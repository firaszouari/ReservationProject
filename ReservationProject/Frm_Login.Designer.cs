namespace ReservationProject
{
    partial class Frm_Login
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
            this.L_Username = new Telerik.WinControls.UI.RadLabel();
            this.L_password = new Telerik.WinControls.UI.RadLabel();
            this.T_Username = new Telerik.WinControls.UI.RadTextBox();
            this.T_Password = new Telerik.WinControls.UI.RadTextBox();
            this.Btn_Login = new Telerik.WinControls.UI.RadButton();
            this.htmlToolTip1 = new MetroFramework.Drawing.Html.HtmlToolTip();
            this.htmlToolTip2 = new MetroFramework.Drawing.Html.HtmlToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.L_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Username
            // 
            this.L_Username.Location = new System.Drawing.Point(91, 101);
            this.L_Username.Name = "L_Username";
            this.L_Username.Size = new System.Drawing.Size(80, 21);
            this.L_Username.TabIndex = 0;
            this.L_Username.Text = "Username :";
            this.L_Username.ThemeName = "Material";
            // 
            // L_password
            // 
            this.L_password.Location = new System.Drawing.Point(91, 185);
            this.L_password.Name = "L_password";
            this.L_password.Size = new System.Drawing.Size(79, 21);
            this.L_password.TabIndex = 1;
            this.L_password.Text = "Password :";
            this.L_password.ThemeName = "Material";
            // 
            // T_Username
            // 
            this.T_Username.Location = new System.Drawing.Point(256, 101);
            this.T_Username.Name = "T_Username";
            this.T_Username.Size = new System.Drawing.Size(283, 41);
            this.T_Username.TabIndex = 2;
            this.T_Username.ThemeName = "Material";
            this.htmlToolTip1.SetToolTip(this.T_Username, "\r\n");
            this.T_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_Username_KeyPress);
            // 
            // T_Password
            // 
            this.T_Password.Location = new System.Drawing.Point(256, 182);
            this.T_Password.Name = "T_Password";
            this.T_Password.PasswordChar = '*';
            this.T_Password.Size = new System.Drawing.Size(283, 41);
            this.T_Password.TabIndex = 3;
            this.T_Password.ThemeName = "Material";
            this.T_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_Password_KeyPress);
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(304, 269);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(120, 36);
            this.Btn_Login.TabIndex = 4;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.ThemeName = "Material";
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // htmlToolTip1
            // 
            this.htmlToolTip1.OwnerDraw = true;
            this.htmlToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.htmlToolTip1.ToolTipTitle = "Verifier le nom d\'utilisateur";
            // 
            // htmlToolTip2
            // 
            this.htmlToolTip2.OwnerDraw = true;
            this.htmlToolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.htmlToolTip2.ToolTipTitle = "Verifier le password";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 383);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.T_Password);
            this.Controls.Add(this.T_Username);
            this.Controls.Add(this.L_password);
            this.Controls.Add(this.L_Username);
            this.Name = "Frm_Login";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            this.ThemeName = "Material";
            ((System.ComponentModel.ISupportInitialize)(this.L_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadLabel L_Username;
        private Telerik.WinControls.UI.RadLabel L_password;
        private Telerik.WinControls.UI.RadTextBox T_Username;
        private Telerik.WinControls.UI.RadTextBox T_Password;
        private Telerik.WinControls.UI.RadButton Btn_Login;
        private MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;
        private MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip2;
    }
}
