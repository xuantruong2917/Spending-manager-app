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
    public partial class Frm_ChonVi : Form
    {
        public Frm_ChonVi()
        {
            InitializeComponent();
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            string chonvi = cbb_ChonVi.Text;
            string loaivi = cbb_LoaiVi.Text;
            if (cbb_ChonVi.Text == "  ---Nhấp Để Chọn---")
               chonvi= "";
            if (cbb_LoaiVi.Text == "  ---Nhấp Để Chọn---")
                loaivi = "";
            AppPlatform.API.CreateWallet(chonvi,loaivi);


        }
    }
}
