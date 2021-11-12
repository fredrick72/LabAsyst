using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabAsyst
{
    public partial class DeviceProperties : UserControl
    {
        private Device dev;
        private bool IDSet = false;

        public Device Dev
        {
            get { return dev; }
            set { dev = value; }
        }
        
        public DeviceProperties()
        {
            InitializeComponent();
        }

        private void setTargetPointButton_Click(object sender, EventArgs e)
        {
            TargetSetting TS = new TargetSetting();
            
            TS.ShowDialog();
            dev.TargetPoint = TS.Target;
            targetPointTextBox.Text = "X: " + TS.Target.X + "Y: " + TS.Target.Y; 
           

        }

        private void DeviceProperties_Load(object sender, EventArgs e)
        {
            setTargetPointButton.Enabled = false;
            if (dev != null) {
                string target = "";
                IDTextBox.TextChanged -= new System.EventHandler(this.IDTextBox_TextChanged);
                IDTextBox.Text = Dev.ID;
                IDSet = true;
                setTargetPointButton.Enabled = true;
                IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
                nameTextBox.Text = Dev.Name;
                manufacturerTextBox.Text = Dev.Manufacturer;
                target = "X: " + Dev.TargetPoint.X + " Y: " + Dev.TargetPoint.Y;
                targetPointTextBox.Text = target;
            }
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {
            dev = new Device(IDTextBox.Text);
            IDSet = true;
            setTargetPointButton.Enabled = true;

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IDSet)
            {
                dev.Name = nameTextBox.Text;
            }
            else {
                MessageBox.Show("Please set ID First");
                //redirect focus
                IDTextBox.Focus();
            }
        }

        private void manufacturerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IDSet)
            {
                dev.Manufacturer = manufacturerTextBox.Text;
            }
            else
            {
                MessageBox.Show("Please set ID First");
                //redirect focus
                IDTextBox.Focus();
            }
        }
    } 
}
