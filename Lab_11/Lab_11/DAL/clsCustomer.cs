using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11.DAL
{
    internal class clsCustomer: ICustomer
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string GhiChu { get; set; }
        public clsCustomer(string _maKH, string _tenKH, string _sdt, string _ghiChu)
        {
            MaKH = _maKH;
            TenKH = _tenKH;
            SDT = _sdt;
            GhiChu = _ghiChu;
        }
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
            new string[] { "@MaKH" },
            new object[] { MaKH },
            strSqlConnection,
            "sp_deleteCustomer");
        }
        public int findByIDCustomer(string strSqlConnection)
        {
            return Ultil.ultil.ExcuteProcedure(
            new string[] { "@MaKH" },
            new object[] { MaKH },
            strSqlConnection,
            "sp_findByIDCustomer");
        }
    }
}
