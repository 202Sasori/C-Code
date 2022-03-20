using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8.DAL
{
    internal class changeInt
    {
        public static int change(string str)
        {
            int result;
            result = Convert.ToInt32(str);
            return result;
        }
    }
}
