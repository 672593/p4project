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
    public class Bestelling_DAO : Base
    {
        // Made by Faruk Bikmaz
        public List<Bestelling> Db_Get_All_Orders()
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery("GetAllOrders", sqlParameters));
        }
        private List<Bestelling> ReadTables(DataTable dataTable)
        {

            List<Bestelling> bestelling = new List<Bestelling>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bestelling be = new Bestelling()
                {
                    orderTableId = (int)dr["orderTableId"],
                   // employeeId = (int)dr["employeeId"],
                    orderId = (int)dr["orderId"],
                    currentDate = (DateTime)dr["currentDate"],
                    totalPrice = (decimal)dr["totalPrice"],
                    comment = (string)dr["comment"],

                };
                bestelling.Add(be);
            }
            return bestelling;
        }

        public void InsertBestelling(Bestelling be)
        {
            SqlParameter sqlq1 = new SqlParameter("@orderTableId", be.orderTableId);
            SqlParameter sqlq2 = new SqlParameter("@employeeId", be.employeeId);
            SqlParameter sqlq3 = new SqlParameter("@currentDate", be.currentDate);
            SqlParameter sqlq4 = new SqlParameter("@totalPrice", be.totalPrice);
            SqlParameter sqlq5 = new SqlParameter("@comment", be.comment);

            SqlParameter[] sqlParameters = new SqlParameter[] { sqlq1, sqlq2, sqlq3, sqlq4, sqlq5 };

            ExecuteEditQuery("CreateOrder", sqlParameters);
        }

        public int getLastOrderId()
        {
            int orderId = 0;
            DataTable order = ExecuteSelectQuery("GetLastOrderId");
            foreach (DataRow item in order.Rows) { orderId = (int)item["orderId"]; }

            return orderId;
        }
    }
}
