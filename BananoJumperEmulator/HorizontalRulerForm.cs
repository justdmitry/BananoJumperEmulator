namespace BananoJumperEmulator
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class HorizontalRulerForm : Form
    {
        private readonly ProgramState state;

        public HorizontalRulerForm()
        {
            this.state = Program.State;
            InitializeComponent();
        }

        public event EventHandler RecalcLevels;

        protected void OnRecalcLevels()
        {
            var width = this.ClientSize.Width;
            state.XLevel = this.PointToScreen(new Point(width / 2, 0)).X;
            RecalcLevels?.Invoke(this, EventArgs.Empty);
        }

        private void HorizontalRulerForm_Load(object sender, EventArgs e)
        {
            if (state.HorizontalRulerFormLocation != null)
            {
                this.Location = state.HorizontalRulerFormLocation.Value;
            }

            OnRecalcLevels();
        }

        private void HorizontalRulerForm_Move(object sender, EventArgs e)
        {
            state.HorizontalRulerFormLocation = this.Location;

            OnRecalcLevels();
        }

        private void HorizontalRulerForm_Paint(object sender, PaintEventArgs e)
        {
            var g = this.CreateGraphics();
            var height = this.ClientSize.Height;
            var width = this.ClientSize.Width;

            g.Clear(SystemColors.Control);

            var redPen = new Pen(Color.Red, 2);
            g.DrawLine(redPen, width / 2, 0, width / 2, height);

            OnRecalcLevels();
        }
    }
}
