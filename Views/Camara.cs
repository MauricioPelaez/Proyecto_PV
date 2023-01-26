using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using AForge.Video.DirectShow;
using AForge.Video;
using Proyecto_PV.Views;

namespace Proyecto_PV.Views
{
    public partial class Camara : Form
    {

        private bool Hay_Dispositivos;
        private FilterInfoCollection Mis_Dispositivos;
        private VideoCaptureDevice Mi_WebCam;


        public Camara()
        {
            InitializeComponent();
           
        }

        private void Camara_Load(object sender, EventArgs e)
        {
            Cargar_Dispositivos();
        }

        public void Cargar_Dispositivos()
        {
            Mis_Dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if(Mis_Dispositivos.Count > 0)
            {
                Hay_Dispositivos = true;

                if(Hay_Dispositivos == true)
                {
                    for (int i = 0; i < Mis_Dispositivos.Count; i++)
                        combo_Cenecciones.Items.Add(Mis_Dispositivos[i].Name.ToString());

                    combo_Cenecciones.Text = Mis_Dispositivos[0].ToString();
                }
                
            }
            else
            {
                Hay_Dispositivos = false;
            }
        }

        public void Cerra_Cam()
        {
            if (Mi_WebCam != null && Mi_WebCam.IsRunning)
            {
                Mi_WebCam.SignalToStop();
                Mi_WebCam = null;
            }
        }

        private void botones1_Click(object sender, EventArgs e)
        {
            Cerra_Cam();
            int i = combo_Cenecciones.SelectedIndex;
            string NombreVide = Mis_Dispositivos[i].MonikerString;

            Mi_WebCam = new VideoCaptureDevice(NombreVide);
            Mi_WebCam.NewFrame += new NewFrameEventHandler(Capturando);
            Mi_WebCam.Start();
        }

        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            Img_Camara.Image = Imagen;

        }

        private void Camara_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cerra_Cam();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
