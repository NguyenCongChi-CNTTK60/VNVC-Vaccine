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
    public partial class UC_ThongKeNhanVien : UserControl
    {
        public UC_ThongKeNhanVien()
        {
            InitializeComponent();
            Hienthi();
        }


        private void Hienthi()
        {
            DataTable dt = NhanVienBUS.Intance.TKNhanVien();
            dgvNv.DataSource = dt;
        }

    }
}
