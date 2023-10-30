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
            networkManager = new NetworkManager();
        }

        public void StartServer()
        {
            running = true;
            Console.WriteLine("Starting server");
        }
    }
}
