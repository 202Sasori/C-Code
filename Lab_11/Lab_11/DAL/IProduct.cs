using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11.DAL
{
    internal interface IProduct
    {
        string MaH { get; set; }
        string TenHang { get; set; }
        string DonGia { get; set; }
        string GhiChu { get; set; }
        int addProduct(string strSqlConnection);
        int updateProduct (string strSqlConnection);
        int deleteProduct (string strSqlConnection);
        int findByIDProduct (string strSqlConnection);
    }
}
