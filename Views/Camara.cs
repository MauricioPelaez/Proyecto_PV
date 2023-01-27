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
using AForge;
using Proyecto_PV.Views;
using Proyecto_PV.Datos_Staticos;

namespace Proyecto_PV.Views
{
    public partial class Camara : Form
    {
        public Camara()
        {
            InitializeComponent();

            temporisador.Interval = 1000;
            temporisador.Start();

        }

        /**
        private FilterInfoCollection Mis_Dispositivos;
        private VideoCaptureDevice Mi_WebCam;

        private void Camara_Load(object sender, EventArgs e)
        {
            Cargar_Dispositivos();
            combo_Cenecciones.SelectedIndex = 1;
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
            // ->Img_Camara.Image = Imagen;

        }

        private void Camara_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cerra_Cam();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        **/

        public int islendurumu = 0;
        FilterInfoCollection CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        private VideoCaptureDevice videoSource = null;
        public static int durdur = 0;
        public static int gonder = 0;
        public int karamelt = 0;
        public int selected = -1;

        private void Camara_Load(object sender, EventArgs e)
        {
            temporisador.Tick += new EventHandler(Cuenta);
            
            try
            {
                CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                foreach (FilterInfo Device in CaptureDevices)
                {
                    int i = 1;
                    combo_Conect.Items.Add(Device.Name);
                    i++;
                }
                combo_Conect.SelectedIndex = 1;
            }
            catch
            {
                CaptureDevices = null;
            }
           
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Star_Cam();
        }
        private void Star_Cam()
        {
            selected = Global.camara;
            lbl_Confirm.Text = "";
            if (islendurumu == 0)
            {
                if (karamelt > 0) return;

                try
                {
                    videoSource = new VideoCaptureDevice(CaptureDevices[selected].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
                    videoSource.Start();
                    karamelt = 1;
                }
                catch
                {

                    if (!(videoSource == null))
                        if (videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource = null;
                        }
                }

            }
        }


        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            Img_1.Image = img;
            
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(videoSource == null))
                {
                    videoSource.SignalToStop();
                    videoSource = null;
                }
            }
            catch { }
            
            Login login = new Login();
            login.Show();
            this.Close();
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                
                Img_2.Image.Save(@"C:\Punto_Venta\Fotos\foto.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                lbl_Confirm.Text = "IMAGEN GUARDADA";
            }
            catch { }
           
        }

        private void Camara_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Cerrar_Cam();
                Img_1.Image = null;
                Img_2.Image = null;
            
            }
            catch { }
        }
        public void Cerrar_Cam()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;

            }
        }

        private void tmr_Seg_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbl_Time.Text = Tiempo.ToString();
            Parar_Cont();

            if(lbl_Time.Text == "0")
            {
                GUI_Principal vent = new GUI_Principal();
                vent.Show();
                this.Close();
            }

            if (Img_1.Image != null)
            {
                if (lbl_Time.Text == "4")
                {
                    Img_2.Image = Img_1.Image;
                    
                }
                if (selected > 0)
                {
                    lbl_Nombre_User.Text = Global.usuarioLog;
                    lbl_Tipo_user.Text = Global.tipoUsuarioLog;
                }
               
            }

            if (lbl_Time.Text == "3")
            {
                try
                {
                    if(selected > 0)
                    {
                        Img_2.Image.Save(@"C:\Punto_Venta\Fotos\foto_.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        lbl_Confirm.Text = "VALIDACIÓN EXÍTOSA";
                        
                    }

                }
                catch { }
            }

            if (lbl_Time.Text == "6")
            {
                Star_Cam();
                if(selected <=0)
                {
                    lbl_Confirm.Text = "NO CAM ...";
                    lbl_Confirm.ForeColor= Color.White;
                }
            }

            if (lbl_Time.Text == "1")
            {
                Cerrar_Cam();
            }
        }

        public Timer temporisador = new Timer();
        public int Tiempo = 7;

        void Cuenta(object sender, EventArgs e)
        {
            Tiempo -= 1;
        }


        private void Parar_Cont()
        {
            if(lbl_Time.Text == "0")
            {
                temporisador.Stop();
                Tiempo = 7;
            }
        }
    }
}
