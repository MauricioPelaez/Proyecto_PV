using MySql.Data.MySqlClient;
using Proyecto_PV.Datos_Staticos;
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
    public partial class GUI_Bodegas : Form
    {
        public GUI_Bodegas()
        {
            InitializeComponent();       
            Tabla();
        }

        #region Color borde del GroupBox    
        private void gb_DatosBod_Paint_1(object sender, PaintEventArgs e)
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

        #region Evento load
        private void GUI_Bodegas_Load(object sender, EventArgs e)
        {
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            DGV_Bodegas.ClearSelection();
            NRegistros();
        }
        #endregion

        #region Tabla
        private void Tabla()
        {
            DGV_Bodegas.DataSource = LlenarTabla();
            DGV_Bodegas.Columns[0].HeaderText = "CÓDIGO";
            DGV_Bodegas.Columns[1].HeaderText = "DESCRIPCIÓN";

            DGV_Bodegas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV_Bodegas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DGV_Bodegas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void NRegistros()
        {
            int nreg = DGV_Bodegas.Rows.Count;
            lbl_NRegistros.Text = "Total items: " + nreg.ToString();
        }
        #endregion

        #region Habilitar / Deshabilitar
        private void Habilitar()
        {
            txt_CodigoBod.Enabled = true;
            txt_DescripcioBod.Enabled = true;
        }
        private void Deshabilitar()
        {
            txt_CodigoBod.Enabled = false;
            txt_DescripcioBod.Enabled = false;
        }
        private void Limpiar()
        {
            txt_CodigoBod.Text = "";
            txt_DescripcioBod.Text = "";
            DGV_Bodegas.ClearSelection();
        }

        private void Reestablecer()
        {
            btn_Nuevo.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_Actualiazar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Cancelar.Enabled = true;
        }
        #endregion

        #region Selecionar registro (Tabla)
        private void DGV_Bodegas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_CodigoBod.Text = DGV_Bodegas.CurrentRow.Cells[0].Value.ToString();
                txt_DescripcioBod.Text = DGV_Bodegas.CurrentRow.Cells[1].Value.ToString();
                Habilitar();
                txt_CodigoBod.Focus();
                txt_Buscar.Text = "";
                btn_Guardar.Enabled = false;
                btn_Actualiazar.Enabled = true;
                btn_Eliminar.Enabled = true;
                btn_Nuevo.Enabled = true;


                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.ConnectionString = conexionSQL.Conectar();
                    conexion.Open();
                }

                string query = "SELECT `id` FROM `bodega` WHERE `cod_bod` = @code Or `desc_bod` = @desc";
                MySqlCommand command = new MySqlCommand(query, conexion);
                command.Parameters.Add("@code", MySqlDbType.VarChar).Value = txt_CodigoBod.Text;
                command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = txt_DescripcioBod.Text;
                Global.id_bodega = Convert.ToString(command.ExecuteScalar());

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            
        }
        #endregion

        #region Salto de linea
        private void txt_CodigoBod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_DescripcioBod.Focus();
                e.Handled = true;
            }
        }
        #endregion

        #region Base de datos

        MySqlConnection conexion = new MySqlConnection();
        ConexionDB.ConexionSQL conexionSQL = new ConexionDB.ConexionSQL();

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
                string query = "SELECT `cod_bod`, `desc_bod` FROM `bodega`";
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

        #region Busqueda dinamica
        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = conexionSQL.Conectar();
                conexion.Open();
            }

            string cadena = "SELECT `cod_bod`, `desc_bod` FROM `bodega` WHERE `cod_bod` LIKE '%" + txt_Buscar.Text + "%' Or `desc_bod` LIKE '%" + txt_Buscar.Text + "%'";
            MySqlCommand comando = new MySqlCommand(cadena, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

            DataSet datos = new DataSet();
            adapter.Fill(datos);

            try
            {
                DGV_Bodegas.DataSource = datos.Tables[0];
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

        #region Agregar nuevo registro

        #region Botón Nuevo
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar();
            btn_Guardar.Enabled = true;
            btn_Eliminar.Enabled = false;
            btn_Actualiazar.Enabled = false;
            btn_Nuevo.Enabled = false;
            txt_CodigoBod.Focus();
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
            if (txt_CodigoBod.Text == "" || txt_DescripcioBod.Text == "")
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
                string cadena = "SELECT * FROM `bodega` WHERE `cod_bod` = @code";
                MySqlCommand command = new MySqlCommand(cadena, conexion);
                command.Parameters.Add("@code", MySqlDbType.VarChar).Value = txt_CodigoBod.Text;

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet datos = new DataSet();
                adapter.Fill(datos, "bodega");

                int lista = datos.Tables["bodega"].Rows.Count;

                if (lista != 0)
                {
                    string mensaje = "La bodega ya se encuentra registrada...";
                    string titulo = "Código de bodega existente";
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
                        string insert = "INSERT INTO `bodega`(`cod_bod`, `desc_bod`, `fecha_insert`, `user_insert`, `fecha_update`, `user_update`) VALUES (@code, @desc, @fecha, @user, @fecha, @user)";
                        MySqlCommand comando = new MySqlCommand(insert, conexion);
                        comando.Parameters.Add("@code", MySqlDbType.VarChar).Value = txt_CodigoBod.Text.Trim();
                        comando.Parameters.Add("@desc", MySqlDbType.VarChar).Value = txt_DescripcioBod.Text.Trim();
                        comando.Parameters.Add("@fecha", MySqlDbType.VarChar).Value = lbl_Fecha.Text.Trim();
                        comando.Parameters.Add("@user", MySqlDbType.VarChar).Value = Global.usuarioLog.Trim();

                        MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                        DataTable DT = new DataTable();
                        adaptador.Fill(DT);

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

                        Console.WriteLine(ex.Message);
                        conexion.Dispose();
                    }

                }

            }
        }
        #endregion

        #region Actualizar registro
        private void btn_Actualiazar_Click(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = conexionSQL.Conectar();
                conexion.Open();
            }

            if (txt_CodigoBod.Text == "" || txt_DescripcioBod.Text == "")
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
                string update = "UPDATE `bodega` SET `cod_bod`= @code,`desc_bod`= @desc,`fecha_update`= @fecha,`user_update`= @user WHERE `id` = @id";
                MySqlCommand command = new MySqlCommand(update, conexion);
                command.Parameters.Add("@code", MySqlDbType.VarChar).Value = txt_CodigoBod.Text.Trim();
                command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = txt_DescripcioBod.Text.Trim();
                command.Parameters.Add("@fecha", MySqlDbType.VarChar).Value = lbl_Fecha.Text.Trim();
                command.Parameters.Add("@user", MySqlDbType.VarChar).Value = Global.usuarioLog.Trim();
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Global.id_bodega;

                command.ExecuteNonQuery();

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

            if (txt_CodigoBod.Text == "" || txt_DescripcioBod.Text == "")
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
                string delete = "DELETE FROM `bodega` WHERE `id` = @id";
                MySqlCommand command = new MySqlCommand(delete, conexion);
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Global.id_bodega;
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

        #region Botón Cancelar
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Deshabilitar();
            Limpiar();
            Reestablecer();
            NRegistros();
        }
        #endregion

        #region Cerrar Formulario
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Global.pestaña = false;
            this.Close();
        }
        #endregion
        
    }
}
