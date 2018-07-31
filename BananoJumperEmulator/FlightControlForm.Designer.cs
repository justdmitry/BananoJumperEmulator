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
            System.Windows.Forms.Button IncreaseWidthButton;
            System.Windows.Forms.Button DecreaseWidthButton;
            System.Windows.Forms.Button endButton;
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.ShowRulerFormButton = new System.Windows.Forms.CheckBox();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            IncreaseWidthButton = new System.Windows.Forms.Button();
            DecreaseWidthButton = new System.Windows.Forms.Button();
            endButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IncreaseWidthButton
            // 
            IncreaseWidthButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            IncreaseWidthButton.Location = new System.Drawing.Point(10, 53);
            IncreaseWidthButton.Name = "IncreaseWidthButton";
            IncreaseWidthButton.Size = new System.Drawing.Size(181, 31);
            IncreaseWidthButton.TabIndex = 1;
            IncreaseWidthButton.Text = "Form width >>>";
            IncreaseWidthButton.Click += new System.EventHandler(this.IncreaseWidthButton_Click);
            // 
            // DecreaseWidthButton
            // 
            DecreaseWidthButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            DecreaseWidthButton.Location = new System.Drawing.Point(10, 90);
            DecreaseWidthButton.Name = "DecreaseWidthButton";
            DecreaseWidthButton.Size = new System.Drawing.Size(181, 31);
            DecreaseWidthButton.TabIndex = 2;
            DecreaseWidthButton.Text = "<<< Form width";
            DecreaseWidthButton.UseVisualStyleBackColor = true;
            DecreaseWidthButton.Click += new System.EventHandler(this.DecreaseWidthButton_Click);
            // 
            // endButton
            // 
            endButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            endButton.Location = new System.Drawing.Point(10, 308);
            endButton.Name = "endButton";
            endButton.Size = new System.Drawing.Size(181, 38);
            endButton.TabIndex = 99;
            endButton.Text = "End and Close";
            endButton.UseVisualStyleBackColor = true;
            endButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(10, 136);
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
            this.stopButton.Location = new System.Drawing.Point(10, 180);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(181, 38);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ShowRulerFormButton
            // 
            this.ShowRulerFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowRulerFormButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ShowRulerFormButton.Location = new System.Drawing.Point(10, 10);
            this.ShowRulerFormButton.Name = "ShowRulerFormButton";
            this.ShowRulerFormButton.Size = new System.Drawing.Size(181, 38);
            this.ShowRulerFormButton.TabIndex = 0;
            this.ShowRulerFormButton.Text = "Show/Hide Ruler Form";
            this.ShowRulerFormButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowRulerFormButton.UseVisualStyleBackColor = true;
            this.ShowRulerFormButton.CheckedChanged += new System.EventHandler(this.ShowRulerFormButton_CheckedChanged);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // FlightControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 357);
            this.Controls.Add(this.ShowRulerFormButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(endButton);
            this.Controls.Add(DecreaseWidthButton);
            this.Controls.Add(IncreaseWidthButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlightControlForm";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Flight Control";
            this.Load += new System.EventHandler(this.FlightControlForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ShowRulerFormButton;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
    }
}