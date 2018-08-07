namespace BananoJumperEmulator
{
    using System;
    using System.Drawing;

    public class ProgramState
    {
        public Point? VerticalRulerFormLocation { get; set; }

        public Size? VerticalRulerFormSize { get; set; }

        public Point? HorizontalRulerFormLocation { get; set; }

        public Point? FlightControlFormLocation { get; set; }

        public float LevelGround { get; set; }

        public float LevelPlatform1 { get; set; }

        public float LevelPlatform2 { get; set; }

        public float LevelPlatform3 { get; set; }

        public int YLevel0 { get; set; }

        public int YLevel1 { get; set; }

        public int YLevel2 { get; set; }

        public int YLevel3 { get; set; }

        public int XLevel { get; set; }

        public Rectangle MonkeyArea { get; set; }
    }
}
