
namespace WindowsFormsApp
{
    partial class FormDoiMatKhauMoi
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtHoVaTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSĐT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnEye = new FontAwesome.Sharp.IconButton();
            this.btnEyeSlash = new FontAwesome.Sharp.IconButton();
            this.btnEyeMKM = new FontAwesome.Sharp.IconButton();
            this.btneyemkmeye = new FontAwesome.Sharp.IconButton();
            this.txtMKMOI = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXNMKeyeslach = new FontAwesome.Sharp.IconButton();
            this.btnXNMKMeye = new FontAwesome.Sharp.IconButton();
            this.txtXNMKmOI = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "Đổi mật khẩu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(3, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 1);
            this.panel3.TabIndex = 16;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtHoVaTen.BorderColor = System.Drawing.Color.Silver;
            this.txtHoVaTen.BorderRadius = 5;
            this.txtHoVaTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoVaTen.DefaultText = "Nhập mật khẩu hiện tại";
            this.txtHoVaTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoVaTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoVaTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoVaTen.DisabledState.Parent = this.txtHoVaTen;
            this.txtHoVaTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoVaTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoVaTen.FocusedState.Parent = this.txtHoVaTen;
            this.txtHoVaTen.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtHoVaTen.ForeColor = System.Drawing.Color.DarkGray;
            this.txtHoVaTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoVaTen.HoverState.Parent = this.txtHoVaTen;
            this.txtHoVaTen.Location = new System.Drawing.Point(12, 136);
            this.txtHoVaTen.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.PasswordChar = '\0';
            this.txtHoVaTen.PlaceholderText = "";
            this.txtHoVaTen.SelectedText = "";
            this.txtHoVaTen.SelectionStart = 22;
            this.txtHoVaTen.ShadowDecoration.Parent = this.txtHoVaTen;
            this.txtHoVaTen.Size = new System.Drawing.Size(442, 54);
            this.txtHoVaTen.TabIndex = 246;
            this.txtHoVaTen.Click += new System.EventHandler(this.txtHoVaTen_Click);
            this.txtHoVaTen.Leave += new System.EventHandler(this.txtHoVaTen_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(318, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 35);
            this.label6.TabIndex = 245;
            this.label6.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(13, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(313, 32);
            this.label8.TabIndex = 244;
            this.label8.Text = "Mật khẩu tài khoản đang đăng nhập";
            // 
            // txtSĐT
            // 
            this.txtSĐT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSĐT.BorderColor = System.Drawing.Color.Silver;
            this.txtSĐT.BorderRadius = 5;
            this.txtSĐT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSĐT.DefaultText = "Nhập tên nv";
            this.txtSĐT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSĐT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSĐT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSĐT.DisabledState.Parent = this.txtSĐT;
            this.txtSĐT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSĐT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSĐT.FocusedState.Parent = this.txtSĐT;
            this.txtSĐT.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtSĐT.ForeColor = System.Drawing.Color.Black;
            this.txtSĐT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSĐT.HoverState.Parent = this.txtSĐT;
            this.txtSĐT.Location = new System.Drawing.Point(514, 134);
            this.txtSĐT.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.PasswordChar = '\0';
            this.txtSĐT.PlaceholderText = "";
            this.txtSĐT.ReadOnly = true;
            this.txtSĐT.SelectedText = "";
            this.txtSĐT.SelectionStart = 11;
            this.txtSĐT.ShadowDecoration.Parent = this.txtSĐT;
            this.txtSĐT.Size = new System.Drawing.Size(484, 56);
            this.txtSĐT.TabIndex = 248;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(515, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 247;
            this.label1.Text = "Số  điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(639, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 35);
            this.label2.TabIndex = 249;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(12, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 32);
            this.label4.TabIndex = 250;
            this.label4.Text = "Mật khẩu mới\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(515, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 32);
            this.label5.TabIndex = 252;
            this.label5.Text = "Xác nhận mật khẩu mới\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(137, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 35);
            this.label7.TabIndex = 254;
            this.label7.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(723, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 35);
            this.label9.TabIndex = 255;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(13, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 32);
            this.label10.TabIndex = 256;
            this.label10.Text = "Lưu ý:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label11.Location = new System.Drawing.Point(93, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(277, 32);
            this.label11.TabIndex = 257;
            this.label11.Text = "Mật khẩu của bạn cần thỏa mãn\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label12.Location = new System.Drawing.Point(12, 479);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(774, 32);
            this.label12.TabIndex = 258;
            this.label12.Text = "-   Sau khi đổi mật khẩu. Hệ thống sẽ tự động thoát.  Bạn sẽ đăng nhập bằng mật k" +
    "hẩu mới.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label13.Location = new System.Drawing.Point(13, 421);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(739, 32);
            this.label13.TabIndex = 259;
            this.label13.Text = "-   Mật khẩu cần đảm bảo các chữ cái, chữ số và ký tự đặt biệt để nâng cao tính b" +
    "ảo mật.";
            // 
            // btnHuy
            // 
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnHuy.FlatAppearance.BorderSize = 2;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnHuy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHuy.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            this.btnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuy.IconSize = 25;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(724, 532);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHuy.Size = new System.Drawing.Size(114, 45);
            this.btnHuy.TabIndex = 261;
            this.btnHuy.Text = "     Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.FlatAppearance.BorderSize = 2;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLuu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.IconSize = 25;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(875, 532);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLuu.Size = new System.Drawing.Size(114, 45);
            this.btnLuu.TabIndex = 260;
            this.btnLuu.Text = "    Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnEye
            // 
            this.btnEye.BackColor = System.Drawing.Color.White;
            this.btnEye.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEye.FlatAppearance.BorderSize = 0;
            this.btnEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEye.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEye.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnEye.IconColor = System.Drawing.Color.Gray;
            this.btnEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEye.IconSize = 30;
            this.btnEye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEye.Location = new System.Drawing.Point(378, 146);
            this.btnEye.Name = "btnEye";
            this.btnEye.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEye.Size = new System.Drawing.Size(59, 33);
            this.btnEye.TabIndex = 262;
            this.btnEye.Text = "  ";
            this.btnEye.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEye.UseVisualStyleBackColor = false;
            this.btnEye.Click += new System.EventHandler(this.btnEye_Click);
            // 
            // btnEyeSlash
            // 
            this.btnEyeSlash.BackColor = System.Drawing.Color.White;
            this.btnEyeSlash.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEyeSlash.FlatAppearance.BorderSize = 0;
            this.btnEyeSlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEyeSlash.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEyeSlash.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEyeSlash.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnEyeSlash.IconColor = System.Drawing.Color.DimGray;
            this.btnEyeSlash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEyeSlash.IconSize = 30;
            this.btnEyeSlash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEyeSlash.Location = new System.Drawing.Point(378, 146);
            this.btnEyeSlash.Name = "btnEyeSlash";
            this.btnEyeSlash.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEyeSlash.Size = new System.Drawing.Size(56, 33);
            this.btnEyeSlash.TabIndex = 263;
            this.btnEyeSlash.Text = "  ";
            this.btnEyeSlash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEyeSlash.UseVisualStyleBackColor = false;
            this.btnEyeSlash.Click += new System.EventHandler(this.btnEyeSlash_Click);
            // 
            // btnEyeMKM
            // 
            this.btnEyeMKM.BackColor = System.Drawing.Color.White;
            this.btnEyeMKM.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEyeMKM.FlatAppearance.BorderSize = 0;
            this.btnEyeMKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEyeMKM.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEyeMKM.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEyeMKM.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnEyeMKM.IconColor = System.Drawing.Color.DimGray;
            this.btnEyeMKM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEyeMKM.IconSize = 30;
            this.btnEyeMKM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEyeMKM.Location = new System.Drawing.Point(378, 272);
            this.btnEyeMKM.Name = "btnEyeMKM";
            this.btnEyeMKM.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEyeMKM.Size = new System.Drawing.Size(56, 33);
            this.btnEyeMKM.TabIndex = 266;
            this.btnEyeMKM.Text = "  ";
            this.btnEyeMKM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEyeMKM.UseVisualStyleBackColor = false;
            this.btnEyeMKM.Click += new System.EventHandler(this.btnEyeMKM_Click_1);
            // 
            // btneyemkmeye
            // 
            this.btneyemkmeye.BackColor = System.Drawing.Color.White;
            this.btneyemkmeye.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btneyemkmeye.FlatAppearance.BorderSize = 0;
            this.btneyemkmeye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneyemkmeye.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneyemkmeye.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btneyemkmeye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btneyemkmeye.IconColor = System.Drawing.Color.Gray;
            this.btneyemkmeye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneyemkmeye.IconSize = 30;
            this.btneyemkmeye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneyemkmeye.Location = new System.Drawing.Point(378, 273);
            this.btneyemkmeye.Name = "btneyemkmeye";
            this.btneyemkmeye.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btneyemkmeye.Size = new System.Drawing.Size(59, 33);
            this.btneyemkmeye.TabIndex = 265;
            this.btneyemkmeye.Text = "  ";
            this.btneyemkmeye.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneyemkmeye.UseVisualStyleBackColor = false;
            this.btneyemkmeye.Click += new System.EventHandler(this.btneyemkmeye_Click);
            // 
            // txtMKMOI
            // 
            this.txtMKMOI.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMKMOI.BorderColor = System.Drawing.Color.Silver;
            this.txtMKMOI.BorderRadius = 5;
            this.txtMKMOI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKMOI.DefaultText = "Mật khẩu mới\r\n";
            this.txtMKMOI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMKMOI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMKMOI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKMOI.DisabledState.Parent = this.txtMKMOI;
            this.txtMKMOI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKMOI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMKMOI.FocusedState.Parent = this.txtMKMOI;
            this.txtMKMOI.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtMKMOI.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMKMOI.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMKMOI.HoverState.Parent = this.txtMKMOI;
            this.txtMKMOI.Location = new System.Drawing.Point(12, 263);
            this.txtMKMOI.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtMKMOI.Name = "txtMKMOI";
            this.txtMKMOI.PasswordChar = '\0';
            this.txtMKMOI.PlaceholderText = "";
            this.txtMKMOI.SelectedText = "";
            this.txtMKMOI.SelectionStart = 14;
            this.txtMKMOI.ShadowDecoration.Parent = this.txtMKMOI;
            this.txtMKMOI.Size = new System.Drawing.Size(442, 54);
            this.txtMKMOI.TabIndex = 264;
            this.txtMKMOI.Click += new System.EventHandler(this.txtMKMOI_Click);
            this.txtMKMOI.Leave += new System.EventHandler(this.txtMKMOI_Leave);
            // 
            // btnXNMKeyeslach
            // 
            this.btnXNMKeyeslach.BackColor = System.Drawing.Color.White;
            this.btnXNMKeyeslach.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXNMKeyeslach.FlatAppearance.BorderSize = 0;
            this.btnXNMKeyeslach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXNMKeyeslach.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXNMKeyeslach.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnXNMKeyeslach.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnXNMKeyeslach.IconColor = System.Drawing.Color.DimGray;
            this.btnXNMKeyeslach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXNMKeyeslach.IconSize = 30;
            this.btnXNMKeyeslach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXNMKeyeslach.Location = new System.Drawing.Point(928, 272);
            this.btnXNMKeyeslach.Name = "btnXNMKeyeslach";
            this.btnXNMKeyeslach.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnXNMKeyeslach.Size = new System.Drawing.Size(58, 33);
            this.btnXNMKeyeslach.TabIndex = 269;
            this.btnXNMKeyeslach.Text = "  ";
            this.btnXNMKeyeslach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXNMKeyeslach.UseVisualStyleBackColor = false;
            this.btnXNMKeyeslach.Click += new System.EventHandler(this.btnXNMKeyeslach_Click);
            // 
            // btnXNMKMeye
            // 
            this.btnXNMKMeye.BackColor = System.Drawing.Color.White;
            this.btnXNMKMeye.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXNMKMeye.FlatAppearance.BorderSize = 0;
            this.btnXNMKMeye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXNMKMeye.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXNMKMeye.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnXNMKMeye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnXNMKMeye.IconColor = System.Drawing.Color.Gray;
            this.btnXNMKMeye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXNMKMeye.IconSize = 30;
            this.btnXNMKMeye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXNMKMeye.Location = new System.Drawing.Point(928, 273);
            this.btnXNMKMeye.Name = "btnXNMKMeye";
            this.btnXNMKMeye.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnXNMKMeye.Size = new System.Drawing.Size(61, 33);
            this.btnXNMKMeye.TabIndex = 268;
            this.btnXNMKMeye.Text = "  ";
            this.btnXNMKMeye.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXNMKMeye.UseVisualStyleBackColor = false;
            this.btnXNMKMeye.Click += new System.EventHandler(this.btnXNMKMeye_Click);
            // 
            // txtXNMKmOI
            // 
            this.txtXNMKmOI.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtXNMKmOI.BorderColor = System.Drawing.Color.Silver;
            this.txtXNMKmOI.BorderRadius = 5;
            this.txtXNMKmOI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXNMKmOI.DefaultText = "Xác nhận mật khẩu\r\n";
            this.txtXNMKmOI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtXNMKmOI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtXNMKmOI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXNMKmOI.DisabledState.Parent = this.txtXNMKmOI;
            this.txtXNMKmOI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXNMKmOI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXNMKmOI.FocusedState.Parent = this.txtXNMKmOI;
            this.txtXNMKmOI.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtXNMKmOI.ForeColor = System.Drawing.Color.DarkGray;
            this.txtXNMKmOI.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXNMKmOI.HoverState.Parent = this.txtXNMKmOI;
            this.txtXNMKmOI.Location = new System.Drawing.Point(514, 263);
            this.txtXNMKmOI.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtXNMKmOI.Name = "txtXNMKmOI";
            this.txtXNMKmOI.PasswordChar = '\0';
            this.txtXNMKmOI.PlaceholderText = "";
            this.txtXNMKmOI.SelectedText = "";
            this.txtXNMKmOI.SelectionStart = 19;
            this.txtXNMKmOI.ShadowDecoration.Parent = this.txtXNMKmOI;
            this.txtXNMKmOI.Size = new System.Drawing.Size(484, 54);
            this.txtXNMKmOI.TabIndex = 267;
            this.txtXNMKmOI.Click += new System.EventHandler(this.guna2TextBox3_Click);
            this.txtXNMKmOI.Leave += new System.EventHandler(this.txtXNMKmOI_Leave);
            // 
            // FormDoiMatKhauMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1015, 598);
            this.Controls.Add(this.btnXNMKeyeslach);
            this.Controls.Add(this.btnXNMKMeye);
            this.Controls.Add(this.txtXNMKmOI);
            this.Controls.Add(this.btnEyeMKM);
            this.Controls.Add(this.btneyemkmeye);
            this.Controls.Add(this.txtMKMOI);
            this.Controls.Add(this.btnEyeSlash);
            this.Controls.Add(this.btnEye);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSĐT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDoiMatKhauMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoiMatKhauMoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txtHoVaTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtSĐT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton btnHuy;
        private FontAwesome.Sharp.IconButton btnLuu;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private FontAwesome.Sharp.IconButton btnEye;
        private FontAwesome.Sharp.IconButton btnEyeSlash;
        private FontAwesome.Sharp.IconButton btnEyeMKM;
        private FontAwesome.Sharp.IconButton btneyemkmeye;
        private Guna.UI2.WinForms.Guna2TextBox txtMKMOI;
        private FontAwesome.Sharp.IconButton btnXNMKeyeslach;
        private FontAwesome.Sharp.IconButton btnXNMKMeye;
        private Guna.UI2.WinForms.Guna2TextBox txtXNMKmOI;
    }
}