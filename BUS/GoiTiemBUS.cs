using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GoiTiemBUS
    {
        private static GoiTiemBUS instance;

        public GoiTiemBUS()
        {
        }

        public static GoiTiemBUS Intance
        {
            get { if (instance == null) instance = new GoiTiemBUS(); return instance; }
            set => instance = value;
        }

        public DataTable HienThi()
        {
            return GoiTiemDAO.Intance.HienThi();
        }

        public DataTable HienThi1()
        {
            return GoiTiemDAO.Intance.HienThi1();
        }


        public List<GoiTiemDTO> getListGoitiem()
        {
            return GoiTiemDAO.Intance.getListGoitiem();
        }


        public DataTable TimKiemTG(string maPN)
        {
            return GoiTiemDAO.Intance.TimKiemTG(maPN);
        }


        public bool themChiTietGoiTiem(string maGT, string maVX, DateTime ngayPH, int soLieu)
        {
            return GoiTiemDAO.Intance.themChiTietGoiTiem(maGT, maVX, ngayPH, soLieu);
        }


        public DataTable TimKiemMaVXMaGT(string maGT, string maVX)
        {
            return GoiTiemDAO.Intance.TimKiemMaVXMaGT(maGT, maVX);
        }


        public DataTable TimKiemTT(string tk)
        {
            return GoiTiemDAO.Intance.TimKiemTT(tk);
        }


        public bool xoaChiTietGoiTiem(string maGT, string maVX)
        {
            return GoiTiemDAO.Intance.xoaChiTietGoiTiem(maGT, maVX);
        }


        public bool suaChiTietGoiTiem(string maGT, string maVX, DateTime thoigian, int sl)
        {
            return GoiTiemDAO.Intance.suaChiTietGoiTiem(maGT, maVX, thoigian, sl);
        }


        public DataTable TimKiemMaVX(string maGT)
        {
            return GoiTiemDAO.Intance.TimKiemMaVX(maGT);
        }


        public DataTable TimKiemGiaBan(string maGT)
        {
            return GoiTiemDAO.Intance.TimKiemGiaBan(maGT);
        }
    }
}