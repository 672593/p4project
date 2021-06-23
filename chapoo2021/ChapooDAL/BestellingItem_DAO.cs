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
    public class BestellingItem_DAO : Base
    {
        // Made by Faruk Bikmaz
        public List<BestellingItem> Db_Get_OrderItem()
        {
            SqlParameter[] sqlp = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery("GetAllOrderItem", sqlp));
        }

        private List<BestellingItem> ReadTables(DataTable dataTable)
        {
            List<BestellingItem> bestellingitem = new List<BestellingItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                BestellingItem bi = new BestellingItem()
                {
                    orderId = (int)dr["orderId"],
                    orderItemId = (int)dr["orderItemId"],
                    itemName = (string)dr["itemName"],
                    // menuItemId = (int)dr["menuItemId"],
                    amount = (int)dr["amount"],
                };
                bestellingitem.Add(bi);
            }
            return bestellingitem;
        }

        public void DeleteOrderItem(int menuItemId, int orderItemId)
        {
            SqlParameter sqlq = new SqlParameter("@menuItemId", menuItemId);
            SqlParameter sqlq1 = new SqlParameter("@orderItemId", orderItemId);
            SqlParameter[] sqlParameters = new SqlParameter[] { sqlq, sqlq1 };

            ExecuteEditQuery("DeleteOrderItem", sqlParameters);
        }

        public void DeleteOrder(int orderId)
        {
            SqlParameter sqlq = new SqlParameter("@orderId", orderId);
            SqlParameter[] sqlParameters = new SqlParameter[] { sqlq };

            ExecuteEditQuery("DeleteOrder", sqlParameters);
        }

        public void UpdateAmountOrderItem(int orderItemId, int amount)
        {
            SqlParameter sqlq = new SqlParameter("@orderItemId", orderItemId);
            SqlParameter sqlq1 = new SqlParameter("@amount", amount);
            SqlParameter[] sqlParameters = new SqlParameter[] { sqlq, sqlq1 };

            ExecuteEditQuery("EditOrderItemAmount", sqlParameters);
        }

        public void InsertBestelling(BestellingItem be)
        {
            SqlParameter sqlq = new SqlParameter("@orderItemId", be.orderItemId);
            SqlParameter sqlq5 = new SqlParameter("@orderId", be.orderId);
            SqlParameter sqlq6 = new SqlParameter("@menuItemId", be.menuItemId);
            SqlParameter sqlq7 = new SqlParameter("@orderTime", be.orderTime);
            SqlParameter sqlq8 = new SqlParameter("@amount", be.amount);
            SqlParameter sqlq9 = new SqlParameter("@price", be.price);
            SqlParameter sqlq10 = new SqlParameter("@orderItemStatus", be.orderItemStatus);
            SqlParameter[] sqlParameters = new SqlParameter[] { sqlq, sqlq5, sqlq6, sqlq7, sqlq8, sqlq9, sqlq10 };

            ExecuteEditQuery("CreateOrder", sqlParameters);
        }
        public int GetLastOrderItemId()
        {
            int orderItemId = 0;
            DataTable order = ExecuteSelectQuery("GetLastOrderItemId");
            foreach (DataRow item in order.Rows) { orderItemId = (int)item["orderItemId"]; }

            return orderItemId;
        }
        /*        public int GetPriceForOrderItem(int menuItemId)
                {
                    DataTable order = ExecuteSelectQuery("GetPriceForOrderItem");
                    foreach (DataRow item in order.Rows) { menuItemId = (int)item["menuItemId"]; }

                    return menuItemId;
                }*/
    }
}
