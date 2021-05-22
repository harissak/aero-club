using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    class Services_membre
    {

        static public List<MBR> read_member_by_name(string memberName)
        {
            return DAL.AccesMBR.Read_MBR_BY_START_NAME(memberName);
        }

    }
}
