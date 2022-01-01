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
    public partial class FormTrangChu1 : Form
    {

        private string tk;
        private string tempTK;
        public FormTrangChu1(string tk)
        {
            InitializeComponent();
           
            this.tk = tk;
            tempTK = tk;
            TTnguoiban();
            UC_TrangChu _TrangChu = new UC_TrangChu(lblTenNV.Text);
            addUC(_TrangChu);
            //Phanquyen();
           
            
        }




        private void TTnguoiban()
        {
            string name = tempTK;
            string query = "select MaNV,TenHienThi from Nhanvien where TenDangNhap = '" + tk + "'";

           
                DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                lblMaNV.Text = dt.Rows[0]["MaNV"].ToString();
                lblTenNV.Text = dt.Rows[0]["TenHienThi"].ToString();
            }

            
        }



        private void Phanquyen(UserControl us1, UserControl us2)
        {
            string Name = tempTK;
            string query = "select Quyen as [Quyen] from NhanVien where TenDangNhap = N'" + Name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                lblQuyen.Text = dt.Rows[0]["Quyen"].ToString();

                if (lblQuyen.Text == "Quản lý")
                {
                    addUC(us1);
                }
                else if (lblQuyen.Text == "Nhân viên")
                {

                    addUC(us2);

                }
            }
        }









        private void addUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 35, 149);
            UC_ThongKe _ThongKe = new UC_ThongKe();
            Phanquyen(_ThongKe, _HienThiQuyen);
            ButtonHide();
            btnThongKe.ForeColor = Color.White;
            btnThongKe.BackColor = myRgbColor;


        }


      


        private void ButtonHide()
        {

            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 35, 149);
            // 1. btnTrangchu

            btnTrangchu.ForeColor = Color.Black;
            btnTrangchu.BackColor = Color.White;



            // 2. btnKhachhang

            btnKhachHang.ForeColor = Color.Black;
            btnKhachHang.BackColor = Color.White;

            // 3. btnBanhang

            btnDangKyTiem.ForeColor = Color.Black;
            btnDangKyTiem.BackColor = Color.White;

            // 4. btnNhanvien

            btnNhanVien.ForeColor = Color.Black;
            btnNhanVien.BackColor = Color.White;

            // 5. btnKhohang

            btnKhoHang.ForeColor = Color.Black;
            btnKhoHang.BackColor = Color.White;


            // 6. btnNhacungcap

            btnNhaCungCap.ForeColor = Color.Black;
            btnNhaCungCap.BackColor = Color.White;

            // 7. btnThongke

            btnThongKe.ForeColor = Color.Black;
            btnThongKe.BackColor = Color.White;



            // 7. btnThongke

            btnGoiTiem.ForeColor = Color.Black;
            btnGoiTiem.BackColor = Color.White;
            // 8. btnThongke

            btnDangXuat.ForeColor = Color.Black;
           


            // 9. btnKhuyenMai

            


        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 35, 149);
            UC_TrangChu _TrangChu = new UC_TrangChu(lblTenNV.Text);
            addUC(_TrangChu);
          
            ButtonHide();
            btnTrangchu.ForeColor = Color.White;
            btnTrangchu.BackColor = myRgbColor;
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 35, 149);
            UC_DangKyTiem _DangKyTiem = new UC_DangKyTiem(lblMaNV.Text,lblTenNhanVien.Text);
            addUC(_DangKyTiem);

            ButtonHide();
            btnDangKyTiem.ForeColor = Color.White;
            btnDangKyTiem.BackColor = myRgbColor;


        }

       




        UC_HienThiQuyen _HienThiQuyen = new UC_HienThiQuyen();
        private void btnNhanVien_Click(object sender, EventArgs e)
        {   
            
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 35, 149);
            UC_NhanVien  _NhanVien = new UC_NhanVien();
            ButtonHide();
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.BackColor = myRgbColor;
            Phanquyen(_NhanVien, _HienThiQuyen);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 35, 149);
            UC_NhaCungCap _NhaCungCap = new UC_NhaCungCap();
            //addUC(_NhaCungCap);
            Phanquyen(_NhaCungCap, _HienThiQuyen);

            ButtonHide();
            btnNhaCungCap.ForeColor = Color.White;
            btnNhaCungCap.BackColor = myRgbColor;
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 35, 149);
            UC_KhoVaccine _KhoVaccine = new UC_KhoVaccine(lblMaNV.Text,lblTenNhanVien.Text);
            //addUC(_KhoVaccine);
            Phanquyen(_KhoVaccine, _HienThiQuyen);
            ButtonHide();
            btnKhoHang.ForeColor = Color.White;
            btnKhoHang.BackColor = myRgbColor;
        }



      

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Hide();
        }

        private void lblTenNV_Click(object sender, EventArgs e)
        {
            //UC_ReportHangTon f = new UC_ReportHangTon();
            //addUC(f);
        }


      

        private void showsubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
               
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

       

     

       

        private void btnNhanThan_Click(object sender, EventArgs e)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 35, 149);
            UC_QuanLyThanhNhan _QuanLyThanhNhan = new UC_QuanLyThanhNhan();
            addUC(_QuanLyThanhNhan);
            
            ButtonHide();
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.BackColor = myRgbColor;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 35, 149);
            UC_KhachHang _KhachHang = new UC_KhachHang();
            addUC(_KhachHang);

            ButtonHide();
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.BackColor = myRgbColor;
        }

        private void btnGoiTiem_Click(object sender, EventArgs e)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(0, 35, 149);
            ButtonHide();
            UC_XacNhanMa _XacNhanMa = new UC_XacNhanMa();
            // addUC(_XacNhanMa);
            Phanquyen(_XacNhanMa, _HienThiQuyen);
            btnGoiTiem.ForeColor = Color.White;
            btnGoiTiem.BackColor = myRgbColor;
        }

        private void iconDangXuat_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Hide();
        }
    }
}
