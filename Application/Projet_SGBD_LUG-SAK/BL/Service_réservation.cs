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

        public static int Add_new_reservation(RES reservation)
        {
            return DAL.AccesRÉS.Add_new_reservation(reservation);
        }

        public static List<RES> Read_all_reservations()
        {
            return DAL.AccesRÉS.Read_all_reservations();
        }

        

    }
}
