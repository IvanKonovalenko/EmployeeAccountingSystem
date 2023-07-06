using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccountingSystem.DataBase
{
    public class DataBase1
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=IVAN\SQLEXPRESS; Initial Catalog=EmployeeAccountingSystemDB; Integrated Security=True");
        public void OpenConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed) _connection.Open();
        }
        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open) _connection.Close();
        }
        public SqlConnection GetConnection() => _connection;
    }
}
