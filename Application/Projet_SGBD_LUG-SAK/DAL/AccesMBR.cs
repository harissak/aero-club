using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Dapper;
using System.Data;

namespace DAL
{
    public static class AccesMBR
    {
        static public List<MBR> SelectMbr(string start_name)
        {
            List<MBR> retval= new List<MBR>();
            return retval; 
        }


        static public List<MBR> Read_MBR_BY_START_NAME(string start_name)
        {
            List<MBR> retval = new List<MBR>();

            //Daper  -  16.05.2021---

            using (var connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                retval = connection.Query<MBR>("select_mbr_by_name",
                                        param: new { start_name = start_name },
                                        commandType: CommandType.StoredProcedure).AsList<MBR>();
            }

            return retval;
        }

        static public List<MBR> Read_MBR_BY_ID(int mbr_id)
        {
            List<MBR> retval = new List<MBR>();

            //Daper  -  16.05.2021---

            using (var connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                retval = connection.Query<MBR>("select_mbr_by_id",
                                        param: new { mbr_id = mbr_id },
                                        commandType: CommandType.StoredProcedure).AsList<MBR>();
            }

            return retval;
        }
    }
}
