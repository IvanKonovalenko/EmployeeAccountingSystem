﻿using EmployeeAccountingSystem.AddingEmployee;
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
        }

        private void AddEmplyeeButton_Click(object sender, EventArgs e)
        {
            if (_addingEmployeeForm == null || _addingEmployeeForm.IsDisposed)
            {
                _addingEmployeeForm = new(account);
                _addingEmployeeForm.Closed += (s, args) => this.Show();
                this.Hide();
                _addingEmployeeForm.Show();
            }
        }
    }
}
