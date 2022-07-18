using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE1T4_Project
{
    public partial class Form_Object_Infor : Form
    {
        public Form_Object_Infor()
        {
            InitializeComponent();
        }
        Timer refreshTimer = new Timer { Interval = 100 };
        private void Form_Object_Infor_Load(object sender, EventArgs e)
        {
            List<ObjView> itemss = new List<ObjView>();
            
            dtGridView.Columns.Clear();
            dtGridView.DataSource = itemss;
            dtGridView.AllowUserToResizeColumns = true;
            dtGridView.Columns[0].Width = 70;
            dtGridView.Columns[1].Width = 70;
            dtGridView.Columns[2].Width = 125;
            dtGridView.Columns[3].Width = 125;
            dtGridView.Columns[4].Width = 100;
            dtGridView.Columns[5].Width = 100;
            dtGridView.Columns[6].Width = 100;
            dtGridView.Refresh();
            
            refreshTimer.Tick += new System.EventHandler(refreshTimerHandler);
            refreshTimer.Start();
        }
        private void Form_Object_Infor_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshTimer.Stop();
            Form_Status.viewQueue = false;
        }
        public class ObjView
        {
            public int Index { get; set; }
            public int Type { get; set; }
            public string Name { get; set; }
            public string Shapes { get; set; }
            public double Area { get; set; }
            public double Coordinate_X { get; set; }
            public double Coordinate_Y { get; set; }
}
        public void refreshTimerHandler(object source, EventArgs e)
        {
            if(ObQueue.changeQueue)
            {
                List<ObjView> itemss = new List<ObjView>();
                if (ObQueue.queue.Count > 0)
                {
                    for (int i = 0; i < ObQueue.queue.Count; i++)
                    {
                        itemss.Add(new ObjView() {
                            Index = i,
                            Type = ObQueue.queue[i].typeObject,
                            Name = Cam_S.imgSet[ObQueue.queue[i].typeObject].name,
                            Shapes = ObQueue.queue[i].shapes.ToString(),
                            Area = ObQueue.queue[i].area,
                            Coordinate_X = ObQueue.queue[i].CoorX,
                            Coordinate_Y = ObQueue.queue[i].CoorY,
                        }) ;
                    }
                }

                //dtGridView.Columns.Clear();
                dtGridView.DataSource = itemss;
                ObQueue.changeQueue = false;
            }
        }

        
    }
}
