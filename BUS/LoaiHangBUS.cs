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
    public class LoaiHangBUS
    {
        private static LoaiHangBUS instance;

        public LoaiHangBUS()
        {
        }

        public static LoaiHangBUS Intance
        {
            get { if (instance == null) instance = new LoaiHangBUS(); return instance; }
            set => instance = value;
        }


        public List<LoaiHangDTO> getListLoaiHang()
        {
            return LoaiHangDAO.Intance.getListLoaiHang();
        }


        public DataTable TimKiemGG(string tenLH)
        {
            return LoaiHangDAO.Intance.TimKiemTenMH(tenLH);
        }


        public DataTable TimKiemMaMH(string tenLH)
        {
            return LoaiHangDAO.Intance.TimKiemMaMH(tenLH);
        }


        public DataTable TimKiemMaMH1(string tenMH)
        {
            return LoaiHangDAO.Intance.TimKiemMaMH1(tenMH);
        }


        public DataTable DemMaLH()
        {
            return LoaiHangDAO.Intance.DemMaLH();
        }


        public bool ThemLH(string maLH, string tenLH)
        {
            return LoaiHangDAO.Intance.ThemLH(maLH, tenLH);
        }


        public DataTable TimKiemTenVaccine(string tenLH)
        {
            return LoaiHangDAO.Intance.TimKiemTenVaccine(tenLH);
        }

        public DataTable TimKiemMaLoai(string tenLH)
        {
            return LoaiHangDAO.Intance.TimKiemMaLoai(tenLH);
        }


        public DataTable TimKiemTenVaccine1(string tenLH)
        {
            return LoaiHangDAO.Intance.TimKiemTenVaccine1(tenLH);
        }
    }
}
