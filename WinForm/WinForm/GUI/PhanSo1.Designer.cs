namespace WinForm.GUI
{
    partial class PhanSo1
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
            this.btnCong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMau2 = new System.Windows.Forms.TextBox();
            this.txtTu2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMau1 = new System.Windows.Forms.TextBox();
            this.txtTu1 = new System.Windows.Forms.TextBox();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKQTu = new System.Windows.Forms.TextBox();
            this.txtKQMau = new System.Windows.Forms.TextBox();
            this.btnIN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(59, 191);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(81, 34);
            this.btnCong.TabIndex = 0;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mau So";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tu So";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMau2
            // 
            this.txtMau2.Location = new System.Drawing.Point(289, 133);
            this.txtMau2.Name = "txtMau2";
            this.txtMau2.Size = new System.Drawing.Size(52, 22);
            this.txtMau2.TabIndex = 6;
            // 
            // txtTu2
            // 
            this.txtTu2.Location = new System.Drawing.Point(289, 78);
            this.txtTu2.Name = "txtTu2";
            this.txtTu2.Size = new System.Drawing.Size(52, 22);
            this.txtTu2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mau So";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tu So";
            // 
            // txtMau1
            // 
            this.txtMau1.Location = new System.Drawing.Point(112, 133);
            this.txtMau1.Name = "txtMau1";
            this.txtMau1.Size = new System.Drawing.Size(52, 22);
            this.txtMau1.TabIndex = 10;
            // 
            // txtTu1
            // 
            this.txtTu1.Location = new System.Drawing.Point(112, 78);
            this.txtTu1.Name = "txtTu1";
            this.txtTu1.Size = new System.Drawing.Size(52, 22);
            this.txtTu1.TabIndex = 9;
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(177, 191);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(81, 34);
            this.btnTru.TabIndex = 13;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(289, 191);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(81, 34);
            this.btnNhan.TabIndex = 14;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(409, 191);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(81, 34);
            this.btnChia.TabIndex = 15;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kết quả";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtKQTu
            // 
            this.txtKQTu.Location = new System.Drawing.Point(441, 81);
            this.txtKQTu.Name = "txtKQTu";
            this.txtKQTu.Size = new System.Drawing.Size(49, 22);
            this.txtKQTu.TabIndex = 17;
            // 
            // txtKQMau
            // 
            this.txtKQMau.Location = new System.Drawing.Point(441, 133);
            this.txtKQMau.Name = "txtKQMau";
            this.txtKQMau.Size = new System.Drawing.Size(49, 22);
            this.txtKQMau.TabIndex = 18;
            // 
            // btnIN
            // 
            this.btnIN.Location = new System.Drawing.Point(177, 240);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(193, 33);
            this.btnIN.TabIndex = 19;
            this.btnIN.Text = "In kết quả";
            this.btnIN.UseVisualStyleBackColor = true;
            this.btnIN.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PhanSo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 285);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.txtKQMau);
            this.Controls.Add(this.txtKQTu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMau1);
            this.Controls.Add(this.txtTu1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMau2);
            this.Controls.Add(this.txtTu2);
            this.Controls.Add(this.btnCong);
            this.Name = "PhanSo1";
            this.Text = "TÍNH";
            this.Load += new System.EventHandler(this.PhanSo1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMau2;
        private System.Windows.Forms.TextBox txtTu2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMau1;
        private System.Windows.Forms.TextBox txtTu1;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKQTu;
        private System.Windows.Forms.TextBox txtKQMau;
        private System.Windows.Forms.Button btnIN;
    }
}

