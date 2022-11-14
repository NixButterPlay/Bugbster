using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugbsterInjector
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process[] proc = Process.GetProcessesByName("RustClient");
            if(proc.Length == 1)
            {
                MessageBox.Show("RustClient has Successfully Founded... Running Bugbster Injector...");
                Thread.Sleep(5000);
            }
            else
            {
                MessageBox.Show("RustClient not Founded");
                Environment.Exit(1553);
            }
            Console.WriteLine("Waiting For Injection...");
            Console.Title = "Bugbster Injector Console";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BugbsterInjector());
        }
    }
}
