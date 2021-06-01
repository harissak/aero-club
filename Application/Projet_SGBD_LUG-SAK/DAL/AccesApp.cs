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
    public static class AccesApp
    {
        static public APP Read_App_By_ID(int app_ID)
        {
            APP retval;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                retval = connection.QuerySingle("select_app_by_id",
                                                param: new { app_id = app_ID },
                                                commandType: CommandType.StoredProcedure);
            }
            return retval;
        }

        public static int Add_new_app(APP app)
        {
            int retVal;
            DynamicParameters parameters;

            retVal = 0;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                parameters = new DynamicParameters();
                parameters.Add("@app_id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                parameters.AddDynamicParams(app);
                connection.Execute("sp_insert_new_app",
                                    param: parameters,
                                    commandType: CommandType.StoredProcedure);

                retVal = parameters.Get<int>("@app_id");
            }

            return retVal;
        }

        public static List<APP> Read_all()
        {
            List<APP> retval = new List<APP>();

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                retval = connection.Query<APP>("select_all_app",
                                                commandType: CommandType.StoredProcedure).AsList<APP>();
            }
            return retval;
        }
        
    }
}
