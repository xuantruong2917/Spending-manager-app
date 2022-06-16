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
    public partial class Frm_DSThuTien : Form
    {
        public Frm_DSThuTien()
        {
            InitializeComponent();
        }
        public int vi = -1;

        private void Frm_DSThuTien_Load(object sender, EventArgs e)
        {
            InitListView(LV_Data);
            // -------Get top database with Amount---------------
            //LoadDataToListView(Products_Data.List(20));
            // -------Get all database---------------
            // LoadDataToListView(Products_Data.List());


            List<Wallet> wallets = AppPlatform.API.GetWallets();
            //cbb_Vi.Text = wallets.Count.ToString();
            for (int i = 0; i < wallets.Count; i++)
            {
                cbb_Vi.Items.Add(wallets[i].walletName.ToString());
            }        
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
            colHead.Text = "Số Tiền Thu";
            colHead.Width = 100;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Nội Dung Thu";
            colHead.Width = 100;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Thời Gian Thu";
            colHead.Width = 100;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

        }
        #endregion

        #region [ Process Data ]
        private void LoadDataToListView(List<Transaction> transactions)
        {
            this.Cursor = Cursors.WaitCursor;
            ListView LV = LV_Data;
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;

            LV.Items.Clear();
            int x = 1;
            for (int i = 0; i < transactions.Count; i++)
            {
                if (transactions[i].amount < 0)
                    continue;
                lvi = new ListViewItem();
                lvi.Text = (x ++).ToString();

                lvi.ForeColor = Color.DarkBlue;
                lvi.BackColor = Color.White;

                lvi.ImageIndex = 0;

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = transactions[i].walletName.ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = transactions[i].amount.ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = transactions[i].info;
                lvi.SubItems.Add(lvsi);

                DateTime abc = new DateTime(transactions[i].createdOn);
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = abc.ToString();
                lvi.SubItems.Add(lvsi);


                LV.Items.Add(lvi);

                
            }
        }
        #endregion


        private void btn_Load_Click(object sender, EventArgs e)
        {
            if (cbb_Vi.Text == "  ---Nhấp Để Chọn---" || cbb_Vi.Text == "")
            {
                MessageBox.Show("Vui long chon vi");
                return;
            }

            else
            {
                List<Wallet> wallets = AppPlatform.API.GetWallets();
                int x = 0;
                while (x != wallets.Count)
                {
                    if (cbb_Vi.Text == wallets[x].walletName.ToString())
                    {
                        vi = x;
                        x = wallets.Count;
                    }
                    else
                        x++;
                }
                if (vi > -1)
                {
                    Wallet wallet = wallets[vi];
                    List<Transaction> transactions = wallet.GetTransactions();
                    LoadDataToListView(transactions);
                    return;
                }
            }
                
        }

        #region [ Action ]

        private void LV_Data_ItemActivate(object sender, EventArgs e)
        {
            txt_SoTienThu.Text = LV_Data.SelectedItems[0].SubItems[2].Text;
            txt_NoiDungThu.Text = LV_Data.SelectedItems[0].SubItems[3].Text;
            txt_NgayThu.Text = LV_Data.SelectedItems[0].SubItems[4].Text;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
           
            string thongbao = "";
            if (txt_SoTienThu.Text == "")
                thongbao = thongbao + "Vui lòng nhập số tiền thu";
            if (double.Parse(txt_SoTienThu.Text) <= 0)
                thongbao = thongbao + "\nVui lòng nhập lại số tiền thu";
            if (thongbao != "")
                MessageBox.Show(thongbao);
            else
            {
                List<Wallet> wallets = AppPlatform.API.GetWallets();
                Wallet wallet = wallets[vi];

                wallet.Deposit(double.Parse(txt_SoTienThu.Text), txt_NoiDungThu.Text, this.txt_NgayThu.Value);

                //------------
                wallet.Load();
                List<Transaction> transactions = wallet.GetTransactions();
                LoadDataToListView(transactions);
            }
        }
        #endregion


    }
}
