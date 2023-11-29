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
        List<DisplayTile> displayedEntities = new List<DisplayTile>();

        public GameWindow(GlobalManager inGlobalManager)
        {
            InitializeComponent();
            globalManager = inGlobalManager;
            inventory = new Inventory(inGlobalManager);
        }

        public void UpdateEntities(World inWorld, Character inCharacter)
        {
            ClearEntities(); // Remove any entities from screen to stop duplicates

            // Rendering Entities i.e trees, rocks, etc.
            for (int i = 0; i < inWorld.entities.Count; i++)
            {
                int posX = inWorld.entities[i].posX;
                int posY = inWorld.entities[i].posY;
                Image? image = globalManager.renderer.GetImage(inWorld.entities[i].displayChar.ToString());

                if (image != null)
                {
                    DisplayTile newTile = new DisplayTile(posX, posY, null, image);
                    TilePanel.Controls.Add(newTile);
                    newTile.BringToFront();
                    displayedEntities.Add(newTile); // Add to reference list of all displayed entities
                }
                else { Debug.WriteLine("Failed to draw entity"); }
            }


            // Rendering Character
            Image? characterImage = globalManager.renderer.GetImage(inCharacter.displayChar.ToString());

            if (characterImage != null)
            {
                DisplayTile characterTile = new DisplayTile(inCharacter.posX, inCharacter.posY, null, characterImage);
                TilePanel.Controls.Add(characterTile);
                characterTile.BringToFront();
                displayedEntities.Add(characterTile); // Add to reference list of all displayed entities
            }
            else { Debug.WriteLine("Failed to find player image"); }

            Debug.WriteLine("Finished Drawing Entities");
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

        private void ClearEntities()
        {
            for (int i = displayedEntities.Count - 1; i >= 0; i--)
            {
                TilePanel.Controls.Remove(displayedEntities[i]);
            }
            displayedEntities.Clear();
            displayedEntities = new List<DisplayTile>();
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

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            globalManager.networkManager.MessageServer("move", "up");
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            globalManager.networkManager.MessageServer("move", "down");
        }

        private void moveLeftButton_Click(object sender, EventArgs e)
        {
            globalManager.networkManager.MessageServer("move", "left");
        }

        private void moveRightButton_Click(object sender, EventArgs e)
        {
            globalManager.networkManager.MessageServer("move", "right");
        }
    }
}
