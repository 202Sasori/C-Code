using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("One");
            list.Add(2);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
