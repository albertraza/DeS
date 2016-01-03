namespace Dealer
{
    partial class frmSplash
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblProgreso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-3, 320);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(789, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(786, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(179, 65);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(146, 33);
            this.lblLogo.TabIndex = 2;
            this.lblLogo.Text = "D\'Albert Cars";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(226, 320);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(237, 13);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "Por Favor espere mientras se cargan los datos ...";
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Location = new System.Drawing.Point(459, 320);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(49, 13);
            this.lblProgreso.TabIndex = 4;
            this.lblProgreso.Text = "Progreso";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 342);
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblProgreso;
    }
}

