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

    }
}
