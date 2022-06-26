using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        // init
        // cam
        public VideoCapture CamProcess;
        public Mat _frame;
        // plc
        private Plc DeltaPLC = null;
        private ErrorCode errCode;
        // image process
        public Form_Main()
        {
            InitializeComponent();
        }
        // form load
        private void Form_Main_Load(object sender, EventArgs e)
        {
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
        }

        /*          MenuStrip event          */

        //-----------Camera----------------//
        #region Camera
        #region Event
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
                Camera_Enable();
                // change imagebox
                imgBox_crop.Visible = true;
                picbox_offCam.Visible = false;
                // check connect - refresh button
                if (CamProcess.IsOpened)
                {
                    Itf_Lb.set_cam_btn_status(ref btn_cam_connect, true);
                }
                // enable setting camera button
                btn_cam_setting.Enabled = true;
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
                btn_cam_setting.Enabled = false;
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
                    CamProcess = new VideoCapture(Cam_S.Index);
                    CamProcess.ImageGrabbed += ProcessFrame;
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
                _frame = new Mat();
            }
            // start & call handler
            if (CamProcess != null)
            {
                if (!Cam_S.captureInProgress)
                {
                    //start the capture
                    CamProcess.Start();
                    bool tmppp = CamProcess.Set(CapProp.Fps, 5);
                    Cam_S.captureInProgress = true;
                    cbb_Camlist.Enabled = false;
                }
            }
        }
        // event handler
        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (CamProcess != null && CamProcess.Ptr != IntPtr.Zero)
            {
                CamProcess.Retrieve(_frame);
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
                            imgBox_crop.Image = processAndShowGray(imgCrop, Cam_S.imgSet[Cam_S.Set].Min, Cam_S.imgSet[Cam_S.Set].Max);
                        }
                        else
                        {
                            imgBox_crop.Image = processAndShow(imgCrop, Cam_S.imgSet);
                        }
                    }
                }
            }
        }
        // stop capture
        private void Camera_Disable()
        {
            if (CamProcess != null)
            {
                if (Cam_S.captureInProgress)
                {
                    //stop the capture
                    CamProcess.Dispose();
                    Cam_S.captureInProgress = false;
                    cbb_Camlist.Enabled = true;
                }
            }
        }
        // camera config
        private void btn_cam_setting_Click(object sender, EventArgs e)
        {
            Form_CamSetting _camSet = new Form_CamSetting();
            settingCam.IsConFig = true;
            settingCam.set_Frame = new Mat();
            settingCam.fps = CamProcess.Get(Emgu.CV.CvEnum.CapProp.Fps);
            _camSet.ShowDialog();

        }
        #endregion
        #region image process
        private Image<Bgr, byte> processAndShow(Image<Bgr, byte> inputIMG, ImgSet[] imgSet)
        {
            Image<Bgr, byte> _result = new Image<Bgr, byte>(inputIMG.Width, inputIMG.Height);
            inputIMG.CopyTo(_result);

            for (int cntSet = 0; cntSet < accessData.NUMOFSET; cntSet++)
            {
                Hsv highRange = imgSet[cntSet].Max;
                Hsv lowRange = imgSet[cntSet].Min;

                //double ratioImg = 1;
                //if (inputIMG.Width > 300)
                //{
                //    ratioImg = (1 / (double)inputIMG.Width) * 300;
                //}
                // resize image can be approximated better
                //Image<Bgr, byte> resizeIMG = inputIMG.Resize(ratioImg, Inter.Linear);
                // convert bgr to hsv
                Image<Hsv, byte> hsvImg = new Image<Hsv, byte>(inputIMG.Width, inputIMG.Height);
                CvInvoke.CvtColor(inputIMG, hsvImg, ColorConversion.Bgr2Hsv);
                // smooth image with gaussian blur
                CvInvoke.GaussianBlur(hsvImg, hsvImg, new Size(5, 5), 1);
                // convert hsv to binary with range limit
                Image<Gray, byte> grayImg = hsvImg.InRange(lowRange, highRange);
                // opening
                grayImg = grayImg.Erode(2);
                grayImg = grayImg.Dilate(2);

                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                Mat n = new Mat();
                CvInvoke.FindContours(grayImg, contours, n, Emgu.CV.CvEnum.RetrType.Ccomp, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

                List<Triangle2DF> triangleList = new List<Triangle2DF>();
                List<RotatedRect> boxList = new List<RotatedRect>(); //a box is a rotated rectangle

                for (int i = 0; i < contours.Size; i++)
                {
                    double pemir = CvInvoke.ArcLength(contours[i], true);
                    VectorOfPoint approx = new VectorOfPoint();
                    // epsilon in the range of 1 - 5 % of the original contour perimeter.
                    CvInvoke.ApproxPolyDP(contours[i], approx, 0.04 * pemir, true);

                    // find center
                    var moments = CvInvoke.Moments(contours[i]);
                    double area = moments.M00 * 2;

                    int x = (int)(moments.M10 / moments.M00);
                    int y = (int)(moments.M01 / moments.M00);
                    string x1 = x.ToString();
                    string y1 = y.ToString();
                    string td = x1 + "," + y1;

                    // detect shapes
                    // if contour has 3 vertices => triangles
                    // if contour has 4 vertices => rectangles
                    // else => circles

                    if (CvInvoke.ContourArea(approx, false) > 250) //only consider contours with area greater than 250
                    {
                        if (approx.Size == 3) //The contour has 3 vertices, it is a triangle
                        {
                            Point[] pts = approx.ToArray();
                            triangleList.Add(new Triangle2DF(
                                pts[0],
                                pts[1],
                                pts[2]
                            ));
                        }
                        else if (approx.Size == 4) //The contour has 4 vertices.
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
                        }
                    }

                    #region draw triangles and rectangles
                    //triangleRectangleImage.SetTo(new MCvScalar(0));
                    foreach (Triangle2DF triangle in triangleList)
                    {
                        CvInvoke.Polylines(_result, Array.ConvertAll(triangle.GetVertices(), Point.Round),
                            true, new Bgr(Color.DarkBlue).MCvScalar, 2);
                    }

                    foreach (RotatedRect box in boxList)
                    {
                        CvInvoke.Polylines(_result, Array.ConvertAll(box.GetVertices(), Point.Round), true,
                            new Bgr(Color.Cyan).MCvScalar, 2);
                    }

                    //Drawing a light gray frame around the image
                    CvInvoke.Rectangle(_result,
                        new Rectangle(Point.Empty,
                            new Size(_result.Width - 1, _result.Height - 1)),
                        new MCvScalar(120, 120, 120));
                    #endregion

                    //CvInvoke.DrawContours(_result, contours, i, new MCvScalar(0, 255, 0), 3);
                    CvInvoke.Circle(_result, new Point(x, y), 2, new MCvScalar(0, 255, 0), 2);
                    CvInvoke.PutText(_result, td, new Point(x, y), Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new MCvScalar(0, 0, 255), 2);

                    double tmpArea = CvInvoke.ContourArea(approx, false);
                    //lb_cam_area.Text = tmpArea.ToString();
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
            imgtemp = imgtemp.Erode(2);
            imgtemp = imgtemp.Dilate(2);
            return imgtemp;
        }
        #endregion

        #endregion

        #region PLC
        // plc connect
        private void btn_plc_connect_Click(object sender, EventArgs e)
        {
            if (!PLCSelect.IsConnect)
            {
                try
                {
                    // check textbox empty
                    if (string.IsNullOrEmpty(tbx_plc_ip.Text)) throw new Exception("Please enter IP Address.");
                    // init for plc
                    S7.Net.CpuType cpuType = CpuType.S71200;
                    string ipAddress = tbx_plc_ip.Text;
                    DeltaPLC = new Plc(cpuType, ipAddress, 0, 1);
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
                        PLCSelect.IsConnect = !PLCSelect.IsConnect;
                    }
                    // enables cyclic read
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

                DeltaPLC.Close();
                MessageBox.Show(this, "Disconnected PLC!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Itf_Lb.set_plc_btn_status(ref btn_plc_connect, false);
                this.SetEnableButtonConnect(true);
                PLCSelect.IsConnect = !PLCSelect.IsConnect;
            }
        }
        // enable textbox
        private void SetEnableButtonConnect(bool status)
        {
            tbx_plc_ip.Enabled = status;
        }

        /*----------------------------------------------*/
        // button home
        #region move
        private void btn_pos_home_Click(object sender, EventArgs e)
        {
            DeltaPLC.Write(PLC_Addr.Home, 1);
            DeltaPLC.Write(PLC_Addr.Home, 0);
            PLC_Addr.HomingDone.hold = false;
            PLC_Addr.HomingDone.flag = true;
        }

        private void btn_Mov_Move_Click(object sender, EventArgs e)
        {
            PLCSelect.ReadBusy = true;

            PLCSelect.Pos.X = Convert.ToDouble(tbx_mov_X.Text);
            PLCSelect.Pos.Y = Convert.ToDouble(tbx_mov_Y.Text);
            PLCSelect.Pos.Z = Convert.ToDouble(tbx_mov_Z.Text);
            PushToRingBuffer(PLCSelect.Pos);
            DeltaPLC.Write(PLC_Addr.MoveTO, 1);
            DeltaPLC.Write(PLC_Addr.MoveTO, 0);

            short speed = Convert.ToInt16(tbx_mov_velocity.Text);
            short nPoint = Convert.ToInt16(1);

            DeltaPLC.Write(PLC_Addr.nPoint, nPoint.ConvertToUshort());
            DeltaPLC.Write(PLC_Addr.EESpeed, speed.ConvertToUshort());

            PLCSelect.ReadBusy = false;
        }
        #endregion

        #region XYZ move
        private void btn_mov_Xplus_Click(object sender, EventArgs e)
        {
            moveXYZ(PLC_Addr.Xplus);
        }

        private void btn_mov_Yplus_Click(object sender, EventArgs e)
        {
            moveXYZ(PLC_Addr.Yplus);
        }

        private void btn_mov_Zplus_Click(object sender, EventArgs e)
        {
            moveXYZ(PLC_Addr.Zplus);
        }

        private void btn_mov_Xmin_Click(object sender, EventArgs e)
        {
            moveXYZ(PLC_Addr.Xminus);
        }

        private void btn_mov_Ymin_Click(object sender, EventArgs e)
        {
            moveXYZ(PLC_Addr.Yminus);
        }

        private void btn_mov_Zmin_Click(object sender, EventArgs e)
        {
            moveXYZ(PLC_Addr.Zminus);
        }

        private void moveXYZ(string _addr)
        {
            PLCSelect.ReadBusy = true;

            double division;
            if (PLCSelect.Division_Change)
            {
                division = Convert.ToDouble(tbx_mov_division.Text);
                DeltaPLC.Write(PLC_Addr.Division, division.ConvertToUInt());
                PLCSelect.Division_Change = false;
            }

            DeltaPLC.Write(_addr, 1);
            DeltaPLC.Write(_addr, 0);

            PLCSelect.ReadBusy = false;
        }

        private void tbx_mov_division_TextChanged(object sender, EventArgs e)
        {
            PLCSelect.Division_Change = true;
        }
        #endregion

        #region Tool Head
        // switch vaccum
        private void sw_th_Vaccum_SwitchedChanged(object sender)
        {
            if (sw_th_Vaccum.Switched)
            {
                DeltaPLC.Write(PLC_Addr.Vaccum, 1);
            }
            else
            {
                DeltaPLC.Write(PLC_Addr.Vaccum, 0);
            }
        }
        // switch valve
        private void sw_th_Valve_SwitchedChanged(object sender)
        {
            if (sw_th_Valve.Switched)
            {
                DeltaPLC.Write(PLC_Addr.Valve, 1);
            }
            else
            {
                DeltaPLC.Write(PLC_Addr.Valve, 0);
            }
        }
        #endregion

        #endregion
        #region Conveyor
        private void sw_con_Run_SwitchedChanged(object sender)
        {
            double conveyor_Speed;
            PLCSelect.ReadBusy = true;

            if(sw_con_Run.Switched)
            {
                if(PLCSelect.ConveyorSpeed_Change)
                {
                    conveyor_Speed = Convert.ToDouble(tbx_con_speed.Text);
                    DeltaPLC.Write(PLC_Addr.PID_Setpoint, conveyor_Speed.ConvertToUInt());
                    PLCSelect.ConveyorSpeed_Change = false;
                }

                DeltaPLC.Write(PLC_Addr.Conveyor, 1);
            }
            else
            {
                DeltaPLC.Write(PLC_Addr.Conveyor, 0);
            }

            PLCSelect.ReadBusy = false;
        }
        private void tbx_con_speed_TextChanged(object sender, EventArgs e)
        {
            PLCSelect.ConveyorSpeed_Change = true;
        }

        #endregion
        #region PLC cyclic
        private void cyclicRead_Tick(object sender, EventArgs e)
        {
            if ((PLCSelect.IsConnect==true) && (PLCSelect.ReadBusy==false))
            {
                try
                {
                    if (PLC_Addr.HomingDone.flag)
                    {
                        PLC_Addr.HomingDone.bit = read_Singles_Bit(DataType.DataBlock, PLC_Addr.HomingDone.Addr);

                        if (!PLC_Addr.HomingDone.hold)
                        {
                            PLC_Addr.HomingDone.flag = false;
                        }
                    }

                    if (PLC_Addr.Pos_Last_X.flag)
                    {

                        PLCSelect.Pos.X = ((uint)DeltaPLC.Read(PLC_Addr.Pos_Last_X.Addr)).ConvertToDouble();
                        PLCSelect.Pos.Y = ((uint)DeltaPLC.Read(PLC_Addr.Pos_Last_Y.Addr)).ConvertToDouble();
                        PLCSelect.Pos.Z = ((uint)DeltaPLC.Read(PLC_Addr.Pos_Last_Z.Addr)).ConvertToDouble();
                        lb_Pos_X.Text = Math.Round(PLCSelect.Pos.X).ToString();
                        lb_Pos_Y.Text = Math.Round(PLCSelect.Pos.Y).ToString();
                        lb_Pos_Z.Text = Math.Round(PLCSelect.Pos.Z).ToString();

                        if (!PLC_Addr.Pos_Last_X.hold)
                        {
                            PLC_Addr.Pos_Last_X.hold = false;
                        }
                    }

                    if (sw_con_Run.Switched)
                    {
                        PLCSelect.Conveyor_Velocity = ((uint)DeltaPLC.Read(PLC_Addr.Conveyor_MMPS)).ConvertToInt();
                        lb_con_accSpeed.Text = PLCSelect.Conveyor_Velocity.ToString();
                    }

                    if (PLCSelect.Read_Init)
                    {
                        PLCSelect.EESpeed = ((ushort)DeltaPLC.Read(PLC_Addr.EESpeed)).ConvertToShort();
                        PLCSelect.Division = ((uint)DeltaPLC.Read(PLC_Addr.Division)).ConvertToDouble();
                        tbx_mov_velocity.Text = PLCSelect.EESpeed.ToString();
                        tbx_mov_division.Text = PLCSelect.Division.ToString();
                        tbx_mov_X.Text = Math.Round(PLCSelect.Pos.X).ToString();
                        tbx_mov_Y.Text = Math.Round(PLCSelect.Pos.Y).ToString();
                        tbx_mov_Z.Text = Math.Round(PLCSelect.Pos.Z).ToString();
                        tbx_con_speed.Text = "50";
                        PLCSelect.Read_Init = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PushToRingBuffer(DeltaPosition Position)
        {
            DeltaPLC.Write(PLC_Addr.Push_POS_X, Position.X.ConvertToUInt());
            DeltaPLC.Write(PLC_Addr.Push_POS_Y, Position.Y.ConvertToUInt());
            DeltaPLC.Write(PLC_Addr.Push_POS_Z, Position.Z.ConvertToUInt());

            DeltaPLC.Write(PLC_Addr.AddNewPos, 1);
            DeltaPLC.Write(PLC_Addr.AddNewPos, 0);
        }

        private bool read_Singles_Bit(DataType _type,String addr)
        {
            int _dbInd = int.Parse(addr.Substring(2, 2));
            int startInd = int.Parse(addr.Substring(5, 1));
            int bitInd = int.Parse(addr.Right(1));
            byte[] rTmp_Byte = DeltaPLC.ReadBytes(_type, _dbInd, startInd, 1);
            byte write_Byte = rTmp_Byte[0];
            return write_Byte.SelectBit(bitInd);
        }
        #endregion
        #region img set change
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
        // use when update all elements of set group
        private void updatePageSet()
        {
            tbx_img_Name.Text = Cam_S.imgSet[Cam_S.Set].name;
            cbx_img_shape.SelectedIndex = Cam_S.imgSet[Cam_S.Set].shape;

            tbx_img_Area_max.Text = Cam_S.imgSet[Cam_S.Set].area_max.ToString();
            tbx_img_Area_min.Text = Cam_S.imgSet[Cam_S.Set].area_min.ToString();

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

        
    }
}
