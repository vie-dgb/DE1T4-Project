using System;
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
    public class frameConfig
    {
        public string X { get; set; }
        public string Y { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
    }

    public class cNum
    {
        public enum nameLines
        {
            Rect_X,
            Rect_Y,
            Rect_Height,
            Rect_Width,
        }

        public enum numSet
        {
            Name,
            Hue_Max,
            Hue_Min,
            Sat_Max,
            Sat_Min,
            Val_Max,
            Val_Min,
        }
    }

    public class accessData
    {

        public static string savePath = "D:\\Study\\Graduation Project\\Main folder\\App & Firmware\\App\\DE1T4 Project\\saveFrame.txt";

        public static void saveCamData(Rectangle _rect)
        {
            frameConfig newData = new frameConfig();
            newData.X = _rect.X.ToString();
            newData.Y = _rect.Y.ToString();
            newData.Height = _rect.Height.ToString();
            newData.Width  = _rect.Width.ToString();

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
            return returnrect;
        }

        public static ImgSet readInforImgData(int set)
        {
            ImgSet retResult = new ImgSet();
            string[] lines = File.ReadAllLines(savePath);
            double H_Max, H_Min, S_Max, S_Min, V_Max, V_Min;
            int ind = calcSetInd(cNum.numSet.Name, set);

            retResult.name = checkEmptyString(lines, ind); ind++;

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

        private const int NumOfPara = 7;
        private const int StartIndex = 4;
        public static int calcSetInd(cNum.numSet inf, int nSet)
        {
            // index = start + inf + nSet * NumOfPara
            int _re = 0;
            _re = StartIndex + Convert.ToInt32(inf) + (nSet * NumOfPara);
            return _re;
        }
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
    }

    public class CameraSelect 
    {
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
        public Hsv Max { get; set; }
        public Hsv Min { get; set; }
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
