namespace World_Editor.Forms.Controls
{
    public partial class TileControl : UserControl
    {
        public WorldEditorForm editor;
        private char? lastValidChar = null;

        int posX;
        int posY;

        bool initilizing = true;

        public TileControl(char displayChar, int posX, int posY, WorldEditorForm editor)
        {
            InitializeComponent();
            this.Location = new Point(posX * 34, posY * 34);
            this.editor = editor;
            this.posX = posX;
            this.posY = posY;
            charBox.Text = displayChar.ToString();
            initilizing = false;

        }

        private void chatBox_TextChanged(object sender, EventArgs e)
        {
            if (!initilizing)
            {
                if (charBox.Text != string.Empty || charBox.Text != null)
                {
                    char newChar = (char)charBox.Text[0];
                    lastValidChar = newChar;
                    editor.globalManager.world!.worldTiles[posX, posY].displayChar = newChar;
                }
                else { charBox.Text = lastValidChar.ToString(); }
            }
        }
    }
}
