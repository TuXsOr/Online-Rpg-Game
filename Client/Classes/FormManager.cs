using Client.Forms;
<<<<<<< Updated upstream
=======
using System.Diagnostics;
using System.Windows.Forms;
>>>>>>> Stashed changes

namespace Client.Classes
{
    internal partial class FormManager : Form
    {
        internal GlobalManager globalManager;

        private ServerSelect? serverSelectForm;
<<<<<<< Updated upstream
        private Login? loginForm;
=======
        internal LoginForm? loginForm;
>>>>>>> Stashed changes
        private GameWindow? gameWindowForm;

        private List<Form> forms = new List<Form>();


        // Constructor | Update local globalManager reference and init forms
<<<<<<< Updated upstream
        public FormManager(GlobalManager inManager) { globalManager = inManager; InitForms(); forms[0].Show(); }
=======
        public FormManager(GlobalManager inManager)
        {
            InitializeComponent();
            globalManager = inManager;
            this.Show(); // There has to be a better way
            this.Hide();
        }
>>>>>>> Stashed changes


        // Initializing all the needed forms
        private void InitForms()
        {
            serverSelectForm = new ServerSelect(this); forms.Add(serverSelectForm);
<<<<<<< Updated upstream
            loginForm = new Login(this); forms.Add(loginForm);
            gameWindowForm = new GameWindow();
=======
            loginForm = new LoginForm(this); forms.Add(loginForm);
            gameWindowForm = new GameWindow(); forms.Add(gameWindowForm);

            serverSelectForm.Show();
>>>>>>> Stashed changes
        }

        // Switching forms
        public void SwitchForm(string newForm)
        {
<<<<<<< Updated upstream
=======
            Debug.WriteLine("Switching Menu Called");

            switch (newForm.ToLower())
            {
                case "login":
                    if (loginForm != null) { HideAllForms(); loginForm.Show(); }
                    else { Debug.WriteLine("Login Form Not Valid"); }
                    break;
>>>>>>> Stashed changes

        }

        // Closes All forms
        public void CloseAllForms()
        {
            for (int i = 0; i < forms.Count; i++) { forms[i].Hide(); }
        }

        public void ShowLoading()
        {
            this.Show();
        }

        public void UpdateLoadingDisplay(string inText, int inProgress)
        {
            displayText.Text = inText;
            loadingProgress.Value = inProgress;
        }
    }
}
