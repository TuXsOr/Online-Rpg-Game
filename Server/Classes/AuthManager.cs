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



        internal bool AttemptLogin(string username, string password)
        {
            // Get user account info
            UserAccount targetAccount = globalManager.fileManager.GetAccountInfo(username)!;

            // Check if target account exists
            if (targetAccount != null)
            {
                return targetAccount.password == password;
            }
            // If null, account does not exist
            else { return false; }
        }



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
                    newUser.characters.Add(username);

                    // Write account data to the users folder
                    globalManager.fileManager.UpdateAccountData(username, newUser);
                    globalManager.fileManager.CreateCharacter(username);
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
