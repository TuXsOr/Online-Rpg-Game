using System.Diagnostics;

namespace Client.Classes
{
    internal class ProtocolHandler
    {
        private GlobalManager globalManager;


        // Constructor
        public ProtocolHandler(GlobalManager inManager) { globalManager = inManager; }


        // Handle incoming protocol name
        public void HandleProtocol(string inProtocol, string inArgs)
        {
            List<string> args = ParseArgs(inArgs);

            switch (inProtocol)
            {
                case "handshake":
                    if (args[0] == "start")
                    {
                        globalManager.networkManager.MessageServer("handshake", "c");
                        break;
                    } else { break; }

                case "login":
                    if (args[0] == "request") // If server is requesting login then switch to login screen
                    {
                        globalManager.formManager.Invoke(new Action(() =>
                        {
                            globalManager.formManager.SwitchForm("login");
                        }));
                        break;
                    }
                    else if (args[0] == "success")
                    {
                        globalManager.networkManager.MessageServer("characterrequest", args[1]);
                        globalManager.formManager.Invoke(new Action(() =>
                        {
                            globalManager.formManager.ShowLoadingWindow();
                        }));
                        // Add additional stuff for showing loading bar and window

                        break;
                    }
                    break;

                default:
                    Debug.WriteLine($"Recieved unknown protocol: {inProtocol}");
                    break;
            }
        }


        // Parse string into a list of strings
        private List<string> ParseArgs(string args)
        {
            if (args != string.Empty)
            {
                string[] argParts = args.Split(':');
                return argParts.ToList();
            }
            return new List<string>();
        }
    }
}
