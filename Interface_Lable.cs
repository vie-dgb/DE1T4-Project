using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DE1T4_Project
{
    

    class Itf_Lb
    {
        public const string Cam_Start_Btn = "Start Camera";
        public const string Cam_Stop_Btn = "Stop Camera";
        public const string PLC_Connect_Btn = "Connect";
        public const string PLC_Dis_Btn = "Disconnect";

        public static void set_cam_btn_status(ref Button Cambtn, bool flag)
        {
            if (flag)
            {
                Cambtn.Text = Itf_Lb.Cam_Stop_Btn;
                Cambtn.BackColor = Color.DodgerBlue;
                Cambtn.ForeColor = Color.White;
            }
            else
            {
                Cambtn.Text = Itf_Lb.Cam_Start_Btn;
                Cambtn.BackColor = Color.White;
                Cambtn.ForeColor = Color.Black;
            }
        }

        public static void set_plc_btn_status(ref Button Cambtn, bool flag)
        {
            if (flag)
            {
                Cambtn.Text = Itf_Lb.PLC_Dis_Btn;
                Cambtn.BackColor = Color.DodgerBlue;
                Cambtn.ForeColor = Color.White; 
            }
            else
            {
                Cambtn.Text = Itf_Lb.PLC_Connect_Btn;
                Cambtn.BackColor = Color.White;
                Cambtn.ForeColor = Color.Black;
            }
        }
    }
    

}
