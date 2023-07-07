namespace EmployeeAccountingSystem
{
    partial class WorkingSpaceForm
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
            comboBox1 = new ComboBox();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            SurnameLabel = new Label();
            SurnameTextBox = new TextBox();
            DateOfBirthLabel = new Label();
            DateOfBirthTextBox = new TextBox();
            PhoneNumberLabel = new Label();
            PhoneNumberTextBox = new TextBox();
            IdLabel = new Label();
            IDTextBox = new TextBox();
            JobTitleLabel = new Label();
            JobTitleTextBox = new TextBox();
            CityLabel = new Label();
            CityTextBox = new TextBox();
            SalaryLabel = new Label();
            SalaryTextBox = new TextBox();
            AddEmplyeeButton = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(264, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = SystemColors.Window;
            NameTextBox.Location = new Point(282, 79);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.ReadOnly = true;
            NameTextBox.Size = new Size(186, 23);
            NameTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(282, 55);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(52, 21);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "Name";
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SurnameLabel.Location = new Point(502, 55);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(73, 21);
            SurnameLabel.TabIndex = 8;
            SurnameLabel.Text = "Surname";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.BackColor = SystemColors.Window;
            SurnameTextBox.Location = new Point(502, 79);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.ReadOnly = true;
            SurnameTextBox.Size = new Size(186, 23);
            SurnameTextBox.TabIndex = 7;
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DateOfBirthLabel.Location = new Point(282, 126);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(97, 21);
            DateOfBirthLabel.TabIndex = 10;
            DateOfBirthLabel.Text = "Date of Birth";
            // 
            // DateOfBirthTextBox
            // 
            DateOfBirthTextBox.BackColor = SystemColors.Window;
            DateOfBirthTextBox.Location = new Point(282, 150);
            DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            DateOfBirthTextBox.ReadOnly = true;
            DateOfBirthTextBox.Size = new Size(186, 23);
            DateOfBirthTextBox.TabIndex = 9;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberLabel.Location = new Point(502, 126);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(116, 21);
            PhoneNumberLabel.TabIndex = 12;
            PhoneNumberLabel.Text = "Phone Number";
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.BackColor = SystemColors.Window;
            PhoneNumberTextBox.Location = new Point(502, 150);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.ReadOnly = true;
            PhoneNumberTextBox.Size = new Size(186, 23);
            PhoneNumberTextBox.TabIndex = 11;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IdLabel.Location = new Point(502, 264);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(25, 21);
            IdLabel.TabIndex = 20;
            IdLabel.Text = "ID";
            // 
            // IDTextBox
            // 
            IDTextBox.BackColor = SystemColors.Window;
            IDTextBox.Location = new Point(502, 288);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(186, 23);
            IDTextBox.TabIndex = 19;
            // 
            // JobTitleLabel
            // 
            JobTitleLabel.AutoSize = true;
            JobTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            JobTitleLabel.Location = new Point(282, 264);
            JobTitleLabel.Name = "JobTitleLabel";
            JobTitleLabel.Size = new Size(71, 21);
            JobTitleLabel.TabIndex = 18;
            JobTitleLabel.Text = "Job  Title";
            // 
            // JobTitleTextBox
            // 
            JobTitleTextBox.BackColor = SystemColors.Window;
            JobTitleTextBox.Location = new Point(282, 288);
            JobTitleTextBox.Name = "JobTitleTextBox";
            JobTitleTextBox.ReadOnly = true;
            JobTitleTextBox.Size = new Size(186, 23);
            JobTitleTextBox.TabIndex = 17;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CityLabel.Location = new Point(502, 193);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(37, 21);
            CityLabel.TabIndex = 16;
            CityLabel.Text = "City";
            // 
            // CityTextBox
            // 
            CityTextBox.BackColor = SystemColors.Window;
            CityTextBox.Location = new Point(502, 217);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.ReadOnly = true;
            CityTextBox.Size = new Size(186, 23);
            CityTextBox.TabIndex = 15;
            // 
            // SalaryLabel
            // 
            SalaryLabel.AutoSize = true;
            SalaryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SalaryLabel.Location = new Point(282, 193);
            SalaryLabel.Name = "SalaryLabel";
            SalaryLabel.Size = new Size(53, 21);
            SalaryLabel.TabIndex = 14;
            SalaryLabel.Text = "Salary";
            // 
            // SalaryTextBox
            // 
            SalaryTextBox.BackColor = SystemColors.Window;
            SalaryTextBox.Location = new Point(282, 217);
            SalaryTextBox.Name = "SalaryTextBox";
            SalaryTextBox.ReadOnly = true;
            SalaryTextBox.Size = new Size(186, 23);
            SalaryTextBox.TabIndex = 13;
            // 
            // AddEmplyeeButton
            // 
            AddEmplyeeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddEmplyeeButton.Location = new Point(502, 359);
            AddEmplyeeButton.Name = "AddEmplyeeButton";
            AddEmplyeeButton.Size = new Size(186, 29);
            AddEmplyeeButton.TabIndex = 21;
            AddEmplyeeButton.Text = "Add Employee";
            AddEmplyeeButton.UseVisualStyleBackColor = true;
            AddEmplyeeButton.Click += AddEmplyeeButton_Click;
            // 
            // WorkingSpaceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 461);
            Controls.Add(AddEmplyeeButton);
            Controls.Add(IdLabel);
            Controls.Add(IDTextBox);
            Controls.Add(JobTitleLabel);
            Controls.Add(JobTitleTextBox);
            Controls.Add(CityLabel);
            Controls.Add(CityTextBox);
            Controls.Add(SalaryLabel);
            Controls.Add(SalaryTextBox);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(DateOfBirthLabel);
            Controls.Add(DateOfBirthTextBox);
            Controls.Add(SurnameLabel);
            Controls.Add(SurnameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(NameTextBox);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "WorkingSpaceForm";
            Text = "EAS (WorkingSpace)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox NameTextBox;
        private Label NameLabel;
        private Label SurnameLabel;
        private TextBox SurnameTextBox;
        private Label DateOfBirthLabel;
        private TextBox DateOfBirthTextBox;
        private Label PhoneNumberLabel;
        private TextBox PhoneNumberTextBox;
        private Label IdLabel;
        private TextBox IDTextBox;
        private Label JobTitleLabel;
        private TextBox JobTitleTextBox;
        private Label CityLabel;
        private TextBox CityTextBox;
        private Label SalaryLabel;
        private TextBox SalaryTextBox;
        private Button AddEmplyeeButton;
    }
}