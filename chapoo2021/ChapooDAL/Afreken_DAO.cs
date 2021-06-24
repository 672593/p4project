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
        public List<BestellingItem> ReadAllOrdersFromTable(int orderId)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@orderId", orderId)
            };
            return GetAllOrdersFromTable(ExecuteSelectQuery("GetAllOrdersFromTable", sqlParameters));
        }

        private List<BestellingItem> GetAllOrdersFromTable(DataTable dataTable)
        {
            List<BestellingItem> ordersTables = new List<BestellingItem>();
            foreach (DataRow item in dataTable.Rows)
            {
                BestellingItem orderTable = new BestellingItem
                {
                    menuItemId = (int)item["menuItemId"],
                    amount = (int)item["amount"],
                    itemName = (string)item["itemName"],
                    price = (decimal)item["price"],
                    orderTableId = (int)item["orderTableId"],
                    orderId = (int)item["orderId"]
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
        public bool CheckBetaald(int tableId)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@tableId", tableId)
            };
            DataTable dt = ExecuteSelectQuery("CheckBetaald", sqlParameters);

            if (dt == null)
            {
                return true;
            }
            return false;
        }
    }
}