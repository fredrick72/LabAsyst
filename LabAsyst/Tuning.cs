using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;

namespace LabAsyst
{
    public partial class Tuning : Form
    {
        private ImgAnalysis imgan = new ImgAnalysis();
        private bool IsValidImage = false;
        private List<Device> deviceList = new List<Device>();
        
        public Tuning()
        {
            InitializeComponent();
            imageCheckTimer.Start();
        }
        UICam ueyeCam;
        WebCam webcam;
        private void button1_Click(object sender, EventArgs e)
        {
            webcam.Start();
            IsValidImage = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webcam.Stop();
            IsValidImage = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webcam = new WebCam();
            //ueyeCam = new UICam();
            webcam.InitializeWebCam(ref liveImagePictureBox);
            //ueyeCam.InitCamera(ref liveImagePictureBox);

            minRadiusTextBox.Text = Properties.Settings.Default.MinRadius.ToString();
            maxRadiusTextBox.Text = Properties.Settings.Default.MaxRadius.ToString();
            cannyThresholdTextBox.Text = Properties.Settings.Default.CannyThreshold.ToString();
            accumulatorThresholdTextBox.Text = Properties.Settings.Default.AccumulatorTreshold.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            webcam.ResolutionSetting();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webcam.AdvanceSetting();
        }

        private void cannyThreshTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CannyThreshold =  cannyThreshTrackBar.Value;
            cannyThresholdTextBox.Text = Properties.Settings.Default.CannyThreshold.ToString();
        }

        private void accumThreshtrackBar_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AccumulatorTreshold = accumThreshtrackBar.Value;
            accumulatorThresholdTextBox.Text = Properties.Settings.Default.AccumulatorTreshold.ToString();
        }

        private void minRadiusTrackBar_ValueChanged(object sender, EventArgs e)
        {
             Properties.Settings.Default.MinRadius = minRadiusTrackBar.Value;
             minRadiusTextBox.Text = Properties.Settings.Default.MinRadius.ToString();
        }

        private void maxRadiusTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MaxRadius = maxRadiusTrackBar.Value;
            maxRadiusTextBox.Text = Properties.Settings.Default.MaxRadius.ToString();
        }

        private Bitmap ImageToBitmap(Image sysdrawing) 
        {
            if (sysdrawing != null)
            {
                return new System.Drawing.Bitmap(sysdrawing);
                
            }
            else {
                return new System.Drawing.Bitmap(Properties.Resources.Image_Proc_Error);
                
            }
            
        }
        private Image<Gray,Byte> BitmapToEMGUImage(System.Drawing.Bitmap bmimg)
        {
        return new Image<Gray, Byte>(bmimg);
        }

        private void imageCheckTimer_Tick(object sender, EventArgs e)
        {
            if (IsValidImage) {
                imgan.DetectCircles(BitmapToEMGUImage(ImageToBitmap(liveImagePictureBox.Image)));

                liveImagePictureBox.Image = imgan.CircleImage.ToBitmap();
               if ((imgan.DetectedCircle != null))
               {
                xPosLabel.Text = imgan.DetectedCircle[0].Center.X.ToString();
                yPosLabel.Text = imgan.DetectedCircle[0].Center.Y.ToString();
               }
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            uEye.Types.SensorInfo sensorInfo;
            ueyeCam.Camera.Information.GetSensorInfo(out sensorInfo);

            if (sensorInfo.SensorID != uEye.Defines.Sensor.XS &&
                sensorInfo.SensorID != uEye.Defines.Sensor.UI1008_C)
            {
                // avoid multiple instances
                SettingsForm settingsForm = new SettingsForm(ueyeCam.Camera);
                //settingsForm.SizeControl.AOIChanged += OnDisplayChanged;
                //settingsForm.FormatControl.DisplayChanged += OnDisplayChanged;
                settingsForm.ShowDialog();

                //Boolean isEnabled;

                // check if any autofeature is enabled
                //ueyeCam.AutoFeatures.Software.WhiteBalance.GetEnable(out isEnabled);
                //toolStripButtonAWB.Checked = isEnabled;

                //m_Camera.AutoFeatures.Software.Shutter.GetEnable(out isEnabled);
                //toolStripButtonAES.Checked = isEnabled;

                //UpdateToolbar();
            }
            else
            {
                MessageBox.Show("Settings are not supported with this type of camera!");
            }
        }

        private void Tuning_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.AccumulatorTreshold = Int32.Parse(accumulatorThresholdTextBox.Text);
            Properties.Settings.Default.CannyThreshold = Int32.Parse(cannyThresholdTextBox.Text);
            Properties.Settings.Default.MinRadius = Int32.Parse(minRadiusTextBox.Text);
            Properties.Settings.Default.MaxRadius = Int32.Parse(maxRadiusTextBox.Text);
            
        }
    }
}
