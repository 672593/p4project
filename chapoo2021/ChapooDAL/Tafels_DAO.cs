using ChapooModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ChapooDAL
{
    public class Tafels_DAO : Base
    {
        // Made by Faruk Bikmaz

        public List<Tafels> Db_Get_All_Free_Tables()
        {
            SqlParameter[] sqlp = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery("GetAllFreeTables", sqlp));
        }

        private List<Tafels> ReadTables(DataTable dataTable)
        {
            List<Tafels> tafels = new List<Tafels>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Tafels t = new Tafels();
                t.tableId = (int)dr["TableId"];
                tafels.Add(t);
            }
            return tafels;
        }
    }
}
