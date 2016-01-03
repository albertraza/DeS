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
    public partial class frmConsultaAutomoviles : Form
    {
        private void LimpiarCampos()
        {
            txtCilindros.Clear();
            txtCilindrosA.Clear();
            txtCodigo.Clear();
            txtMarca.Clear();
            txtMarcaA.Clear();
            txtModelo.Clear();
            txtModeloA.Clear();
            txtPrecio.Clear();
            txtPrecioA.Clear();
            txtSuplidor.Clear();
            txtSuplidorA.Clear();
            txtYear.Clear();
            txtYearA.Clear();
            txtCodigo.Focus();
            pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
        }
        public frmConsultaAutomoviles()
        {
            InitializeComponent();
        }

        private void lblYear_Click(object sender, EventArgs e)
        {

        }

        private bool state = false;
        public bool Type
        {
            get { return state; }
            set { state = value; }
        }
        public string IDa { get; set; }
        private void frmConsultaAutomoviles_Load(object sender, EventArgs e)
        {
            try
            {
                if (state != true)
                {
                    txtCilindrosA.Enabled = false;
                    txtMarcaA.Enabled = false;
                    txtModeloA.Enabled = false;
                    txtPrecioA.Enabled = false;
                    txtSuplidorA.Enabled = false;
                    txtYearA.Enabled = false;
                    pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
                    btnAceptar.Visible = false;
                    btnCancelar.Visible = false;
                }
                else
                {
                    btnEliminar.Visible = false;
                    btnModificar.Visible = false;
                    btnRegistrarNuevo.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string marca, modelo, year, cilindros, precio, suplidor, codigo;
            if (txtCilindros.Text == string.Empty)
            {
                cilindros = "";
            }
            else
            {
                cilindros = txtCilindros.Text;
            }
            if (txtCodigo.Text == string.Empty)
            {
                codigo = "";
            }
            else
            {
                codigo = txtCodigo.Text;
            }
            if (txtMarca.Text == string.Empty)
            {
                marca = "";
            }
            else
            {
                marca = txtMarca.Text;
            }
            if (txtModelo.Text == string.Empty)
            {
                modelo = txtModelo.Text;
            }
            else
            {
                modelo = txtModelo.Text;
            }
            if (txtPrecio.Text == string.Empty)
            {
                precio = "";
            }
            else
            {
                precio = txtPrecio.Text;
            }
            if (txtSuplidor.Text == string.Empty)
            {
                suplidor = "";
            }
            else
            {
                suplidor = txtSuplidor.Text;
            }
            if (txtYear.Text == string.Empty)
            {
                year = "";
            }
            else
            {
                year = txtYear.Text;
            }
            try
            {
                dgvAutomoviles.DataSource = Automoviles.Buscar(codigo, marca, modelo, year, cilindros, suplidor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ID { get; set; }
        private void btnSelccionar_Click(object sender, EventArgs e)
        {
            if (dgvAutomoviles.SelectedRows.Count == 1)
            {
                try
                {
                    ID = dgvAutomoviles.CurrentRow.Cells[0].Value.ToString();
                    Automoviles a = Automoviles.getAutomovil(dgvAutomoviles.CurrentRow.Cells[0].Value.ToString());
                    txtCilindrosA.Text = a.cilindros;
                    txtMarcaA.Text = a.marca;
                    txtPrecioA.Text = Convert.ToDouble(a.precio).ToString("f2");
                    txtSuplidorA.Text = Automoviles.getSuplidor(int.Parse(dgvAutomoviles.CurrentRow.Cells[0].Value.ToString()));
                    txtYearA.Text = a.year;
                    pbImagen.Image = Image.FromFile(a.imagen);
                    txtModeloA.Text = a.modelo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un automovil de la tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnRegistrarNuevo_Click(object sender, EventArgs e)
        {
            frmRegistrarAutomovil ra = new frmRegistrarAutomovil();
            ra.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarAutomovil ma = new frmModificarAutomovil();
            ma.codigo = ID;
            ma.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarAutomovil ea = new frmEliminarAutomovil();
            ea.codigo = ID;
            ea.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvAutomoviles.SelectedRows.Count == 1)
            {
                IDa = dgvAutomoviles.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un Automovil de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
