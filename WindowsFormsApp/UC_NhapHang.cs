using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class UC_NhapHang : UserControl
    {

        private string manv;
        private string tennv;
        public UC_NhapHang(string manv,string tennv)     // string manv, string tennv
        {
            InitializeComponent();
            /*
            cmbTensp.SelectedIndex = 0;
            cmbTenncc.SelectedIndex = 0;
 
            
            
             lsvNhaphang.View = View.Details;
             lsvNhaphang.GridLines = true;
             lsvNhaphang.FullRowSelect = true;

             lsvNhaphang.Columns.Add("Mã SP", 120);   //0
             lsvNhaphang.Columns.Add("Tên sản phẩm", 200);  //1
             lsvNhaphang.Columns.Add("Số lượng,", 100);   //2
             lsvNhaphang.Columns.Add("Đơn giá", 100);  // 3
             lsvNhaphang.Columns.Add("Tổng tiền", 150);  // 4


            
             lblMapn.Text = Matudong();
             this.dpkNgaykt.Enabled = false;
            DateTime today = DateTime.Now;
            dpkNgaykt.Value = new DateTime(today.Year, today.Month, today.Day);

            

             this.manv = manv;
             txtMaNV.Text = manv;
             this.tennv = tennv;
             txtTenNV.Text = tennv; */

             

        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {

        }
        /*

private void dpkNgaykt_ValueChanged(object sender, EventArgs e)
{

}



public List<MatHangDTO> getListSanPham()
{
   string query = "select * from MatHang";
   List<MatHangDTO> list = new List<MatHangDTO>();
   DataTable dt = DataProvider.Instance.ExecuteQuery(query);
   foreach (DataRow item in dt.Rows)
   {
      MatHangDTO  product = new MatHangDTO(item);
       list.Add(product);
   }
   return list;
}
List<MatHangDTO> list;


public List<NhaCungCapDTO> getListNhaCungCap()
{
   string query = "select * from NhaCungCap";
   List<NhaCungCapDTO> list = new List<NhaCungCapDTO>();
   DataTable dt = DataProvider.Instance.ExecuteQuery(query);
   foreach (DataRow item in dt.Rows)
   {
       NhaCungCapDTO TTncc = new NhaCungCapDTO(item);
       list.Add(TTncc);
   }
   return list;

}
List<NhaCungCapDTO> list1;




private void cmbTensp_Click(object sender, EventArgs e)
{
   //List<MatHangDTO> list;
   list = getListSanPham();
   cmbTensp.DataSource = list;
   cmbTensp.ValueMember = "MaMH";
   cmbTensp.DisplayMember = "TenMH";
   //cmbTensp.SelectedIndex = -1;
}

private void cmbTenncc_Click(object sender, EventArgs e)
{
   list1 = getListNhaCungCap();
   cmbTenncc.DataSource = list1;
   cmbTenncc.ValueMember = "MaNCC";
   cmbTenncc.DisplayMember = "TenNCC";
}






private string Matudong()
{
   string query = "select MaPN from PhieuNhap";
   DataTable dt = DataProvider.Instance.ExecuteQuery(query);
   string ma = "";
   if (dt.Rows.Count <= 0)
   {
       ma = "PN001";
   }
   else
   {
       int k;
       ma = "PN";
       //k = dt.Rows.Count;
       k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
       k++;

       if (k < 10)
       {
           ma = ma + "00";
       }
       else if (k >= 10 && k < 100)
       {
           ma = ma + "0";
       }
       else if (k >= 100 && k < 1000)
       {
           ma = ma + " ";
       }
       ma = ma + k.ToString();

   }
   return ma;
}


int i;
private void cmbTensp_SelectedIndexChanged(object sender, EventArgs e)
{
   if (cmbTensp.SelectedIndex > 0)
   {
       i = cmbTensp.SelectedIndex;
       lblmasp.Text = list[i].MaMH;

       txtGiaBan.Text = list[i].GiaBan.ToString();
       //txtGia.Text = list[i].GiaGoc.ToString();
   }
}

private void btnThem_Click(object sender, EventArgs e)
{
   bool check = false;
   if (check_data() == true)
   {
       string query = "update MatHang set GiaBan = '" + txtGiaBan.Text + "'  where MaMH = '" + lblmasp.Text + "'";  // cập nhật lại số lượng 
       DataProvider.Instance.ExecuteQuery(query);

       if (Int32.Parse(txtSL.Text.ToString()) <= 0)
       {
           MessageBox.Show("Số lượng nhập phải lớn hơn 0");
       }
       else if (Int32.Parse(txtGiaNhap.Text.ToString()) <= 0)
       {
           MessageBox.Show("Giá nhập phải lớn hơn 0");
       }

       else
      if (cmbTensp.SelectedIndex >= 0 && cmbTenncc.SelectedIndex >= 0)
       {
           foreach (ListViewItem N in lsvNhaphang.Items)
           {
               if (N.SubItems[0].Text == cmbTensp.SelectedValue.ToString())
               {
                   check = true;
               }
               if (check == true)
               {
                   int temp = Int32.Parse(N.SubItems[2].Text) + Int32.Parse(txtSL.Text.ToString());
                   N.SubItems[2].Text = temp.ToString();
                   N.SubItems[4].Text = (Int32.Parse(N.SubItems[2].Text) * Int32.Parse(N.SubItems[3].Text)).ToString();
                   break;
               }
           }

           int gia = Int32.Parse(txtGiaNhap.Text) * Int32.Parse(txtSL.Text.ToString());
           if (!check)
           {
               string[] arr = new string[5];
               arr[0] = lblmasp.Text.ToString();
               arr[1] = cmbTensp.Text;
               arr[2] = txtSL.Text.ToString();
               arr[3] = txtGiaNhap.Text;
               arr[4] = gia.ToString();
               ListViewItem listViewItem = new ListViewItem(arr);
               lsvNhaphang.Items.Add(listViewItem);
           }
           //tongTien += gia;
           //lbltong.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tongTien) + "VNĐ";
           Lammoi();
       }
       else
       {
           MessageBox.Show("Bạn chưa chọn sản phẩm hoặc Nhà cung cấp");
       }
   }
}




private bool check_data()
{
   return true;
}

private void txtGiaNhap_TextChanged(object sender, EventArgs e)
{
   if (!string.IsNullOrEmpty(txtGiaNhap.Text))
   {
       int temp = Int32.Parse(txtGiaNhap.Text);
       txtformatgianhap.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", temp) + " đ";
   }
}

private void txtGiaBan_TextChanged(object sender, EventArgs e)
{
   if (!string.IsNullOrEmpty(txtGiaBan.Text))
   {
       int temp = Int32.Parse(txtGiaBan.Text);
       txtformatGiaban.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", temp) + " đ";
   }
}



private void Lammoi()
{
   cmbTensp.SelectedIndex = 0;
   txtSL.Text = "0";
   txtGiaNhap.Text = "0";
   lblmasp.Text = "";
   txtGiaBan.Text = "0";
   cmbTenncc.SelectedIndex = 0;

}

private void btnXoa_Click(object sender, EventArgs e)
{
   for (int i = 0; i < lsvNhaphang.Items.Count; i++) //duyệt tất cả các item trong list
   {
       if (lsvNhaphang.Items[i].Checked)//nếu item đó dc check
       {
           string tien = lsvNhaphang.Items[i].SubItems[4].Text.ToString();
           //tongTien -= Int32.Parse(tien);
           //lbltong.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tongTien) + " VNĐ";
           lsvNhaphang.Items[i].Remove();//xóa item đó đi
           i--;
       }
   }
}

private void cmbTenncc_SelectedIndexChanged(object sender, EventArgs e)
{
   if (cmbTenncc.SelectedIndex > 0)
   {
       i = cmbTenncc.SelectedIndex;
       lblMancc.Text = list1[i].MaNCC;
       //.Text = list1[i].TenNCC;
       txtDiaChi.Text = list1[i].DiaChi;
       txtSĐT.Text = list1[i].SDT;
       txtEmail.Text = list1[i].Email;
       txtDiaChi.ForeColor = Color.Black;
       txtSĐT.ForeColor = Color.Black;
       txtEmail.ForeColor = Color.Black;
   }
}




//
// Lưu phiếu nhập
//
private bool LuuPN(PhieuNhapDTO pn)
{
   // Convert datetime to date SQL Server 
   string query = String.Format("insert into PhieuNhap values('{0}','{1}','{2}','{3}')", pn.MaPN, pn.MaNCC, pn.NgayNhap, pn.MaNV);

   DataProvider.Instance.ExecuteQuery(query);
   return true;
}



//
// Lưu chi tiết phiếu nhập
//
private bool LuuChitietPN(string mapn, string mahh, int sl, int dongia)
{
   // Convert datetime to date SQL Server 
   string query = String.Format("insert into ChiTietPN values('{0}','{1}','{2}','{3}')", mapn, mahh, sl, dongia);
   DataProvider.Instance.ExecuteQuery(query);
   return true;
}



private void btnXacNhan_Click(object sender, EventArgs e)
{
   if (lsvNhaphang.Items.Count > 0)
   {
       PhieuNhapDTO pn = new PhieuNhapDTO();
       pn.MaPN = lblMapn.Text;
       pn.NgayNhap = dpkNgaykt.Value;
       pn.MaNCC = lblMancc.Text;
       pn.MaNV = txtMaNV.Text;





       if (LuuPN(pn))   // lưu hóa đơn
       {
           //FormInHD formInHD = new FormInHD(lblMakh.Text);
           foreach (ListViewItem item in lsvNhaphang.Items)
           {
               LuuChitietPN(pn.MaPN, item.SubItems[0].Text, Int32.Parse(item.SubItems[2].Text), Int32.Parse(item.SubItems[3].Text)); //lưu chi tiết hóa đơn
               string query = "update MatHang set SoLuong = SoLuong + " + Int32.Parse(item.SubItems[2].Text) + "where MaMH = '" + item.SubItems[0].Text + "'";  // cập nhật lại số lượng 
               DataProvider.Instance.ExecuteQuery(query);

           }

           lsvNhaphang.Items.Clear();
           //lbltong.Text = "0 VNĐ";
           //tongTien = 0;
           lblMapn.Text = Matudong();
           Lammoi();
           MessageBox.Show("Nhập hàng thành công");
           txtDiaChi.Text = "Địa chỉ";
           txtEmail.Text = "nhacungcap@gmail.com";
           txtSĐT.Text = "0328644258";
           txtDiaChi.ForeColor = Color.Silver;
           txtSĐT.ForeColor = Color.Silver;
           txtEmail.ForeColor = Color.Silver;

       }
       else
       {
           MessageBox.Show("Bạn chưa có sản phẩm để Lưu");
       }
   }
}

private void btnThemTTMathang_Click(object sender, EventArgs e)
{
   FormThongTinHangMoi f = new FormThongTinHangMoi();
   f.Show();
}

private void btnLamMoi_Click(object sender, EventArgs e)
{
   list = getListSanPham();
   cmbTensp.DataSource = list;
   cmbTensp.ValueMember = "MaMH";
   cmbTensp.DisplayMember = "TenMH";
}

private void guna2TextBox3_TextChanged(object sender, EventArgs e)
{

} */

    } 
}
