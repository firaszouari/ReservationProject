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
    public partial class Frm_HelpService : Telerik.WinControls.UI.RadForm
    {
        private RadTextBox T_Num = new RadTextBox();

        public Frm_HelpService(RadTextBox T_Num)
        {
            this.T_Num = T_Num;

            InitializeComponent();
        }

        private void getServiceList()
        {
            using (HotelEntities hotelEntities = new HotelEntities())
            {
                var query = from service in hotelEntities.Service
                            select new
                            {
                                Code = service.Service_id,
                                Nom = service.ServiceName,
                                Cost = service.ServiceCost
                            };
                Service_Help_Grid.DataSource = query.ToList();
            }
        }

        private void Frm_HelpService_Load(object sender, EventArgs e)
        {
            Service_Help_Grid.Focus();
            getServiceList();
        }

        private void Service_Help_Grid_DoubleClick(object sender, EventArgs e)
        {
            int selectedrowindex = Service_Help_Grid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Service_Help_Grid.Rows[selectedrowindex];
            T_Num.Text = Convert.ToString(selectedRow.Cells["Code"].Value);
            T_Num.Focus();
            this.Close();
        }

        private void Service_Help_Grid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int selectedrowindex = Service_Help_Grid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Service_Help_Grid.Rows[selectedrowindex];
                T_Num.Text = Convert.ToString(selectedRow.Cells["Code"].Value);
                T_Num.Focus();
                this.Close();
            }
        }
    }
}
