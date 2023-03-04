using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exForm
{
    public partial class Form2 : Form
    {
        TextBox txt;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(TextBox t)
        {
            txt = t;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtHVT.Text = txt.Text;
        }
    }
}
