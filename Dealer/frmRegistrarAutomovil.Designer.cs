namespace Dealer
{
    partial class frmRegistrarAutomovil
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
            this.gbAutomoviles = new System.Windows.Forms.GroupBox();
            this.lblCantExistente = new System.Windows.Forms.Label();
            this.txtCantExistente = new System.Windows.Forms.TextBox();
            this.cbSuplidor = new System.Windows.Forms.ComboBox();
            this.lblSuplidor = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.nCilindros = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCilindraje = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.gbImagen = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.gbAutomoviles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCilindros)).BeginInit();
            this.gbImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAutomoviles
            // 
            this.gbAutomoviles.BackColor = System.Drawing.Color.DarkKhaki;
            this.gbAutomoviles.Controls.Add(this.lblCantExistente);
            this.gbAutomoviles.Controls.Add(this.txtCantExistente);
            this.gbAutomoviles.Controls.Add(this.cbSuplidor);
            this.gbAutomoviles.Controls.Add(this.lblSuplidor);
            this.gbAutomoviles.Controls.Add(this.btnNuevo);
            this.gbAutomoviles.Controls.Add(this.nCilindros);
            this.gbAutomoviles.Controls.Add(this.lblPrecio);
            this.gbAutomoviles.Controls.Add(this.txtPrecio);
            this.gbAutomoviles.Controls.Add(this.lblCilindraje);
            this.gbAutomoviles.Controls.Add(this.lblYear);
            this.gbAutomoviles.Controls.Add(this.txtYear);
            this.gbAutomoviles.Controls.Add(this.lblModelo);
            this.gbAutomoviles.Controls.Add(this.txtModelo);
            this.gbAutomoviles.Controls.Add(this.btnRegistrar);
            this.gbAutomoviles.Controls.Add(this.cbMarca);
            this.gbAutomoviles.Controls.Add(this.lblMarca);
            this.gbAutomoviles.Location = new System.Drawing.Point(30, 24);
            this.gbAutomoviles.Name = "gbAutomoviles";
            this.gbAutomoviles.Size = new System.Drawing.Size(464, 323);
            this.gbAutomoviles.TabIndex = 0;
            this.gbAutomoviles.TabStop = false;
            this.gbAutomoviles.Text = "Imformacion Automovil";
            // 
            // lblCantExistente
            // 
            this.lblCantExistente.AutoSize = true;
            this.lblCantExistente.Location = new System.Drawing.Point(250, 99);
            this.lblCantExistente.Name = "lblCantExistente";
            this.lblCantExistente.Size = new System.Drawing.Size(81, 13);
            this.lblCantExistente.TabIndex = 16;
            this.lblCantExistente.Text = "Cant. Existente:";
            // 
            // txtCantExistente
            // 
            this.txtCantExistente.Location = new System.Drawing.Point(337, 95);
            this.txtCantExistente.Name = "txtCantExistente";
            this.txtCantExistente.Size = new System.Drawing.Size(80, 20);
            this.txtCantExistente.TabIndex = 15;
            // 
            // cbSuplidor
            // 
            this.cbSuplidor.FormattingEnabled = true;
            this.cbSuplidor.Location = new System.Drawing.Point(296, 48);
            this.cbSuplidor.Name = "cbSuplidor";
            this.cbSuplidor.Size = new System.Drawing.Size(121, 21);
            this.cbSuplidor.TabIndex = 14;
            this.cbSuplidor.SelectedIndexChanged += new System.EventHandler(this.cbSuplidor_SelectedIndexChanged);
            // 
            // lblSuplidor
            // 
            this.lblSuplidor.AutoSize = true;
            this.lblSuplidor.Location = new System.Drawing.Point(242, 51);
            this.lblSuplidor.Name = "lblSuplidor";
            this.lblSuplidor.Size = new System.Drawing.Size(48, 13);
            this.lblSuplidor.TabIndex = 13;
            this.lblSuplidor.Text = "Suplidor:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(50, 261);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(113, 40);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // nCilindros
            // 
            this.nCilindros.Location = new System.Drawing.Point(74, 178);
            this.nCilindros.Name = "nCilindros";
            this.nCilindros.Size = new System.Drawing.Size(42, 20);
            this.nCilindros.TabIndex = 11;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(28, 221);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(74, 218);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // lblCilindraje
            // 
            this.lblCilindraje.AutoSize = true;
            this.lblCilindraje.Location = new System.Drawing.Point(16, 180);
            this.lblCilindraje.Name = "lblCilindraje";
            this.lblCilindraje.Size = new System.Drawing.Size(52, 13);
            this.lblCilindraje.TabIndex = 8;
            this.lblCilindraje.Text = "Cilindraje:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(36, 141);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Year:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(74, 138);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 5;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(23, 95);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(74, 92);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(309, 261);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(113, 40);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(74, 48);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 21);
            this.cbMarca.TabIndex = 1;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(28, 51);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            // 
            // gbImagen
            // 
            this.gbImagen.BackColor = System.Drawing.Color.DarkKhaki;
            this.gbImagen.Controls.Add(this.btnSeleccionar);
            this.gbImagen.Controls.Add(this.pbImagen);
            this.gbImagen.Location = new System.Drawing.Point(521, 24);
            this.gbImagen.Name = "gbImagen";
            this.gbImagen.Size = new System.Drawing.Size(372, 323);
            this.gbImagen.TabIndex = 1;
            this.gbImagen.TabStop = false;
            this.gbImagen.Text = "Imagen Automovil";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(15, 294);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(188, 23);
            this.btnSeleccionar.TabIndex = 16;
            this.btnSeleccionar.Text = "Seleccionar Imagen";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(6, 19);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(360, 259);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 15;
            this.pbImagen.TabStop = false;
            // 
            // frmRegistrarAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(914, 371);
            this.Controls.Add(this.gbImagen);
            this.Controls.Add(this.gbAutomoviles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRegistrarAutomovil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Automovil";
            this.Load += new System.EventHandler(this.frmRegistrarAutomovil_Load);
            this.gbAutomoviles.ResumeLayout(false);
            this.gbAutomoviles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCilindros)).EndInit();
            this.gbImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAutomoviles;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.GroupBox gbImagen;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.NumericUpDown nCilindros;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCilindraje;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cbSuplidor;
        private System.Windows.Forms.Label lblSuplidor;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lblCantExistente;
        private System.Windows.Forms.TextBox txtCantExistente;
    }
}