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
    public class GoiTiemDAO
    {
        private static GoiTiemDAO instance;

        public GoiTiemDAO()
        {
        }

        public static GoiTiemDAO Intance
        {
            get { if (instance == null) instance = new GoiTiemDAO(); return instance; }
            set => instance = value;
        }


        public DataTable HienThi()
        {
            string query = "select MaGT as [Mã gói tiêm], TenGT as [Tên gói tiêm] from GoiTiem";
            return DataProvider.Instance.ExecuteQuery(query);
        }


        public DataTable HienThi1()
        {
            string query = "select GoiTiem.MaGT as [Mã gói tiêm], VacXin.MaVX as [Mã Vaccine],TenGT as [Tên gói tiêm],TenVX as [Tên Vaccine], ThoiGian as [Ngày phát hàng], SoLieu as [Số liều] from ChiTietGoiTiem inner join GoiTiem on ChiTietGoiTiem.MaGT = GoiTiem.MaGT inner join VacXin on VacXin.MaVX = ChiTietGoiTiem.MaVX";
            return DataProvider.Instance.ExecuteQuery(query);
        }


        public List<GoiTiemDTO> getListGoitiem()
        {
            List<GoiTiemDTO> list = new List<GoiTiemDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from GoiTiem");
            foreach (DataRow item in data.Rows)
            {
                GoiTiemDTO MatHang = new GoiTiemDTO(item);
                list.Add(MatHang);
            }
            return list;
        }


        public DataTable TimKiemTG(string maPN)
        {
            string query = "select ThoiGian from ChiTietGoiTiem where MaGT = '"+maPN+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public bool themChiTietGoiTiem(string maGT, string maVX, DateTime ngayPH, int soLieu)
        {
            string query = String.Format("insert into ChiTietGoiTiem(MaGT, MaVX, ThoiGian,SoLieu) values ('{0}', N'{1}', N'{2}', N'{3}')", maGT, maVX, ngayPH, soLieu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public DataTable TimKiemMaVXMaGT (string maGT, string maVX)
        {
            string query = "select MaGT,MaVX from ChiTietGoiTiem where MaGT = '"+maGT+"' and MaVX = '"+maVX+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


         public bool xoaChiTietGoiTiem(string maGT, string maVX)
        {
            string query = String.Format("delete ChiTietGoiTiem where MaGT = '"+maGT+"' and MaVX = '"+maVX+"'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public DataTable TimKiemTT(string tk)
        {
            string query = "select GoiTiem.MaGT as [Mã gói tiêm], VacXin.MaVX as [Mã Vaccine],TenGT as [Tên gói tiêm],TenVX as [Tên Vaccine], ThoiGian as [Ngày phát hàng], SoLieu as [Số liều] from ChiTietGoiTiem inner join GoiTiem on ChiTietGoiTiem.MaGT = GoiTiem.MaGT inner join VacXin on VacXin.MaVX = ChiTietGoiTiem.MaVX where GoiTiem.MaGT like N'%"+tk+ "%' or GoiTiem.TenGT like N'%" + tk + "%' or VacXin.MaVX like N'%" + tk + "%' or VacXin.TenVX like N'%" + tk + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public bool suaChiTietGoiTiem(string maGT, string maVX, DateTime thoigian, int sl)
        {
            string query = String.Format("update ChiTietGoiTiem set MaGT = N'" + maGT + "', MaVX = N'" + maVX + "', ThoiGian = '" + thoigian + "', SoLieu = N'" + sl + "' where MaGT = N'" + maGT + "' and MaVX = N'" + maVX + "'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }



        public DataTable TimKiemMaVX(string maGT)
        {
            string query = "select MaVX from VacXin where TenVX = N'"+maGT+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable TimKiemGiaBan(string maGT)
        {
            string query = "select GiaBan,SoLuong from VacXin where MaVX = N'" + maGT + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public bool themGoiTiem(string maGT, string tenGT)
        {
            string query = String.Format("insert into GoiTiem(MaGT, TenGT) values ('{0}', N'{1}')", maGT, tenGT);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public bool suaGoiTiem(string maGT, string tenGT)
        {
            string query = String.Format("update GoiTiem set TenGT = N'" + tenGT + "' where MaGT = N'" + maGT + "'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public bool xoaGoiTiem(string maGT)
        {
            string query = String.Format("delete GoiTiem where MaGT = '" + maGT + "'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


    }
}
