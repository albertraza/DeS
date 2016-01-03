namespace Dealer
{
    partial class frmConsultaClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaClientes));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtApellidoC = new System.Windows.Forms.TextBox();
            this.lblApellidoC = new System.Windows.Forms.Label();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.lblnombreC = new System.Windows.Forms.Label();
            this.txtTelefonoC = new System.Windows.Forms.TextBox();
            this.lblTelefonoC = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 145);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(525, 283);
            this.dgvClientes.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(39, 37);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(88, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(268, 92);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(215, 95);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(268, 34);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 8;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(210, 37);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(399, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(399, 90);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(129, 23);
            this.btnSeleccionar.TabIndex = 10;
            this.btnSeleccionar.Text = "Seleccionar Cliente";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtApellidoC
            // 
            this.txtApellidoC.Location = new System.Drawing.Point(706, 299);
            this.txtApellidoC.Name = "txtApellidoC";
            this.txtApellidoC.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoC.TabIndex = 14;
            // 
            // lblApellidoC
            // 
            this.lblApellidoC.AutoSize = true;
            this.lblApellidoC.Location = new System.Drawing.Point(653, 302);
            this.lblApellidoC.Name = "lblApellidoC";
            this.lblApellidoC.Size = new System.Drawing.Size(47, 13);
            this.lblApellidoC.TabIndex = 13;
            this.lblApellidoC.Text = "Apellido:";
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(706, 241);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(100, 20);
            this.txtNombreC.TabIndex = 12;
            // 
            // lblnombreC
            // 
            this.lblnombreC.AutoSize = true;
            this.lblnombreC.Location = new System.Drawing.Point(653, 244);
            this.lblnombreC.Name = "lblnombreC";
            this.lblnombreC.Size = new System.Drawing.Size(47, 13);
            this.lblnombreC.TabIndex = 11;
            this.lblnombreC.Text = "Nombre:";
            // 
            // txtTelefonoC
            // 
            this.txtTelefonoC.Location = new System.Drawing.Point(706, 351);
            this.txtTelefonoC.Name = "txtTelefonoC";
            this.txtTelefonoC.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoC.TabIndex = 16;
            // 
            // lblTelefonoC
            // 
            this.lblTelefonoC.AutoSize = true;
            this.lblTelefonoC.Location = new System.Drawing.Point(648, 354);
            this.lblTelefonoC.Name = "lblTelefonoC";
            this.lblTelefonoC.Size = new System.Drawing.Size(52, 13);
            this.lblTelefonoC.TabIndex = 15;
            this.lblTelefonoC.Text = "Telefono:";
            // 
            // pbImagen
            // 
            this.pbImagen.Image = ((System.Drawing.Image)(resources.GetObject("pbImagen.Image")));
            this.pbImagen.Location = new System.Drawing.Point(636, 32);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(215, 169);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 17;
            this.pbImagen.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(574, 405);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(656, 405);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(737, 405);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(818, 405);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(636, 377);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(761, 376);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(920, 440);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.txtTelefonoC);
            this.Controls.Add(this.lblTelefonoC);
            this.Controls.Add(this.txtApellidoC);
            this.Controls.Add(this.lblApellidoC);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.lblnombreC);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Clientes";
            this.Load += new System.EventHandler(this.frmConsultaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtApellidoC;
        private System.Windows.Forms.Label lblApellidoC;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.Label lblnombreC;
        private System.Windows.Forms.TextBox txtTelefonoC;
        private System.Windows.Forms.Label lblTelefonoC;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}