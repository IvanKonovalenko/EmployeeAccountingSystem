using EmployeeAccountingSystem.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeAccountingSystem
{
    public partial class SignUpForm : Form
    {
        DataBase1 _dataBase = new DataBase1();
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(UsernameTextBox.Text) ||
                String.IsNullOrEmpty(PasswordTextBox.Text) ||
                String.IsNullOrEmpty(RetryPassword.Text) ||
                PasswordTextBox.Text != RetryPassword.Text)
            { Status.Text = "Error"; return; }


            string query = $"SELECT * FROM Accounts WHERE UserName='{UsernameTextBox.Text}';";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(query, _dataBase.GetConnection());
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(table);
            if (table.Rows.Count != 0) { Status.Text = "Error"; return; }

            query = $"INSERT INTO Accounts(UserName,Passwordd) VALUES ('{UsernameTextBox.Text}', '{PasswordTextBox.Text}')";
            command = new SqlCommand(query, _dataBase.GetConnection());
            _dataBase.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                Status.Text = "Success";
            }
            else
            {
                Status.Text = "Error";
            }
            _dataBase.CloseConnection();

        }
    }
}
