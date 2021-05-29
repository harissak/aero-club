using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BL
{
    public static class Services_membre
    {

        public static List <MBR> search_member_by_name (String memberName)
        {
            return DAL.AccesMBR.Read_MBR_BY_START_NAME(memberName);
        }

        public static MBR search_member_by_ID(int memberID)
        {
           
            return DAL.AccesMBR.Read_MBR_BY_ID(memberID);
            
        }

        public static int Add_new_member ( MBR mbr)
        {
            return DAL.AccesMBR.Add_new_member(mbr);
        }

        public static int Delete_member(int MBR_ID)
        {
            int retval = 0;

            //TO ADD: CHECK IF MBR HAS OPEN RESERVATION -FLO-

            retval = DAL.AccesMBR.Delete_MBR(MBR_ID);

            return retval;
        }

        public static int Update_member(MBR mbr)
        {
            //TO ADD: can't remove pilot if there is a running config -FLO-
            int retval = 0;
             MBR current = DAL.AccesMBR.Read_MBR_BY_ID(mbr.Mbr_ID);

            if (current != null)
                retval = DAL.AccesMBR.Update_MBR(current);

            return retval;
        }
    }
}
