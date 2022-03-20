using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class number : Form
    {
        public number()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TextBox[] txt = new TextBox[] { txtResult, txtNumber1, txtNumber2 };
            DAL.deleteTextBox.delete(txt);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            BUS.Sum sum = new BUS.Sum(txtNumber1, txtNumber2);
            txtResult.Text = sum.Add().ToString();
        }
    }
}
