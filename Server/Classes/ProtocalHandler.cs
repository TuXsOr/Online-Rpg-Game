using System.Net;
using System.Net.Sockets;

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
                case "handshake":
                    networkManager.SendClientMessage(inClient, "login", "request");
                    Console.WriteLine("Client connected and completed handshake");
                    break;

                case "login":
                    Console.WriteLine($"Client attempted login with: {inData.args}");
                    break;

                default:
                    break;
            }
        }
    }
}
