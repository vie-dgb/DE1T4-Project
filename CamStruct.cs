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

    public class accessData 
    {
        public static string savePath = "D:\\Study\\Graduation Project\\Main folder\\App & Firmware\\App\\DE1T4 Project\\saveFrame.txt";
        public static void saveData(Rectangle _rect)
        {
            frameConfig newData = new frameConfig();
            newData.X = _rect.X.ToString();
            newData.Y = _rect.Y.ToString();
            newData.Height = _rect.Height.ToString();
            newData.Width  = _rect.Width.ToString();
            if (settingCam.rect != null)
            {
                string[] lines =
                {
                    newData.X, newData.Y, newData.Width, newData.Height
                };
                File.WriteAllLines(savePath, lines);
            }
        }

        public static Rectangle readData()
        {
            Rectangle returnrect = new Rectangle();
            string[] lines = File.ReadAllLines(savePath);
            returnrect.X = checkEmptyInt(lines[0], int.Parse(lines[0]));
            returnrect.Y = checkEmptyInt(lines[1], int.Parse(lines[1]));
            returnrect.Width = checkEmptyInt(lines[2], int.Parse(lines[2]));
            returnrect.Height = checkEmptyInt(lines[3], int.Parse(lines[3]));
            return returnrect;
        }

        public static int checkEmptyInt(string emptyCheck, int value)
        {
            if (emptyCheck != string.Empty)
            {
                return value;
            }
            else return 0;
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
