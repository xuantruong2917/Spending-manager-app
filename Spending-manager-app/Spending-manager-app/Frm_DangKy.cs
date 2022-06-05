using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spending_manager_app
{
    public partial class Frm_DangKy : Form
    {
        public Frm_DangKy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.fullname.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên", "Có lỗi xảy ra");
                return;
            }

            if (this.phone.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Có lỗi xảy ra");
                return;
            }

            if (this.address.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Có lỗi xảy ra");
                return;
            }

            if (this.username.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập", "Có lỗi xảy ra");
                return;
            }

            if (this.password.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Có lỗi xảy ra");
                return;
            }

            if (this.password.Text == "")
            {
                MessageBox.Show("Vui lòng nhập xác nhận mật khẩu", "Có lỗi xảy ra");
                return;
            }

            if (this.password.Text != this.password_verify.Text)

            {
                MessageBox.Show("Mật khẩu bạn nhập không trùng khớp", "Có lỗi xảy ra");
                return;
            }

            string message = AppPlatform.API.SignUp(this.username.Text, this.password.Text, this.fullname.Text, this.phone.Text, this.address.Text);
            MessageBox.Show(message, "Thông báo");
            this.Close();
        }

        
    }
}
