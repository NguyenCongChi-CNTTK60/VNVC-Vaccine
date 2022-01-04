using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace WindowsFormsApp
{
    public partial class FormThongTinHangMoi : Form
    {
        public FormThongTinHangMoi()
        {
            InitializeComponent();
            cmbLoaiHang.SelectedIndex = 0;
            //cmbĐVT.SelectedIndex = 0;
            txtMaMH.Text = Matudong();
        }
        List<LoaiHangDTO> list1;

        private void btnThemLoaiHang_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     





        private void Lammoi()
        {
            txtTenMH.Text = "Nhập tên Vaccine";
            txtTenMH.ForeColor = Color.Silver;
            cmbLoaiHang.SelectedIndex = 0;
            txtPhongBenh.Text = "Phòng bệnh";
            txtPhongBenh.ForeColor = Color.Silver;
            txtNuocSX.Text = "Xuất xứ";
            txtNuocSX.ForeColor = Color.Silver;
            //cmbĐVT.SelectedIndex = -1;

        }



        private string Matudong()
        {
            string query = "select MaVX from VacXin";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "VX001";
            }
            else
            {
                int k;
                ma = "VX";
                // k = dt.Rows.Count;
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

       

       



        private bool LuuHH(string mh, string tenh, int sl, int dg, string maLH,string phongbenh, string nuocsx)
        {
            // Convert datetime to date SQL Server 
            string query = String.Format(" insert into VacXin (MaVX,TenVX,SoLuong,GiaBan,MaLoai,PhongBenh,NuocSX)  values('{0}',N'{1}',N'{2}','{3}','{4}',N'{5}',N'{6}')", mh, tenh, sl, dg, maLH, phongbenh,nuocsx);
            DataProvider.Instance.ExecuteQuery(query);
            return true;
        }


        private string temp;
        private void cmbLoaiHang_SelectedIndexChanged_1(object sender, EventArgs e)
        {


            DataTable dt = MatHangBUS.Intance.TimKiemLH(cmbLoaiHang.Text);
            if (dt.Rows.Count > 0)
            {
                temp = dt.Rows[0]["MaLH"].ToString();
            }

        }

        private void txtTenMH_Click(object sender, EventArgs e)
        {
            txtTenMH.Text = "";
            txtTenMH.ForeColor = Color.Black;
        }



        List<LoaiHangDTO> list2;
        private void cmbLoaiHang_Click(object sender, EventArgs e)
        {
            list2 = LoaiHangBUS.Intance.getListLoaiHang();
            cmbLoaiHang.DataSource = list2;
            cmbLoaiHang.DisplayMember = "TenLoai";
            cmbLoaiHang.ValueMember = "MaLoai";
        }

        private void txtTenMH_Click_1(object sender, EventArgs e)
        {
            txtTenMH.Text = "";
            txtTenMH.ForeColor = Color.Black;
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click_2(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMH.Text))
            {
                MessageBox.Show("Tên mặt hàng không được trống");
            }
            else
            {
                if (LuuHH(txtMaMH.Text, txtTenMH.Text, 0, 1, lblMaLVX.Text, txtPhongBenh.Text, txtNuocSX.Text))
                {
                    MessageBox.Show("Lưu thông tin hàng thành công");
                    txtMaMH.Text = Matudong();
                    Lammoi();
                }
                else
                    MessageBox.Show("Không thể lưu thông tin này");
            }
        }

        private void txtPhongBenh_Click(object sender, EventArgs e)
        {
            txtPhongBenh.Text = "";
            txtPhongBenh.ForeColor = Color.Black;

        }

        private void txtNuocSX_Click(object sender, EventArgs e)
        {
            txtNuocSX.Text = "";
            txtNuocSX.ForeColor = Color.Black;
        }


        int i;
        private void cmbLoaiHang_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (cmbLoaiHang.SelectedIndex > 0)
            {
                i = cmbLoaiHang.SelectedIndex;
                lblMaLVX.Text = list2[i].Maloai;

                //txtGiaBan.Text = list[i].GiaBan.ToString();
            }
        }
    }
}




