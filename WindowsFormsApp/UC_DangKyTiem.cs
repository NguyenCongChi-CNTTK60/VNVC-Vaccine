using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BUS;
using DTO;

namespace WindowsFormsApp
{
    public partial class UC_DangKyTiem : UserControl
    {
        private string manv, tennv;

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        public UC_DangKyTiem(string manv, string tennv)  // string manv, string tennv
        {
            InitializeComponent();

            //
            // Lấy ngày hiện tại
            //
            /*
            DateTime today = DateTime.Now;
            dtpNgayban.Value = new DateTime(today.Year, today.Month, today.Day);


            list = MatHangBUS.Intance.getListSanPham();
            cmbTenhh.DataSource = list;
            cmbTenhh.DisplayMember = "TenMH";
            cmbTenhh.ValueMember = "TenMH";


          


            this.tennv = tennv;
            //lblTenNV.Text = "";
            lblTenNV.Text = tennv;
            this.manv = manv;
            lblMaNV.Text = manv;


            List<KhachHangDTO> listKH = new List<KhachHangDTO>();
            DataTable data2 = KhachHangBUS.Intance.getListKH();
            foreach (DataRow item2 in data2.Rows)
            {
                KhachHangDTO kh = new KhachHangDTO(item2);
                listKH.Add(kh);
            }
            AutoCompleteStringCollection arrName2 = new AutoCompleteStringCollection();
            foreach (KhachHangDTO itemKH in listKH)
            {
                arrName2.Add(itemKH.SDT);
            }
            txtTimkiem.AutoCompleteCustomSource = arrName2;

            lblMahd.Text = Matudong();
            resetInfoProduct();
            this.dtpNgayban.Enabled = false; */
        }


