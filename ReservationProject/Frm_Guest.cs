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
    public partial class Frm_Guest : Telerik.WinControls.UI.RadForm
    {
        HotelEntities hotelEntities;
        Guest guest;
        BindingList<string> data;

        public Frm_Guest()
        {
            InitializeComponent();
        }

        private void Frm_Guest_Load(object sender, EventArgs e)
        {          
            hotelEntities = new HotelEntities();
            guest = new Guest();
            T_DateNais.Text = DateTime.Now.Year.ToString(); ;
            data = new BindingList<string>();
            this.data.Add("M.");
            this.data.Add("Mme");
            this.data.Add("Mlle");
            T_State.DataSource = this.data;
            T_State.Text = "M.";
            T_Num.Focus();
        }

        private void add()
        {
            guest.Guest_id = T_Num.Text;
            guest.FirstName = T_FName.Text;
            guest.LastName = T_LName.Text;
            guest.GuestDOB = Convert.ToDateTime(T_DateNais.Text);
            guest.Address = T_Adr.Text;
            guest.City = T_City.Text;
            guest.State = T_State.Text;
            guest.Country = T_Country.Text;
            guest.PhoneNumber = T_NumTel.Text;
            guest.Email = T_Email.Text;
            hotelEntities.Guest.Add(guest);
            hotelEntities.SaveChanges();
        }

        private void delete()
        {
            String id = T_Num.Text;
            guest = hotelEntities.Guest.Where(c => c.Guest_id == id).First();
            hotelEntities.Guest.Remove(guest);
            hotelEntities.SaveChanges();
        }

        private void update()
        {
            guest.Guest_id = T_Num.Text;
            guest.FirstName = T_FName.Text;
            guest.LastName = T_LName.Text;
            guest.GuestDOB = Convert.ToDateTime(T_DateNais.Text);
            guest.Address = T_Adr.Text;
            guest.City = T_City.Text;
            guest.State = T_State.Text;
            guest.Country = T_Country.Text;
            guest.PhoneNumber = T_NumTel.Text;
            guest.Email = T_Email.Text;
            hotelEntities.Guest.AddOrUpdate(guest);
            hotelEntities.SaveChanges();
        }

        private void refreshForm()
        {
            T_Num.Text = "";
            T_FName.Text = "";
            T_LName.Text = "";
            T_Adr.Text = "";
            T_City.Text = "";
            T_State.Text = "";
            T_Country.Text = "";
            T_NumTel.Text = "";
            T_Email.Text = "";
            T_State.Text = "M.";
            T_DateNais.Text = DateTime.Now.Year.ToString(); ;
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
            if (T_Num.Text != "" && validForm() && !verifEmployeeByID())
            {
                add();
                refreshForm();
            }
            else
            {
                MessageBox.Show("Cet Guest est existe deja !");
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
            if (T_FName.Text == "")
            {
                MessageBox.Show("Il faut saisir le nom du guest !");
                check = false;
            }
            else
            {
                if (T_LName.Text == "")
                {
                    MessageBox.Show("Il faut saisir le prenom du guest !");
                    check = false;
                }
                else
                {
                    if (T_Adr.Text == "")
                    {
                        MessageBox.Show("Il faut saisir l'adresse du Guest !");
                        check = false;
                    }
                    else
                    {
                        if (T_City.Text == "")
                        {
                            MessageBox.Show("Il faut saisir la ville !");
                            check = false;
                        }
                        else
                        {
                            if (T_Country.Text == "")
                            {
                                MessageBox.Show("Il faut saisir pays du guest !");
                                check = false;
                            }
                            else
                            {
                                if (T_NumTel.Text == "")
                                {
                                    MessageBox.Show("Il faut saisir le numero de telephone !");
                                    check = false;
                                }
                                else
                                {
                                    if (T_Email.Text == "")
                                    {
                                        MessageBox.Show("Il faut saisir l'email du guest !");
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

        private void T_Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (T_Num.Text == "")
                    T_Num.Text = increment().ToString();
                else
                    TNumKeyPress();
                T_FName.Focus();
            }
        }

        private void T_FName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_LName.Focus();
        }

        private void T_LName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_DateNais.Focus();
        }

        private void T_DateNais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_Adr.Focus();
        }

        private void T_Adr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_City.Focus();
        }

        private void T_City_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_State.Focus();
        }

        private void T_State_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_Country.Focus();
        }

        private void T_Country_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_NumTel.Focus();
        }

        private void T_NumTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_Email.Focus();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            Frm_HelpGuest frm = new Frm_HelpGuest("guest", T_Num);
            frm.Show();
        }

        private int increment()
        {
            int n = 0;
            var query = hotelEntities.Guest.Max(c => c.Guest_id);
            n = Convert.ToInt32(query) + 1;
            return n;
        }

        private void TNumKeyPress()
        {
            getGuestByID();
        }

        private void getGuestByID()
        {
            var query = from guest in hotelEntities.Guest
                        where guest.Guest_id == T_Num.Text
                        select guest;
            foreach (Guest q in query)
            {
                T_Num.Text = q.Guest_id;
                T_FName.Text = q.FirstName;
                T_LName.Text = q.LastName;
                T_DateNais.Text = q.GuestDOB.ToString();
                T_Adr.Text = q.Address;
                T_State.Text = q.State;
                T_City.Text = q.City;
                T_NumTel.Text = q.PhoneNumber;
                T_Country.Text = q.Country;
                T_Email.Text = q.Email;
            }
        }

        private bool verifEmployeeByID()
        {
            var query = from guest in hotelEntities.Guest.Where(c => c.Guest_id == T_Num.Text)
                        select guest;
            if (query.ToList().Count > 0)
                return true;
            return false;
        }
    }
}
