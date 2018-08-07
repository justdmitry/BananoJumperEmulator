namespace BananoJumperEmulator
{
    partial class HorizontalRulerForm
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
            this.SuspendLayout();
            // 
            // HorizontalRulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(136, 42);
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HorizontalRulerForm";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Horizontal Ruler";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.HorizontalRulerForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HorizontalRulerForm_Paint);
            this.Move += new System.EventHandler(this.HorizontalRulerForm_Move);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip mainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem newLevelGroundMenu;
        private System.Windows.Forms.ToolStripMenuItem newLevelPlatform1Menu;
        private System.Windows.Forms.ToolStripMenuItem newLevelPlatform2Menu;
        private System.Windows.Forms.ToolStripMenuItem newLevelPlatform3Menu;
        private System.Windows.Forms.ToolStripMenuItem deleteLevelMenu;
        private System.Windows.Forms.ToolStripMenuItem positionMenu;
    }
}

