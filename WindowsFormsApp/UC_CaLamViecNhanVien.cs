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
    public partial class UC_CaLamViecNhanVien : UserControl
    {
        public UC_CaLamViecNhanVien()
        {
            InitializeComponent();
            Hienthi();
            //list = NhanVienBUS.Intance.getListNhanVien();
            //cmbTennv.DataSource = list;
            //cmbTennv.DisplayMember = "TenHienThi";
            //cmbTennv.ValueMember = "TenHienThi";
            //list1 = CaLamViecBUS.Intance.getListCalamviec();
            //cmbCalamviec.DataSource = list1;
            //cmbCalamviec.DisplayMember = "Ca";
            //cmbCalamviec.ValueMember = "Ca";
            //LamMoi();

            cmbTennv.SelectedIndex = 0;
            cmbCalamviec.SelectedIndex = 0;
            //cmbLuaChon.SelectedIndex = 0;
        }


        private void Hienthi()
        {
            DataTable dt = CaLamViecBUS.Intance.getListNV();
            dgvGC.DataSource = dt;
        }

        private void cmbTenNV_Click(object sender, EventArgs e)
        {
            list = NhanVienBUS.Intance.getListNhanVien();
            cmbTennv.DataSource = list;
            cmbTennv.DisplayMember = "TenHienThi";
            cmbTennv.ValueMember = "TenHienThi";
        }


        List<NhanVienDTO> list;

        private void cmbCLV_Click(object sender, EventArgs e)
        {
            list1 = CaLamViecBUS.Intance.getListCalamviec();
            cmbCalamviec.DataSource = list1;
            cmbCalamviec.DisplayMember = "Ca";
            cmbCalamviec.ValueMember = "Ca";
        }


        List<CaLamViecDTO> list1;


        private string temp;
        private string temp1;
        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable dt = NhanVienBUS.Intance.getTTNV(cmbTennv.Text);
            DataTable dt1 = CaLamViecBUS.Intance.TimkiemMCLV(cmbCalamviec.Text);
            if (dt.Rows.Count > 0 && dt1.Rows.Count > 0)
            {
                temp = dt.Rows[0]["MaNV"].ToString();
                temp1 = dt1.Rows[0]["MaCLV"].ToString();
                DataTable dt2 = CaLamViecBUS.Intance.TimkiemCLV(temp);
                if (dt2.Rows.Count > 0)
                {
                    DateTime Ngaykt = Convert.ToDateTime(dt2.Rows[0]["NgayKT"].ToString());
                    string temp2 = dt2.Rows[0]["MaCLV"].ToString();
                    if (dtpNgaybd.Value <= Ngaykt && temp2 == temp1)
                    {
                        MessageBox.Show("Ca làm việc nhân viên đã tồn tại, Bạn không thể thêm mới!", "Thông báo");
                    }
                    else if (CaLamViecBUS.Intance.themCLV(temp1, temp, dtpNgaybd.Value, dtpNgaykt.Value))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        Hienthi();
                        //LamMoi();
                    }

                }
                else
                {
                    if (CaLamViecBUS.Intance.themCLV(temp1, temp, dtpNgaybd.Value, dtpNgaykt.Value))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        Hienthi();
                        //LamMoi();
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            
               
                if (CaLamViecBUS.Intance.xoaCLV(lblMNV.Text, dtpNgaybd.Value,dtpNgaykt.Value))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    Hienthi();
                   
                }else
                   MessageBox.Show("Không thể xóa", "Thông báo");
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
                DataTable dt = CaLamViecBUS.Intance.Timkiem(txtTimkiem.Text);
                dgvGC.DataSource = dt;
            }
            else
                Hienthi();


            if(txtTimkiem.Text == "Tìm kiếm theo mã, tên nhân viên")
            {
                Hienthi();
            }
        }

        private void txtTimkiem_Leave(object sender, EventArgs e)
        {
            txtTimkiem.Text = "Tìm kiếm theo mã, tên nhân viên";
            txtTimkiem.ForeColor = Color.Silver;
        }

        private void dgvGC_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            lblMNV.Text = dgvGC.Rows[indexx].Cells[0].Value.ToString();
            cmbCalamviec.Text = dgvGC.Rows[indexx].Cells[2].Value.ToString();
            cmbTennv.Text = dgvGC.Rows[indexx].Cells[1].Value.ToString();
            dtpNgaybd.Value = Convert.ToDateTime(dgvGC.Rows[indexx].Cells[3].Value.ToString());
            dtpNgaykt.Value = Convert.ToDateTime(dgvGC.Rows[indexx].Cells[4].Value.ToString());
        }
    }
}
