using System.Net;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;
using Game.Networking;
using System.Diagnostics;

namespace Server.Classes.Network
{
    internal class NetworkManager
    {
        // Declare global manager to reference other managers as needed
        internal GlobalManager globalManager;

        // Setup default server configuration
        public IPAddress serverIP = IPAddress.Parse("0.0.0.0");
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
            int curIndex = 0; // Connected client index

            // Setup TCP listener and its parameters
            serverIP = IPAddress.Parse(globalManager.fileManager.serverConfig.serverIP);
            serverPort = globalManager.fileManager.serverConfig.serverPort;
            bufferSize = globalManager.fileManager.serverConfig.networkBufferSize;

            // Try and setup the TcpListner class and start listening
            try
            {
                listener = new TcpListener(IPAddress.Any, serverPort); // Why can't I parse a ip address string here?
                listener.Start();

                Console.WriteLine($"Accepting Connections on {serverIP}:{serverPort}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Encountered error Network Manager when binding to IP address.\nError Message:\n{ex.Message}");
            }


            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            // It might need help looping back around, perhaps add a legitimate condition in the while loop?
            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            while (true)
            {
                // Try to accept incoming connection and handle incoming client.
                try
                {
                    // Accept incoming clients
                    TcpClient client = listener!.AcceptTcpClient();

                    // Make sure client connected
                    if (client != null)
                    {
                        Console.WriteLine("Client Attempting Connection");

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
                    else { Console.WriteLine("Client failed to propperly connect"); }
                }
                catch (Exception ex)
                {
                    // There should be additonal error handling here
                    Console.WriteLine($"Encountered error Network Manager when accepting connection.\nError Message:\n{ex.Message}");
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
                            Debug.WriteLine($"##################### Args:\n{inData.args}");
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
}
