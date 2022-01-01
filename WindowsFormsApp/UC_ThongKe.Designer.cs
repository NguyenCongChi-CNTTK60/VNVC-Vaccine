
namespace WindowsFormsApp
{
    partial class UC_ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlTK = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdoNhanVien = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.tdoKhachhang = new System.Windows.Forms.RadioButton();
            this.rdoTKHoaDon = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLuaChon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXem = new Guna.UI2.WinForms.Guna2Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dpkNgaykt = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpkNgaybd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTK
            // 
            this.pnlTK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTK.Controls.Add(this.panel5);
            this.pnlTK.Controls.Add(this.rdoNhanVien);
            this.pnlTK.Controls.Add(this.radioButton4);
            this.pnlTK.Controls.Add(this.radioButton3);
            this.pnlTK.Controls.Add(this.tdoKhachhang);
            this.pnlTK.Controls.Add(this.rdoTKHoaDon);
            this.pnlTK.Controls.Add(this.label6);
            this.pnlTK.Controls.Add(this.label5);
            this.pnlTK.Controls.Add(this.cmbLuaChon);
            this.pnlTK.Controls.Add(this.label3);
            this.pnlTK.Controls.Add(this.btnXem);
            this.pnlTK.Controls.Add(this.chart1);
            this.pnlTK.Controls.Add(this.dpkNgaykt);
            this.pnlTK.Controls.Add(this.label4);
            this.pnlTK.Controls.Add(this.label2);
            this.pnlTK.Controls.Add(this.dpkNgaybd);
            this.pnlTK.Controls.Add(this.label1);
            this.pnlTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTK.Location = new System.Drawing.Point(0, 0);
            this.pnlTK.Name = "pnlTK";
            this.pnlTK.Size = new System.Drawing.Size(1806, 1088);
            this.pnlTK.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1806, 2);
            this.panel5.TabIndex = 291;
            // 
            // rdoNhanVien
            // 
            this.rdoNhanVien.AutoSize = true;
            this.rdoNhanVien.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.rdoNhanVien.Location = new System.Drawing.Point(1439, 1027);
            this.rdoNhanVien.Name = "rdoNhanVien";
            this.rdoNhanVien.Size = new System.Drawing.Size(155, 34);
            this.rdoNhanVien.TabIndex = 247;
            this.rdoNhanVien.TabStop = true;
            this.rdoNhanVien.Text = "Nhân viên";
            this.rdoNhanVien.UseVisualStyleBackColor = true;
            this.rdoNhanVien.CheckedChanged += new System.EventHandler(this.rdoNhanVien_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.radioButton4.Location = new System.Drawing.Point(1136, 1025);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(168, 34);
            this.radioButton4.TabIndex = 246;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Phiếu nhập";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.radioButton3.Location = new System.Drawing.Point(882, 1025);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(126, 34);
            this.radioButton3.TabIndex = 245;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Vaccine";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // tdoKhachhang
            // 
            this.tdoKhachhang.AutoSize = true;
            this.tdoKhachhang.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdoKhachhang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.tdoKhachhang.Location = new System.Drawing.Point(329, 1027);
            this.tdoKhachhang.Name = "tdoKhachhang";
            this.tdoKhachhang.Size = new System.Drawing.Size(177, 34);
            this.tdoKhachhang.TabIndex = 244;
            this.tdoKhachhang.TabStop = true;
            this.tdoKhachhang.Text = "Khách hàng";
            this.tdoKhachhang.UseVisualStyleBackColor = true;
            this.tdoKhachhang.CheckedChanged += new System.EventHandler(this.tdoKhachhang_CheckedChanged);
            // 
            // rdoTKHoaDon
            // 
            this.rdoTKHoaDon.AutoSize = true;
            this.rdoTKHoaDon.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTKHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.rdoTKHoaDon.Location = new System.Drawing.Point(628, 1027);
            this.rdoTKHoaDon.Name = "rdoTKHoaDon";
            this.rdoTKHoaDon.Size = new System.Drawing.Size(141, 34);
            this.rdoTKHoaDon.TabIndex = 243;
            this.rdoTKHoaDon.TabStop = true;
            this.rdoTKHoaDon.Text = " Hóa đơn";
            this.rdoTKHoaDon.UseVisualStyleBackColor = true;
            this.rdoTKHoaDon.CheckedChanged += new System.EventHandler(this.rdoTKHoaDon_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.label6.Location = new System.Drawing.Point(784, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 35);
            this.label6.TabIndex = 242;
            this.label6.Text = "TỔNG QUAN THỐNG KÊ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 1027);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 32);
            this.label5.TabIndex = 241;
            this.label5.Text = "THỐNG KÊ THEO:\r\n";
            // 
            // cmbLuaChon
            // 
            this.cmbLuaChon.BackColor = System.Drawing.Color.Transparent;
            this.cmbLuaChon.BorderColor = System.Drawing.Color.Black;
            this.cmbLuaChon.BorderRadius = 5;
            this.cmbLuaChon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLuaChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLuaChon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLuaChon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLuaChon.FocusedState.Parent = this.cmbLuaChon;
            this.cmbLuaChon.Font = new System.Drawing.Font("Cambria", 10F);
            this.cmbLuaChon.ForeColor = System.Drawing.Color.Black;
            this.cmbLuaChon.HoverState.Parent = this.cmbLuaChon;
            this.cmbLuaChon.ItemHeight = 30;
            this.cmbLuaChon.Items.AddRange(new object[] {
            "--- Lựa chọn xem ---",
            "Hôm qua",
            "Hôm nay",
            "Tuần này",
            "Tháng này",
            "Năm nay"});
            this.cmbLuaChon.ItemsAppearance.Parent = this.cmbLuaChon;
            this.cmbLuaChon.Location = new System.Drawing.Point(1553, 117);
            this.cmbLuaChon.Name = "cmbLuaChon";
            this.cmbLuaChon.ShadowDecoration.Parent = this.cmbLuaChon;
            this.cmbLuaChon.Size = new System.Drawing.Size(233, 36);
            this.cmbLuaChon.TabIndex = 240;
            this.cmbLuaChon.SelectedIndexChanged += new System.EventHandler(this.cmbLuaChon_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1407, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 32);
            this.label3.TabIndex = 239;
            this.label3.Text = "Lựa chọn xem:";
            // 
            // btnXem
            // 
            this.btnXem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            this.btnXem.BorderRadius = 4;
            this.btnXem.BorderThickness = 2;
            this.btnXem.CheckedState.Parent = this.btnXem;
            this.btnXem.CustomImages.Parent = this.btnXem;
            this.btnXem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXem.DisabledState.Parent = this.btnXem;
            this.btnXem.FillColor = System.Drawing.SystemColors.Control;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXem.ForeColor = System.Drawing.Color.Black;
            this.btnXem.HoverState.Parent = this.btnXem;
            this.btnXem.Location = new System.Drawing.Point(856, 121);
            this.btnXem.Name = "btnXem";
            this.btnXem.ShadowDecoration.Parent = this.btnXem;
            this.btnXem.Size = new System.Drawing.Size(124, 36);
            this.btnXem.TabIndex = 33;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(47, 186);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.LabelBorderWidth = 3;
            series1.Legend = "Legend1";
            series1.Name = "Doanh Thu";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1739, 800);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            // 
            // dpkNgaykt
            // 
            this.dpkNgaykt.BorderRadius = 5;
            this.dpkNgaykt.CheckedState.Parent = this.dpkNgaykt;
            this.dpkNgaykt.FillColor = System.Drawing.Color.White;
            this.dpkNgaykt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpkNgaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkNgaykt.HoverState.Parent = this.dpkNgaykt;
            this.dpkNgaykt.Location = new System.Drawing.Point(560, 120);
            this.dpkNgaykt.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpkNgaykt.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpkNgaykt.Name = "dpkNgaykt";
            this.dpkNgaykt.ShadowDecoration.Parent = this.dpkNgaykt;
            this.dpkNgaykt.Size = new System.Drawing.Size(228, 36);
            this.dpkNgaykt.TabIndex = 21;
            this.dpkNgaykt.Value = new System.DateTime(2021, 12, 9, 19, 36, 10, 687);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(446, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Từ ngày";
            // 
            // dpkNgaybd
            // 
            this.dpkNgaybd.BorderRadius = 5;
            this.dpkNgaybd.CheckedState.Parent = this.dpkNgaybd;
            this.dpkNgaybd.FillColor = System.Drawing.Color.White;
            this.dpkNgaybd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpkNgaybd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkNgaybd.HoverState.Parent = this.dpkNgaybd;
            this.dpkNgaybd.Location = new System.Drawing.Point(155, 117);
            this.dpkNgaybd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpkNgaybd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpkNgaybd.Name = "dpkNgaybd";
            this.dpkNgaybd.ShadowDecoration.Parent = this.dpkNgaybd;
            this.dpkNgaybd.Size = new System.Drawing.Size(220, 36);
            this.dpkNgaybd.TabIndex = 18;
            this.dpkNgaybd.Value = new System.DateTime(2021, 12, 9, 19, 36, 10, 687);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "TỔNG QUAN BÁO CÁO\r\n";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.chart1;
            // 
            // UC_ThongKe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlTK);
            this.Name = "UC_ThongKe";
            this.Size = new System.Drawing.Size(1806, 1088);
            this.pnlTK.ResumeLayout(false);
            this.pnlTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTK;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpkNgaykt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2Button btnXem;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpkNgaybd;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLuaChon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoTKHoaDon;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.RadioButton rdoNhanVien;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton tdoKhachhang;
        private System.Windows.Forms.Panel panel5;
    }
}
