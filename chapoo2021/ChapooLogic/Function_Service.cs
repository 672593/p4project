using System;
using ChapooDAL;
using ChapooModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooLogic
{
    public class Function_Service
    {
        static Functie_DAO functie_db = new Functie_DAO();
        public int GetFunctie(Employee employee)
        {
            return functie_db.Function(employee);
        }
    }
        
        
}
