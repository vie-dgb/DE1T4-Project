using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DE1T4_Project
{
    public class ObElement
    {
        public double area { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public double CoorX { get; set; }
        public double CoorY { get; set; }
        public double CurrentY { get; set; }
        public bool inCamArea { get; set; }
        public cNum.shp shapes { get; set; }
        public int typeObject { get; set; }
        public Stopwatch timeStamp { get; set; }
        public double oldTimeStamp { get; set; }
    }

    public class ObQueue
    {
        public static List<ObElement> queue = new List<ObElement>();
        public static int ObjInd_InCam;
        public static bool doneOneInQueue = false;
        public static bool changeQueue = false;
        public static ObElement saveTmpObj(cNum.shp shapes, int _type, int Location_X, int Location_Y,
            double Coor_X, double Coor_Y, double area)
        {
            ObElement tmpObj = new ObElement();
            tmpObj.shapes = shapes;
            tmpObj.x = Location_X;
            tmpObj.y = Location_Y;
            tmpObj.CoorX = Coor_X;
            tmpObj.CoorY = Coor_Y;
            tmpObj.area = area;
            tmpObj.typeObject = _type;
            return tmpObj;
        }
        public static void AddObject(ObElement addObj)
        {
            addObj.inCamArea = true;
            addObj.oldTimeStamp = 0;
            //addObj.CurrentY = addObj.CoorY;
            addObj.timeStamp = Stopwatch.StartNew();
            queue.Add(addObj);
            ObjInd_InCam = queue.Count - 1;
            changeQueue = true;
        }

        public static bool CompareObject(ObElement main, ObElement check)
        {
            int cnt = 0;
            if (main.shapes == check.shapes) cnt++;
            if ((main.x > (check.x - 2))
                && (main.x < (check.x + 2))) cnt++;
            if ((main.area > (check.area - 1500))
                && (main.area < (check.area + 1500))) cnt++;
            if (cnt == 3) return true;
            else return false;
        }

        public static void ObjectPlanner(ObElement obj)
        {
            
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
                if(queue[ObjInd_InCam].y < obj.y)
                {
                    AddObject(obj);
                    return true;
                }
                else if(CompareObject(queue[ObjInd_InCam], obj))
                {
                    queue[ObjInd_InCam].y = obj.y;
                    queue[ObjInd_InCam].x = obj.x;
                }
                return false;
            }
        }
    }
}


//for (int i = 0; i < queue.Count; i++)
//{
//    if (queue[i].inCamArea)
//    {
//        if (!CompareObject(queue[i], obj))
//        {

//        }
//    }
//}