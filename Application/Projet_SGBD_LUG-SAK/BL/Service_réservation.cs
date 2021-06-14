using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BL
{
    public static class Service_réservation
    {

        public static List<RES> Read_reservation_by_ID(int appID)
        {

            List<RES> retVal = new List<RES>();

            retVal.Add(DAL.AccesRÉS.Read_reservation_By_ID(appID));

            return retVal;

        }


        public static void DeleteOldReservations(DateTime today)
        {

            List<RES> allReservations = new List<RES>();

            allReservations = DAL.AccesRÉS.Read_all_reservations();

            foreach (RES reservation in allReservations)
            {
                if (reservation.Res_date < today)
                    DAL.AccesRÉS.Delete_reservation(reservation.Res_ID);
            }

        }



        public static int Add_new_reservation(RES reservation)
        {
            return DAL.AccesRÉS.Add_new_reservation(reservation);
        }

        public static List<RES> Read_all_reservations()
        {
            return DAL.AccesRÉS.Read_all_reservations();
        }

        public static int Update_reservation(RES reservation)
        {
            return DAL.AccesRÉS.Update_reservation(reservation);

        }

        public static int Delete_reservation(int RES_ID)
        {
            return DAL.AccesRÉS.Delete_reservation(RES_ID);
        }

    }
}
