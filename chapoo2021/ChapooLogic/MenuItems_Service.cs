using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;


namespace ChapooLogic
{
    //Made by Anel Gusinac
    public class MenuItems_Service
    {
        MenuAdmin_DAO menuAdminDao = new MenuAdmin_DAO();
        //Gets all menuNames
        public List<MenuItems> GetMenuNames()
        {
            try
            {
                return menuAdminDao.GetMenuNames();
            }
            catch (Exception e)
            {
                List<MenuItems> mItems = new List<MenuItems>();
                MenuItems m = new MenuItems();
                m.MenuItemName = "No items found.";

                mItems.Add(m);

                return mItems;
            }
        }
        //Only returns menuItem and Stock by menuId
        public List<MenuItems> GetMenuItemStock(int menuId)
        {
            try
            {
                return menuAdminDao.GetMenuItemStock(menuId);
            }
            catch (Exception e)
            {
                List<MenuItems> mItems = new List<MenuItems>();
                MenuItems m = new MenuItems();
                m.MenuItemName = "No items found.";

                mItems.Add(m);

                return mItems;
            }
        }
        //Gets all menu items by menuId, inclding price alcoholbool etc.
        public List<MenuItems> GetAllMenuItemsByMenuId(int menuId)
        {
            try
            {
                return menuAdminDao.GetMenuItemsByMenuId(menuId);
            }
            catch (Exception e)
            {
                List<MenuItems> mItems = new List<MenuItems>();
                MenuItems m = new MenuItems();
                m.MenuItemName = "No items found.";

                mItems.Add(m);

                return mItems;
            }
        }
        //werkt voorraad van een product bij.
        public void UpdateMenuItemStock(int id, int stock)
        {
            try
            {
                menuAdminDao.UpdateMenuItemStock(id, stock);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Creates menu item
        public void CreateMenuItem(int menuId, double price, int stock, int alcohol, string name)
        {
            try
            {
                menuAdminDao.CreateMenuItem(menuId, price, stock, alcohol, name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        //remove menu item by ID
        public void DeleteMenuItem(int menuId)
        {
            try
            {
                menuAdminDao.DeleteMenuItem(menuId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void UpdateMenuItem(int menuItemId, string name, double price, int alcohol)
        {

            try
            {
                menuAdminDao.UpdateMenuItem(menuItemId, name, price, alcohol);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void CreateMenu(string menuName)
        {
            try
            {
                menuAdminDao.CreateMenu(menuName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void UpdateMenu(int menuId, string menuName)
        {
            try
            {
                menuAdminDao.UpdateMenu(menuId, menuName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void DeleteMenu(int menuId)
        {
            try
            {
                menuAdminDao.DeleteMenu(menuId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}