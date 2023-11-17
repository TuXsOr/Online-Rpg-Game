using Game.Classes;
using World_Editor.Classes;
using World_Editor.Forms.Controls;

namespace World_Editor.Forms
{
    public partial class WorldEditorForm : Form
    {
        public OptionsForm optionsForm;
        public GlobalManager globalManager;
        public List<TileControl> displayedTiles = new List<TileControl>();


        public WorldEditorForm(GlobalManager inManager)
        {
            InitializeComponent();
            globalManager = inManager;
            optionsForm = new OptionsForm(this);
            optionsForm.Show();
        }

        public void UpdateDisplay(World inWorld)
        {
            int sizeX = inWorld.worldTiles.GetLength(0);
            int sizeY = inWorld.worldTiles.GetLength(1);

            ClearDisplay();

            for (int ix = 0; ix < sizeX; ix++)
            {
                for (int iy = 0; iy < sizeY; iy++)
                {
                    TileControl newTile = new TileControl(inWorld.worldTiles[ix, iy].displayChar, ix, iy);
                    DisplayPanel.Controls.Add(newTile);
                    displayedTiles.Add(newTile);
                }
            }
        }

        public void ClearDisplay()
        {
            for (int i = displayedTiles.Count - 1; i >= 0; i--)
            {
                DisplayPanel.Controls.Remove(displayedTiles[i]);
                displayedTiles.RemoveAt(i);
            }
            displayedTiles = new List<TileControl>();
        }

        private void WorldEditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
