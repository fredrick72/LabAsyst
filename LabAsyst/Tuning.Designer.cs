namespace LabAsyst
{
    partial class Tuning
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxRadiusTrackBar = new System.Windows.Forms.TrackBar();
            this.minRadiusTrackBar = new System.Windows.Forms.TrackBar();
            this.accumThreshtrackBar = new System.Windows.Forms.TrackBar();
            this.cannyThreshTrackBar = new System.Windows.Forms.TrackBar();
            this.cannyThresholdTextBox = new System.Windows.Forms.TextBox();
            this.accumulatorThresholdTextBox = new System.Windows.Forms.TextBox();
            this.minRadiusTextBox = new System.Windows.Forms.TextBox();
            this.maxRadiusTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.xPosLabel = new System.Windows.Forms.Label();
            this.yPosLabel = new System.Windows.Forms.Label();
            this.liveImagePictureBox = new CustomPX.CustomPictureBox();
            this.imageCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maxRadiusTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRadiusTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accumThreshtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyThreshTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(833, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 530);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "WebCam Resolution";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(154, 530);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "WebCam Format";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(730, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Canny Threshhold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(730, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Accumulator Threshhold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Min Radius";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(734, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Max Radius";
            // 
            // maxRadiusTrackBar
            // 
            this.maxRadiusTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::LabAsyst.Properties.Settings.Default, "MaxRadius", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.maxRadiusTrackBar.Location = new System.Drawing.Point(723, 218);
            this.maxRadiusTrackBar.Maximum = 100;
            this.maxRadiusTrackBar.Name = "maxRadiusTrackBar";
            this.maxRadiusTrackBar.Size = new System.Drawing.Size(104, 45);
            this.maxRadiusTrackBar.TabIndex = 8;
            this.maxRadiusTrackBar.Value = global::LabAsyst.Properties.Settings.Default.MaxRadius;
            this.maxRadiusTrackBar.ValueChanged += new System.EventHandler(this.maxRadiusTrackBar_ValueChanged);
            // 
            // minRadiusTrackBar
            // 
            this.minRadiusTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::LabAsyst.Properties.Settings.Default, "MinRadius", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.minRadiusTrackBar.Location = new System.Drawing.Point(723, 167);
            this.minRadiusTrackBar.Maximum = 100;
            this.minRadiusTrackBar.Name = "minRadiusTrackBar";
            this.minRadiusTrackBar.Size = new System.Drawing.Size(104, 45);
            this.minRadiusTrackBar.TabIndex = 7;
            this.minRadiusTrackBar.Value = global::LabAsyst.Properties.Settings.Default.MinRadius;
            this.minRadiusTrackBar.ValueChanged += new System.EventHandler(this.minRadiusTrackBar_ValueChanged);
            // 
            // accumThreshtrackBar
            // 
            this.accumThreshtrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::LabAsyst.Properties.Settings.Default, "AccumulatorTreshold", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.accumThreshtrackBar.Location = new System.Drawing.Point(723, 116);
            this.accumThreshtrackBar.Maximum = 200;
            this.accumThreshtrackBar.Name = "accumThreshtrackBar";
            this.accumThreshtrackBar.Size = new System.Drawing.Size(104, 45);
            this.accumThreshtrackBar.TabIndex = 6;
            this.accumThreshtrackBar.Value = global::LabAsyst.Properties.Settings.Default.AccumulatorTreshold;
            this.accumThreshtrackBar.ValueChanged += new System.EventHandler(this.accumThreshtrackBar_ValueChanged);
            // 
            // cannyThreshTrackBar
            // 
            this.cannyThreshTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::LabAsyst.Properties.Settings.Default, "CannyThreshold", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cannyThreshTrackBar.Location = new System.Drawing.Point(723, 65);
            this.cannyThreshTrackBar.Maximum = 200;
            this.cannyThreshTrackBar.Name = "cannyThreshTrackBar";
            this.cannyThreshTrackBar.Size = new System.Drawing.Size(104, 45);
            this.cannyThreshTrackBar.TabIndex = 5;
            this.cannyThreshTrackBar.Value = global::LabAsyst.Properties.Settings.Default.CannyThreshold;
            this.cannyThreshTrackBar.ValueChanged += new System.EventHandler(this.cannyThreshTrackBar_ValueChanged);
            // 
            // cannyThresholdTextBox
            // 
            this.cannyThresholdTextBox.Location = new System.Drawing.Point(858, 49);
            this.cannyThresholdTextBox.Name = "cannyThresholdTextBox";
            this.cannyThresholdTextBox.Size = new System.Drawing.Size(42, 20);
            this.cannyThresholdTextBox.TabIndex = 13;
            // 
            // accumulatorThresholdTextBox
            // 
            this.accumulatorThresholdTextBox.Location = new System.Drawing.Point(858, 97);
            this.accumulatorThresholdTextBox.Name = "accumulatorThresholdTextBox";
            this.accumulatorThresholdTextBox.Size = new System.Drawing.Size(42, 20);
            this.accumulatorThresholdTextBox.TabIndex = 14;
            // 
            // minRadiusTextBox
            // 
            this.minRadiusTextBox.Location = new System.Drawing.Point(858, 151);
            this.minRadiusTextBox.Name = "minRadiusTextBox";
            this.minRadiusTextBox.Size = new System.Drawing.Size(42, 20);
            this.minRadiusTextBox.TabIndex = 15;
            // 
            // maxRadiusTextBox
            // 
            this.maxRadiusTextBox.Location = new System.Drawing.Point(858, 202);
            this.maxRadiusTextBox.Name = "maxRadiusTextBox";
            this.maxRadiusTextBox.Size = new System.Drawing.Size(42, 20);
            this.maxRadiusTextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(746, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "X Position:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(746, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Y Position:";
            // 
            // xPosLabel
            // 
            this.xPosLabel.AutoSize = true;
            this.xPosLabel.Location = new System.Drawing.Point(855, 319);
            this.xPosLabel.Name = "xPosLabel";
            this.xPosLabel.Size = new System.Drawing.Size(13, 13);
            this.xPosLabel.TabIndex = 19;
            this.xPosLabel.Text = "..";
            // 
            // yPosLabel
            // 
            this.yPosLabel.AutoSize = true;
            this.yPosLabel.Location = new System.Drawing.Point(855, 346);
            this.yPosLabel.Name = "yPosLabel";
            this.yPosLabel.Size = new System.Drawing.Size(13, 13);
            this.yPosLabel.TabIndex = 20;
            this.yPosLabel.Text = "..";
            // 
            // liveImagePictureBox
            // 
            this.liveImagePictureBox.Image = null;
            this.liveImagePictureBox.Location = new System.Drawing.Point(14, 49);
            this.liveImagePictureBox.Name = "liveImagePictureBox";
            this.liveImagePictureBox.Size = new System.Drawing.Size(640, 480);
            this.liveImagePictureBox.TabIndex = 21;
            this.liveImagePictureBox.TabStop = false;
            // 
            // imageCheckTimer
            // 
            this.imageCheckTimer.Interval = 1000;
            this.imageCheckTimer.Tick += new System.EventHandler(this.imageCheckTimer_Tick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(275, 530);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "GigE Settings";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Tuning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 563);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.liveImagePictureBox);
            this.Controls.Add(this.yPosLabel);
            this.Controls.Add(this.xPosLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxRadiusTextBox);
            this.Controls.Add(this.minRadiusTextBox);
            this.Controls.Add(this.accumulatorThresholdTextBox);
            this.Controls.Add(this.cannyThresholdTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxRadiusTrackBar);
            this.Controls.Add(this.minRadiusTrackBar);
            this.Controls.Add(this.accumThreshtrackBar);
            this.Controls.Add(this.cannyThreshTrackBar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Tuning";
            this.Text = "Tuning";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tuning_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxRadiusTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRadiusTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accumThreshtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyThreshTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TrackBar cannyThreshTrackBar;
        private System.Windows.Forms.TrackBar accumThreshtrackBar;
        private System.Windows.Forms.TrackBar minRadiusTrackBar;
        private System.Windows.Forms.TrackBar maxRadiusTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cannyThresholdTextBox;
        private System.Windows.Forms.TextBox accumulatorThresholdTextBox;
        private System.Windows.Forms.TextBox minRadiusTextBox;
        private System.Windows.Forms.TextBox maxRadiusTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label xPosLabel;
        private System.Windows.Forms.Label yPosLabel;
        private CustomPX.CustomPictureBox liveImagePictureBox;
        private System.Windows.Forms.Timer imageCheckTimer;
        private System.Windows.Forms.Button button5;
    }
}

