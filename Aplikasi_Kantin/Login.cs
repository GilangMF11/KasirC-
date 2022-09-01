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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUser.Focus();
            
        }
        SqlConnection Conn = new SqlConnection
            (@"Data Source = (local); initial catalog=Db19SA1208; integrated security=true");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("semua data harap diisi");
                goto berhenti;
            }
            Conn.Close();
            SqlCommand cmd = new SqlCommand("select * from admin where userId = '" + txtUser.Text + "' and password = '" + txtPass.Text+"'", Conn);
            Conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                MessageBox.Show("Anda Berhasil Login!", "Login");
                MenuUtama main = new MenuUtama();
                main.Show();
                this.Hide();
                Close();
            }
            else
            {
                MessageBox.Show("User id atau password tidak valid", "Peringatan");
                txtUser.Text = "";
                txtPass.Text = "";
                txtUser.Focus();
            }
            
        berhenti: ;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
