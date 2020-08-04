using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;

namespace ReservationProject
{
    public partial class Frm_Bill : Telerik.WinControls.UI.RadForm
    {

        HotelEntities hotelEntities;
        Bill bill;
        BillRow billRow;

        public Frm_Bill()
        {
            InitializeComponent();
        }

        private void Frm_Bill_Load(object sender, EventArgs e)
        {
            T_Num.Focus();
            hotelEntities = new HotelEntities();
            bill = new Bill();
            billRow = new BillRow();
            T_Date.Text = DateTime.Now.ToString();
            T_An.Text = DateTime.Now.Year.ToString(); ;

        }

        private void add()
        {
            bill.Bill_id = T_Num.Text;
            bill.An = Convert.ToInt32(T_An.Text);
            bill.Guest_id = T_NGuest.Text;
            bill.DateBill = Convert.ToDateTime(T_Date.Text);
            bill.TotalCost = Convert.ToDecimal(T_TotCost.Text);
            hotelEntities.Bill.Add(bill);
            hotelEntities.SaveChanges();
        }

        private void update()
        {
            bill.Bill_id = T_Num.Text;
            bill.An = Convert.ToInt32(T_An.Text);
            bill.Guest_id = T_NGuest.Text;
            bill.DateBill = Convert.ToDateTime(T_Date.Text);
            bill.TotalCost = Convert.ToDecimal(T_TotCost.Text);
            hotelEntities.Bill.AddOrUpdate(bill);
            hotelEntities.SaveChanges();
        }

        private void delete()
        {
            string num = T_Num.Text;
            int an = Convert.ToInt32(T_An.Text);
            bill = hotelEntities.Bill.Where(c => c.Bill_id == num && c.An == an).First();
            hotelEntities.Bill.Remove(bill);
            hotelEntities.SaveChanges();
        }

        private void radButton8_Click(object sender, EventArgs e)
        {
            deleteSelectedRow();
        }

