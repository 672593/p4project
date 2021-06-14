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

        public int validlogin;


        public Employee(string txt_gebruikersnaam, string txt_wachtwoord, int gebruikersId, string vraag, string antwoord, int functieId)
        {
            username = txt_gebruikersnaam;
            password = txt_wachtwoord;
            employeeId = gebruikersId;
            SecretQuestion = vraag;
            SecretAnswer = antwoord;
            FunctionId = functieId;
        }

        public Employee()
        {
        }

        public enum FunctieNaam
        {
            Bediening = 1, Kok, Barman, Eigenaar
        }
    }
}
