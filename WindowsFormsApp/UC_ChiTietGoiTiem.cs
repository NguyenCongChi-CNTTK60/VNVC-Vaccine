using BUS;
using DTO;
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
    public partial class UC_ChiTietGoiTiem : UserControl
    {
        public UC_ChiTietGoiTiem()
        {
            InitializeComponent();
            HienThi();
            cmbTenGoiTiem.SelectedIndex = 0;
            cmbTenVaccine.SelectedIndex = 0;
            cmbLoaiVX.SelectedIndex = 0;
            list = MatHangBUS.Intance.getListSanPham();
            cmbTenVaccine.DataSource = list;
            cmbTenVaccine.DisplayMember = "TenVX";
            cmbTenVaccine.ValueMember = "MaVX";
        }


        private void HienThi()
        {
            dgvGT.DataSource = GoiTiemBUS.Intance.HienThi1();
        }

        List<MatHangDTO> list;
        List<GoiTiemDTO> list1;
        List<LoaiHangDTO> list2;

    







        int i;
        private void cmbTenVaccine_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = GoiTiemBUS.Intance.TimKiemMaVX(cmbTenVaccine.Text);
            if (dt.Rows.Count > 0)
            {
                //i = cmbTenVaccine.SelectedIndex;
                txtMaVX.Text = dt.Rows[0]["MaVX"].ToString();
                txtMaVX.ForeColor = Color.Black;
            }
        }

        private void cmbTenGoiTiem_Click(object sender, EventArgs e)
        {
            list1 = GoiTiemBUS.Intance.getListGoitiem();
            cmbTenGoiTiem.DataSource = list1;
            cmbTenGoiTiem.DisplayMember = "TenGT";
            cmbTenGoiTiem.ValueMember = "MaGT";
        }

        private void cmbTenGoiTiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = GoiTiemBUS.Intance.TimKiemTG(txtMaGT.Text);
            if (cmbTenGoiTiem.SelectedIndex > 0)
            {
                i = cmbTenGoiTiem.SelectedIndex;
                txtMaGT.Text = list1[i].MaGT;
                txtMaGT.ForeColor = Color.Black;

               

            }
        }

        private void txtMaGT_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = GoiTiemBUS.Intance.TimKiemTG(txtMaGT.Text);
            if (dt.Rows.Count > 0)
            {
                dtpNgaytg.Value = Convert.ToDateTime(dt.Rows[0]["ThoiGian"].ToString());
            }
        }

        private void guna2TextBox3_Click(object sender, EventArgs e)
        {
            txtSL.Text = "";
            txtSL.ForeColor = Color.Black;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable dt1 = GoiTiemBUS.Intance.TimKiemMaVXMaGT(txtMaGT.Text,txtMaVX.Text);
            if(dt1.Rows.Count > 0)
            {
                MessageBox.Show("Vaccine đã tồn tại trong gói, bạn không thể thêm mới");
                
            }else
            if (Int32.Parse(txtSL.Text) > 0)
            {
                if (GoiTiemBUS.Intance.themChiTietGoiTiem(txtMaGT.Text, txtMaVX.Text, dtpNgaytg.Value, Int32.Parse(txtSL.Text)))
                {
                    MessageBox.Show("Thêm chi tiết gói tiêm thành công", "Thông báo");
                    HienThi();
                    LamMoi();
                }
            }
            else
                MessageBox.Show("Số liều tiêm phải lớn hơn 0");
        }

        private void dgvGT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            txtMaGT.Text = dgvGT.Rows[indexx].Cells[0].Value.ToString();
            txtMaVX.Text = dgvGT.Rows[indexx].Cells[1].Value.ToString();
            cmbTenGoiTiem.Text = dgvGT.Rows[indexx].Cells[2].Value.ToString();
            cmbTenVaccine.Text = dgvGT.Rows[indexx].Cells[3].Value.ToString();
            dtpNgaytg.Value = Convert.ToDateTime(dgvGT.Rows[indexx].Cells[4].Value.ToString());
            txtSL.Text = dgvGT.Rows[indexx].Cells[5].Value.ToString();
            txtSL.ForeColor = Color.Black;
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = "";
            txtTimkiem.ForeColor = Color.Black;

        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                dgvGT.DataSource = GoiTiemBUS.Intance.TimKiemTT(txtTimkiem.Text);
                
            }
            else
                HienThi();


            if(txtTimkiem.Text == "Tìm kiếm theo mã,tên")
            {
                HienThi();
            }
        }

    

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (GoiTiemBUS.Intance.xoaChiTietGoiTiem(txtMaGT.Text, txtMaVX.Text))
            {
                MessageBox.Show("Xóa chi tiết thành công", "Thông báo");
                HienThi();
                LamMoi();
            }
        }

        private void LamMoi()
        {
            txtMaVX.Text = "Mã Vaccine";
            txtMaGT.Text = "Mã gói tiêm";
            txtSL.Text = "Nhập số lượng";
            txtMaGT.ForeColor = Color.Silver;
            txtMaVX.ForeColor = Color.Silver;
            txtSL.ForeColor = Color.Silver;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (GoiTiemBUS.Intance.suaChiTietGoiTiem(txtMaGT.Text, txtMaVX.Text, dtpNgaytg.Value, Int32.Parse(txtSL.Text)))
            {
                MessageBox.Show("Sửa chi tiết thành công", "Thông báo");
                HienThi();
                LamMoi();
            }
        }

        private void cmbLoaiVX_Click(object sender, EventArgs e)
        {
            list2 = LoaiHangBUS.Intance.getListLoaiHang();
            cmbLoaiVX.DataSource = list2;
            cmbLoaiVX.DisplayMember = "TenLoai";
            cmbLoaiVX.ValueMember = "MaLoai";
        }

        private void cmbLoaiVX_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select MaLoai from LoaiVacXin where TenLoai = N'" + cmbLoaiVX.Text + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

           
            if(dt.Rows.Count > 0)
            {
                lblMaLoai.Text = dt.Rows[0]["MaLoai"].ToString();
                DataTable dt1 = LoaiHangBUS.Intance.TimKiemTenVaccine(lblMaLoai.Text);
                if(dt1.Rows.Count > 0) {
                    cmbTenVaccine.DataSource = dt1;

                    } 
            } 
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

