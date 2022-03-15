using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.GUI
{
    public partial class PhanSo1 : Form
    {
        private double x1, x2, y1, y2, a, b, ucln;
        public PhanSo1()
        {
            InitializeComponent();
        }
        public PhanSo1(double x1, double y1, double x2, double y2)
        {
            InitializeComponent();
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OOP_2.phanSo ps = new OOP_2.phanSo();
            ps.inputInfor();
            x1 = Convert.ToDouble(txtTu1.Text);
            x2 = Convert.ToDouble(txtTu2.Text);
            y1 = Convert.ToDouble(txtMau1.Text);
            y2 = Convert.ToDouble(txtMau2.Text);
            a = (x1 * y2) + (x2 * y1);
            b = y1 * y2;
            ucln = USCLN(a, b);
            txtKQTu.Text = Convert.ToString(a/ucln);
            txtKQMau.Text = Convert.ToString(b/ucln);
            

        }
        public static double USCLN(double a, double b)
        {
            if (b == 0)
                return a;
            else
                return USCLN(b, a % b);
        }


        private void PhanSo1_Load(object sender, EventArgs e)
        {

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(txtTu1.Text);
            x2 = Convert.ToDouble(txtTu2.Text);
            y1 = Convert.ToDouble(txtMau1.Text);
            y2 = Convert.ToDouble(txtMau2.Text);
            a = (x1 * y2) - (x2 * y1);
            b = y1 * y2;
            ucln = USCLN(a, b);
            txtKQTu.Text = Convert.ToString(a / ucln);
            txtKQMau.Text = Convert.ToString(b / ucln);
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(txtTu1.Text);
            x2 = Convert.ToDouble(txtTu2.Text);
            y1 = Convert.ToDouble(txtMau1.Text);
            y2 = Convert.ToDouble(txtMau2.Text);
            a = (x1 * y2);
            b = (y1 * x2);
            ucln = USCLN(a, b);
            txtKQTu.Text = Convert.ToString(a / ucln);
            txtKQMau.Text = Convert.ToString(b / ucln);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GUI.PhanSo2 ps2 = new PhanSo2(txtKQTu.Text, txtKQMau.Text);
            ps2.ShowDialog();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(txtTu1.Text);
            x2 = Convert.ToDouble(txtTu2.Text);
            y1 = Convert.ToDouble(txtMau1.Text);
            y2 = Convert.ToDouble(txtMau2.Text);
            a = (x1 * x2);
            b = (y1 * y2);
            ucln = USCLN(a, b);
            txtKQTu.Text = Convert.ToString(a / ucln);
            txtKQMau.Text = Convert.ToString(b / ucln);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
