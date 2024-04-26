namespace PinterestPrototype
{
    partial class LoginForm
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
            welcomeLabel = new Label();
            usernameLabel = new Label();
            emaiLabel = new Label();
            usernameTextBox = new TextBox();
            emailTextBox = new TextBox();
            loginButton = new Button();
            singupButton = new Button();
            suggestSignupLabel = new Label();
            passwordLabel = new Label();
            passwordMaskedBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(24, 23);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(59, 25);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "label1";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(24, 59);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(95, 25);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username:";
            // 
            // emaiLabel
            // 
            emaiLabel.AutoSize = true;
            emaiLabel.Location = new Point(24, 99);
            emaiLabel.Name = "emaiLabel";
            emaiLabel.Size = new Size(58, 25);
            emaiLabel.TabIndex = 2;
            emaiLabel.Text = "Email:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(211, 59);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(150, 31);
            usernameTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(211, 99);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(150, 31);
            emailTextBox.TabIndex = 4;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(249, 198);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(112, 34);
            loginButton.TabIndex = 5;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // singupButton
            // 
            singupButton.Location = new Point(249, 302);
            singupButton.Name = "singupButton";
            singupButton.Size = new Size(112, 34);
            singupButton.TabIndex = 6;
            singupButton.Text = "Sign up";
            singupButton.UseVisualStyleBackColor = true;
            // 
            // suggestSignupLabel
            // 
            suggestSignupLabel.AutoSize = true;
            suggestSignupLabel.Location = new Point(24, 274);
            suggestSignupLabel.Name = "suggestSignupLabel";
            suggestSignupLabel.Size = new Size(341, 25);
            suggestSignupLabel.TabIndex = 7;
            suggestSignupLabel.Text = "Don't have an account? Let's sign you up!";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(24, 145);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(91, 25);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Password:";
            // 
            // passwordMaskedBox
            // 
            passwordMaskedBox.Location = new Point(211, 145);
            passwordMaskedBox.Name = "passwordMaskedBox";
            passwordMaskedBox.Size = new Size(150, 31);
            passwordMaskedBox.TabIndex = 9;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passwordMaskedBox);
            Controls.Add(passwordLabel);
            Controls.Add(suggestSignupLabel);
            Controls.Add(singupButton);
            Controls.Add(loginButton);
            Controls.Add(emailTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(emaiLabel);
            Controls.Add(usernameLabel);
            Controls.Add(welcomeLabel);
            Name = "LoginForm";
            Text = "Log in";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private Label usernameLabel;
        private Label emaiLabel;
        private TextBox usernameTextBox;
        private TextBox emailTextBox;
        private Button loginButton;
        private Button singupButton;
        private Label suggestSignupLabel;
        private Label passwordLabel;
        private MaskedTextBox passwordMaskedBox;
    }
}