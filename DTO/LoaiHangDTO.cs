using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiHangDTO
    {
        string maloai, tenloai;

        public LoaiHangDTO(DataRow row)
        {
            this.Maloai = row["MaLoai"].ToString();
            this.Tenloai = row["TenLoai"].ToString();
        }

      
        public string Maloai { get => maloai; set => maloai = value; }
        
        public string Tenloai { get => tenloai; set => tenloai = value; }
    }
}
