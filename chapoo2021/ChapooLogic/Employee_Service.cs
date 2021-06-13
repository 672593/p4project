using System;
using ChapooDAL;
using ChapooModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ChapooLogic
{
    // made by Jelle de Vries
    public class Employee_Service
    {
        Employee_DAO Employee_DAO = new Employee_DAO();
        private PasswordWithSaltHasher _passwordHasher = new PasswordWithSaltHasher();

        public Employee GetCredentials(int id, string password)
        {
            return Employee_DAO.GetCredentials(id, password);
        }
        public string GetSalt(Employee Employee)
        {
           string salt = Employee_DAO.GetSalt(Employee);

            return salt;
        }

        public HashWithSalt CheckHash(string password, string salt)
        {
            return _passwordHasher.HashWithSaltCheck(password, salt, SHA256.Create());
        }

        public string forgotpassquestion(Employee employee)
        {
            return Employee_DAO.GetPassQuestion(employee);
        }

        public string forgotpass(Employee employee)
        {
            return Employee_DAO.Getforgotpass(employee);
        }

        public void Alterpass(int gebruikersnaam, string hash, string salt)
        {
            Employee_DAO.AlterPass(gebruikersnaam, hash, salt);
        }


    }
}
