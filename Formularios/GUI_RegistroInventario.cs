using MySql.Data.MySqlClient;
using Proyecto_PV.Datos_Staticos;
using Proyecto_PV.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Proyecto_PV.Formularios
{
    public partial class GUI_RegistroInventario : Form
    {
        public GUI_RegistroInventario()
        {
            InitializeComponent();
            Tabla();
        }

        #region Evento Load
        private void GUI_RegistroInventario_Load(object sender, EventArgs e)
        {
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Bodegas();
            Proveedores();
            NRegistros();
            Limpiar();
            DGV_Productos.ClearSelection();
        }
        #endregion

        #region Color borde del GroupBox
        private void gb_DetallesProd_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Black, Color.Gray);
        }

        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }
        #endregion

        #region Habilitar / Deshabilitar campos
        private void Habilitar()
        {
            txt_Codigo.Enabled = true;
            txt_Descripción.Enabled = true;
            combo_Proveedor.Enabled = true;
            combo_Bodega.Enabled = true;
            txt_Cantidad.Enabled = true;
            txt_ValCompra.Enabled = true;
            txt_ValVenta.Enabled = true;
            combo_Descuento.Enabled = true;
        }

        private void Deshabilitar()
        {
            txt_Codigo.Enabled = false;
            txt_Descripción.Enabled = false;
            combo_Proveedor.Enabled = false;
            combo_Bodega.Enabled = false;
            txt_Cantidad.Enabled = false;
            txt_ValCompra.Enabled = false;
            txt_ValVenta.Enabled = false;
            combo_Descuento.Enabled = false;
        }

        private void Limpiar()
        {
            txt_Codigo.Text = "";
            txt_Descripción.Text = "";
            combo_Proveedor.SelectedIndex = -1;
            combo_Bodega.SelectedIndex = -1;
            txt_Cantidad.Text = "0";
            txt_Stock.Text = "0";
            txt_ValCompra.Text = "0";
            txt_ValVenta.Text = "0";
            combo_Descuento.SelectedIndex = -1;
            txt_Ganancia.Text = "0";
            DGV_Productos.ClearSelection();
        }

        private void Reestablecer()
        {
            btn_Nuevo.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_Actualizar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Cancelar.Enabled = true;
        }

        #endregion

        #region Saltos de linea
        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_Descripción.Focus();
                e.Handled = true;
            }
        }

        private void txt_Descripción_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                combo_Proveedor.Focus();
                combo_Proveedor.SelectedIndex = 0;
                e.Handled = true;
            }
        }

        private void combo_Proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                combo_Bodega.Focus();
                combo_Bodega.SelectedIndex = 0;
                e.Handled = true;
            }
        }

        private void combo_Bodega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_Cantidad.Focus();
                e.Handled = true;
            }
        }

        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_ValCompra.Focus();
                e.Handled = true;
            }
        }

        private void txt_ValCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_ValVenta.Focus();
                e.Handled = true;
            }
        }

        private void txt_ValVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                combo_Descuento.Focus();
                combo_Descuento.SelectedIndex = 1;
                e.Handled = true;
            }
        }

        #endregion

        #region Tabla
        private void Tabla()
        {
            DGV_Productos.DataSource = LlenarTabla();
            DGV_Productos.Columns[0].HeaderText = "CÓDIGO";
            DGV_Productos.Columns[1].HeaderText = "DESCRIPCIÓN";
            DGV_Productos.Columns[2].HeaderText = "PROVEEDOR";
            DGV_Productos.Columns[3].HeaderText = "BODEGA";
            DGV_Productos.Columns[4].HeaderText = "STOCK";
            DGV_Productos.Columns[5].HeaderText = "V. COMPRA";
            DGV_Productos.Columns[6].HeaderText = "V. VENTA";
            DGV_Productos.Columns[7].HeaderText = "G. UNIDAD";
            DGV_Productos.Columns[8].HeaderText = "T. GANANCIA";
            DGV_Productos.Columns[9].HeaderText = "DESCUENTO";

            DGV_Productos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Productos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV_Productos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV_Productos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV_Productos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Productos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Productos.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Productos.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Productos.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Productos.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DGV_Productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void NRegistros()
        {
            int nreg = DGV_Productos.Rows.Count;
            lbl_NRegistros.Text = "Total items: " + nreg.ToString();
            TotalCompra();
            TotalVenta();
            TotalGanancias();
        }

        private void TotalCompra()
        {
            double sumatoria_Compra = 0;
            foreach (DataGridViewRow row in DGV_Productos.Rows)
            {
                sumatoria_Compra += Convert.ToDouble(row.Cells[5].Value) * Convert.ToDouble(row.Cells[4].Value);
            }
            string compra = sumatoria_Compra.ToString("#,#");
            txt_Total_Valor_Compra.Text = $"$ {compra}";
        }

        private void TotalVenta()
        {
            double sumatoria_Venta = 0;
            foreach (DataGridViewRow row in DGV_Productos.Rows)
            {
                sumatoria_Venta += Convert.ToDouble(row.Cells[6].Value) * Convert.ToDouble(row.Cells[4].Value);
            }
            string venta = sumatoria_Venta.ToString("#,#");
            txt_Total_Valor_Venta.Text = $"$ {venta}";
        }

        private void TotalGanancias()
        {
            double sumatoria_Ganacias = 0;
            foreach (DataGridViewRow row in DGV_Productos.Rows)
            {
                sumatoria_Ganacias += Convert.ToDouble(row.Cells[8].Value);
            }
            string ganacias = sumatoria_Ganacias.ToString("#,#");
            txt_Total_Ganancias.Text = $"$ {ganacias}";
        }        
        #endregion

        #region Base de datos

        MySqlConnection conexion = new MySqlConnection();
        ConexionDB.ConexionSQL conexionSQL = new ConexionDB.ConexionSQL();

        #region Llenar ComboBox Bodegas
        private DataTable CargarBodegas()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = conexionSQL.Conectar();
                conexion.Open();
            }

            DataTable dt = new DataTable();
            string query = "SELECT * FROM `bodega`";
            MySqlCommand command = new MySqlCommand(query, conexion);
            command.CommandTimeout = 60;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(dt);

            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }

            return dt;
        }

        private void Bodegas()
        {
            combo_Bodega.DataSource = CargarBodegas();
            combo_Bodega.DisplayMember = "desc_bod";
            combo_Bodega.ValueMember = "desc_bod";
        }
        #endregion

        #region Llenar ComboBox Proveedores
        private DataTable CargarProveedores()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = conexionSQL.Conectar();
                conexion.Open();
            }

            DataTable dt = new DataTable();
            string query = "SELECT * FROM `proveedor`";
            MySqlCommand command = new MySqlCommand(query, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            command.CommandTimeout = 60;
            adapter.Fill(dt);

            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }

            return dt;
        }

        private void Proveedores()
        {
            combo_Proveedor.DataSource = CargarProveedores();
            combo_Proveedor.DisplayMember = "nom_provee";
            combo_Proveedor.ValueMember = "nom_provee";
        }

        #endregion

        #region Llenar tabla
        private DataTable LlenarTabla()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = conexionSQL.Conectar();
                conexion.Open();
            }

            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT `cod_prod`, `desc_prod`, `nom_provee`, `bodega`, `stck_prod`, `val_compra`, `val_venta`, `gan_unidad`, `gana_prod`, `dto_prod` FROM `inventario`";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.CommandTimeout = 60;

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }

            return dt;
        }
        #endregion

        #region Selecionar registro (Tabla)
        private void DGV_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_Codigo.Text = DGV_Productos.CurrentRow.Cells[0].Value.ToString();
                txt_Descripción.Text = DGV_Productos.CurrentRow.Cells[1].Value.ToString();
                combo_Proveedor.Text = DGV_Productos.CurrentRow.Cells[2].Value.ToString();
                combo_Bodega.Text = DGV_Productos.CurrentRow.Cells[3].Value.ToString();
                txt_Stock.Text = DGV_Productos.CurrentRow.Cells[4].Value.ToString();
                txt_ValCompra.Text = DGV_Productos.CurrentRow.Cells[5].Value.ToString();
                txt_ValVenta.Text = DGV_Productos.CurrentRow.Cells[6].Value.ToString();
                //
                combo_Descuento.Text = DGV_Productos.CurrentRow.Cells[9].Value.ToString();
                Habilitar();
                Ganancia();
                txt_Codigo.Focus();
                txt_Buscar.Text = "";
                txt_Cantidad.Text = "0";
                btn_Guardar.Enabled = false;
                btn_Actualizar.Enabled = true;
                btn_Eliminar.Enabled = true;
                btn_Nuevo.Enabled = true;

                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.ConnectionString = conexionSQL.Conectar();
                    conexion.Open();
                }

                string query = "SELECT `id` FROM `inventario` WHERE `cod_prod` = @code OR `desc_prod` = @desc";
                MySqlCommand command = new MySqlCommand(query, conexion);
                command.Parameters.Add("@code", MySqlDbType.VarChar).Value = txt_Codigo.Text;
                command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = txt_Descripción.Text;
                command.CommandTimeout= 60;
                Global.id_producto = Convert.ToString(command.ExecuteScalar());

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        #endregion

        #region Busqueda dinamica
        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = conexionSQL.Conectar();
                conexion.Open();
            }

            string cadena = "SELECT `cod_prod`, `desc_prod`, `nom_provee`, `bodega`, `stck_prod`, `val_compra`, `val_venta`, `gan_unidad`, `gana_prod`, `dto_prod` FROM `inventario` WHERE " +
                            "`cod_prod` LIKE '%" + txt_Buscar.Text + "%' Or `desc_prod` LIKE '%" + txt_Buscar.Text + "%' Or `nom_provee` LIKE '%" + txt_Buscar.Text + "%' Or `bodega` LIKE '%" + txt_Buscar.Text +
                            "%' Or `stck_prod` LIKE '%" + txt_Buscar.Text + "%' Or `val_compra` LIKE '%" + txt_Buscar.Text + "%' Or `val_venta` LIKE '%" + txt_Buscar.Text + "%' Or `gan_unidad` LIKE '%" + txt_Buscar.Text + 
                            "%' Or `gana_prod` LIKE '%" + txt_Buscar.Text + "%' Or `dto_prod` LIKE '%" + txt_Buscar.Text + "%'";

            MySqlCommand comando = new MySqlCommand(cadena, conexion);
            comando.CommandTimeout = 60;
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

            DataSet datos = new DataSet();
            adapter.Fill(datos);

            try
            {
                DGV_Productos.DataSource = datos.Tables[0];
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("Error en la busqueda dinamica de las bodegas...");
                System.Diagnostics.Debug.WriteLine(ex.ToString());

            }

            NRegistros();

            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
        #endregion

        #region Ganancia
        private void Ganancia()
        {
            try
            {
                float total;
                total = float.Parse(txt_ValVenta.Text) - float.Parse(txt_ValCompra.Text);

                string resultado;
                resultado = total.ToString();
                txt_Ganancia.Text = resultado;
            }
            catch
            {
                string mensajeText = "El valor de compra o de venta es incorrecto";
                string caption = "Error en los Precios";

                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult result;

                result = System.Windows.MessageBox.Show(mensajeText, caption, button, icon);
                txt_ValCompra.Focus();
            }
        }

        private void txt_ValVenta_TextChanged(object sender, EventArgs e)
        {
            Ganancia();
        } 

        #endregion

        #region Agregar nuevo registro

        #region Botón Nuevo
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar();
            btn_Guardar.Enabled = true;
            btn_Eliminar.Enabled = false;
            btn_Actualizar.Enabled = false;
            btn_Nuevo.Enabled = false;
            txt_Codigo.Focus();
            NRegistros();
        }
        #endregion

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = conexionSQL.Conectar();
                conexion.Open();
            }

            if (txt_Codigo.Text == "" || txt_Descripción.Text == "" || txt_Cantidad.Text == "" || txt_ValCompra.Text == "" || txt_ValVenta.Text == "" || combo_Descuento.SelectedIndex < 0)
            {
                string mensaje = "Información incompleta...";
                string titulo = "Advertencia";
                MessageBoxButton boton = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Exclamation;
                MessageBoxResult resultado;

                resultado = System.Windows.MessageBox.Show(mensaje, titulo, boton, icon);
                Habilitar();
                btn_Nuevo.Enabled = false;
            }
            else
            {
                string cadena = "SELECT `cod_prod`, `desc_prod`, `nom_provee`, `bodega`, `stck_prod`, `val_compra`, `val_venta`, `gan_unidad`, `dto_prod`, `gana_prod` FROM `inventario` WHERE `cod_prod` = @code";
                MySqlCommand command = new MySqlCommand(cadena, conexion);
                command.Parameters.Add("@code", MySqlDbType.VarChar).Value = txt_Codigo.Text;
                command.CommandTimeout = 60;
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet datos = new DataSet();
                adapter.Fill(datos, "inventario");

                int lista = datos.Tables["inventario"].Rows.Count;

                if (lista != 0)
                {
                    string mensaje = "El producto ya se encuentra registrado...";
                    string titulo = "Código de producto existente";
                    MessageBoxButton boton = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Exclamation;
                    MessageBoxResult resultado;

                    resultado = System.Windows.MessageBox.Show(mensaje, titulo, boton, icon);
                    Limpiar();
                    Tabla();
                }
                else
                {
                    try
                    {
                        float total = float.Parse(txt_Ganancia.Text) * float.Parse(txt_Cantidad.Text);
                        string Ganancia_T = total.ToString();

                        string insert = "INSERT INTO `inventario`(`cod_prod`, `desc_prod`, `nom_provee`, `bodega`, `stck_prod`, `val_compra`, `val_venta`, `gan_unidad`,  `dto_prod`, `gana_prod`) VALUES (@code, @desc, @prov, @bode, @stock, @vCompra, @vVenta, @guni, @dto, @gana)";
                        MySqlCommand comando = new MySqlCommand(insert, conexion);
                        comando.Parameters.Add("@code", MySqlDbType.VarChar).Value = txt_Codigo.Text.Trim();
                        comando.Parameters.Add("@desc", MySqlDbType.VarChar).Value = txt_Descripción.Text.Trim();
                        comando.Parameters.Add("@prov", MySqlDbType.VarChar).Value = combo_Proveedor.SelectedValue;
                        comando.Parameters.Add("@bode", MySqlDbType.VarChar).Value = combo_Bodega.SelectedValue;
                        comando.Parameters.Add("@stock", MySqlDbType.VarChar).Value = txt_Cantidad.Text.Trim();
                        comando.Parameters.Add("@vCompra", MySqlDbType.VarChar).Value = txt_ValCompra.Text.Trim();
                        comando.Parameters.Add("@vVenta", MySqlDbType.VarChar).Value = txt_ValVenta.Text.Trim();
                        comando.Parameters.Add("@guni", MySqlDbType.VarChar).Value = txt_Ganancia.Text.Trim();
                        comando.Parameters.Add("@dto", MySqlDbType.VarChar).Value = combo_Descuento.SelectedItem;
                        comando.Parameters.Add("@gana", MySqlDbType.VarChar).Value = Ganancia_T;

                        MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                        DataTable DT = new DataTable();
                        adaptador.Fill(DT);


                        string nuevo_reg = "INSERT INTO `nuevo_producto`(`cod_prod`, `desc_prod`, `cant_prod`, `gana_prod`, `fecha_insert`, `user_insert`, `fecha_update`, `user_update`) VALUES (@code, @desc, @cant, @gana, @fecha, @user, @fecha, @user)";
                        MySqlCommand comm = new MySqlCommand(nuevo_reg, conexion);
                        comm.Parameters.Add("@code", MySqlDbType.VarChar).Value = txt_Codigo.Text.Trim();
                        comm.Parameters.Add("@desc", MySqlDbType.VarChar).Value = txt_Descripción.Text.Trim();
                        comm.Parameters.Add("@cant", MySqlDbType.VarChar).Value = txt_Cantidad.Text.Trim();
                        comm.Parameters.Add("@gana", MySqlDbType.VarChar).Value = Ganancia_T;
                        comm.Parameters.Add("@fecha", MySqlDbType.VarChar).Value = lbl_Fecha.Text.Trim();
                        comm.Parameters.Add("@user", MySqlDbType.VarChar).Value = Global.usuarioLog.Trim();
                        MySqlDataAdapter adap = new MySqlDataAdapter(comm);
                        DataTable tabla = new DataTable();
                        adap.Fill(tabla);


                        string mensaje = "Registro exitoso...";
                        string titulo = "Confirmación";
                        MessageBoxButton boton = MessageBoxButton.OK;
                        MessageBoxImage icon = MessageBoxImage.Information;
                        MessageBoxResult resultado;
                        resultado = System.Windows.MessageBox.Show(mensaje, titulo, boton, icon);

                        Limpiar();
                        Tabla();
                        Reestablecer();
                        Deshabilitar();
                        NRegistros();
                        txt_ValCompra.Text = "0";
                        txt_ValVenta.Text = "0";
                        txt_Cantidad.Text = "0";

                        if (conexion.State == ConnectionState.Open)
                        {
                            conexion.Close();
                        }
                    }
                    catch (SqlException ex)
                    {
                        string mensaje = "Error al realizar el registro...";
                        string titulo = "Error";
                        MessageBoxButton boton = MessageBoxButton.OK;
                        MessageBoxImage icon = MessageBoxImage.Error;
                        MessageBoxResult resultado;
                        resultado = System.Windows.MessageBox.Show(mensaje, titulo, boton, icon);

                        System.Diagnostics.Debug.WriteLine(ex.Message);
                        conexion.Dispose();
                    }
                }
            }
        }
        #endregion

        #region Stock
        public string Stock()
        {
            string query = "SELECT `stck_prod` FROM `inventario` WHERE `id`= @id";
            MySqlCommand sqlCommand = new MySqlCommand(query, conexion);
            sqlCommand.Parameters.Add("@id", MySqlDbType.VarChar).Value = Global.id_producto;
            sqlCommand.CommandTimeout = 60;
            string stock = Convert.ToString(sqlCommand.ExecuteScalar());
            return stock;
        }
        #endregion

        #region Actualizar registro
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = conexionSQL.Conectar();
                conexion.Open();
            }

            if (txt_Codigo.Text == "" || txt_Descripción.Text == "" || txt_Cantidad.Text == "" || txt_ValCompra.Text == "" || txt_ValVenta.Text == "" || combo_Descuento.SelectedIndex < 0)
            {
                string mensaje = "Información incompleta...";
                string titulo = "Advertencia";
                MessageBoxButton boton = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Exclamation;
                MessageBoxResult resultado;
                resultado = System.Windows.MessageBox.Show(mensaje, titulo, boton, icon);
            }
            else
            {
                int Total = int.Parse(Stock()) + int.Parse(txt_Cantidad.Text);
                int ganacia = Total * int.Parse(txt_Ganancia.Text);
                string Total_Stock = Total.ToString();
                string GananciaTotal = ganacia.ToString();

                string update = "UPDATE `inventario` SET `cod_prod`= @code,`desc_prod`= @desc,`nom_provee`= @prov,`bodega`= @bode,`stck_prod`= @stock,`val_compra`= @vCompra,`val_venta`= @vVenta,`gan_unidad`= @guni, `dto_prod`= @dto,`gana_prod`= @gana WHERE `id` = @id";
                MySqlCommand command = new MySqlCommand(update, conexion);
                command.Parameters.Add("@code", MySqlDbType.VarChar).Value = txt_Codigo.Text.Trim();
                command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = txt_Descripción.Text.Trim();
                command.Parameters.Add("@prov", MySqlDbType.VarChar).Value = combo_Proveedor.SelectedValue;
                command.Parameters.Add("@bode", MySqlDbType.VarChar).Value = combo_Bodega.SelectedValue;
                command.Parameters.Add("@stock", MySqlDbType.VarChar).Value = Total_Stock;
                command.Parameters.Add("@vCompra", MySqlDbType.VarChar).Value = txt_ValCompra.Text.Trim();
                command.Parameters.Add("@vVenta", MySqlDbType.VarChar).Value = txt_ValVenta.Text.Trim();
                command.Parameters.Add("@guni", MySqlDbType.VarChar).Value = txt_Ganancia.Text.Trim();
                command.Parameters.Add("@dto", MySqlDbType.VarChar).Value = combo_Descuento.SelectedItem;
                command.Parameters.Add("@gana", MySqlDbType.VarChar).Value = GananciaTotal;
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Global.id_producto;
                command.ExecuteNonQuery();


                string actualiza = "UPDATE `nuevo_producto` SET `cod_prod`= @code,`desc_prod`= @desc,`cant_prod`= @cant,`gana_prod`= @gana, `fecha_update`= @fecha,`user_update`= @user WHERE `id` = @id";
                MySqlCommand comm = new MySqlCommand(actualiza, conexion);

                comm.Parameters.Add("@code", MySqlDbType.VarChar).Value = txt_Codigo.Text.Trim();
                comm.Parameters.Add("@desc", MySqlDbType.VarChar).Value = txt_Descripción.Text.Trim();
                comm.Parameters.Add("@cant", MySqlDbType.VarChar).Value = txt_Cantidad.Text.Trim();
                comm.Parameters.Add("@gana", MySqlDbType.VarChar).Value = GananciaTotal;
                comm.Parameters.Add("@fecha", MySqlDbType.VarChar).Value = lbl_Fecha.Text.Trim();
                comm.Parameters.Add("@user", MySqlDbType.VarChar).Value = Global.usuarioLog.Trim();
                comm.Parameters.Add("@id", MySqlDbType.VarChar).Value = Global.id_producto;
                comm.ExecuteNonQuery();

                string mensaje = "Actualización exitosa...";
                string titulo = "Confirmación";
                MessageBoxButton boton = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBoxResult resultado;
                resultado = System.Windows.MessageBox.Show(mensaje, titulo, boton, icon);

                Limpiar();
                Tabla();
                Deshabilitar();
                Reestablecer();
                TotalCompra();
                TotalVenta();
                TotalGanancias();

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
        #endregion

        #region Eliminar registro
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = conexionSQL.Conectar();
                conexion.Open();
            }

            if (txt_Codigo.Text == "")
            {
                string mensaje = "Debe seleccionar el registro que desea eliminar...";
                string titulo = "Advertencia";
                MessageBoxButton boton = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Exclamation;
                MessageBoxResult resultado;
                resultado = System.Windows.MessageBox.Show(mensaje, titulo, boton, icon);
            }
            else
            {
                string borrar = "DELETE FROM `nuevo_producto` WHERE `id`= @id";
                MySqlCommand cmd = new MySqlCommand(borrar, conexion);
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = Global.id_producto;
                cmd.ExecuteNonQuery();

                string delete = "DELETE FROM `inventario` WHERE `id` = @id";
                MySqlCommand command = new MySqlCommand(delete, conexion);
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Global.id_producto;
                command.ExecuteNonQuery();

                string mensaje = "Eliminación exitosa...";
                string titulo = "Confirmación";
                MessageBoxButton boton = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBoxResult resultado;
                resultado = System.Windows.MessageBox.Show(mensaje, titulo, boton, icon);

                Limpiar();
                Deshabilitar();
                Reestablecer();
                Tabla();
                NRegistros();

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
        #endregion

        #endregion

        #region Cerrar Formulario
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Global.pestaña = false;
            this.Close();
        }
        #endregion

        #region Botón Cancelar
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Deshabilitar();
            Limpiar();
            Reestablecer();
            NRegistros();
        }
        #endregion

    }
}
