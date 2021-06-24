using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooLogic
{
    public class Table_Service
    {
        Table_DAO table_db = new Table_DAO();

        public List<Table> GetTables()
        {
            try
            {
                List<Table> table = table_db.Db_Get_Tables();
                return table;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                List<Table> table = new List<Table>();
                Table t = new Table();
                return table;
            }
        }

        public List<Table> GetTafelData()
        {
            return table_db.Get_Tafel_Data();
        }

        public List<Table> GetOrderStatus()
        {
            return table_db.GetOrderStatus();
        }
    }
}
