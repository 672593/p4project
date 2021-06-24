using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using ChapooModel;

namespace ChapooDAL
{
    public class KeukenBarBestelling_DAO : Base
    {
        public List<KeukenBarBestelling> Db_Get_All_Keuken_Bestellingen(Boolean keuken, Boolean openstaand)
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            if (keuken == true)
            {
                if (openstaand == true)
                {
                    return ReadTables(ExecuteSelectQuery("GetAllKeukenBestellingen", sqlParameters));
                }
                else
                {
                    return ReadTables(ExecuteSelectQuery("GetAllKeukenGereed", sqlParameters));
                }
            }
            else
            {
                if (openstaand == true)
                {
                    return ReadTables(ExecuteSelectQuery("GetAllBarBestellingen", sqlParameters));
                }
                else
                {
                    return ReadTables(ExecuteSelectQuery("GetAllBarGereed", sqlParameters));
                }
            }

        }
        private List<KeukenBarBestelling> ReadTables(DataTable dataTable)
        {
            List<KeukenBarBestelling> OrderList = new List<KeukenBarBestelling>();
            foreach (DataRow dr in dataTable.Rows)
            {
                KeukenBarBestelling bestelItem = new KeukenBarBestelling()
                {
                    OrderItemID = (int)dr["orderItemId"],
                    orderTableId = (int)dr["orderTableId"],
                    Name = (string)(dr["itemName"].ToString()),
                    Amount = (int)(dr["amount"]),
                    Datum = (DateTime)(dr["currentDate"]),
                    Comment = (string)(dr["comment"].ToString()),
                };
                OrderList.Add(bestelItem);

            }
            return OrderList;
        }

        public void WijzigBestelling(KeukenBarBestelling act)
        {
            SqlParameter sqlparameter1 = new SqlParameter("@OrderItemId", act.OrderItemID);
            SqlParameter sqlparameter2 = new SqlParameter("@OrderStatus", act.OrderItemStatus);
            SqlParameter[] sqlparameter = new SqlParameter[] { sqlparameter1, sqlparameter2 };
            ExecuteEditQuery("UpdateOrderStatus", sqlparameter);
        }

    }
}
