using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7;
using S7.Net;

namespace DE1T4_Project
{
    class DeltaPosition
    {
        public double X;
        public double Y;
        public double Z;
    }
    class PLC
    {
        public static CpuType cpuType = CpuType.S71200;
        public static string ipAddress = "192.168.0.127";

        public static bool busy = false;
        public static bool IsConnect = false;
        public static bool Read_Init = true;

        public static DeltaPosition Pos = new DeltaPosition() { X = 0, Y = 0, Z = 0, };

        public static short EESpeed;
        public static double Division;
        public static double Conveyor_Velocity;
        public static double Conveyor_Set_Velocity;

        // Pick&Place
        //public static DeltaPosition PnP_Offset = new DeltaPosition() { X = 0, Y = 0, Z = 0, };
        public static DeltaPosition PnP_Offset = new DeltaPosition() { X = 0, Y = 0, Z = 0, };
        public static DeltaPosition PnP_Typ1_Coor = new DeltaPosition() { X = 0, Y = 0, Z = 0, };
        public static DeltaPosition PnP_Typ2_Coor = new DeltaPosition() { X = 0, Y = 0, Z = 0, };
        public static DeltaPosition PnP_Typ3_Coor = new DeltaPosition() { X = 0, Y = 0, Z = 0, };
        public static double Z_Pick;
        public static double Z_Place;
        public static double Y_Pick_Limit_High;
        public static double Y_Pick_Limit_Low;
        public static short Count_Type_1;
        public static short Count_Type_2;
        public static short Count_Type_3;

        #region methods
        public static void Home(ref Plc _plc)
        {
            WriteBit(ref _plc, PLC_Addr.Home, 1);
        }
        public static void MovP2P(ref Plc _plc, DeltaPosition pos, short nPoint)
        {
            // add to buffer
            PushToRingBuffer(ref _plc, pos);
            WriteShort(ref _plc, PLC_Addr.nPoint, nPoint);
            // move
            WriteBit(ref _plc, PLC_Addr.MoveTO, 1);
            WriteBit(ref _plc, PLC_Addr.MoveTO, 0);
        }
        public static void ChangeEESpeed(ref Plc _plc, short speed)
        {
            EESpeed = speed;
            WriteShort(ref _plc, PLC_Addr.EESpeed, EESpeed);
        }
        public static void MovXYZ(ref Plc _plc, string _addr)
        {
            WriteBit(ref _plc, _addr, 1);
            WriteBit(ref _plc, _addr, 0);
        }
        public static void ChangeDivision(ref Plc _plc, double div)
        {
            Division = div;
            WriteDouble(ref _plc, PLC_Addr.Division, Division);
        }
        public static void Vaccum(ref Plc _plc, int value)
        {
            WriteBit(ref _plc, PLC_Addr.Vaccum, value);
        }
        public static void Valve(ref Plc _plc, int value)
        {
            WriteBit(ref _plc, PLC_Addr.Valve, value);
        }
        public static void ChangeConveyorSpeed(ref Plc _plc, double speed)
        {
            Conveyor_Set_Velocity = speed;
            WriteDouble(ref _plc, PLC_Addr.PID_Setpoint, Conveyor_Set_Velocity);
        }
        public static void Conveyor(ref Plc _plc, int value)
        {
            WriteBit(ref _plc, PLC_Addr.Conveyor, value);
        }
        public static void PushToRingBuffer(ref Plc _plc ,DeltaPosition Position)
        {
            // write position
            WriteDouble(ref _plc, PLC_Addr.Push_POS_X, Position.X);
            WriteDouble(ref _plc, PLC_Addr.Push_POS_Y, Position.Y);
            WriteDouble(ref _plc, PLC_Addr.Push_POS_Z, Position.Z);
            // add
            WriteBit(ref _plc, PLC_Addr.AddNewPos, 1);
            WriteBit(ref _plc, PLC_Addr.AddNewPos, 0);
        }
        public static void ReadPosition(ref Plc _plc)
        {
            ReadParameterDouble(ref _plc, ref PLC.Pos.X, PLC_Addr.Pos_Last_X);
            ReadParameterDouble(ref _plc, ref PLC.Pos.Y, PLC_Addr.Pos_Last_Y);
            ReadParameterDouble(ref _plc, ref PLC.Pos.Z, PLC_Addr.Pos_Last_Z);
        }
        public static void ReadConveyorSpeed(ref Plc _plc)
        {
            ReadParameterDouble(ref _plc, ref PLC.Conveyor_Velocity, PLC_Addr.Conveyor_MMPS);
        }

