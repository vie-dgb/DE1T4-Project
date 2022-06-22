using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

using Emgu.CV;
using Emgu.CV.Structure;
using System.Xml.Serialization;
using System.IO;

namespace DE1T4_Project
{
    public partial class Form_CamSetting : Form
    {
        public static System.Timers.Timer _timer;
        public Form_CamSetting()
        {
            InitializeComponent();
        }

        private void Form_CamSetting_Load(object sender, EventArgs e)
        {
            setCamTimer.Interval = 500/Convert.ToInt32(settingCam.fps);
            setCamTimer.Enabled = true;
            setCamTimer.Start();
        }

        private void Form_CamSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            setCamTimer.Stop();
            setCamTimer.Enabled = false;
            settingCam.IsConFig = false;
        }

        private void setCamTimer_Tick(object sender, EventArgs e)
        {
            if (!settingCam.set_Frame.IsEmpty)
            {
                Image tmpImg = settingCam.set_Frame.ToImage<Bgr, byte>().ToBitmap();
                picBox_config.Image = tmpImg;
            }
        }

        private void imgBox_Config_Paint(object sender, PaintEventArgs e)
        {
            if (settingCam.rect != null)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRectangle());
            }
        }

        private Rectangle GetRectangle()
        {
            settingCam.rect = new Rectangle();
            settingCam.rect.X = Math.Min(settingCam.StartLocation.X, settingCam.EndLcation.X);
            settingCam.rect.Y = Math.Min(settingCam.StartLocation.Y, settingCam.EndLcation.Y);
            settingCam.rect.Width = Math.Abs(settingCam.StartLocation.X - settingCam.EndLcation.X);
            settingCam.rect.Height = Math.Abs(settingCam.StartLocation.Y - settingCam.EndLcation.Y);

            return settingCam.rect;
        }

        private void picBox_config_MouseDown(object sender, MouseEventArgs e)
        {
            settingCam.IsMouseDown = true;
            settingCam.StartLocation = e.Location;
            settingCam.updateFrame = true;
        }

        private void picBox_config_MouseMove(object sender, MouseEventArgs e)
        {
            if (settingCam.IsMouseDown == true)
            {
                settingCam.EndLcation = e.Location;
                picBox_config.Invalidate();
            }
        }

        private void picBox_config_Paint(object sender, PaintEventArgs e)
        {
            if (settingCam.rect != null)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRectangle());
            }
        }

        private void picBox_config_MouseUp(object sender, MouseEventArgs e)
        {
            if (settingCam.IsMouseDown == true)
            {
                settingCam.EndLcation = e.Location;
                settingCam.IsMouseDown = false;
                accessData.saveCamData(settingCam.rect);
                settingCam.updateFrame = false;
            }
        }

        private void btn_config_reframe_Click(object sender, EventArgs e)
        {
            settingCam.StartLocation = new Point(0, 0);
            settingCam.EndLcation = new Point(0,0);
            GetRectangle();
            accessData.saveCamData(settingCam.rect);
        }
    }
}
