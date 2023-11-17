using Game.Classes;
using World_Editor.Forms;

namespace World_Editor.Classes
{
    public class GlobalManager : ApplicationContext
    {
        internal World? world;

        internal WorldEditorForm? editorForm;
        internal Generator generator;

        public GlobalManager()
        {
            generator = new Generator(this);
            DisplayEditor();
        }


        public void DisplayEditor()
        {
            editorForm = new WorldEditorForm(this);
            editorForm.Show();
        }
    }
}
