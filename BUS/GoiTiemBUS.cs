using DAO;
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


    }
}
