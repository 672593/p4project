using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooLogic
{
    // Made by Faruk Bikmaz
    public class Menu_Service
    {
        private Menu_DAO _menuDAO = new Menu_DAO();
        public List<Lunch> GetLunch()
        {
            try
            {
                List<Lunch> lunch = _menuDAO.Db_Get_Lunch();
                return lunch;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                List<Lunch> lunch = new List<Lunch>();
                Lunch l = new Lunch();

                //Test values
                l.itemName = "Geen LUNCH vandaag";
                l.price = 100;

                lunch.Add(l);
                return lunch;
            }
        }

        public List<Diner> GetDiner()
        {
            try
            {
                List<Diner> diner = _menuDAO.Db_Get_Diner();
                return diner;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                List<Diner> diner = new List<Diner>();
                Diner d = new Diner();

                //Test values
                d.itemName = "Geen DINER vandaag";
                d.price = 100;

                diner.Add(d);
                return diner;
            }
        }

        public List<Drankjes> GetDrankjes()
        {
            try
            {
                List<Drankjes> drankjes = _menuDAO.Db_Get_Drankjes();
                return drankjes;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                List<Drankjes> drankjes = new List<Drankjes>();
                Drankjes dra = new Drankjes();

                //Test values
                dra.itemName = "geen DRANKJES vandaag";
                dra.price = 100;
                dra.alcohol = true;

                drankjes.Add(dra);
                return drankjes;
            }
        }
    }
}
