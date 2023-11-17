using Newtonsoft.Json;
using Server.Classes.Account;
using Game.Classes;
using System.Text.Json;
using System.Text;

namespace Server.Classes
{
    internal class FileManager
    {
        public ServerConfig serverConfig = new ServerConfig();

        // Constructor
        public FileManager() { LoadServerConfig(); SetupDataDirectory(); }


        public void SetupDataDirectory()
        {
            // Setup Data Directories
            Directory.CreateDirectory($"{serverConfig.serverDataPath}\\World");
            Directory.CreateDirectory($"{serverConfig.serverDataPath}\\Characters");
            Directory.CreateDirectory($"{serverConfig.serverDataPath}\\UserAccounts");
        }


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
                string configJson = JsonConvert.SerializeObject(tmpConfig, Formatting.Indented);

                File.WriteAllText(filePath, configJson);

                serverConfig = tmpConfig;
            }
        }


        /////////////////////////////////
        // World Data Handling
        /////////////////////////////////

        public World? GetWorldData(string inWorldName)
        {
            try
            {
                string filepath = $"{serverConfig.serverDataPath}\\World\\{inWorldName}.world";
                if (File.Exists(filepath))
                {
                    string readFile = File.ReadAllText(filepath);
                    World? targetWorld = JsonConvert.DeserializeObject<World>(readFile);
                    Console.WriteLine($"Retrieved world data for {inWorldName}.");
                    return targetWorld;
                }
                else { return null; }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error when loading {inWorldName}.world\nError Message:\n{ex}");
                return null;
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

            try
            {
                string characterJson = JsonConvert.SerializeObject(newData, Formatting.Indented);
                File.WriteAllText(filepath, characterJson);
                Console.WriteLine($"Updated {inName}");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }


        // Get Character Data
        public Character? GetCharacter(string inName)
        {
            string filepath = $"{serverConfig.serverDataPath}\\Characters\\{inName.ToLower()}.json";

            try
            {
                string readText = File.ReadAllText(filepath);
                Character? character = JsonConvert.DeserializeObject<Character>(readText);
                return character;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to retrieve character: {inName}.json\nError Message:\n{ex}");
                return null;
            }
        }



        /////////////////////////////////
        // User Data Handling
        /////////////////////////////////


        // Get user account data from username
        public UserAccount? GetAccountInfo(string username)
        {
            string filepath = $"{serverConfig.serverDataPath}\\UserAccounts\\{username.ToLower()}.usr";
            
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
            string filepath = $"{serverConfig.serverDataPath}\\UserAccounts\\{username.ToLower()}.usr";
            string newDataJson = JsonConvert.SerializeObject(newData, Formatting.Indented);
            // string encryptedJson = E_crypt.EncryptString(newDataJson, serverConfig.backupKey);

            try
            {
                File.WriteAllText(filepath, newDataJson);
                CreateCharacter(username);
                return true;
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
            string filepath = $"{serverConfig.serverDataPath}\\UserAccounts\\{username.ToLower()}.usr";
            return File.Exists(filepath);
        }
    }
}
