namespace EmployeeAccountingSystem
{
    public partial class LogInForm : Form
    {
        SignUpForm _signUpForm;
        public LogInForm()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (_signUpForm == null||_signUpForm.IsDisposed) 
            {
                _signUpForm = new();
                _signUpForm.Closed += (s, args) => this.Show();
                this.Hide();
                _signUpForm.Show();
            }
        }
    }
}