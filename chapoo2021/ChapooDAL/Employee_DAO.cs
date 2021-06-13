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
    // Made by Jelle de Vries
    public class Employee_DAO : Base
    {
        // get all employees
        /*
        public List<Employee> DB_Get_All_Accounts()
        {
            SqlParameter[] sqlp = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery("GetEmployees", sqlp));
        }
        */

        // get credentials (salt and hashed password) for employeeID @id
        public Employee GetCredentials(int id, string password)
        {
            SqlParameter[] sqlp = new SqlParameter[2]
            {
                new SqlParameter("@id", id),
                new SqlParameter("@password", password)
            };
            //SELECT COUNT(*) FROM employee WHERE employeeId = @id AND hashedPassword = @password;
            DataTable results = ExecuteSelectQuery("GetCredentials", sqlp);

            // the parameters get returned as a new employee
            Employee huidigGebruiker = new Employee();
            //check if employee login is valid  
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

        // get salt for user with @id
        public string GetSalt(Employee employee)
        {

            SqlParameter[] sqlp = new SqlParameter[1]
            {
                new SqlParameter("@id", employee.employeeId)
            };
            //SELECT Salt From employee WHERE employeeId = @id;
            DataTable acc = ExecuteSelectQuery("GetSalt", sqlp);
            foreach (DataRow dr in acc.Rows)
            {
                employee.Salt = (string)dr["Salt"];
            }
            return employee.Salt;
        }

        public string GetPassQuestion(Employee employee)
        {
            SqlParameter[] sqlp = new SqlParameter[1]
            {
                new SqlParameter("@id", employee.username)
            };
            DataTable em = ExecuteSelectQuery("GetPassQ", sqlp);

            foreach (DataRow dr in em.Rows)
            {
                employee.SecretQuestion = (string)dr["SecretQuestion"];
            }

            return employee.SecretQuestion;
        }

        public string Getforgotpass(Employee employee)
        {
            SqlParameter[] sqlp = new SqlParameter[1]
            {
                new SqlParameter("@id", employee.username)
            };
            DataTable em = ExecuteSelectQuery("GetPassA", sqlp);

            foreach (DataRow dr in em.Rows)
            {
                employee.SecretAnswer = (string)dr["SecretAnswer"];
            }

            return employee.SecretAnswer;
        }

        public void AlterPass(int gebruikersnaam, string hash, string salt)
        {
            // alter hash
            SqlParameter[] sqlp = new SqlParameter[2]
            {
                new SqlParameter("@id", gebruikersnaam),
                new SqlParameter("@hash", hash)
            };

            ExecuteEditQuery("AlterHash", sqlp);

            // alter salt
            SqlParameter[] sqlq = new SqlParameter[2]
            {
                new SqlParameter("@id", gebruikersnaam),
                new SqlParameter("@salt", salt)
            };

            ExecuteEditQuery("AlterSalt", sqlq);
        }




    }
}
