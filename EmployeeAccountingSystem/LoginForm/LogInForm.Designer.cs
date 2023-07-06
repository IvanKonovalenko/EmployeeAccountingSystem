namespace EmployeeAccountingSystem
{
    partial class LogInForm
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
            UsernameLabel = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            LoginLabel = new Label();
            LogInButton = new Button();
            SignUpButton = new Button();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameLabel.Location = new Point(99, 166);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(88, 21);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "User Name";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(99, 190);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(152, 23);
            UsernameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(99, 257);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(152, 23);
            PasswordTextBox.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(99, 233);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(76, 21);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            LoginLabel.Location = new Point(125, 50);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(91, 37);
            LoginLabel.TabIndex = 4;
            LoginLabel.Text = "Log In";
            // 
            // LogInButton
            // 
            LogInButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LogInButton.Location = new Point(12, 357);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(152, 30);
            LogInButton.TabIndex = 5;
            LogInButton.Text = "Log In";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // SignUpButton
            // 
            SignUpButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SignUpButton.Location = new Point(170, 357);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(152, 30);
            SignUpButton.TabIndex = 6;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 461);
            Controls.Add(SignUpButton);
            Controls.Add(LogInButton);
            Controls.Add(LoginLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(UsernameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LogInForm";
            Text = "EAS (Log In)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UsernameLabel;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Label PasswordLabel;
        private Label LoginLabel;
        private Button LogInButton;
        private Button SignUpButton;
    }
}