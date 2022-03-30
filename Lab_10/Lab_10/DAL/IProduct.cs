using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10.DAL
{
    internal interface IProduct
    {
        int MaH { get; set; }
        string TenHang { get; set; }
        int DonGia { get; set; }
        string GhiChu { get; set; }
        int addProduct(string strSqlConnection);
        int updateProduct(string strSqlConnection);
        int deleteProduct(string strSqlConnection);
        int findProductByID(string strProductID);
    }
}
