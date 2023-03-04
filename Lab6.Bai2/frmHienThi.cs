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
    public partial class frmHienThi : Form
    {
        HANG hang;
        public frmHienThi()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Hứng dữ liệu từ form khác
        /// </summary>
        /// <param name="h">Đối tượng được hứng</param>
        public frmHienThi(HANG h)
        {
            hang = h;
            InitializeComponent();
        }

        private void frmHienThi_Load(object sender, EventArgs e)
        {
            txtMaHang.Text = hang.MaHang;
            txtTenHang.Text = hang.TenHang;
            txtNCC.Text = hang.NhaCC;
        }
    }
}
