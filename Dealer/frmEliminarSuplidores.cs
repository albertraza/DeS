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
    public partial class frmEliminarSuplidores : Form
    {
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtCodigo.Enabled = true;
            txtCodigo.Focus();
            txtDescripcion.Clear();
            txtDireccion.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            btnEliminar.Enabled = false;
            lblBuscar.Enabled = true;
            pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png"); 
        }
        public frmEliminarSuplidores()
        {
            InitializeComponent();
        }
        private string IDs;
        public string codigo
        {
            get { return IDs; }
            set { IDs = value; }
        }
        private void frmEliminarSuplidores_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = IDs;
            try
            {
                if (txtCodigo.Text != string.Empty)
                {
                    Suplidores s = Suplidores.getSuplidor(txtCodigo.Text);
                    txtDescripcion.Text = s.descripcion;
                    txtDireccion.Text = s.direccion;
                    txtNombre.Text = s.nombre;
                    txtTelefono.Text = s.telefono;
                    txtCodigo.Enabled = false;
                    lblBuscar.Enabled = false;
                    pbImagen.Image = Image.FromFile(s.imagen);
                }
                else
                {
                    pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
                    txtDescripcion.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtNombre.Enabled = false;
                    txtTelefono.Enabled = false;
                    btnEliminar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblBuscar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Suplidores s = new Suplidores();
            try
            {
                s = Suplidores.getSuplidor(txtCodigo.Text);
                if (s != null)
                {
                    txtDescripcion.Text = s.descripcion;
                    txtDireccion.Text = s.direccion;
                    txtNombre.Text = s.nombre;
                    txtTelefono.Text = s.telefono;
                    btnEliminar.Enabled = true;
                    pbImagen.Image = Image.FromFile(s.imagen);
                    txtCodigo.Enabled = false;
                    lblBuscar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No Existe el Suplidor, Digite un ID valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigo.Clear();
                    txtCodigo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int r = Suplidores.Eliminar(txtCodigo.Text);
                if (r > 0)
                {
                    MessageBox.Show("Eliminado Exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
