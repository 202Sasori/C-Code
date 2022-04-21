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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            BUS.clsReportCustomer report = new BUS.clsReportCustomer();
            report.reportCustomer(crystalReportCustomer, @"..\..\CrystalReport\CrystalReportCustomer.rpt");
        }
    }
}
