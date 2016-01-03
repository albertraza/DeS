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
    public partial class frmRegistrarSuplidores : Form
    {
        private void LimpiarCampos()
        {
            txtDescripcion.Clear();
            txtDireccion.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtNombre.Focus();
            pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
        }
        public frmRegistrarSuplidores()
        {
            InitializeComponent();
        }
        string uimagen, dimagen;
        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfld = new OpenFileDialog();
            openfld.ShowDialog();
            try
            {
                uimagen = openfld.FileName;
                pbImagen.Image = Image.FromFile(uimagen);
                dimagen = @"C:\FactoriadeProyectos\Dealer\img\log\sup\" + Path.GetFileName(uimagen);
                File.Copy(uimagen, dimagen, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Suplidores s = new Suplidores();
            if (txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Descripcion esta vacia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
            }

            else if (txtDireccion.Text == string.Empty)
            {
                MessageBox.Show("Direccion esta vacia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccion.Focus();
            }
            else if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("El Nombre del suplidor esta vacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
            }
            else if (txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("El telefono esta vacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
            }
            else
            {
                s.descripcion = txtDescripcion.Text;
                s.direccion = txtDireccion.Text;
                s.imagen = dimagen;
                s.nombre = txtNombre.Text;
                s.telefono = txtTelefono.Text;

                try
                {
                    int r = Suplidores.Registrar(s);
                    if (r > 0)
                    {
                        MessageBox.Show("Registrado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void frmRegistrarSuplidores_Load(object sender, EventArgs e)
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
    }
}
