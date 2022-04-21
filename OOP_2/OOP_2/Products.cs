using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class Products
    {
        public string productID, productName;
        public double price;
        //Constructor
        public Products() { }
        public Products(string productID, string productName, double price)
        {
            this.productID = productID;
            this.productName = productName;
            this.price = price;
        }
        //Getter and Setter
        public string ProductID { get { return productID ; } set { productID = value; } }
        public string ProductName { get { return productName ; } set { productName = value; } }
        public double Price { get { return price ; } set { price = value; } }
        //Input Infor
        public void setInfor()
        {
            Console.Write("--Pruduct ID: ");
            this.productID = Console.ReadLine();
            Console.Write("--Name: ");
            this.productName = Console.ReadLine();
            Console.Write("--Unit Price: ");
            this.price = Convert.ToDouble(Console.ReadLine());
        }
        //Print infor
        public void printInfor()
        {
            Console.WriteLine("Product ID: " + productID
                              + "\tName: " + productName
                              + "\tUnit Price: " + price + " VND");
        }
    }
}
