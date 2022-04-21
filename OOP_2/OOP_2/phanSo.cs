using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class phanSo
    {
        //Phan so co x la tu so, y la mau so: x/y
        private double x;
        private double y;
        //Constructor
        public phanSo() { }
        public phanSo(double x, double y) {
            this.x = x;
            this.y = y;
        }
        //Getter and Setter
        public double getX() { return x; }
        public double getY() { return y; }
        public void setX(double x) { this.x = x; }
        public void setY(double y) { this.y = y; }
        //Nhap tu so va mau so
        public void inputInfor()
        {
            Console.Write("Nhap tu so x = ");
            this.x = Convert.ToDouble(Console.ReadLine());
            while(this.y == 0)
            {
                Console.Write("Nhap mau so y = ");
                this.y = Convert.ToDouble(Console.ReadLine());
            }
        }
        public void infor()
        {
            Console.WriteLine($"Phan so: {x}/{y}");
        }
        //Rut gon phan so
        public static void rutGon(phanSo a)
        {
            //Chua rut gon dc x/x chua rut gon dc 0/x
            double j = (a.x < a.y) ? a.y : a.x;
            for (int i = 1; i <= j; i++)
            {
                if (a.x % i == 0 && a.y % i == 0)
                {
                    a.x /= i;
                    a.y /= i;
                }
            }   
        }
        //Nap chong toan tu +
        public static phanSo operator +(phanSo a, phanSo b)
        {
            phanSo c = new phanSo();
            c.x = (a.x * b.y) + (b.x * a.y);
            c.y = a.y * b.y;
            rutGon(c);
            Console.WriteLine($"Sum: {a.x}/{a.y} + {b.x}/{b.y} = {c.x}/{c.y} ");
            return c;
        }
        //Nap chong toan tu -
        public static phanSo operator -(phanSo a, phanSo b)
        {
            phanSo c = new phanSo();
            c.x = (a.x * b.y) - (b.x * a.y);
            c.y = a.y * b.y;
            rutGon(c);
            Console.WriteLine($"Subtract: {a.x}/{a.y} - {b.x}/{b.y} = {c.x}/{c.y}");
            return c;
        }
        //Nap chong toan tu *
        public static phanSo operator *(phanSo a, phanSo b)
        {
            phanSo c = new phanSo();
            c.x = a.x * b.x ;
            c.y = a.y * b.y;
            rutGon(c);
            Console.WriteLine($"Multiply: {a.x}/{a.y} * {b.x}/{b.y} = {c.x}/{c.y}");
            return c;
        }
        //Nap chong toan tu /
        public static phanSo operator /(phanSo a, phanSo b)
        {
            phanSo c = new phanSo();
            c.x = a.x * b.y;
            c.y = a.y * b.x;
            rutGon(c);
            Console.WriteLine($"Division: {a.x}/{a.y} : {b.x}/{b.y} = {c.x}/{c.y}");
            return c;
        }
    }
}
