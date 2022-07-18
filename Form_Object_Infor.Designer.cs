
namespace DE1T4_Project
{
    partial class Form_Object_Infor
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
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.indexObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordinate_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordinate_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridView
            // 
            this.dtGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexObj,
            this.type,
            this.name,
            this.shapes,
            this.area,
            this.coordinate_X,
            this.coordinate_Y});
            this.dtGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dtGridView.Location = new System.Drawing.Point(0, 0);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.Size = new System.Drawing.Size(744, 190);
            this.dtGridView.TabIndex = 1;
            // 
            // indexObj
            // 
            this.indexObj.HeaderText = "Index";
            this.indexObj.MinimumWidth = 6;
            this.indexObj.Name = "indexObj";
            this.indexObj.ReadOnly = true;
            this.indexObj.Width = 70;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 70;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // shapes
            // 
            this.shapes.HeaderText = "Shapes";
            this.shapes.MinimumWidth = 6;
            this.shapes.Name = "shapes";
            this.shapes.ReadOnly = true;
            this.shapes.Width = 125;
            // 
            // area
            // 
            this.area.HeaderText = "Area";
            this.area.MinimumWidth = 6;
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // coordinate_X
            // 
            this.coordinate_X.HeaderText = "Coordinate_X";
            this.coordinate_X.MinimumWidth = 6;
            this.coordinate_X.Name = "coordinate_X";
            this.coordinate_X.ReadOnly = true;
            // 
            // coordinate_Y
            // 
            this.coordinate_Y.HeaderText = "Coordinate_Y";
            this.coordinate_Y.MinimumWidth = 6;
            this.coordinate_Y.Name = "coordinate_Y";
            this.coordinate_Y.ReadOnly = true;
            // 
            // Form_Object_Infor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(744, 190);
            this.Controls.Add(this.dtGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Object_Infor";
            this.Text = "Object Queue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Object_Infor_FormClosing);
            this.Load += new System.EventHandler(this.Form_Object_Infor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn shapes;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordinate_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordinate_Y;
    }
}