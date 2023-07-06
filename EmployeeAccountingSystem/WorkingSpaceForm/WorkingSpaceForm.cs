using EmployeeAccountingSystem.AddingEmployee;
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
        AddingEmployeeForm _addingEmployeeForm;
        public WorkingSpaceForm()
        {
            InitializeComponent();
        }

        private void AddEmplyeeButton_Click(object sender, EventArgs e)
        {
            if (_addingEmployeeForm == null || _addingEmployeeForm.IsDisposed)
            {
                _addingEmployeeForm = new();
                _addingEmployeeForm.Closed += (s, args) => this.Show();
                this.Hide();
                _addingEmployeeForm.Show();
            }
        }
    }
}
