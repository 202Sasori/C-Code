
namespace Lab_11.GUI
{
    partial class frmReportProduct
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
            this.crystalReportProduct = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportProduct
            // 
            this.crystalReportProduct.ActiveViewIndex = -1;
            this.crystalReportProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportProduct.Location = new System.Drawing.Point(0, 0);
            this.crystalReportProduct.Name = "crystalReportProduct";
            this.crystalReportProduct.Size = new System.Drawing.Size(974, 546);
            this.crystalReportProduct.TabIndex = 0;
            // 
            // frmReportProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 546);
            this.Controls.Add(this.crystalReportProduct);
            this.Name = "frmReportProduct";
            this.Text = "frmReportProduct";
            this.Load += new System.EventHandler(this.frmReportProduct_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportProduct;
    }
}