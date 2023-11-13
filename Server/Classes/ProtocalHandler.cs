using Newtonsoft.Json;
using Game.Networking;
using Server.Classes.Account;
using Server.Classes.Game;

namespace Server.Classes.Network
{
    internal class ProtocalHandler
    {
        public NetworkManager networkManager;
        public ProtocalHandler(NetworkManager inManager)
        {
            networkManager = inManager;
        }

        public static List<string> ParseArgs(string inArgs)
        {
            string[] parts = inArgs.Split(':');
            List<string> argsList = parts.ToList();
            return argsList;
        }

        public void HandleProtocol(ConnectedClient inClient, NetworkTransfer inData)
        {
            List<string> args = ParseArgs(inData.args);

            switch (inData.protocol)
            {
                // Handshake handling
                case "handshake":
                    networkManager.SendClientMessage(inClient, "login", "request");
                    Console.WriteLine("Client connected and completed handshake");
                    break;

                // Login handling
                case "login":
                    // CHeck if login was correct
                    if (networkManager.globalManager.authManager.AttemptLogin(args[0], args[1]))
                    {
                        // If correct respond to client with successful attempt
                        networkManager.SendClientMessage(inClient, "login", $"success:{args[0]}");

                        // Update the connected client's set username for future use
                        inClient.username = args[0];
                        networkManager.UpdateConnectedClient(inClient.clientID, inClient);
                        break;
                    }
                    else
                    {
                        // If incorrect respond to client with unsuccessful attempt
                        networkManager.SendClientMessage(inClient, "login", "failed");
                        break;
                    }

                // Account Creation Handling
                case "createaccount":
                    // Check if account was created and then reply to the client with the results
                    bool success = networkManager.globalManager.authManager.CreateAccount(args[0], args[1], args[2]);
                    networkManager.SendClientMessage(inClient, "createaccount", success.ToString());
                    break;

                case "characterrequest":
                    int characterIndex = int.Parse(args[0]);
                    UserAccount curUser = networkManager.globalManager.fileManager.GetAccountInfo(args[1])!;

                    Character targetChar = networkManager.globalManager.fileManager.GetCharacter(curUser.characters[characterIndex])!;
                    if (targetChar != null)
                    {
                        string jsonCharData = JsonConvert.SerializeObject(targetChar);
                        networkManager.SendClientMessage(inClient, "characterdata", jsonCharData);

                        break;
                    }
                    break;

                default:
                    Console.WriteLine($"Unknown protocol recieved: {inData.protocol}");
                    break;
            }
        }
    }
}
