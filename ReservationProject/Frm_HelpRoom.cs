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
using System.Reflection;

namespace ReservationProject
{
    public partial class Frm_HelpRoom : Telerik.WinControls.UI.RadForm
    {
        private RadTextBox txt = new RadTextBox();

        public Frm_HelpRoom(RadTextBox txt)
        {
            this.txt = txt;
            InitializeComponent();
        }


        private void getRoomList()
        {
            using(HotelEntities hotelEntities = new HotelEntities())
            {
                var query = from room in hotelEntities.Room
                            select new
                            {
                                Numero = room.RoomNum,
                                Description = room.Description,
                                NbreLit = room.QteBeds,
                                NbreMax = room.MaxOccupancy,
                                Disponibilite = room.Availability
                            };
                Room_Help_Grid.DataSource = query.ToList();
               
            }
        }

        private void Frm_HelpRoom_Load(object sender, EventArgs e)
        {
            Room_Help_Grid.Focus();
            getRoomList();
        }

        private void Room_Help_Grid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int selectedrowindex = Room_Help_Grid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Room_Help_Grid.Rows[selectedrowindex];
                txt.Text = Convert.ToString(selectedRow.Cells["Numero"].Value);
                txt.Focus();
                this.Close();
            }
        }

        private void Room_Help_Grid_DoubleClick(object sender, EventArgs e)
        {
            int selectedrowindex = Room_Help_Grid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Room_Help_Grid.Rows[selectedrowindex];
            txt.Text = Convert.ToString(selectedRow.Cells["Numero"].Value);
            txt.Focus();
            this.Close();
        }
    }
}
