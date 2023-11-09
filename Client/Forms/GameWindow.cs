using Client.Classes.Managers;
using System.Windows.Forms;

namespace Client.Forms
{
    
    public partial class GameWindow : Form
    {
        GlobalManager globalManager;
        public GameWindow(GlobalManager inManager)
        {
            InitializeComponent();
            globalManager = inManager;
        }

        private void GameWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            globalManager.formManager.CheckIfAllFormsClosed();
        }
    }
}
