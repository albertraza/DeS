namespace Dealer
{
    partial class frmConsultarSuplidores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSuplidores = new System.Windows.Forms.DataGridView();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.txtDireecionS = new System.Windows.Forms.TextBox();
            this.lblDireccionS = new System.Windows.Forms.Label();
            this.txtNombreS = new System.Windows.Forms.TextBox();
            this.lblNombreS = new System.Windows.Forms.Label();
            this.txtTelefonoS = new System.Windows.Forms.TextBox();
            this.lblTelefonoS = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuplidores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSuplidores
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuplidores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuplidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuplidores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuplidores.Location = new System.Drawing.Point(12, 167);
            this.dgvSuplidores.Name = "dgvSuplidores";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuplidores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSuplidores.Size = new System.Drawing.Size(579, 346);
            this.dgvSuplidores.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(30, 35);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(79, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(177, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(79, 121);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(177, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(18, 124);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(350, 32);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 8;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(292, 35);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(294, 76);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(209, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar Suplidor";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(294, 118);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(209, 23);
            this.btnSelecionar.TabIndex = 10;
            this.btnSelecionar.Text = "Seleccionar Suplidor";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(732, 32);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(391, 238);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 11;
            this.pbImagen.TabStop = false;
            // 
            // txtDireecionS
            // 
            this.txtDireecionS.Location = new System.Drawing.Point(819, 330);
            this.txtDireecionS.Name = "txtDireecionS";
            this.txtDireecionS.Size = new System.Drawing.Size(229, 20);
            this.txtDireecionS.TabIndex = 15;
            // 
            // lblDireccionS
            // 
            this.lblDireccionS.AutoSize = true;
            this.lblDireccionS.Location = new System.Drawing.Point(913, 314);
            this.lblDireccionS.Name = "lblDireccionS";
            this.lblDireccionS.Size = new System.Drawing.Size(52, 13);
            this.lblDireccionS.TabIndex = 14;
            this.lblDireccionS.Text = "Direccion";
            // 
            // txtNombreS
            // 
            this.txtNombreS.Location = new System.Drawing.Point(819, 294);
            this.txtNombreS.Name = "txtNombreS";
            this.txtNombreS.Size = new System.Drawing.Size(229, 20);
            this.txtNombreS.TabIndex = 13;
            // 
            // lblNombreS
            // 
            this.lblNombreS.AutoSize = true;
            this.lblNombreS.Location = new System.Drawing.Point(913, 278);
            this.lblNombreS.Name = "lblNombreS";
            this.lblNombreS.Size = new System.Drawing.Size(44, 13);
            this.lblNombreS.TabIndex = 12;
            this.lblNombreS.Text = "Nombre";
            // 
            // txtTelefonoS
            // 
            this.txtTelefonoS.Location = new System.Drawing.Point(884, 368);
            this.txtTelefonoS.Name = "txtTelefonoS";
            this.txtTelefonoS.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoS.TabIndex = 17;
            // 
            // lblTelefonoS
            // 
            this.lblTelefonoS.AutoSize = true;
            this.lblTelefonoS.Location = new System.Drawing.Point(909, 352);
            this.lblTelefonoS.Name = "lblTelefonoS";
            this.lblTelefonoS.Size = new System.Drawing.Size(49, 13);
            this.lblTelefonoS.TabIndex = 16;
            this.lblTelefonoS.Text = "Telefono";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(687, 490);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 23);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(810, 490);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(117, 23);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo Suplidor";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(933, 490);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 23);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar Suplidor";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(819, 407);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(229, 54);
            this.txtDescripcion.TabIndex = 22;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(902, 391);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 21;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1056, 490);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 23);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar Suplidor";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmConsultarSuplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1188, 525);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtTelefonoS);
            this.Controls.Add(this.lblTelefonoS);
            this.Controls.Add(this.txtDireecionS);
            this.Controls.Add(this.lblDireccionS);
            this.Controls.Add(this.txtNombreS);
            this.Controls.Add(this.lblNombreS);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dgvSuplidores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultarSuplidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Suplidores";
            this.Load += new System.EventHandler(this.frmConsultarSuplidores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuplidores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSuplidores;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.TextBox txtDireecionS;
        private System.Windows.Forms.Label lblDireccionS;
        private System.Windows.Forms.TextBox txtNombreS;
        private System.Windows.Forms.Label lblNombreS;
        private System.Windows.Forms.TextBox txtTelefonoS;
        private System.Windows.Forms.Label lblTelefonoS;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnEliminar;
    }
}