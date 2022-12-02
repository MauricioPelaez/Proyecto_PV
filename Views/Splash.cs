using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PV.Views;

namespace Proyecto_PV
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            if (barra_Progreso.Value < 100)
            {
                barra_Progreso.Value = barra_Progreso.Value + 1;
                lbl_Carga.Text = "Cargando... " + barra_Progreso.Value + "%";
            }
            else
            {
                temporizador.Enabled = false;

                Login ventana = new Login();
                ventana.Show();
                this.Close();
            }
        }
    }
  
}
