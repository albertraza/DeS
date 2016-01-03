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
    public partial class frmConsultaClientes : Form
    {
        private void LimpiarCampos()
        {
            txtApellido.Clear();
            txtApellidoC.Clear();
            txtCodigo.Clear();
            txtNombre.Clear();
            txtNombreC.Clear();
            txtTelefono.Clear();
            txtTelefonoC.Clear();
            txtCodigo.Focus();
        }
        public frmConsultaClientes()
        {
            InitializeComponent();
        }
        private bool state;
        public bool Type
        {
            get { return state; }
            set { state = value; }
        }
        private void frmConsultaClientes_Load(object sender, EventArgs e)
        {
            if (state != true)
            {
                txtApellidoC.Enabled = false;
                txtNombreC.Enabled = false;
                txtTelefonoC.Enabled = false;
                btnAceptar.Visible = false;
                btnCancelar.Visible = false;
            }
            else
            {
                btnEliminar.Visible = false;
                btnModificar.Visible = false;
                btnNuevo.Visible = false;
                txtApellidoC.Enabled = false;
                txtNombreC.Enabled = false;
                txtTelefonoC.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, telefono, codigo;
            if (txtApellido.Text == string.Empty)
            {
                apellido = "";
            }
            else
            {
                apellido = txtApellido.Text;
            }
            if (txtCodigo.Text == string.Empty)
            {
                codigo = "";
            }
            else
            {
                codigo = txtCodigo.Text;
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
                dgvClientes.DataSource = Clientes.Buscar(codigo, nombre, apellido, telefono);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string ID;
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1)
            {
                ID = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                try
                {
                    Clientes c = Clientes.getClientes(ID);
                    txtApellidoC.Text = c.apellido;
                    txtNombreC.Text = c.nombre;
                    txtTelefonoC.Text = c.telefono;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un cliente de la tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarClientes ec = new frmEliminarClientes();
            ec.codigo = ID;
            ec.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarClientes mc = new frmModificarClientes();
            mc.codigo = ID;
            mc.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmRegistrarCliente rc = new frmRegistrarCliente();
            rc.Show();
        }

        public string IDc { get; set; }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1)
            {
                IDc = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un Automovil, Seleccione uno de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
