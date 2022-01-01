using BUS;
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


namespace WindowsFormsApp
{
    public partial class UC_ThongKeHoaDon : UserControl
    {
        public UC_ThongKeHoaDon()
        {
            InitializeComponent();
            DateTime today = DateTime.Now;
            dpkNgaybd.Value = new DateTime(today.Year - 1, today.Month, 1);
            dpkNgaykt.Value = dpkNgaybd.Value.AddYears(1).AddMonths(12).AddDays(-1);
            ThucThi();
            TongtienHoadon();
            cmbLuaChon.SelectedIndex = 0;
        }




        DateTime today = DateTime.Now;
        private void TongtienHoadon()
        {
            int Tongtien = 0;  
            DataTable dt = HoaDonBUS.Intance.TongTienHoaDon();
            string tien = dt.Rows[0]["Tổng tiền hóa đơn"].ToString();
            Tongtien = Int32.Parse(tien);
            lblTongTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", Tongtien) + " đ";
            //lblTienBangChu.Text = ChuyenDoiTienBUS.Instance.So_chu(Tongtien);
        }


        private void TongtienHoadontheongay()
        {
            int Tongtien = 0;
            DateTime ngaybd = dpkNgaybd.Value;
            DateTime ngaykt = dpkNgaykt.Value;
            DataTable dt = HoaDonBUS.Intance.TongTienTheoNgay(ngaybd, ngaykt);
            //string tien = dt.Rows[0]["Tổng tiền hóa đơn"].ToString();
            if (dt.Rows.Count > 0)
            {
                string tien = dt.Rows[0]["Tổng tiền hóa đơn"].ToString();
                if (!string.IsNullOrEmpty(tien)){
                    Tongtien = Int32.Parse(tien);
                    lblTongTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", Tongtien) + " đ";
                    //lblTienBangChu.Text = ChuyenDoiTienBUS.Instance.So_chu(Tongtien);
                } else
                    lblTongTien.Text = "0 đ";
            }
            else
                lblTongTien.Text = "0";
                   
        }


        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            UC_ThongKe tk = new UC_ThongKe();
            tk.Show();
            this.Hide();
        }

        private void btnTangngay_Click(object sender, EventArgs e)
        {

        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            ThucThi();
            TongtienHoadontheongay();
        }

        private void cmbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbLuaChon.Text == "Hôm qua")
            {
                
                dpkNgaybd.Value = new DateTime(today.Year, today.Month, today.Day -1);
                dpkNgaykt.Value = dpkNgaybd.Value;
                ThucThi();
                TongtienHoadontheongay();
             
            }else if (cmbLuaChon.Text == "Hôm nay")
            {
                dpkNgaybd.Value = new DateTime(today.Year, today.Month, today.Day);
                dpkNgaykt.Value = dpkNgaybd.Value;
                ThucThi();
                TongtienHoadontheongay();
            }else if (cmbLuaChon.Text == "Tuần này")
            {
                dpkNgaybd.Value = new DateTime(today.Year, today.Month, today.Day - 7);
                dpkNgaykt.Value = dpkNgaybd.Value.AddDays(7);
                ThucThi();
                TongtienHoadontheongay();
            }else if (cmbLuaChon.Text == "Tháng này")
            {
                dpkNgaybd.Value = new DateTime(today.Year, today.Month, 1);
                dpkNgaykt.Value = dpkNgaybd.Value.AddDays(29);
                ThucThi();
                TongtienHoadontheongay();
            }else if (cmbLuaChon.Text == "Năm nay")
            {
                dpkNgaybd.Value = new DateTime(today.Year,1, 1);
                dpkNgaykt.Value = dpkNgaybd.Value.AddMonths(11).AddDays(29);
                ThucThi();
                TongtienHoadontheongay();
            }
        }


        private void ThucThi()
        {
            DateTime ngaybd = dpkNgaybd.Value;
            DateTime ngaykt = dpkNgaykt.Value;
            DataTable dt = HoaDonBUS.Intance.TKHoaDon(ngaybd, ngaykt);
            dgvHd.DataSource = dt;
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            FormChiTietHD f = new FormChiTietHD(mahd);
            f.Show();
        }


        private string mahd;
        private void dgvHd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexx;
            indexx = e.RowIndex;
            mahd = dgvHd.Rows[indexx].Cells[0].Value.ToString();
        }
    }

}
