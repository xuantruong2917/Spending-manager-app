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
        public int vi = -1;
        string doitenvi = "";
        public int table = 0;
        private void Frm_ChonVi_Load(object sender, EventArgs e)
        {
            if(table == 0)
                btn_Sua.Visible= false;
            InitListView(LV_Data);

            List<Wallet> wallets = AppPlatform.API.GetWallets();
            //cbb_Vi.Text = wallets.Count.ToString();
           /* for (int i = 0; i < wallets.Count; i++)
            {
                cbb_Vi.Items.Add(wallets[i].walletName.ToString());
            }*/
           LoadDataToListView(wallets);
        }

        #region [ Design Layout ]
        private void InitListView(ListView LV)
        {
            ColumnHeader colHead;
            colHead = new ColumnHeader();
            colHead.Text = "Stt";
            colHead.Width = 50;
            colHead.TextAlign = HorizontalAlignment.Center;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Tên Ví";
            colHead.Width = 100;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Loại Ví";
            colHead.Width = 100;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

        }
        #endregion

        #region [ Process Data ]
        private void LoadDataToListView(List<Wallet> wallets)
        {
            this.Cursor = Cursors.WaitCursor;
            ListView LV = LV_Data;
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;

            LV.Items.Clear();
            for (int i = 0; i < wallets.Count; i++)
            {
                lvi = new ListViewItem();
                lvi.Text = (i + 1).ToString();

                lvi.ForeColor = Color.DarkBlue;
                lvi.BackColor = Color.White;

                lvi.ImageIndex = 0;

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = wallets[i].walletName.ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = wallets[i].type.ToString();
                lvi.SubItems.Add(lvsi);

                LV.Items.Add(lvi);
            }
        }
        #endregion

        #region [ Action ]

        private void LV_Data_ItemActivate(object sender, EventArgs e)
        {
            txt_ChonVi.Text = LV_Data.SelectedItems[0].SubItems[1].Text;
            txt_LoaiVi.Text = LV_Data.SelectedItems[0].SubItems[2].Text.ToString();
            doitenvi = txt_ChonVi.Text;
           
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            string chonvi = txt_ChonVi.Text;
            string loaivi = txt_LoaiVi.Text;
            if (chonvi == "")
            {
                if (cbb_ChonVi.Text != "  ---Nhấp Để Chọn---")
                    chonvi = chonvi + cbb_ChonVi.Text;
            }
            if (loaivi == "")
            {
                if (cbb_LoaiVi.Text != "  ---Nhấp Để Chọn---")
                    loaivi = loaivi + cbb_LoaiVi.Text;
            }
            if (chonvi != "")
            {
                AppPlatform.API.CreateWallet(chonvi, loaivi);
                List<Wallet> wallets = AppPlatform.API.GetWallets();
                LoadDataToListView(wallets);

            }
            else
                MessageBox.Show("Vui lòng chọn loại ví bạn muốn quản lí.");


        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string chonvi = txt_ChonVi.Text;
            string loaivi = txt_LoaiVi.Text;
            if(chonvi != "")
            {
                List<Wallet> wallets = AppPlatform.API.GetWallets();
                int x = 0;
                while (x != wallets.Count)
                {
                    if (doitenvi == wallets[x].walletName.ToString())
                    {
                        vi = x;
                        x = wallets.Count;
                    }
                    else
                        x++;
                }
                wallets[vi].ChangeInfo(chonvi,loaivi);
                //------ Load lại------------
                List<Wallet> walletss = AppPlatform.API.GetWallets();
                LoadDataToListView(walletss);
            }

        }
        #endregion
    }
}
