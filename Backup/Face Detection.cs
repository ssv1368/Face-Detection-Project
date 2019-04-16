using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using AForge.Math;
using AForge.Imaging;
namespace i_rely_solely_on_god
{
    class Face_Detection
    {
        //Define variable for Convert RGB 2 YCBCR
        //double Y = 0;
        //double Cb = 0;
        double Cr = 0;
        int R = 0;
        int G = 0;
        int B = 0;
        int r = 0;
        int Testdetection, WPresentdetection = 0;
        int BPresentdetection1 = 0;
        AForge.Math.Histogram activeHistogram = null;
        //Main function for face detection
        public int[]  FaceDetection(Form1 Main, PictureBox PicFirst, PictureBox Picresult,TextBox TWskin,PictureBox face,TextBox TBskin)
        {
            Testdetection = 0;
            Graphics hh = PicFirst.CreateGraphics();
            Bitmap PreResult = new Bitmap(PicFirst.Image);
            Bitmap Result = new Bitmap(PicFirst.Width, Picresult.Height);
            Bitmap HisResult = new Bitmap(PicFirst.Width, Picresult.Height);
            Bitmap Template50 = new Bitmap("sample50.bmp");
            Bitmap Template25 = new Bitmap("sample25.bmp");
            Bitmap facee = new Bitmap(face.Width, face.Height);
            for (int i = 0; i < PicFirst.Width; i++)
            {
                for (int j = 0; j < PicFirst.Height; j++)
                {
                    //Getting red layer
                    R = PreResult.GetPixel(i, j).R;
                    //Getting green layer
                    G = PreResult.GetPixel(i, j).G;
                    //Getting blue layer
                    B = PreResult.GetPixel(i, j).B;
                    //Formula for convert RGB 2 YCBCR
                    //Y = 0.299 * R + 0.587 * G + 0.114 * B;
                    //Cb = -0.169*R - 0.332*G + 0.500*B;
                    Cr = 0.500 * R - 0.419 * G - 0.081 * B;
                    //Ckeck for "-" values(Because we can't use "-" values for RGB color)
                    if (Cr < 0)
                        //Convert to Positive values
                        Cr =0;
                    HisResult.SetPixel(i, j, Color.FromArgb((int)Cr, (int)Cr, (int)Cr));
                    if (Cr > 10)
                        //Convert to Positive values
                        Cr = 255;
                        //if (Cr>20)
                        //    //Convert to Positive values
                        //    Cr = Cr+128;
                        //Set the pixel  by cr value
                        Result.SetPixel(i, j, Color.FromArgb((int)Cr, (int)Cr, (int)Cr));
                    }
            }
          
            //Create filter form my image
            FiltersSequence processingFilter = new FiltersSequence();
            //Detection the adges
            processingFilter.Add(new Edges());
   
            WPresentdetection=0;
            BPresentdetection1= 0;
            //Apply filter for my pic
            Picresult.Image =processingFilter.Apply( Result);
            //Detect face with big template
            for (int d = 0; d <150-50; d+=20)
            {
                Testdetection = 0;
                WPresentdetection = 0;
                BPresentdetection1 = 0;
                for (int c = 0; c <150-50; c+=20)
                {
                    Testdetection = 0;
                    WPresentdetection = 0;
                    BPresentdetection1 = 0;
                    for (int w = 0; w < Template50.Width; w++)
                    {
                        for (int h = 0; h < Template50.Height; h++)
                        {
                            if (Template50.GetPixel(w, h).B == 255)
                            {
                                if (Result.GetPixel(d + w, c + h).B == Template50.GetPixel(w, h).B)
                                {
                                    WPresentdetection++;
                                }
                            }
                            //if (Template50.GetPixel(w, h).B == 255)
                            //{
                            //    if (Result.GetPixel(d + w, c + h).B == Template50.GetPixel(w, h).B)
                            //    {
                            //        BPresentdetection1++;
                            //    }
                            //}
                        }
                    }
                    TWskin.Text = WPresentdetection.ToString();
                    TBskin.Text = BPresentdetection1.ToString();
                    if (WPresentdetection > 377)//&&BPresentdetection1>1579)
                    {
                        hh.DrawRectangle(new Pen(Color.Red), d, c,60, 60);
                        for (int i = 0; i < 60; i++)
                        {
                            for (int j = 0; j< 60; j++)
                            {
                                r = PreResult.GetPixel(i + d, j + c).R;
                                facee.SetPixel(i, j, Color.FromArgb((int)r, (int)r, (int)r));
                                face.Image  = facee;
                            }
                        }
                        TWskin.Text = WPresentdetection.ToString();
                        TBskin.Text = BPresentdetection1.ToString();
                        WPresentdetection = 0;
                        BPresentdetection1 = 0;
                        Testdetection = 1;
                        break;
                    }
                    // Detect face with small template
                    //else
                    //{
                    //    Testdetection = 0;
                    //    WPresentdetection = 0;
                    //    for (int w = 0; w < Template25.Width; w++)
                    //    {
                    //        for (int h = 0; h < Template25.Height; h++)
                    //        {
                    //            if (Result.GetPixel(d + w, c + h).B == 255)
                    //            {
                    //                if (Result.GetPixel(d + w, c + h).B == Template25.GetPixel(w, h).B)
                    //                {
                    //                    WPresentdetection++;
                    //                }
                    //            }
                    //        }
                    //    }
                    //    if (WPresentdetection > 50)
                    //    {
                    //        hh.DrawRectangle(new Pen(Color.Red), d, c, 30, 30);
                    //        for (int i = 0; i < 30; i++)
                    //        {
                    //            for (int j = 0; j < 30; j++)
                    //            {
                    //                r = PreResult.GetPixel(i + d, j + c).R;
                    //                facee.SetPixel(i, j, Color.FromArgb((int)r, (int)r, (int)r));
                    //                face.Image = facee;
                    //            }
                    //        }
                    //        TWskin.Text = WPresentdetection.ToString();
                    //        WPresentdetection = 0;
                    //        Testdetection = 2;
                    //        break;
                    //    }
                    //}
                }
                if (Testdetection == 1 || Testdetection == 2)
                {
                    WPresentdetection = 0;
                    BPresentdetection1=0;
                    Testdetection = 0;
                    break;
                }
            }
            //Draw histogram
            AForge.Imaging.ImageStatistics stat =
            new AForge.Imaging.ImageStatistics(HisResult);
            if (stat != null)
            {
                //Do if the pic is gray
                if (stat.IsGrayscale)
                {
                    activeHistogram = stat.Red;
                }
                //Do if the pic is colourful
                if (!stat.IsGrayscale)
                {
                    activeHistogram = stat.Red;
                }
            }
            return (activeHistogram.Values);
        }
    }
}