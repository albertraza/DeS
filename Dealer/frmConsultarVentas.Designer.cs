namespace Dealer
{
    partial class frmConsultarVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarVentas));
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.txtCarro = new System.Windows.Forms.TextBox();
            this.lblCarroComprado = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecioUnd = new System.Windows.Forms.Label();
            this.txtCantComprada = new System.Windows.Forms.TextBox();
            this.lblCantC = new System.Windows.Forms.Label();
            this.txtTotalPagado = new System.Windows.Forms.TextBox();
            this.lblTotalPagado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtTotalPagadoM = new System.Windows.Forms.TextBox();
            this.lblTotalPagadoM = new System.Windows.Forms.Label();
            this.txtCantCompradaM = new System.Windows.Forms.TextBox();
            this.lblCantCompradaM = new System.Windows.Forms.Label();
            this.txtPrecioM = new System.Windows.Forms.TextBox();
            this.lblPrecioM = new System.Windows.Forms.Label();
            this.txtCarroM = new System.Windows.Forms.TextBox();
            this.lblCarroM = new System.Windows.Forms.Label();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.lblNombreM = new System.Windows.Forms.Label();
            this.txtCodigoM = new System.Windows.Forms.TextBox();
            this.lblCodigoM = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(12, 198);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(651, 252);
            this.dgvVentas.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(52, 47);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(490, 144);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(116, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar ";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(101, 44);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(139, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(140, 93);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(100, 20);
            this.txtNombreC.TabIndex = 5;
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.Location = new System.Drawing.Point(52, 96);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(82, 13);
            this.lblNombreC.TabIndex = 4;
            this.lblNombreC.Text = "Nombre Cliente:";
            // 
            // txtCarro
            // 
            this.txtCarro.Location = new System.Drawing.Point(140, 143);
            this.txtCarro.Name = "txtCarro";
            this.txtCarro.Size = new System.Drawing.Size(100, 20);
            this.txtCarro.TabIndex = 7;
            // 
            // lblCarroComprado
            // 
            this.lblCarroComprado.AutoSize = true;
            this.lblCarroComprado.Location = new System.Drawing.Point(48, 146);
            this.lblCarroComprado.Name = "lblCarroComprado";
            this.lblCarroComprado.Size = new System.Drawing.Size(86, 13);
            this.lblCarroComprado.TabIndex = 6;
            this.lblCarroComprado.Text = "Carro Comprado:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(326, 44);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // lblPrecioUnd
            // 
            this.lblPrecioUnd.AutoSize = true;
            this.lblPrecioUnd.Location = new System.Drawing.Point(277, 47);
            this.lblPrecioUnd.Name = "lblPrecioUnd";
            this.lblPrecioUnd.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioUnd.TabIndex = 8;
            this.lblPrecioUnd.Text = "Precio:";
            // 
            // txtCantComprada
            // 
            this.txtCantComprada.Location = new System.Drawing.Point(386, 93);
            this.txtCantComprada.Name = "txtCantComprada";
            this.txtCantComprada.Size = new System.Drawing.Size(40, 20);
            this.txtCantComprada.TabIndex = 11;
            // 
            // lblCantC
            // 
            this.lblCantC.AutoSize = true;
            this.lblCantC.Location = new System.Drawing.Point(277, 96);
            this.lblCantC.Name = "lblCantC";
            this.lblCantC.Size = new System.Drawing.Size(103, 13);
            this.lblCantC.TabIndex = 10;
            this.lblCantC.Text = "Cantidad Comprada:";
            // 
            // txtTotalPagado
            // 
            this.txtTotalPagado.Location = new System.Drawing.Point(357, 146);
            this.txtTotalPagado.Name = "txtTotalPagado";
            this.txtTotalPagado.Size = new System.Drawing.Size(69, 20);
            this.txtTotalPagado.TabIndex = 13;
            // 
            // lblTotalPagado
            // 
            this.lblTotalPagado.AutoSize = true;
            this.lblTotalPagado.Location = new System.Drawing.Point(277, 149);
            this.lblTotalPagado.Name = "lblTotalPagado";
            this.lblTotalPagado.Size = new System.Drawing.Size(74, 13);
            this.lblTotalPagado.TabIndex = 12;
            this.lblTotalPagado.Text = "Total Pagado:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(490, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 23);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(490, 102);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(116, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtTotalPagadoM
            // 
            this.txtTotalPagadoM.Location = new System.Drawing.Point(1002, 317);
            this.txtTotalPagadoM.Name = "txtTotalPagadoM";
            this.txtTotalPagadoM.Size = new System.Drawing.Size(69, 20);
            this.txtTotalPagadoM.TabIndex = 27;
            // 
            // lblTotalPagadoM
            // 
            this.lblTotalPagadoM.AutoSize = true;
            this.lblTotalPagadoM.Location = new System.Drawing.Point(922, 320);
            this.lblTotalPagadoM.Name = "lblTotalPagadoM";
            this.lblTotalPagadoM.Size = new System.Drawing.Size(74, 13);
            this.lblTotalPagadoM.TabIndex = 26;
            this.lblTotalPagadoM.Text = "Total Pagado:";
            // 
            // txtCantCompradaM
            // 
            this.txtCantCompradaM.Location = new System.Drawing.Point(1031, 264);
            this.txtCantCompradaM.Name = "txtCantCompradaM";
            this.txtCantCompradaM.Size = new System.Drawing.Size(40, 20);
            this.txtCantCompradaM.TabIndex = 25;
            // 
            // lblCantCompradaM
            // 
            this.lblCantCompradaM.AutoSize = true;
            this.lblCantCompradaM.Location = new System.Drawing.Point(922, 267);
            this.lblCantCompradaM.Name = "lblCantCompradaM";
            this.lblCantCompradaM.Size = new System.Drawing.Size(103, 13);
            this.lblCantCompradaM.TabIndex = 24;
            this.lblCantCompradaM.Text = "Cantidad Comprada:";
            // 
            // txtPrecioM
            // 
            this.txtPrecioM.Location = new System.Drawing.Point(971, 215);
            this.txtPrecioM.Name = "txtPrecioM";
            this.txtPrecioM.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioM.TabIndex = 23;
            // 
            // lblPrecioM
            // 
            this.lblPrecioM.AutoSize = true;
            this.lblPrecioM.Location = new System.Drawing.Point(922, 218);
            this.lblPrecioM.Name = "lblPrecioM";
            this.lblPrecioM.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioM.TabIndex = 22;
            this.lblPrecioM.Text = "Precio:";
            // 
            // txtCarroM
            // 
            this.txtCarroM.Location = new System.Drawing.Point(785, 314);
            this.txtCarroM.Name = "txtCarroM";
            this.txtCarroM.Size = new System.Drawing.Size(100, 20);
            this.txtCarroM.TabIndex = 21;
            // 
            // lblCarroM
            // 
            this.lblCarroM.AutoSize = true;
            this.lblCarroM.Location = new System.Drawing.Point(693, 317);
            this.lblCarroM.Name = "lblCarroM";
            this.lblCarroM.Size = new System.Drawing.Size(86, 13);
            this.lblCarroM.TabIndex = 20;
            this.lblCarroM.Text = "Carro Comprado:";
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(785, 264);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(100, 20);
            this.txtNombreM.TabIndex = 19;
            // 
            // lblNombreM
            // 
            this.lblNombreM.AutoSize = true;
            this.lblNombreM.Location = new System.Drawing.Point(697, 267);
            this.lblNombreM.Name = "lblNombreM";
            this.lblNombreM.Size = new System.Drawing.Size(82, 13);
            this.lblNombreM.TabIndex = 18;
            this.lblNombreM.Text = "Nombre Cliente:";
            // 
            // txtCodigoM
            // 
            this.txtCodigoM.Location = new System.Drawing.Point(746, 215);
            this.txtCodigoM.Name = "txtCodigoM";
            this.txtCodigoM.Size = new System.Drawing.Size(139, 20);
            this.txtCodigoM.TabIndex = 17;
            // 
            // lblCodigoM
            // 
            this.lblCodigoM.AutoSize = true;
            this.lblCodigoM.Location = new System.Drawing.Point(697, 218);
            this.lblCodigoM.Name = "lblCodigoM";
            this.lblCodigoM.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoM.TabIndex = 16;
            this.lblCodigoM.Text = "Codigo:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(714, 417);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 23);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(925, 417);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 23);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(780, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // frmConsultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1097, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtTotalPagadoM);
            this.Controls.Add(this.lblTotalPagadoM);
            this.Controls.Add(this.txtCantCompradaM);
            this.Controls.Add(this.lblCantCompradaM);
            this.Controls.Add(this.txtPrecioM);
            this.Controls.Add(this.lblPrecioM);
            this.Controls.Add(this.txtCarroM);
            this.Controls.Add(this.lblCarroM);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.lblNombreM);
            this.Controls.Add(this.txtCodigoM);
            this.Controls.Add(this.lblCodigoM);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtTotalPagado);
            this.Controls.Add(this.lblTotalPagado);
            this.Controls.Add(this.txtCantComprada);
            this.Controls.Add(this.lblCantC);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecioUnd);
            this.Controls.Add(this.txtCarro);
            this.Controls.Add(this.lblCarroComprado);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.lblNombreC);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dgvVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultarVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Ventas";
            this.Load += new System.EventHandler(this.frmConsultarVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.TextBox txtCarro;
        private System.Windows.Forms.Label lblCarroComprado;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecioUnd;
        private System.Windows.Forms.TextBox txtCantComprada;
        private System.Windows.Forms.Label lblCantC;
        private System.Windows.Forms.TextBox txtTotalPagado;
        private System.Windows.Forms.Label lblTotalPagado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtTotalPagadoM;
        private System.Windows.Forms.Label lblTotalPagadoM;
        private System.Windows.Forms.TextBox txtCantCompradaM;
        private System.Windows.Forms.Label lblCantCompradaM;
        private System.Windows.Forms.TextBox txtPrecioM;
        private System.Windows.Forms.Label lblPrecioM;
        private System.Windows.Forms.TextBox txtCarroM;
        private System.Windows.Forms.Label lblCarroM;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Label lblNombreM;
        private System.Windows.Forms.TextBox txtCodigoM;
        private System.Windows.Forms.Label lblCodigoM;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}