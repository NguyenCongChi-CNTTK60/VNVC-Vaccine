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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            lblCanhBao.Text = "";

        }






        FormTrangChu f = new FormTrangChu();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string passWord = txtMatKhau.Text;
            if (Login(tenDangNhap, passWord))
            {
                FormTrangChu1 n = new FormTrangChu1(txtTenDangNhap.Text);
                n.Show();
                this.Hide();
            }
            else
                lblCanhBao.Text = "Sai tài khoản hoặc mật khẩu!";
                lblCanhBao.ForeColor = Color.Brown;
        }
        


       // FormSignUp n = new FormSignUp();
        private void lblDangky_Click(object sender, EventArgs e)
        {
            FormSignUp n = new FormSignUp();
            n.Show();
            this.Hide();
        }

        private void txtTenDangNhap_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "";
            txtTenDangNhap.ForeColor = Color.Black;
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = "VD: VanA";
                txtTenDangNhap.ForeColor = Color.Silver;
            }
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";
            txtMatKhau.ForeColor = Color.Black;
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "*****";
                txtMatKhau.ForeColor = Color.Silver;
            }
        }



        bool Login(string userName, string passWord)
        {
            return NhanVienBUS.Intance.Login(userName, passWord);
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            lblCanhBao.Text = "";
        }

       
        private void lblBanQuenMK_Click(object sender, EventArgs e)
        {
            FormSDT f = new FormSDT();
            f.Show();
            this.Hide();
        }

        private void chkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMK.Checked == true)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
                txtMatKhau.PasswordChar = '*';
        }
    }
}
