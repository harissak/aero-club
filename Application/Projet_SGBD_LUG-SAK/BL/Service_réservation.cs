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

        public static void Res_check_cotisation_status(int mbr_id)
        {
            if (BL.Services_membre.Check_cotisation_status(mbr_id) == false)
                throw new Exception("BL_RES_CHECK_RULE_1");                       //Pilot can't do the reservation, cotisation is not valid anymore
        }

        public static void Res_Check_APP_Break_Time(int app_id, DateTime jour, DateTime heurdeb, DateTime heurfin)
        {
            if (DAL.AccesRÉS.Res_Check_APP_Break_Time(app_id, jour, heurdeb, heurfin) == true)
                throw new Exception("BL_RES_CHECK_RULE_2");                      //Break time of 15 min btw reservation is not resepcted
        }

        public static void Res_Check_ThreeMonthDelay(DateTime today, DateTime jour)
        {
            if(today.AddMonths(3) <= jour)
                throw new Exception("BL_RES_CHECK_RULE_3");                     //reservation is more than 3 month in future
        }

        public static void Res_Check_Pilot_Lic(int mbr_id, DateTime reservation)
        {
          if( reservation > (DAL.AccesLIC.Read_Lic_By_FK_MBRID(mbr_id).Lic_exp).AddMonths(1))
                    throw new Exception("BL_RES_CHECK_RULE_4");                 //reservation is not under the licesence expiration + 1 month

        }
    }
}
