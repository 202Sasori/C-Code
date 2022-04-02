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
    public partial class frmDetailCustomer : Form
    {
        public frmDetailCustomer()
        {
            InitializeComponent();
        }

        private void frmDetailCustomer_Load(object sender, EventArgs e)
        {
            BUS.clsReportDetailCustomer report = new BUS.clsReportDetailCustomer();
            report.reportDetailCustomer(crystalReportCustomer, @"..\..\CrystalReport\CrystalReportDetailCustomer.rpt");
        }
    }
}
