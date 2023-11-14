using System.Diagnostics;

namespace Client.Classes
{
    internal class ProtocolHandler
    {
        private GlobalManager globalManager;


        // Constructor
        public ProtocolHandler(GlobalManager inManager) { globalManager = inManager; }


        // Handle incoming protocol name
        public void HandleProtocol(string inProtocol, string inArgs)
        {
            List<string> args = ParseArgs(inArgs);

            switch (inProtocol)
            {
                case "handshake":
                    if (args[0] == "start")
                    {
                        globalManager.networkManager.MessageServer("handshake", "c");
                        break;
                    } else { break; }

                case "login":
                    switch (args[0].ToLower())
                    {
                        case "request":
                            globalManager.formManager.Invoke(new Action(() =>
                            {
                                globalManager.formManager.SwitchForm("login");
                            }));
                            break;

                        case "success":
                            globalManager.networkManager.MessageServer("characterrequest", args[1]);
                            globalManager.formManager.Invoke(new Action(() =>
                            {
                                globalManager.formManager.ShowLoadingWindow();
                            }));
                            // Add additional stuff for showing loading bar and window

                            break;

                        case "failed":
                            globalManager.formManager.Invoke(new Action(() =>
                            {
                                globalManager.formManager.loginForm!.loginResult.Text = "Failed!";
                                globalManager.formManager.loginForm!.loginResult.ForeColor = Color.Red;
                                globalManager.formManager.loginForm.loginResult.Visible = true;
                                globalManager.formManager.loginForm!.Reset();
                            }));
                            break;
                    } break;
                case "createaccount":
                    if (args[0] == "True")
                    {
                        globalManager.formManager.Invoke(new Action(() =>
                        {
                            globalManager.formManager.loginForm!.createAccountResult.Text = "Successful!";
                            globalManager.formManager.loginForm!.createAccountResult.ForeColor = Color.Green;
                            globalManager.formManager.loginForm!.createAccountResult.Visible = true;
                            globalManager.formManager.loginForm!.Reset();

                        }));
                        break;
                    }
                    else
                    {
                        globalManager.formManager.Invoke(new Action(() =>
                        {
                            globalManager.formManager.loginForm!.createAccountResult.Text = "Failed!";
                            globalManager.formManager.loginForm!.createAccountResult.ForeColor = Color.Red;
                            globalManager.formManager.loginForm!.createAccountResult.Visible = true;
                            globalManager.formManager.loginForm!.Reset();

                        }));
                        break;
                    }

                default:
                    Debug.WriteLine($"Recieved unknown protocol: {inProtocol}");
                    break;
            }
        }


        // Parse string into a list of strings
        private List<string> ParseArgs(string args)
        {
            if (args != string.Empty)
            {
                string[] argParts = args.Split(':');
                return argParts.ToList();
            }
            return new List<string>();
        }
    }
}
