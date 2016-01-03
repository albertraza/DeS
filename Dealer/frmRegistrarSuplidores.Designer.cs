namespace Dealer
{
    partial class frmRegistrarSuplidores
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
            this.gbSuplidores = new System.Windows.Forms.GroupBox();
            this.btnSeleccionarImagen = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelofono = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gbSuplidores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSuplidores
            // 
            this.gbSuplidores.BackColor = System.Drawing.Color.DarkKhaki;
            this.gbSuplidores.Controls.Add(this.btnSeleccionarImagen);
            this.gbSuplidores.Controls.Add(this.pbImagen);
            this.gbSuplidores.Controls.Add(this.txtTelefono);
            this.gbSuplidores.Controls.Add(this.lblTelofono);
            this.gbSuplidores.Controls.Add(this.txtDescripcion);
            this.gbSuplidores.Controls.Add(this.lblDescripcion);
            this.gbSuplidores.Controls.Add(this.txtDireccion);
            this.gbSuplidores.Controls.Add(this.lbldireccion);
            this.gbSuplidores.Controls.Add(this.txtNombre);
            this.gbSuplidores.Controls.Add(this.lblNombre);
            this.gbSuplidores.Location = new System.Drawing.Point(25, 29);
            this.gbSuplidores.Name = "gbSuplidores";
            this.gbSuplidores.Size = new System.Drawing.Size(764, 319);
            this.gbSuplidores.TabIndex = 0;
            this.gbSuplidores.TabStop = false;
            this.gbSuplidores.Text = "Imformacion Suplidores";
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(455, 290);
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(192, 23);
            this.btnSeleccionarImagen.TabIndex = 4;
            this.btnSeleccionarImagen.Text = "Seleccionar Imagen";
            this.btnSeleccionarImagen.UseVisualStyleBackColor = true;
            this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(362, 37);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(379, 247);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 8;
            this.pbImagen.TabStop = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(101, 153);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 2;
            // 
            // lblTelofono
            // 
            this.lblTelofono.AutoSize = true;
            this.lblTelofono.Location = new System.Drawing.Point(43, 156);
            this.lblTelofono.Name = "lblTelofono";
            this.lblTelofono.Size = new System.Drawing.Size(52, 13);
            this.lblTelofono.TabIndex = 6;
            this.lblTelofono.Text = "Telefono:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(101, 200);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(204, 84);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(29, 203);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(101, 105);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(204, 20);
            this.txtDireccion.TabIndex = 1;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(40, 108);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(55, 13);
            this.lbldireccion.TabIndex = 2;
            this.lbldireccion.Text = "Direccion:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(204, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(48, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(57, 354);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(255, 354);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmRegistrarSuplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(839, 385);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbSuplidores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRegistrarSuplidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Suplidores";
            this.Load += new System.EventHandler(this.frmRegistrarSuplidores_Load);
            this.gbSuplidores.ResumeLayout(false);
            this.gbSuplidores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSuplidores;
        private System.Windows.Forms.Button btnSeleccionarImagen;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelofono;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRegistrar;
    }
}