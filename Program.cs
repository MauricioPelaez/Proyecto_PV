using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PV
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Splash main = new Splash();
            main.FormClosed += Terminar_Ejecucion;
            main.Show();
            Application.Run();
        }

        private static void Terminar_Ejecucion(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= Terminar_Ejecucion;
            
            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed +=Terminar_Ejecucion;
            }
        }

    }
}
