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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarUsuario ru = new frmRegistrarUsuario();
            ru.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarUsuario mu = new frmModificarUsuario();

            mu.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarUsuario eu = new frmEliminarUsuario();
            eu.Show();
        }

        private void insertarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistrarAutomovil ra = new frmRegistrarAutomovil();
            ra.Show();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmModificarAutomovil ma = new frmModificarAutomovil();
            ma.Show();
        }

        private void insertarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRegistrarSuplidores rs = new frmRegistrarSuplidores();
            rs.Show();
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmModificarSuplidores ms = new frmModificarSuplidores();
            ms.Show();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEliminarAutomovil ea = new frmEliminarAutomovil();
            ea.Show();
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmEliminarSuplidores es = new frmEliminarSuplidores();
            es.Show();
        }

        private void insertarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmRegistrarCliente rc = new frmRegistrarCliente();
            rc.Show();
        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmModificarClientes mc = new frmModificarClientes();
            mc.Show();
        }

        private void eliminarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmEliminarClientes ec = new frmEliminarClientes();
            ec.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaUsuarios cu = new frmConsultaUsuarios();
            cu.Show();
        }

        private void automovilesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaAutomoviles ca = new frmConsultaAutomoviles();
            ca.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaClientes cc = new frmConsultaClientes();
            cc.Show();
        }

        private void suplidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarSuplidores cs = new frmConsultarSuplidores();
            cs.Show();
        }

        private void LimpiarAutomovil()
        {
            txtCantExistente.Clear();
            txtCilindros.Clear();
            txtCodigo.Clear();
            txtCodigo.Enabled = true;
            txtMarca.Clear();
            txtModelo.Clear();
            txtPrecio.Clear();
            txtSuplidor.Clear();
            lblBuscar.Enabled = true;
        }
        private void LimpiarClientes()
        {
            txtCodigoC.Clear();
            txtCodigoC.Enabled = true;
            txtApellido.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            lblBuscarC.Enabled = true;
        }
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
                txtApellido.Enabled = false;
                txtCantExistente.Enabled = false;
                txtCilindros.Enabled = false;
                txtMarca.Enabled = false;
                txtModelo.Enabled = false;
                txtNombre.Enabled = false;
                txtPrecio.Enabled = false;
                txtSuplidor.Enabled = false;
                txtTelefono.Enabled = false;
                txtTotalPagar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblBuscar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Digite el codigo del automovil, sino lo sabe presione consultar automoviles", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
            }
            else
            {
                try
                {
                    Automoviles a = Automoviles.getAutomovil(txtCodigo.Text);
                    if (a != null)
                    {
                        txtCantExistente.Text = Automoviles.getCantExistente(int.Parse(txtCodigo.Text));
                        txtCilindros.Text = a.cilindros;
                        txtMarca.Text = a.marca;
                        txtModelo.Text = a.modelo;
                        txtPrecio.Text = double.Parse(a.precio).ToString("f2");
                        txtSuplidor.Text = Automoviles.getSuplidor(int.Parse(txtCodigo.Text));
                        txtCodigo.Enabled = false;
                        lblBuscar.Enabled = false;
                        pbImagen.Image = Image.FromFile(a.imagen);
                        int cant = int.Parse(Automoviles.getCantExistente(int.Parse(txtCodigo.Text)));
                        if (cant == 0)
                        {
                            MessageBox.Show("El Automovil no esta Disponible para Despachar, Intentelo Luego", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe el Automovil, Digite un codigo valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnLimpiarCA_Click(object sender, EventArgs e)
        {
            LimpiarAutomovil();
            try
            {
                pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultarAutomoviles_Click(object sender, EventArgs e)
        {
            frmConsultaAutomoviles ca = new frmConsultaAutomoviles();
            ca.Type = true;
            ca.ShowDialog();
            if (ca.IDa != null)
            {
                txtCodigo.Text = ca.IDa;
                try
                {
                    Automoviles a = Automoviles.getAutomovil(txtCodigo.Text);
                    if (a != null)
                    {
                        txtCantExistente.Text = Automoviles.getCantExistente(int.Parse(txtCodigo.Text));
                        txtCilindros.Text = a.cilindros;
                        txtMarca.Text = a.marca;
                        txtModelo.Text = a.modelo;
                        txtPrecio.Text = double.Parse(a.precio).ToString("f2");
                        txtSuplidor.Text = Automoviles.getSuplidor(int.Parse(txtCodigo.Text));
                        txtCodigo.Enabled = false;
                        lblBuscar.Enabled = false;
                        pbImagen.Image = Image.FromFile(a.imagen);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiarCC_Click(object sender, EventArgs e)
        {
            LimpiarClientes();
        }

        private void lblBuscarC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtCodigoC.Text == string.Empty)
            {
                MessageBox.Show("El Codigo esta vacio, sino conoce el codigo presione consultar clientes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoC.Focus();
            }
            else
            {
                Clientes c = Clientes.getClientes(txtCodigoC.Text);
                if (c != null)
                {
                    txtApellido.Text = c.apellido;
                    txtNombre.Text = c.nombre;
                    txtTelefono.Text = c.telefono;
                    txtCodigoC.Enabled = false;
                    lblBuscarC.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No existe el Cliente, sino conoce el codigo presione consultar clientes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoC.Clear();
                    txtCodigoC.Focus();
                }
            }
        }

        private void btnConsultarC_Click(object sender, EventArgs e)
        {
            frmConsultaClientes cc = new frmConsultaClientes();
            cc.Type = true;
            cc.ShowDialog();
            if (cc.IDc != null)
            {
                txtCodigoC.Text = cc.IDc;
                Clientes c = Clientes.getClientes(txtCodigoC.Text);
                if (c != null)
                {
                    txtApellido.Text = c.apellido;
                    txtNombre.Text = c.nombre;
                    txtTelefono.Text = c.telefono;
                    txtCodigoC.Enabled = false;
                    lblBuscarC.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("No se selecciono ningun Automovil", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private int cante = 0, cantc = 0;
        private double preciound = 0, totalpagar = 0;
        private void lblCalcular_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtCantExistente.Text == string.Empty)
            {
                MessageBox.Show("No se ha Cargado el Automovil a Despachar; Digite un codigo valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
            }
            else if (txtCodigoC.Text == string.Empty)
            {
                MessageBox.Show("No se ha Cargado el Cliente a Despachar; Digite un codigo valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoC.Focus();
            }
            else
            {
                cante = int.Parse(txtCantExistente.Text);
                if (txtCantComprar.Text == string.Empty)
                {
                    MessageBox.Show("Cantidad a Comprar esta vacia, digite una cantidad a comprar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantComprar.Focus();
                }
                else if (cante < int.Parse(txtCantComprar.Text))
                {
                    MessageBox.Show("No hay Suficientes automoviles, Digite una cantidad menor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantComprar.Clear();
                    txtCantComprar.Focus();
                }
                else
                {
                    cantc = int.Parse(txtCantComprar.Text);
                    preciound = double.Parse(txtPrecio.Text);

                    totalpagar = cantc * preciound;
                    txtTotalPagar.Text = totalpagar.ToString("f2");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarAutomovil();
            LimpiarClientes();
            txtCantComprar.Clear();
            txtTotalPagar.Clear();
            try
            {
                pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDespachar_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == string.Empty)
            {
                MessageBox.Show("No se ha cargado el Automovil, Digite un codigo e intente nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
            }
            else if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("No se ha cargado el Cliente, Digite un codigo e intente nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoC.Focus();
            }
            else
            {
                if (txtCantExistente.Text == string.Empty)
                {
                    MessageBox.Show("No se ha Cargado el Automovil a Despachar; Digite un codigo valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigo.Focus();
                }
                else if (txtCodigoC.Text == string.Empty)
                {
                    MessageBox.Show("No se ha Cargado el Cliente a Despachar; Digite un codigo valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoC.Focus();
                }
                else
                {
                    cante = int.Parse(txtCantExistente.Text);
                    if (txtCantComprar.Text == string.Empty)
                    {
                        MessageBox.Show("Cantidad a Comprar esta vacia, digite una cantidad a comprar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCantComprar.Focus();
                    }
                    else if (cante < int.Parse(txtCantComprar.Text))
                    {
                        MessageBox.Show("No hay Suficientes automoviles, Digite una cantidad menor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCantComprar.Clear();
                        txtCantComprar.Focus();
                    }
                    else if (cante == 0)
                    {
                        MessageBox.Show("El Automovil no esta disponible", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        cantc = int.Parse(txtCantComprar.Text);
                        preciound = double.Parse(txtPrecio.Text);

                        totalpagar = cantc * preciound;
                        txtTotalPagar.Text = totalpagar.ToString("f2");
                        if (MessageBox.Show("Cantidad a Comprar: " + cantc.ToString() + " \n \n Total a Pagar: " + totalpagar.ToString() + " \n \n Desea despachar el Automovil?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            Ventas v = new Ventas();
                            v.Cant_Comprada = cantc.ToString();
                            v.Carro_Comprado = txtMarca.Text + " " + txtModelo.Text;
                            v.Nombre_Cliente = txtNombre.Text + " " + txtApellido.Text;
                            v.Precio_Und = preciound.ToString();
                            v.Total_pagar = totalpagar.ToString();

                            try
                            {
                                int r = Ventas.Registrar(v, txtCodigo.Text);
                                if (r > 0)
                                {
                                    MessageBox.Show("Despacho con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Automoviles.ActualizarCantExistente(txtCodigo.Text, (cante - cantc).ToString());
                                    LimpiarAutomovil();
                                    LimpiarClientes();
                                    pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
                                    txtCantComprar.Clear();
                                    txtTotalPagar.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo Despachar el Automovil", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }

        private void automovilesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmReporteAutomoviles ra = new frmReporteAutomoviles();
            ra.Show();
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmReporteClientes rc = new frmReporteClientes();
            rc.Show();
        }

        private void suplidoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmReporteSuplidores rs = new frmReporteSuplidores();
            rs.Show();
        }

        private void usuariosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmReporteUsuarios ru = new frmReporteUsuarios();
            ru.Show();
        }

        private void vantasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteVenttas rv = new frmReporteVenttas();
            rv.Show();
        }

        private void despachosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarVentas cv = new frmConsultarVentas();
            cv.Show();
        }

        private void btnBuscarDespacho_Click(object sender, EventArgs e)
        {
            frmConsultarVentas cv = new frmConsultarVentas();
            cv.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
