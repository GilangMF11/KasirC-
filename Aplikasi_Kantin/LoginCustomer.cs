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
    public partial class LoginCustomer : Form
    {
        public LoginCustomer()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection
            (@"Data Source = (local); initial catalog=Db19SA1208; integrated security=true");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "" || txtId.Text == "")
            {
                MessageBox.Show("semua data harap diisi");
                goto berhenti;
            }
            Conn.Close();
            SqlCommand cmd = new SqlCommand("select * from customer where nmCustomer = '" + txtNama.Text + "' and idCustomer = '" + txtId.Text + "'", Conn);
            Conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                MessageBox.Show("Anda Berhasil Login!", "Login");
                Close();
            }
            else
            {
                MessageBox.Show("User id atau password tidak valid", "Peringatan");
                txtNama.Text = "";
                txtId.Text = "";
                txtNama.Focus();
            }

        berhenti: ;
        }
    }
}
