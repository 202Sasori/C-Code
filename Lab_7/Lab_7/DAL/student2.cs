using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7.DAL
{
    public partial class student2 : Form
    {
        student sv = new student();
        public student2()
        {
            InitializeComponent();
            //Số lượng cột
            dgvStudent.ColumnCount = 3;
            dgvStudent.Columns[0].Name = "Student ID";
            dgvStudent.Columns[1].Name = "Name";
            dgvStudent.Columns[2].Name = "Class";
            //Fix kích thước cột
            dgvStudent.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStudent.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStudent.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void student2_Load(object sender, EventArgs e)
        {
            //Thêm ảnh vào form
            DataGridViewImageColumn dgvimgcol = new DataGridViewImageColumn();
            dgvimgcol.HeaderText = "Uploaded Image";
            dgvimgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dgvStudent.Columns.Add(dgvimgcol);

            dgvStudent.RowTemplate.Height = 120;

            dgvStudent.AllowUserToAddRows = false;
        }
        //Button add
        private void button1_Click(object sender, EventArgs e)
        {
                sv.ID = txtID.Text.Trim();
                sv.Name = txtName.Text.Trim();
                sv.Class = txtClass.Text.Trim();
                //Thêm các thông tin vào DatagirdList
                MemoryStream mmst = new MemoryStream();
                picStudent.Image.Save(mmst, picStudent.Image.RawFormat);
                byte[] img = mmst.ToArray();
                dgvStudent.Rows.Add(sv.ID, sv.Name, sv.Class, img);

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

        }

        private void picStudent_Click(object sender, EventArgs e)
        {
            //Lấy ảnh từ file bất kỳ trong local
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picStudent.Image = new Bitmap(opnfd.FileName);

            }
        }
    }
}
