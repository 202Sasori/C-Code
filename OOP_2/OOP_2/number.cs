using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class number
    {
        private double num;
        //Constructor
        public number() { }
        public number(double num)
        {
            this.num = num;
        }
        //Getter and Setter
        public double Num { get { return num; } set { this.Num = value; } }
        //Nhap so
        public void inputInfor()
        {
            Console.Write("Nhap so: ");
            this.num = Convert.ToDouble(Console.ReadLine());
        }
        public void inFor()
        {
            Console.WriteLine($"So {num}");
        }
        //Nap chong toan tu +
        public static number operator +(number a, number b)
        {
            number c = new number();
            c.num = a.num + b.num;
            Console.WriteLine($"Sum {a.num} + {b.num} = {c.num}");
            return c;
        }
        //Nap chong toan tu -
        public static number operator -(number a, number b)
        {
            number c = new number();
            c.num = a.num - b.num;
            Console.WriteLine($"Subtract: {a.num} - {b.num} = {c.num}");
            return c;
        }
        //Nap chong toan tu *
        public static number operator *(number a, number b)
        {
            number c = new number();
            c.num = a.num * b.num;
            Console.WriteLine($"Multiply: {a.num} * {b.num} = {c.num}");
            return c;
        }
        //Nap chong toan tu /
        public static number operator /(number a, number b)
        {
            number c = new number();
            c.num = a.num / b.num;
            Console.WriteLine($"Division: {a.num} : {b.num} = {c.num}");
            return c;
        }
        //Ktra so nguyen to
        public void kiemTraNgTo()
        {
            bool IsPrime = true;
            if (num < 2)
            {
                IsPrime = false;
            }
            for(int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.WriteLine($"{num} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{num} khong la so nguyen to");
            }
        }
        //Ktra tinh chan le
        public void ktraChanLe()
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} la so chan");
            }
            else
            {
                Console.WriteLine($"{num} la so le");
            }
        }
    }
}
