
namespace WindowsFormsApp
{
    partial class UC_ChiTietGoiTiem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTk = new System.Windows.Forms.Label();
            this.dgvGT = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbLoaiVX = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbTenVaccine = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbTenGoiTiem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpNgaytg = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSL = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaVX = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaGT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMaLoai = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGT)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTk
            // 
            this.lblTk.AutoSize = true;
            this.lblTk.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.lblTk.Location = new System.Drawing.Point(766, 12);
            this.lblTk.Name = "lblTk";
            this.lblTk.Size = new System.Drawing.Size(288, 40);
            this.lblTk.TabIndex = 250;
            this.lblTk.Text = "Quản lý chi tiết gói tiêm";
            // 
            // dgvGT
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvGT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGT.BackgroundColor = System.Drawing.Color.White;
            this.dgvGT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGT.ColumnHeadersHeight = 45;
            this.dgvGT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGT.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGT.EnableHeadersVisualStyles = false;
            this.dgvGT.GridColor = System.Drawing.Color.Black;
            this.dgvGT.Location = new System.Drawing.Point(22, 481);
            this.dgvGT.Name = "dgvGT";
            this.dgvGT.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGT.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGT.RowHeadersVisible = false;
            this.dgvGT.RowHeadersWidth = 62;
            this.dgvGT.RowTemplate.Height = 45;
            this.dgvGT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGT.Size = new System.Drawing.Size(1763, 521);
            this.dgvGT.TabIndex = 249;
            this.dgvGT.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGT.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGT.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGT.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGT.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGT.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvGT.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvGT.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.dgvGT.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGT.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvGT.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGT.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvGT.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvGT.ThemeStyle.ReadOnly = true;
            this.dgvGT.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGT.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGT.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvGT.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvGT.ThemeStyle.RowsStyle.Height = 45;
            this.dgvGT.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGT.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvGT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGT_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Mã gói tiêm";
            this.Column1.FillWeight = 67.70961F;
            this.Column1.HeaderText = "Mã gói tiêm ";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Mã Vaccine";
            this.Column2.FillWeight = 68.18182F;
            this.Column2.HeaderText = "Mã Vaccine";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Tên gói tiêm";
            this.Column3.FillWeight = 175.4284F;
            this.Column3.HeaderText = "Tên gói tiêm";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Tên Vaccine";
            this.Column4.FillWeight = 136.3603F;
            this.Column4.HeaderText = "Tên Vaccine";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Ngày phát hàng";
            this.Column5.FillWeight = 84.15864F;
            this.Column5.HeaderText = "Ngày phát hành";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Số liều";
            this.Column6.FillWeight = 68.16131F;
            this.Column6.HeaderText = "Số liều";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cmbLoaiVX);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.cmbTenVaccine);
            this.panel2.Controls.Add(this.cmbTenGoiTiem);
            this.panel2.Controls.Add(this.dtpNgaytg);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtSL);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtTimkiem);
            this.panel2.Controls.Add(this.txtMaVX);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.txtMaGT);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(22, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1763, 401);
            this.panel2.TabIndex = 248;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cmbLoaiVX
            // 
            this.cmbLoaiVX.BackColor = System.Drawing.Color.Transparent;
            this.cmbLoaiVX.BorderColor = System.Drawing.Color.Black;
            this.cmbLoaiVX.BorderRadius = 3;
            this.cmbLoaiVX.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoaiVX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiVX.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiVX.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiVX.FocusedState.Parent = this.cmbLoaiVX;
            this.cmbLoaiVX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbLoaiVX.ForeColor = System.Drawing.Color.Black;
            this.cmbLoaiVX.HoverState.Parent = this.cmbLoaiVX;
            this.cmbLoaiVX.ItemHeight = 30;
            this.cmbLoaiVX.Items.AddRange(new object[] {
            "----- Chọn loại Vaccine  -----"});
            this.cmbLoaiVX.ItemsAppearance.Parent = this.cmbLoaiVX;
            this.cmbLoaiVX.Location = new System.Drawing.Point(1264, 123);
            this.cmbLoaiVX.Name = "cmbLoaiVX";
            this.cmbLoaiVX.ShadowDecoration.Parent = this.cmbLoaiVX;
            this.cmbLoaiVX.Size = new System.Drawing.Size(484, 36);
            this.cmbLoaiVX.TabIndex = 250;
            this.cmbLoaiVX.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiVX_SelectedIndexChanged);
            this.cmbLoaiVX.Click += new System.EventHandler(this.cmbLoaiVX_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(1382, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 35);
            this.label14.TabIndex = 249;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1258, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 35);
            this.label15.TabIndex = 248;
            this.label15.Text = "Loại Vaccine";
            // 
            // cmbTenVaccine
            // 
            this.cmbTenVaccine.BackColor = System.Drawing.Color.Transparent;
            this.cmbTenVaccine.BorderColor = System.Drawing.Color.Black;
            this.cmbTenVaccine.BorderRadius = 3;
            this.cmbTenVaccine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenVaccine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenVaccine.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenVaccine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenVaccine.FocusedState.Parent = this.cmbTenVaccine;
            this.cmbTenVaccine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTenVaccine.ForeColor = System.Drawing.Color.Black;
            this.cmbTenVaccine.HoverState.Parent = this.cmbTenVaccine;
            this.cmbTenVaccine.ItemHeight = 30;
            this.cmbTenVaccine.Items.AddRange(new object[] {
            "----- Chọn tên Vaccine  -----"});
            this.cmbTenVaccine.ItemsAppearance.Parent = this.cmbTenVaccine;
            this.cmbTenVaccine.Location = new System.Drawing.Point(667, 123);
            this.cmbTenVaccine.Name = "cmbTenVaccine";
            this.cmbTenVaccine.ShadowDecoration.Parent = this.cmbTenVaccine;
            this.cmbTenVaccine.Size = new System.Drawing.Size(507, 36);
            this.cmbTenVaccine.TabIndex = 247;
            this.cmbTenVaccine.SelectedIndexChanged += new System.EventHandler(this.cmbTenVaccine_SelectedIndexChanged);
            // 
            // cmbTenGoiTiem
            // 
            this.cmbTenGoiTiem.BackColor = System.Drawing.Color.Transparent;
            this.cmbTenGoiTiem.BorderColor = System.Drawing.Color.Black;
            this.cmbTenGoiTiem.BorderRadius = 3;
            this.cmbTenGoiTiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenGoiTiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenGoiTiem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenGoiTiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenGoiTiem.FocusedState.Parent = this.cmbTenGoiTiem;
            this.cmbTenGoiTiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTenGoiTiem.ForeColor = System.Drawing.Color.Black;
            this.cmbTenGoiTiem.HoverState.Parent = this.cmbTenGoiTiem;
            this.cmbTenGoiTiem.ItemHeight = 30;
            this.cmbTenGoiTiem.Items.AddRange(new object[] {
            "----- Chọn gói tiêm -----"});
            this.cmbTenGoiTiem.ItemsAppearance.Parent = this.cmbTenGoiTiem;
            this.cmbTenGoiTiem.Location = new System.Drawing.Point(29, 123);
            this.cmbTenGoiTiem.Name = "cmbTenGoiTiem";
            this.cmbTenGoiTiem.ShadowDecoration.Parent = this.cmbTenGoiTiem;
            this.cmbTenGoiTiem.Size = new System.Drawing.Size(534, 36);
            this.cmbTenGoiTiem.TabIndex = 246;
            this.cmbTenGoiTiem.SelectedIndexChanged += new System.EventHandler(this.cmbTenGoiTiem_SelectedIndexChanged);
            this.cmbTenGoiTiem.Click += new System.EventHandler(this.cmbTenGoiTiem_Click);
            // 
            // dtpNgaytg
            // 
            this.dtpNgaytg.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaytg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaytg.Location = new System.Drawing.Point(1426, 231);
            this.dtpNgaytg.Name = "dtpNgaytg";
            this.dtpNgaytg.Size = new System.Drawing.Size(322, 33);
            this.dtpNgaytg.TabIndex = 245;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1420, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 35);
            this.label13.TabIndex = 244;
            this.label13.Text = "Ngày phát hành";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(1121, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 35);
            this.label11.TabIndex = 243;
            this.label11.Text = "*";
            // 
            // txtSL
            // 
            this.txtSL.BorderColor = System.Drawing.Color.Silver;
            this.txtSL.BorderRadius = 5;
            this.txtSL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSL.DefaultText = "Nhập số lượng\r\n\r\n";
            this.txtSL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSL.DisabledState.Parent = this.txtSL;
            this.txtSL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSL.FocusedState.Parent = this.txtSL;
            this.txtSL.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.ForeColor = System.Drawing.Color.Gray;
            this.txtSL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSL.HoverState.Parent = this.txtSL;
            this.txtSL.Location = new System.Drawing.Point(1032, 231);
            this.txtSL.Margin = new System.Windows.Forms.Padding(7);
            this.txtSL.Name = "txtSL";
            this.txtSL.PasswordChar = '\0';
            this.txtSL.PlaceholderText = "";
            this.txtSL.SelectedText = "";
            this.txtSL.SelectionStart = 17;
            this.txtSL.ShadowDecoration.Parent = this.txtSL;
            this.txtSL.Size = new System.Drawing.Size(347, 49);
            this.txtSL.TabIndex = 242;
            this.txtSL.Click += new System.EventHandler(this.guna2TextBox3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1026, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 35);
            this.label12.TabIndex = 241;
            this.label12.Text = "Số lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 35);
            this.label9.TabIndex = 220;
            this.label9.Text = "Tìm kiếm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(145, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 35);
            this.label10.TabIndex = 240;
            this.label10.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(632, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 35);
            this.label8.TabIndex = 239;
            this.label8.Text = "*";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BorderColor = System.Drawing.Color.Silver;
            this.txtTimkiem.BorderRadius = 5;
            this.txtTimkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiem.DefaultText = "Tìm kiếm theo mã, tên";
            this.txtTimkiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiem.DisabledState.Parent = this.txtTimkiem;
            this.txtTimkiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiem.FocusedState.Parent = this.txtTimkiem;
            this.txtTimkiem.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtTimkiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiem.HoverState.Parent = this.txtTimkiem;
            this.txtTimkiem.Location = new System.Drawing.Point(29, 331);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(7);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.PasswordChar = '\0';
            this.txtTimkiem.PlaceholderText = "";
            this.txtTimkiem.SelectedText = "";
            this.txtTimkiem.SelectionStart = 21;
            this.txtTimkiem.ShadowDecoration.Parent = this.txtTimkiem;
            this.txtTimkiem.Size = new System.Drawing.Size(1719, 49);
            this.txtTimkiem.TabIndex = 222;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            this.txtTimkiem.Click += new System.EventHandler(this.txtTimkiem_Click);
            // 
            // txtMaVX
            // 
            this.txtMaVX.BorderColor = System.Drawing.Color.Silver;
            this.txtMaVX.BorderRadius = 5;
            this.txtMaVX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaVX.DefaultText = "Mã Vaccine\r\n\r\n";
            this.txtMaVX.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaVX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaVX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaVX.DisabledState.Parent = this.txtMaVX;
            this.txtMaVX.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaVX.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaVX.FocusedState.Parent = this.txtMaVX;
            this.txtMaVX.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVX.ForeColor = System.Drawing.Color.Gray;
            this.txtMaVX.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaVX.HoverState.Parent = this.txtMaVX;
            this.txtMaVX.Location = new System.Drawing.Point(531, 231);
            this.txtMaVX.Margin = new System.Windows.Forms.Padding(7);
            this.txtMaVX.Name = "txtMaVX";
            this.txtMaVX.PasswordChar = '\0';
            this.txtMaVX.PlaceholderText = "";
            this.txtMaVX.ReadOnly = true;
            this.txtMaVX.SelectedText = "";
            this.txtMaVX.SelectionStart = 14;
            this.txtMaVX.ShadowDecoration.Parent = this.txtMaVX;
            this.txtMaVX.Size = new System.Drawing.Size(441, 49);
            this.txtMaVX.TabIndex = 238;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(525, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 35);
            this.label7.TabIndex = 237;
            this.label7.Text = "Mã Vaccine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(783, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 35);
            this.label5.TabIndex = 235;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(661, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 35);
            this.label6.TabIndex = 234;
            this.label6.Text = "Tên Vaccine";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(10, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1747, 49);
            this.panel4.TabIndex = 232;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Thông tin chung";
            // 
            // txtMaGT
            // 
            this.txtMaGT.BorderColor = System.Drawing.Color.Silver;
            this.txtMaGT.BorderRadius = 5;
            this.txtMaGT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaGT.DefaultText = "Mã gói tiêm\r\n";
            this.txtMaGT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaGT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaGT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaGT.DisabledState.Parent = this.txtMaGT;
            this.txtMaGT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaGT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaGT.FocusedState.Parent = this.txtMaGT;
            this.txtMaGT.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGT.ForeColor = System.Drawing.Color.Gray;
            this.txtMaGT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaGT.HoverState.Parent = this.txtMaGT;
            this.txtMaGT.Location = new System.Drawing.Point(29, 231);
            this.txtMaGT.Margin = new System.Windows.Forms.Padding(7);
            this.txtMaGT.Name = "txtMaGT";
            this.txtMaGT.PasswordChar = '\0';
            this.txtMaGT.PlaceholderText = "";
            this.txtMaGT.ReadOnly = true;
            this.txtMaGT.SelectedText = "";
            this.txtMaGT.SelectionStart = 13;
            this.txtMaGT.ShadowDecoration.Parent = this.txtMaGT;
            this.txtMaGT.Size = new System.Drawing.Size(448, 49);
            this.txtMaGT.TabIndex = 220;
            this.txtMaGT.TextChanged += new System.EventHandler(this.txtMaGT_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 35);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mã gói tiêm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(145, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 35);
            this.label3.TabIndex = 19;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 35);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên gói tiêm";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(10, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1355, 1);
            this.panel3.TabIndex = 16;
            // 
            // lblMaLoai
            // 
            this.lblMaLoai.AutoSize = true;
            this.lblMaLoai.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLoai.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMaLoai.Location = new System.Drawing.Point(1314, 16);
            this.lblMaLoai.Name = "lblMaLoai";
            this.lblMaLoai.Size = new System.Drawing.Size(125, 35);
            this.lblMaLoai.TabIndex = 251;
            this.lblMaLoai.Text = "Mã Vaccine";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1806, 2);
            this.panel5.TabIndex = 251;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.panel4;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 15;
            this.guna2Elipse3.TargetControl = this.dgvGT;
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.btnSua.FlatAppearance.BorderSize = 2;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnSua.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 30;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(1617, 1021);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSua.Size = new System.Drawing.Size(167, 45);
            this.btnSua.TabIndex = 254;
            this.btnSua.Text = "         Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.btnXoa.FlatAppearance.BorderSize = 2;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 30;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1408, 1021);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnXoa.Size = new System.Drawing.Size(167, 45);
            this.btnXoa.TabIndex = 253;
            this.btnXoa.Text = "         Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.btnThem.FlatAppearance.BorderSize = 2;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 30;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(1196, 1021);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThem.Size = new System.Drawing.Size(167, 45);
            this.btnThem.TabIndex = 252;
            this.btnThem.Text = "        Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // UC_ChiTietGoiTiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lblMaLoai);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblTk);
            this.Controls.Add(this.dgvGT);
            this.Controls.Add(this.panel2);
            this.Name = "UC_ChiTietGoiTiem";
            this.Size = new System.Drawing.Size(1806, 1088);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGT)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTk;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiem;
        private Guna.UI2.WinForms.Guna2TextBox txtMaGT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtSL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtMaVX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgaytg;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTenVaccine;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTenGoiTiem;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLoaiVX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblMaLoai;
    }
}
