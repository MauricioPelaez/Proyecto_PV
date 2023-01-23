using Proyecto_PV.Datos_Staticos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }




        #region Cerrar Formulario
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Global.pestaña = false;
            this.Close();
        }
        #endregion
    }
}
