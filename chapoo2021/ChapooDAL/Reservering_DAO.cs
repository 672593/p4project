using ChapooModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooDAL
{
    public class Reservering_DAO : Base
    {
        public List<Reservering> Db_Get_AllReservering()
        {
            SqlParameter[] sqlp = new SqlParameter[0];
            return ReadTablesReservering(ExecuteSelectQuery("GetAllReservation", sqlp));
        }

        private List<Reservering> ReadTablesReservering(DataTable dataTable)
        {
            List<Reservering> reserv = new List<Reservering>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Reservering re = new Reservering()
                {
                    reservationId = (int)dr["reservationId"],
                    tableId = (int)dr["tableId"],
                    reservationName = (string)dr["reservationName"],
                    reservationTel = (string)dr["reservationTel"],
                    reservationEmail = (string)dr["reservationEmail"],
                    reservationComment = (string)dr["reservationComment"],
                    reservationDate = (DateTime)dr["reservationDate"],
                };
                reserv.Add(re);
            }
            return reserv;
        }

        public void DeleteReservation(int reservationId)
        {
            SqlParameter sqlq = new SqlParameter("@reservationId", reservationId);
            SqlParameter[] sqlParameters = new SqlParameter[] { sqlq };

            ExecuteEditQuery("DeleteReservation", sqlParameters);
        }

        public void EditReservering(int reservationId, int tableId, string reservationName, string reservationTel, string reservationEmail, string reservationComment, DateTime reservationDate)
        {
            SqlParameter sqlq = new SqlParameter("@reservationId", reservationId);
            SqlParameter sqlq1 = new SqlParameter("@tableId", tableId);
            SqlParameter sqlq2 = new SqlParameter("@reservationName", reservationName);
            SqlParameter sqlq3 = new SqlParameter("@reservationTel", reservationTel);
            SqlParameter sqlq4 = new SqlParameter("@reservationEmail", reservationEmail);
            SqlParameter sqlq5 = new SqlParameter("@reservationComment", reservationComment);
            SqlParameter sqlq6 = new SqlParameter("@reservationDate", reservationDate);
            SqlParameter[] sqlParameters = new SqlParameter[] { sqlq, sqlq1, sqlq2, sqlq3, sqlq4, sqlq5, sqlq6 };

            ExecuteEditQuery("EditReservering", sqlParameters);
        }

        public void InsertReservering(Reservering re)
        {
            SqlParameter sqlq = new SqlParameter("@reservationId", re.reservationId);
            SqlParameter sqlq1 = new SqlParameter("@tableId", re.tableId);
            SqlParameter sqlq2 = new SqlParameter("@reservationName", re.reservationName);
            SqlParameter sqlq3 = new SqlParameter("@reservationTel", re.reservationTel);
            SqlParameter sqlq4 = new SqlParameter("@reservationEmail", re.reservationEmail);
            SqlParameter sqlq5 = new SqlParameter("@reservationComment", re.reservationComment);
            SqlParameter sqlq6 = new SqlParameter("@reservationDate", re.reservationDate);
            SqlParameter[] sqlParameters = new SqlParameter[] { sqlq, sqlq1, sqlq2, sqlq3, sqlq4, sqlq5, sqlq6 };

            ExecuteEditQuery("InsertReservering", sqlParameters);
        }

        public int GetLastReserveringId()
        {
            int reservationId = 0;
            DataTable reservering = ExecuteSelectQuery("GetLastReserveringId");
            foreach (DataRow item in reservering.Rows) { reservationId = (int)item["reservationId"]; }

            return reservationId;
        }
    }
}
