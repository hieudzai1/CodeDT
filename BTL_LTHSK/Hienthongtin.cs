using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTHSK
{
    public partial class Hienthongtin : Form
    {
        public Hienthongtin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLKH qlkh = new QLKH();
            qlkh.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quanlynhacungcap qlncc = new Quanlynhacungcap();
            qlncc.Show();
        }

        private void btnBCD_Click(object sender, EventArgs e)
        {
            FormBCdon BC1 = new FormBCdon();
            BC1.Show();
        }

        private void btnBCN_Click(object sender, EventArgs e)
        {
            Baocaonhom1 BC2 = new Baocaonhom1();
            BC2.Show();
        }
    }
}
