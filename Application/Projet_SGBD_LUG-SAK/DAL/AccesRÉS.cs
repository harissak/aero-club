using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DTO;

namespace DAL
{
    public static class AccesRÉS
    {
        static public RES Read_reservation_By_ID(int RES_ID)
        {
            RES retval;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                retval = connection.QuerySingle("sp_select_reservation_by_id",
                                                param: new { reservation_id = RES_ID },
                                                commandType: CommandType.StoredProcedure);
            }
            return retval;
        }

        public static int Add_new_reservation(RES reservation)
        {
            int retVal;
            DynamicParameters parameters;

            retVal = 0;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                parameters = new DynamicParameters();
                parameters.Add("@RES_ID", dbType: DbType.Int32, direction: ParameterDirection.Output);
                parameters.AddDynamicParams(reservation);
                connection.Execute("sp_insert_new_reservation",
                                    param: parameters,
                                    commandType: CommandType.StoredProcedure);

                retVal = parameters.Get<int>("@RES_ID");
            }

            return retVal;
        }

        public static List<RES> Read_all_reservations()
        {
            List<RES> retval = new List<RES>();

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                retval = connection.Query<RES>("sp_select_all_reservation",
                                                commandType: CommandType.StoredProcedure).AsList<RES>();
            }
            return retval;
        }

       public static int CheckIFRunningResByApp(int app_id,DateTime now)
        {
            int retval;
            DynamicParameters parameters;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                connection.Open();
                parameters = new DynamicParameters();
                parameters.Add("@RES_FK_APP_ID", app_id, DbType.Int32, direction: ParameterDirection.Input);
                parameters.Add("@RES_date_now", now, DbType.DateTime, direction: ParameterDirection.Input);
                parameters.Add("@count", 0, DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("sp_select_running_res_by_app",     
                                   param: parameters,
                                   commandType: CommandType.StoredProcedure);

                retval = parameters.Get<int>("@count");
            }

            return retval;
        }
    }
}
