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
    public partial class Frm_TraCuuSoDu_ChuyenTienGiuaCacVi : Form
    {
        public int table = 1;
        public Frm_TraCuuSoDu_ChuyenTienGiuaCacVi()
        {
            InitializeComponent();
        }
        public int tuvi=-1, denvi=-1;
        private void Frm_TraCuuSoDu_ChuyenTienGiuaCacVi_Load(object sender, EventArgs e)
        {
            if(table == 0)
            {
                panel1.Visible = false;
                this.Size = new System.Drawing.Size(400,500);
               
            }    
            else
            {
                //panel2.Visible = false;
            }
            List<Wallet> wallets = AppPlatform.API.GetWallets();
            for (int i = 0; i < wallets.Count; i++)
            {
                cbb_TuVi.Items.Add(wallets[i].walletName.ToString());
                cbb_DenVi.Items.Add(wallets[i].walletName.ToString());
            }
            InitListView(LV_Data);
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
            colHead.Text = "Số Dư";
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
                lvsi.Text = wallets[i].balance.ToString();
                lvi.SubItems.Add(lvsi);

                LV.Items.Add(lvi);


            }
        }
        #endregion

        bool check()
        {
            string thongbao = "";
            if (cbb_TuVi.Text == "  ---Nhấp Để Chọn---")
            {
                thongbao = thongbao + "Vui lòng chọn ví chuyển tiền đi ";

            }
            if (cbb_DenVi.Text == "  ---Nhấp Để Chọn---")
            {
                thongbao = thongbao + "\nVui lòng chọn ví nhận tiền";

            }
            if(cbb_DenVi.Text == cbb_TuVi.Text)
            {
                thongbao = thongbao + "Ví chuyển và ví nhận trùng nhau";
            }    
            if (thongbao == "")
                return true;
            else
            {
                MessageBox.Show(thongbao);
                return false;
            }
        }
        #region [ Action_ChuyenTien ]
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_SoTien.Text = "";
            txt_NgayChuyen.Text = "";
            cbb_TuVi.Text = "  ---Nhấp Để Chọn---";
            cbb_DenVi.Text = "  ---Nhấp Để Chọn---";
        }

        private void btn_Chuyen_Click(object sender, EventArgs e)
        {
            if (check())
            {
                List<Wallet> wallets = AppPlatform.API.GetWallets();
                int x = 0,y=0;
                while (x != wallets.Count)
                {
                    if (cbb_TuVi.Text.ToString() == wallets[x].walletName.ToString())
                    {
                        tuvi = x;
                        x = wallets.Count;

                    }

                    else
                        x++;
                }
                while (y != wallets.Count)
                {
                    if (cbb_DenVi.Text.ToString() == wallets[y].walletName.ToString())
                    {
                        denvi = y;
                        y = wallets.Count;
                        // MessageBox.Show(vi.ToString());

                    }
                    else
                        y++;
                }
                if (tuvi != denvi)
                {
                    Wallet wallet_ViTien = wallets[tuvi];
                    Wallet wallet_Bank = wallets[denvi];
                    wallet_ViTien.Transfer(double.Parse(txt_SoTien.Text.ToString()),wallet_Bank,txt_NgayChuyen.Value);
                    
                    
                    LoadDataToListView(wallets);
                }
            }
            
          
        }
        #endregion
    }
}
