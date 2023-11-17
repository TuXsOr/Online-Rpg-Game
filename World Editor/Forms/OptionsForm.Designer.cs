namespace World_Editor.Forms
{
    partial class OptionsForm
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
            SaveButton = new Button();
            GenerateButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            sizeXDown = new Button();
            sizeXDisplay = new Label();
            sizeXUp = new Button();
            sizeYUp = new Button();
            sizeYDisplay = new Label();
            sizeYDown = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(6, 510);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(116, 46);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // GenerateButton
            // 
            GenerateButton.Location = new Point(128, 510);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(124, 46);
            GenerateButton.TabIndex = 1;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 481);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "World";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 463);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 3;
            label1.Text = "World Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 9);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 4;
            label2.Text = "Map Size X";
            // 
            // sizeXDown
            // 
            sizeXDown.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            sizeXDown.Location = new Point(6, 36);
            sizeXDown.Name = "sizeXDown";
            sizeXDown.Size = new Size(32, 32);
            sizeXDown.TabIndex = 5;
            sizeXDown.Text = "-";
            sizeXDown.UseVisualStyleBackColor = true;
            sizeXDown.Click += sizeXDown_Click;
            // 
            // sizeXDisplay
            // 
            sizeXDisplay.AutoSize = true;
            sizeXDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sizeXDisplay.Location = new Point(42, 42);
            sizeXDisplay.Name = "sizeXDisplay";
            sizeXDisplay.Size = new Size(28, 21);
            sizeXDisplay.TabIndex = 6;
            sizeXDisplay.Text = "10";
            // 
            // sizeXUp
            // 
            sizeXUp.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            sizeXUp.Location = new Point(76, 36);
            sizeXUp.Name = "sizeXUp";
            sizeXUp.Size = new Size(32, 32);
            sizeXUp.TabIndex = 7;
            sizeXUp.Text = "+";
            sizeXUp.UseVisualStyleBackColor = true;
            sizeXUp.Click += sizeXUp_Click;
            // 
            // sizeYUp
            // 
            sizeYUp.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            sizeYUp.Location = new Point(76, 115);
            sizeYUp.Name = "sizeYUp";
            sizeYUp.Size = new Size(32, 32);
            sizeYUp.TabIndex = 11;
            sizeYUp.Text = "+";
            sizeYUp.UseVisualStyleBackColor = true;
            sizeYUp.Click += sizeYUp_Click;
            // 
            // sizeYDisplay
            // 
            sizeYDisplay.AutoSize = true;
            sizeYDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sizeYDisplay.Location = new Point(42, 121);
            sizeYDisplay.Name = "sizeYDisplay";
            sizeYDisplay.Size = new Size(28, 21);
            sizeYDisplay.TabIndex = 10;
            sizeYDisplay.Text = "10";
            // 
            // sizeYDown
            // 
            sizeYDown.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            sizeYDown.Location = new Point(6, 115);
            sizeYDown.Name = "sizeYDown";
            sizeYDown.Size = new Size(32, 32);
            sizeYDown.TabIndex = 9;
            sizeYDown.Text = "-";
            sizeYDown.UseVisualStyleBackColor = true;
            sizeYDown.Click += sizeYDown_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 88);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 8;
            label4.Text = "Map Size Y";
            // 
            // OptionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 568);
            Controls.Add(sizeYUp);
            Controls.Add(sizeYDisplay);
            Controls.Add(sizeYDown);
            Controls.Add(label4);
            Controls.Add(sizeXUp);
            Controls.Add(sizeXDisplay);
            Controls.Add(sizeXDown);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(GenerateButton);
            Controls.Add(SaveButton);
            Name = "OptionsForm";
            Text = "OptionsForm";
            FormClosed += OptionsForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Button GenerateButton;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button sizeXDown;
        private Label sizeXDisplay;
        private Button sizeXUp;
        private Button sizeYUp;
        private Label sizeYDisplay;
        private Button sizeYDown;
        private Label label4;
    }
}