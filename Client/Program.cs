using Client.Classes.Managers;
using System;
using System.Windows.Forms;

namespace Client
{
    
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create global manager object and then run it
            GlobalManager manager = new GlobalManager();
            Application.Run(manager);

        }
    }
}
