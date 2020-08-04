namespace ReservationProject
{
    partial class RadForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.Reservation_Gantt = new DevExpress.XtraGantt.GanttControl();
            ((System.ComponentModel.ISupportInitialize)(this.Reservation_Gantt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Reservation_Gantt
            // 
            this.Reservation_Gantt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reservation_Gantt.Location = new System.Drawing.Point(0, 0);
            this.Reservation_Gantt.Name = "Reservation_Gantt";
            this.Reservation_Gantt.Size = new System.Drawing.Size(1739, 746);
            this.Reservation_Gantt.TabIndex = 0;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1739, 746);
            this.Controls.Add(this.Reservation_Gantt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Reservation";
            this.ThemeName = "Material";
            ((System.ComponentModel.ISupportInitialize)(this.Reservation_Gantt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private DevExpress.XtraGantt.GanttControl Reservation_Gantt;
    }
}