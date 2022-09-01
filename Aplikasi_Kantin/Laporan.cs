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
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;

namespace Aplikasi_Kantin
{
    public partial class Laporan : Form
    {
       
        SqlConnection Conn = new SqlConnection
            (@"Data Source = (local); initial catalog=Db19SA1208; integrated security=true");
        public Laporan()
        {
            
            InitializeComponent();
            //textCetak = Cetak;
        }
        DataTable dt = new DataTable();
        BindingSource bS = new BindingSource();
        private void bindingdata()
        {
            

            SqlDataAdapter da = new SqlDataAdapter("select idTransaksi as [Id Transaksi], tglTransaksi as [Tanggal], userId as [Petugas], nmMenu as [Nama Menu], idMenu [Id Menu], hrgbeli as [Harga Beli], hrgjual as [Harga Jual], idCustomer [Id Customer], jmljual as [Jumlah] from View_Laporan", Conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);

            da.Fill(dt);

            bS.DataSource = dt;
            dgvReport.DataSource = bS;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from View_Laporan";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "View_Laporan");
            dgvReport.DataSource = ds;
            dgvReport.DataMember = "View_Laporan";
            dgvReport.ReadOnly = true;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void showdataOmzet()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select sum ((hrgjual*jmljual)-(hrgbeli*jmljual)) as [Keuntungan] from View_Laporan";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "View_Laporan");
            dgvOmzet.DataSource = ds;
            dgvOmzet.DataMember = "View_Laporan";
            dgvOmzet.ReadOnly = true;
            dgvOmzet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void showdataHargaBeli()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select sum (hrgbeli*jmljual) as [Harga Beli] from View_Laporan";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "View_Laporan");
            dgvBeli.DataSource = ds;
            dgvBeli.DataMember = "View_Laporan";
            dgvBeli.ReadOnly = true;
            dgvBeli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void showdataHargaJual()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select sum (hrgjual*jmljual) as [Harga Jual] from View_Laporan";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "View_Laporan");
            dgvJual.DataSource = ds;
            dgvJual.DataMember = "View_Laporan";
            dgvJual.ReadOnly = true;
            dgvJual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Laporan_Load(object sender, EventArgs e)
        {
            showdata();
            showdataOmzet();
            showdataHargaBeli();
            showdataHargaJual();
            bindingdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cetak_Transaksi Cetak = new Cetak_Transaksi();
            Cetak.Show();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            bS.Filter = "[Petugas] like '%" + txtCari.Text + "%'";
        }

        private void btnCariTanggal_Click(object sender, EventArgs e)
        {
            bS.Filter = string.Format("[Tanggal] = '{0}'", DTPtanggal.Text);
        }

        private void DTPtanggal_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void dgvOmzet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
