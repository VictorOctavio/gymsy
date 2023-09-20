using Microsoft.Extensions.Options;
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

           // => optionsBuilder.UseSqlServer("Server=DESKTOP-R1CB0VV\\SQLEXPRESS;Database=gymsy;Integrated Security=True;TrustServerCertificate=True;");
            // Settings
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1("instructor"));
            //Application.Run(new LoginDesing());
        }
    }
}