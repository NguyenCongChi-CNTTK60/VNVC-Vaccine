using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DTO;
using WindowsFormsApp;

namespace DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public HoaDonDAO()
        {
        }

        public static HoaDonDAO Intance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
            set => instance = value;
        }

        public string LoadMaDHMoi()
        {
            string madh = "";

            madh = "DH" + DateTime.Now.Day.ToString("00") + DateTime.Now.Month.ToString("00") + DateTime.Now.Year.ToString("0000");

            string query = String.Format("SELECT dbo.fn_Get_MaDonHang_Next( @MaHD )");

            object madh_next = DataProvider.Instance.ExecuteScalar(query, new object[] { madh });

            if (madh_next.ToString() == "")
            {
                madh_next = madh + "001";
            }
            return madh_next.ToString();
        }



        public bool LuuDonHang(HoaDonDTO dh)
        {
            // Convert datetime to date SQL Server 
            string query = String.Format("insert into HoaDon values('{0}','{1}','{2}','{3}','{4}')", dh.MaHD, dh.MaKH, dh.NgayTao, dh.MaNV, dh.TongTien);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }



        public DataTable LoadDanhSachDonHangTheoKH(string MaKH)
        {
            string query = "select * from HoaDon where MaKH ='" + MaKH + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }



        // CHÍ

        public DataTable TKHoaDon(DateTime ngaybd, DateTime ngaykt)
        {
            string query = "select DangKyTiem.MaHD as [Mã hóa đơn],KhachHang.TenKH as [Tên khách hàng],NgayTao as [Ngày tạo],TongTien[Tổng tiền],TenHienThi as [Nhân viên tạo] from DangKyTiem inner join KhachHang on DangKyTiem.MaKH = KhachHang.MaKH inner join NhanVien on NhanVien.MaNV = DangKyTiem.MaNV where  NgayTao between '" + ngaybd + "' and '" + ngaykt + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable TongTienHoaDon()
        {
            string query = "select sum(Tongtien) as [Tổng tiền hóa đơn] from DangKyTiem";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable TongTienTheoNgay(DateTime ngaybd, DateTime ngaykt)
        {
            string query =  "select sum(Tongtien) as [Tổng tiền hóa đơn]from DangKyTiem where NgayTao between '" + ngaybd + "' and '" + ngaykt + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }






    }
}