        //
        // Tạo mã hóa đơn tự động
        // chí
        /*
        private string Matudong()
        {
            string query = "select MaHD from HoaDon";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "HD001";
            }
            else
            {
                int k;
                ma = "HD";
                //k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = dt.Rows.Count;
                k++;
                if (k < 10)
                    ma = ma + "00";
                {
                }
                else if (k >= 10 && k < 100)
                {
                    ma = ma + "0";
                }
                else if (k >= 100 && k < 1000)
                {
                    ma = ma + "";
                }
                ma = ma + k.ToString();

            }
            return ma;
        }



        private void btnThemDVT_Click(object sender, EventArgs e)
        {
            //FormDonViTinh tdvt = new FormDonViTinh();
            //tdvt.ShowDialog();
        }
        List<MatHangDTO> list;
        List<LoaiHangDTO> list1;


        KhachHangDTO khachHang = new KhachHangDTO()
        {
            MaKH = null
        };

        public KhachHangDTO GetTenBySDT(string id)
        {
            KhachHangDTO item = new KhachHangDTO();

            string query = "select * from KhachHang where SDT ='" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                item = new KhachHangDTO(data.Rows[0]);
                //lblMaKH.Text = data.Rows[0]["MaKH"].ToString();

            }
            return item;
        }




        private void resetInfoProduct()
        {

            cmbTenhh.SelectedIndex = -1;
            cmbLoaihang.SelectedIndex = -1;
            cmbTenhh.Text = "";
            cmbLoaihang.Text = "";
            txtSoLuong.Value = 0;
            lblGiaban.Text = "0 đ";
            lblMaKH.Text = "";
            lblMahh.Text = "";
            //lblMahh.Text = "";

        }



        //
        // Lưu hóa đơn
        //
        private bool LuuHD(HoaDonDTO dh)
        {
            // Convert datetime to date SQL Server 
            string query = String.Format("insert into HoaDon values('{0}','{1}','{2}','{3}','{4}')", dh.MaHD, dh.MaKH, dh.NgayTao, dh.MaNV, dh.TongTien);
            DataProvider.Instance.ExecuteQuery(query);
            return true;
        }


        private bool LuuDH(string mahd, string mahh, int sl, int dg)
        {
            string query = String.Format("insert into ChiTietHD values('{0}','{1}','{2}','{3}')", mahd, mahh, sl, dg);
            DataProvider.Instance.ExecuteQuery(query);
            return true;
        }







        private void btnok_Click(object sender, EventArgs e)
        {
            //int gia = Int32.Parse(txtGia.Text) * Int32.Parse(txtSoLuong.Value.ToString());
            //tongTien += gia;
            int tienkhachdua = Int32.Parse(txtTienkhachdua.Text);
            int tienhoantra = tienkhachdua - tongTien;
            lblTienhoantra.Text = string.Format(new CultureInfo("vi-VN"), "{0:#.##00}", tienhoantra) + " đ";

        }



        private int i;
        private int tiengiam = 0;
        private int tongTien = 0;
        private string Tienkhachduafomart;


        private void Tinhtienhoantra()
        {
            if (!string.IsNullOrEmpty(txtTienkhachdua.Text))
            {
                int tienkhachdua = Int32.Parse(txtTienkhachdua.Text);
                int tienhoantra = tienkhachdua - tongTien;
                lblFomart.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tienkhachdua) + " đ";
                lblTienhoantra.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tienhoantra) + " đ";
                Tienkhachduafomart = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tienkhachdua) + " đ";
            }
            else
                txtTienkhachdua.Text = "";
        }



        private void cmbTenmh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenhh.SelectedIndex >= 0)
            {
                i = cmbTenhh.SelectedIndex;
                //txtTenMH.Text = list[i].TenMH;
                //cmbMaMH.Text = list[i].MaMH;
                lblMahh.Text = list[i].MaMH.ToString();
                lblGiaban.Text = list[i].GiaBan.ToString();
                DataTable dt = LoaiHangBUS.Intance.TimKiemMaMH1(cmbTenhh.Text);
                cmbTenhh.DataSource = dt;

            }
        }



        private void cmbTenhh_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cmbTenhh.SelectedIndex >= 0)
            {
                i = cmbTenhh.SelectedIndex;
                DataTable dt1 = LoaiHangBUS.Intance.TimKiemMaMH(cmbTenhh.Text);

                if (dt1.Rows.Count > 0)
                {
                    lblMahh.Text = dt1.Rows[0]["MaMH"].ToString();
                    lblGiaban.Text = list[i].GiaBan.ToString();


                    string tk = lblMahh.Text;
                    // DataTable dt1 = MatHangBUS.Intance.TimKiemGiaBan(tk);
                   /* DataTable dt = GiamGiaBUS.Intance.TimKiemGG(tk);
                    if (dt.Rows.Count > 0)
                    {
                        DateTime Ngaybd = Convert.ToDateTime(dt.Rows[0]["NgayBD"].ToString());
                        DateTime Ngaykt = Convert.ToDateTime(dt.Rows[0]["NgayKT"].ToString());
                        lblGiaban.Text = dt1.Rows[0]["GiaBan"].ToString();

                        if (Ngaybd <= dtpNgayban.Value && dtpNgayban.Value <= Ngaykt)
                        {
                            lblPhantram.Text = dt.Rows[0]["PhanTram"].ToString();
                        }
                        else
                            lblPhantram.Text = "0";
                    }
                    else
                        lblPhantram.Text = "0"; 
                }
            }
        }



        private void cmbLoaihang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tk = cmbLoaihang.Text;
            DataTable dt = LoaiHangBUS.Intance.TimKiemGG(tk);
            DataTable dt1 = LoaiHangBUS.Intance.TimKiemMaMH(tk);
            if (dt.Rows.Count > 0 && dt.Rows.Count > 0)
            {
                cmbTenhh.DataSource = dt;
            }
        }


        private int TienGiam;
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtSoLuong.Value > 0 && !string.IsNullOrEmpty(lblMahh.Text) && !string.IsNullOrEmpty(cmbTenhh.Text))
            {
                bool check = false;

                foreach (ListViewItem item in lvSanPhamBan.Items)
                {
                    if (item.SubItems[0].Text == lblMahh.Text.ToString())
                    {
                        check = true;
                    }
                    if (check)
                    {
                        int temp = Int32.Parse(item.SubItems[2].Text) + Int32.Parse(txtSoLuong.Value.ToString());

                        item.SubItems[2].Text = temp.ToString();
                        item.SubItems[4].Text = (Int32.Parse(item.SubItems[2].Text) * Int32.Parse(item.SubItems[3].Text)).ToString();
                        break;
                    }
                }


                int gia = (Int32.Parse(lblGiaban.Text) - ((Int32.Parse(lblGiaban.Text) * Int32.Parse(lblPhantram.Text)) / 100)) * Int32.Parse(txtSoLuong.Value.ToString());

                int Giaban = Int32.Parse(lblGiaban.Text) - ((Int32.Parse(lblGiaban.Text) * Int32.Parse(lblPhantram.Text)) / 100);




                if (!check)
                {
                    string[] arr = new string[6];
                    arr[0] = lblMahh.Text.ToString();
                    arr[1] = cmbTenhh.Text;
                    arr[2] = txtSoLuong.Value.ToString();
                    arr[3] = Giaban.ToString();
                    arr[4] = gia.ToString();
                    arr[5] = lblPhantram.Text;
                    ListViewItem listViewItem = new ListViewItem(arr);
                    lvSanPhamBan.Items.Add(listViewItem);
                }
                 TienGiam = ((Int32.Parse(lblGiaban.Text) * Int32.Parse(lblPhantram.Text)) / 100) * Int32.Parse(txtSoLuong.Value.ToString());
                tiengiam += TienGiam;
                lblTiengiam.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tiengiam) + " đ";
                tongTien += gia;
                lblTongtien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tongTien) + " đ";
                lblTenbangchu.Text = ChuyenDoiTienBUS.Instance.So_chu(tongTien);
                Tinhtienhoantra();
                resetInfoProduct();

            }
            else
                MessageBox.Show("Số lượng phải lớn hơn 0, Hoặc bạn chưa chọn sản phẩm", "Thông báo");
        }




        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvSanPhamBan.Items.Count; i++) //duyệt tất cả các item trong list
            {
                if (lvSanPhamBan.Items[i].Checked)//nếu item đó dc check
                {
                    cmbTenhh.Text = lvSanPhamBan.Items[i].SubItems[1].Text.ToString();
                    Decimal b = Convert.ToDecimal(lvSanPhamBan.Items[i].SubItems[2].Text.ToString());
                    txtSoLuong.Value = b;
                    string tien = lvSanPhamBan.Items[i].SubItems[4].Text.ToString();
                    tongTien -= Int32.Parse(tien);
                    //int TienGiam = ((Int32.Parse(lblGiaban.Text) * Int32.Parse(lblPhantram.Text)) / 100) * Int32.Parse(txtSoLuong.Value.ToString());
                    tiengiam -= TienGiam;
                    lblTiengiam.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tiengiam) + " đ";
                    lblTongtien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tongTien) + " đ";
                    lblTenbangchu.Text = ChuyenDoiTienBUS.Instance.So_chu(tongTien);
                    lvSanPhamBan.Items[i].Remove();//xóa item đó đi
                    Tinhtienhoantra();
                    i--;
                    resetInfoProduct();
                    lblPhantram.Text = "0";
                }
                else if (lvSanPhamBan.Items.Count == 0)
                {
                    lblTiengiam.Text = "0 đ";
                }
            }
        }




        private void lvSanPhamBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvSanPhamBan.Items.Count; i++) //duyệt tất cả các item trong list
            {

                cmbTenhh.Text = lvSanPhamBan.Items[i].SubItems[1].Text.ToString();
                Decimal b = Convert.ToDecimal(lvSanPhamBan.Items[i].SubItems[2].Text.ToString());
                txtSoLuong.Value = b;
                lblPhantram.Text = lvSanPhamBan.Items[i].SubItems[5].Text.ToString();
                lblGiaban.Text = lvSanPhamBan.Items[i].SubItems[3].Text.ToString();

            }
        }



        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = KhachHangBUS.Intance.TimKiemDiemTL(txtTimkiem.Text);
            if(dt.Rows.Count > 0)
            {
                lblDiemTichLuy.Text = dt.Rows[0]["DiemTichLuy"].ToString();
                if(Int32.Parse(lblDiemTichLuy.Text) >= 50 && Int32.Parse(lblDiemTichLuy.Text) < 100)
                {
                    lblVoucher.Text = "5";
                }else if (Int32.Parse(lblDiemTichLuy.Text) > 100)
                {
                    lblVoucher.Text = "15";
                }else if(Int32.Parse(lblDiemTichLuy.Text) < 50)
                {
                    lblVoucher.Text = "0";
                }
            }

            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                List<KhachHangDTO> listKH = new List<KhachHangDTO>();
                khachHang = GetTenBySDT(txtTimkiem.Text);
                lblMaKH.Text = khachHang.MaKH;
                lblMaKH.ForeColor = Color.Black;
                lblTenkh.Text = khachHang.TenKH;
                lblTenkh.ForeColor = Color.Black;
                AutoCompleteStringCollection arrName2 = new AutoCompleteStringCollection();
                foreach (KhachHangDTO itemKH in listKH)
                {
                    arrName2.Add(itemKH.SDT);
                }
                txtTimkiem.AutoCompleteCustomSource = arrName2;
            }
            else
            {
                lblTenkh.Text = "Khách hàng mới";
                lblTenkh.ForeColor = Color.Black;
                lblVoucher.Text = "0";
                lblDiemTichLuy.Text = "0";
            }

        }

        private void txtTienkhachdua_TextChanged_1(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtTienkhachdua.Text))
            {
                Tinhtienhoantra();
            }
            else
            {
                lblFomart.Text = "0đ";
                lblTienhoantra.Text = "0đ";
            }
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimkiem.Text))
            {
                MessageBox.Show("Chưa có thông tin của khách hàng");
            }
            else if (string.IsNullOrEmpty(txtTienkhachdua.Text))
            {
                MessageBox.Show("Bạn chưa nhập tiền khách đưa");
            }
            else
             if (lvSanPhamBan.Items.Count > 0)
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.MaHD = lblMahd.Text;
                hd.MaKH = lblMaKH.Text;
                hd.NgayTao = dtpNgayban.Value;
                hd.MaNV = lblMaNV.Text;
                hd.TongTien = tongTien;




                if (LuuHD(hd))   // lưu hóa đơn
                {
                    //FormInHD formInHD = new FormInHD(lblMakh.Text);
                    foreach (ListViewItem item in lvSanPhamBan.Items)
                    {
                        LuuDH(hd.MaHD, item.SubItems[0].Text, Int32.Parse(item.SubItems[2].Text), Int32.Parse(item.SubItems[3].Text));  //lưu chi tiết hóa đơn
                        string query = "update MatHang set SoLuong = SoLuong - " + Int32.Parse(item.SubItems[2].Text) + "where MaMH = '" + item.SubItems[0].Text + "'";  // cập nhật lại số lượng 
                        DataProvider.Instance.ExecuteQuery(query);

                    }


                    DataTable dt = KhachHangBUS.Intance.TimKiemDiemTichLuy(lblMaKH.Text);
                    if (dt.Rows.Count > 0)
                    {
                        string Diem = dt.Rows[0]["DiemTichLuy"].ToString();
                        int diem = Int32.Parse(Diem);
                        if (diem >= 50 && diem < 100)
                        {
                            if (MessageBox.Show("Khách hàng có Voucher giảm giá 5% (mua hàng trên 5 lần), Khách hàng có muốn sử dụng", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                tiengiam = tiengiam + (tongTien * 5 / 100);
                                tongTien = tongTien - (tongTien * 5 / 100);
                                lblTiengiam.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tiengiam) + " VNĐ";
                                lblTongtien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tongTien) + " VNĐ";
                                string query = "update KhachHang set DiemTichLuy = DiemTichLuy - " + 50 + " where MaKH = '" + lblMaKH.Text + "'";  // cập nhật lại số lượng 
                                DataProvider.Instance.ExecuteQuery(query);
                                Tinhtienhoantra();
                                LamMoi();
                            }
                            else
                            {
                                string query = "update KhachHang set DiemTichLuy = DiemTichLuy + " + 10 + " where MaKH = '" + lblMaKH.Text + "'";  // cập nhật lại số lượng 
                                DataProvider.Instance.ExecuteQuery(query);
                                LamMoi();

                            }
                        }
                        else if (diem >= 100)
                        {
                            if (MessageBox.Show("Khách hàng có Voucher giảm giá 15% (mua hàng trên 10 lần), Khách hàng có muốn sử dụng", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                tiengiam = tiengiam + (tongTien * 15 / 100);
                                tongTien = tongTien - (tongTien * 15 / 100);
                                lblTiengiam.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tiengiam) + " VNĐ";
                                lblTongtien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tongTien) + " VNĐ";
                                string query = "update KhachHang set DiemTichLuy = DiemTichLuy - " + 100 + " where MaKH = '" + lblMaKH.Text + "'";  // cập nhật lại số lượng 
                                DataProvider.Instance.ExecuteQuery(query);
                                Tinhtienhoantra();
                                LamMoi();
                            }
                            else
                            {
                                string query = "update KhachHang set DiemTichLuy = DiemTichLuy + " + 10 + " where MaKH = '" + lblMaKH.Text + "'";  // cập nhật lại số lượng 
                                DataProvider.Instance.ExecuteQuery(query);
                                LamMoi();

                            }
                        }
                        else
                        {

                            string query = "update KhachHang set DiemTichLuy = DiemTichLuy + " + 10 + " where MaKH = '" + lblMaKH.Text + "'";  // cập nhật lại số lượng 
                            DataProvider.Instance.ExecuteQuery(query);
                            LamMoi();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa có sản phẩm để thanh toán");
                    }
                }
            }
        }



        private void UC_BanHang_Load(object sender, EventArgs e)
        {
        }

        private void cmbLoaihang_Click(object sender, EventArgs e)
        {
            list1 = LoaiHangBUS.Intance.getListLoaiHang();
            cmbLoaihang.DataSource = list1;
            cmbLoaihang.DisplayMember = "TenLH";
            cmbLoaihang.ValueMember = "MaLH";
        }

        private void LamMoi()
        {
            FormInHoaDon formInHoaDon = new FormInHoaDon(lblMahd.Text, Tienkhachduafomart, lblTienhoantra.Text, lblTiengiam.Text, lblTongtien.Text);
            formInHoaDon.Show();
            lvSanPhamBan.Items.Clear();
            lblTongtien.Text = "0 đ";
            lblTenbangchu.Text = "Không đồng";                                            // làm mới tất cả 
            lblTenkh.Text = ".";
            lblTenkh.Text = "UNKNOW NAME";
            tongTien = 0;
            lblMahd.Text = Matudong();
            resetInfoProduct();
            txtTimkiem.Text = "";
            txtTienkhachdua.Text = "";
            lblTiengiam.Text = "";
        }
    } */
    }
}



