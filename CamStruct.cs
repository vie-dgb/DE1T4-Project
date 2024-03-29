﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using DirectShowLib;
using SharpDX.MediaFoundation;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using System.IO;

namespace DE1T4_Project
{
    public class cNum
    {
        public enum nameLines
        {
            Rect_X,
            Rect_Y,
            Rect_Height,
            Rect_Width,
            Start_Location_X,
            Start_Location_Y,
            Stop_Location_X,
            Stop_Location_Y,
            Calib_Width,
            Calib_Height,
            Ratio_Width,
            Ratio_Height,
            TL_Position_X,      // top left position of frame
            TL_Position_Y,
        }

        public enum numSet
        {
            Name,
            Shapes,
            Area_Max,
            Area_Min,
            Lable_Color,
            Hue_Max,
            Hue_Min,
            Sat_Max,
            Sat_Min,
            Val_Max,
            Val_Min,
        }

        public enum shp
        {
            Circles,
            Triangles,
            Rectangles,
            Non,
        }

    }

    public class CamConfig 
    {
        public double Brightness { get; set; }
        public double Contrast { get; set; }
        public double Saturation { get; set; }
        public double Hue { get; set; }
        public double Gain { get; set; }
        public double Sharpness { get; set; }
        public double Gamma { get; set; }
        public double WhiteBalanceRedV { get; set; }
        public double Autofocus { get; set; }
    }


    public class frameConfig
    {
        public string X { get; set; }
        public string Y { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public string Start_X { get; set; }
        public string Start_Y { get; set; }
        public string Stop_X { get; set; }
        public string Stop_Y { get; set; }
    }

    public class Calib
    {
        public double Calib_Width { get; set; }
        public double Calib_Height { get; set; }
        public double Ratio_Width { get; set; }
        public double Ratio_Height { get; set; }
        public double TL_Position_X { get; set; }
        public double TL_Position_Y { get; set; }
    }

    public class settingCam
    {
        public static Rectangle rect;
        public static Point StartLocation;
        public static Point EndLcation;
        public static bool IsMouseDown = false;
        public static bool updateFrame = false;
        public static bool IsConFig = false;
        public static Mat set_Frame;
        public static double fps;
        public static Calib calibCam = new Calib();
        public static CamConfig configCam = new CamConfig();
    }

    public class Cam_S
    {
        public static VideoCapture CamProcess;
        public static int Index;
        public static string Name;
        public static bool captureInProgress = false;
        public static bool Dispose = false;
        public static CameraStruct.CamList[] List;
        public static int Set;
        public static ImgSet[] imgSet;
    }

    public class ImgSet
    {
        public string name { get; set; }
        public int shape { get; set; }
        public double area_max { get; set; }
        public double area_min { get; set; }
        public Int32 Lable_Color { get; set; }
        public Hsv Max { get; set; }
        public Hsv Min { get; set; }
    }

