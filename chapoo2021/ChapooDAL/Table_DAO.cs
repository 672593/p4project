using ChapooModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooDAL
{
    public class Table_DAO : Base
    {
        public List<Table> Db_Get_Tables()
        {
            SqlParameter[] sqlp = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery("GetTables", sqlp));
        }

        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {
                    tableId = (int)dr["tableId"],
                };
                tables.Add(table);
            }
            return tables;
        }

        private List<Table> ReadStatus(DataTable dataTable)
        {
            List<Table> tafels = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table tafel = new Table()
                {
                    tableId = (int)dr["tableId"],
                    TafelStatusId = (int)dr["tableStatusId"],
                };
                tafels.Add(tafel);
            }
            return tafels;
        }

        private List<Table> ReadOrderStatus(DataTable dataTable)
        {
            List<Table> tafels = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table tafel = new Table()
                {
                    orderid = (int)dr["orderid"],
                    orderTableId = (int)dr["orderTableid"],
                    currentDate = (DateTime)dr["currentDate"]
                };
                tafels.Add(tafel);
            }
            return tafels;
        }

        public List<Table> Get_Tafel_Data() // made by Jelle de Vries. Get table data from database
        {
            SqlParameter[] sqlp = new SqlParameter[0];
            return ReadStatus(ExecuteSelectQuery("GetTafelStatus", sqlp));
        }


        public List<Table> GetOrderStatus() // made by Jelle de Vries. Get order data from database
        {
            SqlParameter[] sqlp = new SqlParameter[0];
            return ReadOrderStatus(ExecuteSelectQuery("GetOrderStatus", sqlp));
        }
    }
}
