using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dealer
{
    public partial class frmConfirmarClave : Form
    {
        public frmConfirmarClave()
        {
            InitializeComponent();
        }

        public string pass { get; set; }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtConfirmar.Text == string.Empty)
            {
                MessageBox.Show("Clave vacia, Digite una valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pass = txtConfirmar.Text;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pass = null;
            this.Close();
        }
    }
}
