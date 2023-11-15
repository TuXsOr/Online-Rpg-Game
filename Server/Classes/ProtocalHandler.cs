using System.Net;
using System.Net.Sockets;
using System.Text;
using Game.Networking;
using Newtonsoft.Json;
using Server.Classes.Account;
using Game.Classes;

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
                    string comparingUsername = args[0];
                    string comparingPassword = args[1];
                    bool loginSuccess = networkManager.globalManager.authManager.AttemptLogin(comparingUsername, comparingPassword);
                    if (loginSuccess)
                    {
                        // If correct respond to client with successful attempt
                        networkManager.SendClientMessage(inClient, "login", $"success:{comparingUsername}");

                        // Update the connected client's set username for future use
                        inClient.username = comparingUsername;
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
                    Character? outCharacter = networkManager.globalManager.fileManager.GetCharacter(args[0]);

                    if (outCharacter != null)
                    {
                        string charJson = JsonConvert.SerializeObject(outCharacter);
                        networkManager.SendClientMessage(inClient, "chardata", charJson);

                        break;
                    }
                    else
                    {
                        networkManager.SendClientMessage(inClient, "chardata", "failed");
                        break;
                    }

                case "worldrequest":
                    string worldString = JsonConvert.SerializeObject(networkManager.globalManager.worldManager.world);
                    networkManager.SendClientMessage(inClient, "worlddata", worldString);
                    break;

                default:
                    Console.WriteLine($"Unknown protocol recieved: {inData.protocol}");
                    break;
            }
        }
    }
}
