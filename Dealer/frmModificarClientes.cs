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
    public partial class frmModificarClientes : Form
    {
        private void LimpiarCampos()
        {
            txtApellido.Clear();
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCodigo.Focus();
            txtCodigo.Enabled = true;
            lblBuscar.Enabled = true;
            btnModificar.Enabled = false;
        }
        public frmModificarClientes()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void lblBuscar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("El codigo esta vacio, digite uno valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
            }
            else
            {
                Clientes c = new Clientes();
                try
                {
                    c = Clientes.getClientes(txtCodigo.Text);
                    if (c == null)
                    {
                        MessageBox.Show("No Existe el Cliente, Digite un Codigo valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigo.Clear();
                        txtCodigo.Focus();
                    }
                    else
                    {
                        txtApellido.Text = c.apellido;
                        txtNombre.Text = c.nombre;
                        txtTelefono.Text = c.telefono;
                        txtCodigo.Enabled = false;
                        lblBuscar.Enabled = false;
                        btnModificar.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Nombre vacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtApellido.Text == string.Empty)
            {
                MessageBox.Show("Apellido vacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
            }
            else if (txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("Telefono Vacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
            }
            else
            {
                c.codigo = txtCodigo.Text;
                c.nombre = txtNombre.Text;
                c.apellido = txtApellido.Text;
                c.telefono = txtTelefono.Text;

                try
                {
                    int r = Clientes.Modificar(c);
                    if (r > 0)
                    {
                        MessageBox.Show("Modificado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private string IDc;
        public string codigo
        {
            get { return IDc; }
            set { IDc = value; }
        }
        private void frmModificarClientes_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = IDc;
            try
            {
                if (txtCodigo.Text != string.Empty)
                {
                    btnModificar.Enabled = true;
                    Clientes c = Clientes.getClientes(txtCodigo.Text);
                    txtApellido.Text = c.apellido;
                    txtNombre.Text = c.nombre;
                    txtTelefono.Text = c.telefono;
                    lblBuscar.Enabled = false;
                    txtCodigo.Enabled = false;
                    btnModificar.Enabled = true;
                }
                else
                {
                    btnModificar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
