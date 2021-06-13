using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using ChapooModel;

namespace ChapooDAL
{
    public class MenuAdmin_DAO : Base
    {
        //Menu names for combobox
        public List<MenuItems> GetMenuNames()
        {
            List<MenuItems> menuItemsList = new List<MenuItems>();

            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable datatable = ExecuteSelectQuery("getMenuNames", sqlParameters);

            foreach (DataRow dr in datatable.Rows)
            {
                MenuItems menuItem = new MenuItems();
                menuItem.MenuId = (int)dr["menuId"];
                menuItem.MenuItemName = (string)dr["menuName"];

                menuItemsList.Add(menuItem);
            }
            return menuItemsList;
        }
        //Stock Methods
        //Gets products only Id, name and stock
        public List<MenuItems> GetMenuItemStock(int menuId)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@menuId", menuId));

            DataTable dt = ExecuteSelectQuery("getSelectedMenuItemStock", list.ToArray<SqlParameter>());

            return ReadMenuItemStock(dt);
        }
        //Reads datatable returns list of MenuItems only id, name, stock
        public List<MenuItems> ReadMenuItemStock(DataTable dataTable)
        {
            List<MenuItems> menuItemStockList = new List<MenuItems>();
            foreach (DataRow row in dataTable.Rows)
            {
                MenuItems m = new MenuItems();
                m.MenuItemId = (int)row["menuItemId"];
                m.MenuItemName = (string)row["itemName"];
                m.MenuItemStock = (int)row["stock"];

                menuItemStockList.Add(m);
            }
            return menuItemStockList;
        }

        //Update stock of menu item.
        public void UpdateMenuItemStock(int id, int stock)
        {
            SqlParameter sqlparameter1 = new SqlParameter("@stockUpdate", stock);
            SqlParameter sqlparameter2 = new SqlParameter("@menuItemId", id);

            SqlParameter[] sqlp = new SqlParameter[] { sqlparameter1, sqlparameter2 };

            ExecuteEditQuery("updateMenuItemStock", sqlp);

        }

        //Menu articles methods
        //Gets all menu articles (including price alcoholic), with given month.
        public List<MenuItems> GetMenuItemsByMenuId(int menuId)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@menuId", menuId));

            DataTable dt = ExecuteSelectQuery("GetAllMenuItems", list.ToArray<SqlParameter>());

            return ReadAllMenuItemsByMenuId(dt);
        }
        //Reads datatable returns list of MenuItems including id, name, price, alcohol, 
        public List<MenuItems> ReadAllMenuItemsByMenuId(DataTable dt)
        {
            List<MenuItems> menuItemList = new List<MenuItems>();
            foreach (DataRow row in dt.Rows)
            {
                MenuItems m = new MenuItems();
                m.MenuItemId = (int)row["menuItemId"];
                m.MenuItemName = (string)row["itemName"];
                m.MenuItemPrice = (decimal)row["price"];
                m.ContainsAlcohol = (bool)row["alcohol"];
                menuItemList.Add(m);
            }
            return menuItemList;
        }
        //Creates new row in menuItem table
        public void CreateMenuItem(int menuId, double price, int stock, int alcohol, string name)
        {
            SqlParameter sqlparameter1 = new SqlParameter("@menuId", menuId);
            SqlParameter sqlparameter2 = new SqlParameter("@price", price);
            SqlParameter sqlparameter3 = new SqlParameter("@stock", stock);
            SqlParameter sqlparameter4 = new SqlParameter("@alcohol", alcohol);
            SqlParameter sqlparameter5 = new SqlParameter("@productName", name);

            SqlParameter[] sqlp = new SqlParameter[] {
                sqlparameter1,
                sqlparameter2,
                sqlparameter3,
                sqlparameter4,
                sqlparameter5
            };

            ExecuteEditQuery("CreateMenuItem", sqlp);
        }
        public void DeleteMenuItem(int menuId)
        {
            SqlParameter sqlparameter1 = new SqlParameter("@menuItemId", menuId);
            SqlParameter[] sqlp = new SqlParameter[] {
                sqlparameter1
            };
            ExecuteEditQuery("DeleteMenuItem", sqlp);

        }
        public void UpdateMenuItem(int menuItemId, string name, double price, int alcohol)
        {

            SqlParameter[] sqlParameters = new SqlParameter[]{
                 new SqlParameter("@menuItemId", menuItemId),
                 new SqlParameter("@name", name),
                 new SqlParameter("@price", price),
                 new SqlParameter("@alcohol", alcohol)
            };
            ExecuteEditQuery("UpdateMenuItem", sqlParameters);
        }
        public void CreateMenu(string menuName)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@menuName", menuName)
            };
            ExecuteEditQuery("CreateMenu", sqlParameters);            
        }
        public void UpdateMenu(int menuId, string menuName)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]{
                 new SqlParameter("@menuId", menuId),
                 new SqlParameter("@menuName", menuName)
            };
            ExecuteEditQuery("UpdateMenu", sqlParameters);
        }
        public void DeleteMenu(int menuId)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]{
                 new SqlParameter("@menuId", menuId)
            };
            ExecuteEditQuery("DeleteMenu", sqlParameters);
        }
    }
}