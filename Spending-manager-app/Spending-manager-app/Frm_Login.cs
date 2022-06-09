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
    public partial class Frm_Login : Form
    {
        public bool close = true;
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Sign_in_Click(object sender, EventArgs e)
        {
            Form SignInForm = new Frm_DangKy();
            SignInForm.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
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
               

            bool loginSuccessed = AppPlatform.API.Login(this.username.Text, this.password.Text);
            if (!loginSuccessed)
                MessageBox.Show("Tài khoản không tồn tại hoặc mật khẩu không hợp lệ", "Lỗi đăng nhập");
            else
            {
                //MessageBox.Show("Đăng nhập thành công", "Thông Báo");
                this.close = false;
                this.Close();
            }
        }

    }
}
