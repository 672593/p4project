using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooLogic
{
    public class Bestelling_Service
    {
        Bestelling_DAO bestellingDAO = new Bestelling_DAO();
        public List<Bestelling> GetAllOrders()
        {
            try
            {

                return bestellingDAO.Db_Get_All_Orders();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                List<Bestelling> bestelling = new List<Bestelling>();

                return bestelling;
            }
        }

        public bool InsertBestelling(Bestelling be)
        {
            try
            {
                bestellingDAO.InsertBestelling(be);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public int GetLastOrderId()
        {
            return bestellingDAO.getLastOrderId();
        }


    }
}
