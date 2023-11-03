using Newtonsoft.Json;
using Server.Classes.Account;
using Server.Classes.Game;
using System.Text;

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



        /////////////////////////////////
        // Character Data Handleing
        /////////////////////////////////

        public bool CreateCharacter(string inName)
        {
            string filepath = $"{serverConfig.serverDataPath}\\Characters\\{inName.ToLower()}.json";

            if (!File.Exists(filepath))
            {
                // Create and update new character data
                Character newCharacter = new Character();
                newCharacter.name = inName;
                newCharacter.inventory = serverConfig.startingItems;
                newCharacter.money = serverConfig.startingMoney;

                // Write to file
                UpdateCharacterData(inName, newCharacter);
                return true;
            }
            else { return false; }
        }


        // Update character data with new character data
        public void UpdateCharacterData(string inName, Character newData)
        {
            string filepath = $"{serverConfig.serverDataPath}\\Characters\\{inName.ToLower()}.json";

            string characterJson = JsonConvert.SerializeObject(newData);
            File.WriteAllText(filepath, characterJson);
        }



        /////////////////////////////////
        // User Data Handling
        /////////////////////////////////


        // Get user account data from username
        public UserAccount? GetAccountInfo(string username)
        {
            string filepath = $"{serverConfig.serverDataPath}\\{username}.json";
            
            // Check if account exists
            if (File.Exists(filepath))
            {
                string fileText = File.ReadAllText(filepath);
                UserAccount targetAccount = JsonConvert.DeserializeObject<UserAccount>(fileText)!;
                return targetAccount;
            }
            else { return null; }
        }

        public bool UpdateAccountData(string username, UserAccount newData)
        {
            string filepath = $"{serverConfig.serverDataPath}\\UserAccounts\\{username.ToLower()}.json";
            string newDataJson = JsonConvert.SerializeObject(newData);

            try
            {
                // Encrypt User Data before storeing user data
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error when Updating Account Data in File Manager. \n {ex}");
                return false;
            }
        }

        // Check if account exists
        public bool AccountExists(string username)
        {
            string filepath = $"{serverConfig.serverDataPath}\\Useraccounts\\{username.ToLower()}.json";
            return File.Exists(filepath);
        }
    }
}