    public class accessData
    {
        private const int NumOfPara = 11;
        private const int StartIndex = 14;
        public static string savePath = "D:\\Study\\Graduation Project\\Main folder\\App & Firmware\\App\\DE1T4 Project\\saveFrame.txt";
        //public static string savePath = "saveFrame.txt";
        public const int NUMOFSET = 3;
        public static void saveTLPos(ref Calib save, double X, double Y)
        {
            save.TL_Position_X = X;
            save.TL_Position_Y = Y;
            string[] Readlines = File.ReadAllLines(savePath);
            int ind = Convert.ToInt32(cNum.nameLines.TL_Position_X);
            Readlines[ind] = save.TL_Position_X.ToString();

            ind = Convert.ToInt32(cNum.nameLines.TL_Position_Y);
            Readlines[ind] = save.TL_Position_Y.ToString();
            File.WriteAllLines(savePath, Readlines);
        }
        public static void readTLPos(ref Calib read)
        {
            string[] lines = File.ReadAllLines(savePath);
            int ind = Convert.ToInt32(cNum.nameLines.TL_Position_X);
            read.TL_Position_X = checkEmptyDouble(lines, ind);
            ind = Convert.ToInt32(cNum.nameLines.TL_Position_Y);
            read.TL_Position_Y = checkEmptyDouble(lines, ind);
        }
        public static void SaveCalibRatio(ref Calib save, double camHeight, double camWidth)
        {
            save.Ratio_Width = save.Calib_Width / camWidth;
            save.Ratio_Height = save.Calib_Height / camHeight;

            string[] Readlines = File.ReadAllLines(savePath);

            int ind = Convert.ToInt32(cNum.nameLines.Calib_Width);
            Readlines[ind] = save.Calib_Width.ToString();

            ind = Convert.ToInt32(cNum.nameLines.Calib_Height);
            Readlines[ind] = save.Calib_Height.ToString();

            ind = Convert.ToInt32(cNum.nameLines.Ratio_Width);
            Readlines[ind] = save.Ratio_Width.ToString();

            ind = Convert.ToInt32(cNum.nameLines.Ratio_Height);
            Readlines[ind] = save.Ratio_Height.ToString();

            File.WriteAllLines(savePath, Readlines);
        }
        public static void SaveCalibRatio(ref Calib save)
        {
            string[] Readlines = File.ReadAllLines(savePath);

            int ind = Convert.ToInt32(cNum.nameLines.Calib_Width);
            Readlines[ind] = save.Calib_Width.ToString();

            ind = Convert.ToInt32(cNum.nameLines.Calib_Height);
            Readlines[ind] = save.Calib_Height.ToString();

            File.WriteAllLines(savePath, Readlines);
        }
        public static void ReadCalibRatio(ref Calib read)
        {
            string[] lines = File.ReadAllLines(savePath);

            int ind = Convert.ToInt32(cNum.nameLines.Calib_Width);
            read.Calib_Width = checkEmptyDouble(lines, ind);
            ind = Convert.ToInt32(cNum.nameLines.Calib_Height);
            read.Calib_Height = checkEmptyDouble(lines, ind);
            ind = Convert.ToInt32(cNum.nameLines.Ratio_Width);
            read.Ratio_Width = checkEmptyDouble(lines, ind);
            ind = Convert.ToInt32(cNum.nameLines.Ratio_Height);
            read.Ratio_Height = checkEmptyDouble(lines, ind);
        }
        public static void saveCamData(Rectangle _rect, Point _Start, Point _Stop)
        {
            frameConfig newData = new frameConfig();
            newData.X = _rect.X.ToString();
            newData.Y = _rect.Y.ToString();
            newData.Height = _rect.Height.ToString();
            newData.Width  = _rect.Width.ToString();
            newData.Start_X = _Start.X.ToString();
            newData.Start_Y = _Start.Y.ToString();
            newData.Stop_X = _Stop.X.ToString();
            newData.Stop_Y = _Stop.Y.ToString();

            string[] Readlines = File.ReadAllLines(savePath);

            if (settingCam.rect != null)
            {
                int ind = Convert.ToInt32(cNum.nameLines.Rect_X);
                Readlines[ind] = newData.X;

                ind = Convert.ToInt32(cNum.nameLines.Rect_Y);
                Readlines[ind] = newData.Y;

                ind = Convert.ToInt32(cNum.nameLines.Rect_Width);
                Readlines[ind] = newData.Width;

                ind = Convert.ToInt32(cNum.nameLines.Rect_Height);
                Readlines[ind] = newData.Height;

                ind = Convert.ToInt32(cNum.nameLines.Start_Location_X);
                Readlines[ind] = newData.Start_X;

                ind = Convert.ToInt32(cNum.nameLines.Start_Location_Y);
                Readlines[ind] = newData.Start_Y;

                ind = Convert.ToInt32(cNum.nameLines.Stop_Location_X);
                Readlines[ind] = newData.Stop_X;

                ind = Convert.ToInt32(cNum.nameLines.Stop_Location_Y);
                Readlines[ind] = newData.Stop_Y;



                File.WriteAllLines(savePath, Readlines);
            }
        }
        public static Rectangle readCamData()
        {
            Rectangle returnrect = new Rectangle();
            string[] lines = File.ReadAllLines(savePath);

            int ind = Convert.ToInt32(cNum.nameLines.Rect_X);
            returnrect.X = checkEmptyInt(lines, ind);

            ind = Convert.ToInt32(cNum.nameLines.Rect_Y);
            returnrect.Y = checkEmptyInt(lines, ind);

            ind = Convert.ToInt32(cNum.nameLines.Rect_Width);
            returnrect.Width = checkEmptyInt(lines, ind);

            ind = Convert.ToInt32(cNum.nameLines.Rect_Height);
            returnrect.Height = checkEmptyInt(lines, ind);

            ind = Convert.ToInt32(cNum.nameLines.Start_Location_X);
            settingCam.StartLocation.X = checkEmptyInt(lines, ind);

            ind = Convert.ToInt32(cNum.nameLines.Start_Location_Y);
            settingCam.StartLocation.Y = checkEmptyInt(lines, ind);

            ind = Convert.ToInt32(cNum.nameLines.Stop_Location_X);
            settingCam.EndLcation.X = checkEmptyInt(lines, ind);

            ind = Convert.ToInt32(cNum.nameLines.Stop_Location_Y);
            settingCam.EndLcation.Y = checkEmptyInt(lines, ind);

            return returnrect;
        }
        public static ImgSet readInforImgData(int set)
        {
            ImgSet retResult = new ImgSet();
            string[] lines = File.ReadAllLines(savePath);
            double H_Max, H_Min, S_Max, S_Min, V_Max, V_Min;
            int ind = calcSetInd(cNum.numSet.Name, set);

            retResult.name = checkEmptyString(lines, ind); ind++;
            retResult.shape = checkEmptyInt(lines, ind); ind++;

            retResult.area_max = checkEmptyDouble(lines, ind); ind++;
            retResult.area_min = checkEmptyDouble(lines, ind); ind++;

            retResult.Lable_Color = checkEmptyInt32(lines, ind); ind++;

            H_Max = checkEmptyDouble(lines, ind); ind++;
            H_Min = checkEmptyDouble(lines, ind); ind++;

            S_Max = checkEmptyDouble(lines, ind); ind++;
            S_Min = checkEmptyDouble(lines, ind); ind++;

            V_Max = checkEmptyDouble(lines, ind); ind++;
            V_Min = checkEmptyDouble(lines, ind);

            retResult.Max = new Hsv(H_Max, S_Max, V_Max);
            retResult.Min = new Hsv(H_Min, S_Min, V_Min);

            return retResult;
        }
        public static void saveInforImgData(cNum.numSet para, int set, int value)
        {
            string[] Readlines = File.ReadAllLines(savePath);
            int ind = calcSetInd(para, set);
            Readlines[ind] = Convert.ToString(value);
            File.WriteAllLines(savePath, Readlines);
        }
        public static void saveInforImgData(cNum.numSet para, int set, double value)
        {
            string[] Readlines = File.ReadAllLines(savePath);
            int ind = calcSetInd(para, set);
            Readlines[ind] = Convert.ToString(value);
            File.WriteAllLines(savePath, Readlines);
        }
        public static void saveInforImgData(cNum.numSet para, int set, string name)
        {
            string[] Readlines = File.ReadAllLines(savePath);
            int ind = calcSetInd(para, set);
            Readlines[ind] = name;
            File.WriteAllLines(savePath, Readlines);
        }
        public static void saveInforImgData(cNum.numSet para, int set, Color saveColor)
        {
            // read txt & fine index
            string[] Readlines = File.ReadAllLines(savePath);
            int ind = calcSetInd(para, set);
            // convert color to string
            Int32 colorArgb = Convert.ToInt32(saveColor.ToArgb());
            string saveString = colorArgb.ToString();
            // save
            Readlines[ind] = saveString;
            File.WriteAllLines(savePath, Readlines);
        }
        public static int checkEmptyInt(string[] emptyCheck, int index)
        {
            int result;
            if (index < emptyCheck.Length)
            {
                if (emptyCheck[index] != string.Empty)
                {
                    result = Convert.ToInt32(emptyCheck[index]);
                    return result;
                }
            }
            return 0;
        }
        public static double checkEmptyDouble(string[] emptyCheck, int index)
        {
            double result;
            if (index < emptyCheck.Length)
            {
                if (emptyCheck[index] != string.Empty)
                {
                    result = Convert.ToDouble(emptyCheck[index]);
                    return result;
                }
            }
            return 0;
        }
        public static string checkEmptyString(string[] emptyCheck, int index)
        {
            string result;
            if (index < emptyCheck.Length)
            {
                if (emptyCheck[index] != string.Empty)
                {
                    result = Convert.ToString(emptyCheck[index]);
                    return result;
                }
            }
            return "Color " + Convert.ToString(index);
        }
        public static Int32 checkEmptyInt32(string[] emptyCheck, int index)
        {
            Int32 result;
            if (index < emptyCheck.Length)
            {
                if (emptyCheck[index] != string.Empty)
                {
                    string colorString = emptyCheck[index];
                    Int32 colorArgb = Convert.ToInt32(colorString);
                    // if value is zero choose normal color (red)
                    if (colorArgb == 0)     result = Convert.ToInt32(Color.FromArgb(Convert.ToInt32(Color.Red)));
                    else                    result = colorArgb;
                    return result;
                }
            }
            return Convert.ToInt32(Color.FromArgb(Convert.ToInt32(Color.Red)));
        }
        public static int calcSetInd(cNum.numSet inf, int nSet)
        {
            // index = start + inf + nSet * NumOfPara
            int _re = 0;
            _re = StartIndex + Convert.ToInt32(inf) + (nSet * NumOfPara);
            return _re;
        }
    }

