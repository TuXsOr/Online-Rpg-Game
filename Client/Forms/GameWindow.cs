using Client.Classes;
using Client.Classes.Game;
using Client.Forms.Controls;
using Game.Classes;

namespace Client.Forms
{
    internal partial class GameWindow : Form
    {
        WorldManager worldManager;
        public Inventory inventory;
        List<DisplayTile> displayedTiles = new List<DisplayTile>();

        public GameWindow(WorldManager inManager, GlobalManager inGlobalManager)
        {
            InitializeComponent();
            worldManager = inManager;
            inventory = new Inventory(inGlobalManager);
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

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            if (inventory.Visible) { inventory.Hide(); inventory.Visible = false; }
            else { inventory.Show(); inventory.Visible = true; }
        }

        private void GameWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
