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
 
       
        //Create object of face_detection class
        private Face_Detection Face;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
            //Create new object of facedetection
            Face = new Face_Detection();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Drawing.Bitmap b = new Bitmap(System.Drawing.Image.FromFile(openFileDialog1.FileName ), PicFirst.Width, PicFirst.Height);
                PicFirst.Image = b;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            histogram.Values = Face.FaceDetection(this, PicFirst, Picresult, textBox1, face1, textBox2);
        } 
    }
}
