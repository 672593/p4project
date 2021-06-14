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
        static Function_DAO functie_db = new Function_DAO();
        public int GetFunctie(Employee employee)
        {
            return functie_db.Function(employee);
        }
    }


}
