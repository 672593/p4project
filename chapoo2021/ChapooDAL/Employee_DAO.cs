using ChapooModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooDAL
{
    public class Employee_DAO : Base
    {
        public List<Employee> DB_Get_All_Accounts()
        {
            SqlParameter[] sqlp = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery("GetEmployees", sqlp));
        }

        public Employee GetCredentials(int id, string password)
        {
            SqlParameter[] sqlp = new SqlParameter[2]
            {
                new SqlParameter("@id", id),
                new SqlParameter("@password", id)
            };

            DataTable results = new DataTable;
            results = ExecuteSelectQuery("GetCredentials", sqlp);

            Employee huidigGebruiker = new Employee();
            huidigGebruiker.username = id.ToString();
            if (results.Rows[0][0].ToString() == "1")
            {
                huidigGebruiker.validlogin = 1;
                return huidigGebruiker;
            }
            else
            {
                huidigGebruiker.validlogin = 0;
                return huidigGebruiker;
            }

        }




        public List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee()
                {
                    Name = (String)dr["employeeName"],
                    password = (String)dr["hashedPassword"],
                    employeeId = (int)dr["employeeid"],
                    SecretQuestion = (String)dr["secretQuestion"],
                    SecretAnswer = (String)dr["secretAnswer"],
                    FunctionId = (int)dr["functionId"]
                };
                employees.Add(employee);
            }
            return employees;
        }

        public string GetSalt(Employee employee)
        {
            
            String query = $"SELECT Salt From Gebruiker WHERE Gebruikersnaam = '{employee.employeeId}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            OpenConnection();
            DataTable acc = ExecuteSelectQuery(query, sqlParameters);
            foreach (DataRow dr in acc.Rows)
            {
                employee.Salt = (String)dr["Salt"];
            }
            return employee.Salt;
        }






    }
}
