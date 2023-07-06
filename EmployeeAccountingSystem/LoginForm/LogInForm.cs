using EmployeeAccountingSystem.DataBase;
namespace EmployeeAccountingSystem
{
    public partial class LogInForm : Form
    {
        DataBase1 _dataBase= new DataBase1();
        SignUpForm _signUpForm;
        WorkingSpaceForm _workingSpaceForm;
        public LogInForm()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (_signUpForm == null || _signUpForm.IsDisposed)
            {
                _signUpForm = new();
                _signUpForm.Closed += (s, args) => this.Show();
                this.Hide();
                _signUpForm.Show();
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(UsernameTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text)) return;
            
            if (_workingSpaceForm == null || _workingSpaceForm.IsDisposed)
            {
                _workingSpaceForm = new();
                _workingSpaceForm.Closed += (s, args) => this.Show();
                this.Hide();
                _workingSpaceForm.Show();
            }
        }
    }
}