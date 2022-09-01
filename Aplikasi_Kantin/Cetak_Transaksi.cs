using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace Aplikasi_Kantin
{
    public partial class Cetak_Transaksi : Form
    {
        private DataSet ds;
        private SqlDataAdapter da;

        SqlConnection Conn = new SqlConnection
            (@"Data Source = (local); initial catalog=Db19SA1208; integrated security=true");
        public Cetak_Transaksi()
        {
            InitializeComponent();
            cetak();
        }

        void cetak()
        {
            Conn.Open();
            da = new SqlDataAdapter("Select * from View_Laporan order by IdTransaksi asc",Conn);
            ds = new DataSet();
            da.Fill(ds, "View_laporan");
            report_Transaksi myreport = new report_Transaksi();
            myreport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myreport;
            crystalReportViewer1.Refresh();

        }

        private void Cetak_Transaksi_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }


    }
}
