using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;
using System.Text;
using Newtonsoft.Json;

namespace Client.Classes
{
    internal class NetworkManager
    {
        private GlobalManager globalManager;

        // Network Connection Properties
        internal string targetIP = "127.0.0.1";
        internal int targetPort = 80;
        internal int bufferSize = 1024;

        // Client and stream declerations
        protected internal TcpClient? client;
        protected internal NetworkStream? stream;

        // declare communication thread
        Thread? communicationThread; // Possibly can use this during disconnect(?)


        // Constructor
        public NetworkManager(GlobalManager inManager) { globalManager = inManager; }

        
        // Attempt Connection
        public void ConnectToServer()
        {
            try
            {
                // Connect to server and get the stream
                client = new TcpClient(targetIP, targetPort);

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
                // Double check if using `!` correctly in the morning

                byte[] buffer = new byte[bufferSize]; // setup buffer
                int bytesRead;


                while (true) // Replace true with some value that can be changed
                {
                    // Get how many bytes to read
                    bytesRead = stream.Read(buffer, 0, buffer.Length);

                    if (bytesRead > 0)
                    {
                        string readData = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        NetworkTransfer inData = JsonConvert.DeserializeObject<NetworkTransfer>(readData);
                        Debug.WriteLine($"Received {inData.protocol}, with the following details: {inData.args}");
                    }
                    else { Debug.WriteLine("No data recieved"); }

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in Network Manager when handling communication. \n Error Message: \n {ex}");
            }
        }
    }
}
