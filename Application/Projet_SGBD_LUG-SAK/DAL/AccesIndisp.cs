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
    public static class  AccesIndisp
    {
        public static List<Indisp> Get_Current_Indisp_By_APP(int app_id, DateTime now)
        {
            List<Indisp> retval;
            DynamicParameters parameters;
            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                parameters = new DynamicParameters();
                parameters.Add("FK_APP_ID",app_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
                parameters.Add("Date_now", now, dbType: DbType.DateTime, direction: ParameterDirection.Input);

                retval = connection.Query<Indisp>("sp_select_curr_indisp_by_app",
                                                  param: parameters,
                                                  commandType: CommandType.StoredProcedure).AsList<Indisp>();
            }

            return retval;
        }
    }
}
