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
    public partial class frmConsultaUsuarios : Form
    {
        private void LimpiarCampos()
        {
            txtCodigoC.Clear();
            txtIDUsuario.Clear();
            txtCodigo.Clear();
            txtIDUsuarioC.Clear();
            pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
        }
        public frmConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo, idusuario;
            if (txtCodigo.Text == string.Empty)
            {
                codigo = "";
            }
            else
            {
                codigo = txtCodigo.Text;
            }
            if (txtIDUsuario.Text == string.Empty)
            {
                idusuario = "";
            }
            else
            {
                idusuario = txtIDUsuario.Text;
            }
            try
            {
                dgvUsuarios.DataSource = Usuario.Buscar(codigo, idusuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrarUsuario ru = new frmRegistrarUsuario();
            ru.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmModificarUsuario mu = new frmModificarUsuario();
            mu.codigo = txtCodigoC.Text;
            mu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEliminarUsuario eu = new frmEliminarUsuario();
            eu.codigo = txtCodigoC.Text;
            eu.ShowDialog();
        }

        public string ID {get; set;}
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 1)
            {
                ID = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();

                try
                {
                    Usuario u = Usuario.getUsuario(ID);
                    txtCodigoC.Text = u.codigo;
                    txtIDUsuarioC.Text = u.ID_Usuario;
                    pbImagen.Image = Image.FromFile(Usuario.ImagenUsrCod(ID));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un usuario de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmConsultaUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                txtCodigoC.Enabled = false;
                txtIDUsuarioC.Enabled = false;
                pbImagen.Image = Image.FromFile(@"C:\FactoriadeProyectos\Dealer\img\n.png");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
