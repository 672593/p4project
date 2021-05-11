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
                l.price = (decimal)dr["price"];
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
                d.price = (decimal)dr["price"];
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
                dra.price = (decimal)dr["price"];
                dra.alcohol = (bool)dr["alcohol"];
                drankje.Add(dra);
            }
            return drankje;
        }
    }
}
