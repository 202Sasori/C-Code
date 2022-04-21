using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BTL.DAL.Interface;

namespace BTL.DAL.clsClass
{
    class clsSanPham //: ISanPham
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public int SoLuong { get; set; }
        public string Loai { get; set; }
        public string NhaCC { get; set; }
        public int Gia { get; set; }
        string sqlConectionString;

        public clsSanPham(string _maHang, string _tenHang, int _soLuong, string _loai, string _nhaCC, int _gia)
        {
            MaHang = _maHang;
            TenHang = _tenHang;
            SoLuong = _soLuong;
            Loai = _loai;
            NhaCC = _nhaCC;
            Gia = _gia;
        }
        public clsSanPham(string _maHang)
        {
            MaHang = _maHang;
        }
        public int themHangHoa(string strConnection)
        {
            return Ultil.Ultil.ExecuteProcedure(
            new string[] { "@MaHang", "@TenHang", "@SoLuong", "@MaLoai", "@MaNCC", "@Gia" },
            new object[] { MaHang, TenHang, SoLuong, Loai, NhaCC, Gia },
            strConnection, "sp_insertHangHoa"
            );
        }
        public int suaHangHoa(string strConnection)
        {
            return Ultil.Ultil.ExecuteProcedure(
            new string[] { "@MaHang", "@TenHang", "@SoLuong", "@MaLoai", "@MaNCC", "@Gia" },
            new object[] { MaHang, TenHang, SoLuong, Loai, NhaCC, Gia },
            strConnection, "sp_updateHangHoa"
            );
        }
        public int xoaHangHoa(string strConnection)
        {
            return Ultil.Ultil.ExecuteProcedure(
            new string[] { "@MaHang"},
            new object[] { MaHang},
            strConnection, "sp_deleteHangHoa"
            );
        }

        /*
        public DataTable timKiemHangHoa()
        {
            SqlConnection conn = new SqlConnection(sqlConectionString);
            SqlCommand cm = new SqlCommand("exec sp_selectHangHoa" + this.MaHang, conn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LoadData()
        {
            SqlConnection conn = new SqlConnection(sqlConectionString);
            SqlCommand cm = new SqlCommand("exec sp_AllHang", conn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }*/
    }
}
