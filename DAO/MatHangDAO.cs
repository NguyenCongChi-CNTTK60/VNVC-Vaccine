using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using WindowsFormsApp;

namespace DAO
{
    public class MatHangDAO
    {
        private static MatHangDAO instance;

        public MatHangDAO()
        {
        }

        public static MatHangDAO Intance
        {
            get { if (instance == null) instance = new MatHangDAO(); return instance; }
            set => instance = value;
        }

        public List<MatHangDTO> getListSanPham()
        {
            List<MatHangDTO> list = new List<MatHangDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from VacXin");
            foreach (DataRow item in data.Rows)
            {
                MatHangDTO MatHang = new MatHangDTO(item);
                list.Add(MatHang);
            }
            return list;
        }

        public bool suaHH(string MaHang, string TenHH, string loai, int GiaBan, string phongbenh, string nuocsx)
        {
            string query = String.Format("update VacXin set  GiaBan = '" + GiaBan + "', TenVX = N'" + TenHH + "',MaLoai = N'" + loai + "', PhongBenh = N'" + phongbenh + "', NuocSX = N'" + nuocsx + "'  where MaVX = '" + MaHang + "'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public bool kiemtraXoa(string maHang)
        {
            string query = String.Format("select * from ChiTietHD where MaMH = '{0}'", maHang);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return false;
            }
            query = String.Format("select * from ChiTietPN where MaMH = '{0}'", maHang);
            data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }

        public bool capNhatHH(string maHang, int SL, int DonGia)
        {
            string query = String.Format("update MatHang set SoLuong = {0} + SoLuong, GiaGoc = (GiaGoc + {1})/2 where MaMH = '{2}'", SL, DonGia, maHang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool xoaHang(string maKH)
        {
            string query = String.Format("delete from VacXin where MaVX = '{0}'", maKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public string loadMaHH()
        {
            string maKHnext = "SP001";
            string query = "select top 1 MaMH from MatHang order by MaMH desc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                DataRow data2 = data.Rows[0];
                string maKH = data2["MaMH"].ToString();
                maKHnext = maKH.Substring(2);
                int i = Convert.ToInt32(maKHnext);
                i = i + 1;
                if (i < 100 && i > 9)
                {
                    maKHnext = "SP0" + i;
                }
                else if (i < 10) maKHnext = "SP00" + (i);
                else
                {
                    maKHnext = "SP" + i;
                }
            }

            return maKHnext;
        }

        public DataTable TimKiemHH(string maPN)
        {
            string query = "exec usp_timMatHang @maPN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maPN });
            return data;
        }

   
      

        public void capNhatHinh(string imgLocation, string maHang)
        {
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            // Update hình nếu có
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-RNOPI29;Initial Catalog=QLSieuThi;User ID=sa;Password=123"))
            {
                string query = String.Format("Update MatHang set Anh = @hinh where MaMH = '{0}'", maHang);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(new SqlParameter("@hinh", images));
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public byte[] getAnhByID(string ID)
        {
            string query = String.Format("select Anh from MatHang where MaMH = '{0}'", ID);
            DataRow data = DataProvider.Instance.ExecuteQuery(query).Rows[0];
            byte[] img = ((byte[])data["Anh"]);
            return img;
        }


        // CHÍ
        public DataTable TKMatHang()
        {
            string query = "USP_TKMatHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable TimKiemMH(string tk)
        {
            string query = "select VacXin.MaVX as [Mã Vaccine],VacXin.TenVX as [Tên Vaccine],sum(ChitietPN.Soluong) as [Số lượng nhập],VacXin.SoLuong as [Số lượng tồn], (sum(ChitietPN.Soluong) - VacXin.SoLuong) as [Số lượng bán],VacXin.GiaBan as [Giá bán] from VacXin inner join ChiTietPN on VacXin.MaVX = ChiTietPN.MaVX where VacXin.MaVX like '"+tk+"' or VacXin.TenVX like N'"+tk+"' group by VacXin.MaVX,VacXin.TenVX,VacXin.SoLuong,VacXin.GiaBan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable TimKiemGiaBan(string maMH)
        {
            string query = "select GiaBan from MatHang where MaMH = '" + maMH + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable HienThi()
        {
            string query = "select MaVX as [Mã Vaccine], TenVX as [Tên Vacine],SoLuong as [Số lượng], GiaBan as [Giá bán],PhongBenh as [Phòng bệnh], TenLoai as [Loại Vaccine],NuocSX as [Nước sản xuất] from VacXin inner join LoaiVacXin on VacXin.MaLoai = LoaiVacXin.MaLoai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable TimKiemLH(string tk)
        {
            string query = "select MaLoai from LoaiVacXin where TenLoai = N'" + tk + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable TimKiemMHTrongKH(string tk)
        {
            string query = "select MaVX as [Mã Vaccine], TenVX as [Tên Vacine],SoLuong as [Số lượng], GiaBan as [Giá bán],PhongBenh as [Phòng bệnh], TenLoai as [Loại Vaccine],NuocSX as [Nước sản xuất] from VacXin inner join LoaiVacXin on VacXin.MaLoai = LoaiVacXin.MaLoai where MaVX like N'%" + tk+ "%' or TenVX like N'%" + tk + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable TimKiemSL(string tk)
        {
            string query = "select SoLuong from VacXin where MaVX = N'" + tk + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

    }
}
