using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class MatHangBUS
    {
        private static MatHangBUS instance;

        public MatHangBUS()
        {
        }

        public static MatHangBUS Intance
        {
            get { if (instance == null) instance = new MatHangBUS(); return instance; }
            set => instance = value;
        }

       
        public void capNhatHinh(string imgLocation, string maHang)
        {
            MatHangDAO.Intance.capNhatHinh(imgLocation, maHang);
        }

        public byte[] getAnhByID(string ID)
        {
            return MatHangDAO.Intance.getAnhByID(ID);
        }

        public List<MatHangDTO> getListSanPham()
        {
            return MatHangDAO.Intance.getListSanPham();
        }


        /*
        public MatHangDTO getSP(string maSP)
        {
            return MatHangDAO.Intance.get(maSP);
        } */

        public bool suaHH(string MaHang, string TenHH, string loai, int GiaBan, string phongbenh, string nuocsx)
        {
            return MatHangDAO.Intance.suaHH(MaHang, TenHH, loai, GiaBan, phongbenh,nuocsx);
        }

        public bool kiemtraXoa(string maHang)
        {
            return MatHangDAO.Intance.kiemtraXoa(maHang);
        }

        public bool capNhatHH(string maHang, int SL, int DonGia)
        {
            return MatHangDAO.Intance.capNhatHH(maHang, SL, DonGia);
        }

        public bool xoaHang(string maKH)
        {
            return MatHangDAO.Intance.xoaHang(maKH);
        }

        public string loadMaHH()
        {
            return MatHangDAO.Intance.loadMaHH();
        }

        public DataTable TimKiemHH(string maPN)
        {
            return MatHangDAO.Intance.TimKiemHH(maPN);
        }


        // CHÍ
        public DataTable TKMatHang()
        {
            return MatHangDAO.Intance.TKMatHang();
        }


        public DataTable TimKiemMH(string tk)
        {
            return MatHangDAO.Intance.TimKiemMH(tk);
        }


        public DataTable TimKiemGiaBan(string maMH)
        {
            return MatHangDAO.Intance.TimKiemGiaBan(maMH);
        }


        public DataTable HienThi()
        {
            return MatHangDAO.Intance.HienThi();
        }


        public DataTable TimKiemLH(string tk)
        {
            return MatHangDAO.Intance.TimKiemLH(tk);
        }

        public DataTable TimKiemMHTrongKH(string tk)
        {
            return MatHangDAO.Intance.TimKiemMHTrongKH(tk);
        }

        public DataTable TimKiemSL(string tk)
        {
            return MatHangDAO.Intance.TimKiemSL(tk);
        }
    }
}