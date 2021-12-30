using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp;

namespace DAO
{
    public class LoaiHangDAO
    {
        private static LoaiHangDAO instance;

        public LoaiHangDAO()
        {
        }

        public static LoaiHangDAO Intance
        {
            get { if (instance == null) instance = new LoaiHangDAO(); return instance; }
            set => instance = value;
        }


        public List<LoaiHangDTO> getListLoaiHang()
        {
            List<LoaiHangDTO> list = new List<LoaiHangDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from LoaiVacXin");
            foreach (DataRow item in data.Rows)
            {
                LoaiHangDTO loaihang = new LoaiHangDTO(item);
                list.Add(loaihang);
            }
            return list;
        }


        public DataTable TimKiemTenMH(string tenLH)
        {
            string query = "select TenMH from MatHang inner join LoaiHang on MatHang.MaLH = LoaiHang.MaLH where TenLH = N'" + tenLH + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenLH });
            return data;
        }



        public DataTable TimKiemMaMH(string tenLH)
        {
            string query = "select MaMH,GiaBan from MatHang  where TenMH = N'" + tenLH + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable TimKiemMaMH1(string tenMH)
        {
            string query = "select MaMH from MatHang  where TenMH = N'" + tenMH + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenMH });
            return data;
        }



        public DataTable DemMaLH()
        {
            string query = "select MaLH from LoaiHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public bool ThemLH(string maLH, string tenLH)
        {
            string query = String.Format("insert into LoaiHang(MaLH,TenLH) values ('{0}',N'{1}')", maLH, tenLH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public DataTable TimKiemTenVaccine(string tenLH)
        {
            string query = "select TenVX from VacXin where MaLoai = '" + tenLH + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable TimKiemMaLoai(string tenLH)
        {
            string query = "select MaLoai from LoaiVacXin where TenLoai = '" + tenLH + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable TimKiemTenVaccine1(string tenLH)
        {
            string query = "UC_ChitietGT '"+tenLH+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
