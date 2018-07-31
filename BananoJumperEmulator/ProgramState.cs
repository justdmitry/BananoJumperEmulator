namespace BananoJumperEmulator
{
    using System;
    using System.Drawing;

    public class ProgramState
    {
        public Point? FormLocation { get; set; }

        public Size? FormSize { get; set; }

        public float LevelGround { get; set; }

        public float LevelPlatform1 { get; set; }

        public float LevelPlatform2 { get; set; }

        public float LevelPlatform3 { get; set; }
    }
}
