namespace BTL.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHoaDon = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnNhanVien = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnKhachHang = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnHangHoa = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.label1);
            this.sidePanel.Controls.Add(this.btnHoaDon);
            this.sidePanel.Controls.Add(this.btnNhanVien);
            this.sidePanel.Controls.Add(this.btnKhachHang);
            this.sidePanel.Controls.Add(this.btnHangHoa);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(150, 559);
            this.sidePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Home";
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.AllowAnimations = true;
            this.btnHoaDon.AllowMouseEffects = true;
            this.btnHoaDon.AllowToggling = false;
            this.btnHoaDon.AnimationSpeed = 200;
            this.btnHoaDon.AutoGenerateColors = false;
            this.btnHoaDon.AutoRoundBorders = false;
            this.btnHoaDon.AutoSizeLeftIcon = true;
            this.btnHoaDon.AutoSizeRightIcon = true;
            this.btnHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btnHoaDon.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.BackgroundImage")));
            this.btnHoaDon.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHoaDon.ButtonText = "Hóa Đơn";
            this.btnHoaDon.ButtonTextMarginLeft = 0;
            this.btnHoaDon.ColorContrastOnClick = 45;
            this.btnHoaDon.ColorContrastOnHover = 45;
            this.btnHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnHoaDon.CustomizableEdges = borderEdges1;
            this.btnHoaDon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHoaDon.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHoaDon.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnHoaDon.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnHoaDon.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnHoaDon.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnHoaDon.IconMarginLeft = 11;
            this.btnHoaDon.IconPadding = 10;
            this.btnHoaDon.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoaDon.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnHoaDon.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnHoaDon.IconSize = 25;
            this.btnHoaDon.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.IdleBorderRadius = 50;
            this.btnHoaDon.IdleBorderThickness = 1;
            this.btnHoaDon.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.IdleIconLeftImage = null;
            this.btnHoaDon.IdleIconRightImage = null;
            this.btnHoaDon.IndicateFocus = false;
            this.btnHoaDon.Location = new System.Drawing.Point(9, 382);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHoaDon.OnDisabledState.BorderRadius = 50;
            this.btnHoaDon.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHoaDon.OnDisabledState.BorderThickness = 1;
            this.btnHoaDon.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnHoaDon.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnHoaDon.OnDisabledState.IconLeftImage = null;
            this.btnHoaDon.OnDisabledState.IconRightImage = null;
            this.btnHoaDon.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnHoaDon.onHoverState.BorderRadius = 50;
            this.btnHoaDon.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHoaDon.onHoverState.BorderThickness = 1;
            this.btnHoaDon.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnHoaDon.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.onHoverState.IconLeftImage = null;
            this.btnHoaDon.onHoverState.IconRightImage = null;
            this.btnHoaDon.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.OnIdleState.BorderRadius = 50;
            this.btnHoaDon.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHoaDon.OnIdleState.BorderThickness = 1;
            this.btnHoaDon.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.OnIdleState.IconLeftImage = null;
            this.btnHoaDon.OnIdleState.IconRightImage = null;
            this.btnHoaDon.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnHoaDon.OnPressedState.BorderRadius = 50;
            this.btnHoaDon.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHoaDon.OnPressedState.BorderThickness = 1;
            this.btnHoaDon.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnHoaDon.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.OnPressedState.IconLeftImage = null;
            this.btnHoaDon.OnPressedState.IconRightImage = null;
            this.btnHoaDon.Size = new System.Drawing.Size(126, 47);
            this.btnHoaDon.TabIndex = 4;
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHoaDon.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHoaDon.TextMarginLeft = 0;
            this.btnHoaDon.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnHoaDon.UseDefaultRadiusAndThickness = true;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.AllowAnimations = true;
            this.btnNhanVien.AllowMouseEffects = true;
            this.btnNhanVien.AllowToggling = false;
            this.btnNhanVien.AnimationSpeed = 200;
            this.btnNhanVien.AutoGenerateColors = false;
            this.btnNhanVien.AutoRoundBorders = false;
            this.btnNhanVien.AutoSizeLeftIcon = true;
            this.btnNhanVien.AutoSizeRightIcon = true;
            this.btnNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnNhanVien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.BackgroundImage")));
            this.btnNhanVien.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnNhanVien.ButtonText = "Nhân Viên";
            this.btnNhanVien.ButtonTextMarginLeft = 0;
            this.btnNhanVien.ColorContrastOnClick = 45;
            this.btnNhanVien.ColorContrastOnHover = 45;
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnNhanVien.CustomizableEdges = borderEdges2;
            this.btnNhanVien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNhanVien.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNhanVien.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNhanVien.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNhanVien.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNhanVien.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNhanVien.IconMarginLeft = 11;
            this.btnNhanVien.IconPadding = 10;
            this.btnNhanVien.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhanVien.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNhanVien.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNhanVien.IconSize = 25;
            this.btnNhanVien.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNhanVien.IdleBorderRadius = 50;
            this.btnNhanVien.IdleBorderThickness = 1;
            this.btnNhanVien.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnNhanVien.IdleIconLeftImage = null;
            this.btnNhanVien.IdleIconRightImage = null;
            this.btnNhanVien.IndicateFocus = false;
            this.btnNhanVien.Location = new System.Drawing.Point(9, 301);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNhanVien.OnDisabledState.BorderRadius = 50;
            this.btnNhanVien.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnNhanVien.OnDisabledState.BorderThickness = 1;
            this.btnNhanVien.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNhanVien.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNhanVien.OnDisabledState.IconLeftImage = null;
            this.btnNhanVien.OnDisabledState.IconRightImage = null;
            this.btnNhanVien.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNhanVien.onHoverState.BorderRadius = 50;
            this.btnNhanVien.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnNhanVien.onHoverState.BorderThickness = 1;
            this.btnNhanVien.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNhanVien.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.onHoverState.IconLeftImage = null;
            this.btnNhanVien.onHoverState.IconRightImage = null;
            this.btnNhanVien.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNhanVien.OnIdleState.BorderRadius = 50;
            this.btnNhanVien.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnNhanVien.OnIdleState.BorderThickness = 1;
            this.btnNhanVien.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnNhanVien.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.OnIdleState.IconLeftImage = null;
            this.btnNhanVien.OnIdleState.IconRightImage = null;
            this.btnNhanVien.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNhanVien.OnPressedState.BorderRadius = 50;
            this.btnNhanVien.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnNhanVien.OnPressedState.BorderThickness = 1;
            this.btnNhanVien.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNhanVien.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.OnPressedState.IconLeftImage = null;
            this.btnNhanVien.OnPressedState.IconRightImage = null;
            this.btnNhanVien.Size = new System.Drawing.Size(126, 47);
            this.btnNhanVien.TabIndex = 3;
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNhanVien.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNhanVien.TextMarginLeft = 0;
            this.btnNhanVien.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNhanVien.UseDefaultRadiusAndThickness = true;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.AllowAnimations = true;
            this.btnKhachHang.AllowMouseEffects = true;
            this.btnKhachHang.AllowToggling = false;
            this.btnKhachHang.AnimationSpeed = 200;
            this.btnKhachHang.AutoGenerateColors = false;
            this.btnKhachHang.AutoRoundBorders = false;
            this.btnKhachHang.AutoSizeLeftIcon = true;
            this.btnKhachHang.AutoSizeRightIcon = true;
            this.btnKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnKhachHang.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnKhachHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.BackgroundImage")));
            this.btnKhachHang.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnKhachHang.ButtonText = "Khách Hàng";
            this.btnKhachHang.ButtonTextMarginLeft = 0;
            this.btnKhachHang.ColorContrastOnClick = 45;
            this.btnKhachHang.ColorContrastOnHover = 45;
            this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnKhachHang.CustomizableEdges = borderEdges3;
            this.btnKhachHang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnKhachHang.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnKhachHang.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnKhachHang.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnKhachHang.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnKhachHang.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnKhachHang.IconMarginLeft = 11;
            this.btnKhachHang.IconPadding = 10;
            this.btnKhachHang.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKhachHang.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnKhachHang.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnKhachHang.IconSize = 25;
            this.btnKhachHang.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnKhachHang.IdleBorderRadius = 50;
            this.btnKhachHang.IdleBorderThickness = 1;
            this.btnKhachHang.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnKhachHang.IdleIconLeftImage = null;
            this.btnKhachHang.IdleIconRightImage = null;
            this.btnKhachHang.IndicateFocus = false;
            this.btnKhachHang.Location = new System.Drawing.Point(9, 221);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnKhachHang.OnDisabledState.BorderRadius = 50;
            this.btnKhachHang.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnKhachHang.OnDisabledState.BorderThickness = 1;
            this.btnKhachHang.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnKhachHang.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnKhachHang.OnDisabledState.IconLeftImage = null;
            this.btnKhachHang.OnDisabledState.IconRightImage = null;
            this.btnKhachHang.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnKhachHang.onHoverState.BorderRadius = 50;
            this.btnKhachHang.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnKhachHang.onHoverState.BorderThickness = 1;
            this.btnKhachHang.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnKhachHang.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.onHoverState.IconLeftImage = null;
            this.btnKhachHang.onHoverState.IconRightImage = null;
            this.btnKhachHang.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnKhachHang.OnIdleState.BorderRadius = 50;
            this.btnKhachHang.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnKhachHang.OnIdleState.BorderThickness = 1;
            this.btnKhachHang.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnKhachHang.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.OnIdleState.IconLeftImage = null;
            this.btnKhachHang.OnIdleState.IconRightImage = null;
            this.btnKhachHang.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnKhachHang.OnPressedState.BorderRadius = 50;
            this.btnKhachHang.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnKhachHang.OnPressedState.BorderThickness = 1;
            this.btnKhachHang.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnKhachHang.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.OnPressedState.IconLeftImage = null;
            this.btnKhachHang.OnPressedState.IconRightImage = null;
            this.btnKhachHang.Size = new System.Drawing.Size(126, 47);
            this.btnKhachHang.TabIndex = 2;
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKhachHang.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnKhachHang.TextMarginLeft = 0;
            this.btnKhachHang.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnKhachHang.UseDefaultRadiusAndThickness = true;
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.AllowAnimations = true;
            this.btnHangHoa.AllowMouseEffects = true;
            this.btnHangHoa.AllowToggling = false;
            this.btnHangHoa.AnimationSpeed = 200;
            this.btnHangHoa.AutoGenerateColors = false;
            this.btnHangHoa.AutoRoundBorders = false;
            this.btnHangHoa.AutoSizeLeftIcon = true;
            this.btnHangHoa.AutoSizeRightIcon = true;
            this.btnHangHoa.BackColor = System.Drawing.Color.Transparent;
            this.btnHangHoa.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnHangHoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHangHoa.BackgroundImage")));
            this.btnHangHoa.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHangHoa.ButtonText = "Hàng Hóa";
            this.btnHangHoa.ButtonTextMarginLeft = 0;
            this.btnHangHoa.ColorContrastOnClick = 45;
            this.btnHangHoa.ColorContrastOnHover = 45;
            this.btnHangHoa.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnHangHoa.CustomizableEdges = borderEdges4;
            this.btnHangHoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHangHoa.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHangHoa.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnHangHoa.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnHangHoa.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnHangHoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHangHoa.ForeColor = System.Drawing.Color.White;
            this.btnHangHoa.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHangHoa.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnHangHoa.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnHangHoa.IconMarginLeft = 11;
            this.btnHangHoa.IconPadding = 10;
            this.btnHangHoa.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHangHoa.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnHangHoa.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnHangHoa.IconSize = 25;
            this.btnHangHoa.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnHangHoa.IdleBorderRadius = 50;
            this.btnHangHoa.IdleBorderThickness = 1;
            this.btnHangHoa.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnHangHoa.IdleIconLeftImage = null;
            this.btnHangHoa.IdleIconRightImage = null;
            this.btnHangHoa.IndicateFocus = false;
            this.btnHangHoa.Location = new System.Drawing.Point(9, 132);
            this.btnHangHoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHangHoa.OnDisabledState.BorderRadius = 50;
            this.btnHangHoa.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHangHoa.OnDisabledState.BorderThickness = 1;
            this.btnHangHoa.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnHangHoa.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnHangHoa.OnDisabledState.IconLeftImage = null;
            this.btnHangHoa.OnDisabledState.IconRightImage = null;
            this.btnHangHoa.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnHangHoa.onHoverState.BorderRadius = 50;
            this.btnHangHoa.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHangHoa.onHoverState.BorderThickness = 1;
            this.btnHangHoa.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnHangHoa.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnHangHoa.onHoverState.IconLeftImage = null;
            this.btnHangHoa.onHoverState.IconRightImage = null;
            this.btnHangHoa.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnHangHoa.OnIdleState.BorderRadius = 50;
            this.btnHangHoa.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHangHoa.OnIdleState.BorderThickness = 1;
            this.btnHangHoa.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnHangHoa.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnHangHoa.OnIdleState.IconLeftImage = null;
            this.btnHangHoa.OnIdleState.IconRightImage = null;
            this.btnHangHoa.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnHangHoa.OnPressedState.BorderRadius = 50;
            this.btnHangHoa.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHangHoa.OnPressedState.BorderThickness = 1;
            this.btnHangHoa.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnHangHoa.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnHangHoa.OnPressedState.IconLeftImage = null;
            this.btnHangHoa.OnPressedState.IconRightImage = null;
            this.btnHangHoa.Size = new System.Drawing.Size(126, 47);
            this.btnHangHoa.TabIndex = 1;
            this.btnHangHoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHangHoa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHangHoa.TextMarginLeft = 0;
            this.btnHangHoa.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnHangHoa.UseDefaultRadiusAndThickness = true;
            this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(150, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(893, 559);
            this.mainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 559);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnHangHoa;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnHoaDon;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnNhanVien;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnKhachHang;
        private System.Windows.Forms.Panel mainPanel;
    }
}