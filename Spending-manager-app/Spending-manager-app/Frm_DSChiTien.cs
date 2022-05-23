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

        private void Frm_DSChiTien_Load(object sender, EventArgs e)
        {
            List<Wallet> wallets = AppPlatform.API.GetWallets();



            this.Cursor = Cursors.WaitCursor;
            ListView LV = LV_Data;
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;

            LV.Items.Clear();
            for (int i=0; i<wallets.Count;i++)
            {
                lvi = new ListViewItem();
                lvi.Text = (i + 1).ToString();

                lvi.ForeColor = Color.DarkBlue;
                lvi.BackColor = Color.White;

                lvi.ImageIndex = 0;

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = wallets[i].walletName.ToString();
                lvi.SubItems.Add(lvsi);
            }    

        }
    }
}
