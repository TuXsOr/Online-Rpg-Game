namespace World_Editor.Forms.Controls
{
    partial class TileControl
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
            displayCharText = new Label();
            SuspendLayout();
            // 
            // displayCharText
            // 
            displayCharText.AutoSize = true;
            displayCharText.Location = new Point(8, 8);
            displayCharText.Name = "displayCharText";
            displayCharText.Size = new Size(14, 15);
            displayCharText.TabIndex = 0;
            displayCharText.Text = "#";
            // 
            // TileControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            Controls.Add(displayCharText);
            ForeColor = SystemColors.ControlText;
            Name = "TileControl";
            Size = new Size(32, 32);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label displayCharText;
    }
}
