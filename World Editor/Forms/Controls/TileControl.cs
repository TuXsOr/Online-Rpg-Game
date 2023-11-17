namespace World_Editor.Forms.Controls
{
    public partial class TileControl : UserControl
    {
        public TileControl(char displayChar, int posX, int posY)
        {
            InitializeComponent();
            displayCharText.Text = displayChar.ToString();
            this.Location = new Point(posX * 34, posY * 34);
            // this.Show();
        }
    }
}
