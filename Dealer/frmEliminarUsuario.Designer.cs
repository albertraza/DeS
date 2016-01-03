namespace Dealer
{
    partial class frmEliminarUsuario
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
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.LinkLabel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(47, 28);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(237, 180);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(59, 229);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(214, 229);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.TabStop = true;
            this.lblBuscar.Text = "Buscar";
            this.lblBuscar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBuscar_LinkClicked);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(108, 226);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(47, 312);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(108, 260);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtIDUsuario.TabIndex = 6;
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.Location = new System.Drawing.Point(44, 263);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(60, 13);
            this.lblIDUsuario.TabIndex = 5;
            this.lblIDUsuario.Text = "ID Usuario:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(209, 312);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmEliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(356, 371);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.lblIDUsuario);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pbImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEliminarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Usuario";
            this.Load += new System.EventHandler(this.frmEliminarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.LinkLabel lblBuscar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Label lblIDUsuario;
        private System.Windows.Forms.Button btnEliminar;
    }
}