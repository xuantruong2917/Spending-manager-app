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
            this.cbb_ChonVi = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_TaoMoi = new System.Windows.Forms.Button();
            this.txt_ChonVi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LV_Data = new System.Windows.Forms.ListView();
            this.txt_LoaiVi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_LoaiVi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(497, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 582);
            this.panel1.TabIndex = 16;
            // 
            // cbb_ChonVi
            // 
            this.cbb_ChonVi.FormattingEnabled = true;
            this.cbb_ChonVi.Items.AddRange(new object[] {
            "Momo",
            "Agribank",
            "Bidv",
            "Vietcombank",
            "Tiền mặt"});
            this.cbb_ChonVi.Location = new System.Drawing.Point(358, 50);
            this.cbb_ChonVi.Name = "cbb_ChonVi";
            this.cbb_ChonVi.Size = new System.Drawing.Size(157, 24);
            this.cbb_ChonVi.TabIndex = 27;
            this.cbb_ChonVi.Text = "  ---Nhấp Để Chọn---";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(378, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 45);
            this.button3.TabIndex = 26;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 45);
            this.button2.TabIndex = 25;
            this.button2.Text = "Cập Nhật";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_TaoMoi
            // 
            this.btn_TaoMoi.Location = new System.Drawing.Point(101, 196);
            this.btn_TaoMoi.Name = "btn_TaoMoi";
            this.btn_TaoMoi.Size = new System.Drawing.Size(88, 45);
            this.btn_TaoMoi.TabIndex = 24;
            this.btn_TaoMoi.Text = "Tạo Mới";
            this.btn_TaoMoi.UseVisualStyleBackColor = true;
            this.btn_TaoMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
            // 
            // txt_ChonVi
            // 
            this.txt_ChonVi.Location = new System.Drawing.Point(132, 50);
            this.txt_ChonVi.Name = "txt_ChonVi";
            this.txt_ChonVi.Size = new System.Drawing.Size(148, 22);
            this.txt_ChonVi.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Gợi Ý:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ví Bạn Sử Dụng:";
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
            // 
            // txt_LoaiVi
            // 
            this.txt_LoaiVi.Location = new System.Drawing.Point(132, 112);
            this.txt_LoaiVi.Name = "txt_LoaiVi";
            this.txt_LoaiVi.Size = new System.Drawing.Size(148, 22);
            this.txt_LoaiVi.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Loại Ví:";
            // 
            // cbb_LoaiVi
            // 
            this.cbb_LoaiVi.FormattingEnabled = true;
            this.cbb_LoaiVi.Items.AddRange(new object[] {
            "Bank"});
            this.cbb_LoaiVi.Location = new System.Drawing.Point(357, 112);
            this.cbb_LoaiVi.Name = "cbb_LoaiVi";
            this.cbb_LoaiVi.Size = new System.Drawing.Size(157, 24);
            this.cbb_LoaiVi.TabIndex = 31;
            this.cbb_LoaiVi.Text = "  ---Nhấp Để Chọn---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Gợi Ý:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_ChonVi);
            this.panel2.Controls.Add(this.cbb_LoaiVi);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_LoaiVi);
            this.panel2.Controls.Add(this.btn_TaoMoi);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.cbb_ChonVi);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 283);
            this.panel2.TabIndex = 32;
            // 
            // Frm_ChonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LV_Data);
            this.Name = "Frm_ChonVi";
            this.Text = "Frm_ChonVi";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
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