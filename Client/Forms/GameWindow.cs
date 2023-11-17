using Client.Classes.Game;

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
