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
        public static short Count_Type_1;
        public static short Count_Type_2;
        public static short Count_Type_3;

        #region methods
        public static void Home(ref Plc _plc)
        {
            busy = true;
            _plc.Write(PLC_Addr.Home, 1);
            busy = false;
        }
        public static void MovP2P(ref Plc _plc, DeltaPosition pos, short nPoint)
        {
            busy = true;
            // add to buffet
            PushToRingBuffer(ref _plc, pos);
            _plc.Write(PLC_Addr.nPoint, nPoint.ConvertToUshort());
            // move
            _plc.Write(PLC_Addr.MoveTO, 1);
            _plc.Write(PLC_Addr.MoveTO, 0);
            busy = false;
        }
        public static void ChangeEESpeed(ref Plc _plc, short speed)
        {
            EESpeed = speed;
            busy = true;
            _plc.Write(PLC_Addr.EESpeed, EESpeed.ConvertToUshort());
            busy = false;
        }
        public static void MovXYZ(ref Plc _plc, string _addr)
        {
            busy = true;
            _plc.Write(_addr, 1);
            _plc.Write(_addr, 0);
            busy = false;
        }
        public static void ChangeDivision(ref Plc _plc, double div)
        {
            Division = div;
            busy = true;
            _plc.Write(PLC_Addr.Division, Division.ConvertToUInt());
            busy = false;
        }
        public static void Vaccum(ref Plc _plc, int value)
        {
            busy = true;
            _plc.Write(PLC_Addr.Vaccum, value);
            busy = false;
        }
        public static void Valve(ref Plc _plc, int value)
        {
            busy = true;
            _plc.Write(PLC_Addr.Valve, value);
            busy = false;
        }
        public static void ChangeConveyorSpeed(ref Plc _plc, double speed)
        {
            Conveyor_Set_Velocity = speed;
            busy = true;
            _plc.Write(PLC_Addr.PID_Setpoint, Conveyor_Set_Velocity.ConvertToUInt());
            busy = false;
        }
        public static void Conveyor(ref Plc _plc, int value)
        {
            busy = true;
            _plc.Write(PLC_Addr.Conveyor, value);
            busy = false;
        }
        public static void PushToRingBuffer(ref Plc _plc ,DeltaPosition Position)
        {
            // write position
            _plc.Write(PLC_Addr.Push_POS_X, Position.X.ConvertToUInt());
            _plc.Write(PLC_Addr.Push_POS_Y, Position.Y.ConvertToUInt());
            _plc.Write(PLC_Addr.Push_POS_Z, Position.Z.ConvertToUInt());
            // add
            _plc.Write(PLC_Addr.AddNewPos, 1);
            _plc.Write(PLC_Addr.AddNewPos, 0);
        }
        public static void ReadPosition(ref Plc _plc)
        {
            busy = true;
            PLC.Pos.X = Math.Round(((uint)_plc.Read(PLC_Addr.Pos_Last_X)).ConvertToDouble());
            PLC.Pos.Y = Math.Round(((uint)_plc.Read(PLC_Addr.Pos_Last_Y)).ConvertToDouble());
            PLC.Pos.Z = Math.Round(((uint)_plc.Read(PLC_Addr.Pos_Last_Z)).ConvertToDouble());
            busy = false;
        }
        public static void ReadConveyorSpeed(ref Plc _plc)
        {
            busy = true;
            PLC.Conveyor_Velocity = ((uint)_plc.Read(PLC_Addr.Conveyor_MMPS)).ConvertToInt();
            busy = false;
        }
        public static void ReadParameterDouble(ref Plc _plc, ref double ReadValue, string addr)
        {
            busy = true;
            ReadValue = ((uint)_plc.Read(addr)).ConvertToDouble();
            busy = false;
        }
        public static void ReadParameterShort(ref Plc _plc, ref short ReadValue, string addr)
        {
            busy = true;
            ReadValue = ((ushort)_plc.Read(addr)).ConvertToShort();
            busy = false;
        }
        public static bool read_Singles_Bit(ref Plc _plc, DataType _type, String addr)
        {
            int _dbInd = int.Parse(addr.Substring(2, 2));
            int startInd = int.Parse(addr.Substring(5, 1));
            int bitInd = int.Parse(addr.Right(1));
            busy = true;
            byte[] rTmp_Byte = _plc.ReadBytes(_type, _dbInd, startInd, 1);
            busy = false;
            byte write_Byte = rTmp_Byte[0];
            return write_Byte.SelectBit(bitInd);
        }
        public static bool read_Singles_Bit(ref Plc _plc, String addr)
        {
            return ((bool)_plc.Read(addr));
        }
        
        public static void Pnp_Start(ref Plc _plc)
        {
            busy = true;
            short mode = (short)1;
            _plc.Write(PLC_Addr.PNP_Mode, mode.ConvertToUshort());
            busy = false;
        }
        public static void PnP_Pick(ref Plc _plc, DeltaPosition PickPos, short TargetIndex)
        {
            busy = true;
            // write type of target
            _plc.Write(PLC_Addr.PlacePos_Index, TargetIndex.ConvertToUshort());
            // write position
            _plc.Write(PLC_Addr.PickPosition_X, PickPos.X.ConvertToUInt());
            _plc.Write(PLC_Addr.PickPosition_Y, PickPos.Y.ConvertToUInt());
            //_plc.Write(PLC_Addr.PickPosition_Z, PickPos.Z.ConvertToUInt());
            // run
            _plc.Write(PLC_Addr.Pick_N_Place, 1);
            _plc.Write(PLC_Addr.Pick_N_Place, 0);
            busy = false;
        }
        public static void Read_PnP_Offset(ref Plc _plc)
        {
            busy = true;
            PLC.PnP_Offset.X = ((uint)_plc.Read(PLC_Addr.PNP_Offset_X)).ConvertToDouble();
            PLC.PnP_Offset.Y = ((uint)_plc.Read(PLC_Addr.PNP_Offset_Y)).ConvertToDouble();
            PLC.PnP_Offset.Z = ((uint)_plc.Read(PLC_Addr.PNP_Offset_Z)).ConvertToDouble();
            busy = false;
        }
        public static void Read_PnP_Place_Coor(ref Plc _plc, int _type)
        {
            busy = true;
            switch (_type) 
            {
                case 1:
                    PLC.PnP_Typ1_Coor.X = ((uint)_plc.Read(PLC_Addr.PlacePos_1_X)).ConvertToDouble();
                    PLC.PnP_Typ1_Coor.Y = ((uint)_plc.Read(PLC_Addr.PlacePos_1_Y)).ConvertToDouble();
                    PLC.PnP_Typ1_Coor.Z = ((uint)_plc.Read(PLC_Addr.PlacePos_1_Z)).ConvertToDouble();
                    break;
                case 2:
                    PLC.PnP_Typ2_Coor.X = ((uint)_plc.Read(PLC_Addr.PlacePos_2_X)).ConvertToDouble();
                    PLC.PnP_Typ2_Coor.Y = ((uint)_plc.Read(PLC_Addr.PlacePos_2_Y)).ConvertToDouble();
                    PLC.PnP_Typ2_Coor.Z = ((uint)_plc.Read(PLC_Addr.PlacePos_2_Z)).ConvertToDouble();
                    break;
                case 3:
                    PLC.PnP_Typ3_Coor.X = ((uint)_plc.Read(PLC_Addr.PlacePos_3_X)).ConvertToDouble();
                    PLC.PnP_Typ3_Coor.Y = ((uint)_plc.Read(PLC_Addr.PlacePos_3_Y)).ConvertToDouble();
                    PLC.PnP_Typ3_Coor.Z = ((uint)_plc.Read(PLC_Addr.PlacePos_3_Z)).ConvertToDouble();
                    break;
            }
            busy = false;
        }
        public static void Write_Double(ref Plc _plc, string addr, double value)
        {
            busy = true;
            _plc.Write(addr, value.ConvertToUInt());
            busy = false;
        }
        public static void Write_Short(ref Plc _plc, string addr, short value)
        {
            busy = true;
            _plc.Write(addr, value.ConvertToUshort());
            busy = false;
        }
        #endregion methods
    }

    class PLC_Addr
    {
        // read
        public const string HomingDone = "DB11.DBX0.4";
        public const string Pos_Last_X = "DB26.DBD122";
        public const string Pos_Last_Y = "DB26.DBD126";
        public const string Pos_Last_Z = "DB26.DBD130";
        public const string Conveyor_MMPS = "DB11.DBD56";

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
        #endregion
    }
}
