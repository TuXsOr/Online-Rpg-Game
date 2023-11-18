namespace World_Editor.Forms
{
    partial class ImageSelection
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ImagesList = new Panel();
            SuspendLayout();
            // 
            // ImagesList
            // 
            ImagesList.AutoScroll = true;
            ImagesList.BackColor = SystemColors.ActiveCaption;
            ImagesList.Location = new Point(12, 12);
            ImagesList.Name = "ImagesList";
            ImagesList.Size = new Size(393, 276);
            ImagesList.TabIndex = 0;
            // 
            // ImageSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 300);
            Controls.Add(ImagesList);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ImageSelection";
            Text = "ImageSelection";
            FormClosing += ImageSelection_FormClosing;
            Load += ImageSelection_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel ImagesList;
    }
}