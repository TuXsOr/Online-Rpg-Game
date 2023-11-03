using System.Net;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;

namespace Server.Classes.Network
{
    internal class NetworkManager
    {
        // Declare global manager to reference other managers as needed
        internal GlobalManager globalManager;

        // Setup default server configuration
        public IPAddress serverIP = IPAddress.Parse("127.0.0.1");
        public int serverPort = 80;
        private int bufferSize = 1024;
        private ProtocalHandler protocalHandler;

        // Declare the TCP listener
        public TcpListener? listener;

        internal List<ConnectedClient> connectedClients = new List<ConnectedClient>();


        // Constructor
        public NetworkManager(GlobalManager inManager)
        {
            globalManager = inManager;
            protocalHandler = new ProtocalHandler(this);
        }



        // Handling incoming clients
        public void AcceptConnections()
        {
            // Setup TCP listener and its parameters
            serverIP = IPAddress.Parse(globalManager.fileManager.serverConfig.serverIP);
            serverPort = globalManager.fileManager.serverConfig.serverPort;
            bufferSize = globalManager.fileManager.serverConfig.networkBufferSize;
            
            listener = new TcpListener(serverIP, serverPort);
            listener.Start();

            Console.WriteLine("Accepting Connections");

            int curIndex = 0; // Connected client index


            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            // This should be put in a try/catch statement
            // That could handle eny encountered errors and also provide additional debug
            // It might need help looping back around, perhaps add a legitimate condition in the while loop?
            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            while (true)
            {
                // Accept incoming clients
                TcpClient client = listener.AcceptTcpClient();

                // Make sure client connected
                if (client != null)
                {
                    // Create new connected client data
                    ConnectedClient newClient = new ConnectedClient();
                    newClient.tcpClient = client;
                    newClient.username = string.Empty;
                    newClient.clientID = curIndex;
                    curIndex++; // Move to next client index

                    // Add newly connected client to list of all connected clients
                    connectedClients.Add(newClient);

                    // Start client handling thread
                    Thread newClientThread = new Thread(HandleClient);
                    newClientThread.Start(newClient);

                    // Init Handshake with client
                    SendClientMessage(newClient, "handshake", "start");
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
                            protocalHandler.HandleProtocol(client, inData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Find better way of handling this.
                    // This should remove the client from the connected clients list
                    // And Close the thread
                    Console.WriteLine($"Error in NetworkManager Handle Client Thread. Message: \n{ex}");
                }
            }
        }


        // Message Target Client
        public void SendClientMessage(ConnectedClient inClient, string outProtocol, string outArgs)
        {
            NetworkTransfer outTransfer = new NetworkTransfer();
            outTransfer.protocol = outProtocol;
            outTransfer.args = outArgs;

            string outJson = JsonConvert.SerializeObject(outTransfer);
            byte[] outData = Encoding.UTF8.GetBytes(outJson);

            NetworkStream clientStream = inClient.tcpClient.GetStream();
            clientStream.Write(outData);
        }

        // Get index of client with id from the list of connected clients
        public int GetClientIndex(int clientID)
        {
            for (int i = 0; i <= connectedClients.Count; i++)
            {
                if (connectedClients[i].clientID == clientID)
                {
                    return i;
                }
            }
            return -1;
        }

        // Update a connected client's details on the server's end
        public void UpdateConnectedClient(int clientID, ConnectedClient clientInfo)
        {
            connectedClients.Add(clientInfo);
            connectedClients.RemoveAt(GetClientIndex(clientID));
        }
    }





    // Connected client class
    public class ConnectedClient
    {
        public TcpClient tcpClient { get; set; } = new TcpClient();
        public string username { get; set; } = string.Empty;
        public int clientID { get; set; }
    }


    // Serelized object used in sending and receieving data
    [Serializable]
    public class NetworkTransfer
    {
        public string protocol { get; set; } = "bungo";
        public string args { get; set; } = string.Empty;
    }
}
