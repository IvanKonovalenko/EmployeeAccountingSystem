using EmployeeAccountingSystem.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
