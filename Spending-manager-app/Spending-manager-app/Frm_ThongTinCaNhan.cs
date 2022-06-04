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
    public partial class Frm_ThongTinCaNhan : Form
    {
        public Frm_ThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void Frm_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            Account account = AppPlatform.API.GetAccountInfo();
            txt_FullName.Text = account.fullname;
            txt_DiaChi.Text = account.address;
            txt_SDT.Text = account.phone;
            DateTime abc = new DateTime(account.createdOn);
            txt_NgayDK.Text = abc.ToString("dd/MM/yyyy");
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            Account account = AppPlatform.API.GetAccountInfo();
            account.ChangeInfo(txt_FullName.Text, txt_SDT.Text, txt_DiaChi.Text);
        }

        
    }
}
