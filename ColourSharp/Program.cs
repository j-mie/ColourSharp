using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aero_Visualizer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (IntPtr.Size == 4)
            {
                Console.WriteLine("Starting up in 32Bit");
            }
            else if (IntPtr.Size == 8)
            {
                Console.WriteLine("Starting up in 64Bit");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
