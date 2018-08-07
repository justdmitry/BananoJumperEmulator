namespace BananoJumperEmulator
{
    partial class FlightControlForm
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
            System.Windows.Forms.Button endButton;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.XLevelLabel = new System.Windows.Forms.Label();
            this.YLevel3Label = new System.Windows.Forms.Label();
            this.YLevel2Label = new System.Windows.Forms.Label();
            this.YLevel1Label = new System.Windows.Forms.Label();
            this.YLevel0Label = new System.Windows.Forms.Label();
            this.area0Picture = new System.Windows.Forms.PictureBox();
            this.area1Picture = new System.Windows.Forms.PictureBox();
            this.area2Picture = new System.Windows.Forms.PictureBox();
            this.area3Picture = new System.Windows.Forms.PictureBox();
            this.fpsLabel = new System.Windows.Forms.Label();
            this.alarmLevel0Label = new System.Windows.Forms.Label();
            this.alarmLevel1Label = new System.Windows.Forms.Label();
            this.alarmLevel2Label = new System.Windows.Forms.Label();
            this.alarmLevel3Label = new System.Windows.Forms.Label();
            this.YMonkeyLabel = new System.Windows.Forms.Label();
            this.monkeyLevelLabel = new System.Windows.Forms.Label();
            this.jumpLabel = new System.Windows.Forms.Label();
            endButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.area0Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.area1Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.area2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.area3Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // endButton
            // 
            endButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            endButton.Location = new System.Drawing.Point(10, 348);
            endButton.Name = "endButton";
            endButton.Size = new System.Drawing.Size(181, 38);
            endButton.TabIndex = 99;
            endButton.Text = "End and Close";
            endButton.UseVisualStyleBackColor = true;
            endButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(12, 159);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 19);
            label1.TabIndex = 114;
            label1.Text = "FPS";
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(12, 183);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 19);
            label2.TabIndex = 116;
            label2.Text = "Monkey Y";
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(12, 207);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 19);
            label3.TabIndex = 118;
            label3.Text = "Monkey Lvl";
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(10, 259);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(181, 38);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopButton.Location = new System.Drawing.Point(10, 303);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(181, 38);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 30;
            this.mainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // XLevelLabel
            // 
            this.XLevelLabel.Location = new System.Drawing.Point(81, 11);
            this.XLevelLabel.Name = "XLevelLabel";
            this.XLevelLabel.Size = new System.Drawing.Size(80, 19);
            this.XLevelLabel.TabIndex = 100;
            this.XLevelLabel.Text = "label1";
            this.XLevelLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // YLevel3Label
            // 
            this.YLevel3Label.Location = new System.Drawing.Point(12, 38);
            this.YLevel3Label.Name = "YLevel3Label";
            this.YLevel3Label.Size = new System.Drawing.Size(63, 19);
            this.YLevel3Label.TabIndex = 101;
            this.YLevel3Label.Text = "label1";
            // 
            // YLevel2Label
            // 
            this.YLevel2Label.Location = new System.Drawing.Point(12, 68);
            this.YLevel2Label.Name = "YLevel2Label";
            this.YLevel2Label.Size = new System.Drawing.Size(63, 19);
            this.YLevel2Label.TabIndex = 102;
            this.YLevel2Label.Text = "label1";
            // 
            // YLevel1Label
            // 
            this.YLevel1Label.Location = new System.Drawing.Point(12, 98);
            this.YLevel1Label.Name = "YLevel1Label";
            this.YLevel1Label.Size = new System.Drawing.Size(63, 19);
            this.YLevel1Label.TabIndex = 103;
            this.YLevel1Label.Text = "label1";
            // 
            // YLevel0Label
            // 
            this.YLevel0Label.Location = new System.Drawing.Point(12, 128);
            this.YLevel0Label.Name = "YLevel0Label";
            this.YLevel0Label.Size = new System.Drawing.Size(63, 19);
            this.YLevel0Label.TabIndex = 104;
            this.YLevel0Label.Text = "label1";
            // 
            // area0Picture
            // 
            this.area0Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.area0Picture.Location = new System.Drawing.Point(81, 123);
            this.area0Picture.Name = "area0Picture";
            this.area0Picture.Size = new System.Drawing.Size(80, 24);
            this.area0Picture.TabIndex = 105;
            this.area0Picture.TabStop = false;
            // 
            // area1Picture
            // 
            this.area1Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.area1Picture.Location = new System.Drawing.Point(81, 93);
            this.area1Picture.Name = "area1Picture";
            this.area1Picture.Size = new System.Drawing.Size(80, 24);
            this.area1Picture.TabIndex = 106;
            this.area1Picture.TabStop = false;
            // 
            // area2Picture
            // 
            this.area2Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.area2Picture.Location = new System.Drawing.Point(81, 63);
            this.area2Picture.Name = "area2Picture";
            this.area2Picture.Size = new System.Drawing.Size(80, 24);
            this.area2Picture.TabIndex = 107;
            this.area2Picture.TabStop = false;
            // 
            // area3Picture
            // 
            this.area3Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.area3Picture.Location = new System.Drawing.Point(81, 33);
            this.area3Picture.Name = "area3Picture";
            this.area3Picture.Size = new System.Drawing.Size(80, 24);
            this.area3Picture.TabIndex = 108;
            this.area3Picture.TabStop = false;
            // 
            // fpsLabel
            // 
            this.fpsLabel.Location = new System.Drawing.Point(81, 154);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(80, 24);
            this.fpsLabel.TabIndex = 109;
            this.fpsLabel.Text = "?";
            this.fpsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alarmLevel0Label
            // 
            this.alarmLevel0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alarmLevel0Label.ForeColor = System.Drawing.Color.Red;
            this.alarmLevel0Label.Location = new System.Drawing.Point(167, 128);
            this.alarmLevel0Label.Name = "alarmLevel0Label";
            this.alarmLevel0Label.Size = new System.Drawing.Size(24, 19);
            this.alarmLevel0Label.TabIndex = 113;
            this.alarmLevel0Label.Text = "!!!";
            // 
            // alarmLevel1Label
            // 
            this.alarmLevel1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alarmLevel1Label.ForeColor = System.Drawing.Color.Red;
            this.alarmLevel1Label.Location = new System.Drawing.Point(167, 98);
            this.alarmLevel1Label.Name = "alarmLevel1Label";
            this.alarmLevel1Label.Size = new System.Drawing.Size(24, 19);
            this.alarmLevel1Label.TabIndex = 112;
            this.alarmLevel1Label.Text = "!!!";
            // 
            // alarmLevel2Label
            // 
            this.alarmLevel2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alarmLevel2Label.ForeColor = System.Drawing.Color.Red;
            this.alarmLevel2Label.Location = new System.Drawing.Point(167, 68);
            this.alarmLevel2Label.Name = "alarmLevel2Label";
            this.alarmLevel2Label.Size = new System.Drawing.Size(24, 19);
            this.alarmLevel2Label.TabIndex = 111;
            this.alarmLevel2Label.Text = "!!!";
            // 
            // alarmLevel3Label
            // 
            this.alarmLevel3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alarmLevel3Label.ForeColor = System.Drawing.Color.Red;
            this.alarmLevel3Label.Location = new System.Drawing.Point(167, 38);
            this.alarmLevel3Label.Name = "alarmLevel3Label";
            this.alarmLevel3Label.Size = new System.Drawing.Size(24, 19);
            this.alarmLevel3Label.TabIndex = 110;
            this.alarmLevel3Label.Text = "!!!";
            // 
            // YMonkeyLabel
            // 
            this.YMonkeyLabel.Location = new System.Drawing.Point(81, 178);
            this.YMonkeyLabel.Name = "YMonkeyLabel";
            this.YMonkeyLabel.Size = new System.Drawing.Size(80, 24);
            this.YMonkeyLabel.TabIndex = 115;
            this.YMonkeyLabel.Text = "?";
            this.YMonkeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monkeyLevelLabel
            // 
            this.monkeyLevelLabel.Location = new System.Drawing.Point(81, 202);
            this.monkeyLevelLabel.Name = "monkeyLevelLabel";
            this.monkeyLevelLabel.Size = new System.Drawing.Size(80, 24);
            this.monkeyLevelLabel.TabIndex = 117;
            this.monkeyLevelLabel.Text = "?";
            this.monkeyLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jumpLabel
            // 
            this.jumpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jumpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.jumpLabel.Location = new System.Drawing.Point(81, 226);
            this.jumpLabel.Name = "jumpLabel";
            this.jumpLabel.Size = new System.Drawing.Size(80, 24);
            this.jumpLabel.TabIndex = 119;
            this.jumpLabel.Text = "Jump!";
            this.jumpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlightControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 397);
            this.Controls.Add(this.jumpLabel);
            this.Controls.Add(label3);
            this.Controls.Add(this.monkeyLevelLabel);
            this.Controls.Add(label2);
            this.Controls.Add(this.YMonkeyLabel);
            this.Controls.Add(label1);
            this.Controls.Add(this.alarmLevel0Label);
            this.Controls.Add(this.alarmLevel1Label);
            this.Controls.Add(this.alarmLevel2Label);
            this.Controls.Add(this.alarmLevel3Label);
            this.Controls.Add(this.fpsLabel);
            this.Controls.Add(this.area3Picture);
            this.Controls.Add(this.area2Picture);
            this.Controls.Add(this.area1Picture);
            this.Controls.Add(this.area0Picture);
            this.Controls.Add(this.YLevel0Label);
            this.Controls.Add(this.YLevel1Label);
            this.Controls.Add(this.YLevel2Label);
            this.Controls.Add(this.YLevel3Label);
            this.Controls.Add(this.XLevelLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(endButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlightControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Flight Control";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightControlForm_FormClosing);
            this.Load += new System.EventHandler(this.FlightControlForm_Load);
            this.Move += new System.EventHandler(this.FlightControlForm_Move);
            ((System.ComponentModel.ISupportInitialize)(this.area0Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.area1Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.area2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.area3Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label XLevelLabel;
        private System.Windows.Forms.Label YLevel3Label;
        private System.Windows.Forms.Label YLevel2Label;
        private System.Windows.Forms.Label YLevel1Label;
        private System.Windows.Forms.Label YLevel0Label;
        private System.Windows.Forms.PictureBox area0Picture;
        private System.Windows.Forms.PictureBox area1Picture;
        private System.Windows.Forms.PictureBox area2Picture;
        private System.Windows.Forms.PictureBox area3Picture;
        private System.Windows.Forms.Label fpsLabel;
        private System.Windows.Forms.Label alarmLevel0Label;
        private System.Windows.Forms.Label alarmLevel1Label;
        private System.Windows.Forms.Label alarmLevel2Label;
        private System.Windows.Forms.Label alarmLevel3Label;
        private System.Windows.Forms.Label YMonkeyLabel;
        private System.Windows.Forms.Label monkeyLevelLabel;
        private System.Windows.Forms.Label jumpLabel;
    }
}