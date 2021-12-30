
namespace WindowsFormsApp
{
    partial class FormSignUp
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDangKy = new Guna.UI2.WinForms.Guna2GradientButton();
            this.chkHienThiMK = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTennv = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSĐT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiachi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblThongbao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 1156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BorderRadius = 15;
            this.btnDangKy.CheckedState.Parent = this.btnDangKy;
            this.btnDangKy.CustomImages.Parent = this.btnDangKy;
            this.btnDangKy.DisabledState.Parent = this.btnDangKy;
            this.btnDangKy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(122)))));
            this.btnDangKy.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(122)))));
            this.btnDangKy.FocusedColor = System.Drawing.Color.White;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.HoverState.Parent = this.btnDangKy;
            this.btnDangKy.Location = new System.Drawing.Point(33, 953);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.ShadowDecoration.Parent = this.btnDangKy;
            this.btnDangKy.Size = new System.Drawing.Size(547, 64);
            this.btnDangKy.TabIndex = 33;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // chkHienThiMK
            // 
            this.chkHienThiMK.AutoSize = true;
            this.chkHienThiMK.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHienThiMK.Location = new System.Drawing.Point(31, 889);
            this.chkHienThiMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkHienThiMK.Name = "chkHienThiMK";
            this.chkHienThiMK.Size = new System.Drawing.Size(206, 39);
            this.chkHienThiMK.TabIndex = 32;
            this.chkHienThiMK.Text = "Hiển thị mật khẩu";
            this.chkHienThiMK.UseVisualStyleBackColor = true;
            this.chkHienThiMK.CheckedChanged += new System.EventHandler(this.chkHienThiMK_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 769);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 35);
            this.label3.TabIndex = 31;
            this.label3.Text = "Mật khẩu";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.BorderColor = System.Drawing.Color.Silver;
            this.txtMatkhau.BorderRadius = 5;
            this.txtMatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatkhau.DefaultText = "*****";
            this.txtMatkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatkhau.DisabledState.Parent = this.txtMatkhau;
            this.txtMatkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatkhau.FocusedState.Parent = this.txtMatkhau;
            this.txtMatkhau.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtMatkhau.ForeColor = System.Drawing.Color.Silver;
            this.txtMatkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatkhau.HoverState.Parent = this.txtMatkhau;
            this.txtMatkhau.Location = new System.Drawing.Point(31, 810);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(6);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.PlaceholderText = "";
            this.txtMatkhau.SelectedText = "";
            this.txtMatkhau.SelectionStart = 5;
            this.txtMatkhau.ShadowDecoration.BorderRadius = 10;
            this.txtMatkhau.ShadowDecoration.Parent = this.txtMatkhau;
            this.txtMatkhau.Size = new System.Drawing.Size(559, 47);
            this.txtMatkhau.TabIndex = 30;
            this.txtMatkhau.TextOffset = new System.Drawing.Point(15, 0);
            this.txtMatkhau.Click += new System.EventHandler(this.txtMatkhau_Click);
            this.txtMatkhau.Leave += new System.EventHandler(this.txtMatkhau_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 633);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 35);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tài khoản";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderColor = System.Drawing.Color.Silver;
            this.txtTenDangNhap.BorderRadius = 5;
            this.txtTenDangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDangNhap.DefaultText = "VD:  VanA";
            this.txtTenDangNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDangNhap.DisabledState.Parent = this.txtTenDangNhap;
            this.txtTenDangNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDangNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDangNhap.FocusedState.Parent = this.txtTenDangNhap;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.Silver;
            this.txtTenDangNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDangNhap.HoverState.Parent = this.txtTenDangNhap;
            this.txtTenDangNhap.Location = new System.Drawing.Point(32, 673);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.PasswordChar = '\0';
            this.txtTenDangNhap.PlaceholderText = "";
            this.txtTenDangNhap.SelectedText = "";
            this.txtTenDangNhap.SelectionStart = 9;
            this.txtTenDangNhap.ShadowDecoration.BorderRadius = 10;
            this.txtTenDangNhap.ShadowDecoration.Parent = this.txtTenDangNhap;
            this.txtTenDangNhap.Size = new System.Drawing.Size(560, 47);
            this.txtTenDangNhap.TabIndex = 28;
            this.txtTenDangNhap.TextOffset = new System.Drawing.Point(15, 0);
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            this.txtTenDangNhap.Click += new System.EventHandler(this.txtTenDangNhap_Click);
            this.txtTenDangNhap.Leave += new System.EventHandler(this.txtTenDangNhap_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 35);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tên người dùng";
            // 
            // txtTennv
            // 
            this.txtTennv.BorderColor = System.Drawing.Color.Silver;
            this.txtTennv.BorderRadius = 5;
            this.txtTennv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTennv.DefaultText = "VD:  Nguyễn Văn A\r\n";
            this.txtTennv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTennv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTennv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTennv.DisabledState.Parent = this.txtTennv;
            this.txtTennv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTennv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTennv.FocusedState.Parent = this.txtTennv;
            this.txtTennv.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtTennv.ForeColor = System.Drawing.Color.Silver;
            this.txtTennv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTennv.HoverState.Parent = this.txtTennv;
            this.txtTennv.Location = new System.Drawing.Point(31, 240);
            this.txtTennv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.PasswordChar = '\0';
            this.txtTennv.PlaceholderText = "";
            this.txtTennv.SelectedText = "";
            this.txtTennv.SelectionStart = 19;
            this.txtTennv.ShadowDecoration.BorderRadius = 10;
            this.txtTennv.ShadowDecoration.Parent = this.txtTennv;
            this.txtTennv.Size = new System.Drawing.Size(561, 47);
            this.txtTennv.TabIndex = 35;
            this.txtTennv.TextOffset = new System.Drawing.Point(15, 0);
            this.txtTennv.TextChanged += new System.EventHandler(this.txtTennv_TextChanged);
            this.txtTennv.Click += new System.EventHandler(this.txtTennv_Click);
            this.txtTennv.Leave += new System.EventHandler(this.txtTennv_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 35);
            this.label5.TabIndex = 38;
            this.label5.Text = "Số điện thoại";
            // 
            // txtSĐT
            // 
            this.txtSĐT.BorderColor = System.Drawing.Color.Silver;
            this.txtSĐT.BorderRadius = 5;
            this.txtSĐT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSĐT.DefaultText = "VD:  0328644258";
            this.txtSĐT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSĐT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSĐT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSĐT.DisabledState.Parent = this.txtSĐT;
            this.txtSĐT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSĐT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSĐT.FocusedState.Parent = this.txtSĐT;
            this.txtSĐT.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtSĐT.ForeColor = System.Drawing.Color.Silver;
            this.txtSĐT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSĐT.HoverState.Parent = this.txtSĐT;
            this.txtSĐT.Location = new System.Drawing.Point(33, 350);
            this.txtSĐT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.PasswordChar = '\0';
            this.txtSĐT.PlaceholderText = "";
            this.txtSĐT.SelectedText = "";
            this.txtSĐT.SelectionStart = 15;
            this.txtSĐT.ShadowDecoration.BorderRadius = 10;
            this.txtSĐT.ShadowDecoration.Parent = this.txtSĐT;
            this.txtSĐT.Size = new System.Drawing.Size(559, 47);
            this.txtSĐT.TabIndex = 37;
            this.txtSĐT.TextOffset = new System.Drawing.Point(15, 0);
            this.txtSĐT.TextChanged += new System.EventHandler(this.txtSĐT_TextChanged);
            this.txtSĐT.Click += new System.EventHandler(this.txtSĐT_Click);
            this.txtSĐT.Leave += new System.EventHandler(this.txtSĐT_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 35);
            this.label6.TabIndex = 40;
            this.label6.Text = "Địa chi";
            // 
            // txtDiachi
            // 
            this.txtDiachi.BorderColor = System.Drawing.Color.Silver;
            this.txtDiachi.BorderRadius = 5;
            this.txtDiachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiachi.DefaultText = "VD:  An Chấn, Tuy An, Phú Yên";
            this.txtDiachi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiachi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiachi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiachi.DisabledState.Parent = this.txtDiachi;
            this.txtDiachi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiachi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiachi.FocusedState.Parent = this.txtDiachi;
            this.txtDiachi.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtDiachi.ForeColor = System.Drawing.Color.Silver;
            this.txtDiachi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiachi.HoverState.Parent = this.txtDiachi;
            this.txtDiachi.Location = new System.Drawing.Point(33, 462);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.PasswordChar = '\0';
            this.txtDiachi.PlaceholderText = "";
            this.txtDiachi.SelectedText = "";
            this.txtDiachi.SelectionStart = 29;
            this.txtDiachi.ShadowDecoration.BorderRadius = 10;
            this.txtDiachi.ShadowDecoration.Parent = this.txtDiachi;
            this.txtDiachi.Size = new System.Drawing.Size(559, 47);
            this.txtDiachi.TabIndex = 39;
            this.txtDiachi.TextOffset = new System.Drawing.Point(15, 0);
            this.txtDiachi.Click += new System.EventHandler(this.txtDiachi_Click);
            this.txtDiachi.Leave += new System.EventHandler(this.txtDiachi_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 35);
            this.label7.TabIndex = 41;
            this.label7.Text = "Giới tính";
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cmbGioiTinh.BorderColor = System.Drawing.Color.Black;
            this.cmbGioiTinh.BorderRadius = 5;
            this.cmbGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGioiTinh.FocusedState.Parent = this.cmbGioiTinh;
            this.cmbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.cmbGioiTinh.HoverState.Parent = this.cmbGioiTinh;
            this.cmbGioiTinh.ItemHeight = 30;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "----- Chọn giới tính -----",
            "Nam",
            "Nữ",
            "Khác"});
            this.cmbGioiTinh.ItemsAppearance.Parent = this.cmbGioiTinh;
            this.cmbGioiTinh.Location = new System.Drawing.Point(34, 572);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.ShadowDecoration.Parent = this.cmbGioiTinh;
            this.cmbGioiTinh.Size = new System.Drawing.Size(542, 36);
            this.cmbGioiTinh.TabIndex = 263;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(12, 1045);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 1);
            this.panel2.TabIndex = 264;
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(122)))));
            this.lblDangNhap.Location = new System.Drawing.Point(228, 1106);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(141, 40);
            this.lblDangNhap.TabIndex = 266;
            this.lblDangNhap.Text = "Đăng nhập";
            this.lblDangNhap.Click += new System.EventHandler(this.lblDangNhap_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(133, 1057);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(350, 80);
            this.label8.TabIndex = 265;
            this.label8.Text = "Tài khoản của bạn đã sẵn sàng?\r\n\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(198, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 35);
            this.label9.TabIndex = 267;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(166, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 35);
            this.label10.TabIndex = 268;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(134, 633);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 35);
            this.label11.TabIndex = 269;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(134, 769);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 35);
            this.label12.TabIndex = 270;
            this.label12.Text = "*";
            // 
            // lblThongbao
            // 
            this.lblThongbao.AutoSize = true;
            this.lblThongbao.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongbao.ForeColor = System.Drawing.Color.White;
            this.lblThongbao.Location = new System.Drawing.Point(33, 725);
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(77, 26);
            this.lblThongbao.TabIndex = 271;
            this.lblThongbao.Text = "Mật khẩu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::WindowsFormsApp.Properties.Resources.â;
            this.pictureBox1.Location = new System.Drawing.Point(33, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 272;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(26, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 26);
            this.label2.TabIndex = 274;
            this.label2.Text = "Vui lòng đăng ký  để sử dụng phần mềm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label13.Location = new System.Drawing.Point(26, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 42);
            this.label13.TabIndex = 273;
            this.label13.Text = "Xin chào,";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 1165);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblThongbao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDangNhap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbGioiTinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSĐT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTennv);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.chkHienThiMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSignIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2GradientButton btnDangKy;
        private System.Windows.Forms.CheckBox chkHienThiMK;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtMatkhau;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtTennv;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtSĐT;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtDiachi;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGioiTinh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblThongbao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}