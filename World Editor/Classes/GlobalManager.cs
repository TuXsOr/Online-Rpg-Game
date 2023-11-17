using Game.Classes;
using Newtonsoft.Json;
using System.Diagnostics;
using World_Editor.Forms;

namespace World_Editor.Classes
{
    public class GlobalManager : ApplicationContext
    {
        internal World? world;

        WorldEditorForm? editorForm;

        public GlobalManager()
        {
            DisplayEditor();
        }


        public void DisplayEditor()
        {
            editorForm = new WorldEditorForm(this);
            editorForm.Show();
        }





        public void GenerateWorld(int sizeX, int sizeY)
        {
            // Setup the world object
            world = new World();
            world.worldTiles = new Tile[sizeX, sizeY];

            for (int iX = 0; iX < sizeX; iX++)
            {
                for (int iY = 0; iY < sizeY; iY++)
                {
                    Tile newTile = new Tile();
                    newTile.displayChar = '@';
                    newTile.flags.Add("d");
                    world.worldTiles[iX, iY] = newTile;
                }
            }
            // SaveMap();
        }

        // Saving the map to a file
        public void SaveMap()
        {
            string mapDataString = JsonConvert.SerializeObject(world, Formatting.Indented);
            File.WriteAllText($"{Directory.GetCurrentDirectory()}\\World.world", mapDataString);
        }
    }
}
