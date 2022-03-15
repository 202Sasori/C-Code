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
    public partial class HangHoa2 : Form
    {
        private string productID, productName, price;

        private void Form2_Load(object sender, EventArgs e)
        {
            lbMaHang.Text = productID.ToString();
            lbTenHang.Text = productName.ToString();
            lbDonGia.Text = price.ToString();
        }

        public HangHoa2(string productID, string productName, string price)
        {
            InitializeComponent();
            this.productID = productID;
            this.productName = productName;
            this.price = price;
        }
    }
}
