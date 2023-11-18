using Game.Classes;
using System.Diagnostics;
using World_Editor.Forms.Controls;

namespace World_Editor.Forms
{
    public partial class ImageSelection : Form
    {
        TileProperties properties;
        List<TileImageSelector> shownTiles = new List<TileImageSelector>();

        public ImageSelection(TileProperties inPropertiesForm)
        {
            InitializeComponent();
            properties = inPropertiesForm;

        }


        public void UpdateList(List<string> inImages, Renderer inRenderer)
        {
            ClearTiles();
            int curX = 0;
            int curY = 0;

            for (int i = 0; i < inImages.Count; i++)
            {
                Image? newImage = inRenderer.GetImage(inImages[i]);
                TileImageSelector newButton = new TileImageSelector(newImage, inImages[i], curX, curY, properties);
                shownTiles.Add(newButton);
                ImagesList.Controls.Add(newButton);
                curX++;

                if (curX >= 5) { curX = 0; curY++; }


            }
        }

        private void ImageSelection_Load(object sender, EventArgs e) { }

        public void ClearTiles()
        {
            for (int i = shownTiles.Count - 1; i >= 0; i--)
            {
                ImagesList.Controls.Remove(shownTiles[i]);
            }
            shownTiles.Clear();
            shownTiles = new List<TileImageSelector>();
        }

        private void ImageSelection_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (properties.imageSelector != null)
            {
                properties.imageSelector = null;
            }
        }
    }
}
