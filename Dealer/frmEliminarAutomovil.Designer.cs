namespace Dealer
{
    partial class frmEliminarAutomovil
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtSuplidor = new System.Windows.Forms.TextBox();
            this.lblSuplidor = new System.Windows.Forms.Label();
            this.txtCantExistente = new System.Windows.Forms.TextBox();
            this.lblCantExistente = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCilindros = new System.Windows.Forms.TextBox();
            this.lblCilindraje = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lblBuscar = new System.Windows.Forms.LinkLabel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(280, 371);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 36);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(47, 371);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(101, 36);
            this.btnNuevo.TabIndex = 35;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtSuplidor
            // 
            this.txtSuplidor.Location = new System.Drawing.Point(79, 283);
            this.txtSuplidor.Name = "txtSuplidor";
            this.txtSuplidor.Size = new System.Drawing.Size(100, 20);
            this.txtSuplidor.TabIndex = 34;
            // 
            // lblSuplidor
            // 
            this.lblSuplidor.AutoSize = true;
            this.lblSuplidor.Location = new System.Drawing.Point(22, 286);
            this.lblSuplidor.Name = "lblSuplidor";
            this.lblSuplidor.Size = new System.Drawing.Size(48, 13);
            this.lblSuplidor.TabIndex = 33;
            this.lblSuplidor.Text = "Suplidor:";
            // 
            // txtCantExistente
            // 
            this.txtCantExistente.Location = new System.Drawing.Point(114, 331);
            this.txtCantExistente.Name = "txtCantExistente";
            this.txtCantExistente.Size = new System.Drawing.Size(109, 20);
            this.txtCantExistente.TabIndex = 32;
            // 
            // lblCantExistente
            // 
            this.lblCantExistente.AutoSize = true;
            this.lblCantExistente.Location = new System.Drawing.Point(30, 334);
            this.lblCantExistente.Name = "lblCantExistente";
            this.lblCantExistente.Size = new System.Drawing.Size(81, 13);
            this.lblCantExistente.TabIndex = 31;
            this.lblCantExistente.Text = "Cant. Existente:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(79, 232);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(144, 20);
            this.txtPrecio.TabIndex = 30;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(30, 235);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 29;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtCilindros
            // 
            this.txtCilindros.Location = new System.Drawing.Point(79, 190);
            this.txtCilindros.Name = "txtCilindros";
            this.txtCilindros.Size = new System.Drawing.Size(69, 20);
            this.txtCilindros.TabIndex = 28;
            // 
            // lblCilindraje
            // 
            this.lblCilindraje.AutoSize = true;
            this.lblCilindraje.Location = new System.Drawing.Point(21, 193);
            this.lblCilindraje.Name = "lblCilindraje";
            this.lblCilindraje.Size = new System.Drawing.Size(52, 13);
            this.lblCilindraje.TabIndex = 27;
            this.lblCilindraje.Text = "Cilindraje:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(79, 150);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(146, 20);
            this.txtModelo.TabIndex = 26;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(28, 153);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 25;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(79, 103);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(146, 20);
            this.txtMarca.TabIndex = 24;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(30, 106);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 23;
            this.lblMarca.Text = "Marca:";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(436, 53);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(466, 298);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 22;
            this.pbImagen.TabStop = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(185, 64);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 21;
            this.lblBuscar.TabStop = true;
            this.lblBuscar.Text = "Buscar";
            this.lblBuscar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBuscar_LinkClicked);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(79, 61);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 20;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(30, 64);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 19;
            this.lblCodigo.Text = "Codigo:";
            // 
            // frmEliminarAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(923, 430);
            this.Controls.Add(this.btnEliminar);
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
            this.Name = "frmEliminarAutomovil";
            this.Text = "Eliminar Automoviles";
            this.Load += new System.EventHandler(this.frmEliminarAutomovil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtSuplidor;
        private System.Windows.Forms.Label lblSuplidor;
        private System.Windows.Forms.TextBox txtCantExistente;
        private System.Windows.Forms.Label lblCantExistente;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCilindros;
        private System.Windows.Forms.Label lblCilindraje;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.LinkLabel lblBuscar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
    }
}