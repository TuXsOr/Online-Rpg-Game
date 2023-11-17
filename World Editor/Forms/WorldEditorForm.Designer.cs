namespace World_Editor.Forms
{
    partial class WorldEditorForm
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
            DisplayPanel = new Panel();
            SuspendLayout();
            // 
            // DisplayPanel
            // 
            DisplayPanel.Location = new Point(12, 12);
            DisplayPanel.Name = "DisplayPanel";
            DisplayPanel.Size = new Size(700, 700);
            DisplayPanel.TabIndex = 0;
            // 
            // WorldEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 727);
            Controls.Add(DisplayPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "WorldEditorForm";
            Text = "WorldEditorForm";
            FormClosed += WorldEditorForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Panel DisplayPanel;
    }
}