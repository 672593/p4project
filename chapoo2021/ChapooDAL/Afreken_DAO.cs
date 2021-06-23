using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ChapooDAL
{
    public class Afreken_DAO : Base
    {
        public List<OrdersTable> ReadAllOrdersFromTable(int orderId)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@orderId", orderId)
            };
            return GetAllOrdersFromTable(ExecuteSelectQuery("GetAllOrdersFromTable", sqlParameters));
        }

        private List<OrdersTable> GetAllOrdersFromTable(DataTable dataTable)
        {
            List<OrdersTable> ordersTables = new List<OrdersTable>();
            foreach (DataRow item in dataTable.Rows)
            {
                OrdersTable orderTable = new OrdersTable
                {
                    MenuItemId = (int)item["menuItemId"],
                    Amount = (int)item["amount"],
                    ItemName = (string)item["itemName"],
                    Price = (decimal)item["price"],
                    OrderTableId = (int)item["orderTableId"],
                    OrderId = (int)item["orderId"]
                };

                ordersTables.Add(orderTable);
            }
            return ordersTables;
        }
        public void ReceiptCustomer(int OrderId, int PayMethodId, decimal VatPercentage, decimal Tip, decimal PaidPrice, decimal TotalPrice)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@OrderId", OrderId),
                new SqlParameter("@PayMethodId", PayMethodId),
                new SqlParameter("@VatPercentage", VatPercentage),
                new SqlParameter("@Tip", Tip),
                new SqlParameter("@PaidPrice", PaidPrice),
                new SqlParameter("@TotalPrice", TotalPrice)
            };
            ExecuteEditQuery("CreateReceipt", sqlParameters);
        }
        public List<string> GetAllPaymethods()
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadAllPaymethods(ExecuteSelectQuery("GetAllPaymethods", sqlParameters));
        }
        public List<string> ReadAllPaymethods(DataTable dt)
        {
            List<string> modelList = new List<string>();
            foreach (DataRow item in dt.Rows)
            {
                string payMethodName = item["payMethodName"].ToString();
                modelList.Add(payMethodName);
            }
            return modelList;
        }
    }
}