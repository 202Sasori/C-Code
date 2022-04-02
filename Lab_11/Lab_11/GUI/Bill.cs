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

namespace Lab_11.GUI
{
    public partial class Bill : Form
    {
        /// <summary>
        /// Tạo thêm biến chứa chuỗi kết nối
        /// </summary>
        public string strConectionString; 
        /// <summary>
        /// Phương thức khởi dựng mặc định với tham số là chuỗi kết nối
        /// </summary>
        /// <param name="_strConnectionString">Chuỗi kết nối CSDL</param>
        public Bill(string _strConnectionString)
        {
            InitializeComponent();
            strConectionString = _strConnectionString;
        }
        public Bill()
        {
            InitializeComponent();
        }
        public void Display()
        {
            //data.Clear();
            SqlConnection connection = new SqlConnection(strConectionString);
            //connection.Open();
            string text = "select * from HoaDon";
            SqlCommand cmd = new SqlCommand(text, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            //var reader = cmd.ExecuteReader();
            //data.Load(reader);
            da.Fill(data);
            //Hiển thị thông tin lên datagridview.
            dgvBill.DataSource = data;
            //DataBinding(data);
            //connection.Close();
        }
        //Display data to textbox when click to record
        public void DataBinding(DataTable data)
        {
            txtIDBill.DataBindings.Add("Text", data, "MaHD", true);
            string t = txtIDBill.Text;
            txtIDCus.DataBindings.Add("Text", data, "MaKH", true);
            txtDateBill.DataBindings.Add("Text", data, "NgayHD", true);
            txtNote.DataBindings.Add("Text", data, "Ghichu", true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DAL.clsBill bill = new DAL.clsBill(
            txtIDBill.Text, txtIDCus.Text, 
            txtDateBill.Text, txtNote.Text
            );
            bill.addBill(strConectionString);
            Display();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DAL.clsBill bill = new DAL.clsBill(
            txtIDBill.Text, txtIDCus.Text,
            txtDateBill.Text, txtNote.Text
            );
            bill.updateBill(strConectionString);
            Display();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DAL.clsBill bill = new DAL.clsBill(
            txtIDBill.Text, txtIDCus.Text,
            txtDateBill.Text, txtNote.Text
            );
            bill.deleteBill(strConectionString);
            Display();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(strConectionString);
            SqlCommand cmd = new SqlCommand("exec sp_findByIDBill'" + int.Parse(txtIDBill.Text) + "'", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBill.DataSource = dt;
        }

        private void Bill_Load(object sender, EventArgs e)
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

        private void lbReport_Click(object sender, EventArgs e)
        {
            GUI.frmSellInMarch sellInMarch = new GUI.frmSellInMarch();
            sellInMarch.ShowDialog();
        }
    }
}
