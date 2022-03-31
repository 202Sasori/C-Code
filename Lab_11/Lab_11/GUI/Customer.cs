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

namespace Lab_11
{
    public partial class Customer : Form
    {
        /// <summary>
        /// Tạo thêm biến chứa chuỗi kết nối
        /// </summary>
        public string strConectionString;
        /// <summary>
        /// Phương thức khởi dựng mặc định với tham số là chuỗi kết nối
        /// </summary>
        /// <param name="_strConnectionString">Chuỗi kết nối CSDL</param>
        public Customer(string _strConnectionString)
        {
            InitializeComponent();
            strConectionString = _strConnectionString;
        }
        public Customer()
        {
            InitializeComponent();
        }
        public void Display()
        {
            //data.Clear();
            SqlConnection connection = new SqlConnection(strConectionString);
            //connection.Open();
            string text = "select * from KhachHang";
            SqlCommand cmd = new SqlCommand(text, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            //var reader = cmd.ExecuteReader();
            //data.Load(reader);
            da.Fill(data);
            //Hiển thị thông tin lên datagridview.
            dgvCustomer.DataSource = data;
            //DataBinding(data);
            //connection.Close();
        }
        //Display data to textbox when click to record
        public void DataBinding(DataTable data)
        {
            txtCusID.DataBindings.Add("Text", data, "MaKH", true);
            string t = txtCusID.Text;
            txtCusName.DataBindings.Add("Text", data, "TenKH", true);
            txtPhoneNum.DataBindings.Add("Text", data, "SDT", true);
            txtNote.DataBindings.Add("Text", data, "Ghichu", true);
        }
        private void txtIDCus_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DAL.clsCustomer customer = new DAL.clsCustomer(
            txtCusID.Text, txtCusName.Text,
            txtPhoneNum.Text, txtNote.Text);
            customer.addCustomer(strConectionString);
            Display();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DAL.clsCustomer customer = new DAL.clsCustomer(
            txtCusID.Text, txtCusName.Text,
            txtPhoneNum.Text, txtNote.Text);
            customer.updateCustomer(strConectionString);
            Display();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DAL.clsCustomer customer = new DAL.clsCustomer(
            txtCusID.Text, txtCusName.Text,
            txtPhoneNum.Text, txtNote.Text);
            customer.deleteCustomer(strConectionString);
            Display();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(strConectionString);
            SqlCommand cmd = new SqlCommand("exec sp_findByIDCustomer'" + int.Parse(txtCusID.Text) + "'", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCustomer.DataSource = dt;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void lbBackMenu_Click(object sender, EventArgs e)
        {

            GUI.menu menu = new GUI.menu();
            menu.strConectionString = strConectionString;
            this.Hide();
            menu.ShowDialog();
        }
    }
}
