using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using Telerik.WinControls.UI;

namespace ReservationProject
{
    public partial class Frm_HelpReservation : Telerik.WinControls.UI.RadForm
    {

        private RadTextBox T_Num = new RadTextBox();
        private RadTextBox T_An = new RadTextBox();

        public Frm_HelpReservation(RadTextBox T_Num, RadTextBox T_An)
        {
            this.T_Num = T_Num;
            this.T_An = T_An;

            InitializeComponent();
        }

        private void getReservationList()
        {
            using (HotelEntities hotelEntities = new HotelEntities())
            {
                var query = from reservation in hotelEntities.Reservation
                            join guest in hotelEntities.Guest on reservation.Guest_id equals guest.Guest_id
                            join employee in hotelEntities.Employee on reservation.Emplyee_id equals employee.Employee_id                            
                            select new
                            {
                                Code = reservation.Reservation_id,
                                An = reservation.An,
                                NomGuest = guest.FirstName,
                                PrenomGuest = guest.LastName,
                                NomEmployee = employee.FirstName,
                                PrenomEmployee = employee.LastName,
                                RoomId = reservation.RoomNum,
                                Checkin = reservation.Checkin,
                                Checkout = reservation.Checkout,
                                TotDays = reservation.Totaldays,
                                TotCost = reservation.Reservationcost
                            };
                Reservation_Help_Grid.DataSource = query.ToList();
            }
        }

        private void Frm_HelpReservation_Load(object sender, EventArgs e)
        {
            Reservation_Help_Grid.Focus();
            getReservationList();
        }

        private void Reservation_Help_Grid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int selectedrowindex = Reservation_Help_Grid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Reservation_Help_Grid.Rows[selectedrowindex];
                T_Num.Text = Convert.ToString(selectedRow.Cells["Code"].Value);
                if(T_An != null)
                    T_An.Text = Convert.ToString(selectedRow.Cells["An"].Value);
                T_Num.Focus();
                this.Close();
            }
        }

        private void Reservation_Help_Grid_DoubleClick(object sender, EventArgs e)
        {
            int selectedrowindex = Reservation_Help_Grid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Reservation_Help_Grid.Rows[selectedrowindex];
            T_Num.Text = Convert.ToString(selectedRow.Cells["Code"].Value);
            if (T_An != null)
                T_An.Text = Convert.ToString(selectedRow.Cells["An"].Value);
            T_Num.Focus();
            this.Close();
        }
    }
}
