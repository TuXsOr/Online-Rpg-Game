using Client.Classes.Game;
using Game.Classes;

namespace Client.Classes
{
    internal class GlobalManager : ApplicationContext
    {
        internal FormManager formManager;
        internal FileManager fileManager = new FileManager();
        internal NetworkManager networkManager;
        internal ProtocolHandler protocolHandler;
        public WorldManager worldManager;
        public Renderer renderer;

        // Constructor
        public GlobalManager()
        {
            protocolHandler = new ProtocolHandler(this);
            formManager = new FormManager(this);
            networkManager = new NetworkManager(this);
            worldManager = new WorldManager(this);
            renderer = new Renderer(this);
        }

        // Close Application Entirely
        public void ExitApp() { ExitThreadCore(); }
    }
}