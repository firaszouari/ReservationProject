using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;

namespace ReservationProject
{
    public partial class Frm_Login : Telerik.WinControls.UI.RadForm
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            using (HotelEntities hotelEntities = new HotelEntities()) 
            {
                var query = from login in hotelEntities.Login
                            where login.Username.Equals(T_Username.Text.Trim()) && login.Password.Equals(T_Password.Text.Trim())
                            select login;

                if (query.ToList().Count > 0)
                {
                    this.Hide();
                    ShapedForm1 frm =new ShapedForm1();
                    frm.Show();
                }
                else
                {
                    htmlToolTip1.Show("Verifier le nom d'utilisateur !", T_Username, 2500);
                    htmlToolTip2.Show("Verifier le Password !", T_Password, 2500);
                    MessageBox.Show("Verifier le nom d'utilisateur et/ou le mot de passe !");
                }
            }
        }

        private void T_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                T_Password.Focus();
            }
        }

        private void T_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                using (HotelEntities hotelEntities = new HotelEntities())
                {
                    var query = from login in hotelEntities.Login
                                where login.Username.Equals(T_Username.Text.Trim()) && login.Password.Equals(T_Password.Text.Trim())
                                select login;

                    if (query.ToList().Count > 0)
                    {
                        this.Hide();
                        ShapedForm1 frm = new ShapedForm1();
                        frm.Show();
                    }
                    else
                    {
                        htmlToolTip1.Show("Verifier le nom d'utilisateur !", T_Username,2500);
                        htmlToolTip2.Show("Verifier le Password !", T_Password,2500);
                    }
                }
            }
        }
    }
}

