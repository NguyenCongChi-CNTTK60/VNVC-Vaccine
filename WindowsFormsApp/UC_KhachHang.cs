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

namespace WindowsFormsApp
{
    public partial class UC_KhachHang : UserControl
    {
        public UC_KhachHang()
        {
            InitializeComponent();
            //LoadListKH();
            HienThi();
            txtMaKH.Text = Matudong();
            txtMaKH.ForeColor = Color.Black;
        }





        private void HienThi()
        {
            DataTable dt = KhachHangBUS.Intance.HienThi();
            dgvKH.DataSource = dt;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

    



        //
        // Tạo mã hóa đơn tự động
        // 
        private string Matudong()
        {
            string query = "select MaKH from KhachHang";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string ma = "";
            //k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
            if (dt.Rows.Count <= 0)
            {
                ma = "KH001";
            }
            else
            {
                int k;
                ma = "KH";
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



        private void LamMoi()
        {
            txtKH.Text = "Nhập tên khách hàng";
            txtKH.ForeColor = Color.Gray;
            txtSĐT.Text = "Nhập số điện thoại";
            txtSĐT.ForeColor = Color.Gray;
            txtDiachi.Text = "Nhập địa chỉ";
            txtDiachi.ForeColor = Color.Gray;
            txtTenTN.Text = "Nhập tên nhân thân";
            txtTenTN.ForeColor = Color.Gray;
        }

  




        private bool Check_data()
        {
            if (txtKH.Text == "Nhập tên khách hàng")
            {
                MessageBox.Show("Tên khách hàng là bắt buộc", "Thông báo");
                return false;
            }
            else
            if (txtSĐT.Text == "Nhập số điện thoại")
            {


                MessageBox.Show("Số điện thoại khách hàng là bắt buộc", "Thông báo");
                return false;

            }
            return true;
      
        }


        private void addUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.BringToFront();
        }


        private void btnThanNhan_Click(object sender, EventArgs e)
        {
            UC_QuanLyThanhNhan _QuanLyThanhNhan = new UC_QuanLyThanhNhan();
            addUC(_QuanLyThanhNhan);
        }

        private void txtKH_Click(object sender, EventArgs e)
        {
            txtKH.Text = "";
            txtKH.ForeColor = Color.Black;
        }

        private void txtKH_Leave_1(object sender, EventArgs e)
        {
            if (txtKH.Text == "")
            {
                txtKH.Text = "Nhập tên khách hàng";
                txtKH.ForeColor = Color.Gray;
            }
        }

        private void txtSĐT_Click(object sender, EventArgs e)
        {
            txtSĐT.Text = "";
            txtSĐT.ForeColor = Color.Black;
        }

        private void txtSĐT_Leave_1(object sender, EventArgs e)
        {
            if (txtSĐT.Text == "")
            {
                txtSĐT.Text = "Nhập số điện thoại";
                txtSĐT.ForeColor = Color.Gray;
            }
        }

        private void txtTenTN_Click(object sender, EventArgs e)
        {
            txtTenTN.Text = "";
            txtTenTN.ForeColor = Color.Black;
        }

        private void txtDiachi_Click(object sender, EventArgs e)
        {
            txtDiachi.Text = "";
            txtDiachi.ForeColor = Color.Black;
        }

        private void txtDiachi_Leave(object sender, EventArgs e)
        {
            if (txtDiachi.Text == "")
            {
                txtDiachi.Text = "Nhập địa chỉ";
                txtDiachi.ForeColor = Color.Gray;
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
                txtTimkiem.Text = "Tìm kiếm theo mã, tên, sđt khách hàng";
                txtTimkiem.ForeColor = Color.Gray;
            }
        }

        private void txtTenTN_Leave(object sender, EventArgs e)
        {
            if (txtTenTN.Text == "")
            {
                txtTenTN.Text = "Nhập tên thân nhân";
                txtTenTN.ForeColor = Color.Gray;
            }
        }


        string matn;
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (Check_data() == true)
            {
                string query = "select MaKH as [MaKhachHang] from KhachHang where MaKH = '" + txtMaKH.Text + "'";
                DataTable dt = DataProvider.Instance.ExecuteQuery(query);
                string query1 = "select MaTN as [MaThanNhan] from ThanNhan where TenTN = N'" + txtTenTN.Text + "'";
                DataTable dt1 = DataProvider.Instance.ExecuteQuery(query1);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Khách hàng đã tồn tại bạn không thể thêm", "Thông báo");
                    LamMoi();
                    txtMaKH.Text = Matudong();
                }
                else if (dt1.Rows.Count > 0)
                {
                     matn = dt1.Rows[0]["MaThanNhan"].ToString();
                    if (KhachHangBUS.Intance.themKH(txtMaKH.Text, txtKH.Text, txtDiachi.Text, txtSĐT.Text, dtpNgaykt.Value, matn))
                    {
                        MessageBox.Show("Thêm khách hàng thành công", "Thông báo");
                        LamMoi();
                        HienThi();
                        txtMaKH.Text = Matudong();
                    }
                }
                else
                {
                    MessageBox.Show("Thân nhân chưa tồn tại, Bạn cần thêm mới", "Thông báo");
                }
            }
        }

