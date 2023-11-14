using Client.Classes;
using System.Diagnostics;

namespace Client.Forms
{
    internal partial class Login : Form
    {
        private FormManager formManager;

        public Login(FormManager inManager)
        {
            InitializeComponent();
            formManager = inManager;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            tabControl1.Enabled = false;
            loginButton.Enabled = false;
            formManager.globalManager.networkManager.AttemptLogin(usernameBox.Text, passwordBox.Text);
            Debug.WriteLine($"entered password '{passwordBox.Text}'");
            usernameBox.Text = string.Empty;
            passwordBox.Text = string.Empty;
            loginResult.Visible = false;
        }

        public void Reset()
        {
            tabControl1.Enabled = true;
            loginButton.Enabled = true;
            s_emailBox.Enabled = true;
            createAccountButton.Enabled = true;
            usernameBox.Text = string.Empty;
            passwordBox.Text = string.Empty;
            s_emailBox.Text = string.Empty;
            s_passwordBox.Text = string.Empty;
            s_usernameBox.Text = string.Empty;
            s_usernameBox.Enabled = true;
            s_passwordBox.Enabled = true;
            s_emailBox.Enabled = false;
            
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            tabControl1.Enabled = false;
            createAccountButton.Enabled = false;
            s_usernameBox.Enabled = false;
            s_passwordBox.Enabled = false;
            s_emailBox.Enabled = false;
            formManager.globalManager.networkManager.CreateAccount(s_usernameBox.Text.ToLower(), s_passwordBox.Text, s_emailBox.Text.ToLower());

        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            formManager.Invoke(new Action(() =>
            {
                formManager.SwitchForm("serverselect");
                formManager.globalManager.networkManager.Disconnect();
            }));
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            formManager.globalManager.ExitApp();
        }
    }
}
