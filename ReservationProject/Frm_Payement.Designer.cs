namespace ReservationProject
{
    partial class Frm_Payement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Payement));
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.Btn_Cancel = new Telerik.WinControls.UI.RadButton();
            this.Btn_Refresh = new Telerik.WinControls.UI.RadButton();
            this.Btn_Valid = new Telerik.WinControls.UI.RadButton();
            this.radButton5 = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.T_PatType = new Telerik.WinControls.UI.RadDropDownList();
            this.T_CardNum = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.T_An = new Telerik.WinControls.UI.RadTextBox();
            this.L_An = new Telerik.WinControls.UI.RadLabel();
            this.T_Num = new Telerik.WinControls.UI.RadTextBox();
            this.L_Num = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Valid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_PatType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_CardNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_An)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_An)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancel.Image")));
            this.Btn_Cancel.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Cancel.Location = new System.Drawing.Point(330, 27);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(78, 75);
            this.Btn_Cancel.TabIndex = 29;
            this.Btn_Cancel.ThemeName = "Material";
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Refresh.Image")));
            this.Btn_Refresh.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Refresh.Location = new System.Drawing.Point(132, 27);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(78, 75);
            this.Btn_Refresh.TabIndex = 33;
            this.Btn_Refresh.ThemeName = "Material";
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Btn_Valid
            // 
            this.Btn_Valid.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Valid.Image")));
            this.Btn_Valid.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Valid.Location = new System.Drawing.Point(34, 27);
            this.Btn_Valid.Name = "Btn_Valid";
            this.Btn_Valid.Size = new System.Drawing.Size(78, 75);
            this.Btn_Valid.TabIndex = 28;
            this.Btn_Valid.ThemeName = "Material";
            this.Btn_Valid.Click += new System.EventHandler(this.Btn_Valid_Click);
            // 
            // radButton5
            // 
            this.radButton5.Image = ((System.Drawing.Image)(resources.GetObject("radButton5.Image")));
            this.radButton5.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton5.Location = new System.Drawing.Point(231, 27);
            this.radButton5.Name = "radButton5";
            this.radButton5.Size = new System.Drawing.Size(78, 75);
            this.radButton5.TabIndex = 65;
            this.radButton5.ThemeName = "Material";
            this.radButton5.Click += new System.EventHandler(this.radButton5_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radButton2);
            this.radGroupBox1.Controls.Add(this.T_PatType);
            this.radGroupBox1.Controls.Add(this.T_CardNum);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.T_An);
            this.radGroupBox1.Controls.Add(this.L_An);
            this.radGroupBox1.Controls.Add(this.T_Num);
            this.radGroupBox1.Controls.Add(this.L_Num);
            this.radGroupBox1.HeaderText = "Payement :";
            this.radGroupBox1.Location = new System.Drawing.Point(34, 136);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(856, 343);
            this.radGroupBox1.TabIndex = 66;
            this.radGroupBox1.Text = "Payement :";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Text = "Payement :";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radButton2
            // 
            this.radButton2.Image = ((System.Drawing.Image)(resources.GetObject("radButton2.Image")));
            this.radButton2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton2.Location = new System.Drawing.Point(394, 48);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(52, 52);
            this.radButton2.TabIndex = 78;
            this.radButton2.ThemeName = "Material";
            // 
            // T_PatType
            // 
            this.T_PatType.Location = new System.Drawing.Point(161, 208);
            this.T_PatType.Name = "T_PatType";
            this.T_PatType.Size = new System.Drawing.Size(207, 41);
            this.T_PatType.TabIndex = 77;
            this.T_PatType.Text = "radDropDownList1";
            this.T_PatType.ThemeName = "Material";
            // 
            // T_CardNum
            // 
            this.T_CardNum.Location = new System.Drawing.Point(567, 211);
            this.T_CardNum.Name = "T_CardNum";
            // 
            // 
            // 
            this.T_CardNum.RootElement.BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.T_CardNum.RootElement.BorderHighlightThickness = 1;
            this.T_CardNum.Size = new System.Drawing.Size(249, 41);
            this.T_CardNum.TabIndex = 75;
            this.T_CardNum.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.T_CardNum.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.T_CardNum.GetChildAt(0))).BorderHighlightThickness = 1;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.T_CardNum.GetChildAt(0))).BackColor = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.T_CardNum.GetChildAt(0).GetChildAt(0))).BorderHighlightThickness = 1;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.T_CardNum.GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.T_CardNum.GetChildAt(0).GetChildAt(2))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.radLabel2.Location = new System.Drawing.Point(434, 213);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(115, 22);
            this.radLabel2.TabIndex = 73;
            this.radLabel2.Text = "Numéro Cart :";
            this.radLabel2.ThemeName = "Material";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.radLabel3.Location = new System.Drawing.Point(5, 213);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(136, 22);
            this.radLabel3.TabIndex = 71;
            this.radLabel3.Text = "Payement Type :";
            this.radLabel3.ThemeName = "Material";
            // 
            // T_An
            // 
            this.T_An.Location = new System.Drawing.Point(262, 58);
            this.T_An.Name = "T_An";
            // 
            // 
            // 
            this.T_An.RootElement.BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.T_An.RootElement.BorderHighlightThickness = 1;
            this.T_An.Size = new System.Drawing.Size(101, 41);
            this.T_An.TabIndex = 70;
            this.T_An.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.T_An.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.T_An.GetChildAt(0))).BorderHighlightThickness = 1;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.T_An.GetChildAt(0))).BackColor = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.T_An.GetChildAt(0).GetChildAt(0))).BorderHighlightThickness = 1;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.T_An.GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.T_An.GetChildAt(0).GetChildAt(2))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            // 
            // L_An
            // 
            this.L_An.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.L_An.Location = new System.Drawing.Point(222, 73);
            this.L_An.Name = "L_An";
            this.L_An.Size = new System.Drawing.Size(13, 22);
            this.L_An.TabIndex = 69;
            this.L_An.Text = "/";
            this.L_An.ThemeName = "Material";
            // 
            // T_Num
            // 
            this.T_Num.Location = new System.Drawing.Point(103, 58);
            this.T_Num.Name = "T_Num";
            // 
            // 
            // 
            this.T_Num.RootElement.BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.T_Num.RootElement.BorderHighlightThickness = 1;
            this.T_Num.Size = new System.Drawing.Size(99, 41);
            this.T_Num.TabIndex = 68;
            this.T_Num.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.T_Num.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.T_Num.GetChildAt(0))).BorderHighlightThickness = 1;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.T_Num.GetChildAt(0))).BackColor = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.T_Num.GetChildAt(0).GetChildAt(0))).BorderHighlightThickness = 1;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.T_Num.GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.T_Num.GetChildAt(0).GetChildAt(2))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            // 
            // L_Num
            // 
            this.L_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.L_Num.Location = new System.Drawing.Point(5, 73);
            this.L_Num.Name = "L_Num";
            this.L_Num.Size = new System.Drawing.Size(78, 22);
            this.L_Num.TabIndex = 67;
            this.L_Num.Text = "Numéro :";
            this.L_Num.ThemeName = "Material";
            // 
            // Frm_Payement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 513);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radButton5);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Btn_Valid);
            this.Name = "Frm_Payement";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Frm_Payement";
            this.ThemeName = "Material";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Payement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Valid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_PatType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_CardNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_An)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_An)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadButton Btn_Cancel;
        private Telerik.WinControls.UI.RadButton Btn_Refresh;
        private Telerik.WinControls.UI.RadButton Btn_Valid;
        private Telerik.WinControls.UI.RadButton radButton5;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadDropDownList T_PatType;
        private Telerik.WinControls.UI.RadTextBox T_CardNum;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox T_An;
        private Telerik.WinControls.UI.RadLabel L_An;
        private Telerik.WinControls.UI.RadTextBox T_Num;
        private Telerik.WinControls.UI.RadLabel L_Num;
    }
}
