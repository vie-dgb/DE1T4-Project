
namespace DE1T4_Project
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.ToolHead_grbox = new System.Windows.Forms.GroupBox();
            this.lb_th_valve = new System.Windows.Forms.Label();
            this.sw_th_Valve = new MetroSet_UI.Controls.MetroSetSwitch();
            this.lb_th_vaccum = new System.Windows.Forms.Label();
            this.sw_th_Vaccum = new MetroSet_UI.Controls.MetroSetSwitch();
            this.position_grbox = new System.Windows.Forms.GroupBox();
            this.lb_Pos_Z = new System.Windows.Forms.Label();
            this.lb_Pos_Y = new System.Windows.Forms.Label();
            this.lb_Pos_X = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Conveyor_grbox = new System.Windows.Forms.GroupBox();
            this.lb_con_mmps_v = new System.Windows.Forms.Label();
            this.lb_con_accSpeed = new System.Windows.Forms.Label();
            this.lb_con_Velocity = new System.Windows.Forms.Label();
            this.lb_Con_Run = new System.Windows.Forms.Label();
            this.lb_con_mmps = new System.Windows.Forms.Label();
            this.tbx_con_speed = new System.Windows.Forms.TextBox();
            this.lb_con_Speed = new System.Windows.Forms.Label();
            this.sw_con_Run = new MetroSet_UI.Controls.MetroSetSwitch();
            this.PLC_grbox = new System.Windows.Forms.GroupBox();
            this.btn_plc_connect = new System.Windows.Forms.Button();
            this.lb_plc_ip = new System.Windows.Forms.Label();
            this.tbx_plc_ip = new System.Windows.Forms.TextBox();
            this.camera_grbox = new System.Windows.Forms.GroupBox();
            this.btn_camsetup = new System.Windows.Forms.Button();
            this.link_img_getArea = new System.Windows.Forms.LinkLabel();
            this.lb_img_area = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.sw_img_gray = new MetroSet_UI.Controls.MetroSetSwitch();
            this.btn_frame_setting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Camlist = new System.Windows.Forms.ComboBox();
            this.btn_cam_connect = new System.Windows.Forms.Button();
            this.cyclicRead = new System.Windows.Forms.Timer(this.components);
            this.btn_mov_Ymin = new System.Windows.Forms.Button();
            this.btn_mov_Yplus = new System.Windows.Forms.Button();
            this.btn_mov_Xplus = new System.Windows.Forms.Button();
            this.btn_mov_Xmin = new System.Windows.Forms.Button();
            this.btn_mov_Zmin = new System.Windows.Forms.Button();
            this.btn_mov_Zplus = new System.Windows.Forms.Button();
            this.lb_mov_division = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_mov_division = new System.Windows.Forms.TextBox();
            this.movement_grbox = new System.Windows.Forms.GroupBox();
            this.lb_mov_mmps = new System.Windows.Forms.Label();
            this.lb_mov_velocity = new System.Windows.Forms.Label();
            this.tbx_mov_velocity = new System.Windows.Forms.TextBox();
            this.btn_Mov_Move = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_mov_Z = new System.Windows.Forms.TextBox();
            this.tbx_mov_Y = new System.Windows.Forms.TextBox();
            this.tbx_mov_X = new System.Windows.Forms.TextBox();
            this.imageProcess_grbox = new System.Windows.Forms.GroupBox();
            this.link_img_LB_color = new System.Windows.Forms.LinkLabel();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tbx_img_Area_min = new System.Windows.Forms.TextBox();
            this.tbx_img_Area_max = new System.Windows.Forms.TextBox();
            this.cbx_img_shape = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.num_img_set = new System.Windows.Forms.NumericUpDown();
            this.tbx_img_Name = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_img_valMin = new System.Windows.Forms.Label();
            this.lb_img_valMax = new System.Windows.Forms.Label();
            this.scbar_ValMin = new System.Windows.Forms.HScrollBar();
            this.label19 = new System.Windows.Forms.Label();
            this.scbar_ValMax = new System.Windows.Forms.HScrollBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_img_satMin = new System.Windows.Forms.Label();
            this.lb_img_satMax = new System.Windows.Forms.Label();
            this.scbar_SatMin = new System.Windows.Forms.HScrollBar();
            this.label16 = new System.Windows.Forms.Label();
            this.scbar_SatMax = new System.Windows.Forms.HScrollBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_img_hueMin = new System.Windows.Forms.Label();
            this.lb_img_hueMax = new System.Windows.Forms.Label();
            this.scbar_HueMin = new System.Windows.Forms.HScrollBar();
            this.label9 = new System.Windows.Forms.Label();
            this.scbar_HueMax = new System.Windows.Forms.HScrollBar();
            this.color_lable = new System.Windows.Forms.ColorDialog();
            this.tbx_auto_TL_X = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbx_auto_TL_Y = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tbx_auto_offsetX = new System.Windows.Forms.TextBox();
            this.tbx_auto_offsetY = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tbx_auto_offsetZ = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.btn_auto_OnOff = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.tbx_auto_ZPick = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.tbx_auto_ZPlace = new System.Windows.Forms.TextBox();
            this.tbx_typ1_coor_x = new System.Windows.Forms.TextBox();
            this.tbx_typ1_coor_y = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.tbx_typ1_coor_z = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.tbx_typ2_coor_x = new System.Windows.Forms.TextBox();
            this.tbx_typ2_coor_y = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tbx_typ2_coor_z = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.tbx_typ3_coor_x = new System.Windows.Forms.TextBox();
            this.tbx_typ3_coor_y = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.tbx_typ3_coor_z = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbx_y_limit_low = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.tbx_y_limit_high = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.link_clear_all = new System.Windows.Forms.LinkLabel();
            this.lb_typ1_count = new System.Windows.Forms.Label();
            this.link_typ1_clear = new System.Windows.Forms.LinkLabel();
            this.label41 = new System.Windows.Forms.Label();
            this.lb_typ3_count = new System.Windows.Forms.Label();
            this.link_typ3_clear = new System.Windows.Forms.LinkLabel();
            this.label37 = new System.Windows.Forms.Label();
            this.lb_typ2_count = new System.Windows.Forms.Label();
            this.link_typ2_clear = new System.Windows.Forms.LinkLabel();
            this.label31 = new System.Windows.Forms.Label();
            this.imgBox_crop = new Emgu.CV.UI.ImageBox();
            this.picbox_offCam = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_pos_home = new System.Windows.Forms.Button();
            this.btn_objQueueView = new System.Windows.Forms.Button();
            this.ToolHead_grbox.SuspendLayout();
            this.position_grbox.SuspendLayout();
            this.Conveyor_grbox.SuspendLayout();
            this.PLC_grbox.SuspendLayout();
            this.camera_grbox.SuspendLayout();
            this.movement_grbox.SuspendLayout();
            this.imageProcess_grbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_img_set)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_crop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_offCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolHead_grbox
            // 
            this.ToolHead_grbox.BackColor = System.Drawing.Color.Gainsboro;
            this.ToolHead_grbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToolHead_grbox.Controls.Add(this.lb_th_valve);
            this.ToolHead_grbox.Controls.Add(this.sw_th_Valve);
            this.ToolHead_grbox.Controls.Add(this.lb_th_vaccum);
            this.ToolHead_grbox.Controls.Add(this.sw_th_Vaccum);
            this.ToolHead_grbox.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolHead_grbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ToolHead_grbox.Location = new System.Drawing.Point(553, 12);
            this.ToolHead_grbox.Name = "ToolHead_grbox";
            this.ToolHead_grbox.Size = new System.Drawing.Size(155, 180);
            this.ToolHead_grbox.TabIndex = 6;
            this.ToolHead_grbox.TabStop = false;
            this.ToolHead_grbox.Text = "ToolHead";
            // 
            // lb_th_valve
            // 
            this.lb_th_valve.AutoSize = true;
            this.lb_th_valve.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_th_valve.Location = new System.Drawing.Point(47, 140);
            this.lb_th_valve.Name = "lb_th_valve";
            this.lb_th_valve.Size = new System.Drawing.Size(56, 23);
            this.lb_th_valve.TabIndex = 4;
            this.lb_th_valve.Text = "Valve";
            // 
            // sw_th_Valve
            // 
            this.sw_th_Valve.BackColor = System.Drawing.Color.Transparent;
            this.sw_th_Valve.BackgroundColor = System.Drawing.Color.Empty;
            this.sw_th_Valve.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.sw_th_Valve.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.sw_th_Valve.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.sw_th_Valve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_th_Valve.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.sw_th_Valve.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.sw_th_Valve.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.sw_th_Valve.IsDerivedStyle = true;
            this.sw_th_Valve.Location = new System.Drawing.Point(45, 107);
            this.sw_th_Valve.Name = "sw_th_Valve";
            this.sw_th_Valve.Size = new System.Drawing.Size(58, 22);
            this.sw_th_Valve.Style = MetroSet_UI.Enums.Style.Light;
            this.sw_th_Valve.StyleManager = null;
            this.sw_th_Valve.Switched = false;
            this.sw_th_Valve.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.sw_th_Valve.TabIndex = 3;
            this.sw_th_Valve.Text = "metroSetSwitch1";
            this.sw_th_Valve.ThemeAuthor = "Narwin";
            this.sw_th_Valve.ThemeName = "MetroLite";
            this.sw_th_Valve.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.sw_th_Valve.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.sw_th_Valve_SwitchedChanged);
            // 
            // lb_th_vaccum
            // 
            this.lb_th_vaccum.AutoSize = true;
            this.lb_th_vaccum.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_th_vaccum.Location = new System.Drawing.Point(37, 69);
            this.lb_th_vaccum.Name = "lb_th_vaccum";
            this.lb_th_vaccum.Size = new System.Drawing.Size(77, 23);
            this.lb_th_vaccum.TabIndex = 2;
            this.lb_th_vaccum.Text = "Vaccum";
            // 
            // sw_th_Vaccum
            // 
            this.sw_th_Vaccum.BackColor = System.Drawing.Color.Transparent;
            this.sw_th_Vaccum.BackgroundColor = System.Drawing.Color.Empty;
            this.sw_th_Vaccum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.sw_th_Vaccum.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.sw_th_Vaccum.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.sw_th_Vaccum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_th_Vaccum.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.sw_th_Vaccum.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.sw_th_Vaccum.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.sw_th_Vaccum.IsDerivedStyle = true;
            this.sw_th_Vaccum.Location = new System.Drawing.Point(45, 39);
            this.sw_th_Vaccum.Name = "sw_th_Vaccum";
            this.sw_th_Vaccum.Size = new System.Drawing.Size(58, 22);
            this.sw_th_Vaccum.Style = MetroSet_UI.Enums.Style.Light;
            this.sw_th_Vaccum.StyleManager = null;
            this.sw_th_Vaccum.Switched = false;
            this.sw_th_Vaccum.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.sw_th_Vaccum.TabIndex = 1;
            this.sw_th_Vaccum.Text = "metroSetSwitch1";
            this.sw_th_Vaccum.ThemeAuthor = "Narwin";
            this.sw_th_Vaccum.ThemeName = "MetroLite";
            this.sw_th_Vaccum.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.sw_th_Vaccum.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.sw_th_Vaccum_SwitchedChanged);
            // 
            // position_grbox
            // 
            this.position_grbox.BackColor = System.Drawing.Color.Gainsboro;
            this.position_grbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.position_grbox.Controls.Add(this.lb_Pos_Z);
            this.position_grbox.Controls.Add(this.lb_Pos_Y);
            this.position_grbox.Controls.Add(this.lb_Pos_X);
            this.position_grbox.Controls.Add(this.label5);
            this.position_grbox.Controls.Add(this.label4);
            this.position_grbox.Controls.Add(this.label2);
            this.position_grbox.Controls.Add(this.btn_pos_home);
            this.position_grbox.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position_grbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.position_grbox.Location = new System.Drawing.Point(288, 12);
            this.position_grbox.Name = "position_grbox";
            this.position_grbox.Size = new System.Drawing.Size(259, 180);
            this.position_grbox.TabIndex = 7;
            this.position_grbox.TabStop = false;
            this.position_grbox.Text = "Position";
            // 
            // lb_Pos_Z
            // 
            this.lb_Pos_Z.AutoSize = true;
            this.lb_Pos_Z.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pos_Z.Location = new System.Drawing.Point(184, 111);
            this.lb_Pos_Z.Name = "lb_Pos_Z";
            this.lb_Pos_Z.Size = new System.Drawing.Size(42, 28);
            this.lb_Pos_Z.TabIndex = 21;
            this.lb_Pos_Z.Text = "???";
            // 
            // lb_Pos_Y
            // 
            this.lb_Pos_Y.AutoSize = true;
            this.lb_Pos_Y.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pos_Y.Location = new System.Drawing.Point(184, 75);
            this.lb_Pos_Y.Name = "lb_Pos_Y";
            this.lb_Pos_Y.Size = new System.Drawing.Size(42, 28);
            this.lb_Pos_Y.TabIndex = 20;
            this.lb_Pos_Y.Text = "???";
            // 
            // lb_Pos_X
            // 
            this.lb_Pos_X.AutoSize = true;
            this.lb_Pos_X.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pos_X.Location = new System.Drawing.Point(184, 41);
            this.lb_Pos_X.Name = "lb_Pos_X";
            this.lb_Pos_X.Size = new System.Drawing.Size(42, 28);
            this.lb_Pos_X.TabIndex = 19;
            this.lb_Pos_X.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "Z:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "X:";
            // 
            // Conveyor_grbox
            // 
            this.Conveyor_grbox.BackColor = System.Drawing.Color.Gainsboro;
            this.Conveyor_grbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Conveyor_grbox.Controls.Add(this.lb_con_mmps_v);
            this.Conveyor_grbox.Controls.Add(this.lb_con_accSpeed);
            this.Conveyor_grbox.Controls.Add(this.lb_con_Velocity);
            this.Conveyor_grbox.Controls.Add(this.lb_Con_Run);
            this.Conveyor_grbox.Controls.Add(this.lb_con_mmps);
            this.Conveyor_grbox.Controls.Add(this.tbx_con_speed);
            this.Conveyor_grbox.Controls.Add(this.lb_con_Speed);
            this.Conveyor_grbox.Controls.Add(this.sw_con_Run);
            this.Conveyor_grbox.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conveyor_grbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Conveyor_grbox.Location = new System.Drawing.Point(714, 12);
            this.Conveyor_grbox.Name = "Conveyor_grbox";
            this.Conveyor_grbox.Size = new System.Drawing.Size(260, 180);
            this.Conveyor_grbox.TabIndex = 7;
            this.Conveyor_grbox.TabStop = false;
            this.Conveyor_grbox.Text = "Conveyor";
            // 
            // lb_con_mmps_v
            // 
            this.lb_con_mmps_v.AutoSize = true;
            this.lb_con_mmps_v.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_con_mmps_v.Location = new System.Drawing.Point(188, 89);
            this.lb_con_mmps_v.Name = "lb_con_mmps_v";
            this.lb_con_mmps_v.Size = new System.Drawing.Size(63, 23);
            this.lb_con_mmps_v.TabIndex = 17;
            this.lb_con_mmps_v.Text = "mm/s";
            // 
            // lb_con_accSpeed
            // 
            this.lb_con_accSpeed.AutoSize = true;
            this.lb_con_accSpeed.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_con_accSpeed.Location = new System.Drawing.Point(114, 89);
            this.lb_con_accSpeed.Name = "lb_con_accSpeed";
            this.lb_con_accSpeed.Size = new System.Drawing.Size(47, 23);
            this.lb_con_accSpeed.TabIndex = 16;
            this.lb_con_accSpeed.Text = "0.00";
            // 
            // lb_con_Velocity
            // 
            this.lb_con_Velocity.AutoSize = true;
            this.lb_con_Velocity.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_con_Velocity.Location = new System.Drawing.Point(20, 89);
            this.lb_con_Velocity.Name = "lb_con_Velocity";
            this.lb_con_Velocity.Size = new System.Drawing.Size(88, 23);
            this.lb_con_Velocity.TabIndex = 15;
            this.lb_con_Velocity.Text = "Velocity: ";
            // 
            // lb_Con_Run
            // 
            this.lb_Con_Run.AutoSize = true;
            this.lb_Con_Run.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Con_Run.Location = new System.Drawing.Point(20, 44);
            this.lb_Con_Run.Name = "lb_Con_Run";
            this.lb_Con_Run.Size = new System.Drawing.Size(69, 23);
            this.lb_Con_Run.TabIndex = 14;
            this.lb_Con_Run.Text = "Enable";
            // 
            // lb_con_mmps
            // 
            this.lb_con_mmps.AutoSize = true;
            this.lb_con_mmps.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_con_mmps.Location = new System.Drawing.Point(188, 132);
            this.lb_con_mmps.Name = "lb_con_mmps";
            this.lb_con_mmps.Size = new System.Drawing.Size(63, 23);
            this.lb_con_mmps.TabIndex = 13;
            this.lb_con_mmps.Text = "mm/s";
            // 
            // tbx_con_speed
            // 
            this.tbx_con_speed.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_con_speed.Location = new System.Drawing.Point(109, 129);
            this.tbx_con_speed.Name = "tbx_con_speed";
            this.tbx_con_speed.Size = new System.Drawing.Size(73, 27);
            this.tbx_con_speed.TabIndex = 12;
            this.tbx_con_speed.Leave += new System.EventHandler(this.tbx_con_speed_Leave);
            // 
            // lb_con_Speed
            // 
            this.lb_con_Speed.AutoSize = true;
            this.lb_con_Speed.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_con_Speed.Location = new System.Drawing.Point(20, 133);
            this.lb_con_Speed.Name = "lb_con_Speed";
            this.lb_con_Speed.Size = new System.Drawing.Size(83, 23);
            this.lb_con_Speed.TabIndex = 4;
            this.lb_con_Speed.Text = "Setpoint";
            // 
            // sw_con_Run
            // 
            this.sw_con_Run.BackColor = System.Drawing.Color.Transparent;
            this.sw_con_Run.BackgroundColor = System.Drawing.Color.Empty;
            this.sw_con_Run.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.sw_con_Run.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.sw_con_Run.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.sw_con_Run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_con_Run.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.sw_con_Run.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.sw_con_Run.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.sw_con_Run.IsDerivedStyle = true;
            this.sw_con_Run.Location = new System.Drawing.Point(109, 45);
            this.sw_con_Run.Name = "sw_con_Run";
            this.sw_con_Run.Size = new System.Drawing.Size(58, 22);
            this.sw_con_Run.Style = MetroSet_UI.Enums.Style.Light;
            this.sw_con_Run.StyleManager = null;
            this.sw_con_Run.Switched = false;
            this.sw_con_Run.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.sw_con_Run.TabIndex = 3;
            this.sw_con_Run.Text = "metroSetSwitch1";
            this.sw_con_Run.ThemeAuthor = "Narwin";
            this.sw_con_Run.ThemeName = "MetroLite";
            this.sw_con_Run.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.sw_con_Run.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.sw_con_Run_SwitchedChanged);
            // 
            // PLC_grbox
            // 
            this.PLC_grbox.BackColor = System.Drawing.Color.Gainsboro;
            this.PLC_grbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PLC_grbox.Controls.Add(this.pictureBox1);
            this.PLC_grbox.Controls.Add(this.btn_plc_connect);
            this.PLC_grbox.Controls.Add(this.lb_plc_ip);
            this.PLC_grbox.Controls.Add(this.tbx_plc_ip);
            this.PLC_grbox.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLC_grbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PLC_grbox.Location = new System.Drawing.Point(12, 12);
            this.PLC_grbox.Name = "PLC_grbox";
            this.PLC_grbox.Size = new System.Drawing.Size(270, 180);
            this.PLC_grbox.TabIndex = 6;
            this.PLC_grbox.TabStop = false;
            this.PLC_grbox.Text = "Robot connect";
            // 
            // btn_plc_connect
            // 
            this.btn_plc_connect.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plc_connect.Location = new System.Drawing.Point(114, 107);
            this.btn_plc_connect.Name = "btn_plc_connect";
            this.btn_plc_connect.Size = new System.Drawing.Size(125, 45);
            this.btn_plc_connect.TabIndex = 12;
            this.btn_plc_connect.Text = "Connect";
            this.btn_plc_connect.UseVisualStyleBackColor = true;
            this.btn_plc_connect.Click += new System.EventHandler(this.btn_plc_connect_Click);
            // 
            // lb_plc_ip
            // 
            this.lb_plc_ip.AutoSize = true;
            this.lb_plc_ip.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_plc_ip.Location = new System.Drawing.Point(13, 47);
            this.lb_plc_ip.Name = "lb_plc_ip";
            this.lb_plc_ip.Size = new System.Drawing.Size(40, 28);
            this.lb_plc_ip.TabIndex = 11;
            this.lb_plc_ip.Text = "IP:";
            // 
            // tbx_plc_ip
            // 
            this.tbx_plc_ip.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_plc_ip.Location = new System.Drawing.Point(59, 49);
            this.tbx_plc_ip.Name = "tbx_plc_ip";
            this.tbx_plc_ip.Size = new System.Drawing.Size(165, 27);
            this.tbx_plc_ip.TabIndex = 10;
            // 
            // camera_grbox
            // 
            this.camera_grbox.BackColor = System.Drawing.Color.Gainsboro;
            this.camera_grbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.camera_grbox.Controls.Add(this.btn_camsetup);
            this.camera_grbox.Controls.Add(this.link_img_getArea);
            this.camera_grbox.Controls.Add(this.lb_img_area);
            this.camera_grbox.Controls.Add(this.label25);
            this.camera_grbox.Controls.Add(this.sw_img_gray);
            this.camera_grbox.Controls.Add(this.btn_frame_setting);
            this.camera_grbox.Controls.Add(this.label1);
            this.camera_grbox.Controls.Add(this.cbb_Camlist);
            this.camera_grbox.Controls.Add(this.btn_cam_connect);
            this.camera_grbox.Controls.Add(this.imgBox_crop);
            this.camera_grbox.Controls.Add(this.picbox_offCam);
            this.camera_grbox.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camera_grbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.camera_grbox.Location = new System.Drawing.Point(12, 198);
            this.camera_grbox.Name = "camera_grbox";
            this.camera_grbox.Size = new System.Drawing.Size(535, 573);
            this.camera_grbox.TabIndex = 8;
            this.camera_grbox.TabStop = false;
            this.camera_grbox.Text = "Camera";
            // 
            // btn_camsetup
            // 
            this.btn_camsetup.Enabled = false;
            this.btn_camsetup.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_camsetup.Location = new System.Drawing.Point(162, 485);
            this.btn_camsetup.Name = "btn_camsetup";
            this.btn_camsetup.Size = new System.Drawing.Size(150, 40);
            this.btn_camsetup.TabIndex = 66;
            this.btn_camsetup.Text = "Camera Setting";
            this.btn_camsetup.UseVisualStyleBackColor = true;
            this.btn_camsetup.Click += new System.EventHandler(this.btn_camsetup_Click);
            // 
            // link_img_getArea
            // 
            this.link_img_getArea.AutoSize = true;
            this.link_img_getArea.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_img_getArea.Location = new System.Drawing.Point(318, 536);
            this.link_img_getArea.Name = "link_img_getArea";
            this.link_img_getArea.Size = new System.Drawing.Size(83, 23);
            this.link_img_getArea.TabIndex = 65;
            this.link_img_getArea.TabStop = true;
            this.link_img_getArea.Text = "Get Area";
            this.link_img_getArea.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_img_getArea_LinkClicked_1);
            // 
            // lb_img_area
            // 
            this.lb_img_area.AutoSize = true;
            this.lb_img_area.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_img_area.Location = new System.Drawing.Point(407, 536);
            this.lb_img_area.Name = "lb_img_area";
            this.lb_img_area.Size = new System.Drawing.Size(34, 23);
            this.lb_img_area.TabIndex = 64;
            this.lb_img_area.Text = "##";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(318, 492);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(107, 23);
            this.label25.TabIndex = 63;
            this.label25.Text = "Gray Image";
            // 
            // sw_img_gray
            // 
            this.sw_img_gray.BackColor = System.Drawing.Color.Transparent;
            this.sw_img_gray.BackgroundColor = System.Drawing.Color.Empty;
            this.sw_img_gray.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.sw_img_gray.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.sw_img_gray.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.sw_img_gray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_img_gray.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.sw_img_gray.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.sw_img_gray.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.sw_img_gray.IsDerivedStyle = true;
            this.sw_img_gray.Location = new System.Drawing.Point(431, 493);
            this.sw_img_gray.Name = "sw_img_gray";
            this.sw_img_gray.Size = new System.Drawing.Size(58, 22);
            this.sw_img_gray.Style = MetroSet_UI.Enums.Style.Light;
            this.sw_img_gray.StyleManager = null;
            this.sw_img_gray.Switched = false;
            this.sw_img_gray.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.sw_img_gray.TabIndex = 62;
            this.sw_img_gray.Text = "metroSetSwitch1";
            this.sw_img_gray.ThemeAuthor = "Narwin";
            this.sw_img_gray.ThemeName = "MetroLite";
            this.sw_img_gray.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // btn_frame_setting
            // 
            this.btn_frame_setting.Enabled = false;
            this.btn_frame_setting.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_frame_setting.Location = new System.Drawing.Point(6, 485);
            this.btn_frame_setting.Name = "btn_frame_setting";
            this.btn_frame_setting.Size = new System.Drawing.Size(150, 40);
            this.btn_frame_setting.TabIndex = 16;
            this.btn_frame_setting.Text = "Frame Setting";
            this.btn_frame_setting.UseVisualStyleBackColor = true;
            this.btn_frame_setting.Click += new System.EventHandler(this.btn_cam_setting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select camera";
            // 
            // cbb_Camlist
            // 
            this.cbb_Camlist.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Camlist.FormattingEnabled = true;
            this.cbb_Camlist.Location = new System.Drawing.Point(141, 40);
            this.cbb_Camlist.Name = "cbb_Camlist";
            this.cbb_Camlist.Size = new System.Drawing.Size(220, 28);
            this.cbb_Camlist.TabIndex = 14;
            this.cbb_Camlist.DropDown += new System.EventHandler(this.cbb_Camlist_DropDown);
            this.cbb_Camlist.SelectedIndexChanged += new System.EventHandler(this.cbb_Camlist_SelectedIndexChanged);
            // 
            // btn_cam_connect
            // 
            this.btn_cam_connect.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cam_connect.Location = new System.Drawing.Point(367, 33);
            this.btn_cam_connect.Name = "btn_cam_connect";
            this.btn_cam_connect.Size = new System.Drawing.Size(123, 40);
            this.btn_cam_connect.TabIndex = 13;
            this.btn_cam_connect.Text = "Connect";
            this.btn_cam_connect.UseVisualStyleBackColor = true;
            this.btn_cam_connect.Click += new System.EventHandler(this.btn_cam_connect_Click);
            // 
            // cyclicRead
            // 
            this.cyclicRead.Interval = 500;
            this.cyclicRead.Tick += new System.EventHandler(this.cyclicRead_Tick);
            // 
            // btn_mov_Ymin
            // 
            this.btn_mov_Ymin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mov_Ymin.Location = new System.Drawing.Point(93, 86);
            this.btn_mov_Ymin.Name = "btn_mov_Ymin";
            this.btn_mov_Ymin.Size = new System.Drawing.Size(68, 35);
            this.btn_mov_Ymin.TabIndex = 0;
            this.btn_mov_Ymin.Text = "Y-";
            this.btn_mov_Ymin.UseVisualStyleBackColor = true;
            this.btn_mov_Ymin.Click += new System.EventHandler(this.btn_mov_Ymin_Click);
            // 
            // btn_mov_Yplus
            // 
            this.btn_mov_Yplus.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mov_Yplus.Location = new System.Drawing.Point(93, 35);
            this.btn_mov_Yplus.Name = "btn_mov_Yplus";
            this.btn_mov_Yplus.Size = new System.Drawing.Size(68, 35);
            this.btn_mov_Yplus.TabIndex = 1;
            this.btn_mov_Yplus.Text = "Y+";
            this.btn_mov_Yplus.UseVisualStyleBackColor = true;
            this.btn_mov_Yplus.Click += new System.EventHandler(this.btn_mov_Yplus_Click);
            // 
            // btn_mov_Xplus
            // 
            this.btn_mov_Xplus.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mov_Xplus.Location = new System.Drawing.Point(19, 35);
            this.btn_mov_Xplus.Name = "btn_mov_Xplus";
            this.btn_mov_Xplus.Size = new System.Drawing.Size(68, 35);
            this.btn_mov_Xplus.TabIndex = 2;
            this.btn_mov_Xplus.Text = "X+";
            this.btn_mov_Xplus.UseVisualStyleBackColor = true;
            this.btn_mov_Xplus.Click += new System.EventHandler(this.btn_mov_Xplus_Click);
            // 
            // btn_mov_Xmin
            // 
            this.btn_mov_Xmin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mov_Xmin.Location = new System.Drawing.Point(19, 86);
            this.btn_mov_Xmin.Name = "btn_mov_Xmin";
            this.btn_mov_Xmin.Size = new System.Drawing.Size(68, 35);
            this.btn_mov_Xmin.TabIndex = 3;
            this.btn_mov_Xmin.Text = "X-";
            this.btn_mov_Xmin.UseVisualStyleBackColor = true;
            this.btn_mov_Xmin.Click += new System.EventHandler(this.btn_mov_Xmin_Click);
            // 
            // btn_mov_Zmin
            // 
            this.btn_mov_Zmin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mov_Zmin.Location = new System.Drawing.Point(167, 86);
            this.btn_mov_Zmin.Name = "btn_mov_Zmin";
            this.btn_mov_Zmin.Size = new System.Drawing.Size(68, 35);
            this.btn_mov_Zmin.TabIndex = 4;
            this.btn_mov_Zmin.Text = "Z-";
            this.btn_mov_Zmin.UseVisualStyleBackColor = true;
            this.btn_mov_Zmin.Click += new System.EventHandler(this.btn_mov_Zmin_Click);
            // 
            // btn_mov_Zplus
            // 
            this.btn_mov_Zplus.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mov_Zplus.Location = new System.Drawing.Point(167, 35);
            this.btn_mov_Zplus.Name = "btn_mov_Zplus";
            this.btn_mov_Zplus.Size = new System.Drawing.Size(68, 35);
            this.btn_mov_Zplus.TabIndex = 5;
            this.btn_mov_Zplus.Text = "Z+";
            this.btn_mov_Zplus.UseVisualStyleBackColor = true;
            this.btn_mov_Zplus.Click += new System.EventHandler(this.btn_mov_Zplus_Click);
            // 
            // lb_mov_division
            // 
            this.lb_mov_division.AutoSize = true;
            this.lb_mov_division.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mov_division.Location = new System.Drawing.Point(241, 39);
            this.lb_mov_division.Name = "lb_mov_division";
            this.lb_mov_division.Size = new System.Drawing.Size(82, 23);
            this.lb_mov_division.TabIndex = 19;
            this.lb_mov_division.Text = "Division";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "mm";
            // 
            // tbx_mov_division
            // 
            this.tbx_mov_division.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_mov_division.Location = new System.Drawing.Point(329, 36);
            this.tbx_mov_division.Name = "tbx_mov_division";
            this.tbx_mov_division.Size = new System.Drawing.Size(78, 27);
            this.tbx_mov_division.TabIndex = 21;
            this.tbx_mov_division.Leave += new System.EventHandler(this.tbx_mov_division_Leave);
            // 
            // movement_grbox
            // 
            this.movement_grbox.BackColor = System.Drawing.Color.Gainsboro;
            this.movement_grbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.movement_grbox.Controls.Add(this.lb_mov_mmps);
            this.movement_grbox.Controls.Add(this.lb_mov_velocity);
            this.movement_grbox.Controls.Add(this.tbx_mov_velocity);
            this.movement_grbox.Controls.Add(this.btn_Mov_Move);
            this.movement_grbox.Controls.Add(this.label6);
            this.movement_grbox.Controls.Add(this.label7);
            this.movement_grbox.Controls.Add(this.label8);
            this.movement_grbox.Controls.Add(this.tbx_mov_Z);
            this.movement_grbox.Controls.Add(this.tbx_mov_Y);
            this.movement_grbox.Controls.Add(this.tbx_mov_X);
            this.movement_grbox.Controls.Add(this.tbx_mov_division);
            this.movement_grbox.Controls.Add(this.label3);
            this.movement_grbox.Controls.Add(this.lb_mov_division);
            this.movement_grbox.Controls.Add(this.btn_mov_Zplus);
            this.movement_grbox.Controls.Add(this.btn_mov_Zmin);
            this.movement_grbox.Controls.Add(this.btn_mov_Xmin);
            this.movement_grbox.Controls.Add(this.btn_mov_Xplus);
            this.movement_grbox.Controls.Add(this.btn_mov_Yplus);
            this.movement_grbox.Controls.Add(this.btn_mov_Ymin);
            this.movement_grbox.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movement_grbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.movement_grbox.Location = new System.Drawing.Point(980, 12);
            this.movement_grbox.Name = "movement_grbox";
            this.movement_grbox.Size = new System.Drawing.Size(540, 180);
            this.movement_grbox.TabIndex = 4;
            this.movement_grbox.TabStop = false;
            this.movement_grbox.Text = "Movement";
            // 
            // lb_mov_mmps
            // 
            this.lb_mov_mmps.AutoSize = true;
            this.lb_mov_mmps.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mov_mmps.Location = new System.Drawing.Point(413, 94);
            this.lb_mov_mmps.Name = "lb_mov_mmps";
            this.lb_mov_mmps.Size = new System.Drawing.Size(63, 23);
            this.lb_mov_mmps.TabIndex = 35;
            this.lb_mov_mmps.Text = "mm/s";
            // 
            // lb_mov_velocity
            // 
            this.lb_mov_velocity.AutoSize = true;
            this.lb_mov_velocity.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mov_velocity.Location = new System.Drawing.Point(244, 94);
            this.lb_mov_velocity.Name = "lb_mov_velocity";
            this.lb_mov_velocity.Size = new System.Drawing.Size(79, 23);
            this.lb_mov_velocity.TabIndex = 34;
            this.lb_mov_velocity.Text = "Velocity";
            // 
            // tbx_mov_velocity
            // 
            this.tbx_mov_velocity.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_mov_velocity.Location = new System.Drawing.Point(329, 92);
            this.tbx_mov_velocity.Name = "tbx_mov_velocity";
            this.tbx_mov_velocity.Size = new System.Drawing.Size(78, 27);
            this.tbx_mov_velocity.TabIndex = 33;
            this.tbx_mov_velocity.Leave += new System.EventHandler(this.tbx_mov_velocity_Leave);
            // 
            // btn_Mov_Move
            // 
            this.btn_Mov_Move.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mov_Move.Location = new System.Drawing.Point(411, 132);
            this.btn_Mov_Move.Name = "btn_Mov_Move";
            this.btn_Mov_Move.Size = new System.Drawing.Size(123, 40);
            this.btn_Mov_Move.TabIndex = 32;
            this.btn_Mov_Move.Text = "Move";
            this.btn_Mov_Move.UseVisualStyleBackColor = true;
            this.btn_Mov_Move.Click += new System.EventHandler(this.btn_Mov_Move_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 28);
            this.label6.TabIndex = 31;
            this.label6.Text = "Z:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(151, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 28);
            this.label7.TabIndex = 30;
            this.label7.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 28);
            this.label8.TabIndex = 29;
            this.label8.Text = "X:";
            // 
            // tbx_mov_Z
            // 
            this.tbx_mov_Z.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_mov_Z.Location = new System.Drawing.Point(314, 140);
            this.tbx_mov_Z.Name = "tbx_mov_Z";
            this.tbx_mov_Z.Size = new System.Drawing.Size(60, 27);
            this.tbx_mov_Z.TabIndex = 28;
            // 
            // tbx_mov_Y
            // 
            this.tbx_mov_Y.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_mov_Y.Location = new System.Drawing.Point(188, 140);
            this.tbx_mov_Y.Name = "tbx_mov_Y";
            this.tbx_mov_Y.Size = new System.Drawing.Size(60, 27);
            this.tbx_mov_Y.TabIndex = 27;
            // 
            // tbx_mov_X
            // 
            this.tbx_mov_X.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_mov_X.Location = new System.Drawing.Point(56, 140);
            this.tbx_mov_X.Name = "tbx_mov_X";
            this.tbx_mov_X.Size = new System.Drawing.Size(60, 27);
            this.tbx_mov_X.TabIndex = 26;
            // 
            // imageProcess_grbox
            // 
            this.imageProcess_grbox.BackColor = System.Drawing.Color.Gainsboro;
            this.imageProcess_grbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageProcess_grbox.Controls.Add(this.link_img_LB_color);
            this.imageProcess_grbox.Controls.Add(this.label22);
            this.imageProcess_grbox.Controls.Add(this.label21);
            this.imageProcess_grbox.Controls.Add(this.tbx_img_Area_min);
            this.imageProcess_grbox.Controls.Add(this.tbx_img_Area_max);
            this.imageProcess_grbox.Controls.Add(this.cbx_img_shape);
            this.imageProcess_grbox.Controls.Add(this.label20);
            this.imageProcess_grbox.Controls.Add(this.label18);
            this.imageProcess_grbox.Controls.Add(this.num_img_set);
            this.imageProcess_grbox.Controls.Add(this.tbx_img_Name);
            this.imageProcess_grbox.Controls.Add(this.label17);
            this.imageProcess_grbox.Controls.Add(this.label14);
            this.imageProcess_grbox.Controls.Add(this.label15);
            this.imageProcess_grbox.Controls.Add(this.lb_img_valMin);
            this.imageProcess_grbox.Controls.Add(this.lb_img_valMax);
            this.imageProcess_grbox.Controls.Add(this.scbar_ValMin);
            this.imageProcess_grbox.Controls.Add(this.label19);
            this.imageProcess_grbox.Controls.Add(this.scbar_ValMax);
            this.imageProcess_grbox.Controls.Add(this.label12);
            this.imageProcess_grbox.Controls.Add(this.label13);
            this.imageProcess_grbox.Controls.Add(this.lb_img_satMin);
            this.imageProcess_grbox.Controls.Add(this.lb_img_satMax);
            this.imageProcess_grbox.Controls.Add(this.scbar_SatMin);
            this.imageProcess_grbox.Controls.Add(this.label16);
            this.imageProcess_grbox.Controls.Add(this.scbar_SatMax);
            this.imageProcess_grbox.Controls.Add(this.label11);
            this.imageProcess_grbox.Controls.Add(this.label10);
            this.imageProcess_grbox.Controls.Add(this.lb_img_hueMin);
            this.imageProcess_grbox.Controls.Add(this.lb_img_hueMax);
            this.imageProcess_grbox.Controls.Add(this.scbar_HueMin);
            this.imageProcess_grbox.Controls.Add(this.label9);
            this.imageProcess_grbox.Controls.Add(this.scbar_HueMax);
            this.imageProcess_grbox.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageProcess_grbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imageProcess_grbox.Location = new System.Drawing.Point(553, 198);
            this.imageProcess_grbox.Name = "imageProcess_grbox";
            this.imageProcess_grbox.Size = new System.Drawing.Size(360, 573);
            this.imageProcess_grbox.TabIndex = 36;
            this.imageProcess_grbox.TabStop = false;
            this.imageProcess_grbox.Text = "Image";
            // 
            // link_img_LB_color
            // 
            this.link_img_LB_color.AutoSize = true;
            this.link_img_LB_color.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_img_LB_color.Location = new System.Drawing.Point(245, 103);
            this.link_img_LB_color.Name = "link_img_LB_color";
            this.link_img_LB_color.Size = new System.Drawing.Size(83, 23);
            this.link_img_LB_color.TabIndex = 66;
            this.link_img_LB_color.TabStop = true;
            this.link_img_LB_color.Text = "LB Color";
            this.link_img_LB_color.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_img_LB_color_LinkClicked);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(182, 152);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 23);
            this.label22.TabIndex = 60;
            this.label22.Text = "Area min";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(8, 152);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 23);
            this.label21.TabIndex = 59;
            this.label21.Text = "Area max";
            // 
            // tbx_img_Area_min
            // 
            this.tbx_img_Area_min.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_img_Area_min.Location = new System.Drawing.Point(276, 148);
            this.tbx_img_Area_min.Name = "tbx_img_Area_min";
            this.tbx_img_Area_min.Size = new System.Drawing.Size(70, 27);
            this.tbx_img_Area_min.TabIndex = 58;
            this.tbx_img_Area_min.Leave += new System.EventHandler(this.tbx_img_Area_min_Leave);
            // 
            // tbx_img_Area_max
            // 
            this.tbx_img_Area_max.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_img_Area_max.Location = new System.Drawing.Point(105, 148);
            this.tbx_img_Area_max.Name = "tbx_img_Area_max";
            this.tbx_img_Area_max.Size = new System.Drawing.Size(70, 27);
            this.tbx_img_Area_max.TabIndex = 57;
            this.tbx_img_Area_max.Leave += new System.EventHandler(this.tbx_img_Area_max_Leave);
            // 
            // cbx_img_shape
            // 
            this.cbx_img_shape.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_img_shape.FormattingEnabled = true;
            this.cbx_img_shape.Items.AddRange(new object[] {
            "Circle",
            "Triangle",
            "Rectangle"});
            this.cbx_img_shape.Location = new System.Drawing.Point(92, 98);
            this.cbx_img_shape.Name = "cbx_img_shape";
            this.cbx_img_shape.Size = new System.Drawing.Size(121, 28);
            this.cbx_img_shape.TabIndex = 56;
            this.cbx_img_shape.SelectedIndexChanged += new System.EventHandler(this.cbx_img_shape_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(15, 103);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 23);
            this.label20.TabIndex = 55;
            this.label20.Text = "Shapes";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(15, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 23);
            this.label18.TabIndex = 53;
            this.label18.Text = "Type";
            // 
            // num_img_set
            // 
            this.num_img_set.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_img_set.Location = new System.Drawing.Point(69, 39);
            this.num_img_set.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.num_img_set.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_img_set.Name = "num_img_set";
            this.num_img_set.Size = new System.Drawing.Size(37, 31);
            this.num_img_set.TabIndex = 52;
            this.num_img_set.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_img_set.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tbx_img_Name
            // 
            this.tbx_img_Name.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_img_Name.Location = new System.Drawing.Point(190, 41);
            this.tbx_img_Name.Name = "tbx_img_Name";
            this.tbx_img_Name.Size = new System.Drawing.Size(116, 27);
            this.tbx_img_Name.TabIndex = 51;
            this.tbx_img_Name.TextChanged += new System.EventHandler(this.tbx_img_Name_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(125, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 23);
            this.label17.TabIndex = 50;
            this.label17.Text = "Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 533);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 23);
            this.label14.TabIndex = 49;
            this.label14.Text = "Min";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 489);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 23);
            this.label15.TabIndex = 48;
            this.label15.Text = "Max";
            // 
            // lb_img_valMin
            // 
            this.lb_img_valMin.AutoSize = true;
            this.lb_img_valMin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_img_valMin.Location = new System.Drawing.Point(286, 533);
            this.lb_img_valMin.Name = "lb_img_valMin";
            this.lb_img_valMin.Size = new System.Drawing.Size(55, 23);
            this.lb_img_valMin.TabIndex = 47;
            this.lb_img_valMin.Text = "Vmin";
            // 
            // lb_img_valMax
            // 
            this.lb_img_valMax.AutoSize = true;
            this.lb_img_valMax.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_img_valMax.Location = new System.Drawing.Point(286, 489);
            this.lb_img_valMax.Name = "lb_img_valMax";
            this.lb_img_valMax.Size = new System.Drawing.Size(58, 23);
            this.lb_img_valMax.TabIndex = 46;
            this.lb_img_valMax.Text = "Vmax";
            // 
            // scbar_ValMin
            // 
            this.scbar_ValMin.LargeChange = 1;
            this.scbar_ValMin.Location = new System.Drawing.Point(63, 536);
            this.scbar_ValMin.Maximum = 255;
            this.scbar_ValMin.Name = "scbar_ValMin";
            this.scbar_ValMin.Size = new System.Drawing.Size(220, 20);
            this.scbar_ValMin.TabIndex = 45;
            this.scbar_ValMin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scbar_ValMin_Scroll);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 445);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 28);
            this.label19.TabIndex = 44;
            this.label19.Text = "Value";
            // 
            // scbar_ValMax
            // 
            this.scbar_ValMax.LargeChange = 1;
            this.scbar_ValMax.Location = new System.Drawing.Point(63, 492);
            this.scbar_ValMax.Maximum = 255;
            this.scbar_ValMax.Minimum = 1;
            this.scbar_ValMax.Name = "scbar_ValMax";
            this.scbar_ValMax.Size = new System.Drawing.Size(220, 20);
            this.scbar_ValMax.TabIndex = 43;
            this.scbar_ValMax.Value = 1;
            this.scbar_ValMax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scbar_ValMax_Scroll);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 406);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 23);
            this.label12.TabIndex = 42;
            this.label12.Text = "Min";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 362);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 23);
            this.label13.TabIndex = 41;
            this.label13.Text = "Max";
            // 
            // lb_img_satMin
            // 
            this.lb_img_satMin.AutoSize = true;
            this.lb_img_satMin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_img_satMin.Location = new System.Drawing.Point(286, 406);
            this.lb_img_satMin.Name = "lb_img_satMin";
            this.lb_img_satMin.Size = new System.Drawing.Size(54, 23);
            this.lb_img_satMin.TabIndex = 40;
            this.lb_img_satMin.Text = "Smin";
            // 
            // lb_img_satMax
            // 
            this.lb_img_satMax.AutoSize = true;
            this.lb_img_satMax.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_img_satMax.Location = new System.Drawing.Point(286, 362);
            this.lb_img_satMax.Name = "lb_img_satMax";
            this.lb_img_satMax.Size = new System.Drawing.Size(57, 23);
            this.lb_img_satMax.TabIndex = 39;
            this.lb_img_satMax.Text = "Smax";
            // 
            // scbar_SatMin
            // 
            this.scbar_SatMin.LargeChange = 1;
            this.scbar_SatMin.Location = new System.Drawing.Point(63, 409);
            this.scbar_SatMin.Maximum = 255;
            this.scbar_SatMin.Name = "scbar_SatMin";
            this.scbar_SatMin.Size = new System.Drawing.Size(220, 20);
            this.scbar_SatMin.TabIndex = 38;
            this.scbar_SatMin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scbar_SatMin_Scroll);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 318);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 28);
            this.label16.TabIndex = 37;
            this.label16.Text = "Saturation";
            // 
            // scbar_SatMax
            // 
            this.scbar_SatMax.LargeChange = 1;
            this.scbar_SatMax.Location = new System.Drawing.Point(63, 365);
            this.scbar_SatMax.Maximum = 255;
            this.scbar_SatMax.Minimum = 1;
            this.scbar_SatMax.Name = "scbar_SatMax";
            this.scbar_SatMax.Size = new System.Drawing.Size(220, 20);
            this.scbar_SatMax.TabIndex = 36;
            this.scbar_SatMax.Value = 1;
            this.scbar_SatMax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scbar_SatMax_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 23);
            this.label11.TabIndex = 35;
            this.label11.Text = "Min";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 23);
            this.label10.TabIndex = 34;
            this.label10.Text = "Max";
            // 
            // lb_img_hueMin
            // 
            this.lb_img_hueMin.AutoSize = true;
            this.lb_img_hueMin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_img_hueMin.Location = new System.Drawing.Point(286, 277);
            this.lb_img_hueMin.Name = "lb_img_hueMin";
            this.lb_img_hueMin.Size = new System.Drawing.Size(58, 23);
            this.lb_img_hueMin.TabIndex = 33;
            this.lb_img_hueMin.Text = "Hmin";
            // 
            // lb_img_hueMax
            // 
            this.lb_img_hueMax.AutoSize = true;
            this.lb_img_hueMax.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_img_hueMax.Location = new System.Drawing.Point(286, 233);
            this.lb_img_hueMax.Name = "lb_img_hueMax";
            this.lb_img_hueMax.Size = new System.Drawing.Size(61, 23);
            this.lb_img_hueMax.TabIndex = 32;
            this.lb_img_hueMax.Text = "Hmax";
            // 
            // scbar_HueMin
            // 
            this.scbar_HueMin.LargeChange = 1;
            this.scbar_HueMin.Location = new System.Drawing.Point(63, 280);
            this.scbar_HueMin.Maximum = 255;
            this.scbar_HueMin.Name = "scbar_HueMin";
            this.scbar_HueMin.Size = new System.Drawing.Size(220, 20);
            this.scbar_HueMin.TabIndex = 31;
            this.scbar_HueMin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scbar_HueMin_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 28);
            this.label9.TabIndex = 30;
            this.label9.Text = "Hue";
            // 
            // scbar_HueMax
            // 
            this.scbar_HueMax.LargeChange = 1;
            this.scbar_HueMax.Location = new System.Drawing.Point(63, 236);
            this.scbar_HueMax.Maximum = 255;
            this.scbar_HueMax.Minimum = 1;
            this.scbar_HueMax.Name = "scbar_HueMax";
            this.scbar_HueMax.Size = new System.Drawing.Size(220, 20);
            this.scbar_HueMax.TabIndex = 0;
            this.scbar_HueMax.Value = 1;
            this.scbar_HueMax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scbar_HueMax_Scroll);
            // 
            // tbx_auto_TL_X
            // 
            this.tbx_auto_TL_X.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_auto_TL_X.Location = new System.Drawing.Point(204, 46);
            this.tbx_auto_TL_X.Name = "tbx_auto_TL_X";
            this.tbx_auto_TL_X.Size = new System.Drawing.Size(60, 27);
            this.tbx_auto_TL_X.TabIndex = 59;
            this.tbx_auto_TL_X.Leave += new System.EventHandler(this.tbx_auto_TL_X_Leave);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(15, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(183, 23);
            this.label24.TabIndex = 61;
            this.label24.Text = "Camera coordinates";
            // 
            // tbx_auto_TL_Y
            // 
            this.tbx_auto_TL_Y.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_auto_TL_Y.Location = new System.Drawing.Point(293, 46);
            this.tbx_auto_TL_Y.Name = "tbx_auto_TL_Y";
            this.tbx_auto_TL_Y.Size = new System.Drawing.Size(60, 27);
            this.tbx_auto_TL_Y.TabIndex = 63;
            this.tbx_auto_TL_Y.Leave += new System.EventHandler(this.tbx_auto_TL_Y_Leave);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(270, 48);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(17, 23);
            this.label26.TabIndex = 64;
            this.label26.Text = "-";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(19, 89);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(127, 23);
            this.label28.TabIndex = 66;
            this.label28.Text = "Offset (X-Y-Z )";
            // 
            // tbx_auto_offsetX
            // 
            this.tbx_auto_offsetX.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_auto_offsetX.Location = new System.Drawing.Point(162, 85);
            this.tbx_auto_offsetX.Name = "tbx_auto_offsetX";
            this.tbx_auto_offsetX.Size = new System.Drawing.Size(60, 27);
            this.tbx_auto_offsetX.TabIndex = 67;
            this.tbx_auto_offsetX.Leave += new System.EventHandler(this.tbx_auto_offsetX_Leave);
            // 
            // tbx_auto_offsetY
            // 
            this.tbx_auto_offsetY.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_auto_offsetY.Location = new System.Drawing.Point(251, 85);
            this.tbx_auto_offsetY.Name = "tbx_auto_offsetY";
            this.tbx_auto_offsetY.Size = new System.Drawing.Size(60, 27);
            this.tbx_auto_offsetY.TabIndex = 68;
            this.tbx_auto_offsetY.Leave += new System.EventHandler(this.tbx_auto_offsetY_Leave);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(228, 87);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(17, 23);
            this.label29.TabIndex = 69;
            this.label29.Text = "-";
            // 
            // tbx_auto_offsetZ
            // 
            this.tbx_auto_offsetZ.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_auto_offsetZ.Location = new System.Drawing.Point(337, 85);
            this.tbx_auto_offsetZ.Name = "tbx_auto_offsetZ";
            this.tbx_auto_offsetZ.Size = new System.Drawing.Size(60, 27);
            this.tbx_auto_offsetZ.TabIndex = 70;
            this.tbx_auto_offsetZ.Leave += new System.EventHandler(this.tbx_auto_offsetZ_Leave);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(317, 87);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(17, 23);
            this.label30.TabIndex = 71;
            this.label30.Text = "-";
            // 
            // btn_auto_OnOff
            // 
            this.btn_auto_OnOff.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_auto_OnOff.Location = new System.Drawing.Point(446, 14);
            this.btn_auto_OnOff.Name = "btn_auto_OnOff";
            this.btn_auto_OnOff.Size = new System.Drawing.Size(125, 68);
            this.btn_auto_OnOff.TabIndex = 72;
            this.btn_auto_OnOff.Text = "Connect";
            this.btn_auto_OnOff.UseVisualStyleBackColor = true;
            this.btn_auto_OnOff.Click += new System.EventHandler(this.btn_auto_OnOff_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(19, 130);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(138, 23);
            this.label23.TabIndex = 73;
            this.label23.Text = "Z Pick distance";
            // 
            // tbx_auto_ZPick
            // 
            this.tbx_auto_ZPick.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_auto_ZPick.Location = new System.Drawing.Point(163, 126);
            this.tbx_auto_ZPick.Name = "tbx_auto_ZPick";
            this.tbx_auto_ZPick.Size = new System.Drawing.Size(60, 27);
            this.tbx_auto_ZPick.TabIndex = 74;
            this.tbx_auto_ZPick.Leave += new System.EventHandler(this.tbx_auto_ZPick_Leave);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(245, 128);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(147, 23);
            this.label45.TabIndex = 75;
            this.label45.Text = "Z Place distance";
            // 
            // tbx_auto_ZPlace
            // 
            this.tbx_auto_ZPlace.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_auto_ZPlace.Location = new System.Drawing.Point(398, 126);
            this.tbx_auto_ZPlace.Name = "tbx_auto_ZPlace";
            this.tbx_auto_ZPlace.Size = new System.Drawing.Size(60, 27);
            this.tbx_auto_ZPlace.TabIndex = 76;
            this.tbx_auto_ZPlace.Leave += new System.EventHandler(this.tbx_auto_ZPlace_Leave);
            // 
            // tbx_typ1_coor_x
            // 
            this.tbx_typ1_coor_x.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_typ1_coor_x.Location = new System.Drawing.Point(163, 167);
            this.tbx_typ1_coor_x.Name = "tbx_typ1_coor_x";
            this.tbx_typ1_coor_x.Size = new System.Drawing.Size(60, 27);
            this.tbx_typ1_coor_x.TabIndex = 79;
            this.tbx_typ1_coor_x.Leave += new System.EventHandler(this.tbx_typ1_coor_x_Leave);
            // 
            // tbx_typ1_coor_y
            // 
            this.tbx_typ1_coor_y.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_typ1_coor_y.Location = new System.Drawing.Point(252, 167);
            this.tbx_typ1_coor_y.Name = "tbx_typ1_coor_y";
            this.tbx_typ1_coor_y.Size = new System.Drawing.Size(60, 27);
            this.tbx_typ1_coor_y.TabIndex = 80;
            this.tbx_typ1_coor_y.Leave += new System.EventHandler(this.tbx_typ1_coor_y_Leave);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(229, 169);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(17, 23);
            this.label44.TabIndex = 81;
            this.label44.Text = "-";
            // 
            // tbx_typ1_coor_z
            // 
            this.tbx_typ1_coor_z.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_typ1_coor_z.Location = new System.Drawing.Point(341, 167);
            this.tbx_typ1_coor_z.Name = "tbx_typ1_coor_z";
            this.tbx_typ1_coor_z.Size = new System.Drawing.Size(60, 27);
            this.tbx_typ1_coor_z.TabIndex = 82;
            this.tbx_typ1_coor_z.Leave += new System.EventHandler(this.tbx_typ1_coor_z_Leave);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(318, 169);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(17, 23);
            this.label43.TabIndex = 83;
            this.label43.Text = "-";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(19, 171);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(112, 23);
            this.label42.TabIndex = 84;
            this.label42.Text = "Place type 1";
            // 
            // tbx_typ2_coor_x
            // 
            this.tbx_typ2_coor_x.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_typ2_coor_x.Location = new System.Drawing.Point(163, 208);
            this.tbx_typ2_coor_x.Name = "tbx_typ2_coor_x";
            this.tbx_typ2_coor_x.Size = new System.Drawing.Size(60, 27);
            this.tbx_typ2_coor_x.TabIndex = 85;
            this.tbx_typ2_coor_x.Leave += new System.EventHandler(this.tbx_typ2_coor_x_Leave);
            // 
            // tbx_typ2_coor_y
            // 
            this.tbx_typ2_coor_y.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_typ2_coor_y.Location = new System.Drawing.Point(252, 208);
            this.tbx_typ2_coor_y.Name = "tbx_typ2_coor_y";
            this.tbx_typ2_coor_y.Size = new System.Drawing.Size(60, 27);
            this.tbx_typ2_coor_y.TabIndex = 86;
            this.tbx_typ2_coor_y.Leave += new System.EventHandler(this.tbx_typ2_coor_y_Leave);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(229, 210);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(17, 23);
            this.label34.TabIndex = 87;
            this.label34.Text = "-";
            // 
            // tbx_typ2_coor_z
            // 
            this.tbx_typ2_coor_z.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_typ2_coor_z.Location = new System.Drawing.Point(341, 208);
            this.tbx_typ2_coor_z.Name = "tbx_typ2_coor_z";
            this.tbx_typ2_coor_z.Size = new System.Drawing.Size(60, 27);
            this.tbx_typ2_coor_z.TabIndex = 88;
            this.tbx_typ2_coor_z.Leave += new System.EventHandler(this.tbx_typ2_coor_z_Leave);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(318, 210);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(17, 23);
            this.label33.TabIndex = 89;
            this.label33.Text = "-";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(19, 212);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(112, 23);
            this.label32.TabIndex = 90;
            this.label32.Text = "Place type 2";
            // 
            // tbx_typ3_coor_x
            // 
            this.tbx_typ3_coor_x.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_typ3_coor_x.Location = new System.Drawing.Point(163, 249);
            this.tbx_typ3_coor_x.Name = "tbx_typ3_coor_x";
            this.tbx_typ3_coor_x.Size = new System.Drawing.Size(60, 27);
            this.tbx_typ3_coor_x.TabIndex = 91;
            this.tbx_typ3_coor_x.Leave += new System.EventHandler(this.tbx_typ3_coor_x_Leave);
            // 
            // tbx_typ3_coor_y
            // 
            this.tbx_typ3_coor_y.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_typ3_coor_y.Location = new System.Drawing.Point(252, 249);
            this.tbx_typ3_coor_y.Name = "tbx_typ3_coor_y";
            this.tbx_typ3_coor_y.Size = new System.Drawing.Size(60, 27);
            this.tbx_typ3_coor_y.TabIndex = 92;
            this.tbx_typ3_coor_y.Leave += new System.EventHandler(this.tbx_typ3_coor_y_Leave);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(229, 251);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(17, 23);
            this.label40.TabIndex = 93;
            this.label40.Text = "-";
            // 
            // tbx_typ3_coor_z
            // 
            this.tbx_typ3_coor_z.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_typ3_coor_z.Location = new System.Drawing.Point(341, 249);
            this.tbx_typ3_coor_z.Name = "tbx_typ3_coor_z";
            this.tbx_typ3_coor_z.Size = new System.Drawing.Size(60, 27);
            this.tbx_typ3_coor_z.TabIndex = 94;
            this.tbx_typ3_coor_z.Leave += new System.EventHandler(this.tbx_typ3_coor_z_Leave);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(318, 251);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(17, 23);
            this.label39.TabIndex = 95;
            this.label39.Text = "-";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(19, 253);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(112, 23);
            this.label38.TabIndex = 96;
            this.label38.Text = "Place type 3";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btn_objQueueView);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.tbx_y_limit_low);
            this.groupBox1.Controls.Add(this.label46);
            this.groupBox1.Controls.Add(this.tbx_y_limit_high);
            this.groupBox1.Controls.Add(this.label38);
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Controls.Add(this.tbx_typ3_coor_z);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Controls.Add(this.tbx_typ3_coor_y);
            this.groupBox1.Controls.Add(this.tbx_typ3_coor_x);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.tbx_typ2_coor_z);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.tbx_typ2_coor_y);
            this.groupBox1.Controls.Add(this.tbx_typ2_coor_x);
            this.groupBox1.Controls.Add(this.label42);
            this.groupBox1.Controls.Add(this.label43);
            this.groupBox1.Controls.Add(this.tbx_typ1_coor_z);
            this.groupBox1.Controls.Add(this.label44);
            this.groupBox1.Controls.Add(this.tbx_typ1_coor_y);
            this.groupBox1.Controls.Add(this.tbx_typ1_coor_x);
            this.groupBox1.Controls.Add(this.tbx_auto_ZPlace);
            this.groupBox1.Controls.Add(this.label45);
            this.groupBox1.Controls.Add(this.tbx_auto_ZPick);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.btn_auto_OnOff);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.tbx_auto_offsetZ);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.tbx_auto_offsetY);
            this.groupBox1.Controls.Add(this.tbx_auto_offsetX);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.tbx_auto_TL_Y);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.tbx_auto_TL_X);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(919, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 432);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto Mode Parameter";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(229, 290);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(17, 23);
            this.label27.TabIndex = 106;
            this.label27.Text = "-";
            // 
            // tbx_y_limit_low
            // 
            this.tbx_y_limit_low.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_y_limit_low.Location = new System.Drawing.Point(252, 286);
            this.tbx_y_limit_low.Name = "tbx_y_limit_low";
            this.tbx_y_limit_low.Size = new System.Drawing.Size(60, 27);
            this.tbx_y_limit_low.TabIndex = 105;
            this.tbx_y_limit_low.Leave += new System.EventHandler(this.tbx_y_limit_low_Leave);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(19, 291);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(106, 23);
            this.label46.TabIndex = 104;
            this.label46.Text = "Y pick limit";
            // 
            // tbx_y_limit_high
            // 
            this.tbx_y_limit_high.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_y_limit_high.Location = new System.Drawing.Point(163, 286);
            this.tbx_y_limit_high.Name = "tbx_y_limit_high";
            this.tbx_y_limit_high.Size = new System.Drawing.Size(60, 27);
            this.tbx_y_limit_high.TabIndex = 103;
            this.tbx_y_limit_high.Leave += new System.EventHandler(this.tbx_y_limit_high_Leave);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox5.Controls.Add(this.link_clear_all);
            this.groupBox5.Controls.Add(this.lb_typ1_count);
            this.groupBox5.Controls.Add(this.link_typ1_clear);
            this.groupBox5.Controls.Add(this.label41);
            this.groupBox5.Controls.Add(this.lb_typ3_count);
            this.groupBox5.Controls.Add(this.link_typ3_clear);
            this.groupBox5.Controls.Add(this.label37);
            this.groupBox5.Controls.Add(this.lb_typ2_count);
            this.groupBox5.Controls.Add(this.link_typ2_clear);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox5.Location = new System.Drawing.Point(919, 198);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(601, 135);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sort Count";
            // 
            // link_clear_all
            // 
            this.link_clear_all.AutoSize = true;
            this.link_clear_all.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_clear_all.Location = new System.Drawing.Point(304, 35);
            this.link_clear_all.Name = "link_clear_all";
            this.link_clear_all.Size = new System.Drawing.Size(101, 28);
            this.link_clear_all.TabIndex = 92;
            this.link_clear_all.TabStop = true;
            this.link_clear_all.Text = "Clear All";
            this.link_clear_all.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_clear_all_LinkClicked);
            // 
            // lb_typ1_count
            // 
            this.lb_typ1_count.AutoSize = true;
            this.lb_typ1_count.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_typ1_count.Location = new System.Drawing.Point(115, 37);
            this.lb_typ1_count.Name = "lb_typ1_count";
            this.lb_typ1_count.Size = new System.Drawing.Size(72, 28);
            this.lb_typ1_count.TabIndex = 91;
            this.lb_typ1_count.Text = "####";
            // 
            // link_typ1_clear
            // 
            this.link_typ1_clear.AutoSize = true;
            this.link_typ1_clear.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_typ1_clear.Location = new System.Drawing.Point(212, 35);
            this.link_typ1_clear.Name = "link_typ1_clear";
            this.link_typ1_clear.Size = new System.Drawing.Size(67, 28);
            this.link_typ1_clear.TabIndex = 90;
            this.link_typ1_clear.TabStop = true;
            this.link_typ1_clear.Text = "Clear";
            this.link_typ1_clear.Click += new System.EventHandler(this.link_typ1_clear_LinkClicked);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(18, 35);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(80, 28);
            this.label41.TabIndex = 89;
            this.label41.Text = "Type 1";
            // 
            // lb_typ3_count
            // 
            this.lb_typ3_count.AutoSize = true;
            this.lb_typ3_count.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_typ3_count.Location = new System.Drawing.Point(115, 95);
            this.lb_typ3_count.Name = "lb_typ3_count";
            this.lb_typ3_count.Size = new System.Drawing.Size(72, 28);
            this.lb_typ3_count.TabIndex = 88;
            this.lb_typ3_count.Text = "####";
            // 
            // link_typ3_clear
            // 
            this.link_typ3_clear.AutoSize = true;
            this.link_typ3_clear.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_typ3_clear.Location = new System.Drawing.Point(212, 98);
            this.link_typ3_clear.Name = "link_typ3_clear";
            this.link_typ3_clear.Size = new System.Drawing.Size(67, 28);
            this.link_typ3_clear.TabIndex = 87;
            this.link_typ3_clear.TabStop = true;
            this.link_typ3_clear.Text = "Clear";
            this.link_typ3_clear.Click += new System.EventHandler(this.link_typ3_clear_LinkClicked);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(18, 95);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(80, 28);
            this.label37.TabIndex = 86;
            this.label37.Text = "Type 3";
            // 
            // lb_typ2_count
            // 
            this.lb_typ2_count.AutoSize = true;
            this.lb_typ2_count.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_typ2_count.Location = new System.Drawing.Point(115, 65);
            this.lb_typ2_count.Name = "lb_typ2_count";
            this.lb_typ2_count.Size = new System.Drawing.Size(72, 28);
            this.lb_typ2_count.TabIndex = 85;
            this.lb_typ2_count.Text = "####";
            // 
            // link_typ2_clear
            // 
            this.link_typ2_clear.AutoSize = true;
            this.link_typ2_clear.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_typ2_clear.Location = new System.Drawing.Point(212, 65);
            this.link_typ2_clear.Name = "link_typ2_clear";
            this.link_typ2_clear.Size = new System.Drawing.Size(67, 28);
            this.link_typ2_clear.TabIndex = 84;
            this.link_typ2_clear.TabStop = true;
            this.link_typ2_clear.Text = "Clear";
            this.link_typ2_clear.Click += new System.EventHandler(this.link_typ2_clear_LinkClicked);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(18, 65);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(80, 28);
            this.label31.TabIndex = 83;
            this.label31.Text = "Type 2";
            // 
            // imgBox_crop
            // 
            this.imgBox_crop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBox_crop.Location = new System.Drawing.Point(6, 87);
            this.imgBox_crop.Name = "imgBox_crop";
            this.imgBox_crop.Size = new System.Drawing.Size(512, 384);
            this.imgBox_crop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBox_crop.TabIndex = 18;
            this.imgBox_crop.TabStop = false;
            this.imgBox_crop.Visible = false;
            // 
            // picbox_offCam
            // 
            this.picbox_offCam.Image = global::DE1T4_Project.Properties.Resources.offCam;
            this.picbox_offCam.Location = new System.Drawing.Point(6, 87);
            this.picbox_offCam.Name = "picbox_offCam";
            this.picbox_offCam.Size = new System.Drawing.Size(512, 384);
            this.picbox_offCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_offCam.TabIndex = 17;
            this.picbox_offCam.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DE1T4_Project.Properties.Resources.Layer_2IUH;
            this.pictureBox1.Location = new System.Drawing.Point(10, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_pos_home
            // 
            this.btn_pos_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pos_home.BackgroundImage")));
            this.btn_pos_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_pos_home.Location = new System.Drawing.Point(26, 55);
            this.btn_pos_home.Name = "btn_pos_home";
            this.btn_pos_home.Size = new System.Drawing.Size(80, 80);
            this.btn_pos_home.TabIndex = 0;
            this.btn_pos_home.UseVisualStyleBackColor = true;
            this.btn_pos_home.Click += new System.EventHandler(this.btn_pos_home_Click);
            // 
            // btn_objQueueView
            // 
            this.btn_objQueueView.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_objQueueView.Location = new System.Drawing.Point(19, 331);
            this.btn_objQueueView.Name = "btn_objQueueView";
            this.btn_objQueueView.Size = new System.Drawing.Size(125, 40);
            this.btn_objQueueView.TabIndex = 107;
            this.btn_objQueueView.Text = "View Queue";
            this.btn_objQueueView.UseVisualStyleBackColor = true;
            this.btn_objQueueView.Click += new System.EventHandler(this.btn_objQueueView_Click_1);
            // 
            // Form_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1532, 783);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imageProcess_grbox);
            this.Controls.Add(this.camera_grbox);
            this.Controls.Add(this.PLC_grbox);
            this.Controls.Add(this.Conveyor_grbox);
            this.Controls.Add(this.position_grbox);
            this.Controls.Add(this.ToolHead_grbox);
            this.Controls.Add(this.movement_grbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Main";
            this.Text = "DE1T4 Pick&Place Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ToolHead_grbox.ResumeLayout(false);
            this.ToolHead_grbox.PerformLayout();
            this.position_grbox.ResumeLayout(false);
            this.position_grbox.PerformLayout();
            this.Conveyor_grbox.ResumeLayout(false);
            this.Conveyor_grbox.PerformLayout();
            this.PLC_grbox.ResumeLayout(false);
            this.PLC_grbox.PerformLayout();
            this.camera_grbox.ResumeLayout(false);
            this.camera_grbox.PerformLayout();
            this.movement_grbox.ResumeLayout(false);
            this.movement_grbox.PerformLayout();
            this.imageProcess_grbox.ResumeLayout(false);
            this.imageProcess_grbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_img_set)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_crop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_offCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox ToolHead_grbox;
        private MetroSet_UI.Controls.MetroSetSwitch sw_th_Vaccum;
        private System.Windows.Forms.Label lb_th_valve;
        private MetroSet_UI.Controls.MetroSetSwitch sw_th_Valve;
        private System.Windows.Forms.Label lb_th_vaccum;
        private System.Windows.Forms.GroupBox position_grbox;
        private System.Windows.Forms.Button btn_pos_home;
        private System.Windows.Forms.GroupBox Conveyor_grbox;
        private System.Windows.Forms.Label lb_con_Velocity;
        private System.Windows.Forms.Label lb_Con_Run;
        private System.Windows.Forms.Label lb_con_mmps;
        private System.Windows.Forms.TextBox tbx_con_speed;
        private System.Windows.Forms.Label lb_con_Speed;
        private MetroSet_UI.Controls.MetroSetSwitch sw_con_Run;
        private System.Windows.Forms.GroupBox PLC_grbox;
        private System.Windows.Forms.Button btn_plc_connect;
        private System.Windows.Forms.Label lb_plc_ip;
        private System.Windows.Forms.TextBox tbx_plc_ip;
        private System.Windows.Forms.Label lb_con_accSpeed;
        private System.Windows.Forms.Label lb_con_mmps_v;
        private System.Windows.Forms.GroupBox camera_grbox;
        private System.Windows.Forms.ComboBox cbb_Camlist;
        private System.Windows.Forms.Button btn_cam_connect;
        private System.Windows.Forms.Button btn_frame_setting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picbox_offCam;
        private Emgu.CV.UI.ImageBox imgBox_crop;
        private System.Windows.Forms.Timer cyclicRead;
        private System.Windows.Forms.Label lb_Pos_Z;
        private System.Windows.Forms.Label lb_Pos_Y;
        private System.Windows.Forms.Label lb_Pos_X;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_mov_Ymin;
        private System.Windows.Forms.Button btn_mov_Yplus;
        private System.Windows.Forms.Button btn_mov_Xplus;
        private System.Windows.Forms.Button btn_mov_Xmin;
        private System.Windows.Forms.Button btn_mov_Zmin;
        private System.Windows.Forms.Button btn_mov_Zplus;
        private System.Windows.Forms.Label lb_mov_division;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_mov_division;
        private System.Windows.Forms.GroupBox movement_grbox;
        private System.Windows.Forms.Label lb_mov_mmps;
        private System.Windows.Forms.Label lb_mov_velocity;
        private System.Windows.Forms.TextBox tbx_mov_velocity;
        private System.Windows.Forms.Button btn_Mov_Move;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_mov_Z;
        private System.Windows.Forms.TextBox tbx_mov_Y;
        private System.Windows.Forms.TextBox tbx_mov_X;
        private System.Windows.Forms.GroupBox imageProcess_grbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_img_hueMin;
        private System.Windows.Forms.Label lb_img_hueMax;
        private System.Windows.Forms.HScrollBar scbar_HueMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.HScrollBar scbar_HueMax;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lb_img_valMin;
        private System.Windows.Forms.Label lb_img_valMax;
        private System.Windows.Forms.HScrollBar scbar_ValMin;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.HScrollBar scbar_ValMax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_img_satMin;
        private System.Windows.Forms.Label lb_img_satMax;
        private System.Windows.Forms.HScrollBar scbar_SatMin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.HScrollBar scbar_SatMax;
        private System.Windows.Forms.NumericUpDown num_img_set;
        private System.Windows.Forms.TextBox tbx_img_Name;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbx_img_shape;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbx_img_Area_min;
        private System.Windows.Forms.TextBox tbx_img_Area_max;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ColorDialog color_lable;
        private System.Windows.Forms.Label label25;
        private MetroSet_UI.Controls.MetroSetSwitch sw_img_gray;
        private System.Windows.Forms.LinkLabel link_img_LB_color;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel link_img_getArea;
        private System.Windows.Forms.Label lb_img_area;
        private System.Windows.Forms.TextBox tbx_auto_TL_X;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbx_auto_TL_Y;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbx_auto_offsetX;
        private System.Windows.Forms.TextBox tbx_auto_offsetY;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbx_auto_offsetZ;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btn_auto_OnOff;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbx_auto_ZPick;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox tbx_auto_ZPlace;
        private System.Windows.Forms.TextBox tbx_typ1_coor_x;
        private System.Windows.Forms.TextBox tbx_typ1_coor_y;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox tbx_typ1_coor_z;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox tbx_typ2_coor_x;
        private System.Windows.Forms.TextBox tbx_typ2_coor_y;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox tbx_typ2_coor_z;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbx_typ3_coor_x;
        private System.Windows.Forms.TextBox tbx_typ3_coor_y;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox tbx_typ3_coor_z;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.LinkLabel link_clear_all;
        private System.Windows.Forms.Label lb_typ1_count;
        private System.Windows.Forms.LinkLabel link_typ1_clear;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label lb_typ3_count;
        private System.Windows.Forms.LinkLabel link_typ3_clear;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lb_typ2_count;
        private System.Windows.Forms.LinkLabel link_typ2_clear;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tbx_y_limit_low;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox tbx_y_limit_high;
        private System.Windows.Forms.Button btn_camsetup;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btn_objQueueView;
    }
}

