using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab_8.DAL
{
    internal class deleteTextBox
    {
        public static void delete(TextBox[] txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                txt[i].Text = " ";
            }
        }
    }
}
