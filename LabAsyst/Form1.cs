using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabAsyst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WebCam webcam;
        private void button1_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webcam.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref liveImagePictureBox);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            webcam.ResolutionSetting();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webcam.AdvanceSetting();
        }

        private void liveImagePictureBox_Paint(object sender, PaintEventArgs e)
        {
            
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
    }
}
