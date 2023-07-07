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
using System.Windows.Input;

namespace EmployeeAccountingSystem.AddingEmployee
{
    public partial class AddingEmployeeForm : Form
    {
        Account account;

        DataBase1 _dataBase = new DataBase1();
        public AddingEmployeeForm(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void AddEmplyeeButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameTextBox.Text) || String.IsNullOrEmpty(SurnameTextBox.Text) ||
                String.IsNullOrEmpty(DateOfBirthTextBox.Text) || String.IsNullOrEmpty(PhoneNumberTextBox.Text) ||
                String.IsNullOrEmpty(SalaryTextBox.Text) || String.IsNullOrEmpty(CityTextBox.Text) ||
                String.IsNullOrEmpty(JobTitleTextBox.Text)) { Status.ForeColor = Color.Red; Status.Text = "Error"; return; }
            string query = $"INSERT INTO Employee(Name,Surname,DateOfBirth,PhoneNumber,Salary,City,JobTitle,UserNAme) VALUES('{NameTextBox.Text}','{SurnameTextBox.Text}','{DateOfBirthTextBox.Text}','{PhoneNumberTextBox.Text}','{SalaryTextBox.Text}','{CityTextBox.Text}','{JobTitleTextBox.Text}','{account.UserName}');";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, _dataBase.GetConnection());
                _dataBase.OpenConnection();
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    Status.ForeColor = Color.Green;
                    Status.Text = "Success";
                }
                else
                {
                    Status.ForeColor = Color.Red;
                    Status.Text = "Error";
                }
            }
            catch
            {
                Status.ForeColor = Color.Red;
                Status.Text = "Error";
            }
            _dataBase.CloseConnection();
        }
    }
}
