using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.GUI
{
    public partial class HangHoa : Form
    {
        public string strConectionString;// = @"Data Source = MSI\SQLEXPRESS;Initial Catalog = BTL_QLBH; Persist Security Info=True;User ID = sa; Password=123";
        public HangHoa()
        {
            InitializeComponent();
        }
        public HangHoa(string _strConnectionString)
        {
            InitializeComponent();
            strConectionString = _strConnectionString;
        }

        private void HangHoa1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            SqlConnection connection = new SqlConnection(strConectionString);
            string text = "select * from v_chiTietHangHoa";
            SqlCommand cmd = new SqlCommand(text, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            da.Fill(data);
            dgvHangHoa.DataSource = data;
            dgvHangHoa.Columns[0].Width = 100;
            dgvHangHoa.Columns[1].Width = 300;
            dgvHangHoa.AllowUserToResizeColumns = false;
            dgvHangHoa.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThemMoi_Click_1(object sender, EventArgs e)
        {
            GUI.AddHangHoa addHang = new GUI.AddHangHoa(strConectionString);
            addHang.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon xoa khong!", "Delete Document", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(textTimKiem.Text))
                {
                    MessageBox.Show("Vui long nhap Ma hang de xoa");
                    textTimKiem.Focus();
                }
                DAL.clsClass.clsSanPham sp = new DAL.clsClass.clsSanPham(textTimKiem.Text);
                sp.xoaHangHoa(strConectionString);
                MessageBox.Show("Xoa thanh cong san pham co ma " + textTimKiem.Text);
                loadData();
            }
            /*
            SqlConnection connection = new SqlConnection(strConectionString);
            SqlCommand cmd = new SqlCommand("exec sp_deleteHangHoa'" + textTimKiem.Text + "'", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHangHoa.DataSource = dt;
            loadData();
            */
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(strConectionString);
            SqlCommand cmd = new SqlCommand("exec sp_selectHangHoa'" + textTimKiem.Text + "'", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (string.IsNullOrEmpty(textTimKiem.Text))
            {
                MessageBox.Show("Vui long nhap Ma hang tim kiem");
                textTimKiem.Focus();
            }
            if (dt.Rows.Count > 0)
            {
                dgvHangHoa.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Ma hang " + textTimKiem.Text + " khong ton tai!");
            }
            
        }
    }
}
