using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.DAL
{
    internal class phanSo
    {
        //Tao bien
        int rutGon;
        private int x;
        private int y;
        //Tao constructor
        public phanSo() { }
        public phanSo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //Getter & Setter
        //Tu so
        public int TS { get { return this.x; } set { x = value; } }
        //Mau so
        public int MS { get { return this.y; } set { y = value; } }

        //Nạp chồng toán tử
        //Cộng
        public static phanSo operator+ (phanSo a, phanSo b)
        {
            phanSo c = new phanSo();
            //Phép cộng hai phân số ta quy đồng 
            c.TS = (a.TS * b.MS) + (b.TS * a.MS);
            c.MS = a.MS * b.MS;
            return c;
        }
        //Trừ
        public static phanSo operator -(phanSo a, phanSo b)
        {
            phanSo c = new phanSo();
            //Phép cộng hai phân số ta quy đồng 
            c.TS = (a.TS * b.MS) - (b.TS * a.MS);
            c.MS = a.MS * b.MS;
            return c;
        }
        //Nhân
        public static phanSo operator *(phanSo a, phanSo b)
        {
            phanSo c = new phanSo();
            c.TS = a.TS *b .TS;
            c.MS = a.MS * b.MS;
            return c;
        }
        //Chia
        public static phanSo operator /(phanSo a, phanSo b)
        {
            phanSo c = new phanSo();
            c.TS = a.TS * b.MS;
            c.MS = a.MS * b.TS;
            return c;
        }
        public int ucln(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
                return ucln(b, a % b);
        }
    }
}
