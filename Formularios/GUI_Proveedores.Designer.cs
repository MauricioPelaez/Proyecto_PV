namespace Proyecto_PV.Formularios
{
    partial class GUI_Proveedores
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
            this.pnl_Principal = new System.Windows.Forms.Panel();
            this.pnl_Datos = new System.Windows.Forms.Panel();
            this.gb_DatosProv = new System.Windows.Forms.GroupBox();
            this.lbl_funcion = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_TelefonoProv = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_EmailProv = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_NombreProv = new System.Windows.Forms.TextBox();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.combo_FuncionProv = new System.Windows.Forms.ComboBox();
            this.lbl_nit = new System.Windows.Forms.Label();
            this.txt_Nit = new System.Windows.Forms.TextBox();
            this.pnl_Inferior = new System.Windows.Forms.Panel();
            this.DGV_Proveedores = new System.Windows.Forms.DataGridView();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.pnl_Cabecera = new System.Windows.Forms.Panel();
            this.img_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_NRegistros = new System.Windows.Forms.Label();
            this.btn_Cancelar = new Proyecto_PV.Resources.Botones();
            this.btn_Eliminar = new Proyecto_PV.Resources.Botones();
            this.btn_Actualiazar = new Proyecto_PV.Resources.Botones();
            this.btn_Guardar = new Proyecto_PV.Resources.Botones();
            this.btn_Nuevo = new Proyecto_PV.Resources.Botones();
            this.btn_Volver = new Proyecto_PV.Resources.Botones();
            this.pnl_Principal.SuspendLayout();
            this.pnl_Datos.SuspendLayout();
            this.gb_DatosProv.SuspendLayout();
            this.pnl_Inferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Proveedores)).BeginInit();
            this.pnl_Cabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Principal
            // 
            this.pnl_Principal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Principal.Controls.Add(this.pnl_Datos);
            this.pnl_Principal.Controls.Add(this.pnl_Inferior);
            this.pnl_Principal.Controls.Add(this.pnl_Cabecera);
            this.pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Principal.Location = new System.Drawing.Point(0, 0);
            this.pnl_Principal.Name = "pnl_Principal";
            this.pnl_Principal.Size = new System.Drawing.Size(884, 600);
            this.pnl_Principal.TabIndex = 1;
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
            this.pnl_Datos.Size = new System.Drawing.Size(880, 271);
            this.pnl_Datos.TabIndex = 2;
            // 
            // gb_DatosProv
            // 
            this.gb_DatosProv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_DatosProv.BackColor = System.Drawing.Color.LightGray;
            this.gb_DatosProv.Controls.Add(this.lbl_funcion);
            this.gb_DatosProv.Controls.Add(this.lbl_telefono);
            this.gb_DatosProv.Controls.Add(this.txt_TelefonoProv);
            this.gb_DatosProv.Controls.Add(this.lbl_email);
            this.gb_DatosProv.Controls.Add(this.txt_EmailProv);
            this.gb_DatosProv.Controls.Add(this.lbl_nombre);
            this.gb_DatosProv.Controls.Add(this.txt_NombreProv);
            this.gb_DatosProv.Controls.Add(this.lbl_Fecha);
            this.gb_DatosProv.Controls.Add(this.combo_FuncionProv);
            this.gb_DatosProv.Controls.Add(this.lbl_nit);
            this.gb_DatosProv.Controls.Add(this.txt_Nit);
            this.gb_DatosProv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_DatosProv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DatosProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.gb_DatosProv.Location = new System.Drawing.Point(35, 23);
            this.gb_DatosProv.Name = "gb_DatosProv";
            this.gb_DatosProv.Size = new System.Drawing.Size(665, 223);
            this.gb_DatosProv.TabIndex = 72;
            this.gb_DatosProv.TabStop = false;
            this.gb_DatosProv.Text = "Datos del proveedor";
            this.gb_DatosProv.Paint += new System.Windows.Forms.PaintEventHandler(this.gb_DatosProv_Paint);
            // 
            // lbl_funcion
            // 
            this.lbl_funcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_funcion.AutoSize = true;
            this.lbl_funcion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_funcion.Location = new System.Drawing.Point(356, 152);
            this.lbl_funcion.Name = "lbl_funcion";
            this.lbl_funcion.Size = new System.Drawing.Size(59, 15);
            this.lbl_funcion.TabIndex = 78;
            this.lbl_funcion.Text = "FUNCIÓN";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(21, 152);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(65, 15);
            this.lbl_telefono.TabIndex = 76;
            this.lbl_telefono.Text = "TELÉFONO";
            // 
            // txt_TelefonoProv
            // 
            this.txt_TelefonoProv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_TelefonoProv.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TelefonoProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_TelefonoProv.Enabled = false;
            this.txt_TelefonoProv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TelefonoProv.Location = new System.Drawing.Point(24, 170);
            this.txt_TelefonoProv.Name = "txt_TelefonoProv";
            this.txt_TelefonoProv.Size = new System.Drawing.Size(280, 23);
            this.txt_TelefonoProv.TabIndex = 77;
            this.txt_TelefonoProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TelefonoProv_KeyPress);
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(356, 96);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(47, 15);
            this.lbl_email.TabIndex = 74;
            this.lbl_email.Text = "E-MAIL";
            // 
            // txt_EmailProv
            // 
            this.txt_EmailProv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_EmailProv.BackColor = System.Drawing.SystemColors.Window;
            this.txt_EmailProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_EmailProv.Enabled = false;
            this.txt_EmailProv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmailProv.Location = new System.Drawing.Point(359, 114);
            this.txt_EmailProv.Name = "txt_EmailProv";
            this.txt_EmailProv.Size = new System.Drawing.Size(280, 23);
            this.txt_EmailProv.TabIndex = 75;
            this.txt_EmailProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_EmailProv_KeyPress);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(21, 96);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(56, 15);
            this.lbl_nombre.TabIndex = 72;
            this.lbl_nombre.Text = "NOMBRE";
            // 
            // txt_NombreProv
            // 
            this.txt_NombreProv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_NombreProv.BackColor = System.Drawing.SystemColors.Window;
            this.txt_NombreProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NombreProv.Enabled = false;
            this.txt_NombreProv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreProv.Location = new System.Drawing.Point(24, 114);
            this.txt_NombreProv.Name = "txt_NombreProv";
            this.txt_NombreProv.Size = new System.Drawing.Size(280, 23);
            this.txt_NombreProv.TabIndex = 73;
            this.txt_NombreProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreProv_KeyPress);
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lbl_Fecha.Location = new System.Drawing.Point(569, 58);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(43, 17);
            this.lbl_Fecha.TabIndex = 71;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // combo_FuncionProv
            // 
            this.combo_FuncionProv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combo_FuncionProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_FuncionProv.Enabled = false;
            this.combo_FuncionProv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_FuncionProv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_FuncionProv.FormattingEnabled = true;
            this.combo_FuncionProv.Items.AddRange(new object[] {
            "SELECCIONE...",
            "PROVEEDOR DE PRODUCTOS",
            "PROVEEDOR DE SERVICIOS"});
            this.combo_FuncionProv.Location = new System.Drawing.Point(359, 170);
            this.combo_FuncionProv.Name = "combo_FuncionProv";
            this.combo_FuncionProv.Size = new System.Drawing.Size(280, 23);
            this.combo_FuncionProv.TabIndex = 68;
            // 
            // lbl_nit
            // 
            this.lbl_nit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_nit.AutoSize = true;
            this.lbl_nit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nit.Location = new System.Drawing.Point(21, 40);
            this.lbl_nit.Name = "lbl_nit";
            this.lbl_nit.Size = new System.Drawing.Size(76, 15);
            this.lbl_nit.TabIndex = 51;
            this.lbl_nit.Text = "NIT/CÉDULA";
            // 
            // txt_Nit
            // 
            this.txt_Nit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Nit.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Nit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Nit.Enabled = false;
            this.txt_Nit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nit.Location = new System.Drawing.Point(24, 58);
            this.txt_Nit.Name = "txt_Nit";
            this.txt_Nit.Size = new System.Drawing.Size(280, 23);
            this.txt_Nit.TabIndex = 52;
            this.txt_Nit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nit_KeyPress);
            // 
            // pnl_Inferior
            // 
            this.pnl_Inferior.BackColor = System.Drawing.Color.Silver;
            this.pnl_Inferior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Inferior.Controls.Add(this.lbl_NRegistros);
            this.pnl_Inferior.Controls.Add(this.DGV_Proveedores);
            this.pnl_Inferior.Controls.Add(this.lbl_Buscar);
            this.pnl_Inferior.Controls.Add(this.txt_Buscar);
            this.pnl_Inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Inferior.Location = new System.Drawing.Point(0, 336);
            this.pnl_Inferior.Name = "pnl_Inferior";
            this.pnl_Inferior.Size = new System.Drawing.Size(880, 260);
            this.pnl_Inferior.TabIndex = 1;
            // 
            // DGV_Proveedores
            // 
            this.DGV_Proveedores.AllowUserToAddRows = false;
            this.DGV_Proveedores.AllowUserToDeleteRows = false;
            this.DGV_Proveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Proveedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Proveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DGV_Proveedores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DGV_Proveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Proveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Proveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGV_Proveedores.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DGV_Proveedores.Location = new System.Drawing.Point(35, 58);
            this.DGV_Proveedores.MultiSelect = false;
            this.DGV_Proveedores.Name = "DGV_Proveedores";
            this.DGV_Proveedores.ReadOnly = true;
            this.DGV_Proveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_Proveedores.RowHeadersWidth = 25;
            this.DGV_Proveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_Proveedores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Proveedores.Size = new System.Drawing.Size(809, 178);
            this.DGV_Proveedores.TabIndex = 60;
            this.DGV_Proveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Proveedores_CellClick);
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.lbl_Buscar.Location = new System.Drawing.Point(32, 25);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(57, 15);
            this.lbl_Buscar.TabIndex = 59;
            this.lbl_Buscar.Text = "BUSCAR:";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Buscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.Location = new System.Drawing.Point(95, 20);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(350, 23);
            this.txt_Buscar.TabIndex = 58;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged_1);
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
            this.pnl_Cabecera.Size = new System.Drawing.Size(880, 65);
            this.pnl_Cabecera.TabIndex = 0;
            // 
            // img_Logo
            // 
            this.img_Logo.Image = global::Proyecto_PV.Properties.Resources.Proveedores;
            this.img_Logo.Location = new System.Drawing.Point(28, 6);
            this.img_Logo.Name = "img_Logo";
            this.img_Logo.Size = new System.Drawing.Size(57, 50);
            this.img_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Logo.TabIndex = 34;
            this.img_Logo.TabStop = false;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(1, 16);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(879, 34);
            this.lbl_Titulo.TabIndex = 33;
            this.lbl_Titulo.Text = "PROVEEDORES";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NRegistros
            // 
            this.lbl_NRegistros.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_NRegistros.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NRegistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.lbl_NRegistros.Location = new System.Drawing.Point(694, 20);
            this.lbl_NRegistros.Name = "lbl_NRegistros";
            this.lbl_NRegistros.Size = new System.Drawing.Size(150, 23);
            this.lbl_NRegistros.TabIndex = 65;
            this.lbl_NRegistros.Text = "N° registros";
            this.lbl_NRegistros.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            this.btn_Cancelar.Location = new System.Drawing.Point(732, 213);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(105, 40);
            this.btn_Cancelar.TabIndex = 81;
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
            this.btn_Eliminar.Location = new System.Drawing.Point(732, 166);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(105, 40);
            this.btn_Eliminar.TabIndex = 80;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.TextColor = System.Drawing.Color.White;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click_1);
            // 
            // btn_Actualiazar
            // 
            this.btn_Actualiazar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Actualiazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.btn_Actualiazar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.btn_Actualiazar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Actualiazar.BorderRadius = 20;
            this.btn_Actualiazar.BorderSize = 0;
            this.btn_Actualiazar.Enabled = false;
            this.btn_Actualiazar.FlatAppearance.BorderSize = 0;
            this.btn_Actualiazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualiazar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualiazar.ForeColor = System.Drawing.Color.White;
            this.btn_Actualiazar.Location = new System.Drawing.Point(732, 119);
            this.btn_Actualiazar.Name = "btn_Actualiazar";
            this.btn_Actualiazar.Size = new System.Drawing.Size(105, 40);
            this.btn_Actualiazar.TabIndex = 79;
            this.btn_Actualiazar.Text = "ACTUALIZAR";
            this.btn_Actualiazar.TextColor = System.Drawing.Color.White;
            this.btn_Actualiazar.UseVisualStyleBackColor = false;
            this.btn_Actualiazar.Click += new System.EventHandler(this.btn_Actualiazar_Click_1);
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
            this.btn_Guardar.Location = new System.Drawing.Point(732, 72);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(105, 40);
            this.btn_Guardar.TabIndex = 78;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.TextColor = System.Drawing.Color.Transparent;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click_1);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.btn_Nuevo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.btn_Nuevo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Nuevo.BorderRadius = 20;
            this.btn_Nuevo.BorderSize = 0;
            this.btn_Nuevo.FlatAppearance.BorderSize = 0;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_Nuevo.Location = new System.Drawing.Point(732, 25);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(105, 40);
            this.btn_Nuevo.TabIndex = 77;
            this.btn_Nuevo.Text = "NUEVO";
            this.btn_Nuevo.TextColor = System.Drawing.Color.White;
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click_1);
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
            this.btn_Volver.Location = new System.Drawing.Point(738, 13);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(99, 39);
            this.btn_Volver.TabIndex = 0;
            this.btn_Volver.Text = "VOLVER";
            this.btn_Volver.TextColor = System.Drawing.Color.White;
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // GUI_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(884, 600);
            this.Controls.Add(this.pnl_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.GUI_Proveedores_Load);
            this.pnl_Principal.ResumeLayout(false);
            this.pnl_Datos.ResumeLayout(false);
            this.gb_DatosProv.ResumeLayout(false);
            this.gb_DatosProv.PerformLayout();
            this.pnl_Inferior.ResumeLayout(false);
            this.pnl_Inferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Proveedores)).EndInit();
            this.pnl_Cabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Resources.Botones btn_Volver;
        private System.Windows.Forms.Panel pnl_Principal;
        private System.Windows.Forms.Panel pnl_Cabecera;
        private System.Windows.Forms.Panel pnl_Inferior;
        private System.Windows.Forms.Panel pnl_Datos;
        private System.Windows.Forms.DataGridView DGV_Proveedores;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.GroupBox gb_DatosProv;
        private System.Windows.Forms.Label lbl_funcion;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_TelefonoProv;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_EmailProv;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_NombreProv;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.ComboBox combo_FuncionProv;
        private System.Windows.Forms.Label lbl_nit;
        private System.Windows.Forms.TextBox txt_Nit;
        private Resources.Botones btn_Cancelar;
        private Resources.Botones btn_Eliminar;
        private Resources.Botones btn_Actualiazar;
        private Resources.Botones btn_Guardar;
        private Resources.Botones btn_Nuevo;
        private System.Windows.Forms.PictureBox img_Logo;
        private System.Windows.Forms.Label lbl_NRegistros;
    }
}