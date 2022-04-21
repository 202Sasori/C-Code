using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11.DAL
{
    internal interface IBill
    {
        string MaHD { get; set; }
        string MaKH { get; set; }
        string NgayHD { get; set; }
        string GhiChu { get; set; }
        int addBill(string strSqlConnection);
        int updateBill(string strSqlConnection);
        int deleteBill(string strSqlConnection);
        int findByIDBill(string strSqlConnection);
    }
}
