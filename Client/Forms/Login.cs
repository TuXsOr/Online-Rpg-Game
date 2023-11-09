using Client.Classes.Managers;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class Login : Form
    {
        GlobalManager globalManager;
        public Login(GlobalManager inManager)
        {
            InitializeComponent();
            globalManager = inManager;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            globalManager.formManager.CheckIfAllFormsClosed();
        }
    }
}
