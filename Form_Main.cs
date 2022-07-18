using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.Util;
using S7;
using S7.Net;

namespace DE1T4_Project
{
    public partial class Form_Main : Form
    {
        // cam
        public Mat _frame;
        // plc
        private Plc DeltaPLC = null;
        private ErrorCode errCode;
        private bool readCount = false;
        // image process
        private double tmpArea;
        // auto mode
        private bool OnAutoMode = false;
        public Form_Main()
        {
            InitializeComponent();
        }
        // form load
        private void Form_Main_Load(object sender, EventArgs e)
        {
            Introduces _introduces = new Introduces();
            _introduces.ShowDialog();

            bool pathExists = File.Exists(accessData.savePath);
            while (!pathExists)
            {
                OpenFileDialog pathdialog = new OpenFileDialog();
                if (pathdialog.ShowDialog() == DialogResult.OK)
                {
                    string fullPath = pathdialog.FileName;
                    string fileName = pathdialog.SafeFileName;
                    accessData.savePath = fullPath.Replace(fileName, "") + fileName;
                }

                pathExists = File.Exists(accessData.savePath);
            }
                

            // init camera list and choose normal camera have index 0
            refreshCamList();
            for (int i = 0; i < cbb_Camlist.Items.Count; i++)
            {
                string tmp = cbb_Camlist.Items[i].ToString();
                int tmpIndex = int.Parse(tmp.Substring(tmp.Length - 2, 1));
                if (tmpIndex == 0)
                {
                    Cam_S.Name = tmp.Left(tmp.Length - 4);
                    Cam_S.Index = tmpIndex;
                    cbb_Camlist.SelectedIndex = i;
                    break;
                }
            }
            // load setup data
            Cam_S.imgSet = new ImgSet[accessData.NUMOFSET];
            for(int i=0;i< accessData.NUMOFSET; i++)
            {
                Cam_S.imgSet[i] = accessData.readInforImgData(i);
            }
            updatePageSet();
            scbar_HueMax.Value = 255;
            // load auto mode para
            accessData.readTLPos(ref settingCam.calibCam);
            tbx_auto_TL_X.Text = settingCam.calibCam.TL_Position_X.ToString();
            tbx_auto_TL_Y.Text = settingCam.calibCam.TL_Position_Y.ToString();
            tbx_plc_ip.Text = PLC.ipAddress;

            Itf_Lb.set_plc_btn_status(ref btn_plc_connect, false);
            Itf_Lb.set_cam_btn_status(ref btn_cam_connect, false);
            Itf_Lb.set_automode_btn_status(ref btn_auto_OnOff, false);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Introduces _introduces = new Introduces();
            _introduces.ShowDialog();
        }

