namespace Client.Forms
{
    partial class Login
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
<<<<<<< Updated upstream
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Login";
        }

        #endregion
=======
            label1 = new Label();
            usernameBox = new TextBox();
            label2 = new Label();
            passwordBox = new TextBox();
            loginButton = new Button();
            disconnectButton = new Button();
            helpProvider1 = new HelpProvider();
            resultDisplay = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(12, 27);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(157, 23);
            usernameBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(12, 85);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(157, 23);
            passwordBox.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.DarkSeaGreen;
            loginButton.Location = new Point(41, 124);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 32);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // disconnectButton
            // 
            disconnectButton.BackColor = Color.Red;
            disconnectButton.Location = new Point(41, 183);
            disconnectButton.Name = "disconnectButton";
            disconnectButton.Size = new Size(100, 30);
            disconnectButton.TabIndex = 5;
            disconnectButton.Text = "Disconnect";
            disconnectButton.UseVisualStyleBackColor = false;
            // 
            // resultDisplay
            // 
            resultDisplay.AutoSize = true;
            resultDisplay.Location = new Point(12, 159);
            resultDisplay.Name = "resultDisplay";
            resultDisplay.Size = new Size(43, 15);
            resultDisplay.TabIndex = 6;
            resultDisplay.Text = "INSERT";
            resultDisplay.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(181, 225);
            Controls.Add(resultDisplay);
            Controls.Add(disconnectButton);
            Controls.Add(loginButton);
            Controls.Add(passwordBox);
            Controls.Add(label2);
            Controls.Add(usernameBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usernameBox;
        private Label label2;
        private TextBox passwordBox;
        private Button disconnectButton;
        private HelpProvider helpProvider1;
        public Label resultDisplay;
        internal Button loginButton;
>>>>>>> Stashed changes
    }
}