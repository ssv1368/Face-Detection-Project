using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace i_rely_solely_on_god
{
    public partial class Form1 : Form
    {
        //Create object of camera class
        private Camera cam;
        //Create object of face_detection class
        private Face_Detection Face;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //create new object of camera
            cam = new Camera();
            //Initialize camera
            cam.Init_Cam(this,PicFirst.Width,PicFirst.Height,PicFirst);
            //Start capture from camera
            cam.Start();
            //Enable timer for get picture for Progress
            timer1.Enabled = true;
            //Create new object of facedetection
            Face = new Face_Detection();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Getting start for detect your face
            histogram.Values = Face.FaceDetection(this, PicFirst, Picresult,textBox1,face1,textBox2 );
        }
        //Get information from histogram
        private void colorSlider_ValuesChanged(object sender, EventArgs e)
        {
            histogram.Color = System.Drawing.Color.FromArgb(colorSlider.Min, colorSlider.Min, colorSlider.Min);
        }
        //Get information from histogram
        private void histogram_SelectionChanged(object sender, IPLab.HistogramEventArgs e)
        {
            level.Text ="Level : " + e.Min.ToString()+".."+e.Max.ToString() ;
        }
        //Get information from histogram
        private void histogram_PositionChanged(object sender, IPLab.HistogramEventArgs e)
        {
            if (e.Position != -1)
            {
                level.Text ="Level : " +e.Position.ToString();
            }
            else
            {
                level.Text = "Level : ";
            }
        } 
    }
}
