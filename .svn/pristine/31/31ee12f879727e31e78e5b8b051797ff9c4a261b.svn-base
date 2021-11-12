using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Diagnostics;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;

namespace LabAsyst
{
    [Serializable]
    public class Device
    {
        private ImgAnalysis ia;
        private string id;
        private DataRow datarow;
        private la_mainDataSet deviceTableDS = new la_mainDataSet();
        private la_mainDataSetTableAdapters.la_deviceTableAdapter deviceTA = new la_mainDataSetTableAdapters.la_deviceTableAdapter();
        private la_mainDataSet.la_deviceDataTable deviceTable = new la_mainDataSet.la_deviceDataTable();
        private bool isSimulation = false;
        
       
        private PointF targetPoint;
        private CustomPX.CustomPictureBox cPX;

       
        private System.Windows.Forms.Timer imageCheckTimer;
        private int targetRadius = 30; 
        private string name;
        private string manufacturer;
        private status deviceStatus;
        private bool isActive;
        private long averageCyceTime;
        private long averageIdleTime;


        public enum status { waiting, busy, error, unknown };
        private List<long> runtimelist = new List<long>();
        private List<long> idletimelist = new List<long>();
        private int refreshInterval = 2000;


        private Stopwatch busysw = new Stopwatch();
        private Stopwatch idlesw = new Stopwatch();

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public ImgAnalysis Ia
        {
            get { return ia; }
            set { ia = value; }
        }
        public PointF TargetPoint
        {
            get { return targetPoint; }
            set { targetPoint = value; }
        }
        public int TargetRadius
        {
            get { return targetRadius; }
            set { targetRadius = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }    
        public status DeviceStatus
        {
            get { return deviceStatus; }
            set { deviceStatus = value; }
        }
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }
        public long AverageCyceTime
        {
            get { return averageCyceTime; }
            set { averageCyceTime = value; }
        }
        public long AverageIdleTime
        {
            get { return averageIdleTime; }
            set { averageIdleTime = value; }
        }
        public bool IsSimulation
        {
            get { return isSimulation; }
            set { isSimulation = value; }
        }
        public int RefreshInterval
            {
                get { return refreshInterval; }
                set { refreshInterval = value; }
            }
        public CustomPX.CustomPictureBox PictureBox
        {
            get { return cPX; }
            set { cPX = value; }
        }

        public Device() {

            ia = new ImgAnalysis();
            cPX = new CustomPX.CustomPictureBox();
            imageCheckTimer = new System.Windows.Forms.Timer();
            imageCheckTimer.Tick += new EventHandler(imageCheckTimer_Tick);
        }
        public Device(string ID) 
        {
            id = ID;
            ia = new ImgAnalysis();
            cPX = new CustomPX.CustomPictureBox();
            imageCheckTimer = new System.Windows.Forms.Timer();
            imageCheckTimer.Tick += new EventHandler(imageCheckTimer_Tick);
            
        }
        public void CheckDeviceStatus(Image<Gray, Byte> img) 
        {
            if (!isSimulation)
            {
                if (ia.DetectCircles(img))
                {
                    GetStatus(ia.DetectedCircle);
                }
            }
            else {
                GetStatusSim();
            }
            
        }
        private void GetStatus(CircleF[] target)
        {
            bool IsTargetVisible = false;
            //determine if a circle is inside target area
            foreach (CircleF circle in target) {
                if (Math.Pow(circle.Center.X - this.targetPoint.X, 2) + Math.Pow(circle.Center.Y - this.targetPoint.Y, 2) < (targetRadius * targetRadius))
                {
                    IsTargetVisible = true;
                }
            }
           if (IsTargetVisible) {
                deviceStatus = status.waiting;
                if (!idlesw.IsRunning) {
                    idlesw.Restart();
                }
                else if (busysw.IsRunning) { 
                //get elapsed time
                    CalculateTiming(busysw.ElapsedMilliseconds, "busy");
                    busysw.Stop();
                    busysw.Reset();
                }
            }
            else if (!IsTargetVisible)
            {
                deviceStatus = status.busy;
                if (!busysw.IsRunning) {
                    busysw.Restart();
                }
                else if (idlesw.IsRunning) { 
                //get elapsed Time
                    CalculateTiming(idlesw.ElapsedMilliseconds, "idle");
                    idlesw.Stop();
                    idlesw.Reset();
                }
            }
            else {
                deviceStatus = status.error;
            }

        }
        private void GetStatusSim() {
            Random rand = new Random();
            int currentValue;
            currentValue = rand.Next(1, 3);

            if (currentValue == 1) {
                deviceStatus = status.waiting;
                if (!idlesw.IsRunning) {
                    idlesw.Restart();
                }
                else if (busysw.IsRunning) { 
                //get elapsed time
                    CalculateTiming(busysw.ElapsedMilliseconds, "busy");
                    busysw.Stop();
                    busysw.Reset();
                }
            }
            else if (currentValue == 2)
            {
                deviceStatus = status.busy;
                if (!busysw.IsRunning) {
                    busysw.Restart();
                }
                else if (idlesw.IsRunning) { 
                //get elapsed Time
                    CalculateTiming(busysw.ElapsedMilliseconds, "idle");
                    idlesw.Stop();
                    idlesw.Reset();
                }
            }
            else {
                deviceStatus = status.error;
            }

        }

        private void CalculateTiming(long p, string type)
        {
            long runtimeTotal;
            long idletimeTotal;

            if (type.Equals("busy"))
            {
                runtimelist.Add(p);
                runtimeTotal = runtimelist.Sum();
                averageCyceTime = runtimeTotal / runtimelist.Count;
                deviceTable = (la_mainDataSet.la_deviceDataTable)deviceTableDS.Tables["la_device"];
                datarow = deviceTable.NewRow();
                datarow["la_device_id"] = this.id;
                datarow["la_device_name"] = this.name;
                datarow["la_device_manufacturer"] = this.manufacturer;
                datarow["la_device_runtime"] = p;
                datarow["la_device_date_entered"] = DateTime.Now;

                deviceTable.Rows.Add(datarow);

                deviceTA.Update(deviceTable);
                               
                
            }
            else {

                idletimelist.Add(p);
                idletimeTotal = idletimelist.Sum();
                averageIdleTime = idletimeTotal / idletimelist.Count;
            }
        }
        private void imageCheckTimer_Tick(object sender, EventArgs e)
        {
                CheckDeviceStatus(BitmapToEMGUImage(ImageToBitmap(cPX.Image)));
        }
        private Bitmap ImageToBitmap(Image sysdrawimg)
        {
            if (sysdrawimg != null)
            {
                return new System.Drawing.Bitmap(sysdrawimg);

            }
            else
            {
                return new System.Drawing.Bitmap(Properties.Resources.Image_Proc_Error);

            }

        }
        private Image<Gray, Byte> BitmapToEMGUImage(System.Drawing.Bitmap bmimg)
        {
            return new Image<Gray, Byte>(bmimg);
        }

        public void StartRecording(ref CustomPX.CustomPictureBox cpbx) {
            cPX = cpbx;
            imageCheckTimer.Interval = refreshInterval;
            imageCheckTimer.Start();
        }
        public void stopRecording() {
            imageCheckTimer.Stop();
        }
        public void StartSimulation() {
            imageCheckTimer.Interval = refreshInterval;
            imageCheckTimer.Start();
        }
        public void StopSimulation() {
            imageCheckTimer.Stop();
        }
    }
}
