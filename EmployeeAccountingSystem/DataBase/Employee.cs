using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccountingSystem.DataBase
{
    class Employee
    {
        public Employee(int id,string name, string surname, DateTime dateOFBirth, string phoneNumber, decimal salary, string city, string jobTitle, string userName)
        {
            Id = id;
            Name = name;
            Surname = surname;
            DateOFBirth = dateOFBirth;
            PhoneNumber = phoneNumber;
            Salary = salary;
            City = city;
            JobTitle = jobTitle;
            UserName = userName;
        }
        public int Id { get; init; }
        public string Name { get; init; }
        public  string Surname { get; init; }
        public DateTime DateOFBirth { get; init; }
        public string PhoneNumber { get; init; }
        public decimal Salary { get; set; }
        public string City { get; init; }
        public string JobTitle { get; init; }
        public string UserName { get; init; }
    }
}
