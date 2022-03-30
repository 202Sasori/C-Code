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

namespace Lab_10.GUI
{
    public partial class frmConnect : Form
    {
        public frmConnect()
        {
            InitializeComponent();
        }
        SqlConnection Conn = null;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = @"Data Source= MSI\SQLEXPRESS;Initial Catalog=QLBH;
            Integrated Security=True";
            try
            {
                Conn.Open();
                lbConnect.Text = "Ket noi window thanh cong!";
                
            }catch (Exception ex)
            {
                lbConnect.Text = "Ket noi that bai" + ex.Message;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             SqlConnection Conn = new SqlConnection();
             Conn.ConnectionString = @"Data Source= MSI\SQLEXPRESS;Initial Catalog=QLBH;
             User ID= sa;Password =123456@Ab"; ;
            try
            {
                Conn.Open();
                lbConnect.Text = "Ket noi login thanh cong!";
            }
            catch (Exception ex)
            {
                lbConnect.Text = "Ket noi that bai" + ex.Message;
            }
        }
    }
}
