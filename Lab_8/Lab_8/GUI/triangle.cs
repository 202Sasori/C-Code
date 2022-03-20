using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8.GUI
{
    public partial class triangle : Form
    {
        public triangle()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TextBox[] txt = new TextBox[] {txtCheck, txtArea, txtPerimeter, txtSide1, txtSide2, txtSide3};
            DAL.deleteTextBox.delete(txt);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            BUS.triangleMethod check = new BUS.triangleMethod(txtSide1, txtSide2, txtSide3);
            txtCheck.Text = check.checkTriangle().ToString();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            BUS.triangleMethod tinh = new BUS.triangleMethod(txtSide1, txtSide2, txtSide3);
            if(txtCheck.Text == "Tam giac khong ton tai")
            {
                MessageBox.Show("Khong ton tai chu vi va dien tich");
            }
            else
            {
                txtPerimeter.Text = tinh.perimeter().ToString();
                txtArea.Text = tinh.area().ToString();
            }
        }
    }
}
