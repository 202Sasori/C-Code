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
    public partial class AddHangHoa : Form
    {
        public string strConectionString;
        public AddHangHoa(string _strConectionString)
        {
            InitializeComponent();
            strConectionString = _strConectionString;
        }
        public AddHangHoa()
        {
            InitializeComponent();
        }
        private void AddHangHoa_Load(object sender, EventArgs e)
        {
            loadPhanLoai();
            loadNhaCC();
        }
        public void loadPhanLoai()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaLoai, TenLoai FROM PhanLoai", strConectionString);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    string text = dt.Rows[j]["MaLoai"].ToString() + " : " + dt.Rows[j]["TenLoai"].ToString();
                    this.cbbLoai.Items.Add(text);
                    cbbLoai.ValueMember = "MaLoai";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void loadNhaCC()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaNCC, TenNCC FROM NhaCC", strConectionString);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    string text = dt.Rows[j]["MaNCC"].ToString() + " : " + dt.Rows[j]["TenNCC"].ToString();
                    this.cbbNCC.Items.Add(text);
                    cbbNCC.ValueMember = "MaNCC";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DAL.clsClass.clsSanPham sp = new DAL.clsClass.clsSanPham(
            txtMaHang.Text, txtTenHang.Text,
            int.Parse(txtSoLuong.Text), cbbLoai.Text, cbbNCC.Text, int.Parse(txtGia.Text)
            );
            sp.themHangHoa(strConectionString);
        }
    }
}
