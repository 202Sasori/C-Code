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
    public partial class frmReportProduct : Form
    {
        public frmReportProduct()
        {
            InitializeComponent();
        }

        private void frmReportProduct_Load(object sender, EventArgs e)
        {
            BUS.cslReportProduct report = new BUS.cslReportProduct();
            report.reportAllProduct(crystalReportProduct, @"..\..\CrystalReport\CrystalreportAllProduct.rpt");
        }
    }
}
