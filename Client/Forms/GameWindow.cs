using Client.Classes;
using Client.Classes.Game;
using Client.Forms.Controls;
using Game.Classes;
using System.Diagnostics;

namespace Client.Forms
{
    internal partial class GameWindow : Form
    {
        GlobalManager globalManager;
        public Inventory? inventory;
        List<DisplayTile> displayedTiles = new List<DisplayTile>();

        public GameWindow(GlobalManager inGlobalManager)
        {
            InitializeComponent();
            globalManager = inGlobalManager;
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
                    Image? image = globalManager.renderer.GetImage(inWorld.worldTiles[iX, iY].displayChar);
                    
                    if (image != null)
                    {
                        DisplayTile newTile = new DisplayTile(iX, iY, inWorld.worldTiles[iX, iY], image);
                        TilePanel.Controls.Add(newTile);
                    }
                    else { Debug.WriteLine("Null Image when drawing tiles"); }
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
            if (inventory != null)
            {
                if (inventory.Visible) { inventory.Hide(); inventory.Visible = false; }
                else { inventory.Show(); inventory.Visible = true; }
            }
            else
            {
                inventory = new Inventory(globalManager);

                if (inventory.Visible) { inventory.Hide(); inventory.Visible = false; }
                else { inventory.Show(); inventory.Visible = true; }
            }
        }

        private void GameWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
