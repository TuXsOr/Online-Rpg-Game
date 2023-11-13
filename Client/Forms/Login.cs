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
            loginButton.Enabled = false;
            formManager.globalManager.networkManager.AttemptLogin(usernameBox.Text.ToLower(), passwordBox.Text);
            usernameBox.Text = string.Empty;
            passwordBox.Text = string.Empty;
            usernameBox.Enabled = false;
            passwordBox.Enabled = false;
        }


    }
}
