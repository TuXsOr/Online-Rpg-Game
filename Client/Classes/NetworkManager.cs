using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;
using System.Text;
using Newtonsoft.Json;
using Game.Networking;
using System.Security.Cryptography;

namespace Client.Classes
{
    internal class NetworkManager
    {
        private GlobalManager globalManager;
        private ProtocolHandler protocolHandler;

        // Network Connection Properties
        internal string targetIP = "127.0.0.1";
        internal int targetPort = 8080;
        internal int bufferSize = 10240;

        // Client and stream declerations
        protected internal TcpClient? client;
        protected internal NetworkStream? stream;

        internal bool connected = false;

        // declare communication thread
        Thread? communicationThread; // Possibly can use this during disconnect(?)


        // Constructor
        public NetworkManager(GlobalManager inManager)
        {
            // Setup global manager reference and create new protocol handler with reference
            globalManager = inManager;
            protocolHandler = new ProtocolHandler(inManager);
        }

        
        // Attempt Connection
        public void ConnectToServer()
        {
            try
            {
                // Connect to server and get the stream
                client = new TcpClient(targetIP, targetPort);

                connected = true;

                // Setup and start thread to handle communication with the server
                communicationThread = new Thread(HandleCommunication);
                communicationThread.IsBackground = true;
                communicationThread.Name = "Communication Thread";
                communicationThread.Start();
            }
            catch (Exception ex) { Debug.WriteLine($"Error in network manager when attempting to connect to server. \n Error message: \n {ex}"); }
        }

        public void HandleCommunication()
        {
            try
            {
                stream = client!.GetStream(); // get the client's stream

                byte[] buffer = new byte[bufferSize]; // setup buffer
                int bytesRead;


                while (connected) // Replace true with some value that can be changed
                {
                    // Get how many bytes to read
                    bytesRead = stream.Read(buffer, 0, buffer.Length);

                    if (bytesRead > 0)
                    {
                        string readData = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        NetworkTransfer? inData = JsonConvert.DeserializeObject<NetworkTransfer>(readData);
                        if (inData != null)
                        {
                            Debug.WriteLine($"Received {inData.protocol}, with the following details: {inData.args}");
                            protocolHandler.HandleProtocol(inData.protocol, inData.args);
                        }
                        else
                        {
                            Debug.WriteLine("Recieved a Null transfer data");
                        }
                    }
                    else { Debug.WriteLine("No data recieved"); }

                }
            }
            catch (IOException)
            {
                connected = false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in Network Manager when handling communication. \n Error Message: \n {ex}");
            }
        }

        // Send message to server
        public void MessageServer(string outProtocol, string outArgs)
        {
            if (stream != null)
            {
                NetworkTransfer outTransfer = new NetworkTransfer();
                outTransfer.protocol = outProtocol;
                outTransfer.args = outArgs;

                string outJson = JsonConvert.SerializeObject(outTransfer);
                byte[] outData = Encoding.UTF8.GetBytes(outJson);

                stream.Write(outData);
            }
            else { Debug.WriteLine("Client Stream was null"); }
            
        }

        public void AttemptLogin(string username, string password)
        {
            string hashedPassword = HashString(password);
            string outPassword = hashedPassword.Replace("-", string.Empty).ToLower();
            MessageServer("login", $"{username}:{outPassword}");

        }

        public void CreateAccount(string username, string password, string email)
        {
            string hashedPassword = HashString(password);
            string outPassword = hashedPassword.Replace("-", string.Empty).ToLower();
            MessageServer("createaccount", $"{username}:{outPassword}:{email}");
        }

        public void Disconnect()
        {
            connected = false;
            
            client!.Close();
        }

        public string HashString(string inString)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inData = Encoding.UTF8.GetBytes(inString);
                byte[] hashBytes = sha256.ComputeHash(inData);

                return BitConverter.ToString(hashBytes);
            }
        }
    }
}
