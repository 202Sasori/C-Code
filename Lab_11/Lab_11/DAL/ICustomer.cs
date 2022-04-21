using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11.DAL
{
    internal interface ICustomer
    {
        string MaKH { get; set; }
        string TenKH { get; set; }
        string SDT { get; set; }
        string GhiChu { get; set; }
        int addCustomer(string strSqlConnection);
        int updateCustomer(string strSqlConnection);
        int deleteCustomer(string strSqlConnection);
        int findByIDCustomer (string strSqlConnection);
    }
}
