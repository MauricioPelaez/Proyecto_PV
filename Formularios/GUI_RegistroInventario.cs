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
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Global.pestaña = false;
            this.Close();
        }

        #region Load
        private void GUI_RegistroInventario_Load(object sender, EventArgs e)
        {
            Conectar();
            Bodegas();
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

        private void HabiliarCampos()
        {
            txt_Codigo.Enabled = true;
            txt_Descripción.Enabled = true;
            combo_Proveedor.Enabled = true;
            combo_Bodega.Enabled = true;
            txt_Cantidad.Enabled = true;
            txt_Stock.Enabled = true;
            txt_ValCompra.Enabled = true;
            txt_ValVenta.Enabled = true;
            combo_Descuento.Enabled = true;
            txt_Ganancia.Enabled = true;
        }

        private void DeshabiliarCampos()
        {
            txt_Codigo.Enabled = false;
            txt_Descripción.Enabled = false;
            combo_Proveedor.Enabled = false;
            combo_Bodega.Enabled = false;
            txt_Cantidad.Enabled = false;
            txt_Stock.Enabled = false;
            txt_ValCompra.Enabled = false;
            txt_ValVenta.Enabled = false;
            combo_Descuento.Enabled = false;
            txt_Ganancia.Enabled = false;
        }



        #endregion



        #region Base de datos

        #region Conexion BD

        MySqlConnection conexion = new MySqlConnection();
        public void Conectar()
        {
            try
            {
                conexion.ConnectionString = "server=localhost;user=root;password=1005771207;database=proyecto(pv)";
                conexion.Open();
            }
            catch (SqlException ex)
            {
                string mensaje = "Error al conectar con la base de datos";
                string titulo = "Error de conexion";
                MessageBoxButton boton = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult resultado;

                resultado = System.Windows.MessageBox.Show(mensaje, titulo, boton, icon);
                System.Windows.MessageBox.Show(ex.ToString(), "Error detectado...");
            }
        }



        #endregion

        #region Llenar ComboBox Bodegas
        private DataTable Cargar()
        {
            DataTable dt = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `bodega`", conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }

        private void Bodegas()
        {
            combo_Bodega.DataSource = Cargar();
            combo_Bodega.DisplayMember = "desc_bod";
            combo_Bodega.ValueMember = "id";
        }
        #endregion






        #endregion

        
    }
}
