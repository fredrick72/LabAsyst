using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabAsyst
{
    class UICam
    {
        private uEye.Camera _Camera;

        IntPtr displayHandle = IntPtr.Zero;
        private bool bLive = false;
        private CustomPX.CustomPictureBox _FrameImage;

        public uEye.Camera Camera
        {
            get { return _Camera; }
        }
        public UICam() {
            //InitCamera();
        }

        public void InitCamera(ref CustomPX.CustomPictureBox ImageControl)
        {
            _Camera = new uEye.Camera();
            _Camera.Gain.Hardware.Factor.SetMaster(5);
            _Camera.Gain.Hardware.Factor.SetRed(20);
            _Camera.Gain.Hardware.Factor.SetGreen(20);
            _Camera.Gain.Hardware.Factor.SetBlue(20);
            _Camera.Saturation.Set(1);
            displayHandle = (IntPtr)ImageControl.Handle.ToInt32();
            uEye.Defines.Status statusRet = 0;


            // Open Camera
            statusRet = _Camera.Init();
            if (statusRet != uEye.Defines.Status.Success)
            {
                //MessageBox.Show("Camera initializing failed");
                Environment.Exit(-1);
            }

            // Allocate Memory
            statusRet = _Camera.Memory.Allocate();
            if (statusRet != uEye.Defines.Status.Success)
            {
                //MessageBox.Show("Allocate Memory failed");
                Environment.Exit(-1);
            }

            // Start Live Video
            statusRet = _Camera.Acquisition.Capture();
            if (statusRet != uEye.Defines.Status.Success)
            {
                //MessageBox.Show("Start Live Video failed");
            }
            else
            {
                bLive = true;
            }

            // Connect Event
            _Camera.EventFrame += onFrameEvent;

            //CB_Auto_Gain_Balance.Enabled = Camera.AutoFeatures.Software.Gain.Supported;
            //CB_Auto_White_Balance.Enabled = Camera.AutoFeatures.Software.WhiteBalance.Supported;
        }
        private void onFrameEvent(object sender, EventArgs e)
        {
            uEye.Camera Camera = sender as uEye.Camera;

            Int32 s32MemID;
            Camera.Memory.GetActive(out s32MemID);

            Camera.Display.Render(s32MemID, displayHandle, uEye.Defines.DisplayRenderMode.FitToWindow);
        }
        ~UICam() {
            _Camera.Exit();
        }
    }
}
