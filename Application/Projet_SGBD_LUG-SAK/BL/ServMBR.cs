using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using Dapper;


namespace BL
{
    public static class ServMBR
    {
        static public List<MBR> Read_MBR_BY_START_NAME(string start_name)
        {
            List<MBR> retval = new List<MBR>();

            //Daper  -  16.05.2021---

            using (var connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                retval = connection.Query<MBR>("select_member_by_name",
                                        param: new { start_name = start_name },
                                        commandType: CommandType.StoredProcedure).AsList<MBR>();
            }

            return retval;
        }
    }
}
