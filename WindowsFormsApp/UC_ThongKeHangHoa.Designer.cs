
namespace WindowsFormsApp
{
    partial class UC_ThongKeHangHoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHangHoa = new System.Windows.Forms.Panel();
            this.btnXuatBaoGia = new FontAwesome.Sharp.IconButton();
            this.txtTimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.pcbSearch = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.dgvHh = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTk = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlHangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHh)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHangHoa
            // 
            this.pnlHangHoa.Controls.Add(this.panel5);
            this.pnlHangHoa.Controls.Add(this.lblTk);
            this.pnlHangHoa.Controls.Add(this.dgvHh);
            this.pnlHangHoa.Controls.Add(this.btnXuatBaoGia);
            this.pnlHangHoa.Controls.Add(this.txtTimkiem);
            this.pnlHangHoa.Controls.Add(this.pcbSearch);
            this.pnlHangHoa.Controls.Add(this.label2);
            this.pnlHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHangHoa.Location = new System.Drawing.Point(0, 0);
            this.pnlHangHoa.Name = "pnlHangHoa";
            this.pnlHangHoa.Size = new System.Drawing.Size(1806, 1088);
            this.pnlHangHoa.TabIndex = 0;
            // 
            // btnXuatBaoGia
            // 
            this.btnXuatBaoGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.btnXuatBaoGia.FlatAppearance.BorderSize = 0;
            this.btnXuatBaoGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatBaoGia.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatBaoGia.ForeColor = System.Drawing.Color.White;
            this.btnXuatBaoGia.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.btnXuatBaoGia.IconColor = System.Drawing.Color.White;
            this.btnXuatBaoGia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXuatBaoGia.IconSize = 30;
            this.btnXuatBaoGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatBaoGia.Location = new System.Drawing.Point(1574, 46);
            this.btnXuatBaoGia.Name = "btnXuatBaoGia";
            this.btnXuatBaoGia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnXuatBaoGia.Size = new System.Drawing.Size(217, 48);
            this.btnXuatBaoGia.TabIndex = 199;
            this.btnXuatBaoGia.Text = "          Xuất báo giá";
            this.btnXuatBaoGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatBaoGia.UseVisualStyleBackColor = false;
            this.btnXuatBaoGia.Click += new System.EventHandler(this.btnXuatBaoGia_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimkiem.BorderThickness = 0;
            this.txtTimkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiem.DefaultText = "";
            this.txtTimkiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiem.DisabledState.Parent = this.txtTimkiem;
            this.txtTimkiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiem.FillColor = System.Drawing.SystemColors.ControlLight;
            this.txtTimkiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimkiem.FocusedState.Parent = this.txtTimkiem;
            this.txtTimkiem.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimkiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiem.HoverState.Parent = this.txtTimkiem;
            this.txtTimkiem.Location = new System.Drawing.Point(133, 42);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.PasswordChar = '\0';
            this.txtTimkiem.PlaceholderText = "";
            this.txtTimkiem.SelectedText = "";
            this.txtTimkiem.ShadowDecoration.Parent = this.txtTimkiem;
            this.txtTimkiem.Size = new System.Drawing.Size(296, 48);
            this.txtTimkiem.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTimkiem.TabIndex = 46;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // pcbSearch
            // 
            this.pcbSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pcbSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pcbSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.pcbSearch.IconColor = System.Drawing.SystemColors.ControlText;
            this.pcbSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pcbSearch.IconSize = 34;
            this.pcbSearch.Location = new System.Drawing.Point(425, 56);
            this.pcbSearch.Name = "pcbSearch";
            this.pcbSearch.Size = new System.Drawing.Size(36, 34);
            this.pcbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSearch.TabIndex = 45;
            this.pcbSearch.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 38);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tìm kiếm:";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // dgvHh
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvHh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHh.BackgroundColor = System.Drawing.Color.White;
            this.dgvHh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHh.ColumnHeadersHeight = 45;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHh.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvHh.EnableHeadersVisualStyles = false;
            this.dgvHh.GridColor = System.Drawing.Color.Black;
            this.dgvHh.Location = new System.Drawing.Point(21, 110);
            this.dgvHh.Name = "dgvHh";
            this.dgvHh.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHh.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHh.RowHeadersVisible = false;
            this.dgvHh.RowHeadersWidth = 62;
            this.dgvHh.RowTemplate.Height = 45;
            this.dgvHh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHh.Size = new System.Drawing.Size(1770, 948);
            this.dgvHh.TabIndex = 232;
            this.dgvHh.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHh.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHh.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHh.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHh.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHh.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHh.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvHh.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.dgvHh.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHh.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHh.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHh.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHh.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvHh.ThemeStyle.ReadOnly = true;
            this.dgvHh.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHh.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHh.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHh.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHh.ThemeStyle.RowsStyle.Height = 45;
            this.dgvHh.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHh.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblTk
            // 
            this.lblTk.AutoSize = true;
            this.lblTk.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.lblTk.Location = new System.Drawing.Point(834, 15);
            this.lblTk.Name = "lblTk";
            this.lblTk.Size = new System.Drawing.Size(214, 40);
            this.lblTk.TabIndex = 233;
            this.lblTk.Text = "Thống kê Vaccine";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(149)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1806, 2);
            this.panel5.TabIndex = 292;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.dgvHh;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.btnXuatBaoGia;
            // 
            // UC_ThongKeHangHoa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.pnlHangHoa);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ThongKeHangHoa";
            this.Size = new System.Drawing.Size(1806, 1088);
            this.pnlHangHoa.ResumeLayout(false);
            this.pnlHangHoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHangHoa;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiem;
        private FontAwesome.Sharp.IconPictureBox pcbSearch;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnXuatBaoGia;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHh;
        private System.Windows.Forms.Label lblTk;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}
