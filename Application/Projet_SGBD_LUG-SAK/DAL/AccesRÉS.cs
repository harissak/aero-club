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
            List<RES> liste;


            retval = null;
            liste  = null;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                liste = connection.Query<RES>("sp_select_reservation_by_id",
                                                param: new { reservation_id = RES_ID },
                                                commandType: CommandType.StoredProcedure).AsList<RES>();

                if(liste.Count > 0)
                    retval = liste[0];
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


        public static int CheckIFRunningResByMbrId(int mbr_id)
        {
            int retval;
            DynamicParameters parameters;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                connection.Open();
                parameters = new DynamicParameters();
                parameters.Add("@RES_FK_MBR_ID", mbr_id, DbType.Int32, direction: ParameterDirection.Input);
                parameters.Add("@count", 0, DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("sp_select_running_res_by_mbr_id",
                                   param: parameters,
                                   commandType: CommandType.StoredProcedure);

                retval = parameters.Get<int>("@count");
            }

            return retval;
        }


        public static int Update_reservation(RES reservation)
        {
            int retval = 0;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                retval = connection.Execute("sp_update_reservation_infos",
                                            new
                                            {
                                               
                                                RES_ID = reservation.Res_ID,
                                                RES_DATE = reservation.Res_date,
                                                RES_HR_DEB = reservation.Res_hr_deb,
                                                RES_HR_FIN = reservation.Res_hr_fin,
                                                RES_EST_ANN = reservation.Res_est_annule,
                                                RES_EST_PRE = reservation.Res_est_prevenu,
                                                res_fkt_mbr_id = reservation.Res_FK_Mbr_ID,
                                                res_fkt_app_id = reservation.Res_FK_App_ID
               
                                                
                                            },
                                            commandType: CommandType.StoredProcedure);

               
            }
            return retval;
        }

        public static int Delete_reservation(int reservation_ID)
        { 
            int retval;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                connection.Open();
                using (var transac = connection.BeginTransaction())
                {

                    retval = connection.Execute("sp_delete_reservation",
                                            param: new { res_id = reservation_ID },
                                            commandType: CommandType.StoredProcedure,
                                            transaction: transac);
                    transac.Commit();
                }
            }

            return retval;
        }

        public static bool Res_Check_APP_Break_Time(int app_id,DateTime jour,DateTime heurdeb,DateTime heurfin)
        {
            bool retval = false;
            DynamicParameters parameters;
            int count;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                connection.Open();
                parameters = new DynamicParameters();
                parameters.Add("@RES_FK_APP_ID", app_id, DbType.Int32, direction: ParameterDirection.Input);
                parameters.Add("@Date", jour, DbType.Date, direction: ParameterDirection.Input);
                parameters.Add("@Res_hr_deb", heurdeb, DbType.DateTime, direction: ParameterDirection.Input);
                parameters.Add("@Res_hr_fin", heurfin, DbType.DateTime, direction: ParameterDirection.Input);
                parameters.Add("@count", 0, DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("sp_select_conflict_app_break",
                                   param: parameters,
                                   commandType: CommandType.StoredProcedure);
            }

            count = parameters.Get <int>("@count");

            if (count > 0)
                retval = true;

                return retval;
        }
            static public List <RES> Read_reservation_by_app_id(int app_id)
        {
            RES retval;
            List<RES> liste=new List<RES>();


            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                liste = connection.Query<RES>("sp_select_reservation_by_app_id",
                                                param: new { app_id = app_id },
                                                commandType: CommandType.StoredProcedure).AsList<RES>();

            }
            return liste;
        }
    }
}
