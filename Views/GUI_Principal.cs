using Proyecto_PV.Datos_Staticos;
using Proyecto_PV.Formularios;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;

namespace Proyecto_PV.Views
{
    public partial class GUI_Principal : Form
    {
        public GUI_Principal()
        {
            InitializeComponent();
        }

        #region Load Principal
        private void GUI_Principal_Load(object sender, EventArgs e)
        {
            lbl_User.Text = Global.usuarioLog;
            lbl_tipoUser.Text = Global.tipoUsuarioLog;

            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
        #endregion

        #region Mover Formulario

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
        private void pnl_Formularios_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            B_Maxim();
        }


        #endregion

        #region Botones Cabecera
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            if(Global.pestaña == true)
            {
                string mensaje = "Aun tiene un formulario abierto";
                string titulo = "Advertencia";

                MessageBoxButton boton = MessageBoxButton.OK;
                MessageBoxImage icono = MessageBoxImage.Exclamation;
                MessageBoxResult resultado;

                resultado = System.Windows.MessageBox.Show(mensaje, titulo, boton, icono);
            }
            else
            {
                string mensajeText = "¿Desea cerrar la sesión?";
                string caption = "Cerrar sesión";

                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxImage icon = MessageBoxImage.Question;
                MessageBoxResult result;

                result = System.Windows.MessageBox.Show(mensajeText, caption, button, icon);

                if (result == MessageBoxResult.Yes)
                {
                    this.Close();
                }
            }

        }
       
        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btn_Maximizar.Visible = false;
            btn_Restaurar.Visible = true;
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btn_Maximizar.Visible = true;
            btn_Restaurar.Visible = false;
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Expandir / Retraer Menu

        private void ExpandirMenu()
        {
            pnl_Menu.Width = 200;
        }

        private void RetraerMenu()
        {
            pnl_Menu.Width = 70;
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (pnl_Menu.Width == 200)
            {
                RetraerMenu();
            }
            else
            {
                ExpandirMenu();
            }  
        }

        #endregion

        #region Mostrar / Ocultar SubInventario

        private void Mostrar_SubInv()
        {
            pnl_SunInv.Visible = true;
            pnl_SunInv.Height = 200;

            pnl_Dec3.Location = new Point(0, 400);
            btn_ConteoCaja.Location = new Point(0, 400);

            pnl_Dec4.Location = new Point(0, 450);
            btn_Clientes.Location = new Point(0, 450);

            pnl_Dec5.Location = new Point(0, 500);
            btn_TotalVentas.Location = new Point(0, 500);

            pnl_Dec6.Location = new Point(0, 550);
            btn_Creditos.Location = new Point(0, 550);

            pnl_Dec7.Location = new Point(0, 600);
            btn_Proveedores.Location = new Point(0, 600);

            pnl_Dec8.Location = new Point(0, 650);
            btn_Gastos.Location = new Point(0, 650);

            pnl_Dec9.Location = new Point(0, 700);
            btn_Configuracion.Location = new Point(0, 700);
        }

        private void Ocultar_SubInv()
        {
            pnl_SunInv.Visible = false;
            pnl_SunInv.Height = 0;

            pnl_Dec3.Location = new Point(0, 200);
            btn_ConteoCaja.Location = new Point(0, 200);

            pnl_Dec4.Location = new Point(0, 250);
            btn_Clientes.Location = new Point(0, 250);

            pnl_Dec5.Location = new Point(0, 300);
            btn_TotalVentas.Location = new Point(0, 300);

            pnl_Dec6.Location = new Point(0, 350);
            btn_Creditos.Location = new Point(0, 350);

            pnl_Dec7.Location = new Point(0, 400);
            btn_Proveedores.Location = new Point(0, 400);

            pnl_Dec8.Location = new Point(0, 450);
            btn_Gastos.Location = new Point(0, 450);

            pnl_Dec9.Location = new Point(0, 500);
            btn_Configuracion.Location = new Point(0, 500);
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            Ocultar_SubClient();
            Ocultar_SubConfi();
            if (pnl_SunInv.Height == 200)
            {
                Ocultar_SubInv();
            }
            else
            {
                Mostrar_SubInv();
            }
        }
        #endregion

