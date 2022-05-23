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
        public int table = 0;
        public Frm_TraCuuSoDu_ChuyenTienGiuaCacVi()
        {
            InitializeComponent();
        }

        private void Frm_TraCuuSoDu_ChuyenTienGiuaCacVi_Load(object sender, EventArgs e)
        {
            if(table == 1)
            {
                panel1.Visible = false;
               // panel4.Visible = false;


            }    
        }
    }
}
