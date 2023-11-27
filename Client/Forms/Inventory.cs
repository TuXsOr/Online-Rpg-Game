using Client.Classes;
using Game.Classes;

namespace Client.Forms
{
    internal partial class Inventory : Form
    {
        GlobalManager globalManager;
        public Inventory(GlobalManager inManager)
        {
            InitializeComponent();
            globalManager = inManager;
        }

        public void updateInventory(Character inCharacter)
        {
            itemsList.Items.Clear();
            for (int i = 0; i < inCharacter.inventory.Count; i++)
            {
                itemsList.Items.Add(inCharacter.inventory[i]);
            }
            itemsList.Refresh();
        }

        private void Inventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            globalManager.formManager.gameWindowForm!.inventory = null;
        }
    }
}
