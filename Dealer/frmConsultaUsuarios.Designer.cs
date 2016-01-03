namespace Dealer
{
    partial class frmConsultaUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtIDUsuarioC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(28, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(77, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 91);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(447, 319);
            this.dgvUsuarios.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(384, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(256, 27);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtIDUsuario.TabIndex = 8;
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.Location = new System.Drawing.Point(193, 30);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(57, 13);
            this.lblIDUsuario.TabIndex = 7;
            this.lblIDUsuario.Text = "ID Usuario";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(550, 30);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(293, 210);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 9;
            this.pbImagen.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(598, 387);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(110, 23);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar Nuevo";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(714, 387);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 23);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(830, 387);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtIDUsuarioC
            // 
            this.txtIDUsuarioC.Location = new System.Drawing.Point(666, 329);
            this.txtIDUsuarioC.Name = "txtIDUsuarioC";
            this.txtIDUsuarioC.Size = new System.Drawing.Size(100, 20);
            this.txtIDUsuarioC.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Usuario";
            // 
            // txtCodigoC
            // 
            this.txtCodigoC.Location = new System.Drawing.Point(666, 277);
            this.txtCodigoC.Name = "txtCodigoC";
            this.txtCodigoC.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoC.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Codigo:";
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(330, 62);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(129, 23);
            this.btnUsuario.TabIndex = 17;
            this.btnUsuario.Text = "Seleccionar Usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(482, 387);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 23);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(952, 433);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.txtIDUsuarioC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.lblIDUsuario);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Usuarios";
            this.Load += new System.EventHandler(this.frmConsultaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Label lblIDUsuario;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIDUsuarioC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnLimpiar;
    }
}