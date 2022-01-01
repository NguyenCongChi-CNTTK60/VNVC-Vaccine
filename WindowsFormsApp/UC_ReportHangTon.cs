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

namespace WindowsFormsApp
{
    public partial class UC_ReportHangTon : UserControl
    {

        
        public UC_ReportHangTon()
        {
            InitializeComponent();
           // Load();
            
            
        }

        private void Load()
        {
            Chuoiketnoi chuoiketnoi = new Chuoiketnoi();

            SqlConnection con = chuoiketnoi.sqlConnection();
            con.Open();
            string query = "select * from MatHang";
            string query1 = "select VacXin.MaVX,VacXin.TenVX ,sum(ChitietPN.Soluong) as [SLNhap],VacXin.SoLuong as [SoLuong], (sum(ChitietPN.Soluong) - VacXin.SoLuong) as [SLBan],VacXin.GiaBan from VacXin inner join ChiTietPN on VacXin.MaVX = ChiTietPN.MaVX group by VacXin.MaVX,VacXin.TenVX,VacXin.SoLuong,VacXin.GiaBan ";
            SqlDataAdapter dta = new SqlDataAdapter(query1, con);
            DataSet1 dataSet1 = new DataSet1();
            dta.Fill(dataSet1, "DataTable3");
            ReportDataSource dataSource = new ReportDataSource("DataSet1", dataSet1.Tables["DataTable3"]);
            con.Close();
           
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.SetDisplayMode(DisplayMode.Normal);
        }



        private void addUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            UC_ThongKeHangHoa f = new UC_ThongKeHangHoa();
            addUC(f);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           Load();
        }
    }
}
