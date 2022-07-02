using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE1T4_Project
{
    public class ObElement
    {
        public double area { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public bool inCamArea { get; set; }
        public cNum.shp shapes { get; set; }
    }

    public class ObQueue
    {
        public static List<ObElement> queue = new List<ObElement>();
        public static int indQueue = 0;
        public static bool ObjInConveyor = false;
        public static int ObjInd_InCam;
        public static ObElement saveTmpObj(cNum.shp shapes, int Location_X, int Location_Y, double area)
        {
            ObElement tmpObj = new ObElement();
            tmpObj.shapes = shapes;
            tmpObj.x = Location_X;
            tmpObj.y = Location_Y;
            tmpObj.area = area;
            return tmpObj;
        }
        public static void AddObject(ObElement addObj)
        {
            addObj.inCamArea = true;
            queue.Add(addObj);
            ObjInd_InCam = queue.Count - 1;
        }

        public static bool checkObject(ObElement obj)
        {
            if (queue.Count==0)
            {
                AddObject(obj);
                return true;
            }
            else
            {
                bool isNewObj = false;
                //for (int i = 0; i < queue.Count; i++)
                //{
                //    if (queue[i].inCamArea)
                //    {
                //        if (queue[i].x > obj.x) isNewObj = true;
                //    }
                //}
                if (queue[ObjInd_InCam].y < obj.y) isNewObj = true;
                else {
                    queue[ObjInd_InCam].y = obj.y;
                    queue[ObjInd_InCam].x = obj.x;
                }
                if (isNewObj)
                {
                    AddObject(obj);
                    return true;
                }
                else return false;
            }
        }
    }
}
