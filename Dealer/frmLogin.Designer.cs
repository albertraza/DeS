namespace Dealer
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblCLave = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.Location = new System.Drawing.Point(236, 67);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(60, 13);
            this.lblIDUsuario.TabIndex = 1;
            this.lblIDUsuario.Text = "ID Usuario:";
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(302, 64);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtIDUsuario.TabIndex = 2;
            this.txtIDUsuario.TextChanged += new System.EventHandler(this.txtIDUsuario_TextChanged);
            this.txtIDUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDUsuario_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(239, 196);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 32);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(302, 125);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 5;
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            // 
            // lblCLave
            // 
            this.lblCLave.AutoSize = true;
            this.lblCLave.Location = new System.Drawing.Point(259, 128);
            this.lblCLave.Name = "lblCLave";
            this.lblCLave.Size = new System.Drawing.Size(37, 13);
            this.lblCLave.TabIndex = 4;
            this.lblCLave.Text = "Clave:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(343, 196);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 32);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(440, 261);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblCLave);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.lblIDUsuario);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIDUsuario;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblCLave;
        private System.Windows.Forms.Button btnCancelar;
    }
}