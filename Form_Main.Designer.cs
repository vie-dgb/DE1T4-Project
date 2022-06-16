
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
            this.movement_grbox = new System.Windows.Forms.GroupBox();
            this.tbx_mov_division = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_mov_division = new System.Windows.Forms.Label();
            this.btn_mov_Zplus = new System.Windows.Forms.Button();
            this.btn_mov_Zmin = new System.Windows.Forms.Button();
            this.btn_mov_Xmin = new System.Windows.Forms.Button();
            this.btn_mov_Xplus = new System.Windows.Forms.Button();
            this.btn_mov_Yplus = new System.Windows.Forms.Button();
            this.btn_mov_Ymin = new System.Windows.Forms.Button();
            this.ToolHead_grbox = new System.Windows.Forms.GroupBox();
            this.lb_th_valve = new System.Windows.Forms.Label();
            this.sw_th_Valve = new MetroSet_UI.Controls.MetroSetSwitch();
            this.lb_th_vaccum = new System.Windows.Forms.Label();
            this.sw_th_Vaccum = new MetroSet_UI.Controls.MetroSetSwitch();
            this.position_grbox = new System.Windows.Forms.GroupBox();
            this.btn_pos_home = new System.Windows.Forms.Button();
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
            this.btn_cam_setting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Camlist = new System.Windows.Forms.ComboBox();
            this.btn_cam_connect = new System.Windows.Forms.Button();
            this.picbox_offCam = new System.Windows.Forms.PictureBox();
            this.imgBox_drop = new Emgu.CV.UI.ImageBox();
            this.cyclicRead = new System.Windows.Forms.Timer(this.components);
            this.movement2_grbox = new System.Windows.Forms.GroupBox();
            this.tbx_mov_Z = new System.Windows.Forms.TextBox();
            this.tbx_mov_Y = new System.Windows.Forms.TextBox();
            this.tbx_mov_X = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Pos_X = new System.Windows.Forms.Label();
            this.lb_Pos_Y = new System.Windows.Forms.Label();
            this.lb_Pos_Z = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Mov_Move = new System.Windows.Forms.Button();
            this.lb_mov_mmps = new System.Windows.Forms.Label();
            this.lb_mov_velocity = new System.Windows.Forms.Label();
            this.tbx_mov_velocity = new System.Windows.Forms.TextBox();
            this.movement_grbox.SuspendLayout();
            this.ToolHead_grbox.SuspendLayout();
            this.position_grbox.SuspendLayout();
            this.Conveyor_grbox.SuspendLayout();
            this.PLC_grbox.SuspendLayout();
            this.camera_grbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_offCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_drop)).BeginInit();
            this.movement2_grbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // movement_grbox
            // 
            this.movement_grbox.BackColor = System.Drawing.Color.Gainsboro;
            this.movement_grbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            this.movement_grbox.Location = new System.Drawing.Point(1036, 12);
            this.movement_grbox.Name = "movement_grbox";
            this.movement_grbox.Size = new System.Drawing.Size(484, 180);
            this.movement_grbox.TabIndex = 4;
            this.movement_grbox.TabStop = false;
            this.movement_grbox.Text = "Movement";
            // 
            // tbx_mov_division
            // 
            this.tbx_mov_division.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_mov_division.Location = new System.Drawing.Point(332, 54);
            this.tbx_mov_division.Name = "tbx_mov_division";
            this.tbx_mov_division.Size = new System.Drawing.Size(78, 27);
            this.tbx_mov_division.TabIndex = 21;
            this.tbx_mov_division.TextChanged += new System.EventHandler(this.tbx_mov_division_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "mm";
            // 
            // lb_mov_division
            // 
            this.lb_mov_division.AutoSize = true;
            this.lb_mov_division.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mov_division.Location = new System.Drawing.Point(244, 57);
            this.lb_mov_division.Name = "lb_mov_division";
            this.lb_mov_division.Size = new System.Drawing.Size(82, 23);
            this.lb_mov_division.TabIndex = 19;
            this.lb_mov_division.Text = "Division";
            // 
            // btn_mov_Zplus
            // 
            this.btn_mov_Zplus.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mov_Zplus.Location = new System.Drawing.Point(170, 53);
            this.btn_mov_Zplus.Name = "btn_mov_Zplus";
            this.btn_mov_Zplus.Size = new System.Drawing.Size(68, 35);
            this.btn_mov_Zplus.TabIndex = 5;
            this.btn_mov_Zplus.Text = "Z+";
            this.btn_mov_Zplus.UseVisualStyleBackColor = true;
            this.btn_mov_Zplus.Click += new System.EventHandler(this.btn_mov_Zplus_Click);
            // 
            // btn_mov_Zmin
            // 
            this.btn_mov_Zmin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mov_Zmin.Location = new System.Drawing.Point(170, 104);
            this.btn_mov_Zmin.Name = "btn_mov_Zmin";
            this.btn_mov_Zmin.Size = new System.Drawing.Size(68, 35);
            this.btn_mov_Zmin.TabIndex = 4;
            this.btn_mov_Zmin.Text = "Z-";
            this.btn_mov_Zmin.UseVisualStyleBackColor = true;
            this.btn_mov_Zmin.Click += new System.EventHandler(this.btn_mov_Zmin_Click);
            // 
            // btn_mov_Xmin
            // 
            this.btn_mov_Xmin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mov_Xmin.Location = new System.Drawing.Point(22, 104);
            this.btn_mov_Xmin.Name = "btn_mov_Xmin";
            this.btn_mov_Xmin.Size = new System.Drawing.Size(68, 35);
            this.btn_mov_Xmin.TabIndex = 3;
            this.btn_mov_Xmin.Text = "X-";
            this.btn_mov_Xmin.UseVisualStyleBackColor = true;
            this.btn_mov_Xmin.Click += new System.EventHandler(this.btn_mov_Xmin_Click);
            // 
            // btn_mov_Xplus
            // 
            this.btn_mov_Xplus.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mov_Xplus.Location = new System.Drawing.Point(22, 53);
            this.btn_mov_Xplus.Name = "btn_mov_Xplus";
            this.btn_mov_Xplus.Size = new System.Drawing.Size(68, 35);
            this.btn_mov_Xplus.TabIndex = 2;
            this.btn_mov_Xplus.Text = "X+";
            this.btn_mov_Xplus.UseVisualStyleBackColor = true;
            this.btn_mov_Xplus.Click += new System.EventHandler(this.btn_mov_Xplus_Click);
            // 
            // btn_mov_Yplus
            // 
            this.btn_mov_Yplus.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mov_Yplus.Location = new System.Drawing.Point(96, 53);
            this.btn_mov_Yplus.Name = "btn_mov_Yplus";
            this.btn_mov_Yplus.Size = new System.Drawing.Size(68, 35);
            this.btn_mov_Yplus.TabIndex = 1;
            this.btn_mov_Yplus.Text = "Y+";
            this.btn_mov_Yplus.UseVisualStyleBackColor = true;
            this.btn_mov_Yplus.Click += new System.EventHandler(this.btn_mov_Yplus_Click);
            // 
            // btn_mov_Ymin
            // 
            this.btn_mov_Ymin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mov_Ymin.Location = new System.Drawing.Point(96, 104);
            this.btn_mov_Ymin.Name = "btn_mov_Ymin";
            this.btn_mov_Ymin.Size = new System.Drawing.Size(68, 35);
            this.btn_mov_Ymin.TabIndex = 0;
            this.btn_mov_Ymin.Text = "Y-";
            this.btn_mov_Ymin.UseVisualStyleBackColor = true;
            this.btn_mov_Ymin.Click += new System.EventHandler(this.btn_mov_Ymin_Click);
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
            this.ToolHead_grbox.Location = new System.Drawing.Point(614, 12);
            this.ToolHead_grbox.Name = "ToolHead_grbox";
            this.ToolHead_grbox.Size = new System.Drawing.Size(150, 180);
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
            this.position_grbox.Size = new System.Drawing.Size(320, 180);
            this.position_grbox.TabIndex = 7;
            this.position_grbox.TabStop = false;
            this.position_grbox.Text = "Position";
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
            this.Conveyor_grbox.Location = new System.Drawing.Point(770, 12);
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
            this.btn_plc_connect.Location = new System.Drawing.Point(59, 111);
            this.btn_plc_connect.Name = "btn_plc_connect";
            this.btn_plc_connect.Size = new System.Drawing.Size(165, 45);
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
            this.camera_grbox.Controls.Add(this.imgBox_drop);
            this.camera_grbox.Controls.Add(this.btn_cam_setting);
            this.camera_grbox.Controls.Add(this.label1);
            this.camera_grbox.Controls.Add(this.cbb_Camlist);
            this.camera_grbox.Controls.Add(this.btn_cam_connect);
            this.camera_grbox.Controls.Add(this.picbox_offCam);
            this.camera_grbox.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camera_grbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.camera_grbox.Location = new System.Drawing.Point(12, 198);
            this.camera_grbox.Name = "camera_grbox";
            this.camera_grbox.Size = new System.Drawing.Size(659, 573);
            this.camera_grbox.TabIndex = 8;
            this.camera_grbox.TabStop = false;
            this.camera_grbox.Text = "Camera";
            // 
            // btn_cam_setting
            // 
            this.btn_cam_setting.Enabled = false;
            this.btn_cam_setting.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cam_setting.Location = new System.Drawing.Point(496, 33);
            this.btn_cam_setting.Name = "btn_cam_setting";
            this.btn_cam_setting.Size = new System.Drawing.Size(150, 40);
            this.btn_cam_setting.TabIndex = 16;
            this.btn_cam_setting.Text = "Setting Camera";
            this.btn_cam_setting.UseVisualStyleBackColor = true;
            this.btn_cam_setting.Click += new System.EventHandler(this.btn_cam_setting_Click);
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
            // picbox_offCam
            // 
            this.picbox_offCam.Image = global::DE1T4_Project.Properties.Resources.offCam;
            this.picbox_offCam.Location = new System.Drawing.Point(6, 87);
            this.picbox_offCam.Name = "picbox_offCam";
            this.picbox_offCam.Size = new System.Drawing.Size(640, 480);
            this.picbox_offCam.TabIndex = 17;
            this.picbox_offCam.TabStop = false;
            // 
            // imgBox_drop
            // 
            this.imgBox_drop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBox_drop.Location = new System.Drawing.Point(6, 87);
            this.imgBox_drop.Name = "imgBox_drop";
            this.imgBox_drop.Size = new System.Drawing.Size(640, 480);
            this.imgBox_drop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBox_drop.TabIndex = 18;
            this.imgBox_drop.TabStop = false;
            this.imgBox_drop.Visible = false;
            // 
            // cyclicRead
            // 
            this.cyclicRead.Interval = 500;
            this.cyclicRead.Tick += new System.EventHandler(this.cyclicRead_Tick);
            // 
            // movement2_grbox
            // 
            this.movement2_grbox.BackColor = System.Drawing.Color.Gainsboro;
            this.movement2_grbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.movement2_grbox.Controls.Add(this.lb_mov_mmps);
            this.movement2_grbox.Controls.Add(this.lb_mov_velocity);
            this.movement2_grbox.Controls.Add(this.tbx_mov_velocity);
            this.movement2_grbox.Controls.Add(this.btn_Mov_Move);
            this.movement2_grbox.Controls.Add(this.label6);
            this.movement2_grbox.Controls.Add(this.label7);
            this.movement2_grbox.Controls.Add(this.label8);
            this.movement2_grbox.Controls.Add(this.tbx_mov_Z);
            this.movement2_grbox.Controls.Add(this.tbx_mov_Y);
            this.movement2_grbox.Controls.Add(this.tbx_mov_X);
            this.movement2_grbox.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movement2_grbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.movement2_grbox.Location = new System.Drawing.Point(1036, 198);
            this.movement2_grbox.Name = "movement2_grbox";
            this.movement2_grbox.Size = new System.Drawing.Size(484, 135);
            this.movement2_grbox.TabIndex = 9;
            this.movement2_grbox.TabStop = false;
            this.movement2_grbox.Text = "Movement";
            // 
            // tbx_mov_Z
            // 
            this.tbx_mov_Z.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_mov_Z.Location = new System.Drawing.Point(359, 43);
            this.tbx_mov_Z.Name = "tbx_mov_Z";
            this.tbx_mov_Z.Size = new System.Drawing.Size(80, 27);
            this.tbx_mov_Z.TabIndex = 11;
            // 
            // tbx_mov_Y
            // 
            this.tbx_mov_Y.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_mov_Y.Location = new System.Drawing.Point(216, 43);
            this.tbx_mov_Y.Name = "tbx_mov_Y";
            this.tbx_mov_Y.Size = new System.Drawing.Size(80, 27);
            this.tbx_mov_Y.TabIndex = 10;
            // 
            // tbx_mov_X
            // 
            this.tbx_mov_X.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_mov_X.Location = new System.Drawing.Point(73, 43);
            this.tbx_mov_X.Name = "tbx_mov_X";
            this.tbx_mov_X.Size = new System.Drawing.Size(80, 27);
            this.tbx_mov_X.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "Z:";
            // 
            // lb_Pos_X
            // 
            this.lb_Pos_X.AutoSize = true;
            this.lb_Pos_X.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pos_X.Location = new System.Drawing.Point(197, 41);
            this.lb_Pos_X.Name = "lb_Pos_X";
            this.lb_Pos_X.Size = new System.Drawing.Size(42, 28);
            this.lb_Pos_X.TabIndex = 19;
            this.lb_Pos_X.Text = "???";
            // 
            // lb_Pos_Y
            // 
            this.lb_Pos_Y.AutoSize = true;
            this.lb_Pos_Y.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pos_Y.Location = new System.Drawing.Point(197, 75);
            this.lb_Pos_Y.Name = "lb_Pos_Y";
            this.lb_Pos_Y.Size = new System.Drawing.Size(42, 28);
            this.lb_Pos_Y.TabIndex = 20;
            this.lb_Pos_Y.Text = "???";
            // 
            // lb_Pos_Z
            // 
            this.lb_Pos_Z.AutoSize = true;
            this.lb_Pos_Z.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pos_Z.Location = new System.Drawing.Point(197, 111);
            this.lb_Pos_Z.Name = "lb_Pos_Z";
            this.lb_Pos_Z.Size = new System.Drawing.Size(42, 28);
            this.lb_Pos_Z.TabIndex = 21;
            this.lb_Pos_Z.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(322, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "Z:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(179, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "X:";
            // 
            // btn_Mov_Move
            // 
            this.btn_Mov_Move.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mov_Move.Location = new System.Drawing.Point(337, 87);
            this.btn_Mov_Move.Name = "btn_Mov_Move";
            this.btn_Mov_Move.Size = new System.Drawing.Size(123, 40);
            this.btn_Mov_Move.TabIndex = 22;
            this.btn_Mov_Move.Text = "Move";
            this.btn_Mov_Move.UseVisualStyleBackColor = true;
            this.btn_Mov_Move.Click += new System.EventHandler(this.btn_Mov_Move_Click);
            // 
            // lb_mov_mmps
            // 
            this.lb_mov_mmps.AutoSize = true;
            this.lb_mov_mmps.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mov_mmps.Location = new System.Drawing.Point(205, 94);
            this.lb_mov_mmps.Name = "lb_mov_mmps";
            this.lb_mov_mmps.Size = new System.Drawing.Size(63, 23);
            this.lb_mov_mmps.TabIndex = 25;
            this.lb_mov_mmps.Text = "mm/s";
            // 
            // lb_mov_velocity
            // 
            this.lb_mov_velocity.AutoSize = true;
            this.lb_mov_velocity.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mov_velocity.Location = new System.Drawing.Point(36, 94);
            this.lb_mov_velocity.Name = "lb_mov_velocity";
            this.lb_mov_velocity.Size = new System.Drawing.Size(79, 23);
            this.lb_mov_velocity.TabIndex = 24;
            this.lb_mov_velocity.Text = "Velocity";
            // 
            // tbx_mov_velocity
            // 
            this.tbx_mov_velocity.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_mov_velocity.Location = new System.Drawing.Point(121, 92);
            this.tbx_mov_velocity.Name = "tbx_mov_velocity";
            this.tbx_mov_velocity.Size = new System.Drawing.Size(78, 27);
            this.tbx_mov_velocity.TabIndex = 23;
            // 
            // Form_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1532, 783);
            this.Controls.Add(this.movement2_grbox);
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
            this.movement_grbox.ResumeLayout(false);
            this.movement_grbox.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.picbox_offCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_drop)).EndInit();
            this.movement2_grbox.ResumeLayout(false);
            this.movement2_grbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox movement_grbox;
        private System.Windows.Forms.GroupBox ToolHead_grbox;
        private MetroSet_UI.Controls.MetroSetSwitch sw_th_Vaccum;
        private System.Windows.Forms.Label lb_th_valve;
        private MetroSet_UI.Controls.MetroSetSwitch sw_th_Valve;
        private System.Windows.Forms.Label lb_th_vaccum;
        private System.Windows.Forms.GroupBox position_grbox;
        private System.Windows.Forms.Button btn_pos_home;
        private System.Windows.Forms.Button btn_mov_Zplus;
        private System.Windows.Forms.Button btn_mov_Zmin;
        private System.Windows.Forms.Button btn_mov_Xmin;
        private System.Windows.Forms.Button btn_mov_Xplus;
        private System.Windows.Forms.Button btn_mov_Yplus;
        private System.Windows.Forms.Button btn_mov_Ymin;
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
        private System.Windows.Forms.TextBox tbx_mov_division;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_mov_division;
        private System.Windows.Forms.Label lb_con_mmps_v;
        private System.Windows.Forms.GroupBox camera_grbox;
        private System.Windows.Forms.ComboBox cbb_Camlist;
        private System.Windows.Forms.Button btn_cam_connect;
        private System.Windows.Forms.Button btn_cam_setting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picbox_offCam;
        private Emgu.CV.UI.ImageBox imgBox_drop;
        private System.Windows.Forms.Timer cyclicRead;
        private System.Windows.Forms.GroupBox movement2_grbox;
        private System.Windows.Forms.TextBox tbx_mov_Z;
        private System.Windows.Forms.TextBox tbx_mov_Y;
        private System.Windows.Forms.TextBox tbx_mov_X;
        private System.Windows.Forms.Label lb_Pos_Z;
        private System.Windows.Forms.Label lb_Pos_Y;
        private System.Windows.Forms.Label lb_Pos_X;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Mov_Move;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_mov_mmps;
        private System.Windows.Forms.Label lb_mov_velocity;
        private System.Windows.Forms.TextBox tbx_mov_velocity;
    }
}

