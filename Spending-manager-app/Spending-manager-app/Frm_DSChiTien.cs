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
    public partial class Frm_DSChiTien : Form
    {
        public Frm_DSChiTien()
        {
            InitializeComponent();
        }
        public int vi = -1;
        private void Frm_DSChiTien_Load(object sender, EventArgs e)
        {
            InitListView(LV_Data);

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
            colHead.Text = "Nội Dung";
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
            for (int i = 0; i < transactions.Count; i++)
            {
                if (transactions[i].amount > 0)
                    continue;
                lvi = new ListViewItem();
                lvi.Text = (i + 1).ToString();

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

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = transactions[i].createdOn.ToString();
                lvi.SubItems.Add(lvsi);


                LV.Items.Add(lvi);


            }
        }
        #endregion

        private void btn_Load_Click(object sender, EventArgs e)
        {

            if (cbb_Vi.Text == "")
                MessageBox.Show("Vui long chon vi");
            else
            {
                
                List<Wallet> wallets = AppPlatform.API.GetWallets();
                int x = 0;
                while (x != wallets.Count )
                {
                    if (cbb_Vi.Text.ToString() == wallets[x].walletName.ToString())
                    {
                        vi = x;
                        x = wallets.Count;
                       // MessageBox.Show(vi.ToString());

                    }

                    else
                        x++;
                }
                if (vi > -1)
                {
                    Wallet wallet = wallets[vi];
                    List<Transaction> transactions = wallet.GetTransactions();
                    LoadDataToListView(transactions);
                }
            }
        }

        #region [ Action ]

        private void LV_Data_ItemActivate(object sender, EventArgs e)
        {
            txt_SoTienChi.Text = LV_Data.SelectedItems[0].SubItems[2].Text;
            txt_NoiDungChi.Text = LV_Data.SelectedItems[0].SubItems[3].Text;
            txt_NgayChi.Text = LV_Data.SelectedItems[0].SubItems[4].Text;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (txt_SoTienChi.Text == "")
                MessageBox.Show("Vui lòng nhập số tiền thu");

            List<Wallet> wallets = AppPlatform.API.GetWallets();
            Wallet wallet = wallets[vi];

            wallet.Withdraw(double.Parse(txt_SoTienChi.Text), txt_NoiDungChi.Text);

            //------------
            wallet.Load();
            List<Transaction> transactions = wallet.GetTransactions();
            LoadDataToListView(transactions);
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }



        #endregion

        
    }
}
