namespace LabAsyst
{
    partial class DeviceProperties
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.targetPointTextBox = new System.Windows.Forms.TextBox();
            this.setTargetPointButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Device Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manufacturer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Target Point:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(96, 9);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(151, 20);
            this.IDTextBox.TabIndex = 4;
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(96, 35);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(151, 20);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Location = new System.Drawing.Point(96, 62);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(151, 20);
            this.manufacturerTextBox.TabIndex = 6;
            this.manufacturerTextBox.TextChanged += new System.EventHandler(this.manufacturerTextBox_TextChanged);
            // 
            // targetPointTextBox
            // 
            this.targetPointTextBox.Location = new System.Drawing.Point(96, 89);
            this.targetPointTextBox.Name = "targetPointTextBox";
            this.targetPointTextBox.Size = new System.Drawing.Size(86, 20);
            this.targetPointTextBox.TabIndex = 7;
            // 
            // setTargetPointButton
            // 
            this.setTargetPointButton.Location = new System.Drawing.Point(188, 87);
            this.setTargetPointButton.Name = "setTargetPointButton";
            this.setTargetPointButton.Size = new System.Drawing.Size(51, 23);
            this.setTargetPointButton.TabIndex = 8;
            this.setTargetPointButton.Text = "Set";
            this.setTargetPointButton.UseVisualStyleBackColor = true;
            this.setTargetPointButton.Click += new System.EventHandler(this.setTargetPointButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Location = new System.Drawing.Point(253, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(31, 43);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(13, 13);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "..";
            // 
            // DeviceProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.setTargetPointButton);
            this.Controls.Add(this.targetPointTextBox);
            this.Controls.Add(this.manufacturerTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeviceProperties";
            this.Size = new System.Drawing.Size(365, 119);
            this.Load += new System.EventHandler(this.DeviceProperties_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button setTargetPointButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label statusLabel;
        public System.Windows.Forms.TextBox IDTextBox;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox manufacturerTextBox;
        public System.Windows.Forms.TextBox targetPointTextBox;
    }
}
