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
    public partial class frmModificarAutomovil : Form
    {
        private void LimpiarCampos()
        {
            txtCantExistente.Clear();
            txtCilindros.Clear();
            txtCodigo.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtPrecio.Clear();
            txtSuplidor.Clear();
            txtYear.Clear();
            txtCodigo.Enabled = true;
            lblBuscar.Enabled = true;
            btnModificar.Enabled = false;
            pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
        }
        public frmModificarAutomovil()
        {
            InitializeComponent();
        }

        private Automoviles a;
        private string uimagen, dimagen;
        private void lblBuscar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Codigo vacio, digite uno valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
            }
            else
            {
                try
                {
                    a = Automoviles.getAutomovil(txtCodigo.Text);
                    if (a != null)
                    {
                        txtMarca.Text = a.marca;
                        txtCantExistente.Text = Automoviles.getCantExistente(int.Parse(txtCodigo.Text));
                        txtSuplidor.Text = Automoviles.getSuplidor(int.Parse(txtCodigo.Text));
                        txtCilindros.Text = a.cilindros;
                        txtModelo.Text = a.modelo;
                        txtPrecio.Text = a.precio;
                        btnModificar.Enabled = true;
                        txtYear.Text = a.year;
                        pbImagen.Image = Image.FromFile(a.imagen);
                        dimagen = a.imagen;
                        lblBuscar.Enabled = false;
                        txtCodigo.Enabled = false;
                        txtYear.Text = a.year;
                    }
                    else
                    {
                        MessageBox.Show("Automovil no registrado o Codigo incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Automoviles m = new Automoviles();
            if (txtModelo.Text == string.Empty)
            {
                MessageBox.Show("El modelo esta vacio, digite un modelo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModelo.Focus();
            }
            else if (txtPrecio.Text == string.Empty)
            {
                MessageBox.Show("El precio esta vacio, digite un precio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
            }
            else if (txtMarca.Text == string.Empty)
            {
                MessageBox.Show("La marca esta vacia, seleccione una marca valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarca.Focus();
            }
            else if (txtSuplidor.Text == string.Empty)
            {
                MessageBox.Show("El suplidor esta vacio, seleccione un suplidor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSuplidor.Focus();
            }
            else if (txtCilindros.Text == "0" || int.Parse(txtCilindros.Text) < 3 || txtCilindros.Text == string.Empty)
            {
                MessageBox.Show("El Cilindraje esta vacio, digite un Cilindraje para el vehiculo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCilindros.Focus();
            }
            else if (txtCantExistente.Text == string.Empty)
            {
                MessageBox.Show("Cant Existente esta vacia, Digite una valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantExistente.Focus();
            }
            else
            {
                m.cilindros = txtCilindros.Text;
                m.codigo = txtCodigo.Text;
                m.imagen = dimagen;
                m.marca = txtMarca.Text;
                m.modelo = txtModelo.Text;
                m.precio = txtPrecio.Text;
                m.year = txtYear.Text;
                try
                {
                    int r = Automoviles.Modificar(m, txtCantExistente.Text, txtSuplidor.Text);
                    if (r > 0)
                    {
                        MessageBox.Show("Modificado Exitosamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private string IDa;
        public string codigo
        {
            get { return IDa; }
            set { IDa = value; }
        }
        private void frmModificarAutomovil_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = Convert.ToString(IDa);
            try
            {
                if (txtCodigo.Text != string.Empty)
                {
                    lblBuscar.Enabled = false;
                    txtCodigo.Enabled = false;
                    btnModificar.Enabled = true;
                    Automoviles a = Automoviles.getAutomovil(txtCodigo.Text);
                    txtCantExistente.Text = Automoviles.getCantExistente(int.Parse(txtCodigo.Text));
                    txtCilindros.Text = a.cilindros;
                    txtMarca.Text = a.marca;
                    txtModelo.Text = a.modelo;
                    txtYear.Text = a.year;
                    txtPrecio.Text = a.precio;
                    txtSuplidor.Text = Automoviles.getSuplidor(int.Parse(txtCodigo.Text));
                    pbImagen.Image = Image.FromFile(a.imagen);
                    dimagen = a.imagen;
                    txtYear.Text = a.year;
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
        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfld = new OpenFileDialog();
                openfld.ShowDialog();
                uimagen = openfld.FileName;
                pbImagen.Image = Image.FromFile(uimagen);
                dimagen = @"C:\FactoriadeProyectos\Dealer\img\log\mob\" + Path.GetFileName(uimagen);
                File.Copy(uimagen, dimagen, true);
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
