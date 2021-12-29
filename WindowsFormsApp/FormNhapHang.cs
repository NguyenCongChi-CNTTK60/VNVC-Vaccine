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
using System.IO;
using BUS;
using DTO;

namespace WindowsFormsApp
{
    public partial class FormNhapHang : Form
    {
        private string manv;
        private string tennv;
        public FormNhapHang(string manv, string tennv)
        {
            InitializeComponent();


            lsvNhaphang.View = View.Details;
            lsvNhaphang.GridLines = true;
            lsvNhaphang.FullRowSelect = true;

            lsvNhaphang.Columns.Add("Mã mặt hàng", 150);   //0
            lsvNhaphang.Columns.Add("Tên mặt hàng", 200);  //1
            lsvNhaphang.Columns.Add("Số lượng,", 100);   //2
            lsvNhaphang.Columns.Add("Đơn giá", 200);  // 3
            lsvNhaphang.Columns.Add("Tổng tiền", 220);  // 4

            lblMapn.Text = Matudong();


            list = getListSanPham();
            cmbTensp.DataSource = list;
            cmbTensp.ValueMember = "MaMH";
            cmbTensp.DisplayMember = "TenMH";


            list1 = getListNhaCungCap();
            cmbTenncc.DataSource = list1;
            cmbTenncc.ValueMember = "MaNCC";
            cmbTenncc.DisplayMember = "TenNCC";

            lblMancc.Text = "";
            lblTenncc.Text = "";
            lblDiachi.Text = "";
            lblSĐT.Text = "";
            cmbTenncc.SelectedIndex = -1;

            Lammoi();
            DateTime today = DateTime.Now;
            dtpkNgaynhap.Value = new DateTime(today.Year, today.Month, today.Day);

            this.manv = manv;
            lblManv.Text = manv;
            this.tennv = tennv;
            lblTennv.Text = tennv;

            

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
                k = dt.Rows.Count;
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




        public List<MatHangDTO> getListSanPham()
        {
            string query = "select * from MatHang";
            List<MatHangDTO> list = new List<MatHangDTO>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                MatHangDTO product = new MatHangDTO(item);
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



        int i;
        private void cmbTensp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTensp.SelectedIndex >= 0)
            {
                i = cmbTensp.SelectedIndex;
              //  lblmasp.Text = list[i].MaMH;
              //  lbltensp.Text = list[i].TenMH;
              //  txtGiaban.Text = list[i].GiaBan.ToString();
                //txtGia.Text = list[i].GiaGoc.ToString();
            }



        }

        private void cmbTenncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenncc.SelectedIndex >= 0)
            {
                i = cmbTenncc.SelectedIndex;
                lblMancc.Text = list1[i].MaNCC;
                lblTenncc.Text = list1[i].TenNCC;
                lblDiachi.Text = list1[i].DiaChi;
                lblSĐT.Text = list1[i].SDT;
            }
        }


        int tongTien;
        private void btnThem_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (check_data() == true)
            {
                string query = "update MatHang set GiaBan = '" + txtGiaban.Text + "'  where MaMH = '" + lblmasp.Text + "'";  // cập nhật lại số lượng 
                DataProvider.Instance.ExecuteQuery(query);
               
                if (Int32.Parse(txtSoLuong.Text.ToString()) <= 0)
                {
                    MessageBox.Show("Số lượng nhập phải lớn hơn 0");
                }
                else if (Int32.Parse(txtGia.Text.ToString()) <= 0)
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
                            int temp = Int32.Parse(N.SubItems[2].Text) + Int32.Parse(txtSoLuong.Text.ToString());
                            N.SubItems[2].Text = temp.ToString();
                            N.SubItems[4].Text = (Int32.Parse(N.SubItems[2].Text) * Int32.Parse(N.SubItems[3].Text)).ToString();
                            break;
                        }
                    }

                    int gia = Int32.Parse(txtGia.Text) * Int32.Parse(txtSoLuong.Text.ToString());
                    if (!check)
                    {
                        string[] arr = new string[5];
                        arr[0] = lblmasp.Text.ToString();
                        arr[1] = lbltensp.Text;
                        arr[2] = txtSoLuong.Text.ToString();
                        arr[3] = txtGia.Text;
                        arr[4] = gia.ToString();
                        ListViewItem listViewItem = new ListViewItem(arr);
                        lsvNhaphang.Items.Add(listViewItem);
                    }
                    tongTien += gia;
                    lbltong.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tongTien) + "VNĐ";
                    Lammoi();
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm hoặc Nhà cung cấp");
                }
            }
        }

       


        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsvNhaphang.Items.Count; i++) //duyệt tất cả các item trong list
            {
                if (lsvNhaphang.Items[i].Checked)//nếu item đó dc check
                {
                    string tien = lsvNhaphang.Items[i].SubItems[4].Text.ToString();
                    tongTien -= Int32.Parse(tien);
                    lbltong.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tongTien) + " VNĐ";
                    lsvNhaphang.Items[i].Remove();//xóa item đó đi
                    i--;
                }
            }
        }



        private void Lammoi()
        {
            cmbTensp.SelectedIndex = -1;
            txtSoLuong.Text = "0";
            txtGia.Text = "0";  
            lblmasp.Text = "";
            lbltensp.Text = "";
            pcbHangHoa.Image = null;
        }



        private bool check_data()
        {
            if (string.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show("Giá nhập không được trống");
                return false;
            }
            else if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Số lượng không được trống");
                return false;
            }

            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (lsvNhaphang.Items.Count > 0)
            {
                PhieuNhapDTO pn = new PhieuNhapDTO();
                pn.MaPN = lblMapn.Text;
                pn.NgayNhap = dtpkNgaynhap.Value;
                pn.MaNCC = lblMancc.Text;
                pn.MaNV = lblManv.Text;





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
                    lbltong.Text = "0 VNĐ";
                    tongTien = 0;
                    lblMapn.Text = Matudong();
                    Lammoi();
                    MessageBox.Show("Nhập hàng thành công");

                }
                else
                {
                    MessageBox.Show("Bạn chưa có sản phẩm để Lưu");
                }
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







        private void btnThemSP_Click(object sender, EventArgs e)
        {
            FormThongTinHangMoi f = new FormThongTinHangMoi();
            f.Show();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {

            list = getListSanPham();
            cmbTensp.DataSource = list;
            cmbTensp.ValueMember = "MaMH";
            cmbTensp.DisplayMember = "TenMH";


            list1 = getListNhaCungCap();
            cmbTenncc.DataSource = list1;
            cmbTenncc.ValueMember = "MaNCC";
            cmbTenncc.DisplayMember = "TenNCC";

            cmbTensp.SelectedIndex = -1;
            cmbTenncc.SelectedIndex = -1;
            lblMancc.Text = "";
            lblTenncc.Text = "";
            lblDiachi.Text = "";
            lblSĐT.Text = "";
            cmbTenncc.SelectedIndex = -1;
            txtGiaban.Text = "";
            Lammoi();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            string query = "update MatHang set SoLuong = 0,GiaBan = 0 where MaMH = '" + lblmasp.Text + "'";  // cập nhật lại số lượng 
            DataProvider.Instance.ExecuteQuery(query);
        }

        string imgLocation = Application.StartupPath + "\\Resources\\hanghoa.png";

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "PNG files(*.png)|*.png|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dlgOpen.FileName.ToString();
                pcbHangHoa.Image = Image.FromFile(dlgOpen.FileName);
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
