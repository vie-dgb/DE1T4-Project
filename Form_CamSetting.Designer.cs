
namespace DE1T4_Project
{
    partial class Form_CamSetting
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
            this.btn_config_reframe = new System.Windows.Forms.Button();
            this.setCamTimer = new System.Windows.Forms.Timer(this.components);
            this.picBox_config = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_config)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_config_reframe
            // 
            this.btn_config_reframe.Location = new System.Drawing.Point(658, 12);
            this.btn_config_reframe.Name = "btn_config_reframe";
            this.btn_config_reframe.Size = new System.Drawing.Size(121, 38);
            this.btn_config_reframe.TabIndex = 0;
            this.btn_config_reframe.Text = "Reset crop";
            this.btn_config_reframe.UseVisualStyleBackColor = true;
            this.btn_config_reframe.Click += new System.EventHandler(this.btn_config_reframe_Click);
            // 
            // setCamTimer
            // 
            this.setCamTimer.Tick += new System.EventHandler(this.setCamTimer_Tick);
            // 
            // picBox_config
            // 
            this.picBox_config.Location = new System.Drawing.Point(12, 12);
            this.picBox_config.Name = "picBox_config";
            this.picBox_config.Size = new System.Drawing.Size(640, 400);
            this.picBox_config.TabIndex = 3;
            this.picBox_config.TabStop = false;
            this.picBox_config.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_config_Paint);
            this.picBox_config.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_config_MouseDown);
            this.picBox_config.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_config_MouseMove);
            this.picBox_config.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_config_MouseUp);
            // 
            // Form_CamSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(915, 566);
            this.Controls.Add(this.picBox_config);
            this.Controls.Add(this.btn_config_reframe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_CamSetting";
            this.Text = "Camera setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_CamSetting_FormClosing);
            this.Load += new System.EventHandler(this.Form_CamSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_config)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_config_reframe;
        private System.Windows.Forms.Timer setCamTimer;
        private System.Windows.Forms.PictureBox picBox_config;
    }
}