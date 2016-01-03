namespace Dealer
{
    partial class frmConsultaAutomoviles
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
            this.dgvAutomoviles = new System.Windows.Forms.DataGridView();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCilindros = new System.Windows.Forms.TextBox();
            this.lblCilindros = new System.Windows.Forms.Label();
            this.txtSuplidor = new System.Windows.Forms.TextBox();
            this.lblSuplidor = new System.Windows.Forms.Label();
            this.btnSelccionar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.txtModeloA = new System.Windows.Forms.TextBox();
            this.lblModeloA = new System.Windows.Forms.Label();
            this.txtMarcaA = new System.Windows.Forms.TextBox();
            this.lblMarcaA = new System.Windows.Forms.Label();
            this.txtYearA = new System.Windows.Forms.TextBox();
            this.lblYearA = new System.Windows.Forms.Label();
            this.txtCilindrosA = new System.Windows.Forms.TextBox();
            this.lblCilindrosA = new System.Windows.Forms.Label();
            this.txtSuplidorA = new System.Windows.Forms.TextBox();
            this.lblSuplidorA = new System.Windows.Forms.Label();
            this.txtPrecioA = new System.Windows.Forms.TextBox();
            this.lblPrecioA = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrarNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomoviles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutomoviles
            // 
            this.dgvAutomoviles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomoviles.Location = new System.Drawing.Point(12, 152);
            this.dgvAutomoviles.Name = "dgvAutomoviles";
            this.dgvAutomoviles.Size = new System.Drawing.Size(674, 312);
            this.dgvAutomoviles.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(32, 29);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(81, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(399, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(151, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(81, 62);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(35, 65);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(81, 102);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(32, 105);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 6;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(263, 26);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 9;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(225, 29);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year:";
            this.lblYear.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(263, 66);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 11;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(217, 69);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtCilindros
            // 
            this.txtCilindros.Location = new System.Drawing.Point(263, 105);
            this.txtCilindros.Name = "txtCilindros";
            this.txtCilindros.Size = new System.Drawing.Size(100, 20);
            this.txtCilindros.TabIndex = 13;
            // 
            // lblCilindros
            // 
            this.lblCilindros.AutoSize = true;
            this.lblCilindros.Location = new System.Drawing.Point(208, 108);
            this.lblCilindros.Name = "lblCilindros";
            this.lblCilindros.Size = new System.Drawing.Size(49, 13);
            this.lblCilindros.TabIndex = 12;
            this.lblCilindros.Text = "Cilindros:";
            // 
            // txtSuplidor
            // 
            this.txtSuplidor.Location = new System.Drawing.Point(450, 26);
            this.txtSuplidor.Name = "txtSuplidor";
            this.txtSuplidor.Size = new System.Drawing.Size(100, 20);
            this.txtSuplidor.TabIndex = 15;
            // 
            // lblSuplidor
            // 
            this.lblSuplidor.AutoSize = true;
            this.lblSuplidor.Location = new System.Drawing.Point(396, 29);
            this.lblSuplidor.Name = "lblSuplidor";
            this.lblSuplidor.Size = new System.Drawing.Size(48, 13);
            this.lblSuplidor.TabIndex = 14;
            this.lblSuplidor.Text = "Suplidor:";
            // 
            // btnSelccionar
            // 
            this.btnSelccionar.Location = new System.Drawing.Point(399, 103);
            this.btnSelccionar.Name = "btnSelccionar";
            this.btnSelccionar.Size = new System.Drawing.Size(151, 23);
            this.btnSelccionar.TabIndex = 16;
            this.btnSelccionar.Text = "Seleccionar Auto";
            this.btnSelccionar.UseVisualStyleBackColor = true;
            this.btnSelccionar.Click += new System.EventHandler(this.btnSelccionar_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(799, 26);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(351, 235);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 17;
            this.pbImagen.TabStop = false;
            // 
            // txtModeloA
            // 
            this.txtModeloA.Location = new System.Drawing.Point(862, 332);
            this.txtModeloA.Name = "txtModeloA";
            this.txtModeloA.Size = new System.Drawing.Size(100, 20);
            this.txtModeloA.TabIndex = 21;
            // 
            // lblModeloA
            // 
            this.lblModeloA.AutoSize = true;
            this.lblModeloA.Location = new System.Drawing.Point(813, 335);
            this.lblModeloA.Name = "lblModeloA";
            this.lblModeloA.Size = new System.Drawing.Size(45, 13);
            this.lblModeloA.TabIndex = 20;
            this.lblModeloA.Text = "Modelo:";
            // 
            // txtMarcaA
            // 
            this.txtMarcaA.Location = new System.Drawing.Point(862, 292);
            this.txtMarcaA.Name = "txtMarcaA";
            this.txtMarcaA.Size = new System.Drawing.Size(100, 20);
            this.txtMarcaA.TabIndex = 19;
            // 
            // lblMarcaA
            // 
            this.lblMarcaA.AutoSize = true;
            this.lblMarcaA.Location = new System.Drawing.Point(816, 295);
            this.lblMarcaA.Name = "lblMarcaA";
            this.lblMarcaA.Size = new System.Drawing.Size(40, 13);
            this.lblMarcaA.TabIndex = 18;
            this.lblMarcaA.Text = "Marca:";
            // 
            // txtYearA
            // 
            this.txtYearA.Location = new System.Drawing.Point(1027, 292);
            this.txtYearA.Name = "txtYearA";
            this.txtYearA.Size = new System.Drawing.Size(100, 20);
            this.txtYearA.TabIndex = 23;
            // 
            // lblYearA
            // 
            this.lblYearA.AutoSize = true;
            this.lblYearA.Location = new System.Drawing.Point(989, 295);
            this.lblYearA.Name = "lblYearA";
            this.lblYearA.Size = new System.Drawing.Size(32, 13);
            this.lblYearA.TabIndex = 22;
            this.lblYearA.Text = "Year:";
            // 
            // txtCilindrosA
            // 
            this.txtCilindrosA.Location = new System.Drawing.Point(1027, 332);
            this.txtCilindrosA.Name = "txtCilindrosA";
            this.txtCilindrosA.Size = new System.Drawing.Size(100, 20);
            this.txtCilindrosA.TabIndex = 25;
            // 
            // lblCilindrosA
            // 
            this.lblCilindrosA.AutoSize = true;
            this.lblCilindrosA.Location = new System.Drawing.Point(972, 335);
            this.lblCilindrosA.Name = "lblCilindrosA";
            this.lblCilindrosA.Size = new System.Drawing.Size(49, 13);
            this.lblCilindrosA.TabIndex = 24;
            this.lblCilindrosA.Text = "Cilindros:";
            // 
            // txtSuplidorA
            // 
            this.txtSuplidorA.Location = new System.Drawing.Point(862, 369);
            this.txtSuplidorA.Name = "txtSuplidorA";
            this.txtSuplidorA.Size = new System.Drawing.Size(100, 20);
            this.txtSuplidorA.TabIndex = 27;
            // 
            // lblSuplidorA
            // 
            this.lblSuplidorA.AutoSize = true;
            this.lblSuplidorA.Location = new System.Drawing.Point(808, 372);
            this.lblSuplidorA.Name = "lblSuplidorA";
            this.lblSuplidorA.Size = new System.Drawing.Size(48, 13);
            this.lblSuplidorA.TabIndex = 26;
            this.lblSuplidorA.Text = "Suplidor:";
            // 
            // txtPrecioA
            // 
            this.txtPrecioA.Location = new System.Drawing.Point(1027, 369);
            this.txtPrecioA.Name = "txtPrecioA";
            this.txtPrecioA.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioA.TabIndex = 29;
            // 
            // lblPrecioA
            // 
            this.lblPrecioA.AutoSize = true;
            this.lblPrecioA.Location = new System.Drawing.Point(981, 372);
            this.lblPrecioA.Name = "lblPrecioA";
            this.lblPrecioA.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioA.TabIndex = 28;
            this.lblPrecioA.Text = "Precio:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(734, 441);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 23);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrarNuevo
            // 
            this.btnRegistrarNuevo.Location = new System.Drawing.Point(851, 441);
            this.btnRegistrarNuevo.Name = "btnRegistrarNuevo";
            this.btnRegistrarNuevo.Size = new System.Drawing.Size(111, 23);
            this.btnRegistrarNuevo.TabIndex = 31;
            this.btnRegistrarNuevo.Text = "Registrar Nuevo";
            this.btnRegistrarNuevo.UseVisualStyleBackColor = true;
            this.btnRegistrarNuevo.Click += new System.EventHandler(this.btnRegistrarNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(968, 441);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 23);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "Modificar Auto";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1085, 441);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 23);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "Eliminar Auto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(878, 412);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 34;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1041, 412);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmConsultaAutomoviles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1230, 476);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrarNuevo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtPrecioA);
            this.Controls.Add(this.lblPrecioA);
            this.Controls.Add(this.txtSuplidorA);
            this.Controls.Add(this.lblSuplidorA);
            this.Controls.Add(this.txtCilindrosA);
            this.Controls.Add(this.lblCilindrosA);
            this.Controls.Add(this.txtYearA);
            this.Controls.Add(this.lblYearA);
            this.Controls.Add(this.txtModeloA);
            this.Controls.Add(this.lblModeloA);
            this.Controls.Add(this.txtMarcaA);
            this.Controls.Add(this.lblMarcaA);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnSelccionar);
            this.Controls.Add(this.txtSuplidor);
            this.Controls.Add(this.lblSuplidor);
            this.Controls.Add(this.txtCilindros);
            this.Controls.Add(this.lblCilindros);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dgvAutomoviles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultaAutomoviles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Automoviles";
            this.Load += new System.EventHandler(this.frmConsultaAutomoviles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomoviles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutomoviles;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCilindros;
        private System.Windows.Forms.Label lblCilindros;
        private System.Windows.Forms.TextBox txtSuplidor;
        private System.Windows.Forms.Label lblSuplidor;
        private System.Windows.Forms.Button btnSelccionar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.TextBox txtModeloA;
        private System.Windows.Forms.Label lblModeloA;
        private System.Windows.Forms.TextBox txtMarcaA;
        private System.Windows.Forms.Label lblMarcaA;
        private System.Windows.Forms.TextBox txtYearA;
        private System.Windows.Forms.Label lblYearA;
        private System.Windows.Forms.TextBox txtCilindrosA;
        private System.Windows.Forms.Label lblCilindrosA;
        private System.Windows.Forms.TextBox txtSuplidorA;
        private System.Windows.Forms.Label lblSuplidorA;
        private System.Windows.Forms.TextBox txtPrecioA;
        private System.Windows.Forms.Label lblPrecioA;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrarNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}