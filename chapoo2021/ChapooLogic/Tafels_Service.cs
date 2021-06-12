using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;

namespace ChapooLogic
{
    public class Tafels_Service
    {
        // Made by Faruk Bikmaz & Jelle de Vries

        private Tafels_DAO tafels_DAO = new Tafels_DAO();
        

        public List<Tafels> GetAllFreeTables()
        {
            try
            {
                List<Tafels> tafels = tafels_DAO.Db_Get_All_Free_Tables();
                return tafels;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                List<Tafels> tafels = new List<Tafels>();
                Tafels t = new Tafels();

                //Test values
                t.tableId = 99;

                tafels.Add(t);
                return tafels;
            }
        }

        public List<Tafels> GetTafelData()
        {
            return tafels_DAO.Get_Tafel_Data();
        }

        public List<Tafels> GetOrderStatus()
        {

        }
    }

}
