using System.Diagnostics;

namespace Client.Classes
{
    internal class ProtocolHandler
    {
        private GlobalManager globalManager;


        // Constructor
        public ProtocolHandler(GlobalManager inManager)
        {
            globalManager = inManager;
        }


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

<<<<<<< Updated upstream
=======
                case "login":
                    if (args[0] == "request")
                    {
                        // Invoke event with menu name
                        globalManager.formManager.Invoke(new Action(() => { globalManager.formManager.SwitchForm("login"); }));
                        break;
                    }
                    else if (args[0] == "success")
                    {
                        globalManager.formManager.Invoke(new Action(() =>
                        {
                            globalManager.formManager.UpdateLoadingDisplay("Retrieving character Data...", 0);
                            globalManager.networkManager.MessageServer("characterrequest", $"1:{args[1]}");
                        }));
                        break;
                    }
                    break;

                case "characterdata":


                    break;
                    

>>>>>>> Stashed changes
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
