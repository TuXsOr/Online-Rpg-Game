using Server.Classes.Network;

namespace Server.Classes
{
    internal class GlobalManager
    {
        private bool running = false;

        // Manager declerations
        internal FileManager fileManager;
        internal NetworkManager networkManager;

        // During Construction create and store references to other needed manager classes
        public GlobalManager()
        {
            // instanstiate the other managers
            fileManager = new FileManager();
            networkManager = new NetworkManager(this);
        }

        public void StartServer()
        {
            Console.WriteLine("Starting Server");
            running = true;

            Thread networkThread = new Thread(networkManager.AcceptConnections);
            networkThread.IsBackground = true;
            networkThread.Start();

            Tick();
        }

        public void Tick()
        {
            while (running)
            {
                // Wait for next tick
                Thread.Sleep(fileManager.serverConfig.tickRate);
            }
        }
    }
}
