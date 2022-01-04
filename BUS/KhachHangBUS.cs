using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class KhachHangBUS
    {
        private static KhachHangBUS instance;

        public KhachHangBUS()
        {
        }

        public static KhachHangBUS Intance
        {
            get { if (instance == null) instance = new KhachHangBUS(); return instance; }
            set => instance = value;
        }

        public DataTable getListKH()
        {
            return KhachHangDAO.Intance.getListKH();
        }

        public bool themKH(string maKH, string tenKH, string DiaChi, string SDT, DateTime ngaysinh, string matn)
        {
            return KhachHangDAO.Intance.themKH(maKH, tenKH, DiaChi, SDT, ngaysinh, matn);
        }

        public bool suaKH(string maKH, string tenKH, string DiaChi, string SDT, DateTime ngaysinh, string matn)
        {
            return KhachHangDAO.Intance.suaKH(maKH, tenKH, DiaChi, SDT, ngaysinh, matn);
        }

        public bool xoaKH(string maKH)
        {
            return KhachHangDAO.Intance.xoaKH(maKH);
        }

        public DataTable TimKiemKH(string name)
        {
            return KhachHangDAO.Intance.TimKiemKH(name);
        }

        public string loadMaKH()
        {
            return KhachHangDAO.Intance.loadMaKH();
        }


        // CHÍ 
        public DataTable TKKhachHang()
        {
            return KhachHangDAO.Intance.TKKhachHang();
        }


        public DataTable TimKiemKhachHang(string tk)
        {
            return KhachHangDAO.Intance.TimKiemKhachHang(tk);
        }


        public DataTable HienThi()
        {
            return KhachHangDAO.Intance.HienThi();
        }


        public DataTable TimKiemDiemTichLuy(string tk)
        {
            return KhachHangDAO.Intance.TimKiemDiemTichLuy(tk);
        }


        public DataTable TimKiem(string tk)
        {
            return KhachHangDAO.Intance.TimKiem(tk);
        }


        public DataTable TimKiemDiemTL(string tk)
        {
            return KhachHangDAO.Intance.TimKiemDiemTL(tk);
        }


        public DataTable HienThiThanNhan()
        {
            return KhachHangDAO.Intance.HienThiThanNhan();
        }


        public bool themTN(string maTN, string tenTN, string moiQH, string SDT)
        {
            return KhachHangDAO.Intance.themTN(maTN, tenTN, moiQH, SDT);
        }

        public bool suaTN(string maTN, string tenTN, string moiQH, string SDT)
        {
            return KhachHangDAO.Intance.suaTN(maTN, tenTN, moiQH, SDT);
        }


        public bool xoaTN(string maKH)
        {
            return KhachHangDAO.Intance.xoaTN(maKH);
        }

        public DataTable TKhanNhan(string tk)
        {
            return KhachHangDAO.Intance.TKhanNhan(tk);
        }
    }
}
