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
            loadingProgress = new ProgressBar();
            displayText = new Label();
            SuspendLayout();
            // 
            // loadingProgress
            // 
            loadingProgress.Location = new Point(12, 51);
            loadingProgress.Name = "loadingProgress";
            loadingProgress.Size = new Size(317, 33);
            loadingProgress.TabIndex = 0;
            loadingProgress.UseWaitCursor = true;
            // 
            // displayText
            // 
            displayText.AutoSize = true;
            displayText.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            displayText.Location = new Point(12, 9);
            displayText.Name = "displayText";
            displayText.Size = new Size(207, 28);
            displayText.TabIndex = 1;
            displayText.Text = "Loading {NAME HERE}";
            // 
            // FormManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 96);
            Controls.Add(displayText);
            Controls.Add(loadingProgress);
            Name = "FormManager";
            Text = "FormManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar loadingProgress;
        private Label displayText;
    }
}