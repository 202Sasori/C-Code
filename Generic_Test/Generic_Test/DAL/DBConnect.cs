using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Generic_Test
{
    public class DBConnect
    {
        string connect;
        public DBConnect()
        {
            connect = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLBH;Persist Security Info=True;User ID=sa;Password=123";
        }
        public SqlConnection Connect()
        {
            return new SqlConnection(connect);
        }
    }
}
