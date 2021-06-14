using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooLogic
{
    public class BestellingItem_Service
    {
        BestellingItem_DAO _bestellingDAO = new BestellingItem_DAO();
        public List<BestellingItem> GetBestellingItems()
        {
            try
            {
                List<BestellingItem> bestellingitem = _bestellingDAO.Db_Get_OrderItem();
                return bestellingitem;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                List<BestellingItem> bestellingitem = new List<BestellingItem>();
                BestellingItem bi = new BestellingItem();

                //Test values
                bi.orderId = 99;
                bi.orderItemId = 99;
                bi.itemName = "Test";
                bi.menuItemId = 99;
                bi.amount = 99;

                bestellingitem.Add(bi);
                return bestellingitem;
            }
        }

        public bool DeleteOrderItem(int menuItemId, int orderItemId)
        {
            try
            {
                _bestellingDAO.DeleteOrderItem(menuItemId, orderItemId);
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool DeleteOrder(int orderId)
        {
            try
            {
                _bestellingDAO.DeleteOrder(orderId);
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool UpdateAmountOrderItem(int orderItemId, int amount)
        {
            try
            {
                _bestellingDAO.UpdateAmountOrderItem(orderItemId, amount);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool InsertBestelling(BestellingItem be)
        {
            try
            {
                _bestellingDAO.InsertBestelling(be);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public int GetLastOrderItemId()
        {
            return _bestellingDAO.GetLastOrderItemId();
        }

        /*        public int GetPriceForOrderItem(int menuItemId)
                {
                    return _bestellingDAO.GetPriceForOrderItem(menuItemId);
                }*/
    }
}
