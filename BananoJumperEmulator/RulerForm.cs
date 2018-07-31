namespace BananoJumperEmulator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using WindowsInput;
    using WindowsInput.Native;

    public partial class RulerForm : Form
    {
        private readonly ProgramState state;

        InputSimulator inputSimulator;

        float lastLevel;

        public RulerForm()
        {
            this.state = Program.State;
            InitializeComponent();
            inputSimulator = new InputSimulator();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (state.FormLocation != null)
            {
                this.Location = state.FormLocation.Value;
            }

            if (state.FormSize != null)
            {
                this.Size = state.FormSize.Value;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            state.FormLocation = this.Location;
            state.FormSize = this.Size;
        }

        private float GetCurrentLevel(Point p)
        {
            return p.Y * 1000 / this.ClientSize.Height;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            var g = this.CreateGraphics();
            var height = this.ClientSize.Height;
            var width = this.ClientSize.Width;

            g.Clear(SystemColors.Control);

            var redPen = new Pen(Color.Red, 2);
            g.DrawRectangle(redPen, new Rectangle(1, 1, width - 2, height - 2));

            var groundPen = new Pen(Color.Brown, 2);
            if (state.LevelGround != 0)
            {
                var pos = state.LevelGround * height / 1000;
                g.DrawLine(groundPen, 0, pos, width, pos);
            }

            var platformPen = new Pen(Color.Blue, 2);
            if (state.LevelPlatform1 != 0)
            {
                var pos = state.LevelPlatform1 * height / 1000;
                g.DrawLine(platformPen, 0, pos, width, pos);
            }

            if (state.LevelPlatform2 != 0)
            {
                var pos = state.LevelPlatform2 * height / 1000;
                g.DrawLine(platformPen, 0, pos, width, pos);
            }

            if (state.LevelPlatform3 != 0)
            {
                var pos = state.LevelPlatform3 * height / 1000;
                g.DrawLine(platformPen, 0, pos, width, pos);
            }

            var scanLinePen = new Pen(Color.Green, 2);
            var scanPos = 0.5f * width;
            g.DrawLine(scanLinePen, scanPos, 0, scanPos, height);
        }

        private void NewLevelGroundMenu_Click(object sender, EventArgs e)
        {
            state.LevelGround = lastLevel;
            this.Invalidate();
        }

        private void NewLevelPlatform1Menu_Click(object sender, EventArgs e)
        {
            state.LevelPlatform1 = lastLevel;
            this.Invalidate();
        }

        private void NewLevelPlatform2Menu_Click(object sender, EventArgs e)
        {
            state.LevelPlatform2 = lastLevel;
            this.Invalidate();
        }

        private void NewLevelPlatform3Menu_Click(object sender, EventArgs e)
        {
            state.LevelPlatform3 = lastLevel;
            this.Invalidate();
        }

        private void DeleteLevelMenu_Click(object sender, EventArgs e)
        {
            if (Math.Abs(lastLevel - state.LevelGround) < 3)
            {
                state.LevelGround = 0;
            }

            if (Math.Abs(lastLevel - state.LevelPlatform1) < 3)
            {
                state.LevelPlatform1 = 0;
            }

            if (Math.Abs(lastLevel - state.LevelPlatform2) < 3)
            {
                state.LevelPlatform2 = 0;
            }

            if (Math.Abs(lastLevel - state.LevelPlatform3) < 3)
            {
                state.LevelPlatform3 = 0;
            }

            this.Invalidate();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            lastLevel = GetCurrentLevel(e.Location);

            positionMenu.Text = "Level: " + lastLevel;

            deleteLevelMenu.Enabled =
                Math.Abs(lastLevel - state.LevelGround) < 3
                || Math.Abs(lastLevel - state.LevelPlatform1) < 3
                || Math.Abs(lastLevel - state.LevelPlatform2) < 3
                || Math.Abs(lastLevel - state.LevelPlatform3) < 3;
        }
    }
}
