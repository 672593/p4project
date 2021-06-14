using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class Afreken_Service
    {
        readonly Afreken_DAO AfrekenDao = new Afreken_DAO();

        public List<OrdersTable> GetAllOrdersFromTable(int orderId)
        {
            try
            {
                List<OrdersTable> orderTable = AfrekenDao.ReadAllOrdersFromTable(orderId);
                return orderTable;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                List<OrdersTable> orderTable = new List<OrdersTable>();
                OrdersTable bi = new OrdersTable
                {
                    //Test values
                    MenuItemId = 99,
                    Amount = 99,
                    ItemName = "Test, it's not working correctly",
                    Price = 99,
                    OrderTableId = 99
                };

                orderTable.Add(bi);
                return orderTable;
            }
        }
        public void ReceiptCustomer(int OrderId, int PayMethodId, decimal VatPercentage, decimal Tip, decimal PaidPrice, decimal TotalPrice)
        {
            try
            {
                AfrekenDao.ReceiptCustomer(OrderId, PayMethodId, VatPercentage, Tip, PaidPrice, TotalPrice);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

        }
        public List<string> GetAllPaymethods()
        {
            try
            {
                List<string> customerReceipt = AfrekenDao.GetAllPaymethods();
                return customerReceipt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                List<string> customerReceipt = new List<string>();
                CustomerReceipt bi = new CustomerReceipt
                {
                    //Test values
                    ReceiptId = 99
                };

                return customerReceipt;
            }
        }
    }
}