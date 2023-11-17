namespace World_Editor.Forms.Controls
{
    public partial class TileControl : UserControl
    {
        public WorldEditorForm editor;

        internal int posX;
        internal int posY;


        public TileControl(char displayChar, int posX, int posY, WorldEditorForm editor)
        {
            InitializeComponent();
            this.Location = new Point(posX * 34, posY * 34);
            this.editor = editor;
            this.posX = posX;
            this.posY = posY;
            this.displayChar.Text = displayChar.ToString();
            this.BackColor = Color.DarkGreen;

        }

        private void TileControl_Click(object sender, EventArgs e)
        {
            Selected();
            TileProperties properties = new TileProperties(this);
            properties.InitDisplay(editor.globalManager.world!.worldTiles[posX, posY]);
            properties.Show();
        }

        public void Deselect()
        {
            BackColor = Color.DarkGreen;
        }

        public void Selected()
        {
            BackColor = Color.Green;
        }
    }
}
