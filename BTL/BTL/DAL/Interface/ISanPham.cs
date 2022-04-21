using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BTL.DAL.Interface
{
    interface ISanPham
    {
        
        int themHangHoa(string strConnection);
        int suaHangHoa(string strConnection);
        int xoaHangHoa(string strConnection);
        //DataTable timKiemHangHoa();
        //DataTable LoadData(); 
    }
}
