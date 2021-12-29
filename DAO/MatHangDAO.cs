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

        public bool suaHH(string MaHang, string TenHH, string loai, string GiaBan, string DonVi)
        {
            string query = String.Format("update MatHang set  GiaBan = '" + GiaBan + "', TenMH = N'" + TenHH + "',MaLH = N'" + loai + "', DonVi = N'" + DonVi + "'  where MaMH = '" + MaHang + "'");
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
            string query = String.Format("delete from MatHang where MaMH = '{0}'", maKH);
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
            string query = "select MatHang.MaMH as [Mã hàng hóa],MatHang.TenMH as [Tên hàng hóa],DonVi as [Đơn vị tính],sum(ChitietPN.Soluong) as [Số lượng nhập],MatHang.SoLuong as [Số lượng tồn], (sum(ChitietPN.Soluong) - MatHang.SoLuong) as [Số lượng bán],MatHang.GiaBan as [Giá bán] from MatHang inner join ChiTietPN on MatHang.MaMH = ChiTietPN.MaMH where MatHang.TenMH like N'%" + tk + "%' or MatHang.MaMH like '%" + tk + "%'  group by MatHang.MaMH,MatHang.SoLuong,MatHang.TenMH,MatHang.DonVi,DonVi,MatHang.GiaBan";
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
            string query = "select MaLH from LoaiHang where TenLH = N'" + tk + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable TimKiemMHTrongKH(string tk)
        {
            string query = "select MaMH as [Mã mặt hàng], TenMH as [Tên mặt hàng], DonVi as [Đơn vị],SoLuong as [Số lượng], GiaBan as [Giá bán], TenLH as [Loại hàng] from MatHang inner join LoaiHang on MatHang.MaLH = LoaiHang.MaLH where MaMH like N'%"+tk+ "%' or TenMH like N'%" + tk + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable TimKiemSL(string tk)
        {
            string query = "select SoLuong from MatHang where MaMH = N'" + tk + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

    }
}
