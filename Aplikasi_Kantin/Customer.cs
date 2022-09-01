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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection
            (@"Data Source = (local); initial catalog=Db19SA1208; integrated security=true");
        DataTable dt = new DataTable();
        BindingSource bS = new BindingSource();

        private void bindingdata()
        {
            dt.Clear();

            txtIdCus.DataBindings.Clear();
            txtNmCus.DataBindings.Clear();
            txtAlmt.DataBindings.Clear();
            txtKota.DataBindings.Clear();
            txtTelp.DataBindings.Clear();


            SqlDataAdapter da = new SqlDataAdapter("select idCustomer as [Id Customer], nmCustomer as [Nama Customer], almtCustomer as [Alamat], kota as [Kota], hp as [Telp] from customer", Conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);

            da.Fill(dt);

            bS.DataSource = dt;
            dgvCustomer.DataSource = bS;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txtIdCus.DataBindings.Add("Text", bS, "Id Customer");
            txtNmCus.DataBindings.Add("Text", bS, "Nama Customer");
            txtAlmt.DataBindings.Add("Text", bS, "Alamat");
            txtKota.DataBindings.Add("Text", bS, "Alamat");
            txtTelp.DataBindings.Add("Text", bS, "Telp");
            
        }
        private void resetdata()
        {
            txtIdCus.Text = "";
            txtNmCus.Text = "";
            txtAlmt.Text = "";
            txtKota.Text = "";
            txtTelp.Text = "";
        }

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select idCustomer as [Id Customer], nmCustomer as [Nama Customer], almtCustomer as [Alamat], kota as [Kota], hp as [Telp] from customer";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "customer");
            dgvCustomer.DataSource = ds;
            dgvCustomer.DataMember = "customer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            showdata();
            
            bindingdata();
            resetdata();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtIdCus.Text.Trim() == "" | txtNmCus.Text.Trim() == "" | txtAlmt.Text.Trim() == "" | txtKota.Text.Trim() == "" | txtTelp.Text.Trim() == "" )
            {
                MessageBox.Show("Semua data menu harus diisi", "Peringatan");
                goto berhenti;
            }
        berhenti: ;
            Conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "ADDCUSTOMER";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter idCustomer = new SqlParameter("@id", SqlDbType.VarChar);
            SqlParameter nmCustomer = new SqlParameter("@nama", SqlDbType.VarChar);
            SqlParameter almtCustomer = new SqlParameter("@alamat", SqlDbType.VarChar);
            SqlParameter kota = new SqlParameter("@kota", SqlDbType.VarChar);
            SqlParameter hp = new SqlParameter("@tlp", SqlDbType.VarChar);

            idCustomer.Value = txtIdCus.Text;
            nmCustomer.Value = txtNmCus.Text;
            almtCustomer.Value = txtAlmt.Text;
            kota.Value = txtKota.Text;
            hp.Value = txtTelp.Text;

            cmd.Parameters.Add(idCustomer);
            cmd.Parameters.Add(nmCustomer);
            cmd.Parameters.Add(almtCustomer);
            cmd.Parameters.Add(kota);
            cmd.Parameters.Add(hp);

            cmd.ExecuteNonQuery();

            Conn.Close();
            showdata();
            resetdata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIdCus.Text.Trim() == "" )
            {
                MessageBox.Show("Id Customer harus diisi", "Peringatan");
                goto berhenti;
            }
        berhenti: ;

            Conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "DELCUSTOMER";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter idCustomer = new SqlParameter("@id", SqlDbType.VarChar);

            idCustomer.Value = txtIdCus.Text;
            cmd.Parameters.Add(idCustomer);
            cmd.ExecuteNonQuery();
            Conn.Close();
            showdata();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bindingdata();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetdata();
            showdata();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "ADDCUSTOMER";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter idCustomer = new SqlParameter("@id", SqlDbType.VarChar);
            SqlParameter nmCustomer = new SqlParameter("@nama", SqlDbType.VarChar);
            SqlParameter almtCustomer = new SqlParameter("@alamat", SqlDbType.VarChar);
            SqlParameter kota = new SqlParameter("@kota", SqlDbType.VarChar);
            SqlParameter hp = new SqlParameter("@tlp", SqlDbType.VarChar);

            idCustomer.Value = txtIdCus.Text;
            nmCustomer.Value = txtNmCus.Text;
            almtCustomer.Value = txtAlmt.Text;
            kota.Value = txtKota.Text;
            hp.Value = txtTelp.Text;

            cmd.Parameters.Add(idCustomer);
            cmd.Parameters.Add(nmCustomer);
            cmd.Parameters.Add(almtCustomer);
            cmd.Parameters.Add(kota);
            cmd.Parameters.Add(hp);

            cmd.ExecuteNonQuery();

            Conn.Close();
            showdata();
            resetdata();
        }

       

        private void btnCari_Click(object sender, EventArgs e)
        {
            bS.Filter = "[Nama Customer] like '%" + txtCari.Text + "%'";
            bindingdata();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

    }
}
