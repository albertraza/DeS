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
using Dealer.Properties;

namespace Dealer
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int r = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            r++;

            progressBar1.Value = r;

            lblProgreso.Text = r.ToString() + "%";

            if (r == 100)
            {
                timer1.Stop();
                try
                {
                    SqlConnection con = ConnectionDB.conectar();
                    frmLogin l = new frmLogin();
                    l.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }

        }
    }
}
