using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooLogic
{
    
    public class Menu_Service
    {
        private Menu_DAO _menuDAO = new Menu_DAO();

        public List<Menuu> GetMenuNames()
        {
            try
            {
                List<Menuu> menu = _menuDAO.Db_Get_MenuNames();
                return menu;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                List<Menuu> menu = new List<Menuu>();
                Menuu m = new Menuu();

                //Test values
                m.menuId = 99;
                m.menuName = "Geen menu";

                menu.Add(m);
                return menu;
            }
        }

        public List<MenuuItem> GetitemName(int menuId)
        {
            try
            {
                List<MenuuItem> itemNName = _menuDAO.Db_Get_itemName(menuId);
                return itemNName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                List<MenuuItem> menuItem = new List<MenuuItem>();
                MenuuItem m = new MenuuItem();

                //Test values

                m.itemName = "Geen";

                menuItem.Add(m);
                return menuItem;
            }
        }
        public List<MenuuItem> GetSelectedMenuItemId(int menuId, int menuItemId)
        {
            try
            {
                List<MenuuItem> item = _menuDAO.GetSelectedMenuItemId(menuId, menuItemId);
                return item;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                List<MenuuItem> item = new List<MenuuItem>();
                MenuuItem m = new MenuuItem();

                //Test values

                m.menuItemId = 1;

                item.Add(m);
                return item;
            }
        }

        public List<MenuuItem> GetSelitemName(int menuId)
        {
            try
            {
                List<MenuuItem> itemNName = _menuDAO.Db_Get_SelectedMenuItems(menuId);
                return itemNName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                List<MenuuItem> menuItem = new List<MenuuItem>();
                MenuuItem m = new MenuuItem();

                //Test values

                m.itemName = "Geen";

                menuItem.Add(m);
                return menuItem;
            }
        }

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

                drankjes.Add(dra);
                return drankjes;
            }
        }
    }
}
