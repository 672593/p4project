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
    class Employee_DAO : Base
    {
        private SqlConnection dbConnect;

        public Employee_DAO()
        {
            string connstring = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            dbConnect = new SqlConnection(connstring);

        }
        public Employee GetWorkerLogin(string username, string password)
        {

        }









    }
}
