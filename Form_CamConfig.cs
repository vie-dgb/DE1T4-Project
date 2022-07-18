using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.Util;

namespace DE1T4_Project
{
    public partial class Form_CamConfig : Form
    {
        public Form_CamConfig()
        {
            InitializeComponent();
        }

        public void getCamConfig(ref CamConfig cam, ref VideoCapture videocap)
        {
            cam.Brightness = videocap.Get(CapProp.Brightness);
            cam.Contrast = videocap.Get(CapProp.Contrast);
            cam.Hue = videocap.Get(CapProp.Hue);
            cam.Gain = videocap.Get(CapProp.Gain);
            cam.Sharpness = videocap.Get(CapProp.Sharpness);
            cam.Gamma = videocap.Get(CapProp.Gamma);
            cam.WhiteBalanceRedV = videocap.Get(CapProp.WhiteBalanceRedV);
            cam.Autofocus = videocap.Get(CapProp.Autofocus);
        }

        private void Form_CamConfig_Load(object sender, EventArgs e)
        {
            getCamConfig(ref settingCam.configCam, ref Cam_S.CamProcess);

            tbx_Brightness.Text = settingCam.configCam.Brightness.ToString();
            tbx_Contrast.Text = settingCam.configCam.Contrast.ToString();
            tbx_Hue.Text = settingCam.configCam.Hue.ToString();
            tbx_Gain.Text = settingCam.configCam.Gain.ToString();
            tbx_Sharpness.Text = settingCam.configCam.Sharpness.ToString();
            tbx_Gamma.Text = settingCam.configCam.Gamma.ToString();
            tbx_WhiteBalanceRedV.Text = settingCam.configCam.WhiteBalanceRedV.ToString();
            tbx_AutoFocus.Text = settingCam.configCam.Autofocus.ToString();
        }

        private void btn_config_apply_Click(object sender, EventArgs e)
        {
            settingCam.configCam.Brightness = double.Parse(tbx_Brightness.Text);
            settingCam.configCam.Contrast = double.Parse(tbx_Contrast.Text);
            settingCam.configCam.Hue = double.Parse(tbx_Hue.Text);
            settingCam.configCam.Gain = double.Parse(tbx_Gain.Text);
            settingCam.configCam.Sharpness = double.Parse(tbx_Sharpness.Text);
            settingCam.configCam.Gamma = double.Parse(tbx_Gamma.Text);
            settingCam.configCam.WhiteBalanceRedV = double.Parse(tbx_WhiteBalanceRedV.Text);
            settingCam.configCam.Autofocus = double.Parse(tbx_AutoFocus.Text);

            Cam_S.CamProcess.Set(CapProp.Brightness, settingCam.configCam.Brightness);
            Cam_S.CamProcess.Set(CapProp.Contrast, settingCam.configCam.Contrast);
            Cam_S.CamProcess.Set(CapProp.Hue, settingCam.configCam.Hue);
            Cam_S.CamProcess.Set(CapProp.Gain, settingCam.configCam.Gain);
            Cam_S.CamProcess.Set(CapProp.Sharpness, settingCam.configCam.Sharpness);
            Cam_S.CamProcess.Set(CapProp.Gamma, settingCam.configCam.Gamma);
            Cam_S.CamProcess.Set(CapProp.WhiteBalanceRedV, settingCam.configCam.WhiteBalanceRedV);
            Cam_S.CamProcess.Set(CapProp.Autofocus, settingCam.configCam.Autofocus);

            Cam_S.CamProcess.Set(CapProp.FrameHeight, Convert.ToDouble(500));
            Cam_S.CamProcess.Set(CapProp.FrameWidth, Convert.ToDouble(500));
        }

        private void Form_CamConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Status.CamSetting = false;
        }
    }
}
