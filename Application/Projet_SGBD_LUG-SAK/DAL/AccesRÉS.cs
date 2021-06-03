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

    }
}
