using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace ReservationProject
{
    public partial class Frm_Reservation : Telerik.WinControls.UI.RadForm
    {
        HotelEntities hotelEntities;
        Reservation reservation;
        ReservationRow reservationRow;

        public Frm_Reservation()
        {
            InitializeComponent();
        }

        private void Frm_Reservation_Load(object sender, EventArgs e)
        {
            T_Num.Focus();
            hotelEntities = new HotelEntities();
            reservation = new Reservation();
            reservationRow = new ReservationRow();
            T_Checkin.Text = DateTime.Now.ToString();
            T_Checkout.Text = DateTime.Now.ToString();
            T_An.Text = DateTime.Now.Year.ToString(); ;
            //verifRoomChechIn();
            //switchRoomCheckout();
            //switchRoomAvailable();
        }

        private void refreshForm()
        {
            T_Num.Text = "";
            T_An.Text = DateTime.Now.Year.ToString(); ;
            T_NGuest.Text = "";
            T_NEmp.Text = "";
            T_NRoom.Text = "";
            T_NTotJour.Text = "";
            T_Checkin.Text = DateTime.Now.ToString();
            T_Checkout.Text = DateTime.Now.ToString();
            T_TotCost.Text = "";
            Service_Grid.Rows.Clear();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            if (T_An.Text != "")
            {
                if (T_Num.Text != "" && validForm())
                {
                    update();
                    addReservationRow();
                    if (Convert.ToDateTime(T_Checkin.Text).Date == DateTime.Now.Date)
                        updateRoomState("Reserved");
                    else
                        updateRoomState("Occupied");
                    refreshForm();
                }
            }
        }

        private void add()
        {
            reservation.Reservation_id = T_Num.Text;
            reservation.An = Convert.ToInt32(T_An.Text);
            reservation.Guest_id = T_NGuest.Text;
            reservation.Emplyee_id = T_NEmp.Text;
            reservation.RoomNum = Convert.ToInt32(T_NRoom.Text);
            reservation.Checkin = Convert.ToDateTime(T_Checkin.Text);
            reservation.Checkout = Convert.ToDateTime(T_Checkout.Text);
            reservation.Totaldays = Convert.ToInt32(T_NTotJour.Text);
            reservation.Reservationcost = Convert.ToDecimal(T_TotCost.Text);
            hotelEntities.Reservation.Add(reservation);
            hotelEntities.SaveChanges();
        }


        private void delete()
        {
            string num = T_Num.Text;
            int an = Convert.ToInt32(T_An.Text);
            reservation = hotelEntities.Reservation.Where(c => c.Reservation_id == num && c.An == an).First();
            hotelEntities.Reservation.Remove(reservation);
            hotelEntities.SaveChanges();
        }

        private void update()
        {
            reservation.Reservation_id = T_Num.Text;
            reservation.An = Convert.ToInt32(T_An.Text);
            reservation.Guest_id = T_NGuest.Text;
            reservation.Emplyee_id = T_NEmp.Text;
            reservation.RoomNum = Convert.ToInt32(T_NRoom.Text);
            reservation.Checkin = Convert.ToDateTime(T_Checkin.Text);
            reservation.Checkout = Convert.ToDateTime(T_Checkout.Text);
            reservation.Totaldays = Convert.ToInt32(T_NTotJour.Text);
            reservation.Reservationcost = Convert.ToDecimal(T_TotCost.Text);
            hotelEntities.Reservation.AddOrUpdate(reservation);
            hotelEntities.SaveChanges();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if (T_An.Text != "" && T_Num.Text != "")
            {
                delete();
                refreshForm();
            }
        }

        private void Btn_Valid_Click(object sender, EventArgs e)
        {
            if (T_An.Text != "")
            {
                if (T_Num.Text != "" && validForm() && !verifReservationByID())
                {
                    add();
                    addReservationRow();
                    if (Convert.ToDateTime(T_Checkin.Text).Date == DateTime.Now.Date)
                        updateRoomState("Reserved");
                    else
                        updateRoomState("Occupied");

                    refreshForm();
                }
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Frm_HelpGuest frm = new Frm_HelpGuest("guest",T_NGuest);
            frm.Show();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            Frm_HelpGuest frm = new Frm_HelpGuest("employee", T_NEmp);
            frm.Show();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            Frm_HelpRoom frm = new Frm_HelpRoom(T_NRoom);
            frm.Show();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            Frm_HelpReservation frm = new Frm_HelpReservation(T_Num, T_An);
            frm.Show();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            refreshForm();
            T_Num.Focus();
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            Frm_HelpService frm = new Frm_HelpService(T_Service);
            frm.Show();
        }

        private void getServiceListByID(String id)
        {
            var query = from service in hotelEntities.Service
                        where service.Service_id == id
                        select service;
            foreach (Service q in query)
            {
                //Service_Grid.Rows.Insert(Service_Grid.RowCount+1,q.Service_id, q.ServiceName, q.ServiceCost);
                DT_SERVICE.Rows[DT_SERVICE.Rows.Count]["NLigne"] = (DT_SERVICE.Rows.Count + 1).ToString();
                DT_SERVICE.Rows[DT_SERVICE.Rows.Count]["Code"] = q.Service_id;
                DT_SERVICE.Rows[DT_SERVICE.Rows.Count]["Nom"] = q.ServiceName;
                DT_SERVICE.Rows[DT_SERVICE.Rows.Count]["Cost"] = q.ServiceCost.ToString();
            }
        }

        private void radButton7_Click(object sender, EventArgs e)
        {
            getServiceListByID(T_Service.Text);
            T_TotCost.Text = calcCost().ToString();
        }

        private void deleteReservationRow()
        {
            string num = T_Num.Text;
            int an = Convert.ToInt32(T_An.Text);
            var listRservRow = hotelEntities.ReservationRow.Where(c => c.Reservation_id == num && c.An == an);
            foreach(ReservationRow r in listRservRow)
                hotelEntities.ReservationRow.Remove(r);
            hotelEntities.SaveChanges();
        }

        private void addReservationRow()
        {
            deleteReservationRow();
            for (int i = 0; i<DT_SERVICE.Rows.Count; i++)
            {
                reservationRow.Reservation_id = T_Num.Text;
                reservationRow.An = Convert.ToInt32(T_An.Text);
                reservationRow.RowNum = Convert.ToInt32(DT_SERVICE.Rows[i]["NLigne"]);
                reservationRow.Service_id = DT_SERVICE.Rows[i]["Code"].ToString();
                reservationRow.ServiceName = DT_SERVICE.Rows[i]["Nom"].ToString();
                reservationRow.ServiceCost = Convert.ToDecimal(DT_SERVICE.Rows[i]["Cost"]);
                hotelEntities.ReservationRow.AddOrUpdate(reservationRow);
                hotelEntities.SaveChanges();
            }
        }

        private bool validForm()
        {
            Boolean check =true;
            if(T_An.Text == "")
            {
                MessageBox.Show("Il faut saisir l'anneé !");
                check = false;
            }
            else
            {
                if(T_NGuest.Text == "")
                {
                    MessageBox.Show("Il faut saisir le Guest !");
                    check = false;
                }
                else
                {
                    if(T_NEmp.Text == "")
                    {
                        MessageBox.Show("Il faut saisir l'employer !");
                        check = false;
                    }
                    else
                    {
                        if(T_NRoom.Text == "")
                        {
                            MessageBox.Show("Il faut saisir la chambre !");
                            check = false;
                        }
                        else
                        {
                            if (T_NTotJour.Text == "")
                            {
                                MessageBox.Show("Il faut saisir le nombre du jours !");
                                check = false;
                            }
                            else
                            {

                                if ((Convert.ToDateTime(T_Checkout.Text).Date - Convert.ToDateTime(T_Checkin.Text).Date).TotalDays < 0)
                                {
                                    MessageBox.Show("La date du checkIn depasse la date du checkOut !");
                                    check = false;
                                }
                                else
                                {
                                    if (verifReservationValidDate())
                                    {
                                        MessageBox.Show("Cette chambre est reserver pour cette date !!");
                                        check = false;
                                    }
                                }

                            }
                        }
                    }
                }
            }
            return check;
        }

        private decimal calcCost()
        {
            decimal mt = 0;
            mt = Convert.ToInt32(T_NTotJour.Text) * getRoomCost() + calcTotServiceCost();
            return mt;
        }

        private decimal calcTotServiceCost()
        {
            decimal mt = 0;
            for (int i = 0; i < DT_SERVICE.Rows.Count; i++)
                mt += Convert.ToDecimal(DT_SERVICE.Rows[i]["Cost"]);
            return mt;
        }

        private int increment()
        {
            int n = 0;
            int an = Convert.ToInt32(T_An.Text);
            var query = hotelEntities.Reservation.Where(c => c.An == an).Max(c => c.Reservation_id);
            n = Convert.ToInt32(query) + 1;
            return n;
        }

        private void T_Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (T_Num.Text == "")
                    T_Num.Text = increment().ToString();
                else
                    TNumKeyPress();
                T_NGuest.Focus();
            }
        }

        private void T_NGuest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_NEmp.Focus();
        }

        private void T_NEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_NRoom.Focus();
        }

        private void T_NTotJour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                T_Checkin.Focus();
                T_TotCost.Text = calcCost().ToString();
            }
        }

        private void T_NRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_NTotJour.Focus();
        }

        private void T_Checkin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_Checkout.Focus();
        }

        private void T_Checkout_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_Service.Focus();
        }

        private void T_Service_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                getServiceListByID(T_Service.Text);
                Service_Grid.Focus();
            }
        }

        private void radButton8_Click(object sender, EventArgs e)
        {
            deleteSelectedRow();
        }

        private void deleteSelectedRow()
        {
            foreach (DataGridViewRow row in Service_Grid.SelectedRows)
            {
                Service_Grid.Rows.RemoveAt(row.Index);
            }
        }

        private void T_Checkin_ValueChanged(object sender, EventArgs e)
        {
            T_NTotJour.Text = (Convert.ToDateTime(T_Checkout.Text).Date - Convert.ToDateTime(T_Checkin.Text).Date).TotalDays.ToString();
        }

        private void T_Checkout_ValueChanged(object sender, EventArgs e)
        {
            T_NTotJour.Text = (Convert.ToDateTime(T_Checkout.Text).Date - Convert.ToDateTime(T_Checkin.Text).Date).TotalDays.ToString();
        }

        private void TNumKeyPress()
        {
            if (T_An.Text != "")
            {
                getReservationByID();
                getReservationRow();
            }
        }

        private void getReservationByID()
        {
            var query = from reservation in hotelEntities.Reservation
                        where reservation.Reservation_id == T_Num.Text && reservation.An == Convert.ToInt32(T_An.Text)
                        select reservation;
            foreach (Reservation q in query)
            {
                T_Num.Text = q.Reservation_id;
                T_NGuest.Text = q.Guest_id;
                T_NRoom.Text = q.RoomNum.ToString();
                T_NEmp.Text = q.Emplyee_id;
                T_NTotJour.Text = q.Totaldays.ToString();
                T_An.Text = q.An.ToString();
                T_Checkin.Text = q.Checkin.ToString();
                T_Checkout.Text = q.Checkout.ToString();
                T_TotCost.Text = q.Reservationcost.ToString();
            }
        }

        private bool verifReservationByID()
        {
            int an = Convert.ToInt32(T_An.Text);
            var query = from reservation in hotelEntities.Reservation.Where(c => c.Reservation_id == T_Num.Text && c.An == an)
                        select reservation;
            if (query.ToList().Count > 0)
                return true;
            return false;
        }

        private decimal getRoomCost()
        {
            decimal cost = 0;
            int nRoom = Convert.ToInt32(T_NRoom.Text);
            if(T_NRoom.Text != "")
            {
                var query = from room in hotelEntities.Room.Where(c => c.RoomNum == nRoom)
                            select room;
                foreach (Room q in query)
                    if(q != null)
                        cost = Convert.ToDecimal(q.RoomCost);
            }
            return cost;
        }

        private bool verifReservationValidDate()
        {
            int nRoom = Convert.ToInt32(T_NRoom.Text);
            var query = from reservation in hotelEntities.Reservation.Where(c => c.RoomNum == nRoom && ((Convert.ToDateTime(T_Checkin.Text).Date >= Convert.ToDateTime(c.Checkin).Date || Convert.ToDateTime(T_Checkin.Text).Date <= Convert.ToDateTime(c.Checkout).Date) || (Convert.ToDateTime(T_Checkout.Text).Date >= Convert.ToDateTime(c.Checkin).Date || Convert.ToDateTime(T_Checkout.Text).Date <= Convert.ToDateTime(c.Checkout).Date)))
                        select reservation;
            if (query.ToList().Count > 0)
                return true;
            return false;
        }

        private void updateRoomState(String state)
        {
            int nRoom = Convert.ToInt32(T_NRoom.Text);
            var query = from room in hotelEntities.Room.Where(c => c.RoomNum == nRoom)
                        select room;
            foreach (Room q in query)
            {
                q.Availability = state;
                hotelEntities.Room.AddOrUpdate(q);
            }
            hotelEntities.SaveChanges();
        }
       
        private void getReservationRow()
        {
            int an = Convert.ToInt32(T_An.Text);
            var query = from reservationRow in hotelEntities.ReservationRow.Where(c => c.Reservation_id == T_Num.Text && c.An == an)
                        select reservationRow;
            Service_Grid.DataSource = query.ToList();
        }

        private void verifRoomChechIn()
        {
            var query = from reservation in hotelEntities.Reservation
                        join room in hotelEntities.Room on reservation.RoomNum equals room.RoomNum
                        where reservation.Checkin.Date == DateTime.Now.Date
                        select room;
            foreach(Room q in query)
            {
                q.Availability = "Reserved";
                hotelEntities.Room.AddOrUpdate(q);
            }
            hotelEntities.SaveChanges();
        }

        private void switchRoomCheckout()
        {
            var query = from reservation in hotelEntities.Reservation
                        join room in hotelEntities.Room on reservation.RoomNum equals room.RoomNum
                        where reservation.Checkout.Date == DateTime.Now.Date
                        select room;
            foreach (Room q in query)
            {
                q.Availability = "CheckOut";
                hotelEntities.Room.AddOrUpdate(q);
            }
            hotelEntities.SaveChanges();
        }

        private void switchRoomAvailable()
        {
            var query = from reservation in hotelEntities.Reservation
                        join room in hotelEntities.Room on reservation.RoomNum equals room.RoomNum
                        where reservation.Checkout.Date <= DateTime.Now.Date && room.Availability.ToUpper() != "AVAILABLE"
                        select room;
            foreach (Room q in query)
            {
                q.Availability = "Available";
                hotelEntities.Room.AddOrUpdate(q);
            }
            hotelEntities.SaveChanges();
        }
    }
}
