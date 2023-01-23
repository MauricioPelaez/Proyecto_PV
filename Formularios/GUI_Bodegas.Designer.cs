namespace Proyecto_PV.Formularios
{
    partial class GUI_Bodegas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Bodegas));
            this.pnl_Principal = new System.Windows.Forms.Panel();
            this.pnl_Datos = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new Proyecto_PV.Resources.Botones();
            this.btn_Eliminar = new Proyecto_PV.Resources.Botones();
            this.btn_Actualiazar = new Proyecto_PV.Resources.Botones();
            this.btn_Guardar = new Proyecto_PV.Resources.Botones();
            this.btn_Nuevo = new Proyecto_PV.Resources.Botones();
            this.gb_DatosProv = new System.Windows.Forms.GroupBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_DescripcioBod = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_CodigoBod = new System.Windows.Forms.TextBox();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.pnl_Inferior = new System.Windows.Forms.Panel();
            this.lbl_NRegistros = new System.Windows.Forms.Label();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.DGV_Bodegas = new System.Windows.Forms.DataGridView();
            this.pnl_Cabecera = new System.Windows.Forms.Panel();
            this.btn_Volver = new Proyecto_PV.Resources.Botones();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.img_Logo = new System.Windows.Forms.PictureBox();
            this.pnl_Principal.SuspendLayout();
            this.pnl_Datos.SuspendLayout();
            this.gb_DatosProv.SuspendLayout();
            this.pnl_Inferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bodegas)).BeginInit();
            this.pnl_Cabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Principal
            // 
            this.pnl_Principal.BackColor = System.Drawing.Color.LightGray;
            this.pnl_Principal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Principal.Controls.Add(this.pnl_Datos);
            this.pnl_Principal.Controls.Add(this.pnl_Inferior);
            this.pnl_Principal.Controls.Add(this.pnl_Cabecera);
            this.pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Principal.Location = new System.Drawing.Point(0, 0);
            this.pnl_Principal.Name = "pnl_Principal";
            this.pnl_Principal.Size = new System.Drawing.Size(1000, 600);
            this.pnl_Principal.TabIndex = 0;
            // 
            // pnl_Datos
            // 
            this.pnl_Datos.BackColor = System.Drawing.Color.LightGray;
            this.pnl_Datos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Datos.Controls.Add(this.btn_Cancelar);
            this.pnl_Datos.Controls.Add(this.btn_Eliminar);
            this.pnl_Datos.Controls.Add(this.btn_Actualiazar);
            this.pnl_Datos.Controls.Add(this.btn_Guardar);
            this.pnl_Datos.Controls.Add(this.btn_Nuevo);
            this.pnl_Datos.Controls.Add(this.gb_DatosProv);
            this.pnl_Datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Datos.Location = new System.Drawing.Point(0, 65);
            this.pnl_Datos.Name = "pnl_Datos";
            this.pnl_Datos.Size = new System.Drawing.Size(996, 271);
            this.pnl_Datos.TabIndex = 2;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.btn_Cancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.btn_Cancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Cancelar.BorderRadius = 20;
            this.btn_Cancelar.BorderSize = 0;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(790, 211);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(105, 40);
            this.btn_Cancelar.TabIndex = 86;
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.TextColor = System.Drawing.Color.White;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Eliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Eliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Eliminar.BorderRadius = 20;
            this.btn_Eliminar.BorderSize = 0;
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Location = new System.Drawing.Point(790, 164);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(105, 40);
            this.btn_Eliminar.TabIndex = 85;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.TextColor = System.Drawing.Color.White;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Actualiazar
            // 
            this.btn_Actualiazar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Actualiazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(60)))), ((int)(((byte)(240)))));
            this.btn_Actualiazar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(60)))), ((int)(((byte)(240)))));
            this.btn_Actualiazar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Actualiazar.BorderRadius = 20;
            this.btn_Actualiazar.BorderSize = 0;
            this.btn_Actualiazar.Enabled = false;
            this.btn_Actualiazar.FlatAppearance.BorderSize = 0;
            this.btn_Actualiazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualiazar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualiazar.ForeColor = System.Drawing.Color.White;
            this.btn_Actualiazar.Location = new System.Drawing.Point(790, 117);
            this.btn_Actualiazar.Name = "btn_Actualiazar";
            this.btn_Actualiazar.Size = new System.Drawing.Size(105, 40);
            this.btn_Actualiazar.TabIndex = 84;
            this.btn_Actualiazar.Text = "ACTUALIZAR";
            this.btn_Actualiazar.TextColor = System.Drawing.Color.White;
            this.btn_Actualiazar.UseVisualStyleBackColor = false;
            this.btn_Actualiazar.Click += new System.EventHandler(this.btn_Actualiazar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Guardar.BackColor = System.Drawing.Color.Teal;
            this.btn_Guardar.BackgroundColor = System.Drawing.Color.Teal;
            this.btn_Guardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Guardar.BorderRadius = 20;
            this.btn_Guardar.BorderSize = 0;
            this.btn_Guardar.Enabled = false;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Guardar.Location = new System.Drawing.Point(790, 70);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(105, 40);
            this.btn_Guardar.TabIndex = 83;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.TextColor = System.Drawing.Color.Transparent;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(160)))));
            this.btn_Nuevo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(160)))));
            this.btn_Nuevo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Nuevo.BorderRadius = 20;
            this.btn_Nuevo.BorderSize = 0;
            this.btn_Nuevo.FlatAppearance.BorderSize = 0;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_Nuevo.Location = new System.Drawing.Point(790, 23);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(105, 40);
            this.btn_Nuevo.TabIndex = 82;
            this.btn_Nuevo.Text = "NUEVO";
            this.btn_Nuevo.TextColor = System.Drawing.Color.White;
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // gb_DatosProv
            // 
            this.gb_DatosProv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_DatosProv.BackColor = System.Drawing.Color.LightGray;
            this.gb_DatosProv.Controls.Add(this.lbl_telefono);
            this.gb_DatosProv.Controls.Add(this.txt_DescripcioBod);
            this.gb_DatosProv.Controls.Add(this.lbl_nombre);
            this.gb_DatosProv.Controls.Add(this.txt_CodigoBod);
            this.gb_DatosProv.Controls.Add(this.lbl_Fecha);
            this.gb_DatosProv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_DatosProv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DatosProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.gb_DatosProv.Location = new System.Drawing.Point(95, 21);
            this.gb_DatosProv.Name = "gb_DatosProv";
            this.gb_DatosProv.Size = new System.Drawing.Size(537, 223);
            this.gb_DatosProv.TabIndex = 73;
            this.gb_DatosProv.TabStop = false;
            this.gb_DatosProv.Text = "Datos de la bodega";
            this.gb_DatosProv.Paint += new System.Windows.Forms.PaintEventHandler(this.gb_DatosBod_Paint_1);
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(22, 135);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(83, 15);
            this.lbl_telefono.TabIndex = 76;
            this.lbl_telefono.Text = "DESCRIPCIÓN";
            // 
            // txt_DescripcioBod
            // 
            this.txt_DescripcioBod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_DescripcioBod.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DescripcioBod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_DescripcioBod.Enabled = false;
            this.txt_DescripcioBod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescripcioBod.Location = new System.Drawing.Point(25, 153);
            this.txt_DescripcioBod.Name = "txt_DescripcioBod";
            this.txt_DescripcioBod.Size = new System.Drawing.Size(360, 23);
            this.txt_DescripcioBod.TabIndex = 77;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(22, 58);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(53, 15);
            this.lbl_nombre.TabIndex = 72;
            this.lbl_nombre.Text = "CÓDIGO";
            // 
            // txt_CodigoBod
            // 
            this.txt_CodigoBod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_CodigoBod.BackColor = System.Drawing.SystemColors.Window;
            this.txt_CodigoBod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_CodigoBod.Enabled = false;
            this.txt_CodigoBod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoBod.Location = new System.Drawing.Point(25, 79);
            this.txt_CodigoBod.Name = "txt_CodigoBod";
            this.txt_CodigoBod.Size = new System.Drawing.Size(360, 23);
            this.txt_CodigoBod.TabIndex = 73;
            this.txt_CodigoBod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodigoBod_KeyPress);
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lbl_Fecha.Location = new System.Drawing.Point(432, 36);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(43, 17);
            this.lbl_Fecha.TabIndex = 71;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // pnl_Inferior
            // 
            this.pnl_Inferior.BackColor = System.Drawing.Color.Silver;
            this.pnl_Inferior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Inferior.Controls.Add(this.lbl_NRegistros);
            this.pnl_Inferior.Controls.Add(this.lbl_Buscar);
            this.pnl_Inferior.Controls.Add(this.txt_Buscar);
            this.pnl_Inferior.Controls.Add(this.DGV_Bodegas);
            this.pnl_Inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Inferior.Location = new System.Drawing.Point(0, 336);
            this.pnl_Inferior.Name = "pnl_Inferior";
            this.pnl_Inferior.Size = new System.Drawing.Size(996, 260);
            this.pnl_Inferior.TabIndex = 1;
            // 
            // lbl_NRegistros
            // 
            this.lbl_NRegistros.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_NRegistros.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NRegistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.lbl_NRegistros.Location = new System.Drawing.Point(806, 20);
            this.lbl_NRegistros.Name = "lbl_NRegistros";
            this.lbl_NRegistros.Size = new System.Drawing.Size(150, 23);
            this.lbl_NRegistros.TabIndex = 64;
            this.lbl_NRegistros.Text = "N° registros";
            this.lbl_NRegistros.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.lbl_Buscar.Location = new System.Drawing.Point(28, 25);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(57, 15);
            this.lbl_Buscar.TabIndex = 63;
            this.lbl_Buscar.Text = "BUSCAR:";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Buscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.Location = new System.Drawing.Point(95, 20);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(350, 23);
            this.txt_Buscar.TabIndex = 62;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // DGV_Bodegas
            // 
            this.DGV_Bodegas.AllowUserToAddRows = false;
            this.DGV_Bodegas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DGV_Bodegas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Bodegas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Bodegas.BackgroundColor = System.Drawing.Color.Silver;
            this.DGV_Bodegas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Bodegas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DGV_Bodegas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DGV_Bodegas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Bodegas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Bodegas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Bodegas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGV_Bodegas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DGV_Bodegas.Location = new System.Drawing.Point(31, 53);
            this.DGV_Bodegas.MultiSelect = false;
            this.DGV_Bodegas.Name = "DGV_Bodegas";
            this.DGV_Bodegas.ReadOnly = true;
            this.DGV_Bodegas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_Bodegas.RowHeadersWidth = 25;
            this.DGV_Bodegas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_Bodegas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Bodegas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Bodegas.Size = new System.Drawing.Size(925, 178);
            this.DGV_Bodegas.TabIndex = 61;
            this.DGV_Bodegas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Bodegas_CellClick);
            // 
            // pnl_Cabecera
            // 
            this.pnl_Cabecera.BackColor = System.Drawing.Color.Silver;
            this.pnl_Cabecera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Cabecera.Controls.Add(this.img_Logo);
            this.pnl_Cabecera.Controls.Add(this.btn_Volver);
            this.pnl_Cabecera.Controls.Add(this.lbl_Titulo);
            this.pnl_Cabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Cabecera.Location = new System.Drawing.Point(0, 0);
            this.pnl_Cabecera.Name = "pnl_Cabecera";
            this.pnl_Cabecera.Size = new System.Drawing.Size(996, 65);
            this.pnl_Cabecera.TabIndex = 0;
            // 
            // btn_Volver
            // 
            this.btn_Volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.btn_Volver.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.btn_Volver.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Volver.BorderRadius = 20;
            this.btn_Volver.BorderSize = 0;
            this.btn_Volver.FlatAppearance.BorderSize = 0;
            this.btn_Volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.ForeColor = System.Drawing.Color.White;
            this.btn_Volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Volver.Location = new System.Drawing.Point(854, 13);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(99, 39);
            this.btn_Volver.TabIndex = 35;
            this.btn_Volver.Text = "VOLVER";
            this.btn_Volver.TextColor = System.Drawing.Color.White;
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(-2, 13);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(996, 34);
            this.lbl_Titulo.TabIndex = 34;
            this.lbl_Titulo.Text = "BODEGAS";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // img_Logo
            // 
            this.img_Logo.Image = ((System.Drawing.Image)(resources.GetObject("img_Logo.Image")));
            this.img_Logo.Location = new System.Drawing.Point(28, 7);
            this.img_Logo.Name = "img_Logo";
            this.img_Logo.Size = new System.Drawing.Size(57, 50);
            this.img_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Logo.TabIndex = 37;
            this.img_Logo.TabStop = false;
            // 
            // GUI_Bodegas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnl_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_Bodegas";
            this.Text = "GUI_Bodegas";
            this.Load += new System.EventHandler(this.GUI_Bodegas_Load);
            this.pnl_Principal.ResumeLayout(false);
            this.pnl_Datos.ResumeLayout(false);
            this.gb_DatosProv.ResumeLayout(false);
            this.gb_DatosProv.PerformLayout();
            this.pnl_Inferior.ResumeLayout(false);
            this.pnl_Inferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bodegas)).EndInit();
            this.pnl_Cabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Principal;
        private System.Windows.Forms.Panel pnl_Cabecera;
        private System.Windows.Forms.Panel pnl_Inferior;
        private System.Windows.Forms.Panel pnl_Datos;
        private System.Windows.Forms.Label lbl_Titulo;
        private Resources.Botones btn_Volver;
        private System.Windows.Forms.DataGridView DGV_Bodegas;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.GroupBox gb_DatosProv;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_CodigoBod;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_DescripcioBod;
        private Resources.Botones btn_Cancelar;
        private Resources.Botones btn_Eliminar;
        private Resources.Botones btn_Actualiazar;
        private Resources.Botones btn_Guardar;
        private Resources.Botones btn_Nuevo;
        private System.Windows.Forms.Label lbl_NRegistros;
        private System.Windows.Forms.PictureBox img_Logo;
    }
}