using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_2;

namespace WinForm.GUI
{
    public partial class PhanSo2 : Form
    {
        private string tuSo, mauSo;
        public PhanSo2()
        {
            InitializeComponent();
        }
        public PhanSo2(string tuSo, string mauSo)
        {
            InitializeComponent();
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbTu.Text = tuSo.ToString();
            lbMau.Text = mauSo.ToString();
        }
    }
}
