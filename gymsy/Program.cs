using System.Windows.Forms;

namespace gymsy
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Settings
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1("client"));
        }
    }
}