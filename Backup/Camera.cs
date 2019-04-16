using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebCam_Capture;
using System.Windows.Forms;
namespace i_rely_solely_on_god
{
    class Camera
    {
        //Variable of WebCamCapture class
        private WebCamCapture Cam;
        private Form1 Parent;
        PictureBox PicFi;
        //Initialize camera
        public void Init_Cam(Form1 form, int W, int H, PictureBox picFisrt)
        {
            Parent = form;
            PicFi = picFisrt;
            Cam = new WebCamCapture();
            //Set camera height
            Cam.CaptureHeight = H;
            //Set camera width
            Cam.CaptureWidth = W;
            //Refresh picture after avery one milli seconds
            Cam.TimeToCapture_milliseconds = 1;
            //Get picture from camera
            Cam.ImageCaptured += new WebCamCapture.WebCamEventHandler(Cam_ImageCaptured);
        }
        public void Start()
        {
            //Starting Capture
            Cam.Start(0);
        }
        //Get Picture of camera
        //Set picCam equal camera image
       public void Cam_ImageCaptured(object source, WebcamEventArgs e)
        {
           //Set image to picturebox
           PicFi.Image = e.WebCamImage;
        }
    }
}
