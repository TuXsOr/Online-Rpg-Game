namespace Client.Classes
{
    partial class FormManager
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
            loadingBar = new ProgressBar();
            displayLabel = new Label();
            SuspendLayout();
            // 
            // loadingBar
            // 
            loadingBar.Location = new Point(12, 46);
            loadingBar.Name = "loadingBar";
            loadingBar.Size = new Size(276, 23);
            loadingBar.TabIndex = 0;
            loadingBar.Value = 25;
            // 
            // displayLabel
            // 
            displayLabel.AutoSize = true;
            displayLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            displayLabel.Location = new Point(12, 9);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(160, 21);
            displayLabel.TabIndex = 1;
            displayLabel.Text = "Loading NAMEHERE...";
            // 
            // FormManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 150);
            Controls.Add(displayLabel);
            Controls.Add(loadingBar);
            Name = "FormManager";
            Text = "Loading";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar loadingBar;
        private Label displayLabel;
    }
}