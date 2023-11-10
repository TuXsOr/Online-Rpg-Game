using Client.Classes;

namespace Client
{
    internal static class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Setup Global Manager and then run it
            GlobalManager manager = new GlobalManager();
            Application.Run(manager);
        }
    }
}