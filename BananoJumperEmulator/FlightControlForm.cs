namespace BananoJumperEmulator
{
    using System;
    using System.Drawing;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using WindowsInput;

    public partial class FlightControlForm : Form
    {
        private readonly ProgramState state;

        private readonly VerticalRulerForm verticalRulerForm;

        private readonly HorizontalRulerForm horizontalRulerForm;

        private int fps = 0;

        private int fpsSecond = 0;

        private GameState prevGameState = new GameState();

        private GameState currentGameState = new GameState();

        private EventWaitHandle level1Processor = new AutoResetEvent(false);
        private EventWaitHandle level1Done = new AutoResetEvent(false);

        private EventWaitHandle level2Processor = new AutoResetEvent(false);
        private EventWaitHandle level2Done = new AutoResetEvent(false);

        private EventWaitHandle level3Processor = new AutoResetEvent(false);
        private EventWaitHandle level3Done = new AutoResetEvent(false);

        private readonly object syncRoot = new object();

        private bool stopAll = false;

        private InputSimulator inputSimulator = new InputSimulator();

        public FlightControlForm()
        {
            this.state = Program.State;
            InitializeComponent();
            verticalRulerForm = new VerticalRulerForm();
            horizontalRulerForm = new HorizontalRulerForm();

            Task.Run(() => ProcessLevel1());
            Task.Run(() => ProcessLevel2());
            Task.Run(() => ProcessLevel3());
            Task.Run(() => Work());
        }

        public static Bitmap GetDesktopImage(Rectangle rect)
        {
            var bmp = new Bitmap(rect.Width, rect.Height);
            using (var g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(rect.Location, Point.Empty, rect.Size, CopyPixelOperation.SourceCopy);
            }

            return bmp;
        }

        private void FlightControlForm_Load(object sender, EventArgs e)
        {
            verticalRulerForm.RecalcLevels += RecalcLevels;
            verticalRulerForm.Show();
            horizontalRulerForm.RecalcLevels += RecalcLevels;
            horizontalRulerForm.Show();
            stopButton.Enabled = false;
            if (state.FlightControlFormLocation != null)
            {
                this.Location = state.FlightControlFormLocation.Value;
            }
        }

        private void RecalcLevels(object sender, EventArgs e)
        {
            YLevel0Label.Text = state.YLevel0.ToString();
            YLevel1Label.Text = state.YLevel1.ToString();
            YLevel2Label.Text = state.YLevel2.ToString();
            YLevel3Label.Text = state.YLevel3.ToString();

            XLevelLabel.Text = state.XLevel.ToString();
        }

        private void FlightControlForm_Move(object sender, EventArgs e)
        {
            state.FlightControlFormLocation = this.Location;
        }

        private void FlightControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopAll = true;
            level2Processor.Set();
            level3Processor.Set();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            stopButton.Enabled = true;
            mainTimer.Enabled = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            mainTimer.Enabled = false;
            startButton.Enabled = true;
            stopButton.Enabled = false;
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            lock (syncRoot)
            {
                SuspendLayout();
                area0Picture.BackgroundImage = currentGameState.Level0Bitmap;
                area1Picture.BackgroundImage = currentGameState.Level1Bitmap;
                area2Picture.BackgroundImage = currentGameState.Level2Bitmap;
                area3Picture.BackgroundImage = currentGameState.Level3Bitmap;

                alarmLevel0Label.Visible = currentGameState.HaveLevel0Danger;
                alarmLevel1Label.Visible = currentGameState.HaveLevel1Platform;
                alarmLevel2Label.Visible = currentGameState.HaveLevel2Platform;
                alarmLevel3Label.Visible = currentGameState.HaveLevel3Platform;
                YMonkeyLabel.Text = $"{currentGameState.MonkeyPosition} / {currentGameState.MonkeyLevel}";
                YMonkeyLabel.ForeColor = currentGameState.MonkeyStable ? Color.DarkGreen : Color.DarkRed;
                jumpLabel.Visible = currentGameState.Jumped;
                fpsLabel.Text = currentGameState.FPS.ToString();
                ResumeLayout();
            }
        }

        private void Work()
        {
            while (true)
            {
                if (stopAll)
                {
                    break;
                }

                lock (syncRoot)
                {
                    prevGameState = currentGameState;
                    currentGameState = new GameState();

                    level1Done.Reset();
                    level2Done.Reset();
                    level3Done.Reset();

                    level1Processor.Set();
                    level2Processor.Set();
                    level3Processor.Set();

                    var level0Area = new Rectangle(state.XLevel, state.YLevel0 - 18, 50, 20);
                    var monkeyArea = GetDesktopImage(state.MonkeyArea);

                    currentGameState.Level0Bitmap = GetDesktopImage(level0Area);
                    currentGameState.HaveLevel0Danger = IsSomethingOnGround(currentGameState.Level0Bitmap);

                    currentGameState.MonkeyPosition = GetMonkeyPosition(state.MonkeyArea, monkeyArea);
                    currentGameState.MonkeyLevel = GetMonkeyLevel(currentGameState.MonkeyPosition);
                    currentGameState.MonkeyStable = Math.Abs(currentGameState.MonkeyPosition - prevGameState.MonkeyPosition) < 5;

                    if (prevGameState.Jumped)
                    {
                        inputSimulator.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.SPACE);
                    }

                    level1Done.WaitOne();
                    level2Done.WaitOne();
                    level3Done.WaitOne();

                    currentGameState.Jumped = Jump(prevGameState, currentGameState);

                    if (currentGameState.Jumped)
                    {
                        inputSimulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.SPACE);
                        inputSimulator.Keyboard.Sleep(10);
                        inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.SPACE);
                    }

                    var sec = DateTime.Now.Second;
                    if (sec == fpsSecond)
                    {
                        currentGameState.FPS = prevGameState.FPS;
                        fps++;
                    }
                    else
                    {
                        currentGameState.FPS = fps;
                        fps = 1;
                        fpsSecond = sec;
                    }
                }
            }
        }

        private void ProcessLevel1()
        {
            while (level1Processor.WaitOne())
            {
                if (stopAll)
                {
                    break;
                }

                var level1Area = new Rectangle(state.XLevel, state.YLevel1 - 2, 50, 20);
                currentGameState.Level1Bitmap = GetDesktopImage(level1Area);
                currentGameState.HaveLevel1Platform = IsPlatformHere(currentGameState.Level1Bitmap);
                level1Done.Set();
            }
        }

        private void ProcessLevel2()
        {
            while (level2Processor.WaitOne())
            {
                if (stopAll)
                {
                    break;
                }

                var level2Area = new Rectangle(state.XLevel, state.YLevel2 - 2, 50, 20);
                currentGameState.Level2Bitmap = GetDesktopImage(level2Area);
                currentGameState.HaveLevel2Platform = IsPlatformHere(currentGameState.Level2Bitmap);
                level2Done.Set();
            }
        }

        private void ProcessLevel3()
        {
            while (level3Processor.WaitOne())
            {
                if (stopAll)
                {
                    break;
                }

                var level3Area = new Rectangle(state.XLevel, state.YLevel3 - 2, 50, 20);
                currentGameState.Level3Bitmap = GetDesktopImage(level3Area);
                currentGameState.HaveLevel3Platform = IsPlatformHere(currentGameState.Level3Bitmap);
                level3Done.Set();
            }
        }

        private bool IsPlatformHere(Bitmap bitmap)
        {
            float count = 0;

            for (var x = 0; x < bitmap.Width; x++)
            {
                for (var y = 0; y < bitmap.Height; y++)
                {
                    var pixel = bitmap.GetPixel(x, y);

                    if (pixel.R >= 80 && pixel.R <= 130
                        && pixel.G >= 180 && pixel.G <= 220
                        && pixel.B >= 1 && pixel.B <= 100)
                    {
                        count++; // grass
                    }

                    if (pixel.R >= 70 && pixel.R <= 110
                      && pixel.G >= 60 && pixel.G <= 100
                      && pixel.B >= 50 && pixel.B <= 80)
                    {
                        count++; // dirt
                    }
                }
            }

            return count / (bitmap.Width * bitmap.Height) > 0.4;
        }

        private bool IsSomethingOnGround(Bitmap bitmap)
        {
            float count = 0;

            for (var x = 0; x < bitmap.Width; x++)
            {
                for (var y = 0; y < bitmap.Height; y++)
                {
                    var pixel = bitmap.GetPixel(x, y);

                    if (pixel.R <= 10
                        && pixel.G >= 130 && pixel.G <= 150
                        && pixel.B <= 10)
                    {
                        count++; // plant
                    }

                    if (pixel.R >= 170 && pixel.R <= 190
                      && pixel.G >= 170 && pixel.G <= 190
                      && pixel.B >= 160 && pixel.B <= 180)
                    {
                        count++; // stone
                    }
                }
            }

            return count / (bitmap.Width * bitmap.Height) > 0.1;
        }

        private int GetMonkeyPosition(Rectangle monkeyArea, Bitmap bitmap)
        {
            for (var y = bitmap.Height - 1; y >= 0; y--)
            {
                var count = 0;

                for (var x = 0; x < bitmap.Width; x++)
                {
                    var pixel = bitmap.GetPixel(x, y);

                    if (pixel.R >= 180 && pixel.R <= 200
                      && pixel.G >= 140 && pixel.G <= 158
                      && pixel.B >= 70 && pixel.B <= 80)
                    {
                        count++; // monkey body
                    }
                }

                if (count >= 10)
                {
                    return monkeyArea.Top + y + 25; // legs length
                }
            }

            return 0;
        }

        private int GetMonkeyLevel(int monkeyPos)
        {
            var monkeyLegs = monkeyPos;

            if (Math.Abs(monkeyLegs - state.YLevel0) < 5)
            {
                return 0;
            }

            if (Math.Abs(monkeyLegs - state.YLevel1) < 5)
            {
                return 1;
            }

            if (Math.Abs(monkeyLegs - state.YLevel2) < 5)
            {
                return 2;
            }

            if (Math.Abs(monkeyLegs - state.YLevel3) < 5)
            {
                return 3;
            }

            return -1;
        }

        private bool Jump(GameState oldState, GameState newState)
        {
            if (!newState.MonkeyStable)
            {
                return false;
            }

            if (newState.MonkeyLevel == 3)
            {
                if (!oldState.HaveLevel3Platform && newState.HaveLevel3Platform)
                {
                    return true;
                }

                return false;
            }

            if (newState.MonkeyLevel == 2)
            {
                if (newState.HaveLevel3Platform)
                {
                    return true;
                }

                if (!oldState.HaveLevel2Platform && newState.HaveLevel2Platform)
                {
                    return true;
                }

                return false;
            }

            if (newState.MonkeyLevel == 1)
            {
                if (newState.HaveLevel2Platform)
                {
                    return true;
                }

                if (!oldState.HaveLevel1Platform && newState.HaveLevel1Platform)
                {
                    return true;
                }

                return false;
            }

            if (newState.HaveLevel1Platform)
            {
                return true;
            }

            if (newState.HaveLevel0Danger)
            {
                return true;
            }

            return false;
        }
    }
}
