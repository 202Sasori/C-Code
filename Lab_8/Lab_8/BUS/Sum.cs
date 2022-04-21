using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8.BUS
{
    internal class Sum
    {
        public int number1 { get; set; }
        public int number2 { get; set; }
        //Constructor
        public Sum() { }
        public Sum(TextBox txtNumber1, TextBox txtNumber2)
        {
            number1 = DAL.changeInt.change(txtNumber1.Text);
            number2 = DAL.changeInt.change(txtNumber2.Text);
        }
        public Sum(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2; 
        }
        public int Add()
        {
            return number1 + number2;
        }
    }
}
