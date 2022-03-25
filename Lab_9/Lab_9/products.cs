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
namespace Lab_9
{
    public partial class products : Form
    {
        public products()
        {
            InitializeComponent();
        }
        string strCon = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLBH;User ID=sa;Password=123456@Ab";
        SqlConnection conn = null;
        private void products_Load(object sender, EventArgs e)
        {
            //Connect Database
            conn = new SqlConnection(strCon);
            //Open connect
            conn.Open();
            //Sql Query
            string Query = "Select * from Hang";
            SqlCommand cmd = new SqlCommand(Query, conn);
            //excute query
            var reader  = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            //Close connect
            conn.Close();
        }
    }
}
