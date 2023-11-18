using System.Diagnostics;

namespace World_Editor.Forms.Controls
{
    public partial class TileControl : UserControl
    {
        public WorldEditorForm editor;

        internal int posX;
        internal int posY;



        public TileControl(string displayChar, int posX, int posY, WorldEditorForm editor)
        {
            InitializeComponent();
            this.Location = new Point(posX * 34, posY * 34);
            this.editor = editor;
            this.posX = posX;
            this.posY = posY;
            this.BackColor = Color.DarkGreen;
            UpdateImage(displayChar);

        }

        public void Deselect()
        {
            TileImageBox.Visible = true;
        }

        public void Selected()
        {
            TileImageBox.Visible = false;
        }

        public void UpdateImage(string displayChar)
        {
            Image? image = editor.globalManager.renderer.GetImage(displayChar);

            if (image != null)
            {
                TileImageBox.Image = image;
            }
            else { Debug.WriteLine("Null Image"); }
        }

        private void TileImageBox_Click(object sender, EventArgs e)
        {
            Selected();
            TileProperties properties = new TileProperties(this);
            properties.InitDisplay(editor.globalManager.world!.worldTiles[posX, posY]);
            properties.Show();
        }
    }
}
