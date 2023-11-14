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
            createAccountButton = new Button();
            tabControl1 = new TabControl();
            loginTab = new TabPage();
            loginResult = new Label();
            loginButton = new Button();
            passwordBox = new TextBox();
            usernameBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            createAccountTab = new TabPage();
            createAccountResult = new Label();
            s_passwordBox = new TextBox();
            label5 = new Label();
            s_emailBox = new TextBox();
            s_usernameBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            disconnectButton = new Button();
            tabControl1.SuspendLayout();
            loginTab.SuspendLayout();
            createAccountTab.SuspendLayout();
            SuspendLayout();
            // 
            // createAccountButton
            // 
            createAccountButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            createAccountButton.Location = new Point(6, 186);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(99, 32);
            createAccountButton.TabIndex = 5;
            createAccountButton.Text = "Create Account";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(loginTab);
            tabControl1.Controls.Add(createAccountTab);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(238, 252);
            tabControl1.TabIndex = 6;
            // 
            // loginTab
            // 
            loginTab.Controls.Add(loginResult);
            loginTab.Controls.Add(loginButton);
            loginTab.Controls.Add(passwordBox);
            loginTab.Controls.Add(usernameBox);
            loginTab.Controls.Add(label2);
            loginTab.Controls.Add(label1);
            loginTab.Location = new Point(4, 24);
            loginTab.Name = "loginTab";
            loginTab.Padding = new Padding(3);
            loginTab.Size = new Size(230, 224);
            loginTab.TabIndex = 0;
            loginTab.Text = "Login";
            loginTab.UseVisualStyleBackColor = true;
            // 
            // loginResult
            // 
            loginResult.AutoSize = true;
            loginResult.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            loginResult.ForeColor = Color.Red;
            loginResult.Location = new Point(112, 140);
            loginResult.Name = "loginResult";
            loginResult.Size = new Size(61, 25);
            loginResult.TabIndex = 13;
            loginResult.Text = "Failed";
            loginResult.TextAlign = ContentAlignment.TopCenter;
            loginResult.Visible = false;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(6, 133);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 32);
            loginButton.TabIndex = 9;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(6, 91);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(205, 23);
            passwordBox.TabIndex = 8;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // usernameBox
            // 
            usernameBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usernameBox.Location = new Point(6, 27);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(205, 23);
            usernameBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 67);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 5;
            label1.Text = "Username:";
            // 
            // createAccountTab
            // 
            createAccountTab.Controls.Add(createAccountResult);
            createAccountTab.Controls.Add(s_passwordBox);
            createAccountTab.Controls.Add(createAccountButton);
            createAccountTab.Controls.Add(label5);
            createAccountTab.Controls.Add(s_emailBox);
            createAccountTab.Controls.Add(s_usernameBox);
            createAccountTab.Controls.Add(label3);
            createAccountTab.Controls.Add(label4);
            createAccountTab.Location = new Point(4, 24);
            createAccountTab.Name = "createAccountTab";
            createAccountTab.Padding = new Padding(3);
            createAccountTab.Size = new Size(230, 224);
            createAccountTab.TabIndex = 1;
            createAccountTab.Text = "Create Account";
            createAccountTab.UseVisualStyleBackColor = true;
            // 
            // createAccountResult
            // 
            createAccountResult.AutoSize = true;
            createAccountResult.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            createAccountResult.ForeColor = Color.Lime;
            createAccountResult.Location = new Point(111, 189);
            createAccountResult.Name = "createAccountResult";
            createAccountResult.Size = new Size(100, 25);
            createAccountResult.TabIndex = 12;
            createAccountResult.Text = "Successful";
            createAccountResult.TextAlign = ContentAlignment.TopCenter;
            createAccountResult.Visible = false;
            // 
            // s_passwordBox
            // 
            s_passwordBox.Location = new Point(6, 157);
            s_passwordBox.Name = "s_passwordBox";
            s_passwordBox.Size = new Size(205, 23);
            s_passwordBox.TabIndex = 11;
            s_passwordBox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 133);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 10;
            label5.Text = "Password:";
            // 
            // s_emailBox
            // 
            s_emailBox.Location = new Point(6, 91);
            s_emailBox.Name = "s_emailBox";
            s_emailBox.Size = new Size(205, 23);
            s_emailBox.TabIndex = 8;
            // 
            // s_usernameBox
            // 
            s_usernameBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            s_usernameBox.Location = new Point(6, 27);
            s_usernameBox.Name = "s_usernameBox";
            s_usernameBox.Size = new Size(205, 23);
            s_usernameBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 67);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 6;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 3);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 5;
            label4.Text = "Username:";
            // 
            // disconnectButton
            // 
            disconnectButton.ForeColor = Color.Red;
            disconnectButton.Location = new Point(12, 270);
            disconnectButton.Name = "disconnectButton";
            disconnectButton.Size = new Size(89, 30);
            disconnectButton.TabIndex = 7;
            disconnectButton.Text = "Disconnect";
            disconnectButton.UseVisualStyleBackColor = true;
            disconnectButton.Click += disconnectButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 312);
            Controls.Add(disconnectButton);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            FormClosed += Login_FormClosed;
            tabControl1.ResumeLayout(false);
            loginTab.ResumeLayout(false);
            loginTab.PerformLayout();
            createAccountTab.ResumeLayout(false);
            createAccountTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button createAccountButton;
        private TabControl tabControl1;
        private TabPage loginTab;
        private Button loginButton;
        private TextBox passwordBox;
        private TextBox usernameBox;
        private Label label2;
        private Label label1;
        private TabPage createAccountTab;
        private TextBox s_passwordBox;
        private Label label5;
        private TextBox s_emailBox;
        private TextBox s_usernameBox;
        private Label label3;
        private Label label4;
        internal Label createAccountResult;
        internal Label loginResult;
        private Button disconnectButton;
    }
}