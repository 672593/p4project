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
        private string _specialCharsPattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,20}$";
        private PasswordWithSaltHasher _passwordHasher = new PasswordWithSaltHasher();

        public User_Service()
        {
             _userDAO = new User_DAO();
        }
        public void InsertUser(User user)
        {
            _userDAO.InsertUser(user);
        }
        public List<User> GetAllUsers()
        {
            return _userDAO.GetAllUsers();
        }
        public User GetUserById(int userId)
        {
            return _userDAO.GetUserById(userId);
        }
        public void DeleteUser(int userId)
        {
            _userDAO.DeleteUser(userId);
        }
        public void UpdateUser(User user)
        {
            _userDAO.UpdateUser(user);
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
            return _userDAO.GetAllFunctions();
        }
    }
}