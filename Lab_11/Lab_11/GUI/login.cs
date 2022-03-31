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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }
        public string strConnectionString { get; set; }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DAL.clsConnect conn = new DAL.clsConnect(
                txtUser.Text, txtPassword.Text, txtDatabase.Text, cbbServer.Text);
            if (conn.Connect() != null)
            {
                //Gán giá trị cho thuộc tính vừa thêm
                strConnectionString = conn.GetConnectionString();
                //MessageBox.Show(strConnectionString);
                this.Hide();
                menu menu = new menu();
                //Multi form value string connection
                menu.strConectionString = strConnectionString;
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login fail!");
            }
        }
    }
}
