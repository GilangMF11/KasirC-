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

namespace Aplikasi_Kantin
{
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection
            (@"Data Source = (local); initial catalog=Db19SA1208; integrated security=true");
        DataTable dt = new DataTable();
        BindingSource bS = new BindingSource();
        
        private string notrans
        {
            get
            {
                Conn.Open();
                string nomor = "TR-001";
                SqlCommand cmd = new SqlCommand("select max(right(idTransaksi,4)) from transaksi", Conn);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (rd[0].ToString() != "")
                    nomor = "TR-" + (int.Parse(rd[0].ToString()) + 1).ToString("0000");
                rd.Close();
                return nomor;
            }
        }

        private void isiCombo()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select nmMenu from menu";
            DataSet ds1 = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds1, "menu");
            cbMenu.DataSource = ds1.Tables["menu"];
            cbMenu.DisplayMember = "nmMenu";
        }
        
        private void resetdata()
        {
            //txtIdTrans.Text = "";
            DTPtanggal.Text = "";
            txtIdCus.Text = "";
            txtPetugas.Text = "";
            txtjml.Text = "";
        }

       
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static bool MAXIMIZED = false;
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(MAXIMIZED)
            {
                WindowState = FormWindowState.Normal;
                MAXIMIZED = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                MAXIMIZED = true;
            }
         }

        
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            
            WindowState = FormWindowState.Minimized;

        }

  

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtjml.Text == "" |txtPetugas.Text == "" |txtIdCus.Text == "")
            {
                MessageBox.Show("Pastikan Semua Data Terisi", "Peringatan");
                goto berhenti;
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "insert into transaksi values ('" + txtIdTrans.Text + "','" + this.DTPtanggal.Text + "','" + txtIdCus.Text +"','" + txtPetugas.Text + "','" + txtHargaBeli.Text +  "')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = Conn;
            cmd2.CommandText = "insert into detailTransaksi values('" + txtIdTrans.Text + "','" + txtIdMenu.Text + "','" + txtHargaBeli.Text + "','" + txtHargaJual.Text + "','" + txtjml.Text + "')";
            cmd2.CommandType = CommandType.Text;
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Data Tersimpan", "Pemberitauan");
            resetdata();
            txtIdCus.Focus();

        berhenti:
            ;
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            txtIdTrans.Text = notrans;
            resetdata();
            isiCombo();
        }

        
        

        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conn.Close();
            SqlCommand cmd = new SqlCommand("select * from menu where nmMenu='" + cbMenu.Text + "'", Conn);
            Conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txtIdMenu.Text = rd[0].ToString();
                txtHargaBeli.Text = rd[2].ToString();
                txtHargaJual.Text = rd[3].ToString();
                rd.Close();
            }

        }

        private void txtjml_TextChanged(object sender, EventArgs e)
        {
            double jml, harga,total = 0;
            jml = double.Parse(txtjml.Text);
            harga = double.Parse(txtHargaJual.Text);
            total = jml * harga;
            txtTotal.Text = "Rp. " + total.ToString();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIdMenu.Text == "")
            {
                MessageBox.Show("Isi id Transaksi yang akan dihapus");
                goto berhenti;
            }
            Conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from menu where idTransaksi='" + txtIdTrans.Text + "'";
            cmd.ExecuteNonQuery();
            Conn.Close();
            resetdata();
           
            MessageBox.Show("Data Berhasil Dihapus");
        berhenti: ;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}
