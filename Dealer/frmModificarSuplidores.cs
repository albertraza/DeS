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
    public partial class frmModificarSuplidores : Form
    {
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtCodigo.Focus();
            txtCodigo.Enabled = true;
            txtDescripcion.Clear();
            txtDireccion.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            btnModificar.Enabled = false;
            lblBuscar.Enabled = true;
            pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
        }
        public frmModificarSuplidores()
        {
            InitializeComponent();
        }
        private string IDs;
        public string codigo
        {
            get { return IDs; }
            set { IDs = value; }
        }
        private void frmModificarSuplidores_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = IDs;
            try
            {
                if (txtCodigo.Text != string.Empty)
                {
                    Suplidores s = Suplidores.getSuplidor(txtCodigo.Text);
                    txtCodigo.Enabled = false;
                    lblBuscar.Enabled = false;
                    txtDescripcion.Text = s.descripcion;
                    txtDireccion.Text = s.direccion;
                    txtNombre.Text = s.nombre;
                    txtTelefono.Text = s.nombre;
                    pbImagen.Image = Image.FromFile(s.imagen);
                }
                else
                {
                    pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
                    btnModificar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private Suplidores s = new Suplidores();
        private void lblBuscar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                s = Suplidores.getSuplidor(txtCodigo.Text);
                if (s != null)
                {
                    txtDescripcion.Text = s.descripcion;
                    txtDireccion.Text = s.direccion;
                    btnModificar.Enabled = true;
                    txtNombre.Text = s.nombre;
                    txtTelefono.Text = s.telefono;
                    pbImagen.Image = Image.FromFile(s.imagen);
                    dimagen = s.imagen;
                    txtCodigo.Enabled = false;
                    lblBuscar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No Existe el suplidor o codigo incorrecto, digite uno valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
        string uimagen, dimagen;
        private void btnModificar_Click(object sender, EventArgs e)
        {
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
                Suplidores m = new Suplidores();
                m.codigo = txtCodigo.Text;
                m.descripcion = txtDescripcion.Text;
                m.direccion = txtDireccion.Text;
                m.imagen = dimagen;
                m.nombre = txtNombre.Text;
                m.telefono = txtTelefono.Text;

                try
                {
                    int r = Suplidores.Modificar(m);
                    if (r > 0)
                    {
                        MessageBox.Show("Modificado con Exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
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

        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfld = new OpenFileDialog();
            openfld.ShowDialog();
            try
            {
                uimagen = openfld.FileName;
                dimagen = @"C:\FactoriadeProyectos\Dealer\img\log\sup\" + Path.GetFileName(uimagen);
                File.Copy(uimagen, dimagen, true);
                pbImagen.Image = Image.FromFile(uimagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
