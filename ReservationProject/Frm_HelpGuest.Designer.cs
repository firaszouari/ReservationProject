namespace ReservationProject
{
    partial class Frm_HelpGuest
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.Guest_Help_Grid = new MetroFramework.Controls.MetroGrid();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.radGridView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guest_Help_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Controls.Add(this.Guest_Help_Grid);
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.Size = new System.Drawing.Size(473, 365);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.ThemeName = "Material";
            // 
            // Guest_Help_Grid
            // 
            this.Guest_Help_Grid.AllowUserToAddRows = false;
            this.Guest_Help_Grid.AllowUserToDeleteRows = false;
            this.Guest_Help_Grid.AllowUserToResizeRows = false;
            this.Guest_Help_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Guest_Help_Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Guest_Help_Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Guest_Help_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Guest_Help_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Guest_Help_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Guest_Help_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Nom,
            this.Prenom,
            this.Date_Naissance,
            this.Ville,
            this.NumTelephone});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Guest_Help_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Guest_Help_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Guest_Help_Grid.EnableHeadersVisualStyles = false;
            this.Guest_Help_Grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Guest_Help_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Guest_Help_Grid.Location = new System.Drawing.Point(0, 0);
            this.Guest_Help_Grid.Name = "Guest_Help_Grid";
            this.Guest_Help_Grid.ReadOnly = true;
            this.Guest_Help_Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Guest_Help_Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Guest_Help_Grid.RowHeadersWidth = 51;
            this.Guest_Help_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Guest_Help_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Guest_Help_Grid.Size = new System.Drawing.Size(473, 365);
            this.Guest_Help_Grid.TabIndex = 1;
            this.Guest_Help_Grid.DoubleClick += new System.EventHandler(this.Guest_Help_Grid_DoubleClick);
            this.Guest_Help_Grid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guest_Help_Grid_KeyPress);
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 50;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 85;
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "Prenom";
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.MinimumWidth = 6;
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            this.Prenom.Width = 85;
            // 
            // Date_Naissance
            // 
            this.Date_Naissance.DataPropertyName = "Date_Naissance";
            this.Date_Naissance.HeaderText = "Date Naissance";
            this.Date_Naissance.MinimumWidth = 6;
            this.Date_Naissance.Name = "Date_Naissance";
            this.Date_Naissance.ReadOnly = true;
            this.Date_Naissance.Width = 125;
            // 
            // Ville
            // 
            this.Ville.DataPropertyName = "Ville";
            this.Ville.HeaderText = "Ville";
            this.Ville.MinimumWidth = 6;
            this.Ville.Name = "Ville";
            this.Ville.ReadOnly = true;
            this.Ville.Width = 125;
            // 
            // NumTelephone
            // 
            this.NumTelephone.DataPropertyName = "NumTelephone";
            this.NumTelephone.HeaderText = "Telephone";
            this.NumTelephone.MinimumWidth = 6;
            this.NumTelephone.Name = "NumTelephone";
            this.NumTelephone.ReadOnly = true;
            this.NumTelephone.Width = 75;
            // 
            // Frm_HelpGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 365);
            this.Controls.Add(this.radGridView1);
            this.Name = "Frm_HelpGuest";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "HelpGuest";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.Frm_HelpGuest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.radGridView1.ResumeLayout(false);
            this.radGridView1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guest_Help_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private MetroFramework.Controls.MetroGrid Guest_Help_Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumTelephone;
    }
}
