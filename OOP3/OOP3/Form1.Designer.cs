namespace OOP3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTu1 = new System.Windows.Forms.TextBox();
            this.txtMau1 = new System.Windows.Forms.TextBox();
            this.txtMau2 = new System.Windows.Forms.TextBox();
            this.txtTu2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKQT = new System.Windows.Forms.TextBox();
            this.txtKQM = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tử số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mẫu số";
            // 
            // txtTu1
            // 
            this.txtTu1.Location = new System.Drawing.Point(120, 66);
            this.txtTu1.Name = "txtTu1";
            this.txtTu1.Size = new System.Drawing.Size(45, 22);
            this.txtTu1.TabIndex = 2;
            // 
            // txtMau1
            // 
            this.txtMau1.Location = new System.Drawing.Point(120, 114);
            this.txtMau1.Name = "txtMau1";
            this.txtMau1.Size = new System.Drawing.Size(45, 22);
            this.txtMau1.TabIndex = 3;
            // 
            // txtMau2
            // 
            this.txtMau2.Location = new System.Drawing.Point(292, 114);
            this.txtMau2.Name = "txtMau2";
            this.txtMau2.Size = new System.Drawing.Size(45, 22);
            this.txtMau2.TabIndex = 7;
            // 
            // txtTu2
            // 
            this.txtTu2.Location = new System.Drawing.Point(292, 66);
            this.txtTu2.Name = "txtTu2";
            this.txtTu2.Size = new System.Drawing.Size(45, 22);
            this.txtTu2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mẫu số";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tử số";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kết quả";
            // 
            // txtKQT
            // 
            this.txtKQT.Location = new System.Drawing.Point(437, 66);
            this.txtKQT.Name = "txtKQT";
            this.txtKQT.Size = new System.Drawing.Size(45, 22);
            this.txtKQT.TabIndex = 10;
            // 
            // txtKQM
            // 
            this.txtKQM.Location = new System.Drawing.Point(437, 114);
            this.txtKQM.Name = "txtKQM";
            this.txtKQM.Size = new System.Drawing.Size(45, 22);
            this.txtKQM.TabIndex = 11;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(53, 178);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(90, 36);
            this.btnCong.TabIndex = 12;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(158, 178);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(90, 36);
            this.btnTru.TabIndex = 13;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(278, 178);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(90, 36);
            this.btnNhan.TabIndex = 14;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(392, 178);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(90, 36);
            this.btnChia.TabIndex = 15;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(194, 243);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(143, 36);
            this.btnIn.TabIndex = 16;
            this.btnIn.Text = "In sang form mới";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 345);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtKQM);
            this.Controls.Add(this.txtKQT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMau2);
            this.Controls.Add(this.txtTu2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMau1);
            this.Controls.Add(this.txtTu1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TÍNH PHÂN SỐ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTu1;
        private System.Windows.Forms.TextBox txtMau1;
        private System.Windows.Forms.TextBox txtMau2;
        private System.Windows.Forms.TextBox txtTu2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKQT;
        private System.Windows.Forms.TextBox txtKQM;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnIn;
    }
}

