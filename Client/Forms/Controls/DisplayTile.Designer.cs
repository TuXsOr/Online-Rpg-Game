namespace Client.Forms.Controls
{
    partial class DisplayTile
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
            displayChar = new Label();
            SuspendLayout();
            // 
            // displayChar
            // 
            displayChar.AutoSize = true;
            displayChar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            displayChar.Location = new Point(8, 6);
            displayChar.Name = "displayChar";
            displayChar.Size = new Size(15, 21);
            displayChar.TabIndex = 0;
            displayChar.Text = "!";
            // 
            // DisplayTile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            Controls.Add(displayChar);
            Name = "DisplayTile";
            Size = new Size(32, 32);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label displayChar;
    }
}
