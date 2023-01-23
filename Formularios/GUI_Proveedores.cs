using MySql.Data.MySqlClient;
using Proyecto_PV.ConexionDB;
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
    public partial class GUI_Proveedores : Form
    {
        public GUI_Proveedores()
        {
            InitializeComponent();
            Tabla();
        }

        #region Load
        private void GUI_Proveedores_Load(object sender, EventArgs e)
        {
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            DGV_Proveedores.ClearSelection();
            NRegistros();
        }
        #endregion

        #region Color borde del GroupBox
        private void gb_DatosProv_Paint(object sender, PaintEventArgs e)
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

        #region Tabla
        private void Tabla()
        {
            DGV_Proveedores.DataSource = LlenarTabla();
            DGV_Proveedores.Columns[0].HeaderText = "NIT/CÉDULA";
            DGV_Proveedores.Columns[1].HeaderText = "NOMBRE";
            DGV_Proveedores.Columns[2].HeaderText = "E-MAIL";
            DGV_Proveedores.Columns[3].HeaderText = "TELÉFONO";
            DGV_Proveedores.Columns[4].HeaderText = "FUNCIÓN"; 

            DGV_Proveedores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV_Proveedores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV_Proveedores.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV_Proveedores.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV_Proveedores.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DGV_Proveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void NRegistros()
        {
            int nreg = DGV_Proveedores.Rows.Count;
            lbl_NRegistros.Text = "Total items: " + nreg.ToString();
        }
        #endregion

        #region Habilitar / Deshabilitar
        private void Habilitar()
        {
            txt_Nit.Enabled = true;
            txt_NombreProv.Enabled = true;
            txt_EmailProv.Enabled = true;
            txt_TelefonoProv.Enabled = true;
            combo_FuncionProv.Enabled = true;
        }
        private void Deshabilitar()
        {
            txt_Nit.Enabled = false;
            txt_NombreProv.Enabled = false;
            txt_EmailProv.Enabled = false;
            txt_TelefonoProv.Enabled = false;
            combo_FuncionProv.Enabled = false;
        }
        private void Limpiar()
        {
            txt_Nit.Text = "";
            txt_NombreProv.Text = "";
            txt_EmailProv.Text = "";
            txt_TelefonoProv.Text = "";
            combo_FuncionProv.SelectedIndex = 0;
            DGV_Proveedores.ClearSelection();
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

        #region Saltos de linea
        private void txt_Nit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_NombreProv.Focus();
                e.Handled = true;
            }
        }

        private void txt_NombreProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_EmailProv.Focus();
                e.Handled = true;
            }
        }

        private void txt_EmailProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_TelefonoProv.Focus();
                e.Handled = true;
            }
        }

        private void txt_TelefonoProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                combo_FuncionProv.Focus();
                e.Handled = true;
            }
        }

        #endregion

        #region Base de Datos

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
                string query = "SELECT `nit_prov`, `nom_provee`, `mail_prov`, `tel_prov`, `func_prov` FROM `proveedor`";
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
        private void DGV_Proveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_Nit.Text = DGV_Proveedores.CurrentRow.Cells[0].Value.ToString();
                txt_NombreProv.Text = DGV_Proveedores.CurrentRow.Cells[1].Value.ToString();
                txt_EmailProv.Text = DGV_Proveedores.CurrentRow.Cells[2].Value.ToString();
                txt_TelefonoProv.Text = DGV_Proveedores.CurrentRow.Cells[3].Value.ToString();
                combo_FuncionProv.SelectedItem = DGV_Proveedores.CurrentRow.Cells[4].Value.ToString();
                Habilitar();
                txt_Nit.Focus();
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

                string query = "SELECT `id` FROM `proveedor` WHERE `nit_prov` = @nit";
                MySqlCommand command = new MySqlCommand(query, conexion);
                command.Parameters.Add("@nit", MySqlDbType.VarChar).Value = txt_Nit.Text;
                command.CommandTimeout = 60;
                Global.id_proveedor = Convert.ToString(command.ExecuteScalar());

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
        #endregion

        #region Busqueda dinamica
        private void txt_Buscar_TextChanged_1(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = conexionSQL.Conectar();
                conexion.Open();
            }

            string query = "SELECT `nit_prov`, `nom_provee`, `mail_prov`, `tel_prov`, `func_prov` FROM `proveedor` WHERE `nit_prov` LIKE '%" + txt_Buscar.Text + "%' Or `nom_provee` LIKE '%" + txt_Buscar.Text + "%' Or `mail_prov` LIKE '%" + txt_Buscar.Text + "%' Or `tel_prov` LIKE '%" + txt_Buscar.Text + "%' Or `func_prov` LIKE '%" + txt_Buscar.Text + "%'";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.CommandTimeout = 60;
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

            DataSet datos = new DataSet();
            adapter.Fill(datos);

            try
            {
                DGV_Proveedores.DataSource = datos.Tables[0];
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error en la busqueda dinamica de los proveedores...");
                Console.WriteLine(ex.ToString());
            }

            NRegistros();
            DGV_Proveedores.ClearSelection();

            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
        #endregion

        #region Agregar nuevo registro

        #region Botón Nuevo
        private void btn_Nuevo_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar();
            btn_Guardar.Enabled = true;
            btn_Eliminar.Enabled = false;
            btn_Actualiazar.Enabled = false;
            btn_Nuevo.Enabled = false;
            txt_Nit.Focus();
        }
        #endregion

        private void btn_Guardar_Click_1(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = conexionSQL.Conectar();
                conexion.Open();
            }
            if (txt_Nit.Text == "" || txt_NombreProv.Text == "" || txt_EmailProv.Text == "" || txt_TelefonoProv.Text == "" || combo_FuncionProv.SelectedIndex == 0)
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
                string query = "SELECT `nit_prov`, `nom_provee`, `mail_prov`, `tel_prov`, `func_prov`  FROM `proveedor` WHERE `nit_prov` = @nit";
                MySqlCommand command = new MySqlCommand(query, conexion);
                command.Parameters.Add("@nit", MySqlDbType.VarChar).Value = txt_Nit.Text;
                command.CommandTimeout = 60;

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet datos = new DataSet();
                adapter.Fill(datos, "proveedor");

                int lista = datos.Tables["proveedor"].Rows.Count;

                if (lista != 0)
                {
                    string mensaje = "El proveedor ya se encuentra registrado...";
                    string titulo = "Nit de proveedor existente";
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
                        string insert = "INSERT INTO `proveedor`(`nit_prov`, `nom_provee`, `mail_prov`, `tel_prov`, `func_prov`, `fecha_insert`, `user_insert`, `fecha_update`, `user_update`) VALUES (@nit, @nombre, @mail, @phone, @func, @fecha, @user, @fecha, @user)";
                        MySqlCommand comando = new MySqlCommand(insert, conexion);
                        comando.Parameters.Add("@nit", MySqlDbType.VarChar).Value = txt_Nit.Text.Trim();
                        comando.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = txt_NombreProv.Text.Trim();
                        comando.Parameters.Add("@mail", MySqlDbType.VarChar).Value = txt_EmailProv.Text.Trim();
                        comando.Parameters.Add("@phone", MySqlDbType.VarChar).Value = txt_TelefonoProv.Text.Trim();
                        comando.Parameters.Add("@func", MySqlDbType.VarChar).Value = combo_FuncionProv.SelectedItem;
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
        private void btn_Actualiazar_Click_1(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = conexionSQL.Conectar();
                conexion.Open();
            }

            if (txt_Nit.Text == "" || txt_NombreProv.Text == "" || txt_EmailProv.Text == "" || txt_TelefonoProv.Text == "" || combo_FuncionProv.SelectedIndex == 0)
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
                string update = "UPDATE `proveedor` SET `nit_prov`= @nit,`nom_provee`= @nombre,`mail_prov`= @mail,`tel_prov`= @phone,`func_prov`= @func,`fecha_update`= @fecha,`user_update`= @user WHERE `id` = @id";
                MySqlCommand command = new MySqlCommand(update, conexion);
                command.Parameters.Add("@nit", MySqlDbType.VarChar).Value = txt_Nit.Text.Trim();
                command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = txt_NombreProv.Text.Trim();
                command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = txt_EmailProv.Text.Trim();
                command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = txt_TelefonoProv.Text.Trim();
                command.Parameters.Add("@func", MySqlDbType.VarChar).Value = combo_FuncionProv.SelectedItem;
                command.Parameters.Add("@fecha", MySqlDbType.VarChar).Value = lbl_Fecha.Text.Trim();
                command.Parameters.Add("@user", MySqlDbType.VarChar).Value = Global.usuarioLog.Trim();
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Global.id_proveedor;

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
        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = conexionSQL.Conectar();
                conexion.Open();
            }

            if (txt_Nit.Text == "" || txt_NombreProv.Text == "" || txt_EmailProv.Text == "" || txt_TelefonoProv.Text == "" || combo_FuncionProv.SelectedIndex == 0)
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
                string delete = "DELETE FROM `proveedor` WHERE `id` = @id";
                MySqlCommand command = new MySqlCommand(delete, conexion);
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Global.id_proveedor;
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
