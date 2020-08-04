using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReservationProject
{
    public partial class ShapedForm1 : DevExpress.XtraEditors.XtraForm
    {
        public ShapedForm1()
        {
            InitializeComponent();
        }

        private void ShapedForm1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            Frm_Reservation frm_Reservation = new Frm_Reservation();
            frm_Reservation.MdiParent = this;
            frm_Reservation.Show();
        }

        private void accordionControlElement2_Click_1(object sender, EventArgs e)
        {
            Frm_Room frm_Room = new Frm_Room();
            frm_Room.MdiParent = this;
            frm_Room.Show();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            Frm_Guest frm_Guest = new Frm_Guest();
            frm_Guest.MdiParent = this;
            frm_Guest.Show();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            Frm_Employee frm_Employee = new Frm_Employee();
            frm_Employee.MdiParent = this;
            frm_Employee.Show();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            Frm_Service frm_Service = new Frm_Service();
            frm_Service.MdiParent = this;
            frm_Service.Show();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            Frm_Bill frm_Bill = new Frm_Bill();
            frm_Bill.MdiParent = this;
            frm_Bill.Show();
        }

        private void ShapedForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            RadForm1 frm_main = new RadForm1();
            frm_main.MdiParent = this;
            frm_main.Show();
        }

        private void ShapedForm1_Shown(object sender, EventArgs e)
        {

        }

        private void ShapedForm1_Activated(object sender, EventArgs e)
        {
            //RadForm1 frm_main = new RadForm1();
            //frm_main.MdiParent = this;
            //frm_main.Show();
        }
    }
}
