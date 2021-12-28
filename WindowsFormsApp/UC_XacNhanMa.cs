using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class UC_XacNhanMa : UserControl
    {

        private string SĐT;
        public UC_XacNhanMa()
        {
            InitializeComponent();
            HienThi();
           
        }


        private void HienThi()
        {
            dgvGT.DataSource = GoiTiemBUS.Intance.HienThi();
        }



        private void dgvGT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            txtMaGT.Text = dgvGT.Rows[indexx].Cells[0].Value.ToString();
            txtTenGT.Text = dgvGT.Rows[indexx].Cells[1].Value.ToString();
            txtMaGT.ForeColor = Color.Black;
            txtTenGT.ForeColor = Color.Black;
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            FormReportGoiTIem formReportGoiTIem = new FormReportGoiTIem(txtMaGT.Text);
            formReportGoiTIem.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnChiTietGoiTiem_Click(object sender, EventArgs e)
        {
            UC_ChiTietGoiTiem _ChiTietGoiTiem = new UC_ChiTietGoiTiem();
            addUC(_ChiTietGoiTiem);
        }
    }
}
