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

        int viewDistance = 6;

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
                        displayedTiles.Add(newTile);
                    }
                    else { Debug.WriteLine("Null Image when drawing tiles"); }
                }
            }
        }


        // Drawing Ground Tiles
        public void DrawMap()
        {
            Tile[,] tiles = globalManager.worldManager.world!.worldTiles; // temp ref of the tiles
            int curX = globalManager.worldManager.character!.posX; // temp cur x
            int curY = globalManager.worldManager.character!.posY; // temp cur y

            // Clear displayed tiles and Entities
            ClearTiles();
            ClearEntities();


            // Drawing Loops over tiles within view
            for (int iX = - (viewDistance - 1); iX <= viewDistance; iX++)
            {
                for (int iY = - (viewDistance - 1); iY <= viewDistance; iY++)
                {
                    // Store temp ref of real tiles array index
                    int realX = iX + curX;
                    int realY = iY + curY;

                    // Check if at valid index, if not then skip index
                    if (realX > tiles.GetLength(0) - 1 || realX < 0 || realY > tiles.GetLength(1) - 1 || realY < 0) { continue; }


                    // Get image from tile data
                    Image? tileImage = globalManager.renderer.GetImage(tiles[realX, realY].displayChar.ToString());
                    
                    if (tileImage != null)
                    {
                        // Create new displayTile and add it to the pane
                        DisplayTile newTile = new DisplayTile(iX, iY, tiles[realX, realY], tileImage);
                        TilePanel.Controls.Add(newTile);
                        displayedTiles.Add(newTile);


                        // If current tile has any entities then loop over them
                        if (tiles[realX, realY].entities.Count > 0)
                        {
                            for (int i = 0; i <= tiles[realX, realY].entities.Count; i++)
                            {
                                // Get entity image
                                Image? entityImage = globalManager.renderer.GetImage(tiles[realX, realY].entities[i].displayChar.ToString());

                                if (entityImage != null)
                                {
                                    DisplayTile newEntity = new DisplayTile(iX, iY, null, entityImage);
                                    TilePanel.Controls.Add(newEntity);
                                    displayedEntities.Add(newEntity);
                                    newEntity.BringToFront();
                                }
                            }
                        }

                        // Rendering Player Character On Screen
                        if (iX == (viewDistance / 2) && iY == (viewDistance / 2))
                        {
                            Image? characterImage = globalManager.renderer.GetImage("o");
                            if (characterImage != null)
                            {
                                DisplayTile newPlayer = new DisplayTile(iX, iY, null, characterImage);
                                TilePanel.Controls.Add(newPlayer);
                                displayedEntities.Add(newPlayer);
                                newPlayer.BringToFront();
                            }
                        }

                    }
                    
                }
            }


        }


        // Clearing displayed entities
        private void ClearEntities()
        {
            for (int i = displayedEntities.Count - 1; i >= 0; i--)
            {
                TilePanel.Controls.Remove(displayedEntities[i]);
            }
            displayedEntities.Clear();
            displayedEntities = new List<DisplayTile>();
        }

        // Clearing displayed Tiles
        private void ClearTiles()
        {
            for (int i = displayedTiles.Count - 1; i >= 0; i--)
            {
                TilePanel.Controls.Remove(displayedTiles[i]);
            }
            displayedTiles.Clear();
            displayedTiles = new List<DisplayTile>();
        }

        // Button Clicks
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
