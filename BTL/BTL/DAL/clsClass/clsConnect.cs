using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BTL.DAL.Interface;

namespace BTL.DAL.clsClass
{
    public class clsConnect : IConnect
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }
        public string Server { get; set; }
        //Tạo phương thức kết nối
        public clsConnect(string _UserID, string _Password, string _Database, string _Server)
        {
            UserID = _UserID;
            Password = _Password;
            Database = _Database;
            Server = _Server;
        }
        public SqlConnection Connect()
        {
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = getConectionString();
            try
            {
                connect.Open();
            }catch(Exception ex)
            {
                ex.ToString();
                connect = null;
            }
            return connect;
        }
        //Tạo chuỗi kết nối
        public string getConectionString()
        {
            string strConnection;
            strConnection = "";
            strConnection += "Data Source =" + Server + ";";
            strConnection += "Initial Catalog =" + Database + ";";
            //strConnection += "Persist Security Info = True;";
            strConnection += "User ID =" + UserID + ";";
            strConnection += "Password =" + Password + ";";
            return strConnection;
        }
    }
}
