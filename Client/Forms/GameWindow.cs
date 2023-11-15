using Client.Classes.Game;
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
    internal partial class GameWindow : Form
    {
        WorldManager worldManager;
        public GameWindow(WorldManager inManager)
        {
            InitializeComponent();
            worldManager = inManager;
        }

        public void UpdateCharacterData()
        {

        }

        public void UpdateWorldData()
        {

        }
    }
}
