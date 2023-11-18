namespace Client.Forms
{
    partial class Inventory
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
            itemsList = new ListBox();
            SuspendLayout();
            // 
            // itemsList
            // 
            itemsList.FormattingEnabled = true;
            itemsList.ItemHeight = 15;
            itemsList.Location = new Point(12, 12);
            itemsList.Name = "itemsList";
            itemsList.Size = new Size(255, 349);
            itemsList.TabIndex = 0;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 373);
            ControlBox = false;
            Controls.Add(itemsList);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Inventory";
            Text = "Inventory";
            ResumeLayout(false);
        }

        #endregion

        private ListBox itemsList;
    }
}