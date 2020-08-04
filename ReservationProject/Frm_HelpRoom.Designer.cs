namespace ReservationProject
{
    partial class Frm_HelpRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.Room_Help_Grid = new MetroFramework.Controls.MetroGrid();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbreLit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbreMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponibilite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Room_Help_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Room_Help_Grid
            // 
            this.Room_Help_Grid.AllowUserToAddRows = false;
            this.Room_Help_Grid.AllowUserToDeleteRows = false;
            this.Room_Help_Grid.AllowUserToResizeRows = false;
            this.Room_Help_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Room_Help_Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Room_Help_Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Room_Help_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Room_Help_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Room_Help_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Room_Help_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Description,
            this.NbreLit,
            this.NbreMax,
            this.Disponibilite});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Room_Help_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Room_Help_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Room_Help_Grid.EnableHeadersVisualStyles = false;
            this.Room_Help_Grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Room_Help_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Room_Help_Grid.Location = new System.Drawing.Point(0, 0);
            this.Room_Help_Grid.Name = "Room_Help_Grid";
            this.Room_Help_Grid.ReadOnly = true;
            this.Room_Help_Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Room_Help_Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Room_Help_Grid.RowHeadersWidth = 51;
            this.Room_Help_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Room_Help_Grid.RowTemplate.Height = 24;
            this.Room_Help_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Room_Help_Grid.Size = new System.Drawing.Size(516, 484);
            this.Room_Help_Grid.TabIndex = 0;
            this.Room_Help_Grid.DoubleClick += new System.EventHandler(this.Room_Help_Grid_DoubleClick);
            this.Room_Help_Grid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Room_Help_Grid_KeyPress);
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 75;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 160;
            // 
            // NbreLit
            // 
            this.NbreLit.DataPropertyName = "NbreLit";
            this.NbreLit.HeaderText = "Nombre Lit";
            this.NbreLit.MinimumWidth = 6;
            this.NbreLit.Name = "NbreLit";
            this.NbreLit.ReadOnly = true;
            // 
            // NbreMax
            // 
            this.NbreMax.DataPropertyName = "NbreMax";
            this.NbreMax.HeaderText = "Nombre Max Guest";
            this.NbreMax.MinimumWidth = 6;
            this.NbreMax.Name = "NbreMax";
            this.NbreMax.ReadOnly = true;
            this.NbreMax.Width = 135;
            // 
            // Disponibilite
            // 
            this.Disponibilite.DataPropertyName = "Disponibilite";
            this.Disponibilite.HeaderText = "Disponibilite";
            this.Disponibilite.MinimumWidth = 6;
            this.Disponibilite.Name = "Disponibilite";
            this.Disponibilite.ReadOnly = true;
            this.Disponibilite.Width = 130;
            // 
            // Frm_HelpRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 484);
            this.Controls.Add(this.Room_Help_Grid);
            this.Name = "Frm_HelpRoom";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Frm_HelpRoom";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.Frm_HelpRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Room_Help_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private MetroFramework.Controls.MetroGrid Room_Help_Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbreLit;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbreMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponibilite;
    }
}
