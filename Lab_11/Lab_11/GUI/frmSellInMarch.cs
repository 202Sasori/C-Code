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
    public partial class frmSellInMarch : Form
    {
        public frmSellInMarch()
        {
            InitializeComponent();
        }

        private void frmSellInMarch_Load(object sender, EventArgs e)
        {
            BUS.clsReportSellInMarch report = new BUS.clsReportSellInMarch();
            report.reportSellInMarch(crystalReportSellInMarch, @"..\..\CrystalReport\CrystalReportSellInMarch.rpt"); ;
        }
    }
}
