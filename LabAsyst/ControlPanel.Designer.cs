namespace LabAsyst
{
    partial class ControlPanel
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cpStatusStrip = new System.Windows.Forms.StatusStrip();
            this.systemStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deviceInfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.simulateCheckBox = new System.Windows.Forms.CheckBox();
            this.recordCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelUpdateFreqNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.devicePollFreqNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DeviceSetupButton = new System.Windows.Forms.Button();
            this.imageTuningButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.statsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.uiUpdatetimer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.currentImagePictureBox = new CustomPX.CustomPictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.yPosLabel = new System.Windows.Forms.Label();
            this.xPosLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maxRadiusTextBox = new System.Windows.Forms.TextBox();
            this.minRadiusTextBox = new System.Windows.Forms.TextBox();
            this.accumulatorThresholdTextBox = new System.Windows.Forms.TextBox();
            this.cannyThresholdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maxRadiusTrackBar = new System.Windows.Forms.TrackBar();
            this.minRadiusTrackBar = new System.Windows.Forms.TrackBar();
            this.accumThreshtrackBar = new System.Windows.Forms.TrackBar();
            this.cannyThreshTrackBar = new System.Windows.Forms.TrackBar();
            this.menuStrip1.SuspendLayout();
            this.cpStatusStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelUpdateFreqNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicePollFreqNumericUpDown)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentImagePictureBox)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxRadiusTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRadiusTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accumThreshtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyThreshTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1120, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cpStatusStrip
            // 
            this.cpStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemStatusLabel});
            this.cpStatusStrip.Location = new System.Drawing.Point(0, 555);
            this.cpStatusStrip.Name = "cpStatusStrip";
            this.cpStatusStrip.Size = new System.Drawing.Size(1120, 22);
            this.cpStatusStrip.TabIndex = 1;
            this.cpStatusStrip.Text = "statusStrip1";
            // 
            // systemStatusLabel
            // 
            this.systemStatusLabel.Name = "systemStatusLabel";
            this.systemStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.systemStatusLabel.Text = "..";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.errorsRichTextBox);
            this.groupBox1.Location = new System.Drawing.Point(540, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 510);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Errors";
            // 
            // errorsRichTextBox
            // 
            this.errorsRichTextBox.Location = new System.Drawing.Point(9, 33);
            this.errorsRichTextBox.Name = "errorsRichTextBox";
            this.errorsRichTextBox.Size = new System.Drawing.Size(223, 471);
            this.errorsRichTextBox.TabIndex = 1;
            this.errorsRichTextBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deviceInfoRichTextBox);
            this.groupBox2.Location = new System.Drawing.Point(290, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 510);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device Information";
            // 
            // deviceInfoRichTextBox
            // 
            this.deviceInfoRichTextBox.Location = new System.Drawing.Point(15, 33);
            this.deviceInfoRichTextBox.Name = "deviceInfoRichTextBox";
            this.deviceInfoRichTextBox.Size = new System.Drawing.Size(223, 471);
            this.deviceInfoRichTextBox.TabIndex = 0;
            this.deviceInfoRichTextBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.simulateCheckBox);
            this.groupBox3.Controls.Add(this.recordCheckBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.panelUpdateFreqNumericUpDown);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.devicePollFreqNumericUpDown);
            this.groupBox3.Controls.Add(this.DeviceSetupButton);
            this.groupBox3.Controls.Add(this.imageTuningButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 266);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control";
            // 
            // simulateCheckBox
            // 
            this.simulateCheckBox.AutoSize = true;
            this.simulateCheckBox.Location = new System.Drawing.Point(9, 195);
            this.simulateCheckBox.Name = "simulateCheckBox";
            this.simulateCheckBox.Size = new System.Drawing.Size(66, 17);
            this.simulateCheckBox.TabIndex = 7;
            this.simulateCheckBox.Text = "Simulate";
            this.simulateCheckBox.UseVisualStyleBackColor = true;
            this.simulateCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // recordCheckBox
            // 
            this.recordCheckBox.AutoSize = true;
            this.recordCheckBox.Location = new System.Drawing.Point(9, 172);
            this.recordCheckBox.Name = "recordCheckBox";
            this.recordCheckBox.Size = new System.Drawing.Size(61, 17);
            this.recordCheckBox.TabIndex = 6;
            this.recordCheckBox.Text = "Record";
            this.recordCheckBox.UseVisualStyleBackColor = true;
            this.recordCheckBox.CheckedChanged += new System.EventHandler(this.recordCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Panel Update Frequency:";
            // 
            // panelUpdateFreqNumericUpDown
            // 
            this.panelUpdateFreqNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.panelUpdateFreqNumericUpDown.Location = new System.Drawing.Point(176, 137);
            this.panelUpdateFreqNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.panelUpdateFreqNumericUpDown.Name = "panelUpdateFreqNumericUpDown";
            this.panelUpdateFreqNumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.panelUpdateFreqNumericUpDown.TabIndex = 4;
            this.panelUpdateFreqNumericUpDown.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.panelUpdateFreqNumericUpDown.ValueChanged += new System.EventHandler(this.panelUpdateFreqNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Device Update Frequency:";
            // 
            // devicePollFreqNumericUpDown
            // 
            this.devicePollFreqNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.devicePollFreqNumericUpDown.Location = new System.Drawing.Point(176, 110);
            this.devicePollFreqNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.devicePollFreqNumericUpDown.Name = "devicePollFreqNumericUpDown";
            this.devicePollFreqNumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.devicePollFreqNumericUpDown.TabIndex = 2;
            this.devicePollFreqNumericUpDown.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.devicePollFreqNumericUpDown.ValueChanged += new System.EventHandler(this.devicePollFreqNumericUpDown_ValueChanged);
            // 
            // DeviceSetupButton
            // 
            this.DeviceSetupButton.Location = new System.Drawing.Point(150, 33);
            this.DeviceSetupButton.Name = "DeviceSetupButton";
            this.DeviceSetupButton.Size = new System.Drawing.Size(116, 58);
            this.DeviceSetupButton.TabIndex = 1;
            this.DeviceSetupButton.Text = "Device Setup";
            this.DeviceSetupButton.UseVisualStyleBackColor = true;
            this.DeviceSetupButton.Click += new System.EventHandler(this.DeviceSetupButton_Click);
            // 
            // imageTuningButton
            // 
            this.imageTuningButton.Location = new System.Drawing.Point(6, 33);
            this.imageTuningButton.Name = "imageTuningButton";
            this.imageTuningButton.Size = new System.Drawing.Size(124, 58);
            this.imageTuningButton.TabIndex = 0;
            this.imageTuningButton.Text = "Image Tuning";
            this.imageTuningButton.UseVisualStyleBackColor = true;
            this.imageTuningButton.Click += new System.EventHandler(this.imageTuningButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.statsRichTextBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 299);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 238);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Statistics";
            // 
            // statsRichTextBox
            // 
            this.statsRichTextBox.Location = new System.Drawing.Point(6, 24);
            this.statsRichTextBox.Name = "statsRichTextBox";
            this.statsRichTextBox.Size = new System.Drawing.Size(260, 208);
            this.statsRichTextBox.TabIndex = 1;
            this.statsRichTextBox.Text = "";
            // 
            // uiUpdatetimer
            // 
            this.uiUpdatetimer.Interval = 1000;
            this.uiUpdatetimer.Tick += new System.EventHandler(this.uiUpdatetimer_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // currentImagePictureBox
            // 
            this.currentImagePictureBox.Image = null;
            this.currentImagePictureBox.Location = new System.Drawing.Point(790, 297);
            this.currentImagePictureBox.Name = "currentImagePictureBox";
            this.currentImagePictureBox.Size = new System.Drawing.Size(320, 240);
            this.currentImagePictureBox.TabIndex = 5;
            this.currentImagePictureBox.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.yPosLabel);
            this.groupBox5.Controls.Add(this.xPosLabel);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.maxRadiusTextBox);
            this.groupBox5.Controls.Add(this.minRadiusTextBox);
            this.groupBox5.Controls.Add(this.accumulatorThresholdTextBox);
            this.groupBox5.Controls.Add(this.cannyThresholdTextBox);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.maxRadiusTrackBar);
            this.groupBox5.Controls.Add(this.minRadiusTrackBar);
            this.groupBox5.Controls.Add(this.accumThreshtrackBar);
            this.groupBox5.Controls.Add(this.cannyThreshTrackBar);
            this.groupBox5.Location = new System.Drawing.Point(790, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(320, 266);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tuning";
            // 
            // yPosLabel
            // 
            this.yPosLabel.AutoSize = true;
            this.yPosLabel.Location = new System.Drawing.Point(272, 234);
            this.yPosLabel.Name = "yPosLabel";
            this.yPosLabel.Size = new System.Drawing.Size(13, 13);
            this.yPosLabel.TabIndex = 36;
            this.yPosLabel.Text = "..";
            // 
            // xPosLabel
            // 
            this.xPosLabel.AutoSize = true;
            this.xPosLabel.Location = new System.Drawing.Point(115, 234);
            this.xPosLabel.Name = "xPosLabel";
            this.xPosLabel.Size = new System.Drawing.Size(13, 13);
            this.xPosLabel.TabIndex = 35;
            this.xPosLabel.Text = "..";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Y Position:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "X Position:";
            // 
            // maxRadiusTextBox
            // 
            this.maxRadiusTextBox.Location = new System.Drawing.Point(156, 170);
            this.maxRadiusTextBox.Name = "maxRadiusTextBox";
            this.maxRadiusTextBox.Size = new System.Drawing.Size(42, 20);
            this.maxRadiusTextBox.TabIndex = 32;
            // 
            // minRadiusTextBox
            // 
            this.minRadiusTextBox.Location = new System.Drawing.Point(156, 119);
            this.minRadiusTextBox.Name = "minRadiusTextBox";
            this.minRadiusTextBox.Size = new System.Drawing.Size(42, 20);
            this.minRadiusTextBox.TabIndex = 31;
            // 
            // accumulatorThresholdTextBox
            // 
            this.accumulatorThresholdTextBox.Location = new System.Drawing.Point(156, 65);
            this.accumulatorThresholdTextBox.Name = "accumulatorThresholdTextBox";
            this.accumulatorThresholdTextBox.Size = new System.Drawing.Size(42, 20);
            this.accumulatorThresholdTextBox.TabIndex = 30;
            // 
            // cannyThresholdTextBox
            // 
            this.cannyThresholdTextBox.Location = new System.Drawing.Point(156, 17);
            this.cannyThresholdTextBox.Name = "cannyThresholdTextBox";
            this.cannyThresholdTextBox.Size = new System.Drawing.Size(42, 20);
            this.cannyThresholdTextBox.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Max Radius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Min Radius";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Accumulator Threshhold";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Canny Threshhold";
            // 
            // maxRadiusTrackBar
            // 
            this.maxRadiusTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::LabAsyst.Properties.Settings.Default, "MaxRadius", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.maxRadiusTrackBar.Location = new System.Drawing.Point(21, 186);
            this.maxRadiusTrackBar.Maximum = 100;
            this.maxRadiusTrackBar.Name = "maxRadiusTrackBar";
            this.maxRadiusTrackBar.Size = new System.Drawing.Size(104, 45);
            this.maxRadiusTrackBar.TabIndex = 24;
            this.maxRadiusTrackBar.Value = global::LabAsyst.Properties.Settings.Default.MaxRadius;
            this.maxRadiusTrackBar.ValueChanged += new System.EventHandler(this.maxRadiusTrackBar_ValueChanged);
            // 
            // minRadiusTrackBar
            // 
            this.minRadiusTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::LabAsyst.Properties.Settings.Default, "MinRadius", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.minRadiusTrackBar.Location = new System.Drawing.Point(21, 135);
            this.minRadiusTrackBar.Maximum = 100;
            this.minRadiusTrackBar.Name = "minRadiusTrackBar";
            this.minRadiusTrackBar.Size = new System.Drawing.Size(104, 45);
            this.minRadiusTrackBar.TabIndex = 23;
            this.minRadiusTrackBar.Value = global::LabAsyst.Properties.Settings.Default.MinRadius;
            this.minRadiusTrackBar.ValueChanged += new System.EventHandler(this.minRadiusTrackBar_ValueChanged);
            // 
            // accumThreshtrackBar
            // 
            this.accumThreshtrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::LabAsyst.Properties.Settings.Default, "AccumulatorTreshold", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.accumThreshtrackBar.Location = new System.Drawing.Point(21, 84);
            this.accumThreshtrackBar.Maximum = 200;
            this.accumThreshtrackBar.Name = "accumThreshtrackBar";
            this.accumThreshtrackBar.Size = new System.Drawing.Size(104, 45);
            this.accumThreshtrackBar.TabIndex = 22;
            this.accumThreshtrackBar.Value = global::LabAsyst.Properties.Settings.Default.AccumulatorTreshold;
            this.accumThreshtrackBar.ValueChanged += new System.EventHandler(this.accumThreshtrackBar_ValueChanged);
            // 
            // cannyThreshTrackBar
            // 
            this.cannyThreshTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::LabAsyst.Properties.Settings.Default, "CannyThreshold", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cannyThreshTrackBar.Location = new System.Drawing.Point(21, 33);
            this.cannyThreshTrackBar.Maximum = 200;
            this.cannyThreshTrackBar.Name = "cannyThreshTrackBar";
            this.cannyThreshTrackBar.Size = new System.Drawing.Size(104, 45);
            this.cannyThreshTrackBar.TabIndex = 21;
            this.cannyThreshTrackBar.Value = global::LabAsyst.Properties.Settings.Default.CannyThreshold;
            this.cannyThreshTrackBar.ValueChanged += new System.EventHandler(this.cannyThreshTrackBar_ValueChanged);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 577);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.currentImagePictureBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cpStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ControlPanel";
            this.Text = "Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlPanel_FormClosing);
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cpStatusStrip.ResumeLayout(false);
            this.cpStatusStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelUpdateFreqNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicePollFreqNumericUpDown)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentImagePictureBox)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxRadiusTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRadiusTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accumThreshtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyThreshTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip cpStatusStrip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox errorsRichTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox deviceInfoRichTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox recordCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown panelUpdateFreqNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown devicePollFreqNumericUpDown;
        private System.Windows.Forms.Button DeviceSetupButton;
        private System.Windows.Forms.Button imageTuningButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox statsRichTextBox;
        private System.Windows.Forms.ToolStripStatusLabel systemStatusLabel;
        private System.Windows.Forms.Timer uiUpdatetimer;
        private System.Windows.Forms.CheckBox simulateCheckBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private CustomPX.CustomPictureBox currentImagePictureBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label yPosLabel;
        private System.Windows.Forms.Label xPosLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maxRadiusTextBox;
        private System.Windows.Forms.TextBox minRadiusTextBox;
        private System.Windows.Forms.TextBox accumulatorThresholdTextBox;
        private System.Windows.Forms.TextBox cannyThresholdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar maxRadiusTrackBar;
        private System.Windows.Forms.TrackBar minRadiusTrackBar;
        private System.Windows.Forms.TrackBar accumThreshtrackBar;
        private System.Windows.Forms.TrackBar cannyThreshTrackBar;
    }
}