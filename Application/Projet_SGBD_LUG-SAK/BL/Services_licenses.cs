using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BL
{
    public static class Services_licenses
    {
        public static List<LIC> Read_all_lic()
        {
            return DAL.AccesLIC.Read_all_Lic();
        }

        public static List<LIC> Get_Lic_ByName_Owner(string name)
        {
            List<LIC> retval = new List<LIC>();
            List<MBR> owners = BL.Services_membre.search_member_by_name(name);
            List<int> fk_id = new List<int>();

            //recuperation of owner ID with this start of name, only if they are pilot
            foreach (MBR owner in owners)
            {
                if (owner.Mbr_est_pil == true)
                {
                    fk_id.Add(owner.Mbr_ID);
                }
            }

            retval = DAL.AccesLIC.Get_Lic_ByName_Owner(fk_id);

            return retval;
        }

        public static int Insert_Lic(LIC license)
        {
            int retval;

            retval = DAL.AccesLIC.Insert_Lic(license);

            return retval;
        }

        public static int Delete_Lic(int fk_id)
        {
            int retval;

            retval = DAL.AccesLIC.Delete_Lic(fk_id);

            return retval;
        }

        public static List<LIC> Read_Lic_By_ID(int lic_id)
        {
            List<LIC> retval = new List<LIC>();

            retval = DAL.AccesLIC.Read_Lic_By_ID(lic_id);

            return retval;
        }

        public static int Update_lic(LIC update) 
        {
            int retval;

            retval = DAL.AccesLIC.Update_Lic(LIC update);

            return retval;
        }
    
    }
}
