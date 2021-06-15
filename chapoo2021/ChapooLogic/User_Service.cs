using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

//Anel Gusinac
namespace ChapooLogic
{
    public class User_Service
    {
        private User_DAO _userDAO;

        //1capital, 1lowercase, 1digit, 1special sign
        private string _specialCharsPattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,20}$";
        private PasswordWithSaltHasher _passwordHasher = new PasswordWithSaltHasher();

        public User_Service()
        {
            _userDAO = new User_DAO();
        }
        public void InsertUser(User user)
        {
            try
            {
                _userDAO.InsertUser(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public List<User> GetAllUsers()
        {
            try
            {
                return _userDAO.GetAllUsers();
            }
            catch (Exception e)
            {
                List<User> listUsers = new List<User>();
                Console.WriteLine(e.Message);
                User u = new User();

                u.FunctionName = "No Data Found.";

                return listUsers;
            }

        }
        public User GetUserById(int userId)
        {
            try
            {
                return _userDAO.GetUserById(userId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                User u = new User();

                u.FunctionName = "No Data Found.";
                return u;
            }
        }
        public void DeleteUser(int userId)
        {
            try
            {
                _userDAO.DeleteUser(userId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void UpdateUser(User user)
        {
            try
            {
                _userDAO.UpdateUser(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public HashWithSalt PasswordToSHA256(string password)
        {
            return _passwordHasher.HashWithSalt(password, 64, SHA256.Create());
        }
        public bool PasswordIsEqual(string password1, string password2)
        {
            if (password1 == password2)
                return true;
            else
                return false;
        }
        public bool CheckPasswordPattern(string password)
        {
            if (Regex.Match(password, _specialCharsPattern).Success)
            {
                return true;
            }
            return false;
        }
        public List<string> GetAllFunctions()
        {
            try
            {
                return _userDAO.GetAllFunctions();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                List<string> strings = new List<string>();
                strings.Add("No functions were found.");
                return strings;
            }

        }
    }
}