        private void btnXoa_Click_2(object sender, EventArgs e)
        {
            if (Check_data() == true)
            {
                if (MessageBox.Show("Cảnh báo bạn có chắc chắn muốn xóa khách hàng này", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "select MaKH as [MaKhachHang] from DangKyTiem where MaKH = '" + txtMaKH.Text + "'";
                    DataTable dt = DataProvider.Instance.ExecuteQuery(query);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Không thể xóa khách hàng này. Vì khách hàng đã mua hàng ở cửa hàng", "Thông báo");
                        LamMoi();
                        txtMaKH.Text = Matudong();
                    }
                    else


                      if (KhachHangBUS.Intance.xoaKH(txtMaKH.Text))
                    {

                        MessageBox.Show("Xóa khách hàng thành công", "Thông báo");
                        LamMoi();
                        HienThi();
                        txtMaKH.Text = Matudong();
                    }
                }
                else
                    LamMoi();
            }
        }

        private void dgvKH_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            txtKH.Text = dgvKH.Rows[indexx].Cells[1].Value.ToString();
            txtMaKH.Text = dgvKH.Rows[indexx].Cells[0].Value.ToString();
            dtpNgaykt.Value = Convert.ToDateTime(dgvKH.Rows[indexx].Cells[2].Value.ToString());
            txtDiachi.Text = dgvKH.Rows[indexx].Cells[3].Value.ToString();
            txtSĐT.Text = dgvKH.Rows[indexx].Cells[4].Value.ToString();
            txtTenTN.Text = dgvKH.Rows[indexx].Cells[5].Value.ToString();
            txtKH.ForeColor = Color.Black;
            txtDiachi.ForeColor = Color.Black;
            txtMaKH.ForeColor = Color.Black;
            txtTenTN.ForeColor = Color.Black;
            txtSĐT.ForeColor = Color.Black;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (Check_data() == true)
            {
                string query1 = "select MaTN as [MaThanNhan] from ThanNhan where TenTN = N'" + txtTenTN.Text + "'";
                DataTable dt1 = DataProvider.Instance.ExecuteQuery(query1);
                if (dt1.Rows.Count > 0)
                {   
                    matn = dt1.Rows[0]["MaThanNhan"].ToString();
                    if (KhachHangBUS.Intance.suaKH(txtMaKH.Text, txtKH.Text, txtDiachi.Text, txtSĐT.Text, dtpNgaykt.Value, matn))
                    {
                        MessageBox.Show("Sửa khách hàng thành công", "Thông báo");
                        LamMoi();
                        HienThi();
                        txtMaKH.Text = Matudong();
                    }
                }
                else
                {
                    MessageBox.Show("Tên nhân thân không hợp lệ", "Thông báo");
                }
            }
        }

        private void txtTimkiem_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                DataTable dt = KhachHangBUS.Intance.TimKiem(txtTimkiem.Text);
                dgvKH.DataSource = dt;
            }
            else
                HienThi();



            if (txtTimkiem.Text == "Tìm kiếm theo mã, tên, sđt khách hàng")
            {
                HienThi();
            }
        }
    }
}
