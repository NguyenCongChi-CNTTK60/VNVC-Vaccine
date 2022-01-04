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
            txtMaGT.Text = Matudong();
           
        }


        private void HienThi()
        {
            dgvGT.DataSource = GoiTiemBUS.Intance.HienThi();
        }

        private string Matudong()
        {
            string query = "select MaGT from GoiTiem";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "GT001";
            }
            else
            {
                int k;
                ma = "GT";
                //k = dt.Rows.Count;
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                k++;

                if (k < 10)
                {
                    ma = ma + "00";
                }
                else if (k >= 10 && k < 100)
                {
                    ma = ma + "0";
                }
                else if (k >= 100 && k < 1000)
                {
                    ma = ma + " ";
                }
                ma = ma + k.ToString();

            }
            return ma;
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

        private void txtTenGT_Click(object sender, EventArgs e)
        {
            txtTenGT.Text = "";
            txtTenGT.ForeColor = Color.Black;
        }

        private void txtTenGT_Leave(object sender, EventArgs e)
        {
            if(txtTenGT.Text == "")
            {
                txtTenGT.Text = "Nhập tên gói tiêm";
                txtTenGT.ForeColor = Color.Gray;
            }
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = "";
            txtTimkiem.ForeColor = Color.Black;
        }

        private void txtTimkiem_Leave(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                txtTimkiem.Text = "Tìm kiếm theo tên, mã";
                txtTimkiem.ForeColor = Color.Gray;
            }
        }



        private void LamMoi()
        {
            txtTenGT.Text = "Nhập tên gói tiêm";
            txtTenGT.ForeColor = Color.Gray;
            txtMaGT.Text = Matudong();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "select MaGT from GoiTiem where MaGT = '"+txtMaGT.Text+"'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Gói tiêm đã tồn tại", "Thông báo");
                LamMoi();
            }else

            if (GoiTiemBUS.Intance.themGoiTiem(txtMaGT.Text, txtTenGT.Text))
            {
                MessageBox.Show("Thêm gói tiêm thành công", "Thông báo");
                LamMoi();
                HienThi();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (GoiTiemBUS.Intance.suaGoiTiem(txtMaGT.Text, txtTenGT.Text))
            {
                MessageBox.Show("Sửa gói tiêm thành công", "Thông báo");
                LamMoi();
                HienThi();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "select MaGT from ChiTietGoiTiem where MaGT = '" + txtMaGT.Text + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Không thể xóa", "Thông báo");
                LamMoi();
            }else
            if (GoiTiemBUS.Intance.xoaGoiTiem(txtMaGT.Text))
            {
                MessageBox.Show("Xóa gói tiêm thành công", "Thông báo");
                LamMoi();
                HienThi();
            }
        }
    }
}
