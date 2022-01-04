using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using WindowsFormsApp;

namespace DAO
{
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;

        public NhaCungCapDAO()
        {
        }

        public static NhaCungCapDAO Intance
        {
            get { if (instance == null) instance = new NhaCungCapDAO(); return instance; }
            set => instance = value;
        }

        public List<NhaCungCapDTO> getListNCC()
        {
            List<NhaCungCapDTO> list = new List<NhaCungCapDTO>();
            string query = "select * from NhaCungCap";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhaCungCapDTO hangHoa = new NhaCungCapDTO(item);
                list.Add(hangHoa);
            }
            return list;
        }


        public DataTable HienThi()
        {
            string query = "select MaNCC as [Mã nhà cung cấp], TenNCC as [Tên nhà cung cấp], SDT  as [Số điện thoại],   NuocSX as [Địa chỉ], Email from NhaCungCap";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;

        }

        public bool themNCC(string mancc, string tenncc, string diachi, string sdt, string email)
        {
            string query = String.Format("insert into NhaCungCap(MaNCC, TenNCC, NuocSX, SDT, Email) values ('{0}', N'{1}', N'{2}', N'{3}', N'{4}')", mancc,tenncc,diachi,sdt,email);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool suaNCC(string mancc, string tenncc, string diachi, string sdt, string email)
        {
            string query = String.Format("update NhaCungCap set TenNCC = N'"+tenncc+"', NuocSX = N'"+diachi+"', SDT = '"+sdt+"', Email = '"+email+"' where MaNCC = '"+mancc+"'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool xoaNCC(string maKH)
        {
            string query = String.Format("delete from NhaCungCap where MaNCC = '{0}'", maKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public string loadMaNCC()
        {
            string maKHnext = "NCC001";
            string query = "select top 1 MaNCC from NhaCungCap order by MaNCC desc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                DataRow data2 = data.Rows[0];
                string maKH = data2["MaNCC"].ToString();
                maKHnext = maKH.Substring(3);
                int i = Convert.ToInt32(maKHnext);
                i = i + 1;
                if (i < 100 && i > 9)
                {
                    maKHnext = "NCC0" + i;
                }
                else if (i < 10) maKHnext = "NCC00" + (i);
                else
                {
                    maKHnext = "NCC" + i;
                }
            }

            return maKHnext;
        }

        public DataTable TimKiemNCC(string maPN)
        {
            string query = "select MaNCC as [Mã nhà cung cấp], TenNCC as [Tên nhà cung cấp], SDT  as [Số điện thoại],   NuocSX as [Địa chỉ], Email  from NhaCungCap where MaNCC like N'%" + maPN+ "%' or TenNCC like N'%" + maPN + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }




    }
}
