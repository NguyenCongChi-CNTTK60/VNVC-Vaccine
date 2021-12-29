using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GoiTiemDTO
    {

        private string maGT, tenGT;


        public GoiTiemDTO()
        {

        }
        public GoiTiemDTO(DataRow row)
        {
            this.MaGT = row["MaGT"].ToString();
            this.TenGT = row["TenGT"].ToString();

        }

        public string MaGT { get => maGT; set => maGT = value; }
        public string TenGT { get => tenGT; set => tenGT = value; }
    }
}
