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
    public partial class UC_ChiTietGoiTiem : UserControl
    {
        public UC_ChiTietGoiTiem()
        {
            InitializeComponent();
            HienThi();
        }


        private void HienThi()
        {
            dgvGT.DataSource = GoiTiemBUS.Intance.HienThi1();
        }
    }
}
