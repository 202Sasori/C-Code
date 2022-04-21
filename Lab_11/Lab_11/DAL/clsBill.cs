using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11.DAL
{
    internal class clsBill: IBill
    {
        public string MaHD { get; set; }
        public string MaKH { get; set; }
        public string NgayHD { get; set; }
        public string GhiChu { get; set; }
        public clsBill(string _maHD, string _maKH, string _ngayHD, string _ghiChu)
        {
            MaHD = _maHD;
            MaKH = _maKH;
            NgayHD = _ngayHD;
            GhiChu = _ghiChu;
        }
        public int addBill(string strSqlConnection)
        {
            return Ultil.ultil.ExcuteProcedure(
           new string[] { "@MaHD", "@MaKH", "@NgayHD", "@GhiChu" },
           new object[] { MaHD, MaKH, NgayHD, GhiChu },
           strSqlConnection,
           "sp_insertBill");
        }
        public int updateBill(string strSqlConnection)
        {
            return Ultil.ultil.ExcuteProcedure(
           new string[] { "@MaHD", "@MaKH", "@NgayHD", "@GhiChu" },
           new object[] { MaHD, MaKH, NgayHD, GhiChu },
           strSqlConnection,
           "sp_updateBill");
        }
        public int deleteBill(string strSqlConnection)
        {
            return Ultil.ultil.ExcuteProcedure(
           new string[] { "@MaHD" },
           new object[] { MaHD },
           strSqlConnection,
           "sp_deleteBill");
        }
        public int findByIDBill(string strSqlConnection)
        {
            return Ultil.ultil.ExcuteProcedure(
           new string[] { "@MaHD" },
           new object[] { MaHD },
           strSqlConnection,
           "sp_findByIDBill");
        }
    }
}
