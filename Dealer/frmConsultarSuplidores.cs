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
    public partial class frmConsultarSuplidores : Form
    {
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtDireccion.Clear();
            txtDireecionS.Clear();
            txtNombre.Clear();
            txtNombreS.Clear();
            txtTelefono.Clear();
            txtTelefonoS.Clear();
            txtCodigo.Focus();
            pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
        }
        public frmConsultarSuplidores()
        {
            InitializeComponent();
        }

        private void frmConsultarSuplidores_Load(object sender, EventArgs e)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmRegistrarSuplidores rs = new frmRegistrarSuplidores();
            rs.Show();
        }

        string ID;
        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarSuplidores ms = new frmModificarSuplidores();
            ms.codigo = ID;
            ms.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarSuplidores es = new frmEliminarSuplidores();
            es.codigo = ID;
            es.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo, nombre, telefono, direecion;
            if (txtCodigo.Text == string.Empty)
            {
                codigo = "";
            }
            else
            {
                codigo = txtCodigo.Text;
            }
            if (txtDireccion.Text == string.Empty)
            {
                direecion = "";
            }
            else
            {
                direecion = txtDireccion.Text;
            }
            if (txtNombre.Text == string.Empty)
            {
                nombre = "";
            }
            else
            {
                nombre = txtNombre.Text;
            }
            if (txtTelefono.Text == string.Empty)
            {
                telefono = "";
            }
            else
            {
                telefono = txtTelefono.Text;
            }
            try
            {
                dgvSuplidores.DataSource = Suplidores.Buscar(nombre, direecion, telefono, codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvSuplidores.SelectedRows.Count == 1)
            {
                ID = dgvSuplidores.CurrentRow.Cells[0].Value.ToString();
                Suplidores s = Suplidores.getSuplidor(ID);
                txtDireecionS.Text = s.direccion;
                txtNombreS.Text = s.nombre;
                txtTelefonoS.Text = s.telefono;
                txtDescripcion.Text = s.descripcion;
                pbImagen.Image = Image.FromFile(s.imagen);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un Suplidor de la Lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
