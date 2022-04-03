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
    public partial class chart : Form
    {
        public chart()
        {
            InitializeComponent();
        }

        private void chart_Load(object sender, EventArgs e)
        {
            DbChartDataContext db = new DbChartDataContext();
            chartSales.DataSource = db.vw_Sales.ToList();
            chartSales.Series["Sale"].XValueMember = "Thang";
            chartSales.Series["Sale"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartSales.Series["Sale"].YValueMembers = "SoLuong";
            chartSales.Series["Sale"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

        }
    }
}
