using Server.Classes.Account;
using Server.Classes.Network;

namespace Server.Classes.Auth
{
    internal class AuthManager
    {
        GlobalManager globalManager;

        // Constructor
        public AuthManager(GlobalManager inManager)
        {
            globalManager = inManager;
        }


        // Login Handling
        internal bool AttemptLogin(string username, string password)
        {
            UserAccount targetAccount = globalManager.fileManager.GetAccountInfo(username)!;

            // Check if target account exists
            if (targetAccount != null)
            {
                if (targetAccount.password == password)
                {
                    Console.WriteLine($"{DateTime.Now}: {username} login attempt successful");
                    return true;
                }
                else
                {
                    Console.WriteLine($"{DateTime.Now}: {username} login attempt failed");
                    return false;
                }
            }
            // If null, account does not exist
            else
            {
                Console.WriteLine("Null User");
                return false;
            }
        }


        // Account Creation handling
        internal bool CreateAccount(string username, string password, string email)
        {
            // Check if account already exists
            if (!globalManager.fileManager.AccountExists(username))
            {
                try
                {
                    // Setup new account info
                    UserAccount newUser = new UserAccount();
                    newUser.username = username;
                    newUser.password = password;
                    newUser.email = email;
                    newUser.characters.Append(username);
                    newUser.flags.Add("u");

                    // Write account data to the users folder
                    globalManager.fileManager.UpdateAccountData(username, newUser);
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in Auth Manager with create Account: \n {ex}");
                    return false;
                }
            }
            else { return false; }
        }
    }
}
