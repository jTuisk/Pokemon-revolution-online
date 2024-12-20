using System.Diagnostics;

namespace Pokemon_revolution_online_bot.Src.GUI
{
    public partial class HomeForm : Form
    {
        string pathToPROClient = "E:\\PROClient\\PROClient.exe";

        public Process GameProcess { get; private set; } = null;
        public IntPtr GameWindow { get; private set; } = IntPtr.Zero;

        public HomeForm()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            if(GameProcess == null)
            {
                GameProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = pathToPROClient, // Replace with your application
                        UseShellExecute = false
                    }
                };

                Console.WriteLine("HomeForm::StartGame: Staring the game!");
                GameProcess.Start();
                GameProcess.WaitForInputIdle(); // Wait for the app to initialize

                while (GameProcess.MainWindowHandle == IntPtr.Zero)
                {
                    Thread.Sleep(100); // Wait for the window handle
                    GameProcess.Refresh();
                }

                WindowStyleAdjuster.RemoveBorders(GameProcess.MainWindowHandle, 800, 600);
                WindowStyleAdjuster.SetParent(GameProcess.MainWindowHandle, gameScreenPanel.Handle);
                WindowStyleAdjuster.MoveWindow(GameProcess.MainWindowHandle, 0, 0, gameScreenPanel.Width, gameScreenPanel.Height, true);
                gameScreenPanel.Resize += (sender, e) =>
                {
                    WindowStyleAdjuster.MoveWindow(GameProcess.MainWindowHandle, 0, 0, gameScreenPanel.Width, gameScreenPanel.Height, true);
                };
                Console.WriteLine("HomeForm::StartGame: Game is started, resized, restyled and moved to correct location!");
            }
            else
            {
                Console.WriteLine("HomeForm::StartGame: Game is already running!");
            }
        }
    }
}
