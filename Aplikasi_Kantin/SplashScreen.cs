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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if(panel2.Width >= 599){
                timer1.Stop();
                Login Lgn = new Login();
                Lgn.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