        private void deleteSelectedRow()
        {
            foreach (DataGridViewRow row in Reservation_Grid.SelectedRows)
            {
                Reservation_Grid.Rows.RemoveAt(row.Index);
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if (T_Num.Text != "" && T_An.Text != "")
            {
                delete();
                refreshForm();
            }
        }

        private bool validForm()
        {
            Boolean check = true;
            if(T_An.Text == "")
            {
                MessageBox.Show("Il faut saisir l'annees !");
                check = false;
            }
            else
            {
                if(T_NGuest.Text == "")
                {
                    MessageBox.Show("Il faut saisir le guest !");
                    check = false;
                }
            }
            return check;
        }

        private void refreshForm()
        {
            T_Num.Text = "";
            T_NGuest.Text = "";
            T_Reservation.Text = "";
            T_Date.Text = DateTime.Now.ToString();
            T_An.Text = DateTime.Now.Year.ToString(); ;
            Reservation_Grid.Rows.Clear();
        }

        private void Btn_Valid_Click(object sender, EventArgs e)
        {
            if(T_An.Text != "")
            {
                if(T_Num.Text != "" && validForm() && !verifReservationByID())
                {
                    add();
                    addReservationRow();
                    refreshForm();
                }
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            if (T_An.Text != "")
            {
                if (T_Num.Text != "" && validForm())
                {
                    update();
                    addReservationRow();
                    refreshForm();
                }
            }
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            refreshForm();
            T_Num.Focus();
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            Frm_HelpReservation frm = new Frm_HelpReservation(T_Reservation, T_ResAn);
            frm.Show();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Frm_HelpGuest frm = new Frm_HelpGuest("guest",T_NGuest);
            frm.Show();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            Frm_HelpBill frm = new Frm_HelpBill(T_Num, T_An);
            frm.Show();
        }

        private void radButton7_Click(object sender, EventArgs e)
        {
            if (!verifExistReservation())
            {
                getReservationListByID(T_Reservation.Text, Convert.ToInt32(T_ResAn.Text));
                T_TotCost.Text = calcTotReservationCost().ToString();
            }
            else
            {
                MessageBox.Show("Cette Reservation existe dans une autre facture !!");
            }
        }

        private void getReservationListByID(String id, int an)
        {
            using (hotelEntities)
            {
                var query = from reservation in hotelEntities.Reservation
                            where reservation.Reservation_id == id && reservation.An == an
                            select reservation;
                foreach (Reservation q in query)
                    Reservation_Grid.Rows.Insert(Reservation_Grid.RowCount + 1, q.Reservation_id, q.Checkin, q.Checkout, q.Totaldays, q.Reservationcost);
            }
        }

        private void deleteBillRow()
        {
            string num = T_Num.Text;
            int an = Convert.ToInt32(T_An.Text);
            var listBillRow = hotelEntities.BillRow.Where(c => c.Bill_id == num && c.An == an);
            foreach (BillRow r in listBillRow)
                hotelEntities.BillRow.Remove(r);
            hotelEntities.SaveChanges();
        }

        private void addReservationRow()
        {
            deleteBillRow();
            for (int i = 0; i < DT_RESERVATION.Rows.Count; i++)
            {
                billRow.Bill_id = T_Num.Text;
                billRow.An = Convert.ToInt32(T_An.Text);
                billRow.RowNum = Convert.ToInt32(DT_RESERVATION.Rows[i]["NLigne"]);
                billRow.Reservation_id = DT_RESERVATION.Rows[i]["Numero"].ToString();
                billRow.Checkin = Convert.ToDateTime(DT_RESERVATION.Rows[i]["CheckIn"]);
                billRow.Checkout = Convert.ToDateTime(DT_RESERVATION.Rows[i]["CheckOut"]);
                billRow.Totaldays = Convert.ToInt32(DT_RESERVATION.Rows[i]["TotJours"]);
                billRow.Reservationcost = Convert.ToDecimal(DT_RESERVATION.Rows[i]["Cout"]);
                hotelEntities.BillRow.AddOrUpdate(billRow);
                hotelEntities.SaveChanges();
            }
        }

        private decimal calcTotReservationCost()
        {
            decimal mt = 0;
            for (int i = 0; i < DT_RESERVATION.Rows.Count; i++)
                mt += Convert.ToDecimal(DT_RESERVATION.Rows[i]["Cout"]);
            return mt;
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
                T_Date.Focus();
        }

        private void T_Date_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_Reservation.Focus();
        }

        private int increment()
        {
            int n = 0;
            var query = hotelEntities.Bill.Where(c => c.An == Convert.ToInt32(T_An.Text)).Max(c => c.Bill_id);
            n = Convert.ToInt32(query) + 1;
            return n;
        }


        private void TNumKeyPress()
        {
            if (T_An.Text != "")
            {
                getBillByID();
                getBillRow();
            }
        }

        private void getBillByID()
        {
            int an = Convert.ToInt32(T_An.Text);
            var query = from bill in hotelEntities.Bill
                        where bill.Bill_id == T_Num.Text && bill.An == an
                        select bill;
            foreach (Bill q in query)
            {
                T_Num.Text = q.Bill_id;
                T_NGuest.Text = q.Guest_id;
                T_An.Text = q.An.ToString();
                T_Date.Text = q.DateBill.ToString();
                T_TotCost.Text = q.TotalCost.ToString();
            }
        }

        private bool verifReservationByID()
        {
            int an = Convert.ToInt32(T_An.Text);
            var query = from bill in hotelEntities.Bill.Where(c => c.Bill_id == T_Num.Text && c.An == an)
                        select bill;
            if (query.ToList().Count > 0)
                return true;
            return false;
        }

        private void getBillRow()
        {
            int an = Convert.ToInt32(T_An.Text);
            var query = from billRow in hotelEntities.BillRow.Where(c => c.Bill_id == T_Num.Text && c.An == an)
                        select billRow;
            Reservation_Grid.DataSource = query.ToList();
        }

        private bool verifExistReservation()
        {
            int an = Convert.ToInt32(T_An.Text);
            var query = from billRow in hotelEntities.BillRow.Where(c => c.Reservation_id == T_Reservation.Text && c.An == an)
                        select billRow;
            if (query.ToList().Count > 0)
                return true;
            return false;
        }
    }
}
