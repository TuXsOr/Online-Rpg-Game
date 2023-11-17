using Game.Classes;
using World_Editor.Forms.Controls;

namespace World_Editor.Forms
{
    public partial class TileProperties : Form
    {
        TileControl tileControl;
        List<string> towns = new List<string>();
        List<string> flags = new List<string>();

        public TileProperties(TileControl inTileBox)
        {
            InitializeComponent();
            tileControl = inTileBox;
        }

        public void UpdateTileAtPosition()
        {
            Tile outTile = new Tile();
            outTile.displayChar = CharBox.Text[0];
            outTile.towns = towns;
            outTile.flags = flags;

            tileControl.editor.globalManager.world!.worldTiles[tileControl.posX, tileControl.posY] = outTile;
            tileControl.displayChar.Text = CharBox.Text[0].ToString();
        }

        public void InitDisplay(Tile inTile)
        {
            CharBox.Text = inTile.displayChar.ToString();
            towns = inTile.towns;
            flags = inTile.flags;
            UpdateTownsList(towns);
            UpdateFlagsList(flags);
        }

        public void UpdateTownsList(List<string> inTowns)
        {
            TownsList.Items.Clear();
            for (int i = 0; i < inTowns.Count; i++)
            {
                TownsList.Items.Add(inTowns[i]);
            }
            TownsList.Refresh();
        }

        public void UpdateFlagsList(List<string> inFlags)
        {
            FlagsList.Items.Clear();
            for (int i = 0; i < inFlags.Count; i++)
            {
                FlagsList.Items.Add(inFlags[i]);
            }
            FlagsList.Refresh();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            UpdateTileAtPosition();
            this.Close();
        }

        private void addTownButton_Click(object sender, EventArgs e)
        {
            towns.Add(newTownBox.Text);
            newTownBox.Text = string.Empty;
            UpdateTownsList(towns);
        }

        private void addFlagButton_Click(object sender, EventArgs e)
        {
            flags.Add(newFlagText.Text);
            newFlagText.Text = string.Empty;
            UpdateFlagsList(flags);
        }

        private void TileProperties_FormClosed(object sender, FormClosedEventArgs e)
        {
            tileControl.Deselect();
        }

        private void cancelChanges_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
