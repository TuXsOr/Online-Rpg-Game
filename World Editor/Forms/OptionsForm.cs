namespace World_Editor.Forms
{
    public partial class OptionsForm : Form
    {
        WorldEditorForm parent;
        int sizeX = 10;
        int sizeY = 10;

        public OptionsForm(WorldEditorForm parentForm)
        {
            InitializeComponent();
            parent = parentForm;
        }

        public void UpdateUI()
        {
            sizeXDisplay.Text = sizeX.ToString();
            sizeYDisplay.Text = sizeY.ToString();
            parent.UpdateDisplay(parent.globalManager.world!);
        }

        private void sizeXDown_Click(object sender, EventArgs e)
        {
            sizeX--;
            parent.globalManager.GenerateWorld(sizeX, sizeY);
            UpdateUI();
        }

        private void sizeXUp_Click(object sender, EventArgs e)
        {
            sizeX++;
            parent.globalManager.GenerateWorld(sizeX, sizeY);
            UpdateUI();
        }

        private void sizeYDown_Click(object sender, EventArgs e)
        {
            sizeY--;
            parent.globalManager.GenerateWorld(sizeX, sizeY);
            UpdateUI();
        }

        private void sizeYUp_Click(object sender, EventArgs e)
        {
            sizeY++;
            parent.globalManager.GenerateWorld(sizeX, sizeY);
            UpdateUI();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            parent.globalManager.GenerateWorld(sizeX, sizeY);
            UpdateUI();
        }

        private void OptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
