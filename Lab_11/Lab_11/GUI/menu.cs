using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11.GUI
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        public string strConectionString;
        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product product = new GUI.Product();
            this.Hide();
            //Multi form value string connection
            product.strConectionString = strConectionString;
            product.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            this.Hide();
            //Multi form value string connection
            customer.strConectionString = strConectionString;
            customer.ShowDialog();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            this.Hide();
            //Multi form value string connection
            bill.strConectionString = strConectionString;
            bill.ShowDialog();
        }
    }
}
