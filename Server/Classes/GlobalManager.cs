using Server.Classes.Account;
using Server.Classes.Auth;
using Server.Classes.Game;
using Server.Classes.Network;

namespace Server.Classes
{
    internal class GlobalManager
    {
        private bool running = false;

        // Manager declerations
        internal FileManager fileManager;
        internal NetworkManager networkManager;
        internal AuthManager authManager;
        internal WorldManager worldManager;

        // During Construction create and store references to other needed manager classes
        public GlobalManager()
        {
            // instanstiate the other managers
            fileManager = new FileManager();
            networkManager = new NetworkManager(this);
            authManager = new AuthManager(this);
            worldManager = new WorldManager(this);
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

        public void CloseServer()
        {
            Environment.Exit(0);
        }
    }
}
