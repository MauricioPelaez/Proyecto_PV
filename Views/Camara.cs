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

        public int islendurumu = 0;
        FilterInfoCollection CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        private VideoCaptureDevice videoSource = null;
        public static int durdur = 0;
        public static int gonder = 0;
        public int karamelt = 0;

        private void Camara_Load(object sender, EventArgs e)
        {
            temporisador.Tick += new EventHandler(Cuenta);
            try
            {
                CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                foreach (FilterInfo Device in CaptureDevices)
                {
                    int i = 1;
                    combo_Conection.Items.Add(Device.Name);
                    i++;
                }

            }
            catch
            {
                CaptureDevices = null;
            }
           
        }

        public void Cerrar_Cam()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;

            }
        }

        private void Star_Cam()
        {

            lbl_Num.Text = Global.camara.ToString();
            lbl_Confirm.Text = "";
            if (islendurumu == 0)
            {
                if (karamelt > 0) return;

                try
                {
                    videoSource = new VideoCaptureDevice(CaptureDevices[Global.camara].MonikerString);
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
        

        private void tmr_Seg_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbl_Time.Text = Tiempo.ToString();
            Parar_Cont();

            if (lbl_Time.Text == "7")
            {
                Star_Cam();
                if (Global.camara < 0)
                {
                    lbl_Confirm.Text = "NO CAM ...";
                    lbl_Confirm.ForeColor = Color.White;
                }
            }

            if (Img_1.Image != null)
            {
                if (lbl_Time.Text == "5")
                {
                    Img_2.Image = Img_1.Image;

                    if (Global.camara >= 0)
                    {
                        lbl_Nombre_User.Text = Global.usuarioLog;
                        lbl_Tipo_user.Text = Global.tipoUsuarioLog;
                    }

                }
                

            }

            if (lbl_Time.Text == "3")
            {
                try
                {
                    if (Global.camara >= 0)
                    {
                        Img_2.Image.Save(@"C:\Punto_Venta\Fotos\foto_.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        lbl_Confirm.Text = "VALIDACIÓN EXÍTOSA";

                    }

                }
                catch { }
            }

            if (lbl_Time.Text == "1")
            {
                Cerrar_Cam();
            }

            if (lbl_Time.Text == "0")
            {
                GUI_Principal vent = new GUI_Principal();
                vent.Show();
                this.Close();
            }
            
        }

        #region Contador

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

        #endregion

        private void btn_Capture_Click(object sender, EventArgs e)
        {
            Img_2.Image = Img_1.Image;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.camara >= 0)
                {
                    Img_2.Image.Save(@"C:\Punto_Venta\Fotos\foto_.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    lbl_Confirm.Text = "IMAGEN GUARDADA";

                }

            }
            catch { }
        }
    }
}
