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
    public class KeukenDAO : Base
    {
        public List<KeukenModel> Db_Get_All_Keuken_Items()
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery("GetAllKeukenItems", sqlParameters));
        }
        private List<KeukenModel> ReadTables(DataTable dataTable)
        {
            List<KeukenModel> keukenList = new List<KeukenModel>();
            foreach (DataRow dr in dataTable.Rows)
            {
                KeukenModel keukenItem = new KeukenModel()
                {
                    ItemID = (int)dr["menuItemId"],
                    Type = (int)dr["menuId"],
                    Price = (Decimal)dr["price"],
                    Stock = (int)dr["stock"],
                    Name = (string)(dr["itemName"].ToString())
                };
                keukenList.Add(keukenItem);

            }
            return keukenList;
        }
    }
}
