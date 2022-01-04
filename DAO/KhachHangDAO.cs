﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp;

namespace DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public KhachHangDAO()
        {
        }

        public static KhachHangDAO Intance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            set => instance = value;
        }

        public DataTable getListKH()
        {
            string query = "select KhachHang.MaKH,TenKH, DiaChi, SDT, Email  from KhachHang";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool themKH(string maKH, string tenKH, string DiaChi, string SDT, DateTime ngaysinh, string matn)
        {
            string query = String.Format("insert into KhachHang(MaKH, TenKH, DiaChi, SDT, NgaySinh, MaTN) values ('{0}', N'{1}', N'{2}', N'{3}', '{4}', '{5}')", maKH, tenKH, DiaChi, SDT, ngaysinh, matn);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool suaKH(string maKH, string tenKH, string DiaChi, string SDT, DateTime ngaysinh, string matn)
        {
            string query = String.Format("update KhachHang set TenKH = N'" + tenKH + "', DiaChi = N'" + DiaChi + "', SDT = '" + SDT + "', NgaySinh = '"+ ngaysinh +"',MaTN = '"+ matn + "' where MaKH = '" + maKH + "'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool xoaKH(string maKH)
        {
            string query = String.Format("delete from KhachHang where MaKH = '{0}'", maKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable TimKiemKH(string name)
        {
            string query = string.Format("SELECT MaKH,TenKH, DiaChi, SDT, Email FROM KhachHang WHERE dbo.GetUnsignString(KhachHang.TenKH) LIKE N'%' + dbo.GetUnsignString(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public string loadMaKH()
        {
            string maKHnext = "";
            string query = "select top 1 MaKH from KhachHang order by MaKH desc";
            DataRow data = DataProvider.Instance.ExecuteQuery(query).Rows[0];
            maKHnext = data["MaKH"].ToString();
            return maKHnext;
        }


        // CHÍ
        public DataTable TKKhachHang()
        {
            string query = "USP_TKKhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable TimKiemKhachHang(string tk)
        {
            string query = "select KhachHang.MaKH as [Mã khách hàng],TenKH as [Tên khách hàng],SDT as [Số điện thoại], SUM(DangKyTiem.TongTien) AS[Tổng Tiền], Count(DangKyTiem.MaKH) as [Số lần mua hàng] from KhachHang inner join DangKyTiem on KhachHang.MaKH = DangKyTiem.MaKH where TenKH like N'%" + tk + "%' or KhachHang.MaKH like N'" + tk + "' group by DangKyTiem.MaKH, KhachHang.MaKH,TenKH,SDT";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable HienThi()
        {
            string query = "select KhachHang.MaKH as [Mã khách hàng],TenKH as [Tên khách hàng],NgaySinh as [Ngày sinh], DiaChi as [Địa chỉ], KhachHang.SDT as [Số điện thoại], TenTN as [Thân nhân],MoiQuanHe as [Mối quan hệ] from KhachHang inner join ThanNhan on KhachHang.MaTN = ThanNhan.MaTN";
            return DataProvider.Instance.ExecuteQuery(query);
        }


        public DataTable TimKiemDiemTichLuy(string tk)
        {
            string query = "select DiemTichLuy from KhachHang where MaKH = '" + tk + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable TimKiem(string tk)
        {
            string query = "select KhachHang.MaKH as [Mã khách hàng],TenKH as [Tên khách hàng],NgaySinh as [Ngày sinh], DiaChi as [Địa chỉ], KhachHang.SDT as [Số điện thoại], TenTN as [Thân nhân],MoiQuanHe as [Mối quan hệ] from KhachHang inner join ThanNhan on KhachHang.MaTN = ThanNhan.MaTN  where TenKH like N'%" + tk + "%' or KhachHang.MaKH like N'%" + tk + "%'  or KhachHang.SDT like N'%" + tk + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable TimKiemDiemTL(string tk)
        {
            string query = "select * from KhachHang where SDT = '"+tk+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable HienThiThanNhan()
        {
            string query = "select MaTN as [Mã thân nhân], TenTN as [Tên thân nhân], MoiQuanHe as [Mối quan hệ], SDT as [Số điện thoại] from ThanNhan";
            return DataProvider.Instance.ExecuteQuery(query);
        }


        public bool themTN(string maTN, string tenTN, string moiQH, string SDT)
        {
            string query = String.Format("insert into ThanNhan (MaTN, TenTN, MoiQuanHe, SDT) values ('{0}', N'{1}', N'{2}', N'{3}')", maTN, tenTN, moiQH, SDT);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool suaTN(string maTN, string tenTN, string moiQH, string SDT)
        {
            string query = String.Format("update ThanNhan set TenTN = N'" + tenTN + "', MoiQuanHe = N'" + moiQH + "', SDT = '" + SDT + "' where MaKH = '" + maTN + "'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool xoaTN(string maKH)
        {
            string query = String.Format("delete from ThanNhan where MaTN = '{0}'", maKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public DataTable TKhanNhan(string tk)
        {
            string query = "select MaTN as [Mã thân nhân], TenTN as [Tên thân nhân], MoiQuanHe as [Mối quan hệ], SDT as [Số điện thoại] from ThanNhan where MaTN like '%"+tk+ "%' or TenTN like N'%" + tk + "%' or SDT like '%" + tk + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }


    }
}
