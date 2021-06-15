using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BL
{
    public static class Services_membre
    {

        public static List<MBR> search_member_by_name(String memberName)
        {
            return DAL.AccesMBR.Read_MBR_BY_START_NAME(memberName);
        }



        public static int Add_new_member(MBR mbr)
        {
            return DAL.AccesMBR.Add_new_member(mbr);
        }

        public static int Delete_member(int MBR_ID)
        {
            int retval = 0;

            if (DAL.AccesRÉS.CheckIFRunningResByMbrId(MBR_ID) > 0) //check if mbr has running reservation
                throw new Exception("BL_MBR_CHECK_RULE_1");        //if yes cannot delete, delete reservation first

            retval = DAL.AccesMBR.Delete_MBR(MBR_ID);

            return retval;
        }

        public static int Update_member(MBR mbr)
        {
            //TO ADD: can't remove pilot if there is a running config -FLO-
            int retval = 0;


            MBR current = mbr;//DAL.AccesMBR.Read_MBR_BY_ID(mbr.Mbr_ID);

            if (current != null)
                retval = DAL.AccesMBR.Update_MBR(current);

            return retval;
        }

        public static List<MBR> read_all_members_id()
        {
            return DAL.AccesMBR.Read_all_members_id();
        }

        public static MBR search_member_by_ID(int MBR_ID)
        {
            return DAL.AccesMBR.Read_MBR_BY_ID(MBR_ID);
        }

        //test
        public static string TranslateIDToName(string id)
        {
            return DAL.AccesMBR.TranslateIDTOName(Int32.Parse(id));
        }

        public static List<MBR> LoadPilotOnly()
        {
            List<MBR> retval = new List<MBR>();
            List<MBR> allmbr = new List<MBR>();

            allmbr = DAL.AccesMBR.Read_MBR_BY_START_NAME("");

            foreach (MBR membre in allmbr)
            {
                if (membre.Mbr_est_pil == true)
                    retval.Add(membre);
            }

            retval.Sort();

            return retval;
        }

        public static bool Modif_Is_upgratedPilot(int mbr_id, bool modif_pilot)
        {
            bool retval = false;
            bool cur_pilot_status_db = DAL.AccesMBR.Read_MBR_BY_ID(mbr_id).Mbr_est_pil;

            if (modif_pilot == true && cur_pilot_status_db == false)                 //cb modification pilot is checked
                retval = true;                                                      //If is not pilote in DB --> Is an upgrade
       
            return retval;
        }

        public static bool Modif_Is_DowngradeMBR(int mbr_id, bool modif_pilot)
        {
            bool retval = false;
            bool cur_pilot_status_db = DAL.AccesMBR.Read_MBR_BY_ID(mbr_id).Mbr_est_pil;

            if (modif_pilot == false && cur_pilot_status_db == true)               //cb modification pilot is not checked
                retval = true;                                                     //if is pilot in DB --> Is a downgrade

            return retval;
            
        }

        public static bool Check_cotisation_status(int mbr_id)
        {
            bool retval = true;
            DateTime current_date = DateTime.Now;
            DateTime cotisation_val;

            cotisation_val = (DAL.AccesMBR.Read_MBR_BY_ID(mbr_id)).Mbr_cot_valide;

            if (cotisation_val < current_date)
                retval = false;

            return retval;   
        }

        //test
        //public static string TranslateIDToName(string id)
        //{
        //    return DAL.AccesMBR.TranslateIDTOName(Int32.Parse(id));
        //}

        //public static List<MBR> LoadPilotOnly()
        //{
        //    List<MBR> retval = new List<MBR>();
        //    List<MBR> allmbr = new List<MBR>();

        //    allmbr = DAL.AccesMBR.Read_MBR_BY_START_NAME("");
        //}

    }

}

