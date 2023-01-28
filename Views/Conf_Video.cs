using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using Proyecto_PV.Datos_Staticos;

namespace Proyecto_PV.Views
{
    public partial class Conf_Video : Form
    {
        public Conf_Video()
        {
            InitializeComponent();
        }


        FilterInfoCollection CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

        private void Conf_Video_Load(object sender, EventArgs e)
        {
            try
            {
                CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo Device in CaptureDevices)
                {
                    int i = 1;

                    combo_Conect.Items.Add(Device.Name);
                    i++;
                }
            }
            catch
            {
                CaptureDevices = null;
            }

        }

        private void btn_Select_Cam_Click(object sender, EventArgs e)
        {
            Global.camara = combo_Conect.SelectedIndex;
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
