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
            //Tạo list một generic mới
            List<T> list = new List<T>();
            //
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
        /*
        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                var Iitem = GetItem<T>(row);
                data.Add(Iitem);
            }
            return data;
        }
        private static List<T> GetItem<T>(DataRow dr){
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();
            foreach(DataColumn column in dr.Table.Columns){
            foreach(var pro in temp.GetProperties()){
                if(pro.Name == column.ColumnName)
                pro.SetValue(obj, dr[column.ColumnName], null);  
                else  
                continue; 
                }
            }
            return obj;
        }
        */
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
