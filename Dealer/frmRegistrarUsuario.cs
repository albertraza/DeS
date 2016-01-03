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
    public partial class frmRegistrarUsuario : Form
    {
        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void frmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
                txtDestino.Enabled = false;
                txtUbicacion.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            txtClave.Clear();
            txtDestino.Clear();
            txtIDUsuario.Clear();
            txtUbicacion.Clear();
            txtIDUsuario.Focus();
            pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
        }
        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfld = new OpenFileDialog();
            openfld.ShowDialog();
            
            if (!Directory.Exists(@"C:\FactoriadeProyectos\Dealer\img\log\usr"))
            {
                Directory.CreateDirectory(@"C:\FactoriadeProyectos\Dealer\img\log\usr");
            }
            string destino = @"C:\FactoriadeProyectos\Dealer\img\log\usr\" + Path.GetFileName(openfld.FileName);
            try
            {
                pbImagen.Image = Image.FromFile(openfld.FileName);

                txtUbicacion.Text = openfld.FileName.ToString();
                txtDestino.Text = destino;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text != string.Empty && txtUbicacion.Text != string.Empty) { File.Copy(txtUbicacion.Text, txtDestino.Text, true); } else { MessageBox.Show("No hay Fotografia seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            Usuario u = new Usuario();
            if (txtClave.Text == string.Empty)
            {
                MessageBox.Show("Clave vacia, Digite una valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
            }
            else if (txtIDUsuario.Text == string.Empty)
            {
                MessageBox.Show("ID Usuario vacio, Digite uno valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDUsuario.Focus();
            }
            else
            {
                string clave;
                frmConfirmarClave cc = new frmConfirmarClave();
                cc.ShowDialog();
                clave = cc.pass;
                if (txtClave.Text != clave)
                {
                    MessageBox.Show("Las claves son diferentes, digitela nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtClave.Clear();
                    txtClave.Focus();
                }
                else if (clave == null)
                {
                    MessageBox.Show("Confirmacion de clave no realizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClave.Clear();
                    txtClave.Focus();
                }
                else
                {
                    u.ID_Usuario = txtIDUsuario.Text;
                    try
                    {

                        int r = Usuario.Registrar(txtIDUsuario.Text, txtDestino.Text, clave);

                        if (r > 0)
                        {
                            MessageBox.Show("Registrado Exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
