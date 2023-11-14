using Client.Forms;
using System.Windows.Forms;

namespace Client.Classes
{
    internal partial class FormManager : Form
    {
        internal GlobalManager globalManager;

        private ServerSelect? serverSelectForm;
        private Login? loginForm;
        private GameWindow? gameWindowForm;

        private List<Form> forms = new List<Form>();


        // Constructor | Update local globalManager reference and init forms
        public FormManager(GlobalManager inManager)
        {
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
            gameWindowForm = new GameWindow();
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

                default:
                    break;
            }
        }

        // Closes All forms
        public void CloseAllForms()
        {
            for (int i = 0; i < forms.Count; i++) { forms[i].Hide(); }
        }

        public void ShowLoadingWindow()
        {
            CloseAllForms();
            this.Show();
        }

        private void FormManager_Load(object sender, EventArgs e)
        {

        }
    }
}
