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
        public List<BestellingItem> Db_Get_OrderItemSpec(int orderTableId)
        {
            SqlParameter sqlq = new SqlParameter("@orderTableId", orderTableId);
            return ReadTables2(ExecuteSelectQuery("GetSpecificOrderItem", sqlq));
        }
        private List<BestellingItem> ReadTables(DataTable dataTable)
        {
            List<BestellingItem> bestellingitem = new List<BestellingItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                BestellingItem bi = new BestellingItem()
                {
                    orderId = (int)dr["orderId"],
                    orderTableId = (int)dr["orderTableId"],
                    //menuItemId = (int)dr["menuItemId"],
                    //orderItemId = (int)dr["orderItemId"],
                    itemName = (string)dr["itemName"],
                    orderItemStatus = (bool)dr["orderItemStatus"],
                    amount = (int)dr["amount"],
                    // orderTime = (DateTime)dr["orderTime"],
                };
                bestellingitem.Add(bi);
            }
            return bestellingitem;
        }

        private List<BestellingItem> ReadTables2(DataTable dataTable)
        {
            List<BestellingItem> bestellingitem = new List<BestellingItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                BestellingItem bi = new BestellingItem()
                {
                    orderId = (int)dr["orderId"],
                    orderTableId = (int)dr["orderTableId"],
                    //menuItemId = (int)dr["menuItemId"],
                    //orderItemId = (int)dr["orderItemId"],
                    itemName = (string)dr["itemName"],
                    orderItemStatus = (bool)dr["orderItemStatus"],
                    amount = (int)dr["amount"],
                    // orderTime = (DateTime)dr["orderTime"],
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

        public void UpdateAmountOrderItem(int orderId, int amount)
        {
            SqlParameter sqlq = new SqlParameter("@orderId", orderId);
            SqlParameter sqlq1 = new SqlParameter("@amount", amount);
            SqlParameter[] sqlParameters = new SqlParameter[] { sqlq, sqlq1 };

            ExecuteEditQuery("EditOrderItemAmount", sqlParameters);
        }

        public void InsertBestellingItem(BestellingItem be)
        {
            SqlParameter sqlq5 = new SqlParameter("@orderId", be.orderId);
            SqlParameter sqlq6 = new SqlParameter("@menuItemId", be.menuItemId);
            SqlParameter sqlq7 = new SqlParameter("@orderTime", be.orderTime);
            SqlParameter sqlq8 = new SqlParameter("@amount", be.amount);
            SqlParameter sqlq9 = new SqlParameter("@price", be.price);
            SqlParameter sqlq10 = new SqlParameter("@orderItemStatus", be.orderItemStatus);
            SqlParameter[] sqlParameters = new SqlParameter[] { sqlq5, sqlq6, sqlq7, sqlq8, sqlq9, sqlq10 };

            ExecuteEditQuery("CreateOrderitem", sqlParameters);
        }
        public int GetLastOrderItemId()
        {
            int orderItemId = 0;
            DataTable order = ExecuteSelectQuery("GetLastOrderItemId");
            foreach (DataRow item in order.Rows) { orderItemId = (int)item["orderItemId"]; }

            return orderItemId;
        }        
        public List<BestellingItem> GetAllOrderTableId()
        {
            SqlParameter[] sqlp = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery("GetAllOrderTableId", sqlp));
        }
    }
}
