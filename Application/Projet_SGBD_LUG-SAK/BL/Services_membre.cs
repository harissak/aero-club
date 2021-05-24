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

        public static List<MBR> search_member_by_ID(int memberID)
        {
            return DAL.AccesMBR.Read_MBR_BY_ID(memberID);
        }

        public static int Add_new_member ( MBR mbr)
        {
            return DAL.AccesMBR.Add_new_member(mbr);
        }

    }
}
