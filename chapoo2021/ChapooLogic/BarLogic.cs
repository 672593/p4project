using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class BarLogic
    {
        BarDAO bar_db = new BarDAO();

        public List<BarModel> GetBar()
        {
            try
            {
                List<BarModel> barList = bar_db.Db_Get_All_Bar_Items();
                return barList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<BarModel> barList = new List<BarModel>();
                BarModel a = new BarModel();
                a.Name = "Failed";
                a.ItemID = 474791;
                barList.Add(a);

                BarModel b = new BarModel();
                b.Name = "Failed2";
                b.ItemID = 197474;
                barList.Add(b);
                return barList;
            }
        }
    }
}
