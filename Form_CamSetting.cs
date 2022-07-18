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
            string tmp = Convert.ToString(Math.Round(settingCam.calibCam.Ratio_Width, 2));
            tmp += " - " + Convert.ToString(Math.Round(settingCam.calibCam.Ratio_Height, 2));
            lb_get_ratio.Text = tmp;

            tb_ratio_Width.Text = settingCam.calibCam.Calib_Width.ToString();
            tb_ratio_Height.Text = settingCam.calibCam.Calib_Height.ToString();
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

        private Rectangle GetRectangle()
        {
            settingCam.rect = new Rectangle();
            settingCam.rect.X = Math.Min(settingCam.StartLocation.X, settingCam.EndLcation.X);
            settingCam.rect.Y = Math.Min(settingCam.StartLocation.Y, settingCam.EndLcation.Y);
            settingCam.rect.Width = Math.Abs(settingCam.StartLocation.X - settingCam.EndLcation.X);
            settingCam.rect.Height = Math.Abs(settingCam.StartLocation.Y - settingCam.EndLcation.Y);

            lb_crop_width.Text = settingCam.rect.Width.ToString();
            lb_crop_height.Text = settingCam.rect.Height.ToString() ;

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
                accessData.saveCamData(settingCam.rect, settingCam.StartLocation, settingCam.EndLcation);
                settingCam.updateFrame = false;
            }
        }

        private void btn_config_reframe_Click(object sender, EventArgs e)
        {
            settingCam.StartLocation = new Point(0, 0);
            settingCam.EndLcation = new Point(0,0);
            GetRectangle();
            accessData.saveCamData(settingCam.rect, settingCam.StartLocation, settingCam.EndLcation);
        }

        private void btn_config_ratio_Click(object sender, MouseEventArgs e)
        {
            getRatio();
        }

        private void getRatio()
        {
            accessData.SaveCalibRatio(ref settingCam.calibCam, 
                (double)settingCam.rect.Height, (double)settingCam.rect.Width);
            string tmp = Convert.ToString(Math.Round(settingCam.calibCam.Ratio_Width, 2));
            tmp += " - " + Convert.ToString(Math.Round(settingCam.calibCam.Ratio_Height, 2));
            lb_get_ratio.Text = tmp;
        }

        //private void tb_ratio_Width_Leave(object sender, EventArgs e)
        //{
        //    double tmp = Convert.ToDouble(tb_ratio_Width.Text);
        //    if (tmp > 0)
        //    {
        //        settingCam.calibCam.Calib_Width = tmp;
        //        accessData.SaveCalibRatio(ref settingCam.calibCam, settingCam.rect.Height, settingCam.rect.Width);
        //        getRatio();
        //    }
        //}

        //private void tb_ratio_Height_Leave(object sender, EventArgs e)
        //{
        //    double tmp = Convert.ToDouble(tb_ratio_Height.Text);
        //    if (tmp > 0)
        //    {
        //        settingCam.calibCam.Calib_Height = tmp;
        //        accessData.SaveCalibRatio(ref settingCam.calibCam, settingCam.rect.Height, settingCam.rect.Width);
        //        getRatio();
        //    }
        //}
    }
}
