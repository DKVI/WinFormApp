namespace WinFormsApp
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(29, 56);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(206, 23);
            usernameTextBox.TabIndex = 0;
            usernameTextBox.TextChanged += this.UsernameTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(29, 129);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(206, 23);
            passwordTextBox.TabIndex = 1;
            passwordLabel.TextChanged += this.PasswordLabel_TextChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(29, 28);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(59, 15);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "username";
            usernameLabel.Click += Username_Label;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(29, 102);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "password";
            passwordLabel.Click += Password_Label;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(160, 190);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 5;
            loginButton.Text = "button1";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += Login_Button;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 232);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Name = "Login";
            Text = "Login Form";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void PasswordLabel_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label label1;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button loginButton;
    }
}
