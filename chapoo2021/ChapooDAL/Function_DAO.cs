using System;
using ChapooDAL;
using ChapooModel;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooDAL
{
        public class Functie_DAO : Base
        {
            public int Function(Employee Employee)
            {
                String FunctieQuery = $"select functieId from Gebruiker where Gebruikersnaam = '{account.gebruikersnaam}'";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                OpenConnection();
                DataTable readFunctie = ExecuteSelectQuery(FunctieQuery, sqlParameters);
                foreach (DataRow dr in readFunctie.Rows)
                {
                    Employee.FunctionId = (int)dr["functionID"];
                }
                return Employee.FunctionId;
            }
        }
}
