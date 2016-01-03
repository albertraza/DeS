using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dealer
{
    public partial class frmModificarUsuario : Form
    {
        private void Limpiar()
        {
            txtClave.Clear();
            txtCodigo.Clear();
            txtIDUsuario.Clear();
            txtCodigo.Focus();
            btnCambiarImagen.Enabled = false;
            btnGuardar.Enabled = false;
            lblBuscar.Enabled = true;
            pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
        }
        public frmModificarUsuario()
        {
            InitializeComponent();
        }

        Usuario u = new Usuario();
        string imagen = null, dimagen = null, uimagen = null;
        private void lblBuscar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            u = Usuario.getUsuario(txtCodigo.Text);
            if (u == null)
            {
                MessageBox.Show("No existe el Usuario, Digite un codigo velido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Clear();
                txtCodigo.Focus();
            }
            else
            {
                txtIDUsuario.Text = u.ID_Usuario;
                dimagen = Usuario.ImagenUsrCod(txtCodigo.Text);
                lblBuscar.Enabled = false;
                btnGuardar.Enabled = true;
                btnCambiarImagen.Enabled = true;
                try
                {
                    pbImagen.Image = Image.FromFile(Usuario.ImagenUsrCod(txtCodigo.Text));
                    imagen = Usuario.ImagenUsrCod(txtCodigo.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Metodo para pasar valores desde el form 1 hasta el form 2
        /// </summary>
        private string IDu;
        public string codigo
        {
            get { return IDu; }
            set { IDu = value; }
        }
        /// <summary>
        /// Fin meotodo de pasar valores desde el form 1 al form 2
        /// </summary>
        private void frmModificarUsuario_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = IDu;
            try
            {
                if (txtCodigo.Text != string.Empty)
                {
                    Usuario u = Usuario.getUsuario(txtCodigo.Text);
                    txtIDUsuario.Text = u.ID_Usuario;
                    pbImagen.Image = Image.FromFile(Usuario.ImagenUsrCod(txtCodigo.Text));
                    dimagen = Usuario.ImagenUsrCod(txtCodigo.Text);
                    btnGuardar.Enabled = true;
                    btnCambiarImagen.Enabled = true;
                    txtCodigo.Enabled = false;
                    lblBuscar.Enabled = false;
                }
                else
                {
                    pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
                    btnGuardar.Enabled = false;
                    btnCambiarImagen.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfld = new OpenFileDialog();
                openfld.ShowDialog();
                string destino = @"C:\FactoriadeProyectos\Dealer\img\log\usr\" + Path.GetFileName(openfld.FileName);
                pbImagen.Image = Image.FromFile(openfld.FileName);
                dimagen = destino;
                uimagen = openfld.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == string.Empty)
            {
                MessageBox.Show("Clave esta vacia, digite una valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
            }
            else if (txtIDUsuario.Text == string.Empty)
            {
                MessageBox.Show("ID Usuario esta vacio, digite un ID valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDUsuario.Focus();
            }
            else
            {
                frmConfirmarClave cc = new frmConfirmarClave();
                cc.ShowDialog();
                string pass = cc.pass;
                if (pass == null)
                {
                    MessageBox.Show("Las Clave esta vacia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClave.Clear();
                    txtClave.Focus();
                }
                else if (txtClave.Text != pass)
                {
                    MessageBox.Show("Las Claves son diferentes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClave.Clear();
                    txtClave.Focus();
                }
                else
                {
                    try
                    {
                        int r = Usuario.Actualizar(txtIDUsuario.Text, dimagen, txtClave.Text, txtCodigo.Text);
                        if (r > 0)
                        {
                            MessageBox.Show("Modificado Exitosamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
