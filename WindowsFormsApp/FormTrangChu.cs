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
    public partial class FormTrangChu : Form
    {
        private string tk;
        private string luumanv, luutennv;
        public FormTrangChu()  // string tk
        {
            InitializeComponent();
            /*hiển thị trang chủ*/
            //UC_TrangChu tc = new UC_TrangChu();
            //themUC(tc);
            this.tk = tk;
            lblNguoidung.Text = tk;
            //Phanquyen();
            TTnguoiban();


           
           
        }


        
        private void TTnguoiban()
        {
            string name = lblNguoidung.Text;
            string query = "select MaNV,TenHienThi from Nhanvien where TenDangNhap = '" + tk + "'";
            
            if (!string.IsNullOrEmpty(lblNguoidung.Text))
            {
                DataTable dt = DataProvider.Instance.ExecuteQuery(query);
                lblManv.Text = dt.Rows[0]["MaNV"].ToString();
                lblTennv.Text = dt.Rows[0]["TenHienThi"].ToString();
                
            }
        }


        private void Phanquyen()
        {
            string Name = lblNguoidung.Text;
            string query = "select Quyen as [Quyen] from NhanVien where TenDangNhap = N'" + Name + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            lblQuyen.Text = dt.Rows[0]["Quyen"].ToString();

            if (lblQuyen.Text == "Quản lý")
            {

            }
            else if (lblQuyen.Text == "Nhân viên")
            {

                //btnKhuyenMai.Enabled = false;
                btnNhanVien.Enabled = false;
                btnThongKe.Enabled = false;
                btnNhanVien.Enabled = false;
                btnThongKe.Enabled = false;
                btnKhoHang.Enabled = false;
                //btnNCC.Enabled = false;
                //btnNhapHang.Enabled = false;

            }
        }



        private void addUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlTrangChu.Controls.Clear();
            pnlTrangChu.Controls.Add(userControl);
            //userControl.BringToFront();
        }



       


        private void lblNguoidung_Click(object sender, EventArgs e)
        {
            FormThongTinNhanVien formThongTinNhanVien = new FormThongTinNhanVien(lblNguoidung.Text);
            formThongTinNhanVien.Show();
        }

       
        


      
      
        private void btnX_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            //UC_TrangChu _TrangChu = new UC_TrangChu();
            //addUC(_TrangChu);
        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
