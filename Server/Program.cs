using Server.Classes;

namespace Server
{
    internal class Program
    {
        private static void Main()
        {
            GlobalManager manager = new GlobalManager();

            manager.StartServer();
        }
    }
}