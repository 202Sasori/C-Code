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
namespace Generic_Test.GUI
{
    public partial class Bill : Form
    {
        //Tạo kết nối tới cơ sở dữ liệu
        DBConnect cn = new DBConnect();
        public Bill()
        {
            InitializeComponent();
        }
        //Tạo class generic để lưu dữ liệu từ cơ sở dữ liệu
        private List<T> GetList<T>(IDataReader reader)
        {
            List<T> list = new List<T>();
            while (reader.Read())
            {
                var type = typeof(T);
                T obj = (T)Activator.CreateInstance(type);
                foreach (var prop in type.GetProperties())
                {
                    var propType = prop.PropertyType;
                    prop.SetValue(obj, Convert.ChangeType(reader[prop.Name].ToString(), propType));
                }
                list.Add(obj);
            }
            return list;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<DAL.Bill> customers = null;
            SqlConnection cnn = cn.Connect();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(@"Select * from HoaDon", cnn);
            var dataReader = cmd.ExecuteReader();
            customers = GetList<DAL.Bill>(dataReader);
            if (customers != null)
            {
                dgvBill.DataSource = customers;
            }
        }
    }
}
