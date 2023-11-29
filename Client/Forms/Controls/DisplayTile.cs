using Client.Classes;
using Game.Classes;

namespace Client.Forms.Controls
{
    internal partial class DisplayTile : UserControl
    {
        Tile? tileData;
        int posX = 0;
        int posY = 0;

        public DisplayTile(int posX, int posY, Tile? inTile, Image inImage)
        {
            InitializeComponent();
            tileData = inTile;
            this.posX = posX;
            this.posY = posY;
            Location = new Point(posX * 32, posY * 32);
            TileImageBox.Image = inImage;
        }
    }
}
