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
    public class Function_DAO : Base
    {
        public int Function(Employee Employee)
        {

            SqlParameter[] sqlp = new SqlParameter[1]
            {
                    new SqlParameter("@id", Employee.employeeId)
            };

            DataTable acc = ExecuteSelectQuery("GetFunction", sqlp);

            foreach (DataRow dr in acc.Rows)
            {
                Employee.FunctionId = (int)dr["functionID"];
            }
            return Employee.FunctionId;
        }
    }
}
