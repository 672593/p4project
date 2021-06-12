using System;
using ChapooDAL;
using ChapooModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooLogic
{
    // made by Jelle de Vries
    public class Employee_Service
    {
        Employee_DAO Employee_DAO = new Employee_DAO();

        public Employee GetCredentials(int id, string password)
        {
            return Employee_DAO.GetCredentials(id, password);
        }



        public string GetSalt(Employee Employee)
        {
            return Employee_DAO.GetSalt(Employee);
        }


    }
    
}
