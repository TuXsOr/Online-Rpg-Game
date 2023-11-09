using System.Windows.Forms;

namespace Client.Classes.Managers
{
    public class GlobalManager : ApplicationContext
    {
        // Declare manager variables
        internal FormManager formManager;
       public GlobalManager()
        {
            formManager = new FormManager(this);
        }

        public void CloseApplication() { ExitThreadCore(); }
    }
}
