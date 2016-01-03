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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtIDUsuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(Usuario.ImagenUsr(txtIDUsuario.Text));
            }
            catch
            {

            }
        }
        private void Limpiar()
        {
            txtClave.Clear();
            txtIDUsuario.Clear();
            txtIDUsuario.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtIDUsuario.Text == string.Empty)
            {
                MessageBox.Show("ID Usuario vacio, Digite uno valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDUsuario.Focus();
            }
            else if (txtClave.Text == string.Empty)
            {
                MessageBox.Show("Clave vacia, Digite una valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
            }
            else
            {
                Usuario u = new Usuario();
                u.ID_Usuario = txtIDUsuario.Text;
                string clave = txtClave.Text;
                try
                {
                    if (Usuario.Login(u, clave))
                    {
                        frmMenuPrincipal m = new frmMenuPrincipal();
                        m.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Clave incorrectos, Digitelos Nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }
            }
        }

        private void txtIDUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtClave.Focus();
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtIDUsuario.Text == string.Empty)
                {
                    MessageBox.Show("ID Usuario vacio, Digite uno valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIDUsuario.Focus();
                }
                else if (txtClave.Text == string.Empty)
                {
                    MessageBox.Show("Clave vacia, Digite una valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClave.Focus();
                }
                else
                {
                    Usuario u = new Usuario();
                    u.ID_Usuario = txtIDUsuario.Text;
                    string clave = txtClave.Text;
                    try
                    {
                        if (Usuario.Login(u, clave))
                        {
                            frmMenuPrincipal m = new frmMenuPrincipal();
                            m.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Clave incorrectos, Digitelos Nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Limpiar();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Limpiar();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
