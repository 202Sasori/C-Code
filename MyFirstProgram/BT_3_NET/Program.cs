using System;

namespace Program
{
    class So{
        double number1;
        double number2;
        public So()
        {
            Console.Write("Number 1: ");
            this.number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 2: ");
            this.number2 = Convert.ToDouble(Console.ReadLine());
        }
        public void Cong()
        {
            double sum = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {sum}");
        }
        public void Tru()
        {
            double subtraction = number1 - number2;
            Console.WriteLine($"{number1} - {number2} = {subtraction}");
        }
        public void Nhan()
        {
            double multiplication = number1 * number2;
            Console.WriteLine($"{number1} * {number2} = {multiplication}");
        }
        public void Chia()
        {
            double division = number1 / number2;
            Console.WriteLine($"{number1} / {number2} = " + Math.Round(division,2));
        }
    }
    class tamGiac
    {
        double a;
        double b;
        double c;
        public tamGiac()
        {
            Console.Write("Nhap canh a: ");
            this.a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap canh b: ");
            this.b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap canh c: ");
            this.c = Convert.ToDouble(Console.ReadLine());
        }
        public void ktraTamGiac()
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
        public void tinhChuVi()
        {
            if(a + b < c || a + c < b || c + b < a)
            {
                Console.WriteLine("Khong ton tai chu vi tam giac nay");
            }
            else
            {
                double P = a + b + c;
                Console.WriteLine($"Chu vi cua tam giac la {P}");
            }
        }
        public void tinhDienTich()
        {
            if (a + b < c || a + c < b || c + b < a)
            {
                Console.WriteLine("Khong ton tai dien tich tam giac nay");
            }
            else
            {
                double T = (a + b + c) / 2;
                double S = Math.Sqrt(T * (T - a) * (T - b) * (T - c));
                Console.WriteLine($"Dien tich cua tam giac la {S}");
            }
        }
    }
    class SinhVien
    {
        string maSV;
        string name;
        int age;
        string className;

        public SinhVien()
        {
            Console.Write("Nhap ma sinh vien: ");
            this.maSV = Console.ReadLine();
            Console.Write("Ten sinh vien: ");
            this.name = Console.ReadLine();
            Console.Write("Tuoi: ");
            this.age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ten lop: ");
            this.className = Console.ReadLine();

        }
        public void hienThiSinhVien()
        {
            Console.Write($"Ma sinh vien\tTen\t\tTuoi\tTen lop\n");
            Console.Write($"{maSV}\t{name}\t{age}\t{className}\n");
        }
    }
    class diem
    {
        int x;
        int y;

        public void nhapDiem()
        {
            Console.Write("x: ");
            this.x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y: ");
            this.y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"({x} , {y})");
        }
        public void khoangCach()
        {
            diem a = new diem();
            diem b = new diem();
            a.nhapDiem();
            b.nhapDiem();
            double d = Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
            Console.WriteLine($"Khoang cach giua hai diem ({a.x}, {a.y}) va ({b.x}, {b.y}) la {d}");
        }
    }
    class Program
    {
        static void Main(string[] arg)
        {
            
            //Bài 1:
            So bai1 = new So();
            bai1.Cong();
            bai1.Tru();
            bai1.Nhan();
            bai1.Chia();

            //Bài 2
            tamGiac bai2 = new tamGiac();
            bai2.ktraTamGiac();
            bai2.tinhChuVi();
            bai2.tinhDienTich();

            //Bài 3
            SinhVien sv = new SinhVien();
            sv.hienThiSinhVien();
            
            //Bài 4:
            diem d = new diem();
            d.khoangCach();
            Console.ReadKey();
        }
    }
}
