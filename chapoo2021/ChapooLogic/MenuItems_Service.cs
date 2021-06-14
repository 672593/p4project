using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

//Made by Anel Gusinac
namespace ChapooLogic
{
    public class MenuItems_Service
    {

        MenuAdmin_DAO menuAdminDao = new MenuAdmin_DAO();

        //Gets all menuNames
        public List<MenuItems> GetMenuNames()
        {
            return menuAdminDao.GetMenuNames();
        }

        //Only returns menuItem and Stock by menuId
        public List<MenuItems> GetMenuItemStock(int menuId)
        {
            return menuAdminDao.GetMenuItemStock(menuId);
        }

        //Gets all menu items by menuId, inclding price alcoholbool etc.
        public List<MenuItems> GetAllMenuItemsByMenuId(int menuId)
        {
            return menuAdminDao.GetMenuItemsByMenuId(menuId);
        }

        //werkt voorraad van een product bij.
        public void UpdateMenuItemStock(int id, int stock)
        {
            menuAdminDao.UpdateMenuItemStock(id, stock);
        }
        //Creates menu item
        public void CreateMenuItem(int menuId, double price, int stock, int alcohol, string name)
        {
            menuAdminDao.CreateMenuItem(menuId, price, stock, alcohol, name);
        }
        //remove menu item by ID
        public void DeleteMenuItem(int menuId)
        {
            menuAdminDao.DeleteMenuItem(menuId);
        }
        public void UpdateMenuItem(int menuItemId, string name, double price, int alcohol)
        {
            menuAdminDao.UpdateMenuItem(menuItemId, name, price, alcohol);
        }
        public void CreateMenu(string menuName)
        {
            menuAdminDao.CreateMenu(menuName);
        }
        public void UpdateMenu(int menuId, string menuName)
        {
            menuAdminDao.UpdateMenu(menuId, menuName);
        }
        public void DeleteMenu(int menuId)
        {
            menuAdminDao.DeleteMenu(menuId);
        }
    }
}