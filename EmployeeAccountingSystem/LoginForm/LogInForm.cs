using EmployeeAccountingSystem.DataBase;
using System.Data;
using System.Data.SqlClient;

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
            string query = $"SELECT * FROM Accounts WHERE UserName='{UsernameTextBox.Text}' AND Passwordd='{PasswordTextBox.Text}';";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable table=new DataTable();     
            SqlCommand comand = new SqlCommand(query,_dataBase.GetConnection());
            sqlDataAdapter.SelectCommand = comand;
            sqlDataAdapter.Fill(table);

            if (table.Rows.Count == 0) return;
            Account account=new Account(UsernameTextBox.Text, PasswordTextBox.Text);
            if (_workingSpaceForm == null || _workingSpaceForm.IsDisposed)
            {
                _workingSpaceForm = new(account);
                _workingSpaceForm.Closed += (s, args) => this.Show();
                this.Hide();
                _workingSpaceForm.Show();
            }
        }
    }
}