using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using ChapooModel;

namespace ChapooDAL
{
    public class BarDAO : Base
    {
        public List<BarModel> Db_Get_All_Bar_Items()
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery("GetAllBarItems", sqlParameters));
        }
        private List<BarModel> ReadTables(DataTable dataTable)
        {
            List<BarModel> barList = new List<BarModel>();
            foreach (DataRow dr in dataTable.Rows)
            {
                BarModel baritem = new BarModel()
                {
                    ItemID = (int)dr["menuItemId"],
                    Type = (int)dr["menuId"],
                    Price = (Decimal)dr["price"],
                    Stock = (int)dr["stock"],
                    Alcohol = (Boolean)dr["alcohol"],
                    Name = (string)(dr["itemName"].ToString())
                };
                barList.Add(baritem);

            }
            return barList;
        }
    }
}
