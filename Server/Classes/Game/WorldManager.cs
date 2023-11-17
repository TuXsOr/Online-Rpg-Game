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
    }
}
