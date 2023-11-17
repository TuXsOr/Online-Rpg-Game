using Client.Classes.Game;
using Client.Forms.Controls;
using Game.Classes;

namespace Client.Forms
{
    internal partial class GameWindow : Form
    {
        WorldManager worldManager;
        List<DisplayTile> displayedTiles = new List<DisplayTile>();

        public GameWindow(WorldManager inManager)
        {
            InitializeComponent();
            worldManager = inManager;
        }

        public void UpdateCharacterData()
        {

        }

        public void UpdateWorldData(World inWorld)
        {
            ClearTiles();
            int sizeX = inWorld.worldTiles.GetLength(0);
            int sizeY = inWorld.worldTiles.GetLength(1);

            for (int iX = 0; iX < sizeX; iX++)
            {
                for (int iY = 0; iY < sizeY; iY++)
                {
                    DisplayTile newTile = new DisplayTile(iX, iY, inWorld.worldTiles[iX, iY]);
                    TilePanel.Controls.Add(newTile);
                }
            }
        }

        private void ClearTiles()
        {
            for (int i = displayedTiles.Count - 1; i >= 0; i--)
            {
                TilePanel.Controls.Remove(displayedTiles[i]);
            }
            displayedTiles.Clear();
            displayedTiles = new List<DisplayTile>();
        }
    }
}
