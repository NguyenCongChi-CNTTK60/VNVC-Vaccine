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
using BUS;

namespace WindowsFormsApp
{
    public partial class FormSDT : Form
    {
        public FormSDT()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void pnlma_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {

        }

        private void btnQuaylai_Click_1(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Hide();
        }


        private void addUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnlSDT.Controls.Clear();
            pnlSDT.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {

            //DataTable dt = NhanVienBUS.Intance.CapLaiMK(txtTenDangNhap.Text);
            string query = "select SDT as [TenDangNhap] from Nhanvien where SDT = '" + txtSDT.Text + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (!string.IsNullOrEmpty(txtSDT.Text))
            {
                if (dt.Rows.Count > 0)
                {
                    UC_XacNhanMaSDT uC_XacNhanMa = new UC_XacNhanMaSDT(txtSDT.Text);
                    addUC(uC_XacNhanMa);
                }
                else
                {
                    MessageBox.Show("Số điện thoại chưa đúng", "Thông báo");
                }

            }
        }
        /*
private void addUC(UserControl userControl)
{
   userControl.Dock = DockStyle.Fill;
   pnlma.Controls.Clear();
   pnlma.Controls.Add(userControl);
   userControl.BringToFront();
}


Chuoiketnoi chuoiketnoi = new Chuoiketnoi();
private void btnLuu_Click(object sender, EventArgs e)
{
   SqlConnection con = chuoiketnoi.sqlConnection();
   con.Open();
   string tk = txtSđtnv.Text;

   string query = "select Sdt,Tendangnhap from Nhanvien where Sdt = '" + tk + "'";
   SqlCommand sqlCommand = new SqlCommand(query, con);
   SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
   if (sqlDataReader.Read() == true)
   {
       UC_XacNhanSDT uC_Xacnhansdt = new UC_XacNhanSDT(txtSđtnv.Text);
       addUC(uC_Xacnhansdt);
   }
   else
       lblCanhbao.Text = "Số điện thoại không đúng";
   lblCanhbao.ForeColor = Color.Brown;
   con.Close();
}

private void btnQuaylai_Click(object sender, EventArgs e)
{
   FormDangNhap formDangNhap = new FormDangNhap();
   formDangNhap.Show();
   this.Hide();
} */
    }
}

