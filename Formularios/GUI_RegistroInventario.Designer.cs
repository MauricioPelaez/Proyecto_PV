namespace Proyecto_PV.Formularios
{
    partial class GUI_RegistroInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_RegistroInventario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Cabecera = new System.Windows.Forms.Panel();
            this.img_Logo = new System.Windows.Forms.PictureBox();
            this.btn_Volver = new Proyecto_PV.Resources.Botones();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pnl_Principal = new System.Windows.Forms.Panel();
            this.pnl_Datos = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new Proyecto_PV.Resources.Botones();
            this.btn_Eliminar = new Proyecto_PV.Resources.Botones();
            this.btn_Actualizar = new Proyecto_PV.Resources.Botones();
            this.btn_Guardar = new Proyecto_PV.Resources.Botones();
            this.btn_Nuevo = new Proyecto_PV.Resources.Botones();
            this.gb_DetallesProd = new System.Windows.Forms.GroupBox();
            this.txt_Stock = new System.Windows.Forms.Label();
            this.txt_Ganancia = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.combo_Descuento = new System.Windows.Forms.ComboBox();
            this.lbl_Descuento = new System.Windows.Forms.Label();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.txt_Descripción = new System.Windows.Forms.TextBox();
            this.lbl_Bodega = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.combo_Proveedor = new System.Windows.Forms.ComboBox();
            this.lbl_Ganacia = new System.Windows.Forms.Label();
            this.txt_ValVenta = new System.Windows.Forms.TextBox();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.lbl_VVenta = new System.Windows.Forms.Label();
            this.lbl_Provee = new System.Windows.Forms.Label();
            this.txt_ValCompra = new System.Windows.Forms.TextBox();
            this.lbl_VCompra = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.combo_Bodega = new System.Windows.Forms.ComboBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.pnl_Inferior = new System.Windows.Forms.Panel();
            this.txt_Total_Ganancias = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Total_Valor_Venta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Total_Valor_Compra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_NRegistros = new System.Windows.Forms.Label();
            this.DGV_Productos = new System.Windows.Forms.DataGridView();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.pnl_Cabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Logo)).BeginInit();
            this.pnl_Principal.SuspendLayout();
            this.pnl_Datos.SuspendLayout();
            this.gb_DetallesProd.SuspendLayout();
            this.pnl_Inferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Productos)).BeginInit();
            this.SuspendLayout();
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
            this.pnl_Cabecera.TabIndex = 26;
            // 
            // img_Logo
            // 
            this.img_Logo.Image = ((System.Drawing.Image)(resources.GetObject("img_Logo.Image")));
            this.img_Logo.Location = new System.Drawing.Point(28, 7);
            this.img_Logo.Name = "img_Logo";
            this.img_Logo.Size = new System.Drawing.Size(57, 50);
            this.img_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Logo.TabIndex = 33;
            this.img_Logo.TabStop = false;
            // 
            // btn_Volver
            // 
            this.btn_Volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.btn_Volver.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.btn_Volver.BorderColor = System.Drawing.Color.Empty;
            this.btn_Volver.BorderRadius = 20;
            this.btn_Volver.BorderSize = 0;
            this.btn_Volver.FlatAppearance.BorderSize = 0;
            this.btn_Volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.ForeColor = System.Drawing.Color.White;
            this.btn_Volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Volver.Location = new System.Drawing.Point(857, 13);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(99, 39);
            this.btn_Volver.TabIndex = 31;
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
            this.lbl_Titulo.Size = new System.Drawing.Size(996, 39);
            this.lbl_Titulo.TabIndex = 32;
            this.lbl_Titulo.Text = "REGISTRO DE PRODUCTOS";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Principal
            // 
            this.pnl_Principal.BackColor = System.Drawing.Color.LightGray;
            this.pnl_Principal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Principal.Controls.Add(this.pnl_Datos);
            this.pnl_Principal.Controls.Add(this.pnl_Cabecera);
            this.pnl_Principal.Controls.Add(this.pnl_Inferior);
            this.pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Principal.Location = new System.Drawing.Point(0, 0);
            this.pnl_Principal.Name = "pnl_Principal";
            this.pnl_Principal.Size = new System.Drawing.Size(1000, 600);
            this.pnl_Principal.TabIndex = 28;
            // 
            // pnl_Datos
            // 
            this.pnl_Datos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Datos.Controls.Add(this.btn_Cancelar);
            this.pnl_Datos.Controls.Add(this.btn_Eliminar);
            this.pnl_Datos.Controls.Add(this.btn_Actualizar);
            this.pnl_Datos.Controls.Add(this.btn_Guardar);
            this.pnl_Datos.Controls.Add(this.btn_Nuevo);
            this.pnl_Datos.Controls.Add(this.gb_DetallesProd);
            this.pnl_Datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Datos.Location = new System.Drawing.Point(0, 65);
            this.pnl_Datos.Name = "pnl_Datos";
            this.pnl_Datos.Size = new System.Drawing.Size(996, 271);
            this.pnl_Datos.TabIndex = 28;
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
            this.btn_Cancelar.Location = new System.Drawing.Point(798, 212);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(105, 40);
            this.btn_Cancelar.TabIndex = 76;
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
            this.btn_Eliminar.Location = new System.Drawing.Point(798, 165);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(105, 40);
            this.btn_Eliminar.TabIndex = 75;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.TextColor = System.Drawing.Color.White;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.btn_Actualizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.btn_Actualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Actualizar.BorderRadius = 20;
            this.btn_Actualizar.BorderSize = 0;
            this.btn_Actualizar.Enabled = false;
            this.btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar.ForeColor = System.Drawing.Color.White;
            this.btn_Actualizar.Location = new System.Drawing.Point(798, 118);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(105, 40);
            this.btn_Actualizar.TabIndex = 74;
            this.btn_Actualizar.Text = "ACTUALIZAR";
            this.btn_Actualizar.TextColor = System.Drawing.Color.White;
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
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
            this.btn_Guardar.Location = new System.Drawing.Point(798, 71);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(105, 40);
            this.btn_Guardar.TabIndex = 73;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.TextColor = System.Drawing.Color.Transparent;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
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
            this.btn_Nuevo.Location = new System.Drawing.Point(798, 24);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(105, 40);
            this.btn_Nuevo.TabIndex = 72;
            this.btn_Nuevo.Text = "NUEVO";
            this.btn_Nuevo.TextColor = System.Drawing.Color.White;
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // gb_DetallesProd
            // 
            this.gb_DetallesProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_DetallesProd.BackColor = System.Drawing.Color.LightGray;
            this.gb_DetallesProd.Controls.Add(this.txt_Stock);
            this.gb_DetallesProd.Controls.Add(this.txt_Ganancia);
            this.gb_DetallesProd.Controls.Add(this.lbl_Fecha);
            this.gb_DetallesProd.Controls.Add(this.combo_Descuento);
            this.gb_DetallesProd.Controls.Add(this.lbl_Descuento);
            this.gb_DetallesProd.Controls.Add(this.lbl_Desc);
            this.gb_DetallesProd.Controls.Add(this.txt_Descripción);
            this.gb_DetallesProd.Controls.Add(this.lbl_Bodega);
            this.gb_DetallesProd.Controls.Add(this.lbl_stock);
            this.gb_DetallesProd.Controls.Add(this.combo_Proveedor);
            this.gb_DetallesProd.Controls.Add(this.lbl_Ganacia);
            this.gb_DetallesProd.Controls.Add(this.txt_ValVenta);
            this.gb_DetallesProd.Controls.Add(this.lbl_Codigo);
            this.gb_DetallesProd.Controls.Add(this.txt_Codigo);
            this.gb_DetallesProd.Controls.Add(this.lbl_VVenta);
            this.gb_DetallesProd.Controls.Add(this.lbl_Provee);
            this.gb_DetallesProd.Controls.Add(this.txt_ValCompra);
            this.gb_DetallesProd.Controls.Add(this.lbl_VCompra);
            this.gb_DetallesProd.Controls.Add(this.lbl_Cantidad);
            this.gb_DetallesProd.Controls.Add(this.combo_Bodega);
            this.gb_DetallesProd.Controls.Add(this.txt_Cantidad);
            this.gb_DetallesProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_DetallesProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DetallesProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.gb_DetallesProd.Location = new System.Drawing.Point(88, 18);
            this.gb_DetallesProd.Name = "gb_DetallesProd";
            this.gb_DetallesProd.Size = new System.Drawing.Size(674, 245);
            this.gb_DetallesProd.TabIndex = 71;
            this.gb_DetallesProd.TabStop = false;
            this.gb_DetallesProd.Text = "Detalles del producto";
            this.gb_DetallesProd.Paint += new System.Windows.Forms.PaintEventHandler(this.gb_DetallesProd_Paint);
            // 
            // txt_Stock
            // 
            this.txt_Stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.txt_Stock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_Stock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Stock.ForeColor = System.Drawing.Color.White;
            this.txt_Stock.Location = new System.Drawing.Point(423, 140);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.txt_Stock.Size = new System.Drawing.Size(220, 23);
            this.txt_Stock.TabIndex = 78;
            this.txt_Stock.Text = "0";
            this.txt_Stock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Ganancia
            // 
            this.txt_Ganancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.txt_Ganancia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_Ganancia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ganancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.txt_Ganancia.Location = new System.Drawing.Point(423, 210);
            this.txt_Ganancia.Name = "txt_Ganancia";
            this.txt_Ganancia.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.txt_Ganancia.Size = new System.Drawing.Size(220, 23);
            this.txt_Ganancia.TabIndex = 77;
            this.txt_Ganancia.Text = "0";
            this.txt_Ganancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lbl_Fecha.Location = new System.Drawing.Point(570, 35);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(39, 15);
            this.lbl_Fecha.TabIndex = 71;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // combo_Descuento
            // 
            this.combo_Descuento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combo_Descuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Descuento.Enabled = false;
            this.combo_Descuento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_Descuento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Descuento.FormattingEnabled = true;
            this.combo_Descuento.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.combo_Descuento.Location = new System.Drawing.Point(93, 210);
            this.combo_Descuento.Name = "combo_Descuento";
            this.combo_Descuento.Size = new System.Drawing.Size(220, 23);
            this.combo_Descuento.TabIndex = 68;
            // 
            // lbl_Descuento
            // 
            this.lbl_Descuento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Descuento.AutoSize = true;
            this.lbl_Descuento.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descuento.Location = new System.Drawing.Point(4, 213);
            this.lbl_Descuento.Name = "lbl_Descuento";
            this.lbl_Descuento.Size = new System.Drawing.Size(78, 15);
            this.lbl_Descuento.TabIndex = 67;
            this.lbl_Descuento.Text = "DESCUENTO:";
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Desc.AutoSize = true;
            this.lbl_Desc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Desc.Location = new System.Drawing.Point(4, 72);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(86, 15);
            this.lbl_Desc.TabIndex = 53;
            this.lbl_Desc.Text = "DESCRIPCIÓN:";
            // 
            // txt_Descripción
            // 
            this.txt_Descripción.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Descripción.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Descripción.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Descripción.Enabled = false;
            this.txt_Descripción.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripción.Location = new System.Drawing.Point(93, 70);
            this.txt_Descripción.Name = "txt_Descripción";
            this.txt_Descripción.Size = new System.Drawing.Size(550, 23);
            this.txt_Descripción.TabIndex = 54;
            this.txt_Descripción.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Descripción_KeyPress);
            // 
            // lbl_Bodega
            // 
            this.lbl_Bodega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Bodega.AutoSize = true;
            this.lbl_Bodega.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bodega.Location = new System.Drawing.Point(343, 108);
            this.lbl_Bodega.Name = "lbl_Bodega";
            this.lbl_Bodega.Size = new System.Drawing.Size(57, 15);
            this.lbl_Bodega.TabIndex = 57;
            this.lbl_Bodega.Text = "BODEGA:";
            // 
            // lbl_stock
            // 
            this.lbl_stock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(343, 142);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(47, 15);
            this.lbl_stock.TabIndex = 61;
            this.lbl_stock.Text = "STOCK:";
            // 
            // combo_Proveedor
            // 
            this.combo_Proveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combo_Proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Proveedor.Enabled = false;
            this.combo_Proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_Proveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Proveedor.FormattingEnabled = true;
            this.combo_Proveedor.ItemHeight = 15;
            this.combo_Proveedor.Location = new System.Drawing.Point(93, 105);
            this.combo_Proveedor.Name = "combo_Proveedor";
            this.combo_Proveedor.Size = new System.Drawing.Size(220, 23);
            this.combo_Proveedor.TabIndex = 56;
            this.combo_Proveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_Proveedor_KeyPress);
            // 
            // lbl_Ganacia
            // 
            this.lbl_Ganacia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Ganacia.AutoSize = true;
            this.lbl_Ganacia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ganacia.Location = new System.Drawing.Point(343, 213);
            this.lbl_Ganacia.Name = "lbl_Ganacia";
            this.lbl_Ganacia.Size = new System.Drawing.Size(71, 15);
            this.lbl_Ganacia.TabIndex = 69;
            this.lbl_Ganacia.Text = "GANANCIA:";
            // 
            // txt_ValVenta
            // 
            this.txt_ValVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_ValVenta.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ValVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ValVenta.Enabled = false;
            this.txt_ValVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValVenta.Location = new System.Drawing.Point(423, 175);
            this.txt_ValVenta.Name = "txt_ValVenta";
            this.txt_ValVenta.Size = new System.Drawing.Size(220, 23);
            this.txt_ValVenta.TabIndex = 66;
            this.txt_ValVenta.Text = "0";
            this.txt_ValVenta.TextChanged += new System.EventHandler(this.txt_ValVenta_TextChanged);
            this.txt_ValVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValVenta_KeyPress);
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo.Location = new System.Drawing.Point(4, 37);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(56, 15);
            this.lbl_Codigo.TabIndex = 51;
            this.lbl_Codigo.Text = "CÓDIGO:";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Codigo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Codigo.Enabled = false;
            this.txt_Codigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo.Location = new System.Drawing.Point(93, 35);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(220, 23);
            this.txt_Codigo.TabIndex = 52;
            this.txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_KeyPress);
            // 
            // lbl_VVenta
            // 
            this.lbl_VVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_VVenta.AutoSize = true;
            this.lbl_VVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VVenta.Location = new System.Drawing.Point(343, 177);
            this.lbl_VVenta.Name = "lbl_VVenta";
            this.lbl_VVenta.Size = new System.Drawing.Size(74, 15);
            this.lbl_VVenta.TabIndex = 65;
            this.lbl_VVenta.Text = "VAL. VENTA:";
            // 
            // lbl_Provee
            // 
            this.lbl_Provee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Provee.AutoSize = true;
            this.lbl_Provee.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Provee.Location = new System.Drawing.Point(4, 108);
            this.lbl_Provee.Name = "lbl_Provee";
            this.lbl_Provee.Size = new System.Drawing.Size(78, 15);
            this.lbl_Provee.TabIndex = 55;
            this.lbl_Provee.Text = "PROVEEDOR:";
            // 
            // txt_ValCompra
            // 
            this.txt_ValCompra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_ValCompra.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ValCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ValCompra.Enabled = false;
            this.txt_ValCompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValCompra.Location = new System.Drawing.Point(93, 175);
            this.txt_ValCompra.Name = "txt_ValCompra";
            this.txt_ValCompra.Size = new System.Drawing.Size(220, 23);
            this.txt_ValCompra.TabIndex = 64;
            this.txt_ValCompra.Text = "0";
            this.txt_ValCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValCompra_KeyPress);
            // 
            // lbl_VCompra
            // 
            this.lbl_VCompra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_VCompra.AutoSize = true;
            this.lbl_VCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VCompra.Location = new System.Drawing.Point(4, 177);
            this.lbl_VCompra.Name = "lbl_VCompra";
            this.lbl_VCompra.Size = new System.Drawing.Size(86, 15);
            this.lbl_VCompra.TabIndex = 63;
            this.lbl_VCompra.Text = "VAL. COMPRA:";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(4, 142);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(71, 15);
            this.lbl_Cantidad.TabIndex = 59;
            this.lbl_Cantidad.Text = "CANTIDAD:";
            // 
            // combo_Bodega
            // 
            this.combo_Bodega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combo_Bodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Bodega.Enabled = false;
            this.combo_Bodega.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_Bodega.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Bodega.FormattingEnabled = true;
            this.combo_Bodega.Items.AddRange(new object[] {
            "NINGUNA"});
            this.combo_Bodega.Location = new System.Drawing.Point(423, 105);
            this.combo_Bodega.Name = "combo_Bodega";
            this.combo_Bodega.Size = new System.Drawing.Size(220, 23);
            this.combo_Bodega.TabIndex = 58;
            this.combo_Bodega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_Bodega_KeyPress);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Cantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Cantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Cantidad.Enabled = false;
            this.txt_Cantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.Location = new System.Drawing.Point(93, 140);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(220, 23);
            this.txt_Cantidad.TabIndex = 60;
            this.txt_Cantidad.Text = "0";
            this.txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cantidad_KeyPress);
            // 
            // pnl_Inferior
            // 
            this.pnl_Inferior.BackColor = System.Drawing.Color.Silver;
            this.pnl_Inferior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Inferior.Controls.Add(this.txt_Total_Ganancias);
            this.pnl_Inferior.Controls.Add(this.label6);
            this.pnl_Inferior.Controls.Add(this.txt_Total_Valor_Venta);
            this.pnl_Inferior.Controls.Add(this.label4);
            this.pnl_Inferior.Controls.Add(this.txt_Total_Valor_Compra);
            this.pnl_Inferior.Controls.Add(this.label2);
            this.pnl_Inferior.Controls.Add(this.lbl_NRegistros);
            this.pnl_Inferior.Controls.Add(this.DGV_Productos);
            this.pnl_Inferior.Controls.Add(this.lbl_Buscar);
            this.pnl_Inferior.Controls.Add(this.txt_Buscar);
            this.pnl_Inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Inferior.Location = new System.Drawing.Point(0, 336);
            this.pnl_Inferior.Name = "pnl_Inferior";
            this.pnl_Inferior.Size = new System.Drawing.Size(996, 260);
            this.pnl_Inferior.TabIndex = 27;
            // 
            // txt_Total_Ganancias
            // 
            this.txt_Total_Ganancias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Total_Ganancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.txt_Total_Ganancias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_Total_Ganancias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Ganancias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.txt_Total_Ganancias.Location = new System.Drawing.Point(806, 228);
            this.txt_Total_Ganancias.Name = "txt_Total_Ganancias";
            this.txt_Total_Ganancias.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.txt_Total_Ganancias.Size = new System.Drawing.Size(150, 23);
            this.txt_Total_Ganancias.TabIndex = 84;
            this.txt_Total_Ganancias.Text = "$";
            this.txt_Total_Ganancias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(687, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 83;
            this.label6.Text = "TOTAL GANANCIAS:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Total_Valor_Venta
            // 
            this.txt_Total_Valor_Venta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Total_Valor_Venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.txt_Total_Valor_Venta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_Total_Valor_Venta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Valor_Venta.ForeColor = System.Drawing.Color.White;
            this.txt_Total_Valor_Venta.Location = new System.Drawing.Point(474, 228);
            this.txt_Total_Valor_Venta.Name = "txt_Total_Valor_Venta";
            this.txt_Total_Valor_Venta.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.txt_Total_Valor_Venta.Size = new System.Drawing.Size(150, 23);
            this.txt_Total_Valor_Venta.TabIndex = 82;
            this.txt_Total_Valor_Venta.Text = "$";
            this.txt_Total_Valor_Venta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 81;
            this.label4.Text = "V. TOTAL VENTA:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Total_Valor_Compra
            // 
            this.txt_Total_Valor_Compra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Total_Valor_Compra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.txt_Total_Valor_Compra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_Total_Valor_Compra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Valor_Compra.ForeColor = System.Drawing.Color.White;
            this.txt_Total_Valor_Compra.Location = new System.Drawing.Point(146, 228);
            this.txt_Total_Valor_Compra.Name = "txt_Total_Valor_Compra";
            this.txt_Total_Valor_Compra.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.txt_Total_Valor_Compra.Size = new System.Drawing.Size(150, 23);
            this.txt_Total_Valor_Compra.TabIndex = 80;
            this.txt_Total_Valor_Compra.Text = "$";
            this.txt_Total_Valor_Compra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 79;
            this.label2.Text = "V. TOTAL  COMPRA:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_NRegistros
            // 
            this.lbl_NRegistros.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_NRegistros.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NRegistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.lbl_NRegistros.Location = new System.Drawing.Point(806, 20);
            this.lbl_NRegistros.Name = "lbl_NRegistros";
            this.lbl_NRegistros.Size = new System.Drawing.Size(150, 23);
            this.lbl_NRegistros.TabIndex = 65;
            this.lbl_NRegistros.Text = "N° registros";
            this.lbl_NRegistros.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // DGV_Productos
            // 
            this.DGV_Productos.AllowUserToAddRows = false;
            this.DGV_Productos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DGV_Productos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Productos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Productos.BackgroundColor = System.Drawing.Color.Silver;
            this.DGV_Productos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DGV_Productos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DGV_Productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGV_Productos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DGV_Productos.Location = new System.Drawing.Point(31, 53);
            this.DGV_Productos.MultiSelect = false;
            this.DGV_Productos.Name = "DGV_Productos";
            this.DGV_Productos.ReadOnly = true;
            this.DGV_Productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Productos.RowHeadersWidth = 25;
            this.DGV_Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_Productos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Productos.Size = new System.Drawing.Size(925, 160);
            this.DGV_Productos.TabIndex = 62;
            this.DGV_Productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Productos_CellClick);
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.lbl_Buscar.Location = new System.Drawing.Point(28, 20);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(57, 15);
            this.lbl_Buscar.TabIndex = 56;
            this.lbl_Buscar.Text = "BUSCAR:";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Buscar.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Buscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.Location = new System.Drawing.Point(91, 15);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(350, 23);
            this.txt_Buscar.TabIndex = 54;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // GUI_RegistroInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnl_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_RegistroInventario";
            this.Text = "GUI_RegistroInventario";
            this.Load += new System.EventHandler(this.GUI_RegistroInventario_Load);
            this.pnl_Cabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Logo)).EndInit();
            this.pnl_Principal.ResumeLayout(false);
            this.pnl_Datos.ResumeLayout(false);
            this.gb_DetallesProd.ResumeLayout(false);
            this.gb_DetallesProd.PerformLayout();
            this.pnl_Inferior.ResumeLayout(false);
            this.pnl_Inferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Cabecera;
        private System.Windows.Forms.Panel pnl_Principal;
        private System.Windows.Forms.Panel pnl_Datos;
        private System.Windows.Forms.Panel pnl_Inferior;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label lbl_Titulo;
        private Resources.Botones btn_Volver;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.ComboBox combo_Descuento;
        private System.Windows.Forms.Label lbl_Descuento;
        private System.Windows.Forms.Label lbl_Desc;
        private System.Windows.Forms.TextBox txt_Descripción;
        private System.Windows.Forms.Label lbl_Bodega;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.ComboBox combo_Proveedor;
        private System.Windows.Forms.Label lbl_Ganacia;
        private System.Windows.Forms.TextBox txt_ValVenta;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label lbl_VVenta;
        private System.Windows.Forms.Label lbl_Provee;
        private System.Windows.Forms.TextBox txt_ValCompra;
        private System.Windows.Forms.Label lbl_VCompra;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.ComboBox combo_Bodega;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.GroupBox gb_DetallesProd;
        private Resources.Botones btn_Cancelar;
        private Resources.Botones btn_Eliminar;
        private Resources.Botones btn_Actualizar;
        private Resources.Botones btn_Guardar;
        private Resources.Botones btn_Nuevo;
        private System.Windows.Forms.PictureBox img_Logo;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.DataGridView DGV_Productos;
        private System.Windows.Forms.Label lbl_NRegistros;
        private System.Windows.Forms.Label txt_Ganancia;
        private System.Windows.Forms.Label txt_Stock;
        private System.Windows.Forms.Label txt_Total_Valor_Compra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_Total_Ganancias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txt_Total_Valor_Venta;
        private System.Windows.Forms.Label label4;
    }
}