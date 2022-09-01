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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection
            (@"Data Source = (local); initial catalog=Db19SA1208; integrated security=true");

        private void Admin_Load(object sender, EventArgs e)
        {
            resetdata();
            showcombobox();
            showdata();
        }
        private void resetdata()
        {
            txtUser.Text = "";
            txtPass.Text = "";
            cbOtoritas.Text = "";
            txtNama.Text = "";
        }

        void showcombobox()
        {
            cbOtoritas.Items.Add("Supervisor");
        }

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from admin";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "admin");
            dgvAdmin.DataSource = ds;
            dgvAdmin.DataMember = "admin";
            dgvAdmin.ReadOnly = true;
            dgvAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == "" | txtPass.Text.Trim() == "" | txtNama.Text.Trim() == "" | cbOtoritas.Text.Trim() == "")
            {
                MessageBox.Show("Semua data harus terisi!");
                goto berhenti;
            }


            Conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into admin values ('" + txtUser.Text + "','" + txtPass.Text + "','" + cbOtoritas.Text + "','" + txtNama.Text + "')";
            cmd.ExecuteNonQuery();
            Conn.Close();
            showdata();
            resetdata();

        berhenti:
            ;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == "" | txtPass.Text.Trim() == "" | cbOtoritas.Text.Trim() == "")
            {
                MessageBox.Show("Semua data harus terisi!");
                goto berhenti;
            }


            Conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update admin set password='" + txtPass.Text + "' where userId='" + txtUser.Text + "'";
            cmd.ExecuteNonQuery();
            Conn.Close();
            showdata();
            resetdata();

        berhenti:
            ;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Isi User id yang akan dihapus");
                goto berhenti;
            }

            Conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from admin where userId = '" + txtUser.Text + "'";
            cmd.ExecuteNonQuery();
            Conn.Close();
            showdata();
            resetdata();

        berhenti:
            ;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        
    }
}
