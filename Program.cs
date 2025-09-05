using System.IO;

namespace InventoryDB
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if (!File.Exists("inventory.db")) {
                Application.Run(new FirstLaunch());
            }
            else
            {
                Application.Run(new Login());
            }
        }
    }
}