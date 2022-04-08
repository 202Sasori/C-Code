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
namespace Generic_Test
{
    public partial class Form1 : Form
    {
        DBConnect cn = new DBConnect();
        public Form1()
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
            List < DAL.Product > products = null;
            SqlConnection cnn = cn.Connect();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(@"Select * from Hang", cnn);
            var dataReader = cmd.ExecuteReader();
            products = GetList<DAL.Product>(dataReader);
            if(products!= null)
            {
                dgvProduct.DataSource = products;
            }
        }
    }
}
