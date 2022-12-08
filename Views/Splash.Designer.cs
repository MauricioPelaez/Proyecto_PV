namespace Proyecto_PV
{
    partial class Splash
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.barra_Progreso = new System.Windows.Forms.ProgressBar();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.lbl_Carga = new System.Windows.Forms.Label();
            this.img_Splash = new System.Windows.Forms.PictureBox();
            this.pnl_Splash = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.img_Splash)).BeginInit();
            this.pnl_Splash.SuspendLayout();
            this.SuspendLayout();
            // 
            // barra_Progreso
            // 
            this.barra_Progreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.barra_Progreso.ForeColor = System.Drawing.Color.Transparent;
            this.barra_Progreso.Location = new System.Drawing.Point(0, 251);
            this.barra_Progreso.Name = "barra_Progreso";
            this.barra_Progreso.Size = new System.Drawing.Size(742, 17);
            this.barra_Progreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barra_Progreso.TabIndex = 1;
            // 
            // temporizador
            // 
            this.temporizador.Enabled = true;
            this.temporizador.Interval = 20;
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // lbl_Carga
            // 
            this.lbl_Carga.AutoSize = true;
            this.lbl_Carga.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Carga.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Carga.Location = new System.Drawing.Point(0, 229);
            this.lbl_Carga.Name = "lbl_Carga";
            this.lbl_Carga.Size = new System.Drawing.Size(45, 19);
            this.lbl_Carga.TabIndex = 2;
            this.lbl_Carga.Text = "label1";
            // 
            // img_Splash
            // 
            this.img_Splash.Image = ((System.Drawing.Image)(resources.GetObject("img_Splash.Image")));
            this.img_Splash.Location = new System.Drawing.Point(0, 0);
            this.img_Splash.Name = "img_Splash";
            this.img_Splash.Size = new System.Drawing.Size(560, 224);
            this.img_Splash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Splash.TabIndex = 0;
            this.img_Splash.TabStop = false;
            // 
            // pnl_Splash
            // 
            this.pnl_Splash.Controls.Add(this.lbl_Carga);
            this.pnl_Splash.Controls.Add(this.barra_Progreso);
            this.pnl_Splash.Controls.Add(this.img_Splash);
            this.pnl_Splash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Splash.Location = new System.Drawing.Point(0, 0);
            this.pnl_Splash.Name = "pnl_Splash";
            this.pnl_Splash.Size = new System.Drawing.Size(560, 274);
            this.pnl_Splash.TabIndex = 3;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(560, 274);
            this.Controls.Add(this.pnl_Splash);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPLASH";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            ((System.ComponentModel.ISupportInitialize)(this.img_Splash)).EndInit();
            this.pnl_Splash.ResumeLayout(false);
            this.pnl_Splash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_Splash;
        private System.Windows.Forms.ProgressBar barra_Progreso;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.Label lbl_Carga;
        private System.Windows.Forms.Panel pnl_Splash;
    }
}

