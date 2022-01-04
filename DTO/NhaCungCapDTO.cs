using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
      

        private string maNCC, tenNCC, diaChi, sDT, email;

        public NhaCungCapDTO()
        {
        }

        public NhaCungCapDTO(DataRow row)
        {
            this.MaNCC = row["MaNCC"].ToString();
            this.TenNCC = row["TenNCC"].ToString();
            this.DiaChi = row["NuocSX"].ToString();
            this.SDT = row["SDT"].ToString();
            this.Email = row["Email"].ToString();
        }

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Email { get => email; set => email = value; }
    }
}





