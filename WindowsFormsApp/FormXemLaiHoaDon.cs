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
    public partial class FormXemLaiHoaDon : Form
    {

        private string mahd;
        public FormXemLaiHoaDon(string mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
        }

        private void FormXemLaiHoaDon_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            HienThi();
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
          
           
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
