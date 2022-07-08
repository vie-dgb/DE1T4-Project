
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
            this.setCamTimer = new System.Windows.Forms.Timer(this.components);
            this.picBox_config = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_crop_height = new System.Windows.Forms.Label();
            this.lb_crop_width = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btn_config_reframe = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ratio_Height = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ratio_Width = new System.Windows.Forms.TextBox();
            this.lb_get_ratio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_config_ratio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_config)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // setCamTimer
            // 
            this.setCamTimer.Tick += new System.EventHandler(this.setCamTimer_Tick);
            // 
            // picBox_config
            // 
            this.picBox_config.Location = new System.Drawing.Point(12, 12);
            this.picBox_config.Name = "picBox_config";
            this.picBox_config.Size = new System.Drawing.Size(640, 442);
            this.picBox_config.TabIndex = 3;
            this.picBox_config.TabStop = false;
            this.picBox_config.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_config_Paint);
            this.picBox_config.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_config_MouseDown);
            this.picBox_config.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_config_MouseMove);
            this.picBox_config.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_config_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_crop_height);
            this.groupBox1.Controls.Add(this.lb_crop_width);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.btn_config_reframe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(658, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 188);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proccess Frame";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 66;
            this.label1.Text = "Height:";
            // 
            // lb_crop_height
            // 
            this.lb_crop_height.AutoSize = true;
            this.lb_crop_height.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_crop_height.Location = new System.Drawing.Point(111, 147);
            this.lb_crop_height.Name = "lb_crop_height";
            this.lb_crop_height.Size = new System.Drawing.Size(58, 23);
            this.lb_crop_height.TabIndex = 65;
            this.lb_crop_height.Text = "####";
            // 
            // lb_crop_width
            // 
            this.lb_crop_width.AutoSize = true;
            this.lb_crop_width.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_crop_width.Location = new System.Drawing.Point(111, 103);
            this.lb_crop_width.Name = "lb_crop_width";
            this.lb_crop_width.Size = new System.Drawing.Size(58, 23);
            this.lb_crop_width.TabIndex = 64;
            this.lb_crop_width.Text = "####";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(19, 103);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 23);
            this.label23.TabIndex = 63;
            this.label23.Text = "Width:";
            // 
            // btn_config_reframe
            // 
            this.btn_config_reframe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_config_reframe.Location = new System.Drawing.Point(18, 40);
            this.btn_config_reframe.Name = "btn_config_reframe";
            this.btn_config_reframe.Size = new System.Drawing.Size(121, 38);
            this.btn_config_reframe.TabIndex = 62;
            this.btn_config_reframe.Text = "Reset crop";
            this.btn_config_reframe.UseVisualStyleBackColor = true;
            this.btn_config_reframe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_config_reframe_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_ratio_Height);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_ratio_Width);
            this.groupBox2.Controls.Add(this.lb_get_ratio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_config_ratio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(658, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 248);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ratio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(179, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 23);
            this.label6.TabIndex = 73;
            this.label6.Text = "mm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 72;
            this.label5.Text = "mm";
            // 
            // tb_ratio_Height
            // 
            this.tb_ratio_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ratio_Height.Location = new System.Drawing.Point(98, 187);
            this.tb_ratio_Height.Name = "tb_ratio_Height";
            this.tb_ratio_Height.Size = new System.Drawing.Size(75, 27);
            this.tb_ratio_Height.TabIndex = 71;
            this.tb_ratio_Height.Leave += new System.EventHandler(this.tb_ratio_Height_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 70;
            this.label4.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 69;
            this.label3.Text = "Width:";
            // 
            // tb_ratio_Width
            // 
            this.tb_ratio_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ratio_Width.Location = new System.Drawing.Point(98, 141);
            this.tb_ratio_Width.Name = "tb_ratio_Width";
            this.tb_ratio_Width.Size = new System.Drawing.Size(75, 27);
            this.tb_ratio_Width.TabIndex = 68;
            this.tb_ratio_Width.Leave += new System.EventHandler(this.tb_ratio_Width_Leave);
            // 
            // lb_get_ratio
            // 
            this.lb_get_ratio.AutoSize = true;
            this.lb_get_ratio.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_get_ratio.Location = new System.Drawing.Point(99, 95);
            this.lb_get_ratio.Name = "lb_get_ratio";
            this.lb_get_ratio.Size = new System.Drawing.Size(58, 23);
            this.lb_get_ratio.TabIndex = 67;
            this.lb_get_ratio.Text = "####";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 66;
            this.label2.Text = "Ratio:";
            // 
            // btn_config_ratio
            // 
            this.btn_config_ratio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_config_ratio.Location = new System.Drawing.Point(18, 39);
            this.btn_config_ratio.Name = "btn_config_ratio";
            this.btn_config_ratio.Size = new System.Drawing.Size(121, 38);
            this.btn_config_ratio.TabIndex = 65;
            this.btn_config_ratio.Text = "Get Ratio";
            this.btn_config_ratio.UseVisualStyleBackColor = true;
            this.btn_config_ratio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_config_ratio_Click);
            // 
            // Form_CamSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(915, 473);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picBox_config);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_CamSetting";
            this.Text = "Camera setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_CamSetting_FormClosing);
            this.Load += new System.EventHandler(this.Form_CamSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_config)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer setCamTimer;
        private System.Windows.Forms.PictureBox picBox_config;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_crop_height;
        private System.Windows.Forms.Label lb_crop_width;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btn_config_reframe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ratio_Height;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ratio_Width;
        private System.Windows.Forms.Label lb_get_ratio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_config_ratio;
    }
}