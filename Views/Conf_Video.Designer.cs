namespace Proyecto_PV.Views
{
    partial class Conf_Video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conf_Video));
            this.pnl_Cabecera = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_Pie = new System.Windows.Forms.Panel();
            this.combo_Conect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Select_Cam = new Proyecto_PV.Resources.Botones();
            this.pnl_Cabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Cabecera
            // 
            this.pnl_Cabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.pnl_Cabecera.Controls.Add(this.pictureBox1);
            this.pnl_Cabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Cabecera.Location = new System.Drawing.Point(0, 0);
            this.pnl_Cabecera.Name = "pnl_Cabecera";
            this.pnl_Cabecera.Size = new System.Drawing.Size(300, 102);
            this.pnl_Cabecera.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_Pie
            // 
            this.pnl_Pie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.pnl_Pie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Pie.Location = new System.Drawing.Point(0, 318);
            this.pnl_Pie.Name = "pnl_Pie";
            this.pnl_Pie.Size = new System.Drawing.Size(300, 61);
            this.pnl_Pie.TabIndex = 1;
            // 
            // combo_Conect
            // 
            this.combo_Conect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.combo_Conect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_Conect.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Conect.ForeColor = System.Drawing.Color.White;
            this.combo_Conect.FormattingEnabled = true;
            this.combo_Conect.Location = new System.Drawing.Point(44, 182);
            this.combo_Conect.Name = "combo_Conect";
            this.combo_Conect.Size = new System.Drawing.Size(211, 23);
            this.combo_Conect.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(0, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "CAMARA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Select_Cam
            // 
            this.btn_Select_Cam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.btn_Select_Cam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.btn_Select_Cam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            this.btn_Select_Cam.BorderRadius = 12;
            this.btn_Select_Cam.BorderSize = 0;
            this.btn_Select_Cam.FlatAppearance.BorderSize = 0;
            this.btn_Select_Cam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Select_Cam.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Select_Cam.ForeColor = System.Drawing.Color.White;
            this.btn_Select_Cam.Location = new System.Drawing.Point(76, 232);
            this.btn_Select_Cam.Name = "btn_Select_Cam";
            this.btn_Select_Cam.Size = new System.Drawing.Size(150, 40);
            this.btn_Select_Cam.TabIndex = 6;
            this.btn_Select_Cam.Text = "SELECCIONAR";
            this.btn_Select_Cam.TextColor = System.Drawing.Color.White;
            this.btn_Select_Cam.UseVisualStyleBackColor = false;
            this.btn_Select_Cam.Click += new System.EventHandler(this.btn_Select_Cam_Click);
            // 
            // Conf_Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(300, 379);
            this.Controls.Add(this.btn_Select_Cam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_Conect);
            this.Controls.Add(this.pnl_Pie);
            this.Controls.Add(this.pnl_Cabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 0);
            this.Name = "Conf_Video";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conf_Video";
            this.Load += new System.EventHandler(this.Conf_Video_Load);
            this.pnl_Cabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Cabecera;
        private System.Windows.Forms.Panel pnl_Pie;
        private System.Windows.Forms.ComboBox combo_Conect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Resources.Botones btn_Select_Cam;
    }
}