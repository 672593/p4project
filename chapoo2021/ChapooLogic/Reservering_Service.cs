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
        public bool EditReservering(Reservering r)
        {
            try
            {
                reserveringDAO.EditReservering(r);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
      /*  public bool EditReservering(int reservationId, int tableId, string reservationName, string reservationTel, string reservationEmail, string reservationComment, DateTime reservationDate)
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
        }*/

        public bool InsertReservering(int reservationId, int tableId, string reservationName, string reservationTel, string reservationEmail, string reservationComment, DateTime reservationDate)
        {
            try
            {
                reserveringDAO.InsertReservering(reservationId, tableId, reservationName, reservationTel, reservationEmail, reservationComment, reservationDate);
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
