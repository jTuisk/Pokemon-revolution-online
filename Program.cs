using Pokemon_revolution_online_bot.Src.GUI;

namespace Pokemon_revolution_online_bot
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());


            /*
             * Required Threads:
             *      Running in background (all time):
             *          Screen reader to recognize game state
             *          Bot tasks
             *          Data writer
             *          
             *      Running at certain game states:
             *          pokemon encounter:
             *              Pokemon recognition // untill pokemon is recognized
             *          seeking encounter:
             *              Build green path route where player can move (should this be done manaully?)
             *          
             * ????
                 * Read screen to recognize game state
                 * Image recognition
                 * Bot tasks
                 * database writer
                 * GUI update?
             */
        }
    }
}