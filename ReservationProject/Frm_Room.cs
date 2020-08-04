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
    public partial class Frm_Room : Telerik.WinControls.UI.RadForm
    {

        HotelEntities hotelEntities;
        BindingList<string> data;
        Room room;

        public Frm_Room()
        {
            InitializeComponent();
        }

        private void Frm_Room_Load(object sender, EventArgs e)
        {
            T_Num.Focus();
            hotelEntities = new HotelEntities();
            room = new Room();
            data = new BindingList<string>();
            this.data.Add("Reserved");
            this.data.Add("Occupied");
            this.data.Add("Available");
            this.data.Add("CheckOut");
            T_Dispo.DataSource = this.data;
            T_Dispo.Text = "Available";
            T_Num.Focus();
        }

        private void add()
        {
            room.RoomNum = Convert.ToInt32(T_Num.Text);

            room.Description = T_Desc.Text;
            room.QteBeds = Convert.ToInt32(T_NBed.Text);
            room.MaxOccupancy = Convert.ToInt32(T_NMaxGuest.Text);
            room.Availability = T_Dispo.Text;
            room.RoomCost = Convert.ToDecimal(T_Price.Text);
            hotelEntities.Room.Add(room);
            hotelEntities.SaveChanges();
        }

        private void delete()
        {
            int id = Convert.ToInt32(T_Num.Text);
            room = hotelEntities.Room.Where(c => c.RoomNum == id).First();
            hotelEntities.SaveChanges();
        }

        private void update()
        {
            room.RoomNum = Convert.ToInt32(T_Num.Text);
            room.Description = T_Desc.Text;
            room.QteBeds = Convert.ToInt32(T_NBed.Text);
            room.MaxOccupancy = Convert.ToInt32(T_NMaxGuest.Text);
            room.Availability = T_Dispo.Text;
            room.RoomCost = Convert.ToDecimal(T_Price.Text);
            hotelEntities.Room.AddOrUpdate(room);
            hotelEntities.SaveChanges();
        }

        private void refreshForm()
        {
            T_Num.Text = "";
            T_Desc.Text = "";
            T_NBed.Text = "";
            T_NMaxGuest.Text = "";
            T_Price.Text = "";
            T_Dispo.Text = "Available";
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            if (T_Num.Text != "" && validForm())
            {
                update();
                refreshForm();
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if (T_Num.Text != "")
            {
                delete();
                refreshForm();
            }
        }

        private void Btn_Valid_Click(object sender, EventArgs e)
        {
            if (T_Num.Text != "" && validForm() && !verifRoomByID())
            {
                add();
                refreshForm();
            }
            else
            {
                MessageBox.Show("Cette Chambre existe deja !");
            }
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            refreshForm();
            T_Num.Focus();
        }

        private bool validForm()
        {
            Boolean check = true;
            if (T_Desc.Text == "")
            {
                MessageBox.Show("Il faut saisir Description !");
                check = false;
            }
            else
            {
                if (T_NBed.Text == "")
                {
                    MessageBox.Show("Il faut saisir Nombre de lit !");
                    check = false;
                }
                else
                {
                    if (T_NMaxGuest.Text == "")
                    {
                        MessageBox.Show("Il faut saisir le de maximal des guest !");
                        check = false;
                    }
                    else
                    {
                        if (T_Price.Text == "")
                        {
                            MessageBox.Show("Il faut saisir le prix de chambre !");
                            check = false;
                        }
                    }
                }
            }

            return check;
        }

        private void T_Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (T_Num.Text == "")
                    T_Num.Text = increment().ToString();
                else
                    TNumKeyPress();
                T_Desc.Focus();
            }
        }

        private void T_Desc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_NBed.Focus();
        }

        private void T_NBed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_NMaxGuest.Focus();
        }

        private void T_NMaxGuest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_Dispo.Focus();
        }

        private void T_Dispo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_Price.Focus();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            Frm_HelpRoom frm = new Frm_HelpRoom(T_Num);
            frm.Show();
        }

        private int increment()
        {
            int n = 0;
            var query = hotelEntities.Room.Max(c => c.RoomNum);
            n = query + 1;
            return n;
        }

        private void TNumKeyPress()
        {
            getRoomByID();
        }

        private void getRoomByID()
        {
            int num = Convert.ToInt32(T_Num.Text);
            var query = from room in hotelEntities.Room
                        where room.RoomNum == num
                        select room;
            foreach (Room q in query)
            {
                T_Num.Text = q.RoomNum.ToString();
                T_Desc.Text = q.Description;
                T_NBed.Text = q.QteBeds.ToString();
                T_NMaxGuest.Text = q.MaxOccupancy.ToString();
                T_Dispo.Text = q.Availability;
                T_Price.Text = q.RoomCost.ToString();
            }
        }

        private bool verifRoomByID()
        {
            var query = from room in hotelEntities.Room.Where(c => c.RoomNum == Convert.ToInt32(T_Num.Text))
                        select room;
            if(query.ToList().Count > 0)
                return true;
            return false;
        }
    }
}
