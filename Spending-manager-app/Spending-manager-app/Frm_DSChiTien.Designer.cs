namespace Spending_manager_app
{
    partial class Frm_DSChiTien
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("12323");
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.txt_SoTienChi = new System.Windows.Forms.TextBox();
            this.txt_NoiDungChi = new System.Windows.Forms.TextBox();
            this.txt_NgayChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LV_Data = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Load = new System.Windows.Forms.Button();
            this.cbb_Vi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Apply);
            this.panel1.Controls.Add(this.btn_Create);
            this.panel1.Controls.Add(this.txt_SoTienChi);
            this.panel1.Controls.Add(this.txt_NoiDungChi);
            this.panel1.Controls.Add(this.txt_NgayChi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(500, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 609);
            this.panel1.TabIndex = 14;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(322, 416);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(93, 45);
            this.btn_Delete.TabIndex = 26;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(186, 416);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(95, 45);
            this.btn_Apply.TabIndex = 25;
            this.btn_Apply.Text = "Cập Nhật";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(45, 416);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(88, 45);
            this.btn_Create.TabIndex = 24;
            this.btn_Create.Text = "Tạo Mới";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // txt_SoTienChi
            // 
            this.txt_SoTienChi.Location = new System.Drawing.Point(163, 195);
            this.txt_SoTienChi.Name = "txt_SoTienChi";
            this.txt_SoTienChi.Size = new System.Drawing.Size(241, 22);
            this.txt_SoTienChi.TabIndex = 23;
            // 
            // txt_NoiDungChi
            // 
            this.txt_NoiDungChi.Location = new System.Drawing.Point(163, 104);
            this.txt_NoiDungChi.Name = "txt_NoiDungChi";
            this.txt_NoiDungChi.Size = new System.Drawing.Size(241, 22);
            this.txt_NoiDungChi.TabIndex = 22;
            // 
            // txt_NgayChi
            // 
            this.txt_NgayChi.Location = new System.Drawing.Point(163, 279);
            this.txt_NgayChi.Name = "txt_NgayChi";
            this.txt_NgayChi.Size = new System.Drawing.Size(241, 22);
            this.txt_NgayChi.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số Tiền Chi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nội Dung Chi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ngày Chi:";
            // 
            // LV_Data
            // 
            this.LV_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_Data.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LV_Data.ForeColor = System.Drawing.Color.Navy;
            this.LV_Data.FullRowSelect = true;
            this.LV_Data.GridLines = true;
            this.LV_Data.HideSelection = false;
            this.LV_Data.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.LV_Data.Location = new System.Drawing.Point(0, 0);
            this.LV_Data.Margin = new System.Windows.Forms.Padding(4);
            this.LV_Data.Name = "LV_Data";
            this.LV_Data.Size = new System.Drawing.Size(500, 609);
            this.LV_Data.TabIndex = 13;
            this.LV_Data.UseCompatibleStateImageBehavior = false;
            this.LV_Data.View = System.Windows.Forms.View.Details;
            this.LV_Data.ItemActivate += new System.EventHandler(this.LV_Data_ItemActivate);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.LV_Data);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 609);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Load);
            this.panel3.Controls.Add(this.cbb_Vi);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 76);
            this.panel3.TabIndex = 14;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(365, 15);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(66, 43);
            this.btn_Load.TabIndex = 2;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // cbb_Vi
            // 
            this.cbb_Vi.FormattingEnabled = true;
            this.cbb_Vi.Location = new System.Drawing.Point(113, 22);
            this.cbb_Vi.Name = "cbb_Vi";
            this.cbb_Vi.Size = new System.Drawing.Size(232, 24);
            this.cbb_Vi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chọn ví ";
            // 
            // Frm_DSChiTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_DSChiTien";
            this.Text = "Frm_DSChiTien";
            this.Load += new System.EventHandler(this.Frm_DSChiTien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.TextBox txt_SoTienChi;
        private System.Windows.Forms.TextBox txt_NoiDungChi;
        private System.Windows.Forms.TextBox txt_NgayChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LV_Data;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbb_Vi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Load;
    }
}