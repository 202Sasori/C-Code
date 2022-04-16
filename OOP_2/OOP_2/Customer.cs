using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class Customer
    {
        public string cusID, cusName, address;
        //Constructor
        public Customer()
        {
            this.cusID = "";
            this.cusName = "";
            this.address = "";
        }

        public Customer(string cusID, string cusName, string address)
        {
            this.cusID = cusID;
            this.cusName = cusName;
            this.address = address;
        }
        //Getter and Setter
        public string CusID { get { return cusID; } set { cusID = value; } }
        public string CusName { get { return cusName; } set { cusName = value; } }
        public string Address { get { return address; } set { address = value; } }
        //Input Infor
        public void setInfor()
        {
            Console.Write("--Customer ID: ");
            this.cusID = Console.ReadLine();
            Console.Write("--Name: ");
            this.cusName = Console.ReadLine();
            Console.Write("--Address: ");
            this.address = Console.ReadLine();
        }
        //Print infor
        public void printInfor()
        {
            Console.WriteLine("Customer ID: " + cusID
                              + "\tName: " + cusName
                              + "\tAddress: " + address);
        }
    }
}
