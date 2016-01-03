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
    public partial class frmEliminarClientes : Form
    {
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtCodigo.Focus();
            txtCodigo.Enabled = true;
            lblBuscar.Enabled = true;
            btnEliminar.Enabled = false;
            txtApellido.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
        }
        public frmEliminarClientes()
        {
            InitializeComponent();
        }
        private string IDc;
        public string codigo
        {
            get { return IDc; }
            set { IDc = value; }
        }
        private void frmEliminarClientes_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = IDc;
            try
            {
                if (txtCodigo.Text != string.Empty)
                {
                    Clientes c = Clientes.getClientes(txtCodigo.Text);
                    txtApellido.Text = c.apellido;
                    txtNombre.Text = c.nombre;
                    txtTelefono.Text = c.telefono;
                    btnEliminar.Enabled = true;
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtCodigo.Enabled = false;
                    lblBuscar.Enabled = false;
                }
                else
                {
                    btnEliminar.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtTelefono.Enabled = false;
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
                    Clientes c = new Clientes();
                    c = Clientes.getClientes(txtCodigo.Text);
                    if (c != null)
                    {
                        txtNombre.Text = c.nombre;
                        txtApellido.Text = c.apellido;
                        txtTelefono.Text = c.telefono;
                        btnEliminar.Enabled = true;
                        txtCodigo.Enabled = false;
                        lblBuscar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("No existe el cliente, digite un  codigo valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int r = Clientes.Eliminar(txtCodigo.Text);
                if (r > 0)
                {
                    MessageBox.Show("Eliminado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
