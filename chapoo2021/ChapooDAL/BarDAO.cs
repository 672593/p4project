using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;

namespace ChapooDAL
{
    public class BarDAO : Base
    {
        public List<BarModel> Db_Get_All_Bar_Items()
        {
            //string query = "select PersoonId, Voornaam, Achternaam, DocentId, Begeleider from Persoon INNER JOIN Docenten on PersoonId = DocentId";
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
                    Name = (String)(dr["itemName"].ToString())
                };
                barList.Add(baritem);

            }
            return barList;
        }
    }
}
