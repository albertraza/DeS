namespace Dealer
{
    partial class frmModificarUsuario
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCambiarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblCodigo.Location = new System.Drawing.Point(33, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(89, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(53, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(148, 38);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.TabStop = true;
            this.lblBuscar.Text = "Buscar";
            this.lblBuscar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBuscar_LinkClicked);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(6, 19);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(239, 141);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 3;
            this.pbImagen.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(25, 163);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.lblClave);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.lblIDUsuario);
            this.groupBox1.Controls.Add(this.txtIDUsuario);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.lblBuscar);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 212);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del Usuario";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(169, 163);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(39, 114);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(37, 13);
            this.lblClave.TabIndex = 7;
            this.lblClave.Text = "Clave:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(88, 111);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 8;
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.Location = new System.Drawing.Point(22, 72);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(60, 13);
            this.lblIDUsuario.TabIndex = 5;
            this.lblIDUsuario.Text = "ID Usuario:";
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(88, 69);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtIDUsuario.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox2.Controls.Add(this.btnCambiarImagen);
            this.groupBox2.Controls.Add(this.pbImagen);
            this.groupBox2.Location = new System.Drawing.Point(415, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 212);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagen";
            // 
            // btnCambiarImagen
            // 
            this.btnCambiarImagen.Location = new System.Drawing.Point(6, 183);
            this.btnCambiarImagen.Name = "btnCambiarImagen";
            this.btnCambiarImagen.Size = new System.Drawing.Size(147, 23);
            this.btnCambiarImagen.TabIndex = 5;
            this.btnCambiarImagen.Text = "Cambiar Imagen";
            this.btnCambiarImagen.UseVisualStyleBackColor = true;
            this.btnCambiarImagen.Click += new System.EventHandler(this.btnCambiarImagen_Click);
            // 
            // frmModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(688, 267);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmModificarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Usuario";
            this.Load += new System.EventHandler(this.frmModificarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.LinkLabel lblBuscar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblIDUsuario;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCambiarImagen;
    }
}