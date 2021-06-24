using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class KeukenBarBestelling_Service
    {
        KeukenBarBestelling_DAO keuken_db = new KeukenBarBestelling_DAO();

        public List<KeukenBarBestelling> GetKeuken(Boolean checkKeukenBar, Boolean checkOpenstaand)
        {
            try
            {
                List<KeukenBarBestelling> keukenOrderList = keuken_db.Db_Get_All_Keuken_Bestellingen(checkKeukenBar, checkOpenstaand);
                return keukenOrderList;
            }
            catch
            {
                List<KeukenBarBestelling> keukenOrderList = new List<KeukenBarBestelling>();
                return keukenOrderList;
            }
        }

        public bool WijzigBestelling(KeukenBarBestelling keukenBar)
        {
            try
            {
                keuken_db.WijzigBestelling(keukenBar);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
