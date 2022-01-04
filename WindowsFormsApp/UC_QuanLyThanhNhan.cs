using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class UC_QuanLyThanhNhan : UserControl
    {
        public UC_QuanLyThanhNhan()
        {
            InitializeComponent();
            HienThi();
            txtMaKH.Text = Matudong();
        }


        //
        // Tạo mã hóa đơn tự động
        // 
        private string Matudong()
        {
            string query = "select MaTN from ThanNhan";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string ma = "";
            //k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
            if (dt.Rows.Count <= 0)
            {
                ma = "TN001";
            }
            else
            {
                int k;
                ma = "TN";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                // k = dt.Rows.Count;
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
                    ma = ma + "";
                }
                ma = ma + k.ToString();

            }
            return ma;
        }


        private void HienThi()
        {
            dgvTN.DataSource = KhachHangBUS.Intance.HienThiThanNhan();
        }

        private void txtKH_Click(object sender, EventArgs e)
        {
            txtKH.Text = "";
            txtKH.ForeColor = Color.Black;
        }

        private void txtKH_Leave(object sender, EventArgs e)
        {
            if(txtKH.Text == "")
            {
                txtKH.Text = "Nhập tên thân nhân";
                txtKH.ForeColor = Color.Gray;
            }
        }

        private void txtSĐT_Click(object sender, EventArgs e)
        {
            txtSĐT.Text = "";
            txtSĐT.ForeColor = Color.Black;
        }

        private void txtSĐT_Leave(object sender, EventArgs e)
        {
            if (txtSĐT.Text == "")
            {
                txtSĐT.Text = "Nhập sô điện thoại";
                txtSĐT.ForeColor = Color.Gray;
            }
        }

        private void txtMoiquanhe_Click(object sender, EventArgs e)
        {
            txtMoiquanhe.Text = "";
            txtMoiquanhe.ForeColor = Color.Black;
        }

        private void txtMoiquanhe_Leave(object sender, EventArgs e)
        {
            if (txtMoiquanhe.Text == "")
            {
                txtMoiquanhe.Text = "Nhập sô điện thoại";
                txtMoiquanhe.ForeColor = Color.Gray;
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
                txtTimkiem.Text = "Tìm kiếm theo mã, tên, sđt thân nhân";
                txtTimkiem.ForeColor = Color.Gray;
            }
        }

        private void dgvTN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            txtMaKH.Text = dgvTN.Rows[indexx].Cells[0].Value.ToString();
            txtKH.Text = dgvTN.Rows[indexx].Cells[1].Value.ToString();
            txtMoiquanhe.Text = dgvTN.Rows[indexx].Cells[2].Value.ToString();
            txtSĐT.Text = dgvTN.Rows[indexx].Cells[3].Value.ToString();
            txtMoiquanhe.ForeColor = Color.Black;
           txtSĐT.ForeColor = Color.Black;
            txtKH.ForeColor = Color.Black;
           txtMaKH.ForeColor = Color.Black;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KhachHangBUS.Intance.themTN(txtMaKH.Text, txtKH.Text, txtMoiquanhe.Text, txtSĐT.Text))
            {
                MessageBox.Show("Thêm thân nhân thành công", "Thông báo");
                HienThi();
                LamMoi();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KhachHangBUS.Intance.suaTN(txtMaKH.Text, txtKH.Text, txtMoiquanhe.Text, txtSĐT.Text))
            {
                MessageBox.Show("Sửa thân nhân thành công", "Thông báo");
                HienThi();
                LamMoi();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (KhachHangBUS.Intance.xoaTN(txtMaKH.Text))
            {
                MessageBox.Show("Xóa thân nhân thành công", "Thông báo");
                HienThi();
                LamMoi();
            }
        }


        private void LamMoi()
        {
            txtMoiquanhe.Text = "Nhập mối quan hệ";
            txtMaKH.Text = Matudong();
            txtKH.Text = "Nhập tên thân nhân";
            txtSĐT.Text = "Nhập số điện thoại";
            txtSĐT.ForeColor = Color.Gray;
            txtMoiquanhe.ForeColor = Color.Gray;
            txtMaKH.ForeColor = Color.Gray;
            txtKH.ForeColor = Color.Gray;
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                dgvTN.DataSource = KhachHangBUS.Intance.TKhanNhan(txtTimkiem.Text);
            }
            else
                HienThi();
        }
    }
}
