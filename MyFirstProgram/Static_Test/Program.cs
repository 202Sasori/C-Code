using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Test
{
    //Static class
    static class tutorial
    {
        //Static variable
        public static string Topic = "Static class";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Topic name is: {0}", tutorial.Topic);
            Console.ReadLine();
        }
    }
}
