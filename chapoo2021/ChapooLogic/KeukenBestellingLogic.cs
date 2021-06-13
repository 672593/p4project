using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class KeukenBestellingLogic
    {
        KeukenBestellingDAO keuken_db = new KeukenBestellingDAO();

        public List<KeukenBestellingModel> GetKeuken()
        {
            try
            {
                List<KeukenBestellingModel> keukenOrderList = keuken_db.Db_Get_All_Keuken_Bestellingen();
                return keukenOrderList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<KeukenBestellingModel> keukenOrderList = new List<KeukenBestellingModel>();
                KeukenBestellingModel a = new KeukenBestellingModel();
                //a.Name = "Failed";
                // a.ItemID = 474791;
                keukenOrderList.Add(a);

                KeukenBestellingModel b = new KeukenBestellingModel();
                //b.Name = "Failed2";
                //b.ItemID = 197474;
                keukenOrderList.Add(b);
                return keukenOrderList;
            }
        }

        public bool WijzigBestellingKeuken(KeukenBestellingModel keuken)
        {
            try
            {
                keuken_db.WijzigBestellingKeuken(keuken);
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
