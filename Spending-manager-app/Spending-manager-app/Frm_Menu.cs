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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            Account account = AppPlatform.API.GetAccountInfo();

            this.Focus();
            this.BringToFront(); 

            lbl_Name.Text = account.fullname;
            List<Wallet> wallets = AppPlatform.API.GetWallets();
             if(wallets.Count > 0)
            {
                btn_ChonVi.Visible = false;
            }

        }



        #region [Chu Nang]

        private void btn_TraCuuSoDu_Click(object sender, EventArgs e)
        {
            Frm_TraCuuSoDu_ChuyenTienGiuaCacVi frm = new Frm_TraCuuSoDu_ChuyenTienGiuaCacVi();
            frm.table = 0;
            frm.Text = "";
            frm.ShowDialog();

        }

        private void btn_ThemVi_Click(object sender, EventArgs e)
        {
            Frm_ChonVi frm = new Frm_ChonVi();
            frm.table = 1;
            frm.Show();
        }

        private void btn_ChuyenTienGiuaCacVi_Click(object sender, EventArgs e)
        {
            Frm_TraCuuSoDu_ChuyenTienGiuaCacVi frm = new Frm_TraCuuSoDu_ChuyenTienGiuaCacVi();
            //frm.table = 1;
            frm.Text = "";
            frm.ShowDialog();
        }

        private void btn_DSChiTien_Click(object sender, EventArgs e)
        {
            Frm_DSChiTien frm = new Frm_DSChiTien();
            frm.ShowDialog();

        }

        private void btn_DSThuTien_Click(object sender, EventArgs e)
        {
            Frm_DSThuTien frm = new Frm_DSThuTien();
            frm.ShowDialog();
        }

        private void btn_DSChoVay_Click(object sender, EventArgs e)
        {
            Frm_DsChoVay_ThuNo frm = new Frm_DsChoVay_ThuNo();
            frm.ShowDialog();
        }

        private void btn_DSDiVay_Click(object sender, EventArgs e)
        {
            Frm_DSDiVay_TraNo frm = new Frm_DSDiVay_TraNo();
            frm.ShowDialog();
        }

        #endregion

        #region [ Thanh Chinh ]
        private void btn_ChonVi_Click(object sender, EventArgs e)
        {
            Frm_ChonVi frm = new Frm_ChonVi();
           // this.Hide();
            frm.ShowDialog();
            btn_ChonVi.Visible = false;
            
        }

        private void btn_ChucNang_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel4.Visible = false;
            
          
            
        }

        private void btn_ThongTinCaNhan_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel4.Visible = true;
            //Frm_ThongTinCaNhan frm = new Frm_ThongTinCaNhan();
            //frm.TopLevel = false;
            //this.panel4.Controls.Add(frm);
            //frm.Show();
            getthongtin();
        }

      

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
        #region [ thông tin ]
        private void getthongtin()
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


        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

}
