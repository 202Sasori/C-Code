using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11.BUS
{
    class cslReportProduct
    {
        public void reportAllProduct(CrystalReportViewer reportViewer, string CystalReportFilePath)
        {
            ReportDocument report = new ReportDocument();
            report.Load(CystalReportFilePath);
            report.SetDatabaseLogon("sa","123", @"MSI\SQLEXPRESS", "QLBH");
            reportViewer.ReportSource = report;
        }
    }
}
