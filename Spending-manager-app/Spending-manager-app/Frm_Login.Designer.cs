namespace Spending_manager_app
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.btn_Sign_in = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Sign_in
            // 
            this.btn_Sign_in.BackColor = System.Drawing.Color.MidnightBlue;
            resources.ApplyResources(this.btn_Sign_in, "btn_Sign_in");
            this.btn_Sign_in.ForeColor = System.Drawing.Color.White;
            this.btn_Sign_in.Name = "btn_Sign_in";
            this.btn_Sign_in.UseVisualStyleBackColor = false;
            this.btn_Sign_in.Click += new System.EventHandler(this.btn_Sign_in_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.MidnightBlue;
            resources.ApplyResources(this.btn_Login, "btn_Login");
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.ControlLight;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.username, "username");
            this.username.Name = "username";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.ControlLight;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.password, "password");
            this.password.Name = "password";
            // 
            // Frm_Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spending_manager_app.Properties.Resources.Thiết_kế_chưa_có_tên;
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Sign_in);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Sign_in;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
    }
}