        //-----------Camera----------------//
        #region Camera
        #region Camera Event
        // update list camera
        private void cbb_Camlist_DropDown(object sender, EventArgs e)
        {
            refreshCamList();
        }
        // refresh Camera list in combobox
        private void refreshCamList()
        {
            cbb_Camlist.Items.Clear();
            CameraStruct.GetListCamera(ref Cam_S.List);
            for (int i = 0; i < Cam_S.List.Length; i++)
            {
                string tmp = Cam_S.List[i].Name + " (" + Cam_S.List[i].Index.ToString() + ")";
                // check
                if (Cam_S.List[i].Index >= 0)
                {
                    cbb_Camlist.Items.Add(tmp);
                }
            }
        }
        // select camera
        private void cbb_Camlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Cam_S.captureInProgress)
            {
                string tmp = cbb_Camlist.SelectedItem.ToString();
                Cam_S.Name = tmp.Left(tmp.Length - 4);
                Cam_S.Index = int.Parse(tmp.Substring(tmp.Length - 2, 1));
            }
        }
        // connect or disconnect camera
        private void btn_cam_connect_Click(object sender, EventArgs e)
        {
            if (!Cam_S.captureInProgress)
            {
                settingCam.rect = accessData.readCamData();
                accessData.ReadCalibRatio(ref settingCam.calibCam);
                Camera_Enable();

                // change imagebox
                imgBox_crop.Visible = true;
                picbox_offCam.Visible = false;
                // check connect - refresh button
                if (Cam_S.CamProcess.IsOpened)
                {
                    Itf_Lb.set_cam_btn_status(ref btn_cam_connect, true);
                }
                // enable setting camera button
                btn_frame_setting.Enabled = true;
                btn_camsetup.Enabled = true;
            }
            else
            {
                Camera_Disable();
                // change imagebox
                picbox_offCam.Visible = true;
                imgBox_crop.Visible = false;
                // refresh button
                Itf_Lb.set_cam_btn_status(ref btn_cam_connect, false);
                // disable setting camera button
                btn_frame_setting.Enabled = false;
                btn_camsetup.Enabled = false;
            }
        }
        // start capture
        private void Camera_Enable()
        {
            // init videocapture
            if (!Cam_S.captureInProgress)
            {
                try
                {
                    Cam_S.CamProcess = new VideoCapture(Cam_S.Index);
                    Cam_S.CamProcess.ImageGrabbed += ProcessFrame;
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
                _frame = new Mat();
            }
            // start & call handler
            if (Cam_S.CamProcess != null)
            {
                if (!Cam_S.captureInProgress)
                {
                    //start the capture
                    Cam_S.CamProcess.Start();
                    Cam_S.captureInProgress = true;
                    cbb_Camlist.Enabled = false;
                }
            }
        }
        // event handler
        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (Cam_S.CamProcess != null && Cam_S.CamProcess.Ptr != IntPtr.Zero)
            {
                Cam_S.CamProcess.Read(_frame);
                // save for crop image
                Image<Bgr, byte> _imgFrame = new Image<Bgr, byte>(_frame.Width, _frame.Height);
                _imgFrame = _frame.ToImage<Bgr, byte>();
                // save for config if form is open
                if(settingCam.IsConFig)
                {
                    settingCam.set_Frame = _frame;
                }
                // not excute when config
                if (!settingCam.updateFrame)
                {
                    _imgFrame.ROI = settingCam.rect;
                    Image<Bgr, byte> imgCrop = _imgFrame.CopyBlank();
                    _imgFrame.CopyTo(imgCrop);
                    _imgFrame.ROI = Rectangle.Empty;
                    if (!imgCrop.Size.IsEmpty)
                    {
                        if (sw_img_gray.Switched == true)
                        {
                            imgBox_crop.Image = processAndShowGray(imgCrop, Cam_S.imgSet[Cam_S.Set].Min,
                                Cam_S.imgSet[Cam_S.Set].Max);
                        }
                        else
                        {
                            imgBox_crop.Image = processAndShow(imgCrop, Cam_S.imgSet);
                        }
                    }
                }
            }
            // 25fps => 40ms/frame (normal)
            // 10fps => 100ms/frame
            // 5 fps => 200ms/frame
            // delay = fpsneedtime - normalfpstime
            //CvInvoke.WaitKey(60);
        }
        // stop capture
        private void Camera_Disable()
        {
            if (Cam_S.CamProcess != null)
            {
                if (Cam_S.captureInProgress)
                {
                    //stop the capture
                    Cam_S.CamProcess.Dispose();
                    Cam_S.captureInProgress = false;
                    cbb_Camlist.Enabled = true;
                }
            }
        }
        // camera frame config
        private void btn_cam_setting_Click(object sender, EventArgs e)
        {
            Form_CamSetting _camSet = new Form_CamSetting();
            settingCam.IsConFig = true;
            settingCam.set_Frame = new Mat();
            settingCam.fps = Cam_S.CamProcess.Get(Emgu.CV.CvEnum.CapProp.Fps);
            _camSet.ShowDialog();
        }
        // camera image config
        private void btn_camsetup_Click(object sender, EventArgs e)
        {
            if (!Form_Status.CamSetting)
            {
                Form_CamConfig formCamConfig = new Form_CamConfig();
                Form_Status.CamSetting = true;
                formCamConfig.Show();
            }
        }
        #endregion
        #region image process
        private Image<Bgr, byte> processAndShow(Image<Bgr, byte> inputIMG, ImgSet[] imgSet)
        {
            Image<Bgr, byte> _result = new Image<Bgr, byte>(inputIMG.Width, inputIMG.Height);
            inputIMG.CopyTo(_result);

            // loop for every set image
            for (int cntSet = 0; cntSet < accessData.NUMOFSET; cntSet++)
            {
                Color contourColor = new Color();
                contourColor = Color.FromArgb(Cam_S.imgSet[cntSet].Lable_Color);
                Hsv highRange = imgSet[cntSet].Max;
                Hsv lowRange = imgSet[cntSet].Min;

                #region convert image
                // resize for accurate
                // convert bgr to hsv
                Image<Hsv, byte> hsvImg = new Image<Hsv, byte>(inputIMG.Width, inputIMG.Height);
                CvInvoke.CvtColor(inputIMG, hsvImg, ColorConversion.Bgr2Hsv);
                // smooth image with gaussian blur
                CvInvoke.GaussianBlur(hsvImg, hsvImg, new Size(5, 5), 1);
                // convert hsv to binary with range limit
                Image<Gray, byte> grayImg = hsvImg.InRange(lowRange, highRange);
                // opening
                var element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Ellipse,
                new Size(8, 8), new Point(-1, -1));

                CvInvoke.MorphologyEx(grayImg, grayImg, Emgu.CV.CvEnum.MorphOp.Open, element,
                    new Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1.0));
                #endregion convert image

                // find countours
                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                Mat n = new Mat();
                CvInvoke.FindContours(grayImg, contours, n, Emgu.CV.CvEnum.RetrType.Ccomp, 
                    Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

                // check every single countour founded
                for (int i = 0; i < contours.Size; i++)
                {
                    ObElement tmpObj = new ObElement();
                    bool drawCenter = false;
                    double pemir = CvInvoke.ArcLength(contours[i], true);
                    VectorOfPoint approx = new VectorOfPoint();
                    // epsilon in the range of 1 - 5 % of the original contour perimeter.
                    CvInvoke.ApproxPolyDP(contours[i], approx, 0.04 * pemir, true);
                    
                    // find center
                    Moments moments = CvInvoke.Moments(contours[i]);

                    // claculate center coordinates of countour
                    int x = (int)(moments.M10 / moments.M00);
                    int y = (int)(moments.M01 / moments.M00);
                    double coorX = ((double)x * settingCam.calibCam.Ratio_Width) + settingCam.calibCam.TL_Position_X;
                    double coorY = ((double)y * settingCam.calibCam.Ratio_Height) + settingCam.calibCam.TL_Position_Y;
                    coorX = Math.Round(coorX, 0);
                    coorY = Math.Round(coorY, 0);

                    // get countour area
                    double area = CvInvoke.ContourArea(approx, false);
                    tmpArea = area;

                    // detect shapes
                    // if contour has 3 vertices => triangles
                    // if contour has 4 vertices => rectangles
                    // else => circles
                    cNum.shp shpNum = (cNum.shp)imgSet[cntSet].shape;
                    // declare for draw triangles & rectangles egde 
                    List<Triangle2DF> triangle = new List<Triangle2DF>();
                    List<RotatedRect> boxList = new List<RotatedRect>(); //a box is a rotated rectangle

                    if ((tmpArea >= imgSet[cntSet].area_min) && (tmpArea <= imgSet[cntSet].area_max))
                    //only consider contours with area greater than area min
                    {
                        #region shapes detect
                        switch (shpNum) 
                        {
                            case cNum.shp.Circles:
                                #region circles dectect
                                if (approx.Size > 6) 
                                {
                                    // draw circles
                                    //CvInvoke.DrawContours(_result, contours, i,
                                    //    new Bgr(contourColor).MCvScalar, 3);
                                    CircleF CirCles = CvInvoke.MinEnclosingCircle(approx);
                                    CvInvoke.Circle(_result, new Point(x, y), (int)CirCles.Radius, 
                                        new Bgr(contourColor).MCvScalar, 2);
                                    drawCenter = true;
                                }
                                #endregion
                                break;
                            case cNum.shp.Triangles:
                                #region triangles dectect
                                if (approx.Size == 3)
                                {
                                    Point[] pts = approx.ToArray();
                                    triangle.Add(new Triangle2DF(pts[0], pts[1], pts[2]));

                                    foreach (Triangle2DF triAng in triangle)
                                    {
                                        CvInvoke.Polylines(_result, Array.ConvertAll(triAng.GetVertices(), 
                                            Point.Round), true, new Bgr(contourColor).MCvScalar, 3);
                                    }
                                    drawCenter = true;
                                }
                                #endregion
                                break;
                            case cNum.shp.Rectangles:
                                #region rectangles dectect
                                if (approx.Size == 4)
                                {
                                    #region determine if all the angles in the contour are within [80, 100] degree
                                    bool isRectangle = true;
                                    Point[] pts = approx.ToArray();
                                    LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

                                    for (int j = 0; j < edges.Length; j++)
                                    {
                                        double angle = Math.Abs(
                                            edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));
                                        if (angle < 80 || angle > 100)
                                        {
                                            isRectangle = false;
                                            break;
                                        }
                                    }
                                    #endregion
                                    if (isRectangle) boxList.Add(CvInvoke.MinAreaRect(approx));
                                    foreach (RotatedRect box in boxList)
                                    {
                                        CvInvoke.Polylines(_result, Array.ConvertAll(box.GetVertices(), 
                                            Point.Round), true, new Bgr(contourColor).MCvScalar, 2);
                                    }
                                    drawCenter = true;
                                }
                                #endregion
                                break;
                            case cNum.shp.Non:
                                
                                break;
                        }
                        #endregion shapes detect

                        // draw center, coordinates, edge
                        if (drawCenter)
                        {
                            string txtPos = Math.Round(coorX,0).ToString() + "," + Math.Round(coorY, 0).ToString();
                            //string txtPos = x.ToString() + "," + y.ToString();
                            CvInvoke.Circle(_result, new Point(x, y), 2, new Bgr(contourColor).MCvScalar, 2);
                            CvInvoke.PutText(_result, txtPos, new Point(x, y), 
                                Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new Bgr(contourColor).MCvScalar, 2);
                            
                            // add object to queue if automode is enable
                            if(OnAutoMode)
                            {
                                tmpObj = ObQueue.saveTmpObj(shpNum, cntSet, x, y, coorX, coorY, area);
                                ObQueue.checkObject(tmpObj);
                            }
                        }
                    }
                }
            }

            return _result;
        }

        private Image<Gray, byte> processAndShowGray(Image<Bgr, byte> inputImg, Hsv _low, Hsv _high)
        {
            // convert bgr to hsv
            Image<Hsv, byte> hsvImg = new Image<Hsv, byte>(inputImg.Width, inputImg.Height);
            CvInvoke.CvtColor(inputImg, hsvImg, ColorConversion.Bgr2Hsv);
            // smooth image with gaussian blur
            CvInvoke.GaussianBlur(hsvImg, hsvImg, new Size(5, 5), 1);
            // convert hsv to binary with range limit
            Image<Gray, byte> imgtemp = hsvImg.InRange(_low, _high);
            // opening
            var element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Ellipse,
                new Size(8, 8), new Point(-1, -1));

            CvInvoke.MorphologyEx(imgtemp, imgtemp, Emgu.CV.CvEnum.MorphOp.Open, element,
                new Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1.0));

            // find countours
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            Mat n = new Mat();
            CvInvoke.FindContours(imgtemp, contours, n, Emgu.CV.CvEnum.RetrType.Ccomp,
                Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

            // check every single countour founded
            for (int i = 0; i < contours.Size; i++)
            {
                double pemir = CvInvoke.ArcLength(contours[i], true);
                VectorOfPoint approx = new VectorOfPoint();
                // epsilon in the range of 1 - 5 % of the original contour perimeter.
                CvInvoke.ApproxPolyDP(contours[i], approx, 0.04 * pemir, true);

                // get countour area
                tmpArea = CvInvoke.ContourArea(approx, false);
            }
            return imgtemp;
        }

        private void link_img_getArea_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lb_img_area.Text = tmpArea.ToString();
        }
        #endregion
        #endregion
        //--------------PLC----------------//
        #region PLC
        #region Connect
        // plc connect
        private void btn_plc_connect_Click(object sender, EventArgs e)
            {
                if (!PLC.IsConnect)
                {
                    try
                    {
                        // check textbox empty
                        if (string.IsNullOrEmpty(tbx_plc_ip.Text)) throw new Exception("Please enter IP Address.");
                        // init for plc
                        PLC.ipAddress = tbx_plc_ip.Text;
                        DeltaPLC = new Plc(PLC.cpuType, PLC.ipAddress, 0, 1);
                        // check plc is available
                        if (!DeltaPLC.IsAvailable) throw new Exception("Not found PLC!");
                        // open connect
                        errCode = DeltaPLC.Open();
                        // check connect successfully?
                        if (errCode != ErrorCode.NoError) throw new Exception(DeltaPLC.LastErrorString);
                        else
                        {
                            Itf_Lb.set_plc_btn_status(ref btn_plc_connect, true);
                            this.SetEnableButtonConnect(false);
                            PLC.IsConnect = !PLC.IsConnect;
                        }
                        // enables cyclic read
                        readCount = true;
                        cyclicRead.Enabled = true;
                        cyclicRead.Interval = 1000;
                        cyclicRead.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    cyclicRead.Stop();
                    cyclicRead.Enabled = false;
                    PLC.Read_Init = true;
                    DeltaPLC.Close();
                    MessageBox.Show(this, "Disconnected PLC!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Itf_Lb.set_plc_btn_status(ref btn_plc_connect, false);
                    this.SetEnableButtonConnect(true);
                    PLC.IsConnect = !PLC.IsConnect;
                }
            }
        // enable textbox
        private void SetEnableButtonConnect(bool status)
        {
            tbx_plc_ip.Enabled = status;
        }
        #endregion
        #region home
        private void btn_pos_home_Click(object sender, EventArgs e)
        {
            PLC.Home(ref DeltaPLC);
        }
        #endregion
        #region move manual point to point
        private void tbx_mov_velocity_Leave(object sender, EventArgs e)
        {
            short speed = Convert.ToInt16(tbx_mov_velocity.Text);
            if ((speed >= 200) && (speed <= 1200))
            {
                PLC.ChangeEESpeed(ref DeltaPLC, speed);
            }
        }
        private void btn_Mov_Move_Click(object sender, EventArgs e)
        {
            PLC.Pos.X = Convert.ToDouble(tbx_mov_X.Text);
            PLC.Pos.Y = Convert.ToDouble(tbx_mov_Y.Text);
            PLC.Pos.Z = Convert.ToDouble(tbx_mov_Z.Text);
            short nPoint = Convert.ToInt16(1);

            PLC.MovP2P(ref DeltaPLC, PLC.Pos, nPoint);
        }
        #endregion
        #region XYZ move
        private void tbx_mov_division_Leave(object sender, EventArgs e)
        {
            double div = Convert.ToDouble(tbx_mov_division.Text);
            if((div>0)&&(div<50))
            {
                PLC.ChangeDivision(ref DeltaPLC, div);
            }
        }
        private void btn_mov_Xplus_Click(object sender, EventArgs e)
        {
            PLC.MovXYZ(ref DeltaPLC, PLC_Addr.Xplus);
        }
        private void btn_mov_Yplus_Click(object sender, EventArgs e)
        {
            PLC.MovXYZ(ref DeltaPLC, PLC_Addr.Yplus);
        }
        private void btn_mov_Zplus_Click(object sender, EventArgs e)
        {
            PLC.MovXYZ(ref DeltaPLC, PLC_Addr.Zplus);
        }
        private void btn_mov_Xmin_Click(object sender, EventArgs e)
        {
            PLC.MovXYZ(ref DeltaPLC, PLC_Addr.Xminus);
        }
        private void btn_mov_Ymin_Click(object sender, EventArgs e)
        {
            PLC.MovXYZ(ref DeltaPLC, PLC_Addr.Yminus);
        }
        private void btn_mov_Zmin_Click(object sender, EventArgs e)
        {
            PLC.MovXYZ(ref DeltaPLC, PLC_Addr.Zminus);
        }
        #endregion
        #region Tool Head
        // switch vaccum
        private void sw_th_Vaccum_SwitchedChanged(object sender)
        {
            int value;
            if (sw_th_Vaccum.Switched)  value = 1;
            else                        value = 0;
            PLC.Vaccum(ref DeltaPLC, value);
        }
        // switch valve
        private void sw_th_Valve_SwitchedChanged(object sender)
        {
            int value;
            if (sw_th_Valve.Switched)   value = 1;
            else                        value = 0;
            PLC.Valve(ref DeltaPLC, value);
        }
        #endregion
        #region Conveyor
        private void tbx_con_speed_Leave(object sender, EventArgs e)
        {
            double speed = Convert.ToDouble(tbx_con_speed.Text);
            if ((speed > 10) && (speed <= 70))
            {
                PLC.ChangeConveyorSpeed(ref DeltaPLC, speed);
            }
        }
        private void sw_con_Run_SwitchedChanged(object sender)
        {
            int value;
            if (sw_con_Run.Switched) 
                { value = 1; tbx_con_speed.Enabled = false; }
            else 
                { value = 0; tbx_con_speed.Enabled = true; }
            PLC.Conveyor(ref DeltaPLC, value);
        }
        #endregion
    #endregion PLC

    #region PLC cyclic read data
        private void cyclicRead_Tick(object sender, EventArgs e)
        {
            if ((PLC.IsConnect==true) && (PLC.busy==false))
            {
                try
                {
                    // position read & display
                    PLC.ReadPosition(ref DeltaPLC);
                    lb_Pos_X.Text = Math.Round(PLC.Pos.X).ToString();
                    lb_Pos_Y.Text = Math.Round(PLC.Pos.Y).ToString();
                    lb_Pos_Z.Text = Math.Round(PLC.Pos.Z).ToString();
                    // conveyor speed read & display
                    if (sw_con_Run.Switched)
                    {
                        PLC.ReadConveyorSpeed(ref DeltaPLC);
                        lb_con_accSpeed.Text = Math.Round(PLC.Conveyor_Velocity).ToString();
                    }
                    // read count
                    if (readCount)
                    {
                        PLC.Read_PnP_Count(ref DeltaPLC);
                        lb_typ1_count.Text = PLC.Count_Type_1.ToString();
                        lb_typ2_count.Text = PLC.Count_Type_2.ToString();
                        lb_typ3_count.Text = PLC.Count_Type_3.ToString();
                        readCount = false;
                    }
                    // read necessary data when connect 
                    if (PLC.Read_Init)
                    {
                        #region read for switch
                        bool readTmp = false;
                        PLC.ReadParameterBit(ref DeltaPLC, ref readTmp, PLC_Addr.Vaccum);
                        sw_th_Vaccum.Switched = readTmp;

                        PLC.ReadParameterBit(ref DeltaPLC, ref readTmp, PLC_Addr.Valve);
                        sw_th_Valve.Switched = readTmp;

                        PLC.ReadParameterBit(ref DeltaPLC, ref readTmp, PLC_Addr.Conveyor);
                        sw_con_Run.Switched = readTmp;
                        #endregion read for switch

                        #region read EESpeed, division, conveyor setpoint & show
                        PLC.ReadParameterShort(ref DeltaPLC, ref PLC.EESpeed, PLC_Addr.EESpeed);
                        PLC.ReadParameterDouble(ref DeltaPLC, ref PLC.Division, PLC_Addr.Division);
                        PLC.ReadParameterDouble(ref DeltaPLC, ref PLC.Conveyor_Set_Velocity, PLC_Addr.PID_Setpoint);
                        tbx_mov_velocity.Text = PLC.EESpeed.ToString();
                        tbx_mov_division.Text = PLC.Division.ToString();
                        tbx_con_speed.Text = PLC.Conveyor_Set_Velocity.ToString();
                        tbx_mov_X.Text = Math.Round(PLC.Pos.X).ToString();
                        tbx_mov_Y.Text = Math.Round(PLC.Pos.Y).ToString();
                        tbx_mov_Z.Text = Math.Round(PLC.Pos.Z).ToString();
                        #endregion

                        #region read place coordinates & show
                        PLC.Read_PnP_Place_Coor(ref DeltaPLC, 1);
                        PLC.Read_PnP_Place_Coor(ref DeltaPLC, 2);
                        PLC.Read_PnP_Place_Coor(ref DeltaPLC, 3);
                        tbx_typ1_coor_x.Text = PLC.PnP_Typ1_Coor.X.ToString();
                        tbx_typ1_coor_y.Text = PLC.PnP_Typ1_Coor.Y.ToString();
                        tbx_typ1_coor_z.Text = PLC.PnP_Typ1_Coor.Z.ToString();

                        tbx_typ2_coor_x.Text = PLC.PnP_Typ2_Coor.X.ToString();
                        tbx_typ2_coor_y.Text = PLC.PnP_Typ2_Coor.Y.ToString();
                        tbx_typ2_coor_z.Text = PLC.PnP_Typ2_Coor.Z.ToString();

                        tbx_typ3_coor_x.Text = PLC.PnP_Typ3_Coor.X.ToString();
                        tbx_typ3_coor_y.Text = PLC.PnP_Typ3_Coor.Y.ToString();
                        tbx_typ3_coor_z.Text = PLC.PnP_Typ3_Coor.Z.ToString();
                        #endregion

                        #region read offset, z distance, y limit & show
                        PLC.ReadParameterDouble(ref DeltaPLC, ref PLC.Z_Pick, PLC_Addr.PickDown);
                        PLC.ReadParameterDouble(ref DeltaPLC, ref PLC.Z_Place, PLC_Addr.PlaceDown);
                        PLC.ReadParameterDouble(ref DeltaPLC, ref PLC.Y_Pick_Limit_High, PLC_Addr.Y_Pick_Limit_High);
                        PLC.ReadParameterDouble(ref DeltaPLC, ref PLC.Y_Pick_Limit_Low, PLC_Addr.Y_Pick_Limit_Low);
                        PLC.Read_PnP_Offset(ref DeltaPLC);
                        tbx_auto_offsetX.Text = PLC.PnP_Offset.X.ToString();
                        tbx_auto_offsetY.Text = PLC.PnP_Offset.Y.ToString();
                        tbx_auto_offsetZ.Text = PLC.PnP_Offset.Z.ToString();
                        tbx_auto_ZPick.Text = PLC.Z_Pick.ToString();
                        tbx_auto_ZPlace.Text = PLC.Z_Place.ToString();
                        tbx_y_limit_high.Text = PLC.Y_Pick_Limit_High.ToString();
                        tbx_y_limit_low.Text = PLC.Y_Pick_Limit_Low.ToString();
                        #endregion

                        #region read count value & show
                        PLC.ReadParameterShort(ref DeltaPLC, ref PLC.Count_Type_1, PLC_Addr.TargetCount_1);
                        PLC.ReadParameterShort(ref DeltaPLC, ref PLC.Count_Type_2, PLC_Addr.TargetCount_2);
                        PLC.ReadParameterShort(ref DeltaPLC, ref PLC.Count_Type_3, PLC_Addr.TargetCount_3);
                        lb_typ1_count.Text = PLC.Count_Type_1.ToString();
                        lb_typ2_count.Text = PLC.Count_Type_2.ToString();
                        lb_typ3_count.Text = PLC.Count_Type_3.ToString();
                        #endregion
                        PLC.Read_Init = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    #endregion PLC cyclic read data

        //--------Image proccess----------//
    #region img set change
        #region img set change event
        // change num
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int set = Convert.ToInt32(num_img_set.Value) - 1;
            Cam_S.Set = set;
            Cam_S.imgSet[set] = accessData.readInforImgData(set);
            // refresh limits
            scbar_HueMin.Maximum = 255;
            scbar_SatMin.Maximum = 255;
            scbar_ValMin.Maximum = 255;
            updatePageSet();
        }
        // change name
        private void tbx_img_Name_TextChanged(object sender, EventArgs e)
        {
            int set = Convert.ToInt32(num_img_set.Value) - 1;
            accessData.saveInforImgData(cNum.numSet.Name, set, tbx_img_Name.Text);
            Cam_S.imgSet[Cam_S.Set].name = tbx_img_Name.Text;
        }
        // change color lable
        private void link_img_LB_color_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (color_lable.ShowDialog() == DialogResult.OK)
            {
                // save
                int set = Convert.ToInt32(num_img_set.Value) - 1;
                accessData.saveInforImgData(cNum.numSet.Lable_Color, set, color_lable.Color);
                // convert to int32
                string colorString = Convert.ToString(color_lable.Color.ToArgb());
                Int32 colorArgb = Convert.ToInt32(colorString);
                Cam_S.imgSet[Cam_S.Set].Lable_Color = colorArgb;

                changeBtnColor(Cam_S.imgSet[Cam_S.Set].Lable_Color, ref link_img_LB_color);
            }
        }
        // select shapes
        private void cbx_img_shape_SelectedIndexChanged(object sender, EventArgs e)
        {
            int set = Convert.ToInt32(num_img_set.Value) - 1;
            accessData.saveInforImgData(cNum.numSet.Shapes, set, cbx_img_shape.SelectedIndex.ToString());
            Cam_S.imgSet[Cam_S.Set].shape = cbx_img_shape.SelectedIndex;
        }
        // change area max
        private void tbx_img_Area_max_Leave(object sender, EventArgs e)
        {
            int set = Convert.ToInt32(num_img_set.Value) - 1;
            accessData.saveInforImgData(cNum.numSet.Area_Max, set, tbx_img_Area_max.Text);
            Cam_S.imgSet[Cam_S.Set].area_max = Convert.ToDouble(tbx_img_Area_max.Text);
        }
        // change area min
        private void tbx_img_Area_min_Leave(object sender, EventArgs e)
        {
            int set = Convert.ToInt32(num_img_set.Value) - 1;
            accessData.saveInforImgData(cNum.numSet.Area_Min, set, tbx_img_Area_min.Text);
            Cam_S.imgSet[Cam_S.Set].area_min = Convert.ToDouble(tbx_img_Area_min.Text);
        }
        // change hue max
        private void scbar_HueMax_Scroll(object sender, ScrollEventArgs e)
        {
            scrollbarValueChange(scbar_HueMax, lb_img_hueMax);
            accessData.saveInforImgData(cNum.numSet.Hue_Max, Cam_S.Set, Convert.ToDouble(scbar_HueMax.Value));
            scrollbarChangeLimit(scbar_HueMax, scbar_HueMin, lb_img_hueMin, cNum.numSet.Hue_Min);
            changeLimitValue(ref Cam_S.imgSet, cNum.numSet.Hue_Max, scbar_HueMax.Value, Cam_S.Set);
            changeLimitValue(ref Cam_S.imgSet, cNum.numSet.Hue_Min, scbar_HueMin.Value, Cam_S.Set);
        }
        // change hue min
        private void scbar_HueMin_Scroll(object sender, ScrollEventArgs e)
        {
            scrollbarValueChange(scbar_HueMin, lb_img_hueMin);
            accessData.saveInforImgData(cNum.numSet.Hue_Min, Cam_S.Set, Convert.ToDouble(scbar_HueMin.Value));
            changeLimitValue(ref Cam_S.imgSet, cNum.numSet.Hue_Min, scbar_HueMin.Value, Cam_S.Set);
        }
        // change saturation max
        private void scbar_SatMax_Scroll(object sender, ScrollEventArgs e)
        {
            scrollbarValueChange(scbar_SatMax, lb_img_satMax);
            accessData.saveInforImgData(cNum.numSet.Sat_Max, Cam_S.Set, Convert.ToDouble(scbar_SatMax.Value));
            scrollbarChangeLimit(scbar_SatMax, scbar_SatMin, lb_img_satMin, cNum.numSet.Sat_Min);
            changeLimitValue(ref Cam_S.imgSet, cNum.numSet.Sat_Max, scbar_SatMax.Value, Cam_S.Set);
            changeLimitValue(ref Cam_S.imgSet, cNum.numSet.Sat_Min, scbar_SatMin.Value, Cam_S.Set);
        }
        // change saturation main
        private void scbar_SatMin_Scroll(object sender, ScrollEventArgs e)
        {
            scrollbarValueChange(scbar_SatMin, lb_img_satMin);
            accessData.saveInforImgData(cNum.numSet.Sat_Min, Cam_S.Set, Convert.ToDouble(scbar_SatMin.Value));
            changeLimitValue(ref Cam_S.imgSet, cNum.numSet.Sat_Min, scbar_SatMin.Value, Cam_S.Set);
        }
        // change value max
        private void scbar_ValMax_Scroll(object sender, ScrollEventArgs e)
        {
            scrollbarValueChange(scbar_ValMax, lb_img_valMax);
            accessData.saveInforImgData(cNum.numSet.Val_Max, Cam_S.Set, Convert.ToDouble(scbar_ValMax.Value));
            scrollbarChangeLimit(scbar_ValMax, scbar_ValMin, lb_img_valMin, cNum.numSet.Val_Min);
            changeLimitValue(ref Cam_S.imgSet, cNum.numSet.Val_Max, scbar_ValMax.Value, Cam_S.Set);
            changeLimitValue(ref Cam_S.imgSet, cNum.numSet.Val_Min, scbar_ValMin.Value, Cam_S.Set);
        }
        // change value min
        private void scbar_ValMin_Scroll(object sender, ScrollEventArgs e)
        {
            scrollbarValueChange(scbar_ValMin, lb_img_valMin);
            accessData.saveInforImgData(cNum.numSet.Val_Min, Cam_S.Set, Convert.ToDouble(scbar_ValMin.Value));
            changeLimitValue(ref Cam_S.imgSet, cNum.numSet.Val_Min, scbar_ValMin.Value, Cam_S.Set);
        }
        #endregion
        #region function call from event
        // use when update all elements of set group
        private void updatePageSet()
        {
            tbx_img_Name.Text = Cam_S.imgSet[Cam_S.Set].name;
            cbx_img_shape.SelectedIndex = Cam_S.imgSet[Cam_S.Set].shape;

            tbx_img_Area_max.Text = Cam_S.imgSet[Cam_S.Set].area_max.ToString();
            tbx_img_Area_min.Text = Cam_S.imgSet[Cam_S.Set].area_min.ToString();

            changeBtnColor(Cam_S.imgSet[Cam_S.Set].Lable_Color, ref link_img_LB_color);

            scrollbarValueChange(scbar_HueMax, lb_img_hueMax, Cam_S.imgSet[Cam_S.Set].Max.Hue);
            scrollbarValueChange(scbar_HueMin, lb_img_hueMin, Cam_S.imgSet[Cam_S.Set].Min.Hue);
            scrollbarChangeLimit(scbar_HueMax, scbar_HueMin, lb_img_hueMin, cNum.numSet.Hue_Min);

            scrollbarValueChange(scbar_SatMax, lb_img_satMax, Cam_S.imgSet[Cam_S.Set].Max.Satuation);
            scrollbarValueChange(scbar_SatMin, lb_img_satMin, Cam_S.imgSet[Cam_S.Set].Min.Satuation);
            scrollbarChangeLimit(scbar_SatMax, scbar_SatMin, lb_img_satMin, cNum.numSet.Sat_Min);
           
            scrollbarValueChange(scbar_ValMax, lb_img_valMax, Cam_S.imgSet[Cam_S.Set].Max.Value);
            scrollbarValueChange(scbar_ValMin, lb_img_valMin, Cam_S.imgSet[Cam_S.Set].Min.Value);
            scrollbarChangeLimit(scbar_ValMax, scbar_ValMin, lb_img_valMin, cNum.numSet.Val_Min);
        }
        // change limit value
        private void scrollbarChangeLimit(HScrollBar scbarMax, HScrollBar scbarMin, Label lb, cNum.numSet para)
        {
            scbarMin.Maximum = scbarMax.Value - 1;
            lb.Text = Convert.ToString(scbarMin.Value);
        }
        // use when change num set
        private void scrollbarValueChange(HScrollBar scbar, Label lb, double value)
        {
            scbar.Value = Convert.ToInt32(value);
            lb.Text = Convert.ToString(value);
        }
        // use when change element of num set, save value to txt
        private void scrollbarValueChange(HScrollBar scbar, Label lb)
        {
            lb.Text = Convert.ToString(scbar.Value);
        }
        private void changeBtnColor(Int32 argb, ref LinkLabel btn)
        {
            Color tmpCl = new Color();
            tmpCl = Color.FromArgb(argb);
            btn.LinkColor = tmpCl;
            btn.ActiveLinkColor = tmpCl;
        }
        private void changeLimitValue(ref ImgSet[] save, cNum.numSet para, int value, int set)
        {
            ImgSet tmpp = save[set];
            Hsv hsvTemp = new Hsv();
            switch (para)
            {
                case cNum.numSet.Hue_Max:
                    hsvTemp = tmpp.Max;
                    hsvTemp.Hue = Convert.ToDouble(value);
                    tmpp.Max = hsvTemp;
                    break;
                case cNum.numSet.Hue_Min:
                    hsvTemp = tmpp.Min;
                    hsvTemp.Hue = Convert.ToDouble(value);
                    tmpp.Min = hsvTemp;
                    break;
                case cNum.numSet.Sat_Max:
                    hsvTemp = tmpp.Max;
                    hsvTemp.Satuation = Convert.ToDouble(value);
                    tmpp.Max = hsvTemp;
                    break;
                case cNum.numSet.Sat_Min:
                    hsvTemp = tmpp.Min;
                    hsvTemp.Satuation = Convert.ToDouble(value);
                    tmpp.Min = hsvTemp;
                    break;
                case cNum.numSet.Val_Max:
                    hsvTemp = tmpp.Max;
                    hsvTemp.Value = Convert.ToDouble(value);
                    tmpp.Max = hsvTemp;
                    break;
                case cNum.numSet.Val_Min:
                    hsvTemp = tmpp.Min;
                    hsvTemp.Value = Convert.ToDouble(value);
                    tmpp.Min = hsvTemp;
                    break;
            }

            save[set] = tmpp;
        }
        #endregion
        #endregion img set change

        #region Automode
        #region Automode Event
        private void tbx_auto_TL_X_Leave(object sender, EventArgs e)
        {
            double tmp = Convert.ToDouble(tbx_auto_TL_X.Text);
            accessData.saveTLPos(ref settingCam.calibCam, tmp, settingCam.calibCam.TL_Position_Y);
        }
        private void tbx_auto_TL_Y_Leave(object sender, EventArgs e)
        {
            double tmp = Convert.ToDouble(tbx_auto_TL_Y.Text);
            accessData.saveTLPos(ref settingCam.calibCam, settingCam.calibCam.TL_Position_X, tmp);
        }
        private void tbx_auto_offsetX_Leave(object sender, EventArgs e)
        {
            PLC.Convert_N_Write_Double(ref DeltaPLC, tbx_auto_offsetX.Text, PLC_Addr.PNP_Offset_X);
        }
        private void tbx_auto_offsetY_Leave(object sender, EventArgs e)
        {
            PLC.Convert_N_Write_Double(ref DeltaPLC, tbx_auto_offsetY.Text, PLC_Addr.PNP_Offset_Y);
        }
        private void tbx_auto_offsetZ_Leave(object sender, EventArgs e)
        {
            PLC.Convert_N_Write_Double(ref DeltaPLC, tbx_auto_offsetZ.Text, PLC_Addr.PNP_Offset_Z);
        }
        private void tbx_auto_ZPick_Leave(object sender, EventArgs e)
        {
            PLC.Convert_N_Write_Double(ref DeltaPLC, tbx_auto_ZPick.Text, PLC_Addr.PickDown);
        }
        private void tbx_auto_ZPlace_Leave(object sender, EventArgs e)
        {
            PLC.Convert_N_Write_Double(ref DeltaPLC, tbx_auto_ZPlace.Text, PLC_Addr.PlaceDown);
        }
        private void tbx_typ1_coor_x_Leave(object sender, EventArgs e)
        {
            PLC.Convert_N_Write_Double(ref DeltaPLC, tbx_typ1_coor_x.Text, PLC_Addr.PlacePos_1_X);
        }
        private void tbx_typ1_coor_y_Leave(object sender, EventArgs e)
        {
            PLC.Convert_N_Write_Double(ref DeltaPLC, tbx_typ1_coor_y.Text, PLC_Addr.PlacePos_1_Y);
        }
        private void tbx_typ1_coor_z_Leave(object sender, EventArgs e)
        {
            PLC.Convert_N_Write_Double(ref DeltaPLC, tbx_typ1_coor_z.Text, PLC_Addr.PlacePos_1_Z);
        }
        private void tbx_typ2_coor_x_Leave(object sender, EventArgs e)
        {
            PLC.Convert_N_Write_Double(ref DeltaPLC, tbx_typ2_coor_x.Text, PLC_Addr.PlacePos_2_X);
        }
        private void tbx_typ2_coor_y_Leave(object sender, EventArgs e)
        {
            PLC.Convert_N_Write_Double(ref DeltaPLC, tbx_typ2_coor_y.Text, PLC_Addr.PlacePos_2_Y);
        }
        private void tbx_typ2_coor_z_Leave(object sender, EventArgs e)
        {
            PLC.Convert_N_Write_Double(ref DeltaPLC, tbx_typ2_coor_z.Text, PLC_Addr.PlacePos_2_Z);
        }
        private void tbx_typ3_coor_x_Leave(object sender, EventArgs e)
        {
            PLC.Convert_N_Write_Double(ref DeltaPLC, tbx_typ3_coor_x.Text, PLC_Addr.PlacePos_3_X);
        }
        private void tbx_typ3_coor_y_Leave(object sender, EventArgs e)
        {
            PLC.Convert_N_Write_Double(ref DeltaPLC, tbx_typ3_coor_y.Text, PLC_Addr.PlacePos_3_Y);
        }
        private void tbx_typ3_coor_z_Leave(object sender, EventArgs e)
        {
            PLC.Convert_N_Write_Double(ref DeltaPLC, tbx_typ3_coor_z.Text, PLC_Addr.PlacePos_3_Z);
        }
        private void tbx_y_limit_high_Leave(object sender, EventArgs e)
        {
            PLC.Convert_N_Write_Double(ref DeltaPLC, tbx_y_limit_high.Text, PLC_Addr.Y_Pick_Limit_High);
            PLC.ReadParameterDouble(ref DeltaPLC, ref PLC.Y_Pick_Limit_High, PLC_Addr.Y_Pick_Limit_High);
        }
        private void tbx_y_limit_low_Leave(object sender, EventArgs e)
        {
            PLC.Convert_N_Write_Double(ref DeltaPLC, tbx_y_limit_low.Text, PLC_Addr.Y_Pick_Limit_Low);
            PLC.ReadParameterDouble(ref DeltaPLC, ref PLC.Y_Pick_Limit_Low, PLC_Addr.Y_Pick_Limit_Low);
        }
        private void link_typ1_clear_LinkClicked(object sender, EventArgs e)
        {
            short tmp = (short)0;
            PLC.WriteShort(ref DeltaPLC, PLC_Addr.TargetCount_1, tmp);
            PLC.ReadParameterShort(ref DeltaPLC, ref PLC.Count_Type_1, PLC_Addr.TargetCount_1);
            lb_typ1_count.Text = PLC.Count_Type_1.ToString();
        }
        private void link_typ2_clear_LinkClicked(object sender, EventArgs e)
        {
            short tmp = (short)0;
            PLC.WriteShort(ref DeltaPLC, PLC_Addr.TargetCount_2, tmp);
            PLC.ReadParameterShort(ref DeltaPLC, ref PLC.Count_Type_2, PLC_Addr.TargetCount_2);
            lb_typ2_count.Text = PLC.Count_Type_2.ToString();
        }
        private void link_typ3_clear_LinkClicked(object sender, EventArgs e)
        {
            short tmp = (short)0;
            PLC.WriteShort(ref DeltaPLC, PLC_Addr.TargetCount_3, tmp);
            PLC.ReadParameterShort(ref DeltaPLC, ref PLC.Count_Type_3, PLC_Addr.TargetCount_3);
            lb_typ3_count.Text = PLC.Count_Type_3.ToString();
        }
        private void link_clear_all_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            short tmp = (short)0;
            PLC.WriteShort(ref DeltaPLC, PLC_Addr.TargetCount_1, tmp);
            PLC.WriteShort(ref DeltaPLC, PLC_Addr.TargetCount_2, tmp);
            PLC.WriteShort(ref DeltaPLC, PLC_Addr.TargetCount_3, tmp);

            PLC.ReadParameterShort(ref DeltaPLC, ref PLC.Count_Type_1, PLC_Addr.TargetCount_1);
            PLC.ReadParameterShort(ref DeltaPLC, ref PLC.Count_Type_2, PLC_Addr.TargetCount_2);
            PLC.ReadParameterShort(ref DeltaPLC, ref PLC.Count_Type_3, PLC_Addr.TargetCount_3);

            lb_typ1_count.Text = PLC.Count_Type_1.ToString();
            lb_typ2_count.Text = PLC.Count_Type_2.ToString();
            lb_typ3_count.Text = PLC.Count_Type_3.ToString();
        }

        Timer AutoModeTimer = new Timer { Interval = 100 };
        private void btn_auto_OnOff_Click(object sender, EventArgs e)
        {
            if (!OnAutoMode)
            {
                if (!PLC.IsConnect)
                {
                    MessageBox.Show("PLC not connected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Cam_S.captureInProgress)
                {
                    MessageBox.Show("Camera not opening", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                Itf_Lb.set_automode_btn_status(ref btn_auto_OnOff, true);
                this.SetAutoModeButtonEnable(false);

                ObQueue.queue.Clear();
                PLC.Pnp_Start(ref DeltaPLC);
                changeSWInAutoMode();

                AutoModeTimer.Tick += new System.EventHandler(AutoModeTimerHandler);
                AutoModeTimer.Start();

                OnAutoMode = !OnAutoMode;
            }
            else
            {
                AutoModeTimer.Stop();
                PLC.Pnp_Stop(ref DeltaPLC);
                changeSWInAutoMode();
                Itf_Lb.set_automode_btn_status(ref btn_auto_OnOff, false);
                this.SetAutoModeButtonEnable(true);
                OnAutoMode = !OnAutoMode;
            }
        }
        // enable of disable button, textbox,.. when automode on or off 
        private void SetAutoModeButtonEnable(bool status)
        {
            imageProcess_grbox.Enabled = status;
            movement_grbox.Enabled = status;

            btn_pos_home.Enabled = status;

            sw_th_Vaccum.Enabled = status;
            sw_th_Valve.Enabled = status;

            sw_con_Run.Enabled = status;
            tbx_con_speed.Enabled = status;
        }
        private void changeSWInAutoMode()
        {
            bool readTmp = false;
            PLC.ReadParameterBit(ref DeltaPLC, ref readTmp, PLC_Addr.Vaccum);
            sw_th_Vaccum.Switched = readTmp;
            PLC.ReadParameterBit(ref DeltaPLC, ref readTmp, PLC_Addr.Conveyor);
            sw_con_Run.Switched = readTmp;
        }
        #endregion

        // auto mode timer handler
        public void AutoModeTimerHandler(object source, EventArgs e)
        {
            // check connected still alive & read busy bit
            bool readbool = false;
            if (!PLC.ReadParameterBit(ref DeltaPLC, ref readbool, PLC_Addr.PNP_Busy))
                return;
            readCount = true;
            // if not busy pick any object, send pick parameter & run
            if (!readbool)
            {
                // cyclic check object
                if (ObQueue.queue.Count > 0)
                {
                    for (int i = 0; i < ObQueue.queue.Count; i++)
                    {
                        double tmp = ObQueue.queue[i].timeStamp.Elapsed.TotalSeconds;
                        ObQueue.queue[i].CurrentY = ObQueue.queue[i].CoorY - (tmp * (double)PLC.Conveyor_Set_Velocity);
                        if( (ObQueue.queue[i].CurrentY <= PLC.Y_Pick_Limit_High) &&
                            (ObQueue.queue[i].CurrentY >= PLC.Y_Pick_Limit_Low))
                        {
                            DeltaPosition tmpPos = new DeltaPosition();
                            short indTarget = Convert.ToInt16(ObQueue.queue[i].typeObject);
                            tmpPos.X = ObQueue.queue[i].CoorX;
                            tmpPos.Y = ObQueue.queue[i].CurrentY;
                            //tmpPos.Z = offset.Z;
                            PLC.PnP_Pick(ref DeltaPLC, tmpPos, indTarget);
                            //PLC.Conveyor(ref DeltaPLC, 0);
                            ObQueue.queue.RemoveAt(i);
                            ObQueue.changeQueue = true;
                            ObQueue.ObjInd_InCam = ObQueue.queue.Count - 1;
                            return;
                        }
                    }
                }
            }
        }
        #endregion Automode

        private void btn_objQueueView_Click_1(object sender, EventArgs e)
        {
            if (!Form_Status.viewQueue)
            {
                Form_Object_Infor formViewQueue = new Form_Object_Infor();
                Form_Status.viewQueue = true;
                formViewQueue.Show();
            }
        }

        private void link_selectPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool pathExists = false;
            while (!pathExists)
            {
                OpenFileDialog pathdialog = new OpenFileDialog();
                if (pathdialog.ShowDialog() == DialogResult.OK)
                {
                    string fullPath = pathdialog.FileName;
                    string fileName = pathdialog.SafeFileName;
                    accessData.savePath = fullPath.Replace(fileName, "") + fileName;
                }

                pathExists = File.Exists(accessData.savePath);
            }
        }
    }
}
