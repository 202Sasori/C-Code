using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Lab_10.DAL
{
    internal class clsCustomer: ICustomer
    {
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string GhiChu { get; set; }

        public int addCustomer(string strSqlConnection)
        {
            return Ultil.ultil.ExcuteProcedure(
            new string[] { "@MaKH", "@TenKH", "@SDT", "@GhiChu" },
            new object[] { MaKH, TenKH, SDT, GhiChu },
            strSqlConnection,
            "sp_insertCustomer");
        }
        public int updateCustomer(string strSqlConnection)
        {
            return Ultil.ultil.ExcuteProcedure(
            new string[] { "@MaKH", "@TenKH", "@SDT", "@GhiChu" },
            new object[] { MaKH, TenKH, SDT, GhiChu },
            strSqlConnection,
            "sp_updateCustomer");
        }
        public int deleteCustomer(string strSqlConnection)
        {
            return Ultil.ultil.ExcuteProcedure(
            new string[] { "@MaKH"},
            new object[] { MaKH },
            strSqlConnection,
            "sp_deleteCustomer");
        }
        public int findCustomerByID(string strSqlConnection)
        {
            return Ultil.ultil.ExcuteProcedure(
            new string[] { "@MaKH"},
            new object[] { MaKH },
            strSqlConnection,
            "sp_findByIDCustomer");
        }
    }
}
