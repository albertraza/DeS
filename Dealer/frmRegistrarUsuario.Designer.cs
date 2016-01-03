namespace Dealer
{
    partial class frmRegistrarUsuario
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
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.btnBuscarImagen = new System.Windows.Forms.Button();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(16, 46);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(122, 13);
            this.lblUbicacion.TabIndex = 0;
            this.lblUbicacion.Text = "Ubicacion de la Imagen:";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(144, 43);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(242, 20);
            this.txtUbicacion.TabIndex = 1;
            // 
            // btnBuscarImagen
            // 
            this.btnBuscarImagen.Location = new System.Drawing.Point(256, 119);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.Size = new System.Drawing.Size(130, 23);
            this.btnBuscarImagen.TabIndex = 2;
            this.btnBuscarImagen.Text = "Buscar Imagen";
            this.btnBuscarImagen.UseVisualStyleBackColor = true;
            this.btnBuscarImagen.Click += new System.EventHandler(this.btnBuscarImagen_Click);
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(144, 84);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(242, 20);
            this.txtDestino.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Destino de la Imagen:";
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(94, 197);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(106, 20);
            this.txtIDUsuario.TabIndex = 6;
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.Location = new System.Drawing.Point(28, 200);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(60, 13);
            this.lblIDUsuario.TabIndex = 5;
            this.lblIDUsuario.Text = "ID Usuario:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(94, 245);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(106, 20);
            this.txtClave.TabIndex = 8;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(51, 248);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(37, 13);
            this.lblClave.TabIndex = 7;
            this.lblClave.Text = "Clave:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox1.Controls.Add(this.pbImagen);
            this.groupBox1.Controls.Add(this.lblUbicacion);
            this.groupBox1.Controls.Add(this.txtUbicacion);
            this.groupBox1.Controls.Add(this.btnBuscarImagen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDestino);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 160);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imformacion de la Imagen";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(449, 13);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(205, 141);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 5;
            this.pbImagen.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(268, 214);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(103, 37);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(446, 214);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(103, 37);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(724, 308);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.lblIDUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Usuario";
            this.Load += new System.EventHandler(this.frmRegistrarUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Button btnBuscarImagen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Label lblIDUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRegistrar;
    }
}