        #region Pick&Place
        public static void Pnp_Start(ref Plc _plc)
        {
            short mode = (short)1;
            short nPoint = Convert.ToInt16(1);
            WriteShort(ref _plc, PLC_Addr.PNP_Mode, mode);
            MovP2P(ref _plc, PnP_Typ1_Coor, nPoint);
            Vaccum(ref _plc, 1);
            Conveyor(ref _plc, 1);
        }
        public static void Pnp_Stop(ref Plc _plc)
        {
            Vaccum(ref _plc, 0);
            Conveyor(ref _plc, 0);
        }
        public static void PnP_Pick(ref Plc _plc, DeltaPosition PickPos, short TargetIndex)
        {
            // write type of target
            WriteShort(ref _plc, PLC_Addr.PlacePos_Index, TargetIndex);
            // write position
            WriteDouble(ref _plc, PLC_Addr.PickPosition_X, PickPos.X);
            WriteDouble(ref _plc, PLC_Addr.PickPosition_Y, PickPos.Y);
            //WriteDouble(ref _plc, PLC_Addr.PickPosition_Z, PickPos.Z);
            // run
            WriteBit(ref _plc, PLC_Addr.Pick_N_Place, 1);
            WriteBit(ref _plc, PLC_Addr.Pick_N_Place, 0);
        }
        public static void Read_PnP_Offset(ref Plc _plc)
        {
            ReadParameterDouble(ref _plc, ref PLC.PnP_Offset.X, PLC_Addr.PNP_Offset_X);
            ReadParameterDouble(ref _plc, ref PLC.PnP_Offset.Y, PLC_Addr.PNP_Offset_Y);
            ReadParameterDouble(ref _plc, ref PLC.PnP_Offset.Z, PLC_Addr.PNP_Offset_Z);
        }
        public static void Read_PnP_Count(ref Plc _plc)
        {
            ReadParameterShort(ref _plc, ref PLC.Count_Type_1, PLC_Addr.TargetCount_1);
            ReadParameterShort(ref _plc, ref PLC.Count_Type_2, PLC_Addr.TargetCount_2);
            ReadParameterShort(ref _plc, ref PLC.Count_Type_3, PLC_Addr.TargetCount_3);
        }
        public static void Read_PnP_Place_Coor(ref Plc _plc, int _type)
        {
            switch (_type) 
            {
                case 1:
                    ReadParameterDouble(ref _plc, ref PLC.PnP_Typ1_Coor.X, PLC_Addr.PlacePos_1_X);
                    ReadParameterDouble(ref _plc, ref PLC.PnP_Typ1_Coor.Y, PLC_Addr.PlacePos_1_Y);
                    ReadParameterDouble(ref _plc, ref PLC.PnP_Typ1_Coor.Z, PLC_Addr.PlacePos_1_Z);
                    break;
                case 2:
                    ReadParameterDouble(ref _plc, ref PLC.PnP_Typ2_Coor.X, PLC_Addr.PlacePos_2_X);
                    ReadParameterDouble(ref _plc, ref PLC.PnP_Typ2_Coor.Y, PLC_Addr.PlacePos_2_Y);
                    ReadParameterDouble(ref _plc, ref PLC.PnP_Typ2_Coor.Z, PLC_Addr.PlacePos_2_Z);
                    break;
                case 3:
                    ReadParameterDouble(ref _plc, ref PLC.PnP_Typ3_Coor.X, PLC_Addr.PlacePos_3_X);
                    ReadParameterDouble(ref _plc, ref PLC.PnP_Typ3_Coor.Y, PLC_Addr.PlacePos_3_Y);
                    ReadParameterDouble(ref _plc, ref PLC.PnP_Typ3_Coor.Z, PLC_Addr.PlacePos_3_Z);
                    break;
            }
        }
        #endregion Pick&Place

        #region write PLC
        public static void WriteShort(ref Plc _plc, string addr, short value)
        {
            if (PLC.IsConnect)
            {
                busy = true;
                if (_plc.IsConnected)   _plc.Write(addr, value.ConvertToUshort());
                busy = false;
            }
        }
        public static void WriteDouble(ref Plc _plc, string addr, double value)
        {
            if (PLC.IsConnect)
            {
                busy = true;
                if (_plc.IsConnected)   _plc.Write(addr, value.ConvertToUInt());
                busy = false;
            }
        }
        public static void WriteBit(ref Plc _plc, string addr, Int32 value)
        {
            if (PLC.IsConnect)
            {
                busy = true;
                if (_plc.IsConnected) _plc.Write(addr, value);
                busy = false;
            }
        }
        public static bool Convert_N_Write_Double(ref Plc _plc, string textVal, string addr)
        {
            double writeVal;
            bool tryBool = double.TryParse(textVal, out writeVal);
            if (tryBool)
            {
                WriteDouble(ref _plc, addr, writeVal);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Convert_N_Write_Short(ref Plc _plc, string textVal, string addr)
        {
            short writeVal;
            bool tryBool = short.TryParse(textVal, out writeVal);
            if (tryBool)
            {
                WriteDouble(ref _plc, addr, writeVal);
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion write PLC

        #region read PLC
        public static bool ReadParameterDouble(ref Plc _plc, ref double ReadValue, string addr)
        {
            if (PLC.IsConnect)
            {
                busy = true;
                if (_plc.IsConnected)
                {
                    ReadValue = ((uint)_plc.Read(addr)).ConvertToDouble();
                    busy = false;
                    return true;
                }
                busy = false;
            }
            return false;
        }
        public static bool ReadParameterShort(ref Plc _plc, ref short ReadValue, string addr)
        {
            if (PLC.IsConnect)
            {
                busy = true;
                if (_plc.IsConnected)
                {
                    ReadValue = ((ushort)_plc.Read(addr)).ConvertToShort();
                    busy = false;
                    return true;
                }
                busy = false;
            }
            return false;
        }
        public static bool ReadParameterBit(ref Plc _plc, ref bool ReadValue, string addr)
        {
            if (PLC.IsConnect)
            {
                busy = true;
                if (_plc.IsConnected)
                {
                    ReadValue = ((bool)_plc.Read(addr));
                    busy = false;
                    return true;
                }
                busy = false;
            }
            return false;
        }
        #endregion read PLC

        #endregion methods
    }

    class PLC_Addr
    {
        // read
        public const string HomingDone = "DB11.DBX0.4";
        public const string Pos_Last_X = "DB26.DBD122";
        public const string Pos_Last_Y = "DB26.DBD126";
        public const string Pos_Last_Z = "DB26.DBD130";
        public const string Conveyor_MMPS = "DB11.DBD52";

        // write
        public const string Home = "M0.0";
        public const string MoveTO = "M0.1";
        public const string Pick_N_Place = "M0.2";
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

        #region Pick & PLace
        public const string PNP_Mode = "DB36.DBW0";

        public const string PickPosition_X = "DB36.DBD2";
        public const string PickPosition_Y = "DB36.DBD6";
        public const string PickPosition_Z = "DB36.DBD10";

        public const string PlacePosition_X = "DB36.DBD14";
        public const string PlacePosition_Y = "DB36.DBD18";
        public const string PlacePosition_Z = "DB36.DBD20";

        public const string PlacePos_1_X = "DB36.DBD26";
        public const string PlacePos_1_Y = "DB36.DBD30";
        public const string PlacePos_1_Z = "DB36.DBD34";

        public const string PlacePos_2_X = "DB36.DBD38";
        public const string PlacePos_2_Y = "DB36.DBD42";
        public const string PlacePos_2_Z = "DB36.DBD46";

        public const string PlacePos_3_X = "DB36.DBD50";
        public const string PlacePos_3_Y = "DB36.DBD54";
        public const string PlacePos_3_Z = "DB36.DBD58";

        public const string PlacePos_Index = "DB36.DBW62";

        public const string PickDown = "DB36.DBD64";
        public const string PlaceDown = "DB36.DBD68";

        public const string PNP_Done = "DB36.DBX72.0";
        public const string PNP_Busy = "DB36.DBX72.1";

        public const string PNP_Offset_X = "DB36.DBD74";
        public const string PNP_Offset_Y = "DB36.DBD78";
        public const string PNP_Offset_Z = "DB36.DBD82";

        public const string TargetCount_1 = "DB36.DBW86";
        public const string TargetCount_2 = "DB36.DBW88";
        public const string TargetCount_3 = "DB36.DBW90";

        public const string Y_Pick_Limit_High = "DB36.DBD98";
        public const string Y_Pick_Limit_Low = "DB36.DBD102";
        #endregion
    }
}
