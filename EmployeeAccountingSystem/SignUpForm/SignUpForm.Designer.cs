namespace EmployeeAccountingSystem
{
    partial class SignUpForm
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
            UsernameLabel = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            SignupLabel = new Label();
            SignUpButton = new Button();
            RetryPassword = new TextBox();
            Status = new Label();
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
            // SignupLabel
            // 
            SignupLabel.AutoSize = true;
            SignupLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            SignupLabel.Location = new Point(125, 50);
            SignupLabel.Name = "SignupLabel";
            SignupLabel.Size = new Size(111, 37);
            SignupLabel.TabIndex = 4;
            SignupLabel.Text = "Sign Up";
            // 
            // SignUpButton
            // 
            SignUpButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SignUpButton.Location = new Point(99, 339);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(152, 30);
            SignUpButton.TabIndex = 6;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // RetryPassword
            // 
            RetryPassword.Location = new Point(99, 286);
            RetryPassword.Name = "RetryPassword";
            RetryPassword.PasswordChar = '*';
            RetryPassword.Size = new Size(152, 23);
            RetryPassword.TabIndex = 7;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Status.Location = new Point(149, 382);
            Status.Name = "Status";
            Status.Size = new Size(0, 21);
            Status.TabIndex = 8;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 461);
            Controls.Add(Status);
            Controls.Add(RetryPassword);
            Controls.Add(SignUpButton);
            Controls.Add(SignupLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(UsernameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SignUpForm";
            Text = "EAS (Sign Up)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UsernameLabel;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Label PasswordLabel;
        private Label SignupLabel;
        private Button SignUpButton;
        private TextBox RetryPassword;
        private Label Status;
    }
}