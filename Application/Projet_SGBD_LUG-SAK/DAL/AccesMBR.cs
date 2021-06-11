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
        public static object MessageBox { get; private set; }

        static public List<MBR> SelectMbr(string start_name)
        {
            List<MBR> retval = new List<MBR>();
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



        static public MBR Read_MBR_BY_ID(int mbr_id)
        {
            MBR retval;
            List<MBR> liste;

        //Daper  -  16.05.2021---
        retval = null;
            liste = null;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                liste = connection.Query<MBR>("select_mbr_by_id",
                                        param: new { mbr_id = mbr_id},
                                        commandType: CommandType.StoredProcedure).AsList<MBR>();
                
                    retval = liste[0];

            }

         return retval;
        }



        public static int Add_new_member(MBR mbr)
        {
            int retVal;
            DynamicParameters parameters;

            retVal = 0;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                parameters = new DynamicParameters();
                parameters.Add("@MBR_ID", dbType: DbType.Int32, direction: ParameterDirection.Output);

                parameters.AddDynamicParams(new
                {
                    MBR_nom = mbr.Mbr_nom,
                    MBR_prenom = mbr.Mbr_prenom,
                    MBR_sexe = mbr.Mbr_sexe,
                    MBR_naiss = mbr.Mbr_naiss,
                    MBR_adrs = mbr.Mbr_adrs,
                    MBR_num_boite = mbr.Mbr_num_boite,
                    MBR_cp = mbr.Mbr_cp,
                    MBR_loc = mbr.Mbr_loc,
                    MBR_mail = mbr.Mbr_mail,
                    MBR_fix_tel = mbr.Mbr_fix_tel,
                    MBR_gsm = mbr.Mbr_gsm,
                    MBR_cot_valide = mbr.Mbr_cot_valide,
                    MBR_est_pil = mbr.Mbr_est_pil,
                    MBR_est_adm = mbr.Mbr_est_adm,
                    MBR_passw = mbr.Mbr_passw,
                });
                connection.Execute("sp_insert_new_member",
                                    param: parameters,
                                    commandType: CommandType.StoredProcedure);

                mbr.Mbr_ID = parameters.Get<int>("@MBR_ID");
                retVal = mbr.Mbr_ID;
            }

            return retVal;
        }

        public static int Delete_MBR(int MBR_ID)
        {
            int retval;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                connection.Open();
                using (var transac = connection.BeginTransaction())
                {
                    //ONCE RESERVATION IS OPERATIONAL, WE MUST CHECK THAT THE MBR TO DELETE
                    //DOES NOT HAVE AN OPEN RESERVATION

                    retval = connection.Execute("sp_delete_mbr",
                                            param: new { MBR_ID = MBR_ID },
                                            commandType: CommandType.StoredProcedure,
                                            transaction: transac);
                    transac.Commit();
                }
            }

            return retval;
        }

        public static int Update_MBR(MBR mbr)
        {
            int retval = 0;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                retval = connection.Execute("sp_update_member_infos",
                                            new
                                            {
                                                Mbr_ID = mbr.Mbr_ID,
                                                Mbr_nom = mbr.Mbr_nom,
                                                Mbr_prenom = mbr.Mbr_prenom,
                                                Mbr_sexe = mbr.Mbr_sexe,
                                                Mbr_naiss = mbr.Mbr_naiss,
                                                Mbr_adrs = mbr.Mbr_adrs,
                                                Mbr_num_boite = mbr.Mbr_num_boite,
                                                Mbr_cp = mbr.Mbr_cp,
                                                Mbr_loc = mbr.Mbr_loc,
                                                Mbr_mail = mbr.Mbr_mail,
                                                Mbr_fix_tel = mbr.Mbr_fix_tel,
                                                Mbr_gsm = mbr.Mbr_gsm,
                                                Mbr_cot_valide = mbr.Mbr_cot_valide,
                                                Mbr_est_pil = mbr.Mbr_est_pil,
                                                Mbr_est_adm = mbr.Mbr_est_adm,
                                                Mbr_passw = mbr.Mbr_passw
                                            },
                                            commandType: CommandType.StoredProcedure);
            }
            return retval;
        }

      static public  List <MBR> Read_all_members_id()
        {
            List<MBR> retVal;

            retVal = new List<MBR>();

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
                retVal = connection.Query<MBR>("read_all_members",
                                               commandType: CommandType.StoredProcedure).AsList<MBR>();

            return retVal;
        }

        static public string TranslateIDTOName(int mbr_id)
        {
            string retval;
           
           
            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                retval = connection.QuerySingle<string>("select_name_MBR_by_id",
                                        param: new { mbr_id = mbr_id },
                                        commandType: CommandType.StoredProcedure);
            }

            return retval;
        }


    }
  
    
}
