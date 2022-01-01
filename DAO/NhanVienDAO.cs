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
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public NhanVienDAO()
        {
        }

        public static NhanVienDAO Intance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            set => instance = value;
        }

        public bool Login(string userName, string passWord)
        {
            string query = "SELECT * FROM NhanVien WHERE TenDangNhap = N'" + userName + "' AND MatKhau = N'" + passWord + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public NhanVienDTO getNVByID(string id)
        {
            string query = "SELECT * FROM NhanVien WHERE TenDangNhap = N'" + id + "'";
            DataRow a = DataProvider.Instance.ExecuteQuery(query).Rows[0];
            return new NhanVienDTO(a);
        }

        public DataTable getListNV()
        {
            string query = "select MaNV as [Mã nhân viên],TenHienThi as [Tên nhân viên],GioiTinh as [Giới tính],DiaChi as [Địa chỉ],SDT as [Số điện thoại],Quyen as [Chức vụ] from NhanVien";
            return DataProvider.Instance.ExecuteQuery(query);
        }



        public bool suaNV(string maNV, string tenNV, string DiaChi, string GioiTinh, string SDT, string quyen)
        {
            string query = String.Format("update NhanVien set TenHienThi = N'"+tenNV+"', DiaChi = N'"+DiaChi+"', SDT = '"+SDT+"', GioiTinh = N'"+GioiTinh+"', Quyen = N'"+quyen+"' where MaNV = '"+maNV+"'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool xoaNV(string maNV)
        {
            string query = String.Format("delete from NhanVien where MaNV = '{0}'", maNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable TimKiemNV(string name)
        {
            string query = string.Format("select MaNV as [Mã nhân viên],TenHienThi as [Tên nhân viên],GioiTinh as [Giới tính],DiaChi as [Địa chỉ],SDT as [Số điện thoại],Quyen as [Chức vụ] FROM NhanVien WHERE NhanVien.TenHienThi LIKE N'%"+name+"%' or MaNV LIKE '%"+name+"%'");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public string loadMaNV()
        {
            string maNVnext = "";
            string query = "select top 1 MaNV from NhanVien order by MaNV desc";
            DataRow data = DataProvider.Instance.ExecuteQuery(query).Rows[0];
            maNVnext = data["MaNV"].ToString();
            return maNVnext;
        }


        public bool themNV(string maNV, string tenNV, string Gioitinh, string DiaChi, string SDT, string Tendangnhap, string Matkhau)
        {

            string query = String.Format("insert into NhanVien(MaNV,TenHienThi,GioiTinh,DiaChi,SDT,TenDangNhap,MatKhau) values  ('{0}',N'{1}',N'{2}',N'{3}','{4}','{5}','{6}')", maNV, tenNV, Gioitinh, DiaChi, SDT, Tendangnhap, Matkhau);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public bool capnhatmk(string mk, string sdt)
        {
            string query = String.Format("update NhanVien set MatKhau = '{0}' where SDT = '{1}'", mk, sdt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public bool capnhatmk1(string mk, string tk)
        {
            string query = String.Format("update NhanVien set MatKhau = '{0}' where SDT = '{1}'", mk, tk);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public List<NhanVienDTO> getListNhanVien()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from NhanVien");
            foreach (DataRow item in data.Rows)
            {
                NhanVienDTO Nhanvien = new NhanVienDTO(item);
                list.Add(Nhanvien);
            }
            return list;
        }


        public DataTable getTTNV(string id)
        {
            string query = "SELECT * FROM NhanVien WHERE TenHienThi = N'" + id + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }


        public bool Loginn(string userName, string passWord)
        {
            string query = "SELECT * FROM NhanVien WHERE SDT = '" + userName + "' AND MatKhau = '" + passWord + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }


        public DataTable CapLaiMK(string id)
        {
            string query = "SELECT SDT FROM NhanVien WHERE SDT = N'" + id + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }


        public DataTable TKNhanVien()
        {
            string query = "USP_TKNhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
