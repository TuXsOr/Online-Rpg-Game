using Game.Classes;

namespace Client.Forms.Controls
{
    public partial class DisplayTile : UserControl
    {
        Tile tileData;
        int posX = 0;
        int posY = 0;

        public DisplayTile(int posX, int posY, Tile inTile)
        {
            InitializeComponent();
            tileData = inTile;
            this.posX = posX;
            this.posY = posY;
            Location = new Point(posX * 34, posY * 34);
            displayChar.Text = inTile.displayChar.ToString();
        }
    }
}
