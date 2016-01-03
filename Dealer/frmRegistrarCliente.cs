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
    public partial class frmRegistrarCliente : Form
    {
        private void LimpiarCampos()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtNombre.Focus();
            pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
        }
        public frmRegistrarCliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistrarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();

            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Nombre vacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
            }
            else if (txtApellido.Text == string.Empty)
            {
                MessageBox.Show("Apellido vacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
            }
            else if (txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("Telefono vacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
            }
            else
            {
                c.nombre = txtNombre.Text;
                c.apellido = txtApellido.Text;
                c.telefono = txtTelefono.Text;

                try
                {
                    int r = Clientes.Registrar(c);
                    if (r > 0)
                    {
                        MessageBox.Show("Registrado con Exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
