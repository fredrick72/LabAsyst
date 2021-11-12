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
    public partial class TargetSetting : Form
    {
        WebCam webcam;
        PointF target;
        public DialogResult result;

        public PointF Target
        {
            get { return target; }
        }
        public TargetSetting()
        {
            InitializeComponent();
        }
        //private override DialogResult ShowDialog()
        //{
        //    return result;
        //}
        private void TargetSetting_Load(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref liveImagePictureBox);
            webcam.Start();

        }

        private void liveImagePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            target = new PointF(e.X, e.Y);
            xPosTextBox.Text = target.X.ToString();
            yPosTextBox.Text = target.Y.ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            webcam.Stop();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            webcam.Stop();
            this.Close();
        }
    }
}
