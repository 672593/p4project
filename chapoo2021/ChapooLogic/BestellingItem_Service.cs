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
            List<BestellingItem> bestellingitem = null;
            try
            {
                bestellingitem = _bestellingDAO.Db_Get_OrderItem();
                return bestellingitem;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return bestellingitem;
            }
        }

        public List<BestellingItem> GetOrderItemSpec(int orderTableId)
        {
            List<BestellingItem> bestellingitem = null;
            try
            {
                bestellingitem = _bestellingDAO.Db_Get_OrderItemSpec(orderTableId);
                return bestellingitem;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return bestellingitem;
            }
        }

        public List<BestellingItem> GetAllOrderTableId()
        {
            List<BestellingItem> ordertableId = null;
            try
            {
                ordertableId = _bestellingDAO.GetAllOrderTableId();
                return ordertableId;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return ordertableId;
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

        public bool UpdateAmountOrderItem(int orderId, int amount)
        {
            try
            {
                _bestellingDAO.UpdateAmountOrderItem(orderId, amount);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool InsertBestellingItem(BestellingItem be)
        {
            try
            {
                _bestellingDAO.InsertBestellingItem(be);
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
