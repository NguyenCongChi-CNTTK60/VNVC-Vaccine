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
    public partial class UC_ThongKe : UserControl
    {
        public UC_ThongKe()
        {
            InitializeComponent();
            
            getDataChart();
            cmbLuaChon.SelectedIndex = 0;
            
        }

        private void addUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlTK.Controls.Clear();
            pnlTK.Controls.Add(userControl);
            userControl.BringToFront();

        }


        


       
        

        string query = "USP_ThongKeDoanhThuTrongThang @ngaybd , @ngaykt";

        DateTime today = DateTime.Now;
        private void getDataChart()
        {
            chart1.Titles.Clear();
            dpkNgaybd.Value = new DateTime(today.Year -1, today.Month, 1);
            dpkNgaykt.Value = dpkNgaybd.Value.AddYears(1).AddMonths(12).AddDays(-1);
            ThucThi();
            //chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            // chart1.ChartAreas[0].AxisX.Minimum = 0;
            //chart1.Series[0].ChartType = SeriesChartType.Column;

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            ThucThi();
           
            
        }

        



        private void ThucThi()
        {
            chart1.Titles.Clear();
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { dpkNgaybd.Value, dpkNgaykt.Value });
            chart1.DataSource = data;
            chart1.Series["Doanh Thu"].XValueMember = "NGAY";
            chart1.Series["Doanh Thu"].YValueMembers = "TONGTIEN";
            chart1.Titles.Add("THỐNG KÊ DOANH THU");
            chart1.Series["Doanh Thu"].Color = System.Drawing.Color.FromArgb(0, 35, 149);
        }

        private void cmbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLuaChon.Text == "Hôm qua")
            {

                dpkNgaybd.Value = new DateTime(today.Year, today.Month, today.Day - 1);
                dpkNgaykt.Value = dpkNgaybd.Value;
                ThucThi();
                //TongtienHoadontheongay();

            }
            else if (cmbLuaChon.Text == "Hôm nay")
            {
                dpkNgaybd.Value = new DateTime(today.Year, today.Month, today.Day);
                dpkNgaykt.Value = dpkNgaybd.Value;
                ThucThi();
               // TongtienHoadontheongay();
            }
            else if (cmbLuaChon.Text == "Tuần này")
            {
                dpkNgaybd.Value = new DateTime(today.Year, today.Month, today.Day - 7);
                dpkNgaykt.Value = dpkNgaybd.Value.AddDays(7);
                ThucThi();
                //TongtienHoadontheongay();
            }
            else if (cmbLuaChon.Text == "Tháng này")
            {
                dpkNgaybd.Value = new DateTime(today.Year, today.Month, 1);
                dpkNgaykt.Value = dpkNgaybd.Value.AddDays(29);
                ThucThi();
                //TongtienHoadontheongay();
            }
            else if (cmbLuaChon.Text == "Năm nay")
            {
                dpkNgaybd.Value = new DateTime(today.Year, 1, 1);
                dpkNgaykt.Value = dpkNgaybd.Value.AddMonths(11).AddDays(29);
                ThucThi();
               // TongtienHoadontheongay();
            }
        }

        private void tdoKhachhang_CheckedChanged(object sender, EventArgs e)
        {
            UC_ThongKeKhachHang _ThongKeKhachHang = new UC_ThongKeKhachHang();
            addUC(_ThongKeKhachHang);
        }

        
        // btnTKVaccine
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UC_ThongKeHangHoa _ThongKeHangHoa = new UC_ThongKeHangHoa();
            addUC(_ThongKeHangHoa);
        }

        private void rdoTKHoaDon_CheckedChanged(object sender, EventArgs e)
        {
            UC_ThongKeHoaDon _ThongKeHoaDon = new UC_ThongKeHoaDon();
            addUC(_ThongKeHoaDon);
        }

        // btnTKPhieuNhap
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            UC_ThongKePhieuNhap _ThongKePhieuNhap = new UC_ThongKePhieuNhap();
            addUC(_ThongKePhieuNhap);
        }

        private void rdoNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            UC_ThongKeNhanVien _ThongKeNhanVien = new UC_ThongKeNhanVien();
            addUC(_ThongKeNhanVien);
        }
    }
}
