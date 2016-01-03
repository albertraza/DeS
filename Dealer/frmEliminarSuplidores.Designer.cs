namespace Dealer
{
    partial class frmEliminarSuplidores
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
            this.gbSuplidores = new System.Windows.Forms.GroupBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.LinkLabel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gbSuplidores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(260, 388);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(37, 388);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbSuplidores
            // 
            this.gbSuplidores.BackColor = System.Drawing.Color.DarkKhaki;
            this.gbSuplidores.Controls.Add(this.pbImagen);
            this.gbSuplidores.Controls.Add(this.txtDescripcion);
            this.gbSuplidores.Controls.Add(this.label1);
            this.gbSuplidores.Controls.Add(this.txtTelefono);
            this.gbSuplidores.Controls.Add(this.lblTelefono);
            this.gbSuplidores.Controls.Add(this.txtDireccion);
            this.gbSuplidores.Controls.Add(this.lblDireccion);
            this.gbSuplidores.Controls.Add(this.txtNombre);
            this.gbSuplidores.Controls.Add(this.lblNombre);
            this.gbSuplidores.Controls.Add(this.lblBuscar);
            this.gbSuplidores.Controls.Add(this.txtCodigo);
            this.gbSuplidores.Controls.Add(this.lblCodigo);
            this.gbSuplidores.Location = new System.Drawing.Point(21, 27);
            this.gbSuplidores.Name = "gbSuplidores";
            this.gbSuplidores.Size = new System.Drawing.Size(752, 349);
            this.gbSuplidores.TabIndex = 16;
            this.gbSuplidores.TabStop = false;
            this.gbSuplidores.Text = "Informacion Suplidores";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(315, 30);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(397, 296);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 12;
            this.pbImagen.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(85, 232);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(173, 77);
            this.txtDescripcion.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Descripcion:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(85, 183);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(27, 186);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(85, 135);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(146, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(24, 138);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 94);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(191, 44);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.TabStop = true;
            this.lblBuscar.Text = "Buscar";
            this.lblBuscar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBuscar_LinkClicked);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(85, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(36, 44);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo:";
            // 
            // frmEliminarSuplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(791, 421);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbSuplidores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEliminarSuplidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Suplidores";
            this.Load += new System.EventHandler(this.frmEliminarSuplidores_Load);
            this.gbSuplidores.ResumeLayout(false);
            this.gbSuplidores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbSuplidores;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.LinkLabel lblBuscar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
    }
}