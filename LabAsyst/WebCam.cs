﻿using System;
using System.IO;
using System.Linq;
using System.Text;
using WebCam_Capture;
using System.Collections.Generic;
using Emgu.CV.Structure;
using Emgu.CV;



namespace LabAsyst
{
    
    [Serializable]
    class WebCam
    {
        private WebCamCapture webcam;
        private CustomPX.CustomPictureBox _FrameImage;
        private int FrameNumber = 30;
        public void InitializeWebCam(ref CustomPX.CustomPictureBox ImageControl)
        {
            webcam = new WebCamCapture();
            webcam.FrameNumber = ((ulong)(0ul));
            webcam.TimeToCapture_milliseconds = FrameNumber;
            webcam.ImageCaptured += new WebCamCapture.WebCamEventHandler(webcam_ImageCaptured);
            _FrameImage = ImageControl;
            
        }

        void webcam_ImageCaptured(object source, WebcamEventArgs e)
        {
            
            //System.Drawing.Bitmap liveBMP = new System.Drawing.Bitmap(e.WebCamImage);
            //Image<Gray, Byte> liveImage = new Image<Gray, Byte>(liveBMP);
            //imgan.DetectCircles(liveImage);

            //_FrameImage.Image = imgan.CircleImage.ToBitmap();
            _FrameImage.Image = e.WebCamImage;
            _FrameImage.Invalidate();
            
           
        }

        public void Start()
        {
            webcam.TimeToCapture_milliseconds = FrameNumber;
            webcam.Start(0);
          
        }

        public void Stop()
        {
            webcam.Stop();
        }

        public void Continue()
        {
            // change the capture time frame
            webcam.TimeToCapture_milliseconds = FrameNumber;

            // resume the video capture from the stop
            webcam.Start(this.webcam.FrameNumber);
        }

        public void ResolutionSetting()
        {
            webcam.Config();
        }

        public void AdvanceSetting()
        {
            webcam.Config2();
        }

    }
}
