namespace LabAsyst
{
    partial class TargetSetting
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
            this.liveImagePictureBox = new CustomPX.CustomPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.xPosTextBox = new System.Windows.Forms.TextBox();
            this.yPosTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.liveImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // liveImagePictureBox
            // 
            this.liveImagePictureBox.Image = null;
            this.liveImagePictureBox.Location = new System.Drawing.Point(12, 12);
            this.liveImagePictureBox.Name = "liveImagePictureBox";
            this.liveImagePictureBox.Size = new System.Drawing.Size(320, 240);
            this.liveImagePictureBox.TabIndex = 0;
            this.liveImagePictureBox.TabStop = false;
            this.liveImagePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.liveImagePictureBox_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(179, 270);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(260, 270);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // xPosTextBox
            // 
            this.xPosTextBox.Location = new System.Drawing.Point(35, 272);
            this.xPosTextBox.Name = "xPosTextBox";
            this.xPosTextBox.Size = new System.Drawing.Size(47, 20);
            this.xPosTextBox.TabIndex = 5;
            // 
            // yPosTextBox
            // 
            this.yPosTextBox.Location = new System.Drawing.Point(111, 272);
            this.yPosTextBox.Name = "yPosTextBox";
            this.yPosTextBox.Size = new System.Drawing.Size(47, 20);
            this.yPosTextBox.TabIndex = 6;
            // 
            // TargetSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 303);
            this.Controls.Add(this.yPosTextBox);
            this.Controls.Add(this.xPosTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liveImagePictureBox);
            this.Name = "TargetSetting";
            this.Text = "Target Setting";
            this.Load += new System.EventHandler(this.TargetSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liveImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomPX.CustomPictureBox liveImagePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox xPosTextBox;
        private System.Windows.Forms.TextBox yPosTextBox;

    }
}