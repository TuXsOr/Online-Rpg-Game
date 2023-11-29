namespace Client.Forms
{
    partial class GameWindow
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
            TilePanel = new Panel();
            InventoryButton = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            moveUpButton = new Button();
            panel1 = new Panel();
            moveLeftButton = new Button();
            moveRightButton = new Button();
            moveDownButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TilePanel
            // 
            TilePanel.AutoScroll = true;
            TilePanel.BackColor = Color.FromArgb(108, 56, 4);
            TilePanel.Location = new Point(157, 12);
            TilePanel.Name = "TilePanel";
            TilePanel.Size = new Size(512, 512);
            TilePanel.TabIndex = 0;
            // 
            // InventoryButton
            // 
            InventoryButton.Location = new Point(12, 12);
            InventoryButton.Name = "InventoryButton";
            InventoryButton.Size = new Size(128, 36);
            InventoryButton.TabIndex = 1;
            InventoryButton.Text = "Inventory";
            InventoryButton.UseVisualStyleBackColor = true;
            InventoryButton.Click += InventoryButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 54);
            button2.Name = "button2";
            button2.Size = new Size(128, 36);
            button2.TabIndex = 2;
            button2.Text = "Equipment";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 96);
            button3.Name = "button3";
            button3.Size = new Size(128, 36);
            button3.TabIndex = 3;
            button3.Text = "Town";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(12, 483);
            button4.Name = "button4";
            button4.Size = new Size(128, 36);
            button4.TabIndex = 4;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            // 
            // moveUpButton
            // 
            moveUpButton.Location = new Point(22, 3);
            moveUpButton.Name = "moveUpButton";
            moveUpButton.Size = new Size(25, 25);
            moveUpButton.TabIndex = 5;
            moveUpButton.Text = "/\\";
            moveUpButton.UseVisualStyleBackColor = true;
            moveUpButton.Click += moveUpButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(moveLeftButton);
            panel1.Controls.Add(moveRightButton);
            panel1.Controls.Add(moveDownButton);
            panel1.Controls.Add(moveUpButton);
            panel1.Location = new Point(38, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(70, 71);
            panel1.TabIndex = 6;
            // 
            // moveLeftButton
            // 
            moveLeftButton.Location = new Point(0, 24);
            moveLeftButton.Name = "moveLeftButton";
            moveLeftButton.Size = new Size(25, 25);
            moveLeftButton.TabIndex = 8;
            moveLeftButton.Text = "<";
            moveLeftButton.UseVisualStyleBackColor = true;
            moveLeftButton.Click += moveLeftButton_Click;
            // 
            // moveRightButton
            // 
            moveRightButton.Location = new Point(44, 24);
            moveRightButton.Name = "moveRightButton";
            moveRightButton.Size = new Size(25, 25);
            moveRightButton.TabIndex = 7;
            moveRightButton.Text = ">";
            moveRightButton.UseVisualStyleBackColor = true;
            moveRightButton.Click += moveRightButton_Click;
            // 
            // moveDownButton
            // 
            moveDownButton.Location = new Point(22, 46);
            moveDownButton.Name = "moveDownButton";
            moveDownButton.Size = new Size(25, 25);
            moveDownButton.TabIndex = 6;
            moveDownButton.Text = "\\/";
            moveDownButton.UseVisualStyleBackColor = true;
            moveDownButton.Click += moveDownButton_Click;
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(73, 36, 3);
            ClientSize = new Size(681, 531);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(InventoryButton);
            Controls.Add(TilePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "GameWindow";
            Text = "GameWindow";
            FormClosed += GameWindow_FormClosed;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TilePanel;
        private Button InventoryButton;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button moveUpButton;
        private Panel panel1;
        private Button moveLeftButton;
        private Button moveRightButton;
        private Button moveDownButton;
    }
}