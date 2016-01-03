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
    public partial class frmEliminarAutomovil : Form
    {
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtCantExistente.Clear();
            txtCilindros.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtPrecio.Clear();
            txtSuplidor.Clear();
            btnEliminar.Enabled = false;
            txtCodigo.Enabled = true;
            lblBuscar.Enabled = true;
            pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
        }
        public frmEliminarAutomovil()
        {
            InitializeComponent();
        }

        private string IDa;
        public string codigo
        {
            get { return IDa; }
            set { IDa = value; }
        }
        private void frmEliminarAutomovil_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = IDa;
            try
            {
                if (txtCodigo.Text != string.Empty)
                {
                    txtCantExistente.Enabled = false;
                    txtCilindros.Enabled = false;
                    txtMarca.Enabled = false;
                    txtModelo.Enabled = false;
                    txtPrecio.Enabled = false;
                    txtSuplidor.Enabled = false;
                    btnEliminar.Enabled = true;
                    Automoviles a = Automoviles.getAutomovil(txtCodigo.Text);
                    txtCantExistente.Text = Automoviles.getCantExistente(int.Parse(txtCodigo.Text));
                    txtCilindros.Text = a.cilindros;
                    txtMarca.Text = a.marca;
                    txtModelo.Text = a.modelo;
                    txtPrecio.Text = a.precio;
                    txtSuplidor.Text = Automoviles.getSuplidor(int.Parse(txtCodigo.Text));
                    lblBuscar.Enabled = false;
                    txtCodigo.Enabled = false;
                    pbImagen.Image = Image.FromFile(a.imagen);
                }
                else
                {
                    pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
                    txtCantExistente.Enabled = false;
                    txtCilindros.Enabled = false;
                    txtMarca.Enabled = false;
                    txtModelo.Enabled = false;
                    txtPrecio.Enabled = false;
                    txtSuplidor.Enabled = false;
                    btnEliminar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Codigo vacio deigite un codigo valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
            }
            else
            {
                try
                {
                    int r = Automoviles.Eliminar(txtCodigo.Text);
                    if (r > 0)
                    {
                        MessageBox.Show("Eliminado Exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido Eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblBuscar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Automoviles a = new Automoviles();
            try
            {
                a = Automoviles.getAutomovil(txtCodigo.Text);
                if (a != null)
                {
                    pbImagen.Image = Image.FromFile(a.imagen);
                    txtCantExistente.Text = Automoviles.getCantExistente(int.Parse(txtCodigo.Text));
                    txtCilindros.Text = a.cilindros;
                    txtMarca.Text = a.marca;
                    txtModelo.Text = a.modelo;
                    txtPrecio.Text = double.Parse(a.precio).ToString("f2");
                    txtSuplidor.Text = Automoviles.getSuplidor(int.Parse(txtCodigo.Text));
                    lblBuscar.Enabled = false;
                    btnEliminar.Enabled = true;
                    txtCodigo.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No Existe el Automovil", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigo.Clear();
                    txtCodigo.Focus();
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
