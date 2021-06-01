using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Employee
    {
        public string Name;
        public string username;
        public string password;
        public int employeeId;
        public int FunctionId;
        public String SecretQuestion { get; set; }
        public String SecretAnswer { get; set; }
        public String Salt { get; set; }

    }
}
