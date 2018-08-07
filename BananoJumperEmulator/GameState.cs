namespace BananoJumperEmulator
{
    using System.Drawing;

    public class GameState
    {
        public bool HaveLevel0Danger { get; set; }

        public bool HaveLevel1Platform { get; set; }

        public bool HaveLevel2Platform { get; set; }

        public bool HaveLevel3Platform { get; set; }

        public int MonkeyPosition { get; set; }

        public int MonkeyLevel { get; set; }

        public bool MonkeyStable { get; set; }

        public bool Jumped { get; set; }

        public Bitmap Level0Bitmap { get; set; }

        public Bitmap Level1Bitmap { get; set; }

        public Bitmap Level2Bitmap { get; set; }

        public Bitmap Level3Bitmap { get; set; }

        public int FPS { get; set; }
    }
}
