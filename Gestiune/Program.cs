using System;
using System.Linq;
using System.Windows.Forms;
using Gestiune.Forms.Splashscreen;
using Gestiune.Forms;

namespace Gestiune
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GestiuneSplashScreen splashScreen = new GestiuneSplashScreen();
            splashScreen.ShowDialog();
            Application.Run(new MainForm());
        }
    }
}
