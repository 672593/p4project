using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;

namespace ChapooLogic
{
    public class Tafels_Service
    {
        // Made by Faruk Bikmaz

        private Tafels_DAO _tafelsDAO = new Tafels_DAO();

        public List<Tafels> GetAllFreeTables()
        {
            try
            {
                List<Tafels> tafels = _tafelsDAO.Db_Get_All_Free_Tables();
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
    }

}
