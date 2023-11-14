using Client.Classes;

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
            formManager.globalManager.networkManager.AttemptLogin(usernameBox.Text, passwordBox.Text.Replace("-", ""));
            usernameBox.Text = string.Empty;
            passwordBox.Text = string.Empty;
            loginResult.Visible = false;
        }

        public void Reset()
        {
            tabControl1.Enabled = true;
            loginButton.Enabled = true;
            createAccountButton.Enabled = true;
            usernameBox.Text = string.Empty;
            passwordBox.Text = string.Empty;
            s_emailBox.Text = string.Empty;
            s_passwordBox.Text = string.Empty;
            s_usernameBox.Text = string.Empty;
            s_usernameBox.Enabled = false;
            s_passwordBox.Enabled = false;
            s_emailBox.Enabled = false;
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            tabControl1.Enabled = false;
            createAccountButton.Enabled = false;
            s_usernameBox.Enabled = false;
            s_passwordBox.Enabled = false;
            s_emailBox.Enabled = false;
            formManager.globalManager.networkManager.CreateAccount(s_usernameBox.Text.ToLower(), s_passwordBox.Text.Replace("-", string.Empty), s_emailBox.Text.ToLower());

        }
    }
}
