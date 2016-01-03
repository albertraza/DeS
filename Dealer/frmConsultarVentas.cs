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
    public partial class frmConsultarVentas : Form
    {
        public frmConsultarVentas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo, nombre, carro, cant, precio, totalpagar;
            if (txtCantComprada.Text == string.Empty)
            {
                cant = "";
            }
            else
            {
                cant = txtCantComprada.Text;
            }
            if (txtCarro.Text == string.Empty)
            {
                carro = "";
            }
            else
            {
                carro = txtCarro.Text;
            }
            if (txtCodigo.Text == string.Empty)
            {
                codigo = "";
            }
            else
            {
                codigo = txtCodigo.Text;
            }
            if (txtNombreC.Text == string.Empty)
            {
                nombre = "";
            }
            else
            {
                nombre = txtNombreC.Text;
            }
            if (txtPrecio.Text == string.Empty)
            {
                precio = "";
            }
            else
            {
                precio = txtPrecio.Text;
            }
            if (txtTotalPagado.Text == string.Empty)
            {
                totalpagar = "";
            }
            else
            {
                totalpagar = txtTotalPagado.Text;
            }

            try
            {
                dgvVentas.DataSource = Ventas.Buscar(nombre, carro, precio, cant, totalpagar, codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtCantComprada.Clear();
            txtCantCompradaM.Clear();
            txtCarro.Clear();
            txtCarroM.Clear();
            txtCodigo.Clear();
            txtCodigoM.Clear();
            txtNombreC.Clear();
            txtNombreM.Clear();
            txtPrecio.Clear();
            txtPrecioM.Clear();
            txtTotalPagado.Clear();
            txtTotalPagadoM.Clear();
            txtCodigo.Focus();
        }
        private void frmConsultarVentas_Load(object sender, EventArgs e)
        {
            txtPrecioM.Enabled = false;
            txtCarroM.Enabled = false;
            txtCodigoM.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private string ID;
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count == 1)
            {
                ID = dgvVentas.CurrentRow.Cells[0].Value.ToString();
                try
                {
                    Ventas v = Ventas.getVentas(ID);
                    if (v != null)
                    {
                        txtCantCompradaM.Text = v.Cant_Comprada;
                        txtCarroM.Text = v.Carro_Comprado;
                        txtCodigoM.Text = v.codigo;
                        txtNombreM.Text = v.Nombre_Cliente;
                        txtPrecioM.Text = v.Precio_Und;
                        txtTotalPagadoM.Text = v.Total_pagar;
                        cantA = int.Parse(v.Cant_Comprada);
                    }
                    else
                    {
                        MessageBox.Show("No Existe el Registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        int cantA, cantN;
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Ventas v = new Ventas();
                v.Cant_Comprada = txtCantCompradaM.Text;
                v.Carro_Comprado = txtCarroM.Text;
                v.codigo = ID;
                v.Nombre_Cliente = txtNombreM.Text;
                v.Precio_Und = txtPrecioM.Text;
                if (int.Parse(txtCantCompradaM.Text) != cantA)
                {
                    cantN = cantA - int.Parse(txtCantCompradaM.Text);
                    int cantE = int.Parse(Automoviles.getCantExistente(Convert.ToInt32(Ventas.getCodigoauto(ID))));
                    int ncant = cantN + cantE;
                    Automoviles.ActualizarCantExistente(Ventas.getCodigoauto(ID), ncant.ToString());
                }
                double totalpagar = double.Parse(txtPrecioM.Text) * int.Parse(txtCantCompradaM.Text);
                v.Total_pagar = totalpagar.ToString();
                int r = Ventas.Modificar(v);
                if (r > 0)
                {
                    MessageBox.Show("Modificaro Exitosamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtPrecioM.Text == string.Empty || txtCantCompradaM.Text == string.Empty)
            {
                MessageBox.Show("No se ha cargado ningun despacho, Seleccione uno de la tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int codigoA = int.Parse(Ventas.getCodigoauto(ID));
                int cantc = int.Parse(txtCantCompradaM.Text);
                int cante = int.Parse(Automoviles.getCantExistente(codigoA));
                int ncant = cantc + cante;
                try
                {
                    int r = Ventas.Eliminar(ID);
                    if (r > 0)
                    {
                        MessageBox.Show("Eliminado con Exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Automoviles.ActualizarCantExistente(codigoA.ToString(), ncant.ToString());
                        LimpiarCampos();
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
