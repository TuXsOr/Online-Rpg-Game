using Client.Classes.Game;

namespace Client.Classes
{
    internal class GlobalManager : ApplicationContext
    {
        internal FormManager formManager;
        internal FileManager fileManager = new FileManager();
        internal NetworkManager networkManager;
        internal ProtocolHandler protocolHandler;
        internal WorldManager worldManager;

        // Constructor
        public GlobalManager()
        {
            protocolHandler = new ProtocolHandler(this);
            formManager = new FormManager(this);
            networkManager = new NetworkManager(this);
            worldManager = new WorldManager(this);
        }

        // Close Application Entirely
        public void ExitApp() { ExitThreadCore(); }
    }
}