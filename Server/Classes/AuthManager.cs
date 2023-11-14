using Server.Classes.Account;

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
            // Get user account info
            UserAccount targetAccount = globalManager.fileManager.GetAccountInfo(username.ToLower())!;

            Console.WriteLine($"Attempted login for user {username.ToLower()} using `{password}` as a password");

            // Check if target account exists
            if (targetAccount != null)
            {
                Console.WriteLine(targetAccount.password == password);
                if (targetAccount.password == password)
                {
                    return true;
                }
                else { return false; }
            }
            // If null, account does not exist
            else { return false; }
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
