﻿using Game.Classes;
using Newtonsoft.Json;

namespace World_Editor.Classes
{
    internal class Generator
    {
        GlobalManager globalManager;

        public Generator(GlobalManager inManager)
        {
            globalManager = inManager;
        }



        public void GenerateWorld(int sizeX, int sizeY)
        {
            // Setup the world object
            globalManager.world = new World();
            globalManager.world.worldTiles = new Tile[sizeX, sizeY];

            for (int iX = 0; iX < sizeX; iX++)
            {
                for (int iY = 0; iY < sizeY; iY++)
                {
                    Tile newTile = new Tile();
                    newTile.displayChar = "grass";
                    globalManager.world.worldTiles[iX, iY] = newTile;
                }
            }
        }

        // Saving the map to a file
        async public void SaveMap(string worldName)
        {
            string mapDataString = JsonConvert.SerializeObject(globalManager.world, Formatting.Indented);
            await File.WriteAllTextAsync($"{Directory.GetCurrentDirectory()}\\{worldName}.world", mapDataString);
            MessageBox.Show($"Finished saving {worldName}.world");
        }
    }
}
