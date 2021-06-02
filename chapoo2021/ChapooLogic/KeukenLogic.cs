using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class KeukenLogic
    {
        KeukenDAO keuken_db = new KeukenDAO();

        public List<KeukenModel> GetKeuken()
        {
            try
            {
                List<KeukenModel> keukenList = keuken_db.Db_Get_All_Keuken_Items();
                return keukenList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<KeukenModel> keukenList = new List<KeukenModel>();
                KeukenModel a = new KeukenModel();
                a.Name = "Failed";
                a.ItemID = 474791;
                keukenList.Add(a);

                KeukenModel b = new KeukenModel();
                b.Name = "Failed2";
                b.ItemID = 197474;
                keukenList.Add(b);
                return keukenList;
            }
        }
    }
}
