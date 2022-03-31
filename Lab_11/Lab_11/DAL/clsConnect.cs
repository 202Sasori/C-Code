using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Lab_11.DAL
{
    internal class clsConnect : IConnect
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }
        public string Server { get; set; }
        /// <summary>
        /// Phuong thuc khoi dung mac dinh co tham so
        /// </summary>
        /// <param name="_UserID">Ten tai khoan dang nhap vao SQL Server</param>
        /// <param name="_Password">Mat khau dang nhap vao SQL server</param>
        /// <param name="_Database">Ten CSDL trong SQL Server</param>
        /// <param name="_Server">Ten may chu chua SQL server</param>
        public clsConnect(string _UserID, string _Password, string _Database, string _Server)
        {
            UserID = _UserID;
            Password = _Password;
            Database = _Database;
            Server = _Server;
        }
        
        public SqlConnection Connect()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = GetConnectionString();
            try
            {
                Conn.Open();
            }
            catch (Exception)
            {
                Conn = null;
            }
            return Conn;
        }
        /// <summary>
        /// Tạo chuỗi kết nối.
        /// </summary>
        /// <returns>Chuỗi kết nối có 4 thông tin Server, Database, UserID, Passwod</returns>
        public string GetConnectionString()
        {
            string strChainConnect;
            strChainConnect = "";
            strChainConnect += "Data Source =" + Server + ";";
            strChainConnect += "Initial Catalog =" + Database + ";";
            strChainConnect += "User ID =" + UserID + ";";
            strChainConnect += "Password =" + Password + ";";
            return strChainConnect;
        }
    }
}
