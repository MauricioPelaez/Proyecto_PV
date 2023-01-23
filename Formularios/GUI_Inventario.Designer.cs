namespace Proyecto_PV.Formularios
{
    partial class GUI_Inventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Principal = new System.Windows.Forms.Panel();
            this.panel_Cuerpo = new System.Windows.Forms.Panel();
            this.DGV_Inventario = new System.Windows.Forms.DataGridView();
            this.lbl_NRegistros = new System.Windows.Forms.Label();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.panel_Inferior = new System.Windows.Forms.Panel();
            this.txt_Total_Ganancias = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Total_Valor_Venta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Total_Valor_Compra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Cabecera = new System.Windows.Forms.Panel();
            this.btn_Volver = new Proyecto_PV.Resources.Botones();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.panel_Principal.SuspendLayout();
            this.panel_Cuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventario)).BeginInit();
            this.panel_Inferior.SuspendLayout();
            this.pnl_Cabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Principal
            // 
            this.panel_Principal.BackColor = System.Drawing.Color.LightGray;
            this.panel_Principal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Principal.Controls.Add(this.panel_Cuerpo);
            this.panel_Principal.Controls.Add(this.panel_Inferior);
            this.panel_Principal.Controls.Add(this.pnl_Cabecera);
            this.panel_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Principal.Location = new System.Drawing.Point(0, 0);
            this.panel_Principal.Name = "panel_Principal";
            this.panel_Principal.Size = new System.Drawing.Size(1000, 600);
            this.panel_Principal.TabIndex = 1;
            // 
            // panel_Cuerpo
            // 
            this.panel_Cuerpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Cuerpo.Controls.Add(this.DGV_Inventario);
            this.panel_Cuerpo.Controls.Add(this.lbl_NRegistros);
            this.panel_Cuerpo.Controls.Add(this.lbl_Buscar);
            this.panel_Cuerpo.Controls.Add(this.txt_Buscar);
            this.panel_Cuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Cuerpo.Location = new System.Drawing.Point(0, 65);
            this.panel_Cuerpo.Name = "panel_Cuerpo";
            this.panel_Cuerpo.Size = new System.Drawing.Size(996, 481);
            this.panel_Cuerpo.TabIndex = 3;
            // 
            // DGV_Inventario
            // 
            this.DGV_Inventario.AllowUserToAddRows = false;
            this.DGV_Inventario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DGV_Inventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Inventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Inventario.BackgroundColor = System.Drawing.Color.Silver;
            this.DGV_Inventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Inventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DGV_Inventario.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DGV_Inventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Inventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Inventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGV_Inventario.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DGV_Inventario.Location = new System.Drawing.Point(30, 51);
            this.DGV_Inventario.MultiSelect = false;
            this.DGV_Inventario.Name = "DGV_Inventario";
            this.DGV_Inventario.ReadOnly = true;
            this.DGV_Inventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Inventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Inventario.RowHeadersWidth = 25;
            this.DGV_Inventario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(50)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_Inventario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Inventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Inventario.Size = new System.Drawing.Size(936, 400);
            this.DGV_Inventario.TabIndex = 69;
            // 
            // lbl_NRegistros
            // 
            this.lbl_NRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NRegistros.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NRegistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.lbl_NRegistros.Location = new System.Drawing.Point(816, 13);
            this.lbl_NRegistros.Name = "lbl_NRegistros";
            this.lbl_NRegistros.Size = new System.Drawing.Size(150, 23);
            this.lbl_NRegistros.TabIndex = 68;
            this.lbl_NRegistros.Text = "N° registros";
            this.lbl_NRegistros.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.lbl_Buscar.Location = new System.Drawing.Point(30, 18);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(57, 15);
            this.lbl_Buscar.TabIndex = 67;
            this.lbl_Buscar.Text = "BUSCAR:";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Buscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.Location = new System.Drawing.Point(93, 13);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(350, 23);
            this.txt_Buscar.TabIndex = 66;
            // 
            // panel_Inferior
            // 
            this.panel_Inferior.BackColor = System.Drawing.Color.Silver;
            this.panel_Inferior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Inferior.Controls.Add(this.txt_Total_Ganancias);
            this.panel_Inferior.Controls.Add(this.label6);
            this.panel_Inferior.Controls.Add(this.txt_Total_Valor_Venta);
            this.panel_Inferior.Controls.Add(this.label4);
            this.panel_Inferior.Controls.Add(this.txt_Total_Valor_Compra);
            this.panel_Inferior.Controls.Add(this.label2);
            this.panel_Inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Inferior.Location = new System.Drawing.Point(0, 546);
            this.panel_Inferior.Name = "panel_Inferior";
            this.panel_Inferior.Size = new System.Drawing.Size(996, 50);
            this.panel_Inferior.TabIndex = 2;
            // 
            // txt_Total_Ganancias
            // 
            this.txt_Total_Ganancias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Total_Ganancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.txt_Total_Ganancias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_Total_Ganancias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Ganancias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.txt_Total_Ganancias.Location = new System.Drawing.Point(816, 12);
            this.txt_Total_Ganancias.Name = "txt_Total_Ganancias";
            this.txt_Total_Ganancias.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.txt_Total_Ganancias.Size = new System.Drawing.Size(150, 23);
            this.txt_Total_Ganancias.TabIndex = 90;
            this.txt_Total_Ganancias.Text = "$";
            this.txt_Total_Ganancias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(697, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 89;
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
            this.txt_Total_Valor_Venta.Location = new System.Drawing.Point(471, 12);
            this.txt_Total_Valor_Venta.Name = "txt_Total_Valor_Venta";
            this.txt_Total_Valor_Venta.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.txt_Total_Valor_Venta.Size = new System.Drawing.Size(150, 23);
            this.txt_Total_Valor_Venta.TabIndex = 88;
            this.txt_Total_Valor_Venta.Text = "$";
            this.txt_Total_Valor_Venta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 87;
            this.label4.Text = "TOTAL V. VENTA:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Total_Valor_Compra
            // 
            this.txt_Total_Valor_Compra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Total_Valor_Compra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.txt_Total_Valor_Compra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_Total_Valor_Compra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Valor_Compra.ForeColor = System.Drawing.Color.White;
            this.txt_Total_Valor_Compra.Location = new System.Drawing.Point(143, 12);
            this.txt_Total_Valor_Compra.Name = "txt_Total_Valor_Compra";
            this.txt_Total_Valor_Compra.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.txt_Total_Valor_Compra.Size = new System.Drawing.Size(150, 23);
            this.txt_Total_Valor_Compra.TabIndex = 86;
            this.txt_Total_Valor_Compra.Text = "$";
            this.txt_Total_Valor_Compra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 85;
            this.label2.Text = "TOTAL V. COMPRA:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_Cabecera
            // 
            this.pnl_Cabecera.BackColor = System.Drawing.Color.Silver;
            this.pnl_Cabecera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Cabecera.Controls.Add(this.btn_Volver);
            this.pnl_Cabecera.Controls.Add(this.lbl_Titulo);
            this.pnl_Cabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Cabecera.Location = new System.Drawing.Point(0, 0);
            this.pnl_Cabecera.Name = "pnl_Cabecera";
            this.pnl_Cabecera.Size = new System.Drawing.Size(996, 65);
            this.pnl_Cabecera.TabIndex = 1;
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
            this.btn_Volver.Location = new System.Drawing.Point(854, 13);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(99, 39);
            this.btn_Volver.TabIndex = 33;
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
            this.lbl_Titulo.Location = new System.Drawing.Point(58, 13);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(880, 39);
            this.lbl_Titulo.TabIndex = 34;
            this.lbl_Titulo.Text = "INVENTARIO";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GUI_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_Inventario";
            this.Text = "Inventario";
            this.panel_Principal.ResumeLayout(false);
            this.panel_Cuerpo.ResumeLayout(false);
            this.panel_Cuerpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventario)).EndInit();
            this.panel_Inferior.ResumeLayout(false);
            this.pnl_Cabecera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Principal;
        private System.Windows.Forms.Panel pnl_Cabecera;
        private Resources.Botones btn_Volver;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Panel panel_Inferior;
        private System.Windows.Forms.Panel panel_Cuerpo;
        private System.Windows.Forms.Label txt_Total_Ganancias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txt_Total_Valor_Venta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_Total_Valor_Compra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_NRegistros;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.DataGridView DGV_Inventario;
    }
}