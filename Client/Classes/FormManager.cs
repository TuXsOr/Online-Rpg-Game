using Client.Forms;

namespace Client.Classes
{
    internal class FormManager
    {
        internal GlobalManager globalManager;

        private ServerSelect? serverSelectForm;
        private Login? loginForm;
        private GameWindow? gameWindowForm;

        private List<Form> forms = new List<Form>();


        // Constructor | Update local globalManager reference and init forms
        public FormManager(GlobalManager inManager) { globalManager = inManager; InitForms(); forms[0].Show(); }


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

        }

        // Closes All forms
        public void CloseAllForms()
        {
            for (int i = 0; i < forms.Count; i++) { forms[i].Hide(); }
        }
    }
}
