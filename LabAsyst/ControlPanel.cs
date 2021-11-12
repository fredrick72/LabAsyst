using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LabAsyst
{
    public partial class ControlPanel : Form
    {
        private List<Device> deviceList = new List<Device>();
        private WebCam webcam;

        private  int runComputedAverage = 10000;
        private string deviceToolTipMessage;
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void imageTuningButton_Click(object sender, EventArgs e)
        {
            Tuning tune = new Tuning();

            tune.ShowDialog();
        }

        private void DeviceSetupButton_Click(object sender, EventArgs e)
        {

            
            DeviceConfigForm dcf = new DeviceConfigForm();
            if (deviceList.Count > 0)
            {
                //devices exist
                dcf.dcfdeviceList = deviceList;

            }
            dcf.ShowDialog();
                if (dcf.DeviceFLP.Controls.Count > 0) {
                    deviceList.Clear();
                    foreach (DeviceProperties devprop in dcf.DeviceFLP.Controls)
                        deviceList.Add(devprop.Dev);
                }
         }
        

        private void uiUpdatetimer_Tick(object sender, EventArgs e)
        {
            CPUpdate();
        }
        private void CPUpdate()
        {
            //clear device info
            deviceInfoRichTextBox.Clear();
            statsRichTextBox.Clear();
            errorsRichTextBox.Clear();
            if (deviceList[0].Ia.CircleImage != null) { 
             currentImagePictureBox.Image = deviceList[0].Ia.CircleImage.ToBitmap();
            }
           
            foreach (Device dev in deviceList) {
                if (dev.AverageIdleTime > (runComputedAverage * 2))
                { 
                    deviceInfoRichTextBox.SelectionColor = Color.Orange;
                    deviceToolTipMessage = " " + "device: " + dev.ID + " " + "has been idle for a very long time. This could mean the device has stopped responding.";
                    errorsRichTextBox.AppendText(deviceToolTipMessage + Environment.NewLine);
                }
                else if (dev.AverageIdleTime > runComputedAverage)
                {
                    deviceInfoRichTextBox.SelectionColor = Color.Red;
                    deviceToolTipMessage = " " + "device: " + dev.ID + " " + "has been idle for a very long time. This could mean the device has stopped responding.";
                    errorsRichTextBox.AppendText(deviceToolTipMessage + Environment.NewLine);
                }
                else { 
                    deviceInfoRichTextBox.SelectionColor = Color.Green;
                }

                deviceInfoRichTextBox.AppendText("Device ID: " + dev.ID + Environment.NewLine + "Device Name: " + dev.Name + Environment.NewLine + "Device Manufacturer: " + dev.Manufacturer + Environment.NewLine + "Device Status: " + dev.DeviceStatus + Environment.NewLine + Environment.NewLine);
                statsRichTextBox.AppendText("Device ID: " + dev.ID + Environment.NewLine + "Average Cycle Time: " + dev.AverageCyceTime + Environment.NewLine + "Average Idle Time: " + dev.AverageIdleTime + Environment.NewLine); 
            }

        }

        private void recordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (deviceList.Count > 0)
            {
                webcam = new WebCam();
                webcam.InitializeWebCam(ref currentImagePictureBox);
                foreach (Device dev in deviceList)
                {
                    if (recordCheckBox.Checked)
                    {
                        
                        dev.StartRecording(ref currentImagePictureBox);
                        webcam.Start();
                        uiUpdatetimer.Start();
                        systemStatusLabel.Text = "Running";

                    }
                    else
                    {
                        webcam.Stop();
                        dev.stopRecording();
                        uiUpdatetimer.Stop();
                        systemStatusLabel.Text = "Stopped";

                    }
                }
            }
        }
        private void OpenDeviceFile()
        {
            List<DeviceParameters> devPar = new List<DeviceParameters>();
            openFileDialog.Filter = "bin Files (*.bin)|*.bin;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Stream stream = File.Open(openFileDialog.FileName, FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();

                        devPar = (List<DeviceParameters>)bin.Deserialize(stream);

                        foreach (DeviceParameters dp in devPar) {
                            deviceList.Add(new Device() {ID = dp.ID, Name = dp.Name, Manufacturer = dp.Manufacturer, TargetPoint = dp.TargetPoint });
                        }

                    }
                }
                catch (IOException)
                {
                }
            }
        }
        private void SaveDeviceFile()
        {
            List<DeviceParameters> devPar = new List<DeviceParameters>();
            foreach (Device dev in deviceList) {
                devPar.Add(new DeviceParameters() {ID = dev.ID, Manufacturer = dev.Manufacturer, Name = dev.Name, TargetPoint = dev.TargetPoint });
            }
            saveFileDialog.Filter = "bin Files (*.bin)|*.bin;";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) { 
            try
            {
               
                using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, devPar);
                }
            }
            catch (IOException)
            {

            }
        }
        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (deviceList.Count > 0)
            {
                foreach (Device dev in deviceList)
                {
                    if (simulateCheckBox.Checked)
                    {
                        dev.IsSimulation = true;
                        dev.StartSimulation();
                        uiUpdatetimer.Start();
                        systemStatusLabel.Text = "Running (Simulation Mode)";
                    }
                    else
                    {
                        dev.StopSimulation();
                        uiUpdatetimer.Stop();
                        systemStatusLabel.Text = "Stopped";
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDeviceFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDeviceFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void devicePollFreqNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            foreach (Device dev in deviceList) {
                dev.RefreshInterval = (int)devicePollFreqNumericUpDown.Value;
            }
        }

        private void panelUpdateFreqNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            uiUpdatetimer.Interval = (int)panelUpdateFreqNumericUpDown.Value;
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            minRadiusTextBox.Text = Properties.Settings.Default.MinRadius.ToString();
            maxRadiusTextBox.Text = Properties.Settings.Default.MaxRadius.ToString();
            cannyThresholdTextBox.Text = Properties.Settings.Default.CannyThreshold.ToString();
            accumulatorThresholdTextBox.Text = Properties.Settings.Default.AccumulatorTreshold.ToString();

        }

        private void ControlPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.AccumulatorTreshold = Int32.Parse(accumulatorThresholdTextBox.Text);
            Properties.Settings.Default.CannyThreshold = Int32.Parse(cannyThresholdTextBox.Text);
            Properties.Settings.Default.MinRadius = Int32.Parse(minRadiusTextBox.Text);
            Properties.Settings.Default.MaxRadius = Int32.Parse(maxRadiusTextBox.Text);
            Properties.Settings.Default.Save();
        }

        private void cannyThreshTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CannyThreshold = cannyThreshTrackBar.Value;
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