        #region Mostrar / Ocultar SubClientes
        private void Mostrar_SubClient()
        {
            pnl_subClient.Visible = true;
            pnl_subClient.Height = 100;

            pnl_Dec5.Location = new Point(0, 400);
            btn_TotalVentas.Location = new Point(0, 400);

            pnl_Dec6.Location = new Point(0, 450);
            btn_Creditos.Location = new Point(0, 450);

            pnl_Dec7.Location = new Point(0, 500);
            btn_Proveedores.Location = new Point(0, 500);

            pnl_Dec8.Location = new Point(0, 550);
            btn_Gastos.Location = new Point(0, 550);

            pnl_Dec9.Location = new Point(0, 600);
            btn_Configuracion.Location = new Point(0, 600);
        }

        private void Ocultar_SubClient()
        {
            pnl_subClient.Visible = false;
            pnl_subClient.Height = 0;

            pnl_Dec5.Location = new Point(0, 300);
            btn_TotalVentas.Location = new Point(0, 300);

            pnl_Dec6.Location = new Point(0, 350);
            btn_Creditos.Location = new Point(0, 350);

            pnl_Dec7.Location = new Point(0, 400);
            btn_Proveedores.Location = new Point(0, 400);

            pnl_Dec8.Location = new Point(0, 450);
            btn_Gastos.Location = new Point(0, 450);

            pnl_Dec9.Location = new Point(0, 500);
            btn_Configuracion.Location = new Point(0, 500);
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            Ocultar_SubInv();
            Ocultar_SubConfi();

            if(pnl_subClient.Height == 100)
            {
                Ocultar_SubClient();
            }
            else
            {
                Mostrar_SubClient();
            }
        }

        #endregion

        #region Eventos Botones Cliente

        private void btn_RegistrarClient_Click(object sender, EventArgs e)
        {

        }

        private void btn_ConsultarClient_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region  Mostrar / Ocultar SubIConfi
        private void Mostrar_SubConfi()
        {
            pnl_SubConfi.Visible = true;
            pnl_SubConfi.Height = 100;
        }

        private void Ocultar_SubConfi()
        {
            pnl_SubConfi.Visible = false;
            pnl_SubConfi.Height = 0;
        }

        private void btn_Configuracion_Click(object sender, EventArgs e)
        {
            Ocultar_SubInv();
            Ocultar_SubClient();

            if (pnl_SubConfi.Height == 100)
            {
                Ocultar_SubConfi();
            }
            else
            {
                Mostrar_SubConfi();
            }
        }
        #endregion

        #region Eventos Botones Configuración
        private void btn_Usuarios_Click(object sender, EventArgs e)
        {

        }

        private void btn_Empresa_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Fecha y hora
        private void tmr_Reloj_Tick(object sender, EventArgs e)
        {
            lbl_Fecha.Text = DateTime.Now.ToLongDateString();
            lbl_Hora.Text = DateTime.Now.ToString("hh:mm:ss tt");    
        }

        #endregion

        #region Abrir formularios

        private Form ventana = null;
        private void AbrirFormulario(Form formulario)
        {
            if (Global.pestaña == false)
            {
                Global.pestaña = true;
                if (ventana != null)
                {
                    ventana.Close();
                }

                ventana = formulario;
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnl_Formularios.Controls.Add(formulario);
                pnl_Formularios.Tag = formulario;
                formulario.BringToFront();
                formulario.Show();
            }

        }

        public void RetraerTodo()
        {
            Ocultar_SubInv();
            Ocultar_SubClient();
            Ocultar_SubConfi();
            RetraerMenu();
        }

        //Proveedores
        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new GUI_Proveedores());
            RetraerTodo();
        }

        //Registro de inventario
        private void btn_RegistroInv_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new GUI_RegistroInventario());
            RetraerTodo();
        }

        private void btn_ConsultaInv_Click(object sender, EventArgs e)
        {

        }

        private void bnt_BodegaInv_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new GUI_Bodegas());
            RetraerTodo();
        }

        private void btn_Descuento_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
