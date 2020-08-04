using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Linq;

namespace ReservationProject
{
    public partial class Frm_HelpGuest : Telerik.WinControls.UI.RadForm
    {

        private String req;
        private RadTextBox T_Num = new RadTextBox();

        public Frm_HelpGuest(String req , RadTextBox T_Num)
        {
            this.req = req;
            this.T_Num = T_Num;

            InitializeComponent();
        }

        private void display()
        {
            if (req.ToUpper().Equals("GUEST"))
                 getGuestList();
            else if (req.ToUpper().Equals("EMPLOYEE"))
                getEmployeeList();
        }

        private void getGuestList()
        {
            using (HotelEntities hotelEntities = new HotelEntities())
            {
                var query = from guest in hotelEntities.Guest
                               select new
                               {
                                    Code = guest.Guest_id,
                                    Nom = guest.FirstName,
                                    Prenom = guest.LastName,
                                    Date_Naissance = guest.GuestDOB,
                                    Ville = guest.City,
                                    NumTelephone = guest.PhoneNumber
                               };
                Guest_Help_Grid.DataSource = query.ToList();
            }
        }

        private void getEmployeeList()
        {
            using (HotelEntities hotelEntities = new HotelEntities())
            {
                var query = from employee in hotelEntities.Employee
                            select new
                            {
                                Code = employee.Employee_id,
                                Nom = employee.FirstName,
                                Prenom = employee.LastName,
                                Date_Naissance = employee.DOB,
                                Ville = employee.City,
                                NumTelephone = employee.PhoneNumber
                            };
                this.Guest_Help_Grid.DataSource = query.ToList();
            } 
        }

        private void Frm_HelpGuest_Load(object sender, EventArgs e)
        {
            Guest_Help_Grid.Focus();
            display();
        }

        private void Guest_Help_Grid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                int selectedrowindex = Guest_Help_Grid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Guest_Help_Grid.Rows[selectedrowindex];
                T_Num.Text = Convert.ToString(selectedRow.Cells["Code"].Value);
                T_Num.Focus();
                this.Close();
            }
        }

        private void Guest_Help_Grid_DoubleClick(object sender, EventArgs e)
        {
            int selectedrowindex = Guest_Help_Grid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Guest_Help_Grid.Rows[selectedrowindex];
            T_Num.Text = Convert.ToString(selectedRow.Cells["Code"].Value);
            T_Num.Focus();
            this.Close();
        }
    }
}
