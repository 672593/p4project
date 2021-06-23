using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class BarBestellingLogic
    {
        BarBestellingDAO bar_db = new BarBestellingDAO();

        public List<BarBestellingModel> GetBar()
        {
            try
            {
                List<BarBestellingModel> barOrderList = bar_db.Db_Get_All_Bar_Bestellingen();
                return barOrderList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<BarBestellingModel> barOrderList = new List<BarBestellingModel>();
                BarBestellingModel a = new BarBestellingModel();
                //a.Name = "Failed";
               // a.ItemID = 474791;
                barOrderList.Add(a);

                BarBestellingModel b = new BarBestellingModel();
                //b.Name = "Failed2";
                //b.ItemID = 197474;
                barOrderList.Add(b);
                return barOrderList;
            }
        }

        public bool WijzigBestellingBar(BarBestellingModel bar)
        {
            try
            {
                bar_db.WijzigBestellingBar(bar);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
