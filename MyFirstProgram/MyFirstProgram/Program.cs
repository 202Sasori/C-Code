using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bai tap 1:
            Console.WriteLine(
                "Ram thang gieng\n" +
                "Ram xuan long long trang soi\n" +
                "Song xuan nuoc lan mau troi them xuan\n" +
                "Giua dong ban bac viec quan\n" +
                "Khuya ve bat ngat trang ngan day thuyen\n" +
                "Ho Chi Minh\n");
            //Bai tap 2:
            const double pi = 3.14;
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("V = pi*r^2*h = " + Math.Round(pi * radius*radius * height));
            Console.WriteLine("A = 2*pi*r*h = " + Math.Round(2*pi * radius * height));
            //Bai tap 3:
            Console.Write("Input number (0 < number < 100): ");
            int number = Convert.ToInt32(Console.ReadLine());
            //Số hàng đơn vị
            int a = (number / 10);
            //Số hàng chục
            int b = (number % 10);
            int[] num = {a, b};
            for(int i = 0; i < num.Length; i++)
            {
                switch (num[i])
                {
                    case 1:
                        Console.WriteLine("mot");
                        break;
                    case 2:
                        Console.WriteLine("hai");
                        break;
                    case 3:
                        Console.WriteLine("ba");
                        break;
                    case 4:
                        Console.WriteLine("bon");
                        break;
                    case 5:
                        Console.WriteLine("nam");
                        break;
                    case 6:
                        Console.WriteLine("sau");
                        break;
                    case 7:
                        Console.WriteLine("bay");
                        break;
                    case 8:
                        Console.WriteLine("tam");
                        break;
                    case 9:
                        Console.WriteLine("chin");
                        break;
                    default:
                        Console.WriteLine("khong");
                        break;
                }
            }
            
            //Bai tap 4:
            Console.WriteLine("-------- Menu --------\n" +
                              "1. Tam giac vuong dac\n" +
                              "2. Tam giac vuong rong\n" +
                              "3. Hinh vuong rong\n" +
                              "Press 0 to exit!!!");
            
            while (true)
            {
                Console.Write("Select an option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 0) break;
                switch (option){
                    case 1://Tam giac vuong dac
                        Console.WriteLine("Hinh tam giac vuong dac: ");
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2://Tam giac vuong rong
                        Console.WriteLine("Hinh tam giac vuong rong: ");
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                if (i == 9 || j == 0 || i == j)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }

                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3://Hinh vuong dac
                        Console.WriteLine("Hinh vuong dac: ");
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
