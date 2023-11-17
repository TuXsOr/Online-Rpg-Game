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
            displayChar = new Label();
            SuspendLayout();
            // 
            // displayChar
            // 
            displayChar.AutoSize = true;
            displayChar.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            displayChar.ForeColor = Color.White;
            displayChar.Location = new Point(0, 0);
            displayChar.Name = "displayChar";
            displayChar.Size = new Size(14, 13);
            displayChar.TabIndex = 0;
            displayChar.Text = "#";
            // 
            // TileControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            Controls.Add(displayChar);
            Cursor = Cursors.Hand;
            ForeColor = SystemColors.ControlText;
            Name = "TileControl";
            Size = new Size(32, 32);
            Click += TileControl_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Label displayChar;
    }
}
