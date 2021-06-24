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
        private Afreken_DAO AfrekenDao = new Afreken_DAO();

        public List<BestellingItem> GetAllOrdersFromTable(int orderId)
        {
            try
            {
                return AfrekenDao.ReadAllOrdersFromTable(orderId);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
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

                throw new Exception(e.Message);
            }
        }
        public List<string> GetAllPaymethods()
        {
            try
            {
                return AfrekenDao.GetAllPaymethods();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public bool CheckBetaald(int orderID)
        {
            try
            {
                return AfrekenDao.CheckBetaald(orderID);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}