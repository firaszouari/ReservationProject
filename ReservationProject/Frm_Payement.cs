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
    public partial class Frm_Payement : Telerik.WinControls.UI.RadForm
    {

        HotelEntities hotelEntities;
        Payement payement;
        BindingList<string> data;

        public Frm_Payement()
        {
            InitializeComponent();
        }

        private void Frm_Payement_Load(object sender, EventArgs e)
        {
            hotelEntities = new HotelEntities();
            payement = new Payement();
            T_Num.Focus();
            T_An.Text = DateTime.Now.Year.ToString(); ;
            this.data = new BindingList<string>();
            this.data.Add("Espece");
            this.data.Add("Cheque");
            this.data.Add("Credit Cart");
            T_PatType.DataSource = this.data;
            T_PatType.Text = "Espece";
        }


        private void add()
        {
            payement.Payaement_id = T_Num.Text;
            payement.An = Convert.ToInt32(T_An.Text);
            payement.PayementType = T_PatType.Text;
            payement.CardNum = Convert.ToInt32(T_CardNum.Text);
            hotelEntities.Payement.Add(payement);
            hotelEntities.SaveChanges();
        }

        private void delete()
        {
            String id = T_Num.Text;
            int an = Convert.ToInt32(T_An.Text);
            payement = hotelEntities.Payement.Where(c => c.Payaement_id == id && c.An == an).First();
            hotelEntities.Payement.Remove(payement);
            hotelEntities.SaveChanges();
        }

        private void update()
        {
            payement.Payaement_id = T_Num.Text;
            payement.An = Convert.ToInt32(T_An.Text);
            payement.PayementType = T_PatType.Text;
            payement.CardNum = Convert.ToInt32(T_CardNum.Text);
            hotelEntities.Payement.AddOrUpdate(payement);
            hotelEntities.SaveChanges();
        }

        private void refreshFrom()
        {
            T_Num.Text = "";
            T_An.Text = DateTime.Now.Year.ToString(); ;
            T_PatType.Text = "Espece";
            T_CardNum.Text = "";
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            if (T_An.Text != "")
            {
                if (T_Num.Text != "")
                {
                    update();
                }
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if (T_An.Text != "" && T_Num.Text != "")
                delete();
        }

        private void Btn_Valid_Click(object sender, EventArgs e)
        {
            if (T_An.Text != "")
            {
                if (T_Num.Text == "")
                {
                    add();
                }
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            //Frm_HelpReservation frm = new Frm_HelpReservation(T_Bill);
            //frm.Show();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            refreshFrom();
            T_Num.Focus();
        }
        
        private bool validForm()
        {
            Boolean check = true;
            if (T_An.Text == "")
            {
                MessageBox.Show("Il faut saisir l'anneé !");
                check = false;
            }
            else
            {
                //if(T_Bill.Text == "")
                //{
                //    MessageBox.Show("Il faut saisir La !");
                //    check = false;
                //}
            }
            return check;
        }

        private void radButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
