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
    public class KeukenBestellingDAO : Base
    {
        public List<KeukenBestellingModel> Db_Get_All_Keuken_Bestellingen()
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery("GetAllKeukenBestellingen", sqlParameters));
        }
        private List<KeukenBestellingModel> ReadTables(DataTable dataTable)
        {
            List<KeukenBestellingModel> keukenOrderList = new List<KeukenBestellingModel>();
            foreach (DataRow dr in dataTable.Rows)
            {
                KeukenBestellingModel bbestelItem = new KeukenBestellingModel()
                {
                    OrderItemID = (int)dr["orderItemId"],
                    MenuItemId = (int)dr["menuItemId"],
                    OrderItemStatus = (Boolean)dr["orderItemStatus"],
                    orderTableId = (int)dr["orderTableId"],
                    Price = (Decimal)dr["price"],
                    Name = (string)(dr["itemName"].ToString())
                };
                keukenOrderList.Add(bbestelItem);

            }
            return keukenOrderList;
        }

        public void WijzigBestellingKeuken(KeukenBestellingModel act)
        {
            SqlParameter sqlparameter1 = new SqlParameter("@OrderItemId", act.OrderItemID);
            SqlParameter sqlparameter2 = new SqlParameter("@OrderStatus", act.OrderItemStatus);
            SqlParameter[] sqlparameter = new SqlParameter[] { sqlparameter1, sqlparameter2};
            ExecuteEditQuery("UpdateOrderStatus", sqlparameter);
        }
    }
}
