namespace BananoJumperEmulator
{
    using System;
    using System.Drawing.Imaging;
    using System.Windows.Forms;

    public partial class FlightControlForm : Form
    {
        private readonly RulerForm rulerForm;

        public FlightControlForm()
        {
            InitializeComponent();
            rulerForm = new RulerForm();
        }

        public void RepositionSelf()
        {
            this.Top = rulerForm.Top;
            this.Left = rulerForm.Left + rulerForm.Width + 42;
        }

        private void FlightControlForm_Load(object sender, EventArgs e)
        {
            rulerForm.ResizeEnd += (s, args) => this.RepositionSelf();
            ShowRulerFormButton.Checked = true;
            rulerForm.Show();
            RepositionSelf();
            stopButton.Enabled = false;
        }

        private void IncreaseWidthButton_Click(object sender, EventArgs e)
        {
            rulerForm.Width += 10;
            RepositionSelf();
        }

        private void DecreaseWidthButton_Click(object sender, EventArgs e)
        {
            rulerForm.Width -= 10;
            rulerForm.Invalidate();
            RepositionSelf();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowRulerFormButton_CheckedChanged(object sender, EventArgs e)
        {
            rulerForm.Visible = (sender as CheckBox).Checked;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            rulerForm.Hide();
            mainTimer.Enabled = true;
            startButton.Enabled = false;
            stopButton.Enabled = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            mainTimer.Enabled = false;
            startButton.Enabled = true;
            stopButton.Enabled = false;
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            var fileName = "D:\\Temp\\" + DateTimeOffset.Now.Ticks + ".png";
            ScreenCapture.CaptureForegroundWindowToFile(fileName, ImageFormat.Png);
        }
    }
}
