using Game.Classes;
using Newtonsoft.Json;
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
                // Simple handshake
                case "handshake":
                    if (args[0] == "start")
                    {
                        globalManager.networkManager.MessageServer("handshake", "c");
                        break;
                    } else { break; }

                // Character Movement
                case "movement":
                    if (inArgs != "failed")
                    {
                        globalManager.formManager.Invoke(new Action(() =>
                        {
                            globalManager.worldManager.UpdateCharacterPosition( int.Parse(args[0]), int.Parse(args[1]) );
                        }));
                        break;
                    }
                    else { break; }

                // updating world data
                case "worldupdate":
                    if (inArgs != null || inArgs != string.Empty)
                    {
                        globalManager.formManager.Invoke(new Action(() =>
                        {
                            World? inWorld = JsonConvert.DeserializeObject<World>(inArgs!);

                            if (inWorld != null)
                            {
                                globalManager.worldManager.UpdateWorldData(inWorld);
                            }
                            else { }
                        }));
                        break;
                    }
                    else
                    {
                        break;
                    }

                // Receiving world data
                case "worlddata":
                    if (inArgs != null || inArgs != string.Empty)
                    {
                            globalManager.formManager.Invoke(new Action(() =>
                            {
                                World? inWorld = JsonConvert.DeserializeObject<World>(inArgs!);

                                if (inWorld != null)
                                {
                                    globalManager.formManager.UpdateLoadingMenu("Finished Loading!", 100);
                                    globalManager.worldManager.UpdateWorldData(inWorld);
                                    Thread.Sleep(100);
                                    globalManager.formManager.Hide();
                                    globalManager.formManager.SwitchForm("gamewindow");
                                }
                                else
                                {
                                    globalManager.formManager.UpdateLoadingMenu("Failed to load World Data", 0);
                                    globalManager.formManager.Hide();
                                    globalManager.formManager.SwitchForm("Login");
                                    globalManager.formManager.loginForm!.Reset();
                                }
                            }));
                        break;
                    }
                    else
                    {
                        break;
                    }

                // Receiving Character Data
                case "chardata":
                    if (inArgs != "failed")
                    {
                        globalManager.formManager.Invoke(new Action(() =>
                        {
                            Character inCharacter = JsonConvert.DeserializeObject<Character>(inArgs)!;
                            globalManager.worldManager.UpdateCharacterData(inCharacter);
                            
                            globalManager.formManager.UpdateLoadingMenu("Requesting World Data...", 75);
                            globalManager.networkManager.MessageServer("worldrequest", string.Empty);
                        }));

                        break;
                    }
                    else
                    {
                        Debug.WriteLine("Server failed to find character details");
                        globalManager.formManager.Invoke(new Action(() =>
                        {
                            globalManager.formManager.UpdateLoadingMenu("Failed to retrieve character Data", 0);
                            globalManager.formManager.loadingBar.Visible = false;
                        }));
                        break;
                    }

                // Logging into an account
                case "login":
                    switch (args[0].ToLower())
                    {
                        // Show login when a login is requested
                        case "request":
                            globalManager.formManager.Invoke(new Action(() =>
                            {
                                globalManager.formManager.SwitchForm("login");
                            }));
                            break;

                        // Successful Login
                        case "success":
                            
                            globalManager.formManager.Invoke(new Action(() =>
                            {
                                // Initial setup and display of loading window
                                globalManager.formManager.UpdateLoadingMenu("Logged in...", 0);
                                globalManager.formManager.ShowLoadingWindow();

                                // Update loading UI and request character data
                                globalManager.formManager.UpdateLoadingMenu("Retrieveing Character Data...", 25);
                                globalManager.networkManager.MessageServer("characterrequest", args[1]);

                            }));
                            // Add additional stuff for showing loading bar and window

                            break;

                        // Failed Login
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

                // Creating accounts
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
