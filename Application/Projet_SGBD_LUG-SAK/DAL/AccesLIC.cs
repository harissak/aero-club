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
    static public class AccesLIC
    {
        static public List<LIC> Read_all_Lic()
        {
            List<LIC> retval = new List<LIC>();

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                retval = connection.Query<LIC>("sp_select_all_licenses",
                                                commandType: CommandType.StoredProcedure).AsList<LIC>();
            }
            return retval;
        }

        static public List<LIC> Get_Lic_ByID_Owner(List<int> liste_ID_owners)
        {
            List<LIC> retval = new List<LIC>();
            List<LIC> current = new List<LIC>();

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                foreach (int id in liste_ID_owners)
                {
                    current = connection.Query<LIC>("sp_select_lic_by_id_owner",
                                                 param: new { @LIC_FK_MBR = id}, 
                                                commandType: CommandType.StoredProcedure).AsList<LIC>();
                    if(current.Count <= 0)
                    {
                    }
                    else
                    {
                        retval.Add(current[0]);
                        current.Clear();
                    }
                   
                }
            }
            return retval;
        }

        static public int Insert_Lic(LIC license)
        {
            int retval;
            DynamicParameters parameters;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                parameters = new DynamicParameters();
                parameters.Add("@LIC_ID", dbType: DbType.Int32, direction: ParameterDirection.Output);
                parameters.AddDynamicParams(license);
                connection.Execute("sp_insert_new_license",
                                    param: parameters,
                                    commandType: CommandType.StoredProcedure);

                retval = parameters.Get<int>("@LIC_ID");
                
            }
           return retval;
        }

        static public int Delete_Lic(int fk_id)
        {
            int retval;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                connection.Open();
                using (var transac = connection.BeginTransaction())
                {
                    retval = connection.Execute("sp_delete_license",
                                                param: new { @Lic_FK_MBR = fk_id },
                                                commandType: CommandType.StoredProcedure,
                                                transaction: transac);
                    transac.Commit();
                }

            }
            return retval;
        }

        static public List<LIC> Read_Lic_By_ID(int lic_id)
        {
            List<LIC> retval;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                retval = connection.Query<LIC>("select_lic_by_id",
                                                param: new { lic_id = lic_id },
                                                commandType: CommandType.StoredProcedure).AsList<LIC>();
            }
            return retval;
        }

        static public int Update_Lic(LIC update)
        {
            int retval;

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                retval = connection.Execute("sp_update_lic",
                                    new
                                    {
                                        Lic_ID = update.Lic_ID,
                                        Lic_num = update.Lic_num,
                                        Lic_obt = update.Lic_obt,
                                        Lic_exp = update.Lic_exp,
                                        Lic_active = update.Lic_active,
                                        Lic_pays = update.Lic_pays,
                                        Lic_cl1 = update.Lic_cl1,
                                        Lic_cl2 = update.Lic_cl2,
                                        Lic_cl3 = update.Lic_cl3,
                                        Lic_cl4 = update.Lic_cl4,
                                        Lic_cl5 = update.Lic_cl5,
                                        Lic_cl6 = update.Lic_cl6
                                    },
                                    commandType: CommandType.StoredProcedure);        
            }
            return retval;
        }

        static public LIC Read_Lic_By_FK_MBRID(int mbr_id)
        {
            List<LIC> liste;
            LIC retval = new LIC();
            

            using (IDbConnection connection = DAL.Utilitaire.ConnectionToLocalServer())
            {
                liste = connection.Query<LIC>("sp_select_lic_by_id_owner",
                                                param: new { LIC_FK_MBR = mbr_id },
                                                commandType: CommandType.StoredProcedure).AsList<LIC>();

                if (liste.Count > 0)
                    retval = liste[0];
            }
            
            return retval;
        }
    }
}
