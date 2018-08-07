namespace BananoJumperEmulator
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class VerticalRulerForm : Form
    {
        private readonly ProgramState state;

        private float lastLevel;

        public VerticalRulerForm()
        {
            this.state = Program.State;
            InitializeComponent();
        }

        public event EventHandler RecalcLevels;

        protected void OnRecalcLevels()
        {
            var height = this.ClientSize.Height;
            var width = this.ClientSize.Width;
            state.YLevel0 = this.PointToScreen(new Point(0, (int)state.LevelGround * height / 1000)).Y;
            state.YLevel1 = this.PointToScreen(new Point(0, (int)state.LevelPlatform1 * height / 1000)).Y;
            state.YLevel2 = this.PointToScreen(new Point(0, (int)state.LevelPlatform2 * height / 1000)).Y;
            state.YLevel3 = this.PointToScreen(new Point(0, (int)state.LevelPlatform3 * height / 1000)).Y;

            state.MonkeyArea = this.RectangleToScreen(new Rectangle(width, 0, width + 50, height));

            RecalcLevels?.Invoke(this, EventArgs.Empty);
        }

        private void VerticalRulerForm_Load(object sender, EventArgs e)
        {
            if (state.VerticalRulerFormLocation != null)
            {
                this.Location = state.VerticalRulerFormLocation.Value;
            }

            if (state.VerticalRulerFormSize != null)
            {
                this.Size = state.VerticalRulerFormSize.Value;
            }

            OnRecalcLevels();
        }

        private void VerticalRulerForm_Move(object sender, EventArgs e)
        {
            state.VerticalRulerFormLocation = this.Location;
            OnRecalcLevels();
        }

        private void VerticalRulerForm_Resize(object sender, EventArgs e)
        {
            state.VerticalRulerFormSize = this.Size;
            Invalidate();
        }

        private float GetCurrentLevel(Point p)
        {
            return p.Y * 1000 / this.ClientSize.Height;
        }

        private void VerticalRulerForm_Paint(object sender, PaintEventArgs e)
        {
            var g = this.CreateGraphics();
            var height = this.ClientSize.Height;
            var width = this.ClientSize.Width;

            g.Clear(SystemColors.Control);

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

            OnRecalcLevels();
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

        private void VerticalRulerForm_MouseDown(object sender, MouseEventArgs e)
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
