using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Proyecto_PV.Datos_Staticos;

namespace Proyecto_PV.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUser.Focus();
        }

        #region ver Contraseña
        private void chk_VerPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        #endregion

        #region Salto de linea
        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbl_Validacion.Visible = false;

            if (e.KeyChar == 13)
            {
                txtPass.Focus();
                e.Handled = true;
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_Iniciar.Focus();
                e.Handled = true;
                btn_Iniciar.BorderSize = 0;
                btn_Iniciar.BackColor = Color.FromArgb(25, 0, 50);
            }
        }
        #endregion

        #region Botones Cabecera
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btn_Maximizar.Visible = true;
            btn_Restaurar.Visible = false;

        }

        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btn_Maximizar.Visible = false;
            btn_Restaurar.Visible = true;
        }
        #endregion

        #region Mover Interface

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int eParam, int lParam);
        public void B_Maxim()
        {
            if (this.Height <= 700 && this.Width <= 1100)
            {
                btn_Maximizar.Visible = true;
                btn_Restaurar.Visible = false;
            }
        }

        private void pnl_Cabecera_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            B_Maxim();
        }

        private void pnl_Pie_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            B_Maxim();
        }

        private void pnl_Principal_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            B_Maxim();
        }

        #endregion

        #region Base de datos

        MySqlConnection conexion = new MySqlConnection();
        ConexionDB.ConexionSQL conexionSQL = new ConexionDB.ConexionSQL();

        #region Iniciar Sesion
        private void IniciarSesion()
        {
            try
            {
                conexion.ConnectionString = conexionSQL.Conectar();
                if(conexion.State == ConnectionState.Closed) 
                {
                    conexion.Open();
                }
                
                string cadena = "SELECT `Usuario`, `Contraseña` FROM `login` WHERE `Usuario` = @user AND `Contraseña` = @pass";
                MySqlCommand comando = new MySqlCommand(cadena, conexion);
                comando.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtUser.Text;
                comando.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPass.Text;
                comando.CommandTimeout = 60;

                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                if (tabla.Rows.Count == 0)
                {
                    lbl_Validacion.Visible = true;
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtUser.Focus();
                    btn_Iniciar.BackColor = Color.FromArgb(5, 0, 10);
                    lbl_UserIng.Visible = false;
                    lbl_TipoUserIng.Visible = false;
                }
                else
                {

                    GUI_Principal ventana = new GUI_Principal();
                    ventana.Show();
                    this.Close();

                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }

                }
            }
            catch(MySqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                conexion.Close();
                txtUser.Text = "";
                txtPass.Text = "";
                txtUser.Focus();
                lbl_UserIng.Visible = false;
                lbl_TipoUserIng.Visible = false;
                btn_Iniciar.BackColor = Color.FromArgb(5, 0, 10);
            }

        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void btn_Iniciar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                IniciarSesion();
                e.Handled = true;
            }
        }

        #endregion

        #region Ver nombre y tipo del usuario ingresado
        private void txtUser_TextChanged_1(object sender, EventArgs e)
        {
            conexion.ConnectionString = conexionSQL.Conectar();
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            //Mostrar nombre del usuario ingresado
            string cadena = "SELECT `Nombre` FROM `login` WHERE `Usuario` = @user";
            MySqlCommand command = new MySqlCommand(cadena, conexion);
            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtUser.Text;
            command.CommandTimeout= 60;
            lbl_UserIng.Text = Convert.ToString(command.ExecuteScalar());
            lbl_UserIng.Visible = true;

            //Mostrar el tipo de usuario ingresado
            MySqlCommand cmd = new MySqlCommand("SELECT `Tipo` FROM `login` WHERE `Usuario` = @user", conexion);
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtUser.Text;
            lbl_TipoUserIng.Text = Convert.ToString(cmd.ExecuteScalar());
            lbl_TipoUserIng.Visible = true;

            Global.usuarioLog = lbl_UserIng.Text;
            Global.tipoUsuarioLog = lbl_TipoUserIng.Text;

            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        #endregion

        #endregion

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
