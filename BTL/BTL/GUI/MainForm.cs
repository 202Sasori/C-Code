using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.GUI
{
    public partial class MainForm : Form
    {
        public string strConectionString;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = true;
        }
        public void loadForm(object Form)
        {
            if(this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
                Form f = Form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.mainPanel.Controls.Add(f);
                this.mainPanel.Tag = f;
                f.Show();
        }
        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            loadForm(new GUI.HangHoa(strConectionString));
        }
    }
}
