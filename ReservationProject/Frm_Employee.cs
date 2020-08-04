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
    public partial class Frm_Employee : Telerik.WinControls.UI.RadForm
    {
        HotelEntities hotelEntities;
        Employee employee;
        BindingList<string> data;

        public Frm_Employee()
        {
            InitializeComponent();
        }

        private void Frm_Employee_Load(object sender, EventArgs e)
        {
            T_Num.Focus();
            hotelEntities = new HotelEntities();
            employee = new Employee();
            T_DateNais.Text = DateTime.Now.Year.ToString(); ;
            data = new BindingList<string>();
            this.data.Add("M.");
            this.data.Add("Mme");
            this.data.Add("Mlle");
            T_State.DataSource = this.data;
            T_State.Text = "M.";
        }

        private void add()
        {
            employee.Employee_id = T_Num.Text;
            employee.FirstName = T_FName.Text;
            employee.LastName = T_LName.Text;
            employee.DOB = Convert.ToDateTime(T_DateNais.Text);
            employee.Address = T_Adr.Text;
            employee.City = T_City.Text;
            employee.State = T_State.Text;
            employee.PhoneNumber = T_NTel.Text;
            employee.PayRate = Convert.ToDecimal(T_PayRate.Text);
            employee.JobTitle = T_Title.Text;
            hotelEntities.Employee.Add(employee);
            hotelEntities.SaveChanges();
        }

        private void delete()
        {
            String id = T_Num.Text;
            employee = hotelEntities.Employee.Where(c => c.Employee_id == id).First();
            hotelEntities.Employee.Remove(employee);
            hotelEntities.SaveChanges();
        }

        private void update()
        {
            try 
            { 
                employee.Employee_id = T_Num.Text;
                employee.FirstName = T_FName.Text;
                employee.LastName = T_LName.Text;
                employee.DOB = Convert.ToDateTime(T_DateNais.Text);
                employee.Address = T_Adr.Text;
                employee.City = T_City.Text;
                employee.State = T_State.Text;
                employee.PhoneNumber = T_NTel.Text;
                employee.PayRate = Convert.ToDecimal(T_PayRate.Text);
                employee.JobTitle = T_Title.Text;
                hotelEntities.Employee.AddOrUpdate(employee);
                hotelEntities.SaveChanges();
            }  
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)  
            {  
                Exception raise = dbEx;  
                foreach (var validationErrors in dbEx.EntityValidationErrors)  
                {  
                    foreach (var validationError in validationErrors.ValidationErrors)  
                    {  
                                string message = string.Format("{0}:{1}",
                                    validationErrors.Entry.Entity.ToString(),
                                    validationError.ErrorMessage);
                        // raise a new exception nesting  
                        // the current instance as InnerException  
                        raise = new InvalidOperationException(message, raise);
                    }
                }

                MessageBox.Show(raise.ToString());  
            } 
        }

        private void refreshForm()
        {
            T_Num.Text = "";
            T_FName.Text = "";
            T_LName.Text = "";
            T_Adr.Text = "";
            T_City.Text = "";
            T_State.Text = "";
            T_NTel.Text = "";
            T_PayRate.Text = "";
            T_Title.Text = "";
            T_State.Text = "M.";
            T_DateNais.Text = DateTime.Now.Year.ToString(); ;
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {

            if (T_Num.Text != "" && validFrom())
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
            if (T_Num.Text != "" && validFrom() && !verifEmployeeByID())
            {
                add();
                refreshForm();
            }
            else
            {
                MessageBox.Show("Cette Employer est existe Deja !");
            }

        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            refreshForm();
            T_Num.Focus();
        }

        private bool validFrom()
        {
            Boolean check = true;
            if (T_FName.Text == "")
            {
                MessageBox.Show("Il faut saisir le nom !");
                check = false;
            }
            else
            {
                if (T_LName.Text == "")
                {
                    MessageBox.Show("Il faut saisir le Prenom !");
                    check = false;
                }
                else
                {

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
                T_State.Focus();
        }

        private void T_State_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_City.Focus();
        }

        private void T_City_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_Adr.Focus();
        }

        private void T_Adr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_NTel.Focus();
        }

        private void T_NTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_PayRate.Focus();
        }

        private void T_PayRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                T_Title.Focus();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Frm_HelpGuest frm = new Frm_HelpGuest("employee", T_Num);
            frm.Show();
        }

        private int increment()
        {
            int n = 0;
            var query = hotelEntities.Employee.Max(c => c.Employee_id);
            n = Convert.ToInt32(query) + 1;
            return n;
        }

        private void TNumKeyPress()
        {
            getEmployeeByID();
        }

        private void getEmployeeByID()
        {
            var query = from employee in hotelEntities.Employee
                        where employee.Employee_id == T_Num.Text
                        select employee;
            foreach (Employee q in query)
            {
                T_Num.Text = q.Employee_id;
                T_FName.Text = q.FirstName;
                T_LName.Text = q.LastName;
                T_DateNais.Text = q.DOB.ToString();
                T_Adr.Text = q.Address;
                T_State.Text = q.State;
                T_City.Text = q.City;
                T_NTel.Text = q.PhoneNumber;
                T_PayRate.Text = q.PayRate.ToString();
                T_Title.Text = q.JobTitle;
            }
        }

        private bool verifEmployeeByID()
        {
            var query = from employee in hotelEntities.Employee.Where(c => c.Employee_id == T_Num.Text)
                        select employee;
            if (query.ToList().Count > 0)
                return true;
            return false;
        }
    }
}
