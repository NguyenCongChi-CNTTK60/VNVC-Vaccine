using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace WindowsFormsApp
{
    public partial class FormInHoaDon : Form
    {
        private string mahd;
        private string Tienkhachdua;
        private string Tienhoantra;
        private string TienBangChu;
        private string TongTien;

        public FormInHoaDon(string mahd, string Tienkhachdua, string Tienhoantra, string TienBangChu, string TongTien)  //string mahd, string Tienkhachdua, string Tienhoantra, string Tiendagiam, string TongTien
        {
            InitializeComponent();
            this.mahd = mahd;
            this.Tienkhachdua = Tienkhachdua;
            this.Tienhoantra = Tienhoantra;
            this.TienBangChu = TienBangChu;
            this.TongTien = TongTien;
        }


        Chuoiketnoi chuoiketnoi = new Chuoiketnoi();
       

        private void HienThi()
        {
            SqlConnection con = chuoiketnoi.sqlConnection();
            con.Open();
            string query = "USP_Inhoadonn'" + mahd + "'";
            SqlDataAdapter dta = new SqlDataAdapter(query, con);
            DataSet1 dataSet1 = new DataSet1();
            dta.Fill(dataSet1, "DataTable2");
            ReportDataSource dataSource = new ReportDataSource("DataSet1", dataSet1.Tables[1]);
            con.Close();
            ReportParameter[] rptParams = new ReportParameter[]
           {
                new ReportParameter("Tienkhachdua", Tienkhachdua),
                new ReportParameter("Tienhoantra", Tienhoantra),
                new ReportParameter("TongTien", TongTien),
                new ReportParameter("TienBangChu", TienBangChu)
           };
            this.reportViewer1.LocalReport.SetParameters(rptParams);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void FormInHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
