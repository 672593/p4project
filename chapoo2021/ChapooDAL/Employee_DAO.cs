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
        private SqlConnection dbConnect;

        public Employee_DAO()
        {
            string connstring = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            dbConnect = new SqlConnection(connstring);

        }
        public Employee GetWorkerLogin(string username, string password)
        {
            string query = "SELECT FROM WHERE" ;
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("Username", username),
                new SqlParameter("Password", password)
            };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        private Employee ReadTable(DataTable dataTable)
        {
            Employee login = new Employee();
            try
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    login.EmployeeId = (int)dr["EmployeeId"];
                    login.Name = (string)dr["Name"];
                    login.FunctionId = (int)dr["FunctionId"];
                };
                return login;
            }
            catch (Exception)
            {
                return login;
            }

        }








    }
}
