using Client.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    internal partial class ServerSelect : Form
    {
        FormManager formManager;

        public ServerSelect(FormManager inManager)
        {
            InitializeComponent();
            formManager = inManager;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            formManager.globalManager.networkManager.targetIP = ipBox.Text;
            formManager.globalManager.networkManager.ConnectToServer();
        }
    }
}
