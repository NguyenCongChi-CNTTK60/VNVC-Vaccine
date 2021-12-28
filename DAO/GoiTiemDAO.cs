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

    }
}
