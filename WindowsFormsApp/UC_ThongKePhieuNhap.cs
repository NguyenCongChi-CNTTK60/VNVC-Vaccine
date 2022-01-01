using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace WindowsFormsApp
{
    public partial class UC_ThongKePhieuNhap : UserControl
    {
        public UC_ThongKePhieuNhap()
        {
            InitializeComponent();
            Hienthi();
        }


        private void Hienthi()
        {
            DataTable dt = PhieuNhapBUS.Intance.TKPhieuNhap();
            dgvPN.DataSource = dt;
        }

       

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            UC_ThongKe tk = new UC_ThongKe();
            tk.Show();
            this.Hide();
        }



        private string temp;
       

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {

        }


        private void addUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnXemchitiet_Click(object sender, EventArgs e)
        {
            UC_ReportPhieuNhap f = new UC_ReportPhieuNhap(temp);
            addUC(f);
        }

        private void txtTimkiem_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                DataTable dt = PhieuNhapBUS.Intance.TimKiemPN(txtTimkiem.Text);
                dgvPN.DataSource = dt;
            }
            else
                Hienthi();

        }

        private void dgvPN_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;

            temp = dgvPN.Rows[index].Cells[0].Value.ToString();
        }
    }
}