    public class CameraStruct
    {
        public struct CamList
        {
            public string Name;
            public int Index;
        }

        public static void GetListCamera(ref CamList[] cameraList)
        {
            DsDevice[] _SystemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            cameraList = new CamList[_SystemCamereas.Length];
            for (int i = 0; i < _SystemCamereas.Length; i++)
            {
                cameraList[i].Name = _SystemCamereas[i].Name;
                cameraList[i].Index = GetCameraIndexForPartName(cameraList[i].Name);
            }
        }

        public static string[] ListOfAttachedCameras()
        {
            var cameras = new List<string>();
            var attributes = new MediaAttributes(1);
            attributes.Set(CaptureDeviceAttributeKeys.SourceType.Guid, CaptureDeviceAttributeKeys.SourceTypeVideoCapture.Guid);
            var devices = MediaFactory.EnumDeviceSources(attributes);
            for (var i = 0; i < devices.Count(); i++)
            {
                var friendlyName = devices[i].Get(CaptureDeviceAttributeKeys.FriendlyName);
                cameras.Add(friendlyName);
            }
            return cameras.ToArray();
        }
        public static int GetCameraIndexForPartName(string partName)
        {
            var cameras = ListOfAttachedCameras();
            for (var i = 0; i < cameras.Count(); i++)
            {
                if (cameras[i].ToLower().Contains(partName.ToLower()))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
