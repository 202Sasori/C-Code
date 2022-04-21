using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class bill
    {
        Customer customer;
        Products product;
        
        public bill() { }
        public bill(Customer customer, Products product)
        {
            this.product = product;
            this.customer = customer;
        }

        public void showInfor()
        {
                Console.WriteLine("Bill"
                             + "\nProduct ID: " + product.productID
                             + "\nCustomer ID: " + customer.cusID
                             + "\nCustomer Name: " + customer.cusName
                             + "\nProduct Name: " + product.productName
                             + "\nUnit price: " + product.price
                             + "\nAddress: " + customer.address);
        } 
    }
}
