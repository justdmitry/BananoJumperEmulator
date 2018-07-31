namespace BananoJumperEmulator
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;
    using Newtonsoft.Json;

    public static class Program
    {
        public static ProgramState State { get; private set; } = new ProgramState();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            var appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (appPath.EndsWith("\\bin\\Debug"))
            {
                appPath = Path.GetDirectoryName(appPath);
                appPath = Path.GetDirectoryName(appPath);
            }

            var configPath = Path.Combine(appPath, Application.ProductName + ".config.json");
            if (File.Exists(configPath))
            {
                var data = File.ReadAllText(configPath);
                State = JsonConvert.DeserializeObject<ProgramState>(data);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FlightControlForm());

            var newData = JsonConvert.SerializeObject(State);
            File.WriteAllText(configPath, newData);
        }
    }
}
