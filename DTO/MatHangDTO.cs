using System.Data;

namespace DTO
{
    public class MatHangDTO
    {
 
        private string maVX, tenVX;
       

        public MatHangDTO()
        {

        }
        public MatHangDTO(DataRow row)
        {
            this.MaVX = row["MaVX"].ToString();
            this.TenVX = row["TenVX"].ToString();
           
        }

        public string MaVX { get => maVX; set => maVX = value; }
        public string TenVX { get => tenVX; set => tenVX = value; }
    }
}

