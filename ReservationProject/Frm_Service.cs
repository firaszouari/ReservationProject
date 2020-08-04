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
    public partial class Frm_Service : Telerik.WinControls.UI.RadForm
    {

        HotelEntities hotelEntities;
        Service service;

        public Frm_Service()
        {
            InitializeComponent();
        }

        private void Frm_Service_Load(object sender, EventArgs e)
        {
            hotelEntities = new HotelEntities();
            service = new Service();
            T_Num.Focus();
        }

        private void add()
        {
            service.Service_id = T_Num.Text;
            service.ServiceName = T_ServName.Text;
            service.ServiceCost = Convert.ToDecimal(T_Cost.Text);
            hotelEntities.Service.Add(service);
            hotelEntities.SaveChanges();
        }

        private void delete()
        {
            String id = T_Num.Text;
            service = hotelEntities.Service.Where(c => c.Service_id == id).First();
            hotelEntities.Service.Remove(service);
            hotelEntities.SaveChanges();
        }

        private void update()
        {
            service.Service_id = T_Num.Text;
            service.ServiceName = T_ServName.Text;
            service.ServiceCost = Convert.ToDecimal(T_Cost.Text);
            hotelEntities.Service.AddOrUpdate(service);
            hotelEntities.SaveChanges();
        }

        private void refreshForm()
        {
            T_Num.Text = "";
            T_ServName.Text = "";
            T_Cost.Text = "";
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
            if (T_Num.Text != "" && validForm() && !verifServiceByID())
            {
                add();
                refreshForm();
            }
            else
            {
                MessageBox.Show("Cette Service existe deja !");
            }

        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            Frm_HelpService frm = new Frm_HelpService(T_Num);
            frm.Show();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            refreshForm();
            T_Num.Focus();
        }

        private bool validForm()
        {
            Boolean check = true;

            if (T_ServName.Text == "")
            {
                MessageBox.Show("Il faut saisir le nom du service !");
                check = false;
            }
            else
            {
                if (T_Cost.Text == "")
                {
                    MessageBox.Show("Il faut saisir le prix du service !");
                    check = false;
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
                T_ServName.Focus();
            }
        }

        private void T_ServName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_Cost.Focus();
        }

        private int increment()
        {
            int n = 0;
            var query = hotelEntities.Service.Max(c => c.Service_id);
            n = Convert.ToInt32(query) + 1;
            return n;
        }

        private void TNumKeyPress()
        {
            getRoomByID();
        }

        private void getRoomByID()
        {
            var query = from room in hotelEntities.Service
                        where room.Service_id == T_Num.Text
                        select room;
            foreach (Service q in query)
            {
                T_Num.Text = q.Service_id;
                T_ServName.Text = q.ServiceName;
                T_Cost.Text = q.ServiceCost.ToString();
            }
        }

        private bool verifServiceByID()
        {
            var query = from service in hotelEntities.Service.Where(c => c.Service_id == T_Num.Text)
                        select service;
            if (query.ToList().Count > 0)
                return true;
            return false;

        }
    }
}
