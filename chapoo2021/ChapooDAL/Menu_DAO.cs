using ChapooModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooDAL
{
    // Made by Faruk Bikmaz
    public class Menu_DAO : Base
    {
        public List<Menuu> Db_Get_MenuNames()
        {
            SqlParameter[] sqlp = new SqlParameter[0];
            return ReadTablesMenuName(ExecuteSelectQuery("getMenuNames", sqlp));
        }

        private List<Menuu> ReadTablesMenuName(DataTable dataTable)
        {
            List<Menuu> menu = new List<Menuu>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Menuu m = new Menuu();
                m.menuId = (int)dr["menuId"];
                m.menuName = (string)dr["menuName"];
                menu.Add(m);
            }
            return menu;
        }

        public List<MenuuItem> Db_Get_itemName(int menuId)
        {
            SqlParameter sqlp = new SqlParameter("@menuId", menuId);
            SqlParameter[] sqlp1 = new SqlParameter[] { sqlp };
            return ReadTablesItemName(ExecuteSelectQuery("GetitemName", sqlp1));
        }

        private List<MenuuItem> ReadTablesItemName(DataTable dataTable)
        {
            List<MenuuItem> itemName = new List<MenuuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuuItem m = new MenuuItem();
                m.itemName = (string)dr["itemName"];
                itemName.Add(m);
            }
            return itemName;
        }

        public List<MenuuItem> Db_Get_SelectedMenuItems(int menuId)
        {
            SqlParameter sqlp = new SqlParameter("@menuId", menuId);
            SqlParameter[] sqlp1 = new SqlParameter[] { sqlp };
            return ReadTablesSelItemName(ExecuteSelectQuery("GetSelectedMenuItems", sqlp1));
        }
        private List<MenuuItem> ReadTablesSelItemName(DataTable dataTable)
        {
            List<MenuuItem> itemName = new List<MenuuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuuItem m = new MenuuItem();
                m.itemName = (string)dr["itemName"];
                itemName.Add(m);
            }
            return itemName;
        }

        public List<MenuuItem> GetSelectedMenuItemId(int menuId, int menuItemId)
        {
            SqlParameter sqlp = new SqlParameter("@menuId", menuId);
            SqlParameter sqlp1 = new SqlParameter("@menuItemId", menuItemId);
            SqlParameter[] sqlParameters = new SqlParameter[] { sqlp, sqlp1 };
            return ReadTablesMenuId(ExecuteSelectQuery("GetSelectedMenuItemId", sqlParameters));
        }

        private List<MenuuItem> ReadTablesMenuId(DataTable dataTable)
        {
            List<MenuuItem> item = new List<MenuuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuuItem m = new MenuuItem();
                m.menuId = (int)dr["menuId"];
                m.menuItemId = (int)dr["menuItemId"];
                item.Add(m);
            }
            return item;
        }
        // LUNCH
        public List<Lunch> Db_Get_Lunch()
        {
            SqlParameter[] sqlp = new SqlParameter[0];
            return ReadTablesLunch(ExecuteSelectQuery("GetLunch", sqlp));
        }

        private List<Lunch> ReadTablesLunch(DataTable dataTable)
        {
            List<Lunch> lunch = new List<Lunch>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Lunch l = new Lunch();
                l.itemName = (string)dr["itemName"];
                lunch.Add(l);
            }
            return lunch;
        }

        // DINER

        public List<Diner> Db_Get_Diner()
        {
            SqlParameter[] sqlp = new SqlParameter[0];
            return ReadTablesDiner(ExecuteSelectQuery("GetDiner", sqlp));
        }

        private List<Diner> ReadTablesDiner(DataTable dataTable)
        {
            List<Diner> diner = new List<Diner>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Diner d = new Diner();
                d.itemName = (string)dr["itemName"];
                diner.Add(d);
            }
            return diner;
        }

        // DRANKJES

        public List<Drankjes> Db_Get_Drankjes()
        {
            SqlParameter[] sqlp = new SqlParameter[0];
            return ReadTablesDrankjes(ExecuteSelectQuery("GetDrankjes", sqlp));
        }

        private List<Drankjes> ReadTablesDrankjes(DataTable dataTable)
        {
            List<Drankjes> drankje = new List<Drankjes>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drankjes dra = new Drankjes();
                dra.itemName = (string)dr["itemName"];
                drankje.Add(dra);
            }
            return drankje;
        }
    }
}
