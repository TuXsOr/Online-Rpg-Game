namespace World_Editor.Forms.Controls
{
    partial class TileImageSelector
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            displayImageBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)displayImageBox).BeginInit();
            SuspendLayout();
            // 
            // displayImageBox
            // 
            displayImageBox.Location = new Point(0, 0);
            displayImageBox.Name = "displayImageBox";
            displayImageBox.Size = new Size(32, 32);
            displayImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            displayImageBox.TabIndex = 0;
            displayImageBox.TabStop = false;
            // 
            // TileImageSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(displayImageBox);
            Name = "TileImageSelector";
            Size = new Size(32, 32);
            ((System.ComponentModel.ISupportInitialize)displayImageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox displayImageBox;
    }
}
