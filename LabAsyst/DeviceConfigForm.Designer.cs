namespace LabAsyst
{
    partial class DeviceConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addDeviceButton = new System.Windows.Forms.Button();
            this.deviceFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addDeviceButton
            // 
            this.addDeviceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDeviceButton.Location = new System.Drawing.Point(12, 12);
            this.addDeviceButton.Name = "addDeviceButton";
            this.addDeviceButton.Size = new System.Drawing.Size(38, 30);
            this.addDeviceButton.TabIndex = 0;
            this.addDeviceButton.Text = "+";
            this.addDeviceButton.UseVisualStyleBackColor = true;
            this.addDeviceButton.Click += new System.EventHandler(this.addDeviceButton_Click);
            // 
            // deviceFlowLayoutPanel
            // 
            this.deviceFlowLayoutPanel.AutoScroll = true;
            this.deviceFlowLayoutPanel.Location = new System.Drawing.Point(12, 48);
            this.deviceFlowLayoutPanel.Name = "deviceFlowLayoutPanel";
            this.deviceFlowLayoutPanel.Size = new System.Drawing.Size(760, 469);
            this.deviceFlowLayoutPanel.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(633, 523);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(139, 30);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // DeviceConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.deviceFlowLayoutPanel);
            this.Controls.Add(this.addDeviceButton);
            this.Name = "DeviceConfigForm";
            this.Text = "Device Config";
            this.Load += new System.EventHandler(this.DeviceConfigForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addDeviceButton;
        private System.Windows.Forms.FlowLayoutPanel deviceFlowLayoutPanel;
        private System.Windows.Forms.Button okButton;
    }
}