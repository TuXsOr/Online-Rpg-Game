using Newtonsoft.Json;

namespace Server.Classes
{
    internal class FileManager
    {
        public ServerConfig serverConfig = new ServerConfig();
        public FileManager() { LoadServerConfig(); }


        // Load server configuration into memory
        public void LoadServerConfig()
        {
            string filePath = $"{Directory.GetCurrentDirectory()}\\ServerConfig.json";
            if (File.Exists(filePath))
            {
                try
                {
                    serverConfig = JsonConvert.DeserializeObject<ServerConfig>(filePath)!;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Loading Server Config! \n Error: {ex}");
                }
            }
            else
            {
                ServerConfig tmpConfig = new ServerConfig();
                string configJson = JsonConvert.SerializeObject(tmpConfig);

                File.WriteAllText(filePath, configJson);

                serverConfig = tmpConfig;
            }
        }
    }


    // Server configuration class
    public class ServerConfig
    {
        public string serverIP {  get; set; } = "127.0.0.1";
        public int serverPort { get; set; } = 80;
    }
}
