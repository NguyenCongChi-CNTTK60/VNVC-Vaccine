using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace WindowsFormsApp
{
    public partial class UC_NhaCungCap : UserControl
    {
        public UC_NhaCungCap()
        {
            InitializeComponent();
            HienThi();
            txtMaKH.Text = Matudong();
            txtMaKH.ForeColor = Color.Black;
        }

       

        private void txtKH_Enter(object sender, EventArgs e)
        {
            if (txtKH.Text == "Nhập tên")
            {
                txtKH.Text = "";
                txtKH.ForeColor = Color.Black;
            }
        }

        private void txtKH_Leave(object sender, EventArgs e)
        {
            if (txtKH.Text == "")
            {
                txtKH.Text = "Nhập tên";
                txtKH.ForeColor = Color.Gray;
            }
        }

        private void txtSĐT_Enter(object sender, EventArgs e)
        {
            if (txtSĐT.Text == "Nhập số điện thoại")
            {
                txtSĐT.Text = "";
                txtSĐT.ForeColor = Color.Black;
            }
        }

        private void txtSĐT_Leave(object sender, EventArgs e)
        {
            if (txtSĐT.Text == "")
            {
                txtSĐT.Text = "Nhập số điện thoại";
                txtSĐT.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Nhập địa chỉ email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Nhập địa chỉ email";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtDiachi_Enter(object sender, EventArgs e)
        {
            if (txtDiachi.Text == "Nhập địa chỉ")
            {
                txtDiachi.Text = "";
                txtDiachi.ForeColor = Color.Black;
            }
        }

        private void txtDiachi_Leave(object sender, EventArgs e)
        {
            if (txtDiachi.Text == "")
            {
                txtDiachi.Text = "Nhập địa chỉ";
                txtDiachi.ForeColor = Color.Gray;
            }
        }

        private void txtTimkiem_Enter(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "Tìm kiếm theo mã, tên")
            {
                txtTimkiem.Text = "";
                txtTimkiem.ForeColor = Color.Black;
            }
        }

        private void txtTimkiem_Leave(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                txtTimkiem.Text = "Tìm kiếm theo mã, tên";
                txtTimkiem.ForeColor = Color.Gray;
            }
        }


        private void HienThi()
        {
            DataTable dt = NhaCungCapBUS.Intance.HienThi();
            dgvNCC.DataSource = dt;
        }




        //
        // Tạo mã hóa đơn tự động
        // 
        private string Matudong()
        {
            string query = "select MaNCC from NhaCungCap";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "NCC001";
            }
            else
            {
                int k;
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(3, 3));
                ma = "NCC";             
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "select MaNCC from NhaCungCap where MaNCC = '" + txtMaKH.Text + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Nhà cung cấp đã tồn tại bạn không thể thêm", "Thông báo");
                HienThi();
                LamMoi();
            }
            else

            if (NhaCungCapBUS.Intance.themNCC(txtMaKH.Text, txtKH.Text, txtDiachi.Text, txtSĐT.Text, txtEmail.Text))
            {
                MessageBox.Show("Thêm nhà cung cấp thành công", "Thông báo");
                HienThi();
                LamMoi();
            }
        }



        private void LamMoi()
        {
            txtKH.Text = "Nhập tên";
            txtKH.ForeColor = Color.Gray;
            txtSĐT.Text = "Nhập số điện thoại";
            txtSĐT.ForeColor = Color.Gray;
            txtEmail.Text = "Nhập địa chỉ email";
            txtEmail.ForeColor = Color.Gray;
            txtDiachi.Text = "Nhập địa chỉ";
            txtDiachi.ForeColor = Color.Gray;
            txtMaKH.Text = Matudong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string query = "select MaNCC from PhieuNhap where MaNCC = '" + txtMaKH.Text + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bạn không thể xóa  nhà cung cấp này!", "Thông báo");
                HienThi();
                LamMoi();
            }else
            if (NhaCungCapBUS.Intance.xoaNCC(txtMaKH.Text))
            {
                MessageBox.Show("Xóa nhà cung cấp thành công", "Thông báo");
                HienThi();
                LamMoi();
            }
        }

     

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(NhaCungCapBUS.Intance.suaNCC(txtMaKH.Text, txtKH.Text, txtDiachi.Text, txtSĐT.Text, txtEmail.Text))
            {
                MessageBox.Show("Sửa nhà cung cấp thành công", "Thông báo");
                HienThi();
                LamMoi();
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                DataTable dt = NhaCungCapBUS.Intance.TimKiemNCC(txtTimkiem.Text);
                dgvNCC.DataSource = dt;
            } else
                HienThi();



            if(txtTimkiem.Text == "Tìm kiếm theo mã, tên")
            {
                HienThi();
            }
        }

        private void dgvNCC_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            txtMaKH.Text = dgvNCC.Rows[indexx].Cells[0].Value.ToString();
            txtKH.Text = dgvNCC.Rows[indexx].Cells[1].Value.ToString();
            txtDiachi.Text = dgvNCC.Rows[indexx].Cells[3].Value.ToString();
            txtSĐT.Text = dgvNCC.Rows[indexx].Cells[2].Value.ToString();
            txtEmail.Text = dgvNCC.Rows[indexx].Cells[4].Value.ToString();
            txtKH.ForeColor = Color.Black;
            txtSĐT.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtDiachi.ForeColor = Color.Black;
        }
    }
}
