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

        public static List <MBR> search_member_by_name (String memberName)
        {
            return DAL.AccesMBR.Read_MBR_BY_START_NAME(memberName);
        }

        public static List<MBR> search_member_by_ID(int memberID)
        {

            List<MBR> retVal = new List<MBR>();
            
            retVal.Add(DAL.AccesMBR.Read_MBR_BY_ID(memberID));

            return retVal;
            
        }

        public static int Add_new_member ( MBR mbr)
        {
            return DAL.AccesMBR.Add_new_member(mbr);
        }

        public static int Delete_member(int MBR_ID)
        {
            int retval = 0;

            //TO ADD: CHECK IF MBR HAS OPEN RESERVATION -FLO-

            retval = DAL.AccesMBR.Delete_MBR(MBR_ID);

            return retval;
        }

        public static int Update_member(MBR mbr)
        {
            //TO ADD: can't remove pilot if there is a running config -FLO-
            int retval = 0;


                              // I dont know and can not figure out why this funkcion doesnt work
                              // just to test MODIFY METHOD i put it in comment

            MBR current = mbr;//DAL.AccesMBR.Read_MBR_BY_ID(mbr.Mbr_ID);

            if (current != null)
                retval = DAL.AccesMBR.Update_MBR(current);

            return retval;
        }

        public static List<MBR> read_all_members_id()
        {
            return DAL.AccesMBR.Read_all_members_id();
        }

        //public static string Read_member_by_id(int MBR_ID)
        //{
        //    return DAL.AccesMBR.Read_member_by_id(MBR_ID);
        //}

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
    }
}
