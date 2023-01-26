namespace Proyecto_PV.Views
{
    partial class Camara
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
            this.Img_Camara = new System.Windows.Forms.PictureBox();
            this.combo_Cenecciones = new System.Windows.Forms.ComboBox();
            this.btn_Cerrar = new Proyecto_PV.Resources.Botones();
            this.botones1 = new Proyecto_PV.Resources.Botones();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Camara)).BeginInit();
            this.SuspendLayout();
            // 
            // Img_Camara
            // 
            this.Img_Camara.Location = new System.Drawing.Point(29, 64);
            this.Img_Camara.Name = "Img_Camara";
            this.Img_Camara.Size = new System.Drawing.Size(410, 346);
            this.Img_Camara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_Camara.TabIndex = 0;
            this.Img_Camara.TabStop = false;
            // 
            // combo_Cenecciones
            // 
            this.combo_Cenecciones.FormattingEnabled = true;
            this.combo_Cenecciones.Location = new System.Drawing.Point(29, 22);
            this.combo_Cenecciones.Name = "combo_Cenecciones";
            this.combo_Cenecciones.Size = new System.Drawing.Size(346, 21);
            this.combo_Cenecciones.TabIndex = 2;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.Red;
            this.btn_Cerrar.BackgroundColor = System.Drawing.Color.Red;
            this.btn_Cerrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            this.btn_Cerrar.BorderRadius = 20;
            this.btn_Cerrar.BorderSize = 0;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_Cerrar.Location = new System.Drawing.Point(486, 305);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(93, 40);
            this.btn_Cerrar.TabIndex = 3;
            this.btn_Cerrar.Text = "CERRAR";
            this.btn_Cerrar.TextColor = System.Drawing.Color.White;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // botones1
            // 
            this.botones1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botones1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botones1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            this.botones1.BorderRadius = 20;
            this.botones1.BorderSize = 0;
            this.botones1.FlatAppearance.BorderSize = 0;
            this.botones1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botones1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botones1.ForeColor = System.Drawing.Color.White;
            this.botones1.Location = new System.Drawing.Point(461, 221);
            this.botones1.Name = "botones1";
            this.botones1.Size = new System.Drawing.Size(150, 40);
            this.botones1.TabIndex = 1;
            this.botones1.Text = "CONECTAR";
            this.botones1.TextColor = System.Drawing.Color.White;
            this.botones1.UseVisualStyleBackColor = false;
            this.botones1.Click += new System.EventHandler(this.botones1_Click);
            // 
            // Camara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.combo_Cenecciones);
            this.Controls.Add(this.botones1);
            this.Controls.Add(this.Img_Camara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Camara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camara";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Camara_FormClosed);
            this.Load += new System.EventHandler(this.Camara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img_Camara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Img_Camara;
        private Resources.Botones botones1;
        private System.Windows.Forms.ComboBox combo_Cenecciones;
        private Resources.Botones btn_Cerrar;
    }
}