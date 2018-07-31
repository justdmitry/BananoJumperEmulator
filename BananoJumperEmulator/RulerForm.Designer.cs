namespace BananoJumperEmulator
{
    partial class RulerForm
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
            System.Windows.Forms.ToolStripMenuItem newLevelToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
            this.newLevelGroundMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newLevelPlatform1Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.newLevelPlatform2Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.newLevelPlatform3Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteLevelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.positionMenu = new System.Windows.Forms.ToolStripMenuItem();
            newLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // newLevelToolStripMenuItem
            // 
            newLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLevelGroundMenu,
            this.newLevelPlatform1Menu,
            this.newLevelPlatform2Menu,
            this.newLevelPlatform3Menu});
            newLevelToolStripMenuItem.Name = "newLevelToolStripMenuItem";
            newLevelToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            newLevelToolStripMenuItem.Text = "New Level";
            // 
            // newLevelGroundMenu
            // 
            this.newLevelGroundMenu.Name = "newLevelGroundMenu";
            this.newLevelGroundMenu.Size = new System.Drawing.Size(129, 22);
            this.newLevelGroundMenu.Text = "Ground";
            this.newLevelGroundMenu.Click += new System.EventHandler(this.NewLevelGroundMenu_Click);
            // 
            // newLevelPlatform1Menu
            // 
            this.newLevelPlatform1Menu.Name = "newLevelPlatform1Menu";
            this.newLevelPlatform1Menu.Size = new System.Drawing.Size(129, 22);
            this.newLevelPlatform1Menu.Text = "Platform 1";
            this.newLevelPlatform1Menu.Click += new System.EventHandler(this.NewLevelPlatform1Menu_Click);
            // 
            // newLevelPlatform2Menu
            // 
            this.newLevelPlatform2Menu.Name = "newLevelPlatform2Menu";
            this.newLevelPlatform2Menu.Size = new System.Drawing.Size(129, 22);
            this.newLevelPlatform2Menu.Text = "Platform 2";
            this.newLevelPlatform2Menu.Click += new System.EventHandler(this.NewLevelPlatform2Menu_Click);
            // 
            // newLevelPlatform3Menu
            // 
            this.newLevelPlatform3Menu.Name = "newLevelPlatform3Menu";
            this.newLevelPlatform3Menu.Size = new System.Drawing.Size(129, 22);
            this.newLevelPlatform3Menu.Text = "Platform 3";
            this.newLevelPlatform3Menu.Click += new System.EventHandler(this.NewLevelPlatform3Menu_Click);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // mainContextMenu
            // 
            this.mainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            newLevelToolStripMenuItem,
            this.deleteLevelMenu,
            toolStripSeparator1,
            this.positionMenu});
            this.mainContextMenu.Name = "mainContextMenu";
            this.mainContextMenu.Size = new System.Drawing.Size(138, 76);
            // 
            // deleteLevelMenu
            // 
            this.deleteLevelMenu.Name = "deleteLevelMenu";
            this.deleteLevelMenu.Size = new System.Drawing.Size(137, 22);
            this.deleteLevelMenu.Text = "Delete Level";
            this.deleteLevelMenu.Click += new System.EventHandler(this.DeleteLevelMenu_Click);
            // 
            // positionMenu
            // 
            this.positionMenu.Enabled = false;
            this.positionMenu.Name = "positionMenu";
            this.positionMenu.Size = new System.Drawing.Size(137, 22);
            this.positionMenu.Text = "Position:";
            // 
            // RulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(775, 406);
            this.ContextMenuStrip = this.mainContextMenu;
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RulerForm";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.mainContextMenu.ResumeLayout(false);
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

