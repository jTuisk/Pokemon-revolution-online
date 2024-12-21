using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Formats.Tar;

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
            if (GameProcess == null)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (GameProcess == null)
            {
                Console.WriteLine("Game is not running!");
                return;
            }

            Rect rect = new Rect();
            GetWindowRect(GameProcess.MainWindowHandle, ref rect);

            int width = rect.Right - rect.Left;
            int height = rect.Bottom - rect.Top;

            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                graphics.CopyFromScreen(rect.Left, rect.Top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
            }

            string path = $"C:\\Users\\jtuis\\Desktop\\PRO_data\\{DateTime.Now.ToString("(dd_MMMM_hh_mm_ss_tt)")}.png";
            bmp.Save(path);
            Console.WriteLine($"HomeForm::button1_Click: Bitmap created! size: {bmp.Size}");
            Match(bmp);
        }

        private void Match(Bitmap bmp)
        {
            ushort[] pokemonIds = [10, 13, 18, 43, 63, 69]; // route 12 pokemons

            for(int i = 0; i < pokemonIds.Length; i++)
            {
                if(CheckForMatch(bmp, pokemonIds[i]))
                {
                    Console.WriteLine($"Pokemon {pokemonIds[i]} found!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Pokemon not {pokemonIds[i]} found!");
                }
            }
        }

        private bool CheckForMatch(Bitmap bmp, ushort pokemonId)
        {
            string pathToPokemon = $"C:\\Users\\jtuis\\Desktop\\Projects\\Pokemon-revolution-online\\Src\\Data\\Pokemon\\Pokemon_sprites\\{pokemonId}.png";
            Console.WriteLine(File.Exists(pathToPokemon) ? "File exists." : "File does not exist.");

            Mat pokemonPic = CvInvoke.Imread(pathToPokemon);
            Mat gamePic = bmp.ToMat();
            Mat gamePicPainted = bmp.ToMat();

            CvInvoke.CvtColor(gamePic, gamePic, Emgu.CV.CvEnum.ColorConversion.Rgba2Rgb);
            Console.WriteLine($"Pokemon depth: {pokemonPic.Depth}, gamePic: {gamePic.Depth}. Match: {pokemonPic.Depth == gamePic.Depth}");
            Console.WriteLine($"Pokemon Channels: {pokemonPic.NumberOfChannels}, gamePic Channels: {gamePic.NumberOfChannels}, Match: {pokemonPic.NumberOfChannels != gamePic.NumberOfChannels}");

            Mat templateOutput = new Mat();
            CvInvoke.MatchTemplate(gamePic, pokemonPic, templateOutput, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed);

            double minVal = 0.0d;
            double maxVal = 0.0d;
            Point minLoc = new Point();
            Point maxLoc = new Point();

            double threshold = 0.6;
            CvInvoke.MinMaxLoc(templateOutput, ref minVal, ref maxVal, ref minLoc, ref maxLoc);
            CvInvoke.Threshold(templateOutput, templateOutput, threshold, 1, Emgu.CV.CvEnum.ThresholdType.ToZero);

            var matches = templateOutput.ToImage<Gray, byte>();

            Console.WriteLine($"Matches: {matches.Size}");

            bool match = false;

            for (int i = 0; i < matches.Rows; i++)
            {
                for (int j = 0; j < matches.Cols; j++)
                {
                    if (matches[i, j].Intensity > (threshold - 0.01))
                    {
                        Console.WriteLine($"Match[{i},{j}]: {matches[i, j].Intensity}");
                        Point loc = new Point(j, i);
                        Rectangle box = new Rectangle(loc, pokemonPic.Size);
                        CvInvoke.Rectangle(gamePicPainted, box, new MCvScalar(0, 255, 0), 2);
                        match = true;
                    }
                }
            }

            //CvInvoke.Imshow("gamePic", gamePic);
            CvInvoke.Imshow("gamePicPainted", gamePicPainted);
            //CvInvoke.Imshow("pokemonPic", pokemonPic);
            //CvInvoke.Imshow("templateOutput", templateOutput);
            //CvInvoke.WaitKey();

            return match;
        }



        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetWindowRect(IntPtr hWnd, ref Rect rect);

        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }
    }
}
