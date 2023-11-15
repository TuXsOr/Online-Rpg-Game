using Client.Forms;
using System.Windows.Forms;

namespace Client.Classes
{
    internal partial class FormManager : Form
    {
        internal GlobalManager globalManager;

        private ServerSelect? serverSelectForm;
        internal Login? loginForm;
        internal GameWindow? gameWindowForm;

        private List<Form> forms = new List<Form>();


        // Constructor | Update local globalManager reference and init forms
        public FormManager(GlobalManager inManager)
        {
            InitializeComponent();
            globalManager = inManager;
            this.Show();
            this.Hide();
            InitForms();
            forms[0].Show();
        }


        // Initializing all the needed forms
        private void InitForms()
        {
            serverSelectForm = new ServerSelect(this); forms.Add(serverSelectForm);
            loginForm = new Login(this); forms.Add(loginForm);
            gameWindowForm = new GameWindow(globalManager.worldManager);
        }

        // Switching forms
        public void SwitchForm(string newForm)
        {
            switch (newForm)
            {
                case "login":
                    CloseAllForms();
                    loginForm!.Show();
                    break;

                case "gamewindow":
                    CloseAllForms();
                    gameWindowForm!.Show();
                    break;

                default:
                    break;
            }
        }

        // Closes All forms
        public void CloseAllForms()
        {
            for (int i = 0; i < forms.Count; i++) { forms[i].Hide(); }
        }


        // Showing loading window
        public void ShowLoadingWindow()
        {
            CloseAllForms();
            loginForm!.Reset();
            this.Show();
        }

        public void UpdateLoadingMenu(string displayText, int loadingProgress)
        {
            displayLabel.Text = displayText;
            loadingBar.Value = loadingProgress;
        }
    }
}
