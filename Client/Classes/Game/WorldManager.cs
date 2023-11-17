using Game.Classes;

namespace Client.Classes.Game
{
    internal class WorldManager
    {
        internal GlobalManager globalManager;

        // User Data
        internal Character? character;
        internal World? world;


        // Constructor
        public WorldManager(GlobalManager inManager)
        {
            globalManager = inManager;
        }

        public void UpdateWorldData(World inWorldData)
        {
            world = inWorldData;
        }
    }
}
