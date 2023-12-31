﻿namespace Client.Forms.Controls
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
            TileImageBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)TileImageBox).BeginInit();
            SuspendLayout();
            // 
            // TileImageBox
            // 
            TileImageBox.Location = new Point(0, 0);
            TileImageBox.Name = "TileImageBox";
            TileImageBox.Size = new Size(32, 32);
            TileImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            TileImageBox.TabIndex = 0;
            TileImageBox.TabStop = false;
            // 
            // DisplayTile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            Controls.Add(TileImageBox);
            Name = "DisplayTile";
            Size = new Size(32, 32);
            ((System.ComponentModel.ISupportInitialize)TileImageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox TileImageBox;
    }
}
