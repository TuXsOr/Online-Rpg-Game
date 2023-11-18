﻿using Game.Classes;
using World_Editor.Forms.Controls;

namespace World_Editor.Forms
{
    public partial class TileProperties : Form
    {
        internal ImageSelection? imageSelector;

        public TileControl tileControl;
        List<string> towns = new List<string>();
        List<string> flags = new List<string>();

        public TileProperties(TileControl inTileBox)
        {
            InitializeComponent();
            tileControl = inTileBox;
            imageSelector = new ImageSelection(this);
        }

        public void UpdateTileAtPosition()
        {
            Tile outTile = new Tile();
            outTile.displayChar = CharBox.Text;
            outTile.towns = towns;
            outTile.flags = flags;

            tileControl.editor.globalManager.world!.worldTiles[tileControl.posX, tileControl.posY] = outTile;
            tileControl.UpdateImage(outTile.displayChar);
        }

        public void InitDisplay(Tile inTile)
        {
            CharBox.Text = inTile.displayChar;
            demoTileImage.Image = tileControl.editor.globalManager.renderer.GetImage(inTile.displayChar);
            towns = inTile.towns;
            flags = inTile.flags;
            UpdateTownsList(towns);
            UpdateFlagsList(flags);
        }

        public void UpdateDisplayImage(string imageName)
        {
            demoTileImage.Image = tileControl.editor.globalManager.renderer.GetImage(imageName);
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

        private void demoTileImage_Click(object sender, EventArgs e)
        {
            if (imageSelector != null)
            {
                if (!imageSelector.Visible)
                {
                    imageSelector.Show();
                    imageSelector.UpdateList(tileControl.editor.globalManager.renderer.imageNames, tileControl.editor.globalManager.renderer);
                    imageSelector.Visible = true;
                }
                else
                {
                    imageSelector.Hide();
                    imageSelector.Visible = false;
                }
            }
            else
            {
                imageSelector = new ImageSelection(this);
                imageSelector.Show();
                imageSelector.UpdateList(tileControl.editor.globalManager.renderer.imageNames, tileControl.editor.globalManager.renderer);
                imageSelector.Visible = true;
            }
        }
    }
}
