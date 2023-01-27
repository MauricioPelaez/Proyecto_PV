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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Camara));
            this.combo_Conect = new System.Windows.Forms.ComboBox();
            this.lbl_Confirm = new System.Windows.Forms.Label();
            this.pnl_Pie = new System.Windows.Forms.Panel();
            this.Img_1 = new AForge.Controls.PictureBox();
            this.Img_2 = new AForge.Controls.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.btn_Cerrar = new Proyecto_PV.Resources.Botones();
            this.tmr_Seg = new System.Windows.Forms.Timer(this.components);
            this.lbl_Time = new System.Windows.Forms.Label();
            this.btn_Save = new Proyecto_PV.Resources.Botones();
            this.btn_Capture = new Proyecto_PV.Resources.Botones();
            this.lbl_Nombre_User = new System.Windows.Forms.Label();
            this.lbl_Tipo_user = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Img_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_Conect
            // 
            this.combo_Conect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.combo_Conect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_Conect.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Conect.ForeColor = System.Drawing.Color.White;
            this.combo_Conect.FormattingEnabled = true;
            this.combo_Conect.Location = new System.Drawing.Point(26, 77);
            this.combo_Conect.Name = "combo_Conect";
            this.combo_Conect.Size = new System.Drawing.Size(244, 23);
            this.combo_Conect.TabIndex = 2;
            this.combo_Conect.Visible = false;
            // 
            // lbl_Confirm
            // 
            this.lbl_Confirm.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_Confirm.Location = new System.Drawing.Point(266, 20);
            this.lbl_Confirm.Name = "lbl_Confirm";
            this.lbl_Confirm.Size = new System.Drawing.Size(180, 22);
            this.lbl_Confirm.TabIndex = 9;
            this.lbl_Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Pie
            // 
            this.pnl_Pie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.pnl_Pie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Pie.Location = new System.Drawing.Point(0, 400);
            this.pnl_Pie.Name = "pnl_Pie";
            this.pnl_Pie.Size = new System.Drawing.Size(680, 50);
            this.pnl_Pie.TabIndex = 10;
            // 
            // Img_1
            // 
            this.Img_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.Img_1.Image = ((System.Drawing.Image)(resources.GetObject("Img_1.Image")));
            this.Img_1.Location = new System.Drawing.Point(26, 137);
            this.Img_1.Name = "Img_1";
            this.Img_1.Size = new System.Drawing.Size(400, 225);
            this.Img_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_1.TabIndex = 11;
            this.Img_1.TabStop = false;
            // 
            // Img_2
            // 
            this.Img_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.Img_2.Image = ((System.Drawing.Image)(resources.GetObject("Img_2.Image")));
            this.Img_2.Location = new System.Drawing.Point(469, 213);
            this.Img_2.Name = "Img_2";
            this.Img_2.Size = new System.Drawing.Size(180, 100);
            this.Img_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_2.TabIndex = 12;
            this.Img_2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.lbl_Confirm);
            this.panel1.Controls.Add(this.lbl_Hora);
            this.panel1.Controls.Add(this.btn_Cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 51);
            this.panel1.TabIndex = 13;
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_Hora.Location = new System.Drawing.Point(23, 14);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(183, 23);
            this.lbl_Hora.TabIndex = 11;
            this.lbl_Hora.Text = "Hora";
            this.lbl_Hora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btn_Cerrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btn_Cerrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            this.btn_Cerrar.BorderRadius = 6;
            this.btn_Cerrar.BorderSize = 0;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(633, 12);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(35, 28);
            this.btn_Cerrar.TabIndex = 3;
            this.btn_Cerrar.TextColor = System.Drawing.Color.White;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Visible = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // tmr_Seg
            // 
            this.tmr_Seg.Enabled = true;
            this.tmr_Seg.Tick += new System.EventHandler(this.tmr_Seg_Tick);
            // 
            // lbl_Time
            // 
            this.lbl_Time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Time.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.ForeColor = System.Drawing.Color.White;
            this.lbl_Time.Location = new System.Drawing.Point(490, 54);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(141, 80);
            this.lbl_Time.TabIndex = 16;
            this.lbl_Time.Text = "7";
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.btn_Save.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.btn_Save.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            this.btn_Save.BorderRadius = 15;
            this.btn_Save.BorderSize = 0;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(490, 322);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(141, 40);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "GUARDAR";
            this.btn_Save.TextColor = System.Drawing.Color.White;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Capture
            // 
            this.btn_Capture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.btn_Capture.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.btn_Capture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            this.btn_Capture.BorderRadius = 15;
            this.btn_Capture.BorderSize = 0;
            this.btn_Capture.FlatAppearance.BorderSize = 0;
            this.btn_Capture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btn_Capture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Capture.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Capture.ForeColor = System.Drawing.Color.White;
            this.btn_Capture.Location = new System.Drawing.Point(326, 77);
            this.btn_Capture.Name = "btn_Capture";
            this.btn_Capture.Size = new System.Drawing.Size(91, 40);
            this.btn_Capture.TabIndex = 7;
            this.btn_Capture.Text = "FOTO";
            this.btn_Capture.TextColor = System.Drawing.Color.White;
            this.btn_Capture.UseVisualStyleBackColor = false;
            this.btn_Capture.Visible = false;
            // 
            // lbl_Nombre_User
            // 
            this.lbl_Nombre_User.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre_User.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_Nombre_User.Location = new System.Drawing.Point(469, 156);
            this.lbl_Nombre_User.Name = "lbl_Nombre_User";
            this.lbl_Nombre_User.Size = new System.Drawing.Size(180, 17);
            this.lbl_Nombre_User.TabIndex = 17;
            this.lbl_Nombre_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Tipo_user
            // 
            this.lbl_Tipo_user.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tipo_user.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_Tipo_user.Location = new System.Drawing.Point(469, 181);
            this.lbl_Tipo_user.Name = "lbl_Tipo_user";
            this.lbl_Tipo_user.Size = new System.Drawing.Size(180, 17);
            this.lbl_Tipo_user.TabIndex = 18;
            this.lbl_Tipo_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Camara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.lbl_Tipo_user);
            this.Controls.Add(this.lbl_Nombre_User);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.combo_Conect);
            this.Controls.Add(this.Img_2);
            this.Controls.Add(this.Img_1);
            this.Controls.Add(this.pnl_Pie);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Capture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Camara";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camara";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Camara_FormClosing);
            this.Load += new System.EventHandler(this.Camara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox combo_Conect;
        private Resources.Botones btn_Cerrar;
        private Resources.Botones btn_Capture;
        private Resources.Botones btn_Save;
        private System.Windows.Forms.Label lbl_Confirm;
        private System.Windows.Forms.Panel pnl_Pie;
        private AForge.Controls.PictureBox Img_1;
        private AForge.Controls.PictureBox Img_2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmr_Seg;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_Nombre_User;
        private System.Windows.Forms.Label lbl_Tipo_user;
    }
}