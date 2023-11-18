using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using World_Editor.Classes;

namespace World_Editor.Forms.Controls
{
    public partial class TileImageSelector : UserControl
    {
        ImageSelection selectionForm;

        public TileImageSelector(ImageSelection inSelector)
        {
            InitializeComponent();
            selectionForm = inSelector;
        }

        public void UpdateDisplay(Image inImage)
        {
            displayImageBox.Image = inImage;
        }
    }
}
