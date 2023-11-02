using System.Net;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;

namespace Server.Classes.Network
{
    internal class NetworkManager
    {
        // Declare global manager to reference other managers as needed
        private GlobalManager globalManager;

        private int bufferSize = 1024;

        // Setup default server configuration
        public IPAddress serverIP = IPAddress.Parse("127.0.0.1");
        public int serverPort = 80;
        
        // Declare the TCP listener
        public TcpListener? listener;

        internal List<ConnectedClient> connectedClients = new List<ConnectedClient>();


        // Constructor
        public NetworkManager(GlobalManager inManager)
        {
            globalManager = inManager;
        }



        // Handling incoming clients
        public void AcceptConnections()
        {
            serverIP = IPAddress.Parse(globalManager.fileManager.serverConfig.serverIP);
            serverPort = globalManager.fileManager.serverConfig.serverPort;
            
            listener = new TcpListener(serverIP, serverPort);
            listener.Start();

            while (true)
            {
                // Accept incoming clients
                TcpClient client = listener.AcceptTcpClient();

                // Make sure client connected
                if (client != null)
                {
                    ConnectedClient newClient = new ConnectedClient();
                    newClient.tcpClient = client;
                    newClient.username = string.Empty;

                    // Add newly connected client to list of all connected clients
                    connectedClients.Add(newClient);


                    // Handle connected client
                    // Add some sort of handshake

                }
            }
        }


        public void HandleClient(object? inClient)
        {
            ConnectedClient client = (ConnectedClient)inClient!;


            // Make sure client is valid
            if (client != null)
            {

                try
                {
                    NetworkStream stream = client.tcpClient.GetStream();
                    byte[] buffer = new byte[bufferSize];

                    while (true)
                    {

                        // Gets the number of bytes to read (I'm pretty sure)
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);


                        // Check if client disconnected
                        if (bytesRead <= 0)
                        {
                            Console.WriteLine("Client Disconnected Sucessfully");
                            break;
                        }

                        // decode the received data
                        string dataReceived = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        NetworkTransfer? inData = JsonConvert.DeserializeObject<NetworkTransfer>(dataReceived);

                        // If the incoming data is not null
                        if (inData != null)
                        {
                            ProtocalHandler.HandleProtocol(client, inData);
                        }
                    }
                }
                catch
                {

                }
            }
        }
    }





    // Connected client class
    public class ConnectedClient
    {
        public TcpClient tcpClient { get; set; } = new TcpClient();
        public string username { get; set; } = string.Empty;
    }


    // Serelized object used in sending and receieving data
    [Serializable]
    public class NetworkTransfer
    {
        public string protocol { get; set; } = "bungo";
        public string args { get; set; } = string.Empty;
    }
}
