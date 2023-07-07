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
                string value=reader.GetGuid(0).ToString();
                values.Add(value);
            }
            comboBox1.Items.Clear();
            foreach (var item in values)
            {
                comboBox1.Items.Add(item);
            }
            _dataBase.CloseConnection();
        }
        private void AddEmplyeeButton_Click(object sender, EventArgs e)
        {
            if (_addingEmployeeForm == null || _addingEmployeeForm.IsDisposed)
            {
                _addingEmployeeForm = new(account);
                _addingEmployeeForm.ShowDialog();
                UpdateComboBox();
            }
        }

       
    }
}
