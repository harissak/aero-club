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

        //static public APP Read_app_by_desc(string app_desc)
        //{
        //    APP retval;

        //    using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
        //    {
        //        retval = connection.QuerySingle("sp_select_app_by_desc",
        //                                        param: new { app_desc = app_desc },
        //                                        commandType: CommandType.StoredProcedure).APP_ID();
        //    }
        //    return retval;
        //}


        static public APP Read_app_by_desc(string app_desc)
        {
            APP retval;
            List<APP> liste;

            //Daper  -  16.05.2021---
            retval = null;
            liste = null;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                liste = connection.Query<APP>("sp_select_app_by_desc",
                                        param: new { app_desc = app_desc },
                                        commandType: CommandType.StoredProcedure).AsList<APP>();
                if (liste.Count == 1)
                    retval = liste[0];
            }

            return retval;
        }

        static public int DeleteAPP(int app_id)
        {
            int retval;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                connection.Open();
                using (var transac = connection.BeginTransaction())
                {
                    retval = connection.Execute("sp_delete_app",
                                   param: new { APP_ID = app_id },
                                   commandType: CommandType.StoredProcedure,
                                   transaction: transac);

                    transac.Commit();
                }
            }
            return retval;
        }
    }
}
