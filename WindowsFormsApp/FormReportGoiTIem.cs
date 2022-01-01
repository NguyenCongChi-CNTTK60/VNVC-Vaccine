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
    public partial class FormReportGoiTIem : Form
    {

        private string magt;
        public FormReportGoiTIem(string magt)
        {
            InitializeComponent();
            this.magt = magt;
        }


        Chuoiketnoi chuoiketnoi = new Chuoiketnoi();
        private void FormReportGoiTIem_Load(object sender, EventArgs e)
        {
            SqlConnection con = chuoiketnoi.sqlConnection();
            con.Open();
            string query = "UC_ChitietGT'" + magt+ "'";
            SqlDataAdapter dta = new SqlDataAdapter(query, con);
            DataSet1 dataSet1 = new DataSet1();
            dta.Fill(dataSet1, "DataTable4");
            ReportDataSource dataSource = new ReportDataSource("DataSet1", dataSet1.Tables["DataTable4"]);
            con.Close();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
