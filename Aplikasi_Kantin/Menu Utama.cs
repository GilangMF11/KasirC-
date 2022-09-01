using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Kantin
{
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void btnClose_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            lblSelected.Visible = false;
            lblSelected1.Visible = false;
            lblSelected2.Visible = false;
            lblSelected3.Visible = false;
            lblSelected4.Visible = true;
            lblSelected5.Visible = false;
            MessageBox.Show("Versi 1.1.0", "Tentang Kantin Amikom");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            lblSelected.Visible = false;
            lblSelected1.Visible = false;
            lblSelected2.Visible = false;
            lblSelected3.Visible = false;
            lblSelected4.Visible = false;
            lblSelected5.Visible = true;
            DialogResult dr = MessageBox.Show("Anda Ingin LogOut?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Close();
                Login LgnUser = new Login();
                
                LgnUser.Show();
            }
            
        }

        private void btnDataMaster_Click(object sender, EventArgs e)
        {
            lblSelected.Visible = true;
            lblSelected1.Visible = false;
            lblSelected2.Visible = false;
            lblSelected3.Visible = false;
            lblSelected4.Visible = false;
            lblSelected5.Visible = false;
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            lblSelected.Visible = false;
            lblSelected1.Visible = true;
            lblSelected2.Visible = false;
            lblSelected3.Visible = false;
            lblSelected4.Visible = false;
            lblSelected5.Visible = false;

            Transaksi trans = new Transaksi();
            trans.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            
            lblSelected.Visible = false;
            lblSelected1.Visible = false;
            lblSelected2.Visible = true;
            lblSelected3.Visible = false;
            lblSelected4.Visible = false;
            lblSelected5.Visible = false;
            
            MenuMakanan mnMakan = new MenuMakanan();
            mnMakan.Show();
            
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            lblSelected.Visible = false;
            lblSelected1.Visible = false;
            lblSelected2.Visible = false;
            lblSelected3.Visible = true;
            lblSelected4.Visible = false;
            lblSelected5.Visible = false;

            Laporan Lap = new Laporan();
            Lap.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            adm.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus.Show();
        }

        
        }
    }

