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
    public partial class DeviceConfigForm : Form
    {
        public List<Device> dcfdeviceList = new List<Device>();
        public FlowLayoutPanel DeviceFLP
        {
            get { return deviceFlowLayoutPanel; }
        }
        public DeviceConfigForm()
        {
            InitializeComponent();
        }
        private void AddExistingDevices() {
            foreach (Device dev in dcfdeviceList) {
                DeviceProperties dp = new DeviceProperties();

                dp.Dev = dev;

                deviceFlowLayoutPanel.Controls.Add(dp);
            }
        }
        private void addDeviceButton_Click(object sender, EventArgs e)
        {
            deviceFlowLayoutPanel.Controls.Add(CreateDeviceProperties());
        }
        private DeviceProperties CreateDeviceProperties() 
        {
            return new DeviceProperties();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeviceConfigForm_Load(object sender, EventArgs e)
        {
            if (dcfdeviceList.Count > 0) {
                AddExistingDevices();
            }
        }
    }
}
