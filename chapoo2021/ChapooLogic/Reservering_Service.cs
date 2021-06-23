using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooLogic
{
    public class Reservering_Service
    {
        Reservering_DAO reserveringDAO = new Reservering_DAO();
        public List<Reservering> GetAllRes()
        {
            try
            {

                return reserveringDAO.Db_Get_AllReservering();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                List<Reservering> res = new List<Reservering>();
                Reservering re = new Reservering();

                //Test values
                re.reservationId = 99;
                re.tableId = 99;
                re.reservationName = "Fout";
                re.reservationTel = "Fout";
                re.reservationEmail = "Fout";
                re.reservationComment = "Fout";
                re.reservationDate = DateTime.Now;
                res.Add(re);
                return res;
            }
        }
        public bool DeleteReservation(int reservationId)
        {
            try
            {
                reserveringDAO.DeleteReservation(reservationId);
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool EditReservering(int reservationId, int tableId, string reservationName, string reservationTel, string reservationEmail, string reservationComment, DateTime reservationDate)
        {
            try
            {
                reserveringDAO.EditReservering(reservationId, tableId, reservationName, reservationTel, reservationEmail, reservationComment, reservationDate);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool InsertReservering(Reservering re)
        {
            try
            {
                reserveringDAO.InsertReservering(re);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public int GetLastReserveringId()
        {
            return reserveringDAO.GetLastReserveringId();
        }
    }
}
