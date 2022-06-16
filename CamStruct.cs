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
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace DE1T4_Project
{
    public class frameCofig
    {
        public Rectangle rect { get; set; }
    }

    public class accessData 
    {
        public static string savePath = "D:\\Study\\Graduation Project\\Main folder\\App & Firmware\\App\\DE1T4 Project\\save.xml";
        public static XmlSerializer seraialSave_cofig = new XmlSerializer(typeof(frameCofig));
        public static void saveData(Rectangle _rect)
        {
            frameCofig newData = new frameCofig();
            newData.rect = _rect;
            if (settingCam.rect != null)
            {
                settingCam.updateFrame = false;
                FileStream write_stream = File.OpenWrite(savePath);
                seraialSave_cofig.Serialize(write_stream, newData);
                write_stream.Dispose();
            }
        }

        public static Rectangle readData()
        {
            FileStream read_stream = File.OpenRead(savePath);
            frameCofig _result = new frameCofig();
            _result = (frameCofig)(seraialSave_cofig.Deserialize(read_stream));
            return _result.rect;
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
