using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP3.DAL
{
    public partial class Form2 : Form
    {
        string tu, mau;

        private void Form2_Load(object sender, EventArgs e)
        {
            txtKQT.Text = tu;
            txtKQM.Text = mau;
        }

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string tu, string mau)
        {
            this.tu = tu;
            this.mau = mau;
            InitializeComponent();
        }
    }
}
