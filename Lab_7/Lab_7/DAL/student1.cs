using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7.DAL
{
    public partial class student1 : Form
    {
        //Tạo đối tượng sinh viên
        student sv = new student();
        public student1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu từ form
            sv.ID = txtID.Text.Trim();
            sv.Name = txtName.Text.Trim();
            sv.Class = txtClass.Text.Trim();
            //Mở file để lấy ảnh
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if(opnfd.ShowDialog() == DialogResult.OK)
            {
                picStudent.Image = new Bitmap(opnfd.FileName);
            }
            //Đẩy dữ liệu vào listview
            ListViewItem lv = new ListViewItem(sv.ID);
            lv.SubItems.Add(sv.Name);
            lv.SubItems.Add(sv.Class);
            listStudent.Items.Add(lv);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(listStudent.SelectedItems.Count > 0)
            {
                listStudent.Items.RemoveAt(listStudent.SelectedItems[0].Index);
                txtID.Text = "";
                txtName.Text = "";
                txtClass.Text = "";
               picStudent.Image = null;
            }
        }

        private void student1_Load(object sender, EventArgs e)
        {
            //Load dữ liệu mặc định
            ListViewItem lv = new ListViewItem("20208173");
            lv.SubItems.Add("Trần Thị Quỳnh Anh");
            lv.SubItems.Add("Kế toán");
            listStudent.Items.Add(lv);

            lv = new ListViewItem("20201383");
            lv.SubItems.Add("Đinh Thị Thảo");
            lv.SubItems.Add("Kế toán");
            listStudent.Items.Add(lv);
        }

        private void listStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listStudent.SelectedItems.Count > 0)
            {
                ListViewItem lv = listStudent.SelectedItems[0];

                sv.ID = lv.SubItems[0].Text;
                sv.Name = lv.SubItems[1].Text;
                sv.Class = lv.SubItems[2].Text;

                txtID.Text = sv.ID;
                txtName.Text = sv.Name;
                txtClass.Text = sv.Class;
                
            }
        }
    }
}
