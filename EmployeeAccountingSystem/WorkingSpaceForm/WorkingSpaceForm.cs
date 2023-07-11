using EmployeeAccountingSystem.AddingEmployee;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeAccountingSystem
{
    public partial class WorkingSpaceForm : Form
    {
        DataBase1 _dataBase = new DataBase1();
        Account account;
        AddingEmployeeForm _addingEmployeeForm;
        public WorkingSpaceForm(Account account)
        {
            InitializeComponent();
            this.account = account;
            UpdateComboBox();
        }
        private void UpdateComboBox()
        {
            _dataBase.OpenConnection();
            string query = $"SELECT Id FROM Employee WHERE UserNAme='{account.UserName}';";
            SqlCommand sqlCommand = new SqlCommand(query, _dataBase.GetConnection());
            List<string> values = new List<string>();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string value = reader.GetGuid(0).ToString();
                values.Add(value);
            }
            comboBox1.Items.Clear();
            foreach (var item in values)
            {
                comboBox1.Items.Add(item);
            }
            _dataBase.CloseConnection();
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Status.Text = "";
            _dataBase.OpenConnection();
            string ID = comboBox1.SelectedItem.ToString();
            string query = $"SELECT Name, Surname, DateOfBirth,PhoneNumber,Salary,City,JobTitle FROM Employee WHERE Id='{ID}';";
            SqlCommand sqlCommand = new SqlCommand(query, _dataBase.GetConnection());
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                NameTextBox.Text = reader.GetString(0);
                SurnameTextBox.Text = reader.GetString(1);
                DateOfBirthTextBox.Text = reader.GetDateTime(2).ToString();
                PhoneNumberTextBox.Text = reader.GetString(3);
                SalaryTextBox.Text = reader.GetDecimal(4).ToString();
                CityTextBox.Text = reader.GetString(5);
                JobTitleTextBox.Text = reader.GetString(6);
                IDTextBox.Text = ID;

            }
            _dataBase.CloseConnection();
        }


        private void AddEmplyeeButton_Click(object sender, EventArgs e)
        {
            if (_addingEmployeeForm == null || _addingEmployeeForm.IsDisposed)
            {
                _addingEmployeeForm = new(account);
                _addingEmployeeForm.ShowDialog();
                _addingEmployeeForm.Dispose();
                UpdateComboBox();
            }
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(comboBox1?.SelectedItem?.ToString())) return;
            string ID = comboBox1.SelectedItem.ToString();
            string query = $"DELETE FROM Employee WHERE Id='{ID}';";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, _dataBase.GetConnection());
                _dataBase.OpenConnection();
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    Status.ForeColor = Color.Green;
                    Status.Text = "Success";
                    UpdateComboBox();
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
