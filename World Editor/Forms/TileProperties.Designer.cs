namespace World_Editor.Forms
{
    partial class TileProperties
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
            label1 = new Label();
            CharBox = new TextBox();
            TownsList = new ListBox();
            label2 = new Label();
            AcceptChanges = new Button();
            cancelChanges = new Button();
            newTownBox = new TextBox();
            addTownButton = new Button();
            addFlagButton = new Button();
            newFlagText = new TextBox();
            label3 = new Label();
            FlagsList = new ListBox();
            removeTownButton = new Button();
            demoTileImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)demoTileImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 13);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "Tile Image:";
            // 
            // CharBox
            // 
            CharBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CharBox.Location = new Point(330, 6);
            CharBox.Name = "CharBox";
            CharBox.Size = new Size(110, 32);
            CharBox.TabIndex = 1;
            // 
            // TownsList
            // 
            TownsList.FormattingEnabled = true;
            TownsList.ItemHeight = 15;
            TownsList.Location = new Point(12, 76);
            TownsList.Name = "TownsList";
            TownsList.Size = new Size(191, 64);
            TownsList.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 3;
            label2.Text = "Towns: ";
            // 
            // AcceptChanges
            // 
            AcceptChanges.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AcceptChanges.ForeColor = Color.Green;
            AcceptChanges.Location = new Point(119, 220);
            AcceptChanges.Name = "AcceptChanges";
            AcceptChanges.Size = new Size(84, 31);
            AcceptChanges.TabIndex = 4;
            AcceptChanges.Text = "Accept";
            AcceptChanges.UseVisualStyleBackColor = true;
            AcceptChanges.Click += AcceptButton_Click;
            // 
            // cancelChanges
            // 
            cancelChanges.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cancelChanges.ForeColor = Color.FromArgb(192, 0, 0);
            cancelChanges.Location = new Point(220, 220);
            cancelChanges.Name = "cancelChanges";
            cancelChanges.Size = new Size(84, 31);
            cancelChanges.TabIndex = 5;
            cancelChanges.Text = "Cancel";
            cancelChanges.UseVisualStyleBackColor = true;
            cancelChanges.Click += cancelChanges_Click;
            // 
            // newTownBox
            // 
            newTownBox.Location = new Point(69, 147);
            newTownBox.Name = "newTownBox";
            newTownBox.PlaceholderText = "Town Name";
            newTownBox.Size = new Size(134, 23);
            newTownBox.TabIndex = 6;
            // 
            // addTownButton
            // 
            addTownButton.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            addTownButton.Location = new Point(12, 146);
            addTownButton.Name = "addTownButton";
            addTownButton.Size = new Size(49, 23);
            addTownButton.TabIndex = 7;
            addTownButton.Text = "Add";
            addTownButton.UseVisualStyleBackColor = true;
            addTownButton.Click += addTownButton_Click;
            // 
            // addFlagButton
            // 
            addFlagButton.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            addFlagButton.Location = new Point(220, 146);
            addFlagButton.Name = "addFlagButton";
            addFlagButton.Size = new Size(49, 23);
            addFlagButton.TabIndex = 11;
            addFlagButton.Text = "Add";
            addFlagButton.UseVisualStyleBackColor = true;
            addFlagButton.Click += addFlagButton_Click;
            // 
            // newFlagText
            // 
            newFlagText.Location = new Point(277, 147);
            newFlagText.Name = "newFlagText";
            newFlagText.PlaceholderText = "Flag";
            newFlagText.Size = new Size(134, 23);
            newFlagText.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(220, 48);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 9;
            label3.Text = "Flags:";
            // 
            // FlagsList
            // 
            FlagsList.FormattingEnabled = true;
            FlagsList.ItemHeight = 15;
            FlagsList.Location = new Point(220, 76);
            FlagsList.Name = "FlagsList";
            FlagsList.Size = new Size(191, 64);
            FlagsList.TabIndex = 8;
            // 
            // removeTownButton
            // 
            removeTownButton.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            removeTownButton.Location = new Point(12, 176);
            removeTownButton.Name = "removeTownButton";
            removeTownButton.Size = new Size(62, 26);
            removeTownButton.TabIndex = 12;
            removeTownButton.Text = "Remove Town";
            removeTownButton.UseVisualStyleBackColor = true;
            // 
            // demoTileImage
            // 
            demoTileImage.BackColor = SystemColors.ButtonShadow;
            demoTileImage.Location = new Point(118, 6);
            demoTileImage.Name = "demoTileImage";
            demoTileImage.Size = new Size(45, 45);
            demoTileImage.SizeMode = PictureBoxSizeMode.StretchImage;
            demoTileImage.TabIndex = 13;
            demoTileImage.TabStop = false;
            demoTileImage.Click += demoTileImage_Click;
            // 
            // TileProperties
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 260);
            ControlBox = false;
            Controls.Add(demoTileImage);
            Controls.Add(removeTownButton);
            Controls.Add(addFlagButton);
            Controls.Add(newFlagText);
            Controls.Add(label3);
            Controls.Add(FlagsList);
            Controls.Add(addTownButton);
            Controls.Add(newTownBox);
            Controls.Add(cancelChanges);
            Controls.Add(AcceptChanges);
            Controls.Add(label2);
            Controls.Add(TownsList);
            Controls.Add(CharBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TileProperties";
            Text = "TileProperties";
            FormClosed += TileProperties_FormClosed;
            ((System.ComponentModel.ISupportInitialize)demoTileImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox CharBox;
        private ListBox TownsList;
        private Label label2;
        private Button AcceptChanges;
        private Button cancelChanges;
        private TextBox newTownBox;
        private Button addTownButton;
        private Button addFlagButton;
        private TextBox newFlagText;
        private Label label3;
        private ListBox FlagsList;
        private Button removeTownButton;
        private PictureBox demoTileImage;
    }
}