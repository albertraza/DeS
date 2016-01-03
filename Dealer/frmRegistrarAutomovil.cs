using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Dealer
{
    public partial class frmRegistrarAutomovil : Form
    {
        private void LimpiarCampos()
        {
            txtModelo.Clear();
            txtPrecio.Clear();
            txtYear.Clear();
            cbMarca.Text = "";
            cbSuplidor.Text = "";
            cbMarca.Focus();
            txtCantExistente.Clear();
            pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
        }
        private void CBMarcas()
        {
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand("select * from marcas", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    cbMarca.Items.Add(re["marca"]);
                }
            }
        }
        private void CBSuplidores()
        {
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand("select * from Suplidores", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    cbSuplidor.Items.Add(re["nombresuplidor"]);
                }
            }
        }
        public frmRegistrarAutomovil()
        {
            InitializeComponent();
        }

        private void cbSuplidor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistrarAutomovil_Load(object sender, EventArgs e)
        {
            try
            {
                pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
                CBMarcas();
                CBSuplidores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string uimagen = null, dimagen = null;
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfld = new OpenFileDialog();
                openfld.ShowDialog();
                uimagen = openfld.FileName;
                dimagen = @"C:\FactoriadeProyectos\Dealer\img\log\mob\" + Path.GetFileName(uimagen);
                pbImagen.Image = Image.FromFile(uimagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
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
            else if (txtYear.Text == string.Empty)
            {
                MessageBox.Show("El Year esta vacio, digite un Year", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYear.Focus();
            }
            else if (cbMarca.Text == string.Empty)
            {
                MessageBox.Show("La marca esta vacia, seleccione una marca valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMarca.Focus();
            }
            else if (cbSuplidor.Text == string.Empty)
            {
                MessageBox.Show("El suplidor esta vacio, seleccione un suplidor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbSuplidor.Focus();
            }
            else if (nCilindros.Value == 0 || nCilindros.Value < 3)
            {
                MessageBox.Show("El Cilindraje esta vacio, digite un Cilindraje para el vehiculo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nCilindros.Focus();
            }
            else if (txtCantExistente.Text == string.Empty)
            {
                MessageBox.Show("Cant Existente esta vacia, Digite una valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantExistente.Focus();
            }
            else
            {
                Automoviles a = new Automoviles();
                a.marca = cbMarca.Text;
                a.modelo = txtModelo.Text;
                a.precio = txtPrecio.Text;
                a.year = txtYear.Text;
                a.imagen = dimagen;
                a.cilindros = nCilindros.Value.ToString();
                try
                {
                    int r = Automoviles.Registrar(a, txtCantExistente.Text, cbSuplidor.Text);
                    if (r > 0)
                    {
                        MessageBox.Show("Registrado con Exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        File.Copy(uimagen, dimagen, true);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Registrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
