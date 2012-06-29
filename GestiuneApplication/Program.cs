using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestiuneApplication
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
            try
            {
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            { 
                var form = new AppCrashForm();
                form.SetDetails(ex, "Aplicatia s-a inchis din cauza unor erori, doriti sa o reporniti?");
                if (form.ShowDialog() == DialogResult.Yes)
                    Application.Run(new MainForm());
            }
        }
    }
}
