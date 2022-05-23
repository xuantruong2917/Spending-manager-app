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

        private void btn_TraCuuSoDu_Click(object sender, EventArgs e)
        {
            Frm_TraCuuSoDu_ChuyenTienGiuaCacVi frm = new Frm_TraCuuSoDu_ChuyenTienGiuaCacVi();
            frm.table = 1;
            frm.Text = "";
            frm.ShowDialog();
            
        }

        private void btn_ChucNang_Click(object sender, EventArgs e)
        {
            
            btn_ChuyenTienGiuaCacVi.Visible = true;
            btn_DSChiTien.Visible = true;
            btn_DSChoVay.Visible = true;
            btn_DSDiVay.Visible = true; 
            btn_DSThuTien.Visible = true;
            btn_ThemVi.Visible = true;
            btn_TraCuuSoDu.Visible = true;

        }

        #region [Chu Nang]
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

        private void btn_ChonVi_Click(object sender, EventArgs e)
        {
            Frm_ChonVi frm = new Frm_ChonVi();
            frm.ShowDialog();
        }
    }

}
