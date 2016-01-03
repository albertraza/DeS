namespace Dealer
{
    partial class frmModificarAutomovil
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.LinkLabel();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtCilindros = new System.Windows.Forms.TextBox();
            this.lblCilindraje = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCantExistente = new System.Windows.Forms.TextBox();
            this.lblCantExistente = new System.Windows.Forms.Label();
            this.txtSuplidor = new System.Windows.Forms.TextBox();
            this.lblSuplidor = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCambiarImagen = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(34, 29);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(83, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(189, 29);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.TabStop = true;
            this.lblBuscar.Text = "Buscar";
            this.lblBuscar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBuscar_LinkClicked);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(440, 43);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(466, 298);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 3;
            this.pbImagen.TabStop = false;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(83, 68);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(146, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(34, 71);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(83, 115);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(146, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(32, 118);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 6;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtCilindros
            // 
            this.txtCilindros.Location = new System.Drawing.Point(83, 155);
            this.txtCilindros.Name = "txtCilindros";
            this.txtCilindros.Size = new System.Drawing.Size(69, 20);
            this.txtCilindros.TabIndex = 9;
            // 
            // lblCilindraje
            // 
            this.lblCilindraje.AutoSize = true;
            this.lblCilindraje.Location = new System.Drawing.Point(25, 158);
            this.lblCilindraje.Name = "lblCilindraje";
            this.lblCilindraje.Size = new System.Drawing.Size(52, 13);
            this.lblCilindraje.TabIndex = 8;
            this.lblCilindraje.Text = "Cilindraje:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(83, 197);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(144, 20);
            this.txtPrecio.TabIndex = 11;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(34, 200);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtCantExistente
            // 
            this.txtCantExistente.Location = new System.Drawing.Point(118, 321);
            this.txtCantExistente.Name = "txtCantExistente";
            this.txtCantExistente.Size = new System.Drawing.Size(109, 20);
            this.txtCantExistente.TabIndex = 13;
            // 
            // lblCantExistente
            // 
            this.lblCantExistente.AutoSize = true;
            this.lblCantExistente.Location = new System.Drawing.Point(34, 324);
            this.lblCantExistente.Name = "lblCantExistente";
            this.lblCantExistente.Size = new System.Drawing.Size(81, 13);
            this.lblCantExistente.TabIndex = 12;
            this.lblCantExistente.Text = "Cant. Existente:";
            // 
            // txtSuplidor
            // 
            this.txtSuplidor.Location = new System.Drawing.Point(83, 273);
            this.txtSuplidor.Name = "txtSuplidor";
            this.txtSuplidor.Size = new System.Drawing.Size(100, 20);
            this.txtSuplidor.TabIndex = 15;
            // 
            // lblSuplidor
            // 
            this.lblSuplidor.AutoSize = true;
            this.lblSuplidor.Location = new System.Drawing.Point(25, 276);
            this.lblSuplidor.Name = "lblSuplidor";
            this.lblSuplidor.Size = new System.Drawing.Size(48, 13);
            this.lblSuplidor.TabIndex = 14;
            this.lblSuplidor.Text = "Suplidor:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(51, 361);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(101, 36);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(284, 361);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 36);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCambiarImagen
            // 
            this.btnCambiarImagen.Location = new System.Drawing.Point(465, 347);
            this.btnCambiarImagen.Name = "btnCambiarImagen";
            this.btnCambiarImagen.Size = new System.Drawing.Size(217, 23);
            this.btnCambiarImagen.TabIndex = 18;
            this.btnCambiarImagen.Text = "Cambiar Imagen";
            this.btnCambiarImagen.UseVisualStyleBackColor = true;
            this.btnCambiarImagen.Click += new System.EventHandler(this.btnCambiarImagen_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(83, 233);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 20;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(42, 236);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 19;
            this.lblYear.Text = "Year:";
            // 
            // frmModificarAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(918, 409);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnCambiarImagen);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtSuplidor);
            this.Controls.Add(this.lblSuplidor);
            this.Controls.Add(this.txtCantExistente);
            this.Controls.Add(this.lblCantExistente);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtCilindros);
            this.Controls.Add(this.lblCilindraje);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmModificarAutomovil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Automovil";
            this.Load += new System.EventHandler(this.frmModificarAutomovil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.LinkLabel lblBuscar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtCilindros;
        private System.Windows.Forms.Label lblCilindraje;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCantExistente;
        private System.Windows.Forms.Label lblCantExistente;
        private System.Windows.Forms.TextBox txtSuplidor;
        private System.Windows.Forms.Label lblSuplidor;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCambiarImagen;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
    }
}