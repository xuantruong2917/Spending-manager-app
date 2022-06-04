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
    public partial class Frm_DSDiVay_TraNo : Form
    {
        public Frm_DSDiVay_TraNo()
        {
            InitializeComponent();
        }
        public int vi = -1;
        private void Frm_DSDiVay_TraNo_Load(object sender, EventArgs e)
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
            colHead.Text = "Người Cho Vay";
            colHead.Width = 100;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Nội Dung";
            colHead.Width = 100;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Số Tiền Vay";
            colHead.Width = 100;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Ngày Vay";
            colHead.Width = 100;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Ngày Trả";
            colHead.Width = 100;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Trả Nợ";
            colHead.Width = 100;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);


        }
        #endregion

        #region [ Process Data ]
        private void LoadDataToListView(List<Debt> debts)
        {
            this.Cursor = Cursors.WaitCursor;
            ListView LV = LV_Data;
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;

            LV.Items.Clear();
            for (int i = 0; i < debts.Count; i++)
            {
                if (debts[i].amount < 0)
                    continue;
                lvi = new ListViewItem();
                lvi.Text = (i + 1).ToString();

                lvi.ForeColor = Color.DarkBlue;
                lvi.BackColor = Color.White;

                lvi.ImageIndex = 0;

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = debts[i].walletName.ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = debts[i].lender.ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = debts[i].info;
                lvi.SubItems.Add(lvsi);


                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = debts[i].amount.ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = debts[i].createdOn.ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = debts[i].paymentedOn.ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = debts[i].isPaymented.ToString();
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
                while (x != wallets.Count)
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
                    List<Debt> debts = wallet.GetDebts();
                    LoadDataToListView(debts);
                }
            }
        }

        #region [ Action DiVay ]

        private void LV_Data_ItemActivate(object sender, EventArgs e)
        {
            txt_NguoiChoVay.Text = LV_Data.SelectedItems[0].SubItems[2].Text;
            txt_NoiDung.Text = LV_Data.SelectedItems[0].SubItems[3].Text;
            txt_SoTien.Text = LV_Data.SelectedItems[0].SubItems[4].Text;
            txt_NgayVay.Text = LV_Data.SelectedItems[0].SubItems[5].Text;
            txt_NgayTra.Text = LV_Data.SelectedItems[0].SubItems[6].Text;
            cb_TraTien.Checked = bool.Parse(LV_Data.SelectedItems[0].SubItems[7].Text);

        }

        bool check()
        {
            string thongbao = "";
            if (txt_NguoiChoVay.Text == "")
            {
                thongbao = thongbao + "Vui lòng nhập tên người vay";

            }
            if (txt_SoTien.Text == "")
            {
                thongbao = thongbao + "Vui lòng nhập số tiền cho vay";

            }
            if (thongbao == "")
                return true;
            else
            {
                MessageBox.Show(thongbao);
                return false;
            } 
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (check())
            {
                List<Wallet> wallets = AppPlatform.API.GetWallets();
                Wallet wallet = wallets[vi];

                wallet.CreateDebt(double.Parse(txt_SoTien.Text), txt_NguoiChoVay.Text, txt_NoiDung.Text);

                //------------
                wallet.Load();
                List<Debt> debts = wallet.GetDebts();
                LoadDataToListView(debts);

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
