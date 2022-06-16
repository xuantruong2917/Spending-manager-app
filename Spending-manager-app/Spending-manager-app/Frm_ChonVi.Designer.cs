namespace Spending_manager_app
{
    partial class Frm_ChonVi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_TaoMoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ChonVi = new System.Windows.Forms.TextBox();
            this.cbb_ChonVi = new System.Windows.Forms.ComboBox();
            this.cbb_LoaiVi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_LoaiVi = new System.Windows.Forms.TextBox();
            this.LV_Data = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(497, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 582);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_Sua);
            this.panel2.Controls.Add(this.btn_TaoMoi);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_ChonVi);
            this.panel2.Controls.Add(this.cbb_ChonVi);
            this.panel2.Controls.Add(this.cbb_LoaiVi);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_LoaiVi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 582);
            this.panel2.TabIndex = 32;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(213, 414);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(179, 73);
            this.btn_Sua.TabIndex = 26;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_TaoMoi
            // 
            this.btn_TaoMoi.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_TaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TaoMoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoMoi.ForeColor = System.Drawing.Color.White;
            this.btn_TaoMoi.Location = new System.Drawing.Point(213, 321);
            this.btn_TaoMoi.Name = "btn_TaoMoi";
            this.btn_TaoMoi.Size = new System.Drawing.Size(179, 70);
            this.btn_TaoMoi.TabIndex = 24;
            this.btn_TaoMoi.Text = "Thêm";
            this.btn_TaoMoi.UseVisualStyleBackColor = false;
            this.btn_TaoMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Gợi Ý:";
            // 
            // txt_ChonVi
            // 
            this.txt_ChonVi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_ChonVi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ChonVi.Location = new System.Drawing.Point(195, 57);
            this.txt_ChonVi.Name = "txt_ChonVi";
            this.txt_ChonVi.Size = new System.Drawing.Size(243, 34);
            this.txt_ChonVi.TabIndex = 20;
            // 
            // cbb_ChonVi
            // 
            this.cbb_ChonVi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbb_ChonVi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ChonVi.FormattingEnabled = true;
            this.cbb_ChonVi.Items.AddRange(new object[] {
            "Momo",
            "Agribank",
            "Bidv",
            "Vietcombank",
            "Tiền mặt"});
            this.cbb_ChonVi.Location = new System.Drawing.Point(195, 98);
            this.cbb_ChonVi.Name = "cbb_ChonVi";
            this.cbb_ChonVi.Size = new System.Drawing.Size(243, 33);
            this.cbb_ChonVi.TabIndex = 27;
            this.cbb_ChonVi.Text = "  ---Nhấp Để Chọn---";
            // 
            // cbb_LoaiVi
            // 
            this.cbb_LoaiVi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbb_LoaiVi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LoaiVi.FormattingEnabled = true;
            this.cbb_LoaiVi.Items.AddRange(new object[] {
            "Bank"});
            this.cbb_LoaiVi.Location = new System.Drawing.Point(195, 229);
            this.cbb_LoaiVi.Name = "cbb_LoaiVi";
            this.cbb_LoaiVi.Size = new System.Drawing.Size(243, 33);
            this.cbb_LoaiVi.TabIndex = 31;
            this.cbb_LoaiVi.Text = "  ---Nhấp Để Chọn---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Loại Ví:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Gợi Ý:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ví Sử Dụng:";
            // 
            // txt_LoaiVi
            // 
            this.txt_LoaiVi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_LoaiVi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoaiVi.Location = new System.Drawing.Point(195, 182);
            this.txt_LoaiVi.Name = "txt_LoaiVi";
            this.txt_LoaiVi.Size = new System.Drawing.Size(243, 34);
            this.txt_LoaiVi.TabIndex = 29;
            // 
            // LV_Data
            // 
            this.LV_Data.Dock = System.Windows.Forms.DockStyle.Left;
            this.LV_Data.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LV_Data.ForeColor = System.Drawing.Color.Navy;
            this.LV_Data.FullRowSelect = true;
            this.LV_Data.GridLines = true;
            this.LV_Data.HideSelection = false;
            this.LV_Data.Location = new System.Drawing.Point(0, 0);
            this.LV_Data.Margin = new System.Windows.Forms.Padding(4);
            this.LV_Data.Name = "LV_Data";
            this.LV_Data.Size = new System.Drawing.Size(497, 582);
            this.LV_Data.TabIndex = 15;
            this.LV_Data.UseCompatibleStateImageBehavior = false;
            this.LV_Data.View = System.Windows.Forms.View.Details;
            this.LV_Data.ItemActivate += new System.EventHandler(this.LV_Data_ItemActivate);
            // 
            // Frm_ChonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spending_manager_app.Properties.Resources.Thiết_kế_chưa_có_tên__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LV_Data);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frm_ChonVi";
            this.ShowIcon = false;
            this.Text = "Chọn ví";
            this.Load += new System.EventHandler(this.Frm_ChonVi_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_TaoMoi;
        private System.Windows.Forms.TextBox txt_ChonVi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LV_Data;
        private System.Windows.Forms.ComboBox cbb_ChonVi;
        private System.Windows.Forms.ComboBox cbb_LoaiVi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_LoaiVi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}