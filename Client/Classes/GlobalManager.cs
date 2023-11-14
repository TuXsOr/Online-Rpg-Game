namespace Client.Classes
{
    internal class GlobalManager : ApplicationContext
    {
        internal FormManager formManager;
        internal FileManager fileManager = new FileManager();
        internal NetworkManager networkManager;
        internal ProtocolHandler protocolHandler;

        // Constructor
        public GlobalManager()
        {
            protocolHandler = new ProtocolHandler(this);
            formManager = new FormManager(this);
            networkManager = new NetworkManager(this);

        }

        // Close Application Entirely
        public void ExitApp() { ExitThreadCore(); }
    }
}