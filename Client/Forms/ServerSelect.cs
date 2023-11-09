using Client.Classes.Managers;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class ServerSelect : Form
    {
        GlobalManager globalManager;
        public ServerSelect(GlobalManager inManager)
        {
            InitializeComponent();
            globalManager = inManager;
        }

        // Form Closing
        private void ServerSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.WriteLine("Closing Server Select Menu");
            globalManager.formManager.CheckIfAllFormsClosed();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            globalManager.CloseApplication();
        }
    }
}
