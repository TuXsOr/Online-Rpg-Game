namespace World_Editor.Forms.Controls
{
    public partial class TileImageSelector : UserControl
    {
        string imageKey;
        TileProperties properties;
        public TileImageSelector(Image? inImage, string imageKey, int posX, int posY, TileProperties tileProperties)
        {
            InitializeComponent();
            if (inImage != null) { UpdateDisplay(inImage); }
            this.imageKey = imageKey;
            Location = new Point(posX * 55, posY * 55);
            this.properties = tileProperties;
        }

        public void UpdateDisplay(Image inImage)
        {
            displayImageBox.Image = inImage;
        }

        private void displayImageBox_Click(object sender, EventArgs e)
        {
            properties.CharBox.Text = imageKey;
            properties.UpdateDisplayImage(imageKey);
            properties.imageSelector!.Close();
            
        }
    }
}
