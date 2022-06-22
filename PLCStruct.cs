using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE1T4_Project
{
    class PLCSelect
    {
        public static bool IsConnect = false;
        public static bool Read_Init = true;
        public static bool Read_HomeStatus = false;
        public static bool ReadBusy = false;
        public static bool Division_Change = false;
        public static bool EESpeed_Change = false;
        public static bool ConveyorSpeed_Change = true;
        public static DeltaPosition Pos = new DeltaPosition() { X = 0, Y = 0, Z = 0, };
        public static short EESpeed;
        public static double Division;
        public static int Conveyor_Velocity;
    }

    class DeltaPosition
    {
        public double X;
        public double Y;
        public double Z;
    }

    class PLCRead
    {
        public bool flag;
        public string Addr;
        public bool hold;
        // return value
        public bool bit;
    }

    class PLC_Addr
    {
        // read
        public static PLCRead HomingDone = new PLCRead() { flag = false, hold = false, Addr = "DB11.0.4" };
        public static PLCRead Pos_Last_X = new PLCRead() { flag = true, hold = true, Addr = "DB26.DBD122" };
        public static PLCRead Pos_Last_Y = new PLCRead() { flag = true, hold = true, Addr = "DB26.DBD126" };
        public static PLCRead Pos_Last_Z = new PLCRead() { flag = true, hold = true, Addr = "DB26.DBD130" };
        public const string Conveyor_MMPS = "DB11.DBD56";

        // write
        public const string Home = "M0.0";
        public const string MoveTO = "M0.1";
        public const string AddNewPos = "M0.3";

        public const string Vaccum = "M1.0";
        public const string Valve = "M1.1";
        public const string Conveyor = "M1.2";

        public const string Xplus = "M2.0";
        public const string Xminus = "M2.1";
        public const string Yplus = "M2.2";
        public const string Yminus = "M2.3";
        public const string Zplus = "M2.4";
        public const string Zminus = "M2.5";

        public const string Division = "DB26.DBD106";
        public const string nPoint = "DB26.DBW102";
        public const string EESpeed = "DB26.DBW100";

        public const string Push_POS_X = "DB13.DBD8";
        public const string Push_POS_Y = "DB13.DBD12";
        public const string Push_POS_Z = "DB13.DBD16";

        public const string PID_Setpoint = "DB11.DBD60";
    }

}
