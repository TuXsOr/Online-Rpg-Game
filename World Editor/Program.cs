using World_Editor.Classes;

namespace World_Editor
{
    internal static class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            GlobalManager globalManager = new GlobalManager();

            Application.Run(globalManager);
        }
    }
}