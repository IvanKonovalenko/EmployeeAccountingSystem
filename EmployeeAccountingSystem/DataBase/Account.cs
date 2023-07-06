using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccountingSystem.DataBase
{
    public class Account
    {
        public string UserName { get; init; }
        public string Password { get; init; }
        public Account(string username, string password) 
        {
            UserName = username;
            Password = password;
        }
    }
}
