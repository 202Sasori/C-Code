using System;

namespace Bai_2_NET
{
    class Program
    {
        static void Main(String[] args)
        {
            menu();
            while (true)
            {
                int option;
                Console.Write("Select an option: ");
                option = int.Parse(Console.ReadLine());
                if (option == 0) break;
                switch (option)
                {
                    case 1: //Bài 1: tính s = 2 + 4 + 6 + ... + n
                        Console.Write("Nhap so n: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        bai1(n);
                    break;
                    case 2://Bài 2: tính s = 1 + 1/2 + ... + 1/n
                        Console.Write("Nhap so a: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        bai2(a);
                    break;
                    case 3://Bài 3: Kiểm tra một số nguyên có phải là nguyên tố hay không?
                        Console.Write("Nhap so b: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        kiemTraNguyenTo(b);
                    break;
                    case 4:
                        /*Bài 4: Nhập vào 3 số bất kỳ, kiểm tra xem 3 số đó có phải là chiều dài
                        ba cạnh của một tam giác hay không? Là tam giác gì?
                       */
                        Console.Write("Nhap so thu nhat: ");
                        int s1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nhap so thu hai: ");
                        int s2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nhap so thu ba: ");
                        int s3 = Convert.ToInt32(Console.ReadLine());
                        kiemTraTamGiac(s1, s2, s3);
                    break;
                    case 5://Bài 5: Nhập vào n, hiển thị chuỗi Fibonacy n số. (0 1 1 2 3 5 8 ...)
                        int number = 0, numberOfElement;
                        Console.Write("Nhao vao so phan tu day Fibonacci muon in: ");
                        numberOfElement = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Day Fibonacci: ");
                        //In Fibonacci
                        for (int i = 0; i < numberOfElement; i++)
                        {
                            Console.Write(InFibonacci(number) + " ");
                            number++;
                        }
                        Console.WriteLine();
                    break;

                }
            }
            Console.ReadKey();
        }
        // Bài 1:
        static void bai1(int n)
        {
            int sum = 0;
            for (int i = 2; i <= n; i += 2)
            {
                if (i == 2)
                {
                    Console.Write("");
                }
                Console.Write(" + {0}",i);
                sum += i;  
               
            }
            Console.WriteLine(" = " + sum);
        }
        // Bài 2: 
        static void bai2(int a)
        {
            double sum = 0;
            for (int i = 1; i <= a; i++)
            {
                Console.Write(" + 1/{0}", i);
                sum += 1.0 / i;
            }
            Console.WriteLine(" = " + Math.Round(sum, 2));
        }
        // Bài 3:
        static void kiemTraNguyenTo(int b)
        {
            bool soNguyenTo = true;
            if (b < 2)
            {
                soNguyenTo = false; 
            }
            for (int i = 2; i <= Math.Sqrt(b); i++)
            {
                if(b % i == 0)
                {
                    soNguyenTo = false;
                    break;
                }
            }
            if (soNguyenTo)
            {
                Console.WriteLine($"{b} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{b} khong la so nguyen to");
            }
        }
        // Bài 4:
        static void kiemTraTamGiac(double a, double b, double c)
        {
            // Kiểm tra xem ba cạch có phải là ba cạnh của một tam giác hay không
            if (a + b > c && a + c > b && c + b > a)
            {
                // Điều kiện tam giác vuông (định lý pitago)
                if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
                {
                    Console.WriteLine("Tam giac vuong");
                }
                // Điều kiện tam giác đều  là có ba cạnh bằng nhau
                else if (a == b && b == c)
                {
                    Console.WriteLine("Tam giac deu");
                }
                // Điều kiện tam giác cân là có 2 cạnh bằng nhau
                else if (b == c || a == b || a == c)
                {
                    Console.WriteLine("Tam giac can");
                }
                // Điều kiện tam giác tù là có một góc lớn hơn 90 độ
                else if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > a * a + b * b)
                {
                    Console.WriteLine("Tam giac tu");
                }
                else
                {
                    Console.WriteLine("Tam giac nhon");
                }
            } 
            else
            {
                Console.WriteLine("Khong phai ba canh cua tam giac");
            }
        }
        // Bài 5: Đệ quy
        static int InFibonacci(int num)
        {
            if (num == 0)
                return 0;
            else if (num == 1)
                return 1;
            else
                return (InFibonacci(num - 1) + InFibonacci(num - 2));
        }
        static void menu()
        {
            Console.Write("----------Menu---------\n" +
                          "1. Tinh tong S = 2 + 4 + ... + n\n"+
                          "2. Tinh tong S = 1 + 1/2 + ... + 1/n\n" +
                          "3. Kiem tra so nguyen to\n" +
                          "4. Kiem tra 3 so bat ki co tao thanh mot tam giac\n" +
                          "5. In day Fibonacci gom n phan tu (n nhap tu ban phim)\n" +
                          "Press 0 to exit\n");
        }
    }
} 
