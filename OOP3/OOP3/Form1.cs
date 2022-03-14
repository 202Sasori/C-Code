using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP3
{
    public partial class Form1 : Form
    {
        int ucln;
        DAL.phanSo ps1 = new DAL.phanSo();
        DAL.phanSo ps2 = new DAL.phanSo();
        DAL.phanSo ps3 = new DAL.phanSo();
        public Form1()
        {
            InitializeComponent();
        }
        public int UCLN(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return UCLN(b, a % b);
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            ps1.TS = Convert.ToInt32(txtTu1.Text);
            ps1.MS = Convert.ToInt32(txtMau1.Text);
            ps2.TS = Convert.ToInt32(txtTu2.Text);
            ps2.MS = Convert.ToInt32(txtMau2.Text);
            ps3 = ps1 + ps2;
            ucln = UCLN(ps3.TS, ps3.MS);
            txtKQT.Text = Convert.ToString(ps3.TS/ucln);
            txtKQM.Text = Convert.ToString(ps3.MS/ucln);
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            ps1.TS = Convert.ToInt32(txtTu1.Text);
            ps1.MS = Convert.ToInt32(txtMau1.Text);
            ps2.TS = Convert.ToInt32(txtTu2.Text);
            ps2.MS = Convert.ToInt32(txtMau2.Text);
            ps3 = ps1 - ps2;
            ucln = UCLN(ps3.TS, ps3.MS);
            txtKQT.Text = Convert.ToString(ps3.TS / ucln);
            txtKQM.Text = Convert.ToString(ps3.MS / ucln);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            ps1.TS = Convert.ToInt32(txtTu1.Text);
            ps1.MS = Convert.ToInt32(txtMau1.Text);
            ps2.TS = Convert.ToInt32(txtTu2.Text);
            ps2.MS = Convert.ToInt32(txtMau2.Text);
            ps3 = ps1 * ps2;
            ucln = UCLN(ps3.TS, ps3.MS);
            txtKQT.Text = Convert.ToString(ps3.TS / ucln);
            txtKQM.Text = Convert.ToString(ps3.MS / ucln);
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            ps1.TS = Convert.ToInt32(txtTu1.Text);
            ps1.MS = Convert.ToInt32(txtMau1.Text);
            ps2.TS = Convert.ToInt32(txtTu2.Text);
            ps2.MS = Convert.ToInt32(txtMau2.Text);
            ps3 = ps1 / ps2;
            ucln = UCLN(ps3.TS, ps3.MS);
            txtKQT.Text = Convert.ToString(ps3.TS / ucln);
            txtKQM.Text = Convert.ToString(ps3.MS / ucln);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DAL.Form2 frm = new DAL.Form2(txtKQT.Text, txtKQM.Text);
            //this.Hide();//Để ẩn form cũ nhá!
            frm.ShowDialog();
        }
    }
}
