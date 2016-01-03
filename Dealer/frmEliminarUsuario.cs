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
    public partial class frmEliminarUsuario : Form
    {
        private void Limpiar()
        {
            txtCodigo.Clear();
            txtIDUsuario.Clear();
            txtCodigo.Focus();
            lblBuscar.Enabled = true;
            btnEliminar.Enabled = false;
            pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
        }
        public frmEliminarUsuario()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int r = Usuario.Eliminar(txtCodigo.Text);
                if (r > 0)
                {
                    MessageBox.Show("Eliminado Exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo Eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string IDu  = null;
        public string codigo
        {
            get { return IDu; }
            set { IDu = value; }
        }
        private void frmEliminarUsuario_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = null;
            txtCodigo.Text = IDu;
            try
            {
                if (txtCodigo.Text != null)
                {
                    Usuario u = Usuario.getUsuario(txtCodigo.Text);
                    txtIDUsuario.Text = u.ID_Usuario;
                    pbImagen.Image = Image.FromFile(Usuario.ImagenUsrCod(txtCodigo.Text));
                    lblBuscar.Enabled = false;
                }
                else
                {
                    pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
                    txtIDUsuario.Enabled = false;
                    btnEliminar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Usuario U = new Usuario();
        private void lblBuscar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Codigo vacio, Digite uno valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
            }
            else
            {
                try
                {
                    U = Usuario.getUsuario(txtCodigo.Text);
                    if (U != null)
                    {
                        txtIDUsuario.Text = U.ID_Usuario;
                        btnEliminar.Enabled = true;
                        lblBuscar.Enabled = false;
                        pbImagen.Image = Image.FromFile(Usuario.ImagenUsrCod(txtCodigo.Text));
                    }
                    else
                    {
                        MessageBox.Show("No Existe el Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigo.Clear();
                        txtCodigo.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
