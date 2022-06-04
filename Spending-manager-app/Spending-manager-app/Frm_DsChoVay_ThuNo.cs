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
    public partial class Frm_DsChoVay_ThuNo : Form
    {
        public Frm_DsChoVay_ThuNo()
        {
            InitializeComponent();
        }
        public int vi = -1;
        private void Frm_DsChoVay_ThuNo_Load(object sender, EventArgs e)
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
            colHead.Text = "Người Vay";
            colHead.Width = 100;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Nội Dung";
            colHead.Width = 100;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Số Tiền Cho Vay";
            colHead.Width = 100;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Ngày Cho Vay";
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
        private void LoadDataToListView(List<Loan> loans)
        {
            this.Cursor = Cursors.WaitCursor;
            ListView LV = LV_Data;
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;

            LV.Items.Clear();
            for (int i = 0; i < loans.Count; i++)
            {
                if (loans[i].amount < 0)
                    continue;
                lvi = new ListViewItem();
                lvi.Text = (i + 1).ToString();

                lvi.ForeColor = Color.DarkBlue;
                lvi.BackColor = Color.White;

                lvi.ImageIndex = 0;

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = loans[i].walletName.ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = loans[i].debtor.ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = loans[i].info;
                lvi.SubItems.Add(lvsi);


                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = loans[i].amount.ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = loans[i].createdOn.ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = loans[i].paymentedOn.ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = loans[i].isPaymented.ToString();
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
                    List<Loan> loans = wallet.GetLoans();
                    LoadDataToListView(loans);
                }
            }
        }
        #region [ Action Chovay ]

        private void LV_Data_ItemActivate(object sender, EventArgs e)
        {
            txt_NguoiVay.Text = LV_Data.SelectedItems[0].SubItems[2].Text;
            txt_NgayChoVay.Text = LV_Data.SelectedItems[0].SubItems[3].Text;
            txt_NoiDung.Text = LV_Data.SelectedItems[0].SubItems[4].Text;
            txt_Sotien.Text = LV_Data.SelectedItems[0].SubItems[5].Text;
            txt_NgayTra.Text = LV_Data.SelectedItems[0].SubItems[6].Text;
            cb_TraTien.Checked = bool.Parse(LV_Data.SelectedItems[0].SubItems[7].Text);
          
        }

        bool check ()
        {
            string thongbao = "";
            if(txt_NguoiVay.Text=="")
            {
                thongbao = thongbao + "Vui lòng nhập tên người vay";
                
            }
            if (txt_Sotien.Text == "")
            {
                thongbao = thongbao + "Vui lòng nhập số tiền cho vay";

            }
            if(thongbao == "")
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

                wallet.CreateLoan(double.Parse(txt_Sotien.Text), txt_NguoiVay.Text,txt_NoiDung.Text);

                //------------
                wallet.Load();
                List<Loan> loans = wallet.GetLoans();
                LoadDataToListView(loans);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region [ ThuNo ]

        #endregion

        
    }
}
