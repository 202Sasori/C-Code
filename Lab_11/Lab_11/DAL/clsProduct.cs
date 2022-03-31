using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11.DAL
{
    internal class clsProduct : IProduct 
    {
        public string MaH { get; set; }
        public string TenHang { get; set; }
        public string DonGia { get; set; }
        public string GhiChu { get; set; }
        
        public clsProduct(string _maH, string _tenHang, string _donGia, string _ghiChu)
        {
            MaH = _maH;
            TenHang = _tenHang;
            DonGia = _donGia;
            GhiChu = _ghiChu;
        }
        public int addProduct(string strSqlConnection)
        {
            return Ultil.ultil.ExcuteProcedure(
            new string[] { "@MaH", "@TenHang", "@DonGia", "@GhiChu" },
            new object[] { MaH, TenHang, DonGia, GhiChu },
            strSqlConnection, "sp_insertProduct");
        }
        public int updateProduct(string strSqlConnection)
        {
            return Ultil.ultil.ExcuteProcedure(
            new string[] { "@MaH", "@TenHang", "@DonGia", "@GhiChu" },
            new object[] { MaH, TenHang, DonGia, GhiChu },
            strSqlConnection, "sp_updateProduct");
        }
        public int deleteProduct(string strSqlConnection)
        {
            return Ultil.ultil.ExcuteProcedure(
            new string[] { "@MaH" },
            new object[] { MaH },
            strSqlConnection, "sp_deleteProduct");
        }
        public int findByIDProduct(string strSqlConnection)
        {
            return Ultil.ultil.ExcuteProcedure(
            new string[] { "@MaH" },
            new object[] { MaH },
            strSqlConnection, "sp_findByIDProduct");
        }
    }
}
