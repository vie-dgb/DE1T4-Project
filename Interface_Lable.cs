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
        public const string AutoMode_On_Btn = "ON Automode";
        public const string AutoMode_Off_Btn = "Off Automode";

        public static void set_cam_btn_status(ref Button Cambtn, bool flag)
        {
            setButtonStatusItf(ref Cambtn, flag, Itf_Lb.Cam_Start_Btn, Itf_Lb.Cam_Stop_Btn);
        }

        public static void set_plc_btn_status(ref Button PLCbtn, bool flag)
        {
            setButtonStatusItf(ref PLCbtn, flag, Itf_Lb.PLC_Connect_Btn, Itf_Lb.PLC_Dis_Btn);
        }

        public static void set_automode_btn_status(ref Button PLCbtn, bool flag)
        {
            setButtonStatusItf(ref PLCbtn, flag, Itf_Lb.AutoMode_On_Btn, Itf_Lb.AutoMode_Off_Btn);
        }

        public static void setButtonStatusItf(ref Button btn, bool flag, string OnString, string OffString)
        {
            if (flag)
            {
                btn.Text = OffString;
                btn.BackColor = Color.DodgerBlue;
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.Text = OnString;
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }
        }
    }
    

}
