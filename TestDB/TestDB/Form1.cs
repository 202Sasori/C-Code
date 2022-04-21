using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.testDataSet.Students);

        }
        string strCon = @"Data Source=MSI\SQLEXPRESS;Initial Catalog = Test; Integrated Security = True";
        SqlConnection con = null;
        private void btnKetNoiWin_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(strCon);
            try
            {
                con.Open();
                MessageBox.Show("Connect to database");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKetNoiSa_Click(object sender, EventArgs e)
        {

        }
    }
}
