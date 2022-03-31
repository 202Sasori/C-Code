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
    public partial class Product : Form
    {
        /// <summary>
        /// Tạo thêm biến chứa chuỗi kết nối
        /// </summary>
        public string strConectionString; 
        /// Phương thức khởi dựng mặc định với tham số là chuỗi kết nối
        /// </summary>
        /// <param name="_strConnectionString">Chuỗi kết nối CSDL</param>
        public Product(string _strConnectionString)
        {
            InitializeComponent();
            strConectionString = _strConnectionString;
        }
        public Product()
        {
            InitializeComponent();
        }
        private void Product_Load(object sender, EventArgs e)
        {
            Display();
        }
        public void Display()
        {
            //data.Clear();
            SqlConnection connection = new SqlConnection(strConectionString);
            //connection.Open();
            string text = "select * from Hang";
            SqlCommand cmd = new SqlCommand(text, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            //var reader = cmd.ExecuteReader();
            //data.Load(reader);
            da.Fill(data);
            //Hiển thị thông tin lên datagridview.
            dgvProduct.DataSource = data;
            //DataBinding(data);
            //connection.Close();
        }
        //Display data to textbox when click to record
        public void DataBinding(DataTable data)
        {
            txtIDPr.DataBindings.Add("Text", data, "MaH", true);
            string t = txtIDPr.Text;
            txtNamePr.DataBindings.Add("Text", data, "TenHang", true);
            txtPrice.DataBindings.Add("Text", data, "DonGia", true);
            txtNote.DataBindings.Add("Text", data, "Ghichu", true);
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DAL.clsProduct pr = new DAL.clsProduct(
            txtIDPr.Text, txtNamePr.Text,
            txtPrice.Text, txtNote.Text);
            pr.addProduct(strConectionString);
            Display();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DAL.clsProduct pr = new DAL.clsProduct(
            txtIDPr.Text, txtNamePr.Text,
            txtPrice.Text, txtNote.Text);
            pr.updateProduct(strConectionString);
            Display();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete!", "Delete Document",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DAL.clsProduct pr = new DAL.clsProduct(
                txtIDPr.Text, txtNamePr.Text,
                txtPrice.Text, txtNote.Text);
                pr.deleteProduct(strConectionString);
                MessageBox.Show("Successfully deleted!");
                Display();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            /*
            DAL.clsProduct pr = new DAL.clsProduct(
            txtIDPr.Text, txtNamePr.Text,
            txtPrice.Text, txtNote.Text);
            pr.findByIDProduct(strConectionString);
            */
            //Display();
            SqlConnection connection = new SqlConnection(strConectionString);
            SqlCommand cmd = new SqlCommand("exec sp_findByIDProduct'"+int.Parse(txtIDPr.Text)+"'", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProduct.DataSource = dt;
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
