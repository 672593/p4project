using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;
namespace ChapooModel
{
    public class User
    {
        private int _id;
        private string name;
        private string _employeeCode;
        private int _functionId;
        private string _functionName;
        private HashWithSalt _hashWithSalt;
        private string _secretQuestion;
        private string _secretAnswer;
        private string _hash;
        private string _salt;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => name; set => name = value; }
        public string EmployeeCode { get => _employeeCode; set => _employeeCode = value; }
        public int FunctionId { get => _functionId; set => _functionId = value; }
        public string FunctionName { get => _functionName; set => _functionName = value; }
        public HashWithSalt HashWithSalt { get => _hashWithSalt; set => _hashWithSalt = value; }
        public string SecretQuestion { get => _secretQuestion; set => _secretQuestion = value; }
        public string SecretAnswer { get => _secretAnswer; set => _secretAnswer = value; }
        public string Hash { get => _hash; set => _hash = value; }
        public string Salt { get => _salt; set => _salt = value; }
    }
}