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
using System.Windows.Forms;

namespace Proyecto_PV.Formularios
{
    public partial class GUI_Inventario : Form
    {
        public GUI_Inventario()
        {
            InitializeComponent();
            Tabla();
        }

        #region Evento Load
        private void GUI_Inventario_Load(object sender, EventArgs e)
        {
            NRegistros();
            DGV_Inventario.ClearSelection();
        }
        #endregion
        #region Tabla
        private void Tabla()
        {
            DGV_Inventario.DataSource = LlenarTabla();
            DGV_Inventario.Columns[0].HeaderText = "CÓDIGO";
            DGV_Inventario.Columns[1].HeaderText = "DESCRIPCIÓN";
            DGV_Inventario.Columns[2].HeaderText = "PROVEEDOR";
            DGV_Inventario.Columns[3].HeaderText = "BODEGA";
            DGV_Inventario.Columns[4].HeaderText = "STOCK";
            DGV_Inventario.Columns[5].HeaderText = "V. COMPRA";
            DGV_Inventario.Columns[6].HeaderText = "V. VENTA";
            DGV_Inventario.Columns[7].HeaderText = "G. UNIDAD";
            DGV_Inventario.Columns[8].HeaderText = "T. GANANCIA";
            DGV_Inventario.Columns[9].HeaderText = "DESCUENTO";

            DGV_Inventario.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Inventario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV_Inventario.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV_Inventario.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV_Inventario.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Inventario.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Inventario.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Inventario.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Inventario.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Inventario.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DGV_Inventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void NRegistros()
        {
            int nreg = DGV_Inventario.Rows.Count;
            lbl_NRegistros.Text = "Total items: " + nreg.ToString();
            TotalCompra();
            TotalVenta();
            TotalGanancias();
        }

        private void TotalCompra()
        {
            double sumatoria_Compra = 0;
            foreach (DataGridViewRow row in DGV_Inventario.Rows)
            {
                sumatoria_Compra += Convert.ToDouble(row.Cells[5].Value) * Convert.ToDouble(row.Cells[4].Value);
            }
            string compra = sumatoria_Compra.ToString("#,#");
            txt_Total_Valor_Compra.Text = $"$ {compra}";
        }

        private void TotalVenta()
        {
            double sumatoria_Venta = 0;
            foreach (DataGridViewRow row in DGV_Inventario.Rows)
            {
                sumatoria_Venta += Convert.ToDouble(row.Cells[6].Value) * Convert.ToDouble(row.Cells[4].Value);
            }
            string venta = sumatoria_Venta.ToString("#,#");
            txt_Total_Valor_Venta.Text = $"$ {venta}";
        }

        private void TotalGanancias()
        {
            double sumatoria_Ganacias = 0;
            foreach (DataGridViewRow row in DGV_Inventario.Rows)
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
                DGV_Inventario.DataSource = datos.Tables[0];
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("Error en la busqueda dinamica del inventario...");
                System.Diagnostics.Debug.WriteLine(ex.ToString());

            }
           
            NRegistros();
            DGV_Inventario.ClearSelection();

            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
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

        
    }
}
