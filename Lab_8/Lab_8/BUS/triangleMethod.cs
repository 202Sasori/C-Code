using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8.BUS
{
    internal class triangleMethod
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double side3 { get; set; }
        //Constructor
        public triangleMethod() { }
        public triangleMethod(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public triangleMethod(TextBox txtA, TextBox txtB, TextBox txtC)
        {
            side1 = DAL.changeDouble.changeDou(txtA.Text);
            side2 = DAL.changeDouble.changeDou(txtB.Text);
            side3 = DAL.changeDouble.changeDou(txtC.Text);
        }
        //Tinh chu vi tam giac
        public double perimeter()
        {
            string check;
            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                
                return side1 + side2 + side3;
            }
            else
            {
                return double.NaN;
            }
        }
        //Tinh dien tich
        public double area()
        {
            string check;
            if(side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                double p = perimeter() / 2;
                return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            }
            else
            {
                return double.NaN;
            } 
        }
        public string checkTriangle()
        {
            double a = side1;
            double b = side2;
            double c = side3;
            string check;
            //Kiem tra ba canh cua tam giac
            if(a + b > c && a + c > b && b + c > a)
            {
                //Kiem tra tam giac vuong (pitago)
                if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == b * b + a * a)
                {
                    check = "Tam giac vuong";
                }
                //Kiem tra tam giac deu
                else if (a == b && b == c)
                {
                    check = "Tam giac deu";
                }
                //Kiem tra tam giac can
                else if(a == b || a == c || b == c)
                {
                    check = "Tam giac can";
                }
                //Kiem tra tam giac tu
                else if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > a * a + b * b)
                {
                    check = "Tam giac tu";
                }else
                {
                    check = "Tam giac nhon";
                }
            }
            else
            {
                check = "Tam giac khong ton tai";
            }
            return check;

        }
    }
}
