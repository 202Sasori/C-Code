using System;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
            while (true)
            {
                Console.Write("Select an option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 0) break;
                switch (option)
                {
                    case 1:
                        //Bai 1
                        phanSo a = new phanSo();
                        phanSo b = new phanSo();
                        phanSo c = new phanSo();
                        a.inputInfor();
                        b.inputInfor();
                        a.infor();
                        b.infor();
                        c = a + b;
                        c = a - b;
                        c = a * b;
                        c = a / b;
                    break;
                    case 2:
                        //Bai 2
                        number num1 = new number();
                        number num2 = new number();
                        number num3 = new number();
                        num1.inputInfor();
                        num2.inputInfor();
                        num1.inFor();
                        num2.inFor();
                        num2.kiemTraNgTo();
                        num2.ktraChanLe();
                        num3 = num1 + num2;
                        num3 = num1 - num2;
                        num3 = num1 * num2;
                        num3 = num1 / num2;
                    break;
                    case 3:
                        //Bai 3:
                        //Customer
                        Console.Write("Number of customer: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Customer[] customer = new Customer[n];
                        for(int i = 0; i < customer.Length; i++)
                        {
                            Console.WriteLine("Customer " + (i + 1));
                            customer[i] = new Customer();
                            customer[i].setInfor();
                        }
                        for (int i = 0; i < customer.Length; i++)
                        {
                            Console.WriteLine("Customer " + (i + 1) + " infor");
                            customer[i].printInfor();
                        }
                        //Products
                        Console.Write("Number of product: ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Products[] product = new Products[x];
                        for (int i = 0; i < product.Length; i++)
                        {
                            Console.WriteLine("Product " + (i + 1));
                            product[i] = new Products();
                            product[i].setInfor();
                        }
                        for (int i = 0; i < product.Length; i++)
                        {
                            Console.WriteLine("Product " + (i + 1) + " infor");
                            product[i].printInfor();
                        }
                        break;
                            }
                        }      
            //Find max price on product
            bill bill = new bill();
            bill.showInfor();
            void menu()
            {
                Console.WriteLine("----------Menu----------\n"
                                  + "1. Cong, tru, nhan, chia hai phan so\n"
                                  + "2. Cong, tru, nhan, chia hai so,\n" +
                                  "Kiem tra so nguyen to va tinh chan le\n"
                                  + "3. Them  hang hoa\n"
                                  + "4. Xoa hang hoa\n"
                                  + "5. Hang hoa co gia cao nhat\n"
                                  + "6. In hoa don\n"
                                  + "0. Press 0 to exit\n");
            }
            Console.ReadKey();
        }
    }
}