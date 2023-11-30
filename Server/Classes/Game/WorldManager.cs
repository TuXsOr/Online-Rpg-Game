using Game.Classes;

namespace Server.Classes.Game
{
    internal class WorldManager
    {
        internal GlobalManager globalManager;
        internal World? world;

        public WorldManager(GlobalManager inManager)
        {
            globalManager = inManager;

            // Load world data
            world = inManager.fileManager.GetWorldData(globalManager.fileManager.serverConfig.worldName);
            
            // If world is null then use default world
            if (world == null) { world = new World(); }
        }

        public bool CanMove(int newX, int newY)
        {
            if (world == null) { return false; }
            if (world.worldTiles == null) { return false; }
            if (world.worldTiles[newX, newY]  == null) { return false; }
            if (world.worldTiles[newX, newY].flags.Contains("c")) { return false; }
            return true;
        }
    }
}
