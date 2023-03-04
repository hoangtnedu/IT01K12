using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6.Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            HANG h = new HANG(txtMaHang.Text,txtTenHang.Text,txtNCC.Text);
            frmHienThi f = new frmHienThi(h);
            f.ShowDialog();
        }
    }
}
