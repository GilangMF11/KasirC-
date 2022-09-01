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
    public partial class MenuMakanan : Form
    {
        public MenuMakanan()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection
            (@"Data Source = (local); initial catalog=Db19SA1208; integrated security=true");
        private void MenuMakanancs_Load(object sender, EventArgs e)
        {
            comboshow();
            showdata();
            resetdata();
            
        }
        DataTable dt = new DataTable();
        BindingSource bS = new BindingSource();


        private void resetdata()
        {
            txtIdMenu.Text = "";
            txtNmMenu.Text = "";
            txtHrgBeli.Text = "";
            txtHrgJual.Text = "";
            txtStok.Text = "";
            cbSatuan.Text= "";
        }

        private void bindingdata()
        {
            dt.Clear();

            txtIdMenu.DataBindings.Clear();
            txtNmMenu.DataBindings.Clear();
            txtHrgBeli.DataBindings.Clear();
            txtHrgJual.DataBindings.Clear();
            cbSatuan.DataBindings.Clear();
            txtStok.DataBindings.Clear();

            SqlDataAdapter da = new SqlDataAdapter("select idMenu as [Id Menu], nmMenu as [Nama Menu], hrgbeli as [Harga Beli], hrgjual as [Harga Jual], satuan as [Satuan], stok as [Stok] from menu", Conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);

            da.Fill(dt);

            bS.DataSource = dt;
            dgvmenu.DataSource = bS;
            dgvmenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txtIdMenu.DataBindings.Add("Text", bS, "Id Menu");
            txtNmMenu.DataBindings.Add("Text", bS, "Nama Menu");
            txtHrgBeli.DataBindings.Add("Text", bS, "Harga Beli");
            txtHrgJual.DataBindings.Add("Text", bS, "Harga Jual");
            cbSatuan.DataBindings.Add("Text", bS, "Satuan");
            txtStok.DataBindings.Add("Text", bS, "Stok");
        }
        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select idMenu as [Id Menu], nmMenu as [Nama Menu], hrgbeli as [Harga Beli], hrgjual as [Harga Jual], satuan as [Satuan], stok as [Stok] from menu";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "menu");
            dgvmenu.DataSource = ds;
            dgvmenu.DataMember = "menu";
            dgvmenu.ReadOnly = true;
            dgvmenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void comboshow()
        {
            cbSatuan.Items.Add("PCS");
            cbSatuan.Items.Add("Porsi");
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtIdMenu.Text.Trim() == "" | txtNmMenu.Text.Trim() == "" | txtHrgBeli.Text.Trim() == "" | txtHrgJual.Text.Trim() == "" | txtStok.Text.Trim() == "" | cbSatuan.Text.Trim() == "")
            {
                MessageBox.Show("Semua data menu harus diisi", "Peringatan");
                goto berhenti;
            }

            int num,num1;
            bool isNum = int.TryParse(txtHrgBeli.Text.ToString(), out num);
            bool isNum1 = int.TryParse(txtHrgBeli.Text.ToString(), out num1);

            if (!isNum | !isNum1)
            {
                MessageBox.Show("Isi harga harus angka", "Peringatan");
                goto berhenti;
            }

            Conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into menu values ('" + txtIdMenu.Text + "','" + txtNmMenu.Text + "','" + txtHrgBeli.Text + "','" + int.Parse(txtHrgJual.Text) + "','" + cbSatuan.SelectedItem
                + "'," + txtStok.Text + ")";
            cmd.ExecuteNonQuery();
            Conn.Close();
            MessageBox.Show("data berhasil disimpan");
            resetdata();
            showdata();
            bindingdata();

        berhenti:
            ;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtIdMenu.Text.Trim() == "" | txtNmMenu.Text.Trim() == "" | txtHrgBeli.Text.Trim() == "" | txtHrgJual.Text.Trim() == "" | txtStok.Text.Trim() == "" | cbSatuan.Text.Trim() == "")
            {
                MessageBox.Show("Semua data menu harus diisi", "Peringatan");
                goto berhenti;
            }

            int num, num1;
            bool isNum = int.TryParse(txtHrgBeli.Text.ToString(), out num);
            bool isNum1 = int.TryParse(txtHrgBeli.Text.ToString(), out num1);

            if (!isNum | !isNum1)
            {
                MessageBox.Show("Isi harga harus angka", "Peringatan");
                goto berhenti;
            }

            Conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update menu set nmMenu='" + txtNmMenu.Text + "', hrgbeli='" + txtHrgBeli.Text + "', hrgjual='" + txtHrgJual.Text + "', satuan='" + cbSatuan.SelectedItem
                + "', stok='" + txtStok.Text + "' where idMenu='"+ txtIdMenu.Text + "'";
            cmd.ExecuteNonQuery();
            Conn.Close();
            MessageBox.Show("data berhasil disimpan");
            resetdata();
            showdata();
            bindingdata();

        berhenti:
            ;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            resetdata();
            showdata();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIdMenu.Text == "")
            {
                MessageBox.Show("Isi id Menu yang akan dihapus");
                goto berhenti;
            }

            Conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from menu where idMenu='" + txtIdMenu.Text + "'";
            cmd.ExecuteNonQuery();
            Conn.Close();
            showdata();
            resetdata();
            bindingdata();
        berhenti:
            ;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            bS.Filter = "[Nama Menu] like '%" + txtCari.Text + "%'";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static bool MAXIMIZED = false;
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (MAXIMIZED)
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

        private void txtCari_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgvmenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bindingdata();
        }

        

    }
}
