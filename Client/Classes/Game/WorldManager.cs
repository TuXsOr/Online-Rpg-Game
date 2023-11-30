using Client.Forms;
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
            globalManager.formManager.gameWindowForm!.DrawMap();
            // globalManager.formManager.gameWindowForm!.UpdateEntities(world, character!);
        }

        public void UpdateCharacterData(Character inCharacter)
        {
            character = inCharacter;
            
            // If inventory exists attempt to update it with the new character data
            if (globalManager.formManager.gameWindowForm!.inventory != null)
            {
                globalManager.formManager.gameWindowForm.inventory.updateInventory(character);
            }
        }

        public bool UpdateCharacterPosition(int newX, int newY)
        {
            // if character is not null then update its position
            if (character != null && world != null)
            {
                character.posX = newX;
                character.posY = newY;

                globalManager.formManager.gameWindowForm!.DrawMap();
                return true;
            }
            return false;
        }
    }
}
