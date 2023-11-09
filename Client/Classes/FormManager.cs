using Client.Forms;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;

namespace Client.Classes.Managers
{
    internal class FormManager
    {
        GlobalManager globalManager;

        // Setup Forms and list of forms
        private List<Form> forms = new List<Form>();
        private ServerSelect serverSelect;
        private Login loginForm;
        private GameWindow gameWindow;


        // Constructor
        public FormManager(GlobalManager inManager) { globalManager = inManager; InitForms(); serverSelect.Show(); }


        // Hiding all windows
        public void HideAllForms()
        {
            for (int i = 0; i < forms.Count; i++) { forms[i].Hide(); }
        }


        // Init forms and add them to the list of forms
        public void InitForms()
        {
            serverSelect = new ServerSelect(globalManager); forms.Add(serverSelect);
            loginForm = new Login(); forms.Add(loginForm);
            gameWindow = new GameWindow(); forms.Add(gameWindow);
        }


        // Check if all forms closed, if all are then exit the application
        public void CheckIfAllFormsClosed()
        {
            bool allClosed = false;

            for (int i = 0; i < forms.Count; i++) // Loop through forms
            {
                if (forms[i].Visible) // Check if current index is visible
                {
                    allClosed = true;
                    break;
                }
                else { }
            }

            if (allClosed) { globalManager.CloseApplication(); } // If all forms are closed then exit
        }
    }
}
