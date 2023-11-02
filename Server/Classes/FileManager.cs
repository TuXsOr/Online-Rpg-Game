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
                    string configRead = File.ReadAllText(filePath);
                    serverConfig = JsonConvert.DeserializeObject<ServerConfig>(configRead)!;
                    Console.WriteLine("Loaded Server Config");
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
}
