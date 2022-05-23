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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_TaoMoi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LV_Data = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_TaoMoi);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(549, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 582);
            this.panel1.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Momo",
            "Agribank",
            "Bidv",
            "Vietcombank",
            "Tiền mặt"});
            this.comboBox1.Location = new System.Drawing.Point(163, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 24);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.Text = "  ---Nhấp Để Chọn---";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(311, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 45);
            this.button3.TabIndex = 26;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 45);
            this.button2.TabIndex = 25;
            this.button2.Text = "Cập Nhật";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_TaoMoi
            // 
            this.btn_TaoMoi.Location = new System.Drawing.Point(34, 278);
            this.btn_TaoMoi.Name = "btn_TaoMoi";
            this.btn_TaoMoi.Size = new System.Drawing.Size(88, 45);
            this.btn_TaoMoi.TabIndex = 24;
            this.btn_TaoMoi.Text = "Tạo Mới";
            this.btn_TaoMoi.UseVisualStyleBackColor = true;
            this.btn_TaoMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 22);
            this.textBox1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Gợi Ý:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 97);
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
            this.LV_Data.Size = new System.Drawing.Size(549, 582);
            this.LV_Data.TabIndex = 15;
            this.LV_Data.UseCompatibleStateImageBehavior = false;
            this.LV_Data.View = System.Windows.Forms.View.Details;
            // 
            // Frm_ChonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LV_Data);
            this.Name = "Frm_ChonVi";
            this.Text = "Frm_ChonVi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_TaoMoi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LV_Data;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}