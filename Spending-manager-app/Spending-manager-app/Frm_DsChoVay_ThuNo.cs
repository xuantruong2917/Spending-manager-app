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
            int x = 1;
            for (int i = 0; i < loans.Count; i++)
            {
                lvi = new ListViewItem();
                lvi.Text = (x++).ToString();

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
                lvsi.Text = Math.Abs(loans[i].amount).ToString();
                lvi.SubItems.Add(lvsi);

                DateTime abd = new DateTime(loans[i].createdOn);
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = abd.ToString();
                lvi.SubItems.Add(lvsi);

                DateTime abc = new DateTime(loans[i].paymentedOn);
                lvsi = new ListViewItem.ListViewSubItem();
                if (abc.ToString() == "1/1/0001 12:00:00 AM")
                    lvsi.Text = "";
                else
                     lvsi.Text = abc.ToString();
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
            if (cbb_Vi.Text == "  ---Nhấp Để Chọn---")
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
            txt_NgayChoVay.Text = LV_Data.SelectedItems[0].SubItems[5].Text;
            txt_NoiDung.Text = LV_Data.SelectedItems[0].SubItems[3].Text;
            txt_Sotien.Text = LV_Data.SelectedItems[0].SubItems[4].Text;
           
            txt_NgayTra.Text = LV_Data.SelectedItems[0].SubItems[6].Text;
            if (LV_Data.SelectedItems[0].SubItems[6].Text == "1/1/0001 12:00:00 AM")
                txt_NgayTra.Text = "";
            cb_TraTien.Checked = bool.Parse(LV_Data.SelectedItems[0].SubItems[7].Text);
            txt_STT.Text = LV_Data.SelectedItems[0].SubItems[0].Text;
            txt_NguoiTra.Text = LV_Data.SelectedItems[0].SubItems[2].Text;

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
            if (vi == -1)
                return;
            if (check())
            {
                List<Wallet> wallets = AppPlatform.API.GetWallets();
                Wallet wallet = wallets[vi];
                double a = double.Parse(txt_Sotien.Text);
                wallet.CreateLoan(a, txt_NguoiVay.Text,txt_NoiDung.Text,txt_NgayChoVay.Value);

                //------------
                wallet.Load();
                List<Loan> loans = wallet.GetLoans();
                LoadDataToListView(loans);
            }
        }
        #endregion

        #region [ ThuNo ]
        private void btn_ThuNo_Click(object sender, EventArgs e)
        {

            List<Wallet> wallets = AppPlatform.API.GetWallets();
            Wallet wallet = wallets[0];
            List<Loan> loans = wallet.GetLoans();
            int thuno;
            thuno = int.Parse(txt_STT.Text);
            Loan loan = loans[thuno-1];
            wallet.PayLoan(loan,txt_NgayThuNo.Value);

            wallet.Load();
            List<Loan> loanss = wallet.GetLoans();
            LoadDataToListView(loanss);

        }
        #endregion


    }
}
