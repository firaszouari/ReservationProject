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
    public partial class Frm_HelpBill : Telerik.WinControls.UI.RadForm
    {
        RadTextBox T_Num = new RadTextBox();
        RadTextBox T_An = new RadTextBox();

        public Frm_HelpBill(RadTextBox T_Num, RadTextBox T_An)
        {
            this.T_Num = T_Num;
            this.T_An = T_An;
            InitializeComponent();
        }

        private void getBillList()
        {
            using (HotelEntities hotelEntities = new HotelEntities())
            {
                var query = from bill in hotelEntities.Bill
                            join guest in hotelEntities.Guest on bill.Guest_id equals guest.Guest_id
                            select new
                            {
                                Numero = bill.Bill_id,
                                An = bill.An,
                                Nom = guest.FirstName,
                                Prenom = guest.LastName,
                                Date = bill.DateBill,
                                Cout = bill.TotalCost
                            };
                Bill_Help_Grid.DataSource = query.ToList();
            } 
        }

        private void Frm_HelpBill_Load(object sender, EventArgs e)
        {
            Bill_Help_Grid.Focus();
            getBillList();
        }

        private void Bill_Help_Grid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int selectedrowindex = Bill_Help_Grid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Bill_Help_Grid.Rows[selectedrowindex];
                T_Num.Text = Convert.ToString(selectedRow.Cells["Numero"].Value);
                T_An.Text = Convert.ToString(selectedRow.Cells["An"].Value);
                T_Num.Focus();
                this.Close();
            }
        }

        private void Bill_Help_Grid_DoubleClick(object sender, EventArgs e)
        {
            int selectedrowindex = Bill_Help_Grid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Bill_Help_Grid.Rows[selectedrowindex];
            T_Num.Text = Convert.ToString(selectedRow.Cells["Numero"].Value);
            T_An.Text = Convert.ToString(selectedRow.Cells["An"].Value);
            T_Num.Focus();
            this.Close();
        }
    }
}
