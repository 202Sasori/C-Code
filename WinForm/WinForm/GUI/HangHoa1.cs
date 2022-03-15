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
    public partial class HangHoa1 : Form
    {
        public HangHoa1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI.HangHoa2 frm = new GUI.HangHoa2(textMH.Text, textTenHang.Text, textDonGia.Text);
            frm.ShowDialog();
        }

        private void HangHoa1_Load(object sender, EventArgs e)
        {

        }
    }
}
