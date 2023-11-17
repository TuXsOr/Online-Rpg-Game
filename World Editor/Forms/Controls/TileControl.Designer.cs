﻿namespace World_Editor.Forms.Controls
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
            charBox = new TextBox();
            SuspendLayout();
            // 
            // charBox
            // 
            charBox.Location = new Point(3, 3);
            charBox.Name = "charBox";
            charBox.Size = new Size(26, 23);
            charBox.TabIndex = 0;
            charBox.TextChanged += chatBox_TextChanged;
            // 
            // TileControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            Controls.Add(charBox);
            ForeColor = SystemColors.ControlText;
            Name = "TileControl";
            Size = new Size(32, 32);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox charBox;
    }
}
