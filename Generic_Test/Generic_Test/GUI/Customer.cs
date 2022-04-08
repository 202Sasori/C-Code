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
    public partial class Customer : Form
    {
        DBConnect cn = new DBConnect();
        public Customer()
        {
            InitializeComponent();
        }
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
            List<DAL.Customer> customers = null;
            SqlConnection cnn = cn.Connect();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(@"Select * from KhachHang", cnn);
            var dataReader = cmd.ExecuteReader();
            customers = GetList<DAL.Customer>(dataReader);
            if (customers != null)
            {
                dgvCustomer.DataSource = customers;
            }
        }
    }
}
