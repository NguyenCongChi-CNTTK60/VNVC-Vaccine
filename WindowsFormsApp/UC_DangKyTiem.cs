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

            this.manv = manv;
            this.tennv = tennv;
            lblMaNV.Text = manv;
            lblTenNV.Text = tennv;

            DateTime today = DateTime.Now;
            dtpNgayban.Value = new DateTime(today.Year, today.Month, today.Day);

            list = MatHangBUS.Intance.getListSanPham();
            cmbTenVaccine.DataSource = list;
            cmbTenVaccine.DisplayMember = "TenVX";
            cmbTenVaccine.ValueMember = "MaVX";


            cmbTenGoiTiem.SelectedIndex = 0;
            cmbTenVaccine.SelectedIndex = -1;
            cmbLoaiVX.SelectedIndex = 0;
            txtSoLuong.Value = 0;
            lblGiaban.Text = "0đ";
            lblMahd.Text = Matudong();
        }

        List<LoaiHangDTO> list2;

        private void cmbLoaiHang_Click(object sender, EventArgs e)
        {
            list2 = LoaiHangBUS.Intance.getListLoaiHang();
            cmbLoaiVX.DataSource = list2;
            cmbLoaiVX.DisplayMember = "TenLoai";
            cmbLoaiVX.ValueMember = "MaLoai";
        }

        List<MatHangDTO> list;

        private void cmbLoaiVX_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select MaLoai from LoaiVacXin where TenLoai = N'" + cmbLoaiVX.Text + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);


            if (dt.Rows.Count > 0)
            {
                string a = dt.Rows[0]["MaLoai"].ToString();
                DataTable dt1 = LoaiHangBUS.Intance.TimKiemTenVaccine(a);
                if (dt1.Rows.Count > 0)
                {
                    cmbTenVaccine.DataSource = dt1;

                }
            }
        }

      
        List<GoiTiemDTO> list1;

        private void cmbTenGoiTiem_Click(object sender, EventArgs e)
        {
            list1 = GoiTiemBUS.Intance.getListGoitiem();
            cmbTenGoiTiem.DataSource = list1;
            cmbTenGoiTiem.DisplayMember = "TenGT";
            cmbTenGoiTiem.ValueMember = "MaGT";
        }

        private void cmbTenVaccine_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = GoiTiemBUS.Intance.TimKiemMaVX(cmbTenVaccine.Text);
           // DataTable dt1 = GoiTiemBUS.Intance.TimKiemGiaBan(cmbTenVaccine.Text);
            if (dt.Rows.Count > 0)
            {
                //i = cmbTenVaccine.SelectedIndex;
                lblMaVX.Text = dt.Rows[0]["MaVX"].ToString();
                lblMaVX.ForeColor = Color.Black;
                DataTable dt1 = GoiTiemBUS.Intance.TimKiemGiaBan(lblMaVX.Text);
                if (dt1.Rows.Count > 0)
                {
                    lblGiaban.Text = dt1.Rows[0]["DonGia"].ToString();
                }
            }
        }


        int tongTien;
        int temp;
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (cmbTenGoiTiem.Text != "----- Chọn gói tiêm -----" || string.IsNullOrEmpty(cmbTenGoiTiem.Text))
            {
                string query = "select MaGT from GoiTiem where TenGT = N'" + cmbTenGoiTiem.Text + "'";
                DataTable dt = DataProvider.Instance.ExecuteQuery(query);


                if (dt.Rows.Count > 0)
                {
                    string a = dt.Rows[0]["MaGT"].ToString();
                    DataTable dt1 = LoaiHangBUS.Intance.TimKiemTenVaccine1(a);
                    string query1 = "UC_TongTien '" + a + "'";
                    DataTable dt2 = DataProvider.Instance.ExecuteQuery(query1);
                    if (dt1.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {
                            string[] arr = new string[6];
                            arr[0] = dt1.Rows[i]["MaVX"].ToString();
                            arr[1] = dt1.Rows[i]["TenVX"].ToString();
                            arr[2] = dt1.Rows[i]["SoLieu"].ToString();
                            arr[3] = dt1.Rows[i]["GiaBan"].ToString();
                            arr[4] = dt1.Rows[i]["ThanhTien"].ToString();
                            // arr[5] = //lblPhantram.Text;
                            ListViewItem listViewItem = new ListViewItem(arr);
                            lvSanPhamBan.Items.Add(listViewItem);
                            if (dt2.Rows.Count > 0)
                            {
                                 temp = Int32.Parse(dt2.Rows[0]["ThanhTien"].ToString());
                                lblTienbangso.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##00}", temp) + " đ";
                            }
                            cmbTenGoiTiem.SelectedIndex = -1;
                            txtSoLuong.Value = 0;
                            Tinhtienhoantra();
                        }

                    }

                }
            }




            if (txtSoLuong.Value > 0)
            {
                bool check = false;
                foreach (ListViewItem item in lvSanPhamBan.Items)
                {
                    if (item.SubItems[0].Text == lblMaVX.Text)
                    {
                        check = true;
                    }
                    if (check)
                    {
                        int temp = Int32.Parse(item.SubItems[2].Text) + Int32.Parse(txtSoLuong.Value.ToString());
                        item.SubItems[2].Text = temp.ToString();
                        item.SubItems[4].Text = (Int32.Parse(item.SubItems[2].Text) * Int32.Parse(lblGiaban.Text)).ToString();
                        break;
                    }
                }


                int gia = Int32.Parse(lblGiaban.Text) * Int32.Parse(txtSoLuong.Value.ToString());
                if (!check)
                {
                    string[] arr = new string[5];
                    arr[0] = lblMaVX.Text;
                    arr[1] = cmbTenVaccine.Text;
                    arr[2] = txtSoLuong.Value.ToString();
                    arr[3] = lblGiaban.Text;
                    arr[4] = gia.ToString();
                    ListViewItem listViewItem = new ListViewItem(arr);
                    lvSanPhamBan.Items.Add(listViewItem);
                }
                tongTien += gia;
                lblTienbangso.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##00}", tongTien) + " đ";
                txtSoLuong.Value = 0;
                Tinhtienhoantra();
                //lblGiaban.Text = "0đ";

                //Tinhtienhoantra();
                // resetInfoProduct();

            }
            else
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo");

        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvSanPhamBan.Items.Count; i++) //duyệt tất cả các item trong list
            {
                if (lvSanPhamBan.Items[i].Checked)//nếu item đó dc check
                {
                    string tien = lvSanPhamBan.Items[i].SubItems[4].Text.ToString();
                    tongTien -= Int32.Parse(tien);
                    lblTienbangso.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##00}", tongTien) + " đ";
                    lvSanPhamBan.Items[i].Remove();//xóa item đó đi
                    
                    Tinhtienhoantra();
                    i--;

                }
            }
        }

        private void txtTimkiem_TextChanged_1(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtTimkiem.Text))
            {
                string id = txtTimkiem.Text;
                string query = "select * from KhachHang where SDT ='" + id + "'";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                if (data.Rows.Count > 0)
                {
                    lblMaKH.Text = data.Rows[0]["MaKH"].ToString();
                    lblTenkh.Text = data.Rows[0]["TenKH"].ToString();
                }
                else
                {
                    lblTenkh.Text = "Khách hàng mới";
                    lblMaKH.Text = "KH00";
                }
            }
        }


        private void Tinhtienhoantra()
        {
            if (!string.IsNullOrEmpty(txtTienkhachdua.Text))
            {
                int tienkhachdua = Int32.Parse(txtTienkhachdua.Text);
                int tienhoantra = tienkhachdua - tongTien;
                lblTienHoanTra.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tienhoantra) + " đ";
                lblTienKhachDua.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tienkhachdua) + " đ";
            }
            else
                lblTienHoanTra.Text = "0đ";
        }


        private void TinhtienhoantraGoiTiem()
        {
            if (!string.IsNullOrEmpty(txtTienkhachdua.Text))
            {
                int tienkhachdua = Int32.Parse(txtTienkhachdua.Text);
                int tienhoantra = tienkhachdua - temp;
                lblTienHoanTra.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tienhoantra) + " đ";
                lblTienKhachDua.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tienkhachdua) + " đ";
            }
            else
                lblTienHoanTra.Text = "0đ";
        }

        private void txtTienkhachdua_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbTenGoiTiem.Text))
            {
                TinhtienhoantraGoiTiem();
            }else

                Tinhtienhoantra();
        }


        //
        // Tạo mã hóa đơn tự động
        // chí

        private string Matudong()
            {
                string query = "select MaHD from ChiTietDKTiem";
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
                    k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                    //k = dt.Rows.Count;
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
                    ma = ma + "";
                }
                    ma = ma + k.ToString();

                }
                return ma;
            }

       
        }
    }




