using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL
{
    public static class Services_appareils
    {
        public static List<APP> Read_appareil_by_ID(int appID)
        {

            List<APP> retVal = new List<APP>();

            retVal.Add(DAL.AccesApp.Read_App_By_ID(appID));

            return retVal;

        }

        public static APP search_app_by_ID(int APP_ID)
        {
            return DAL.AccesApp.Read_App_By_ID(APP_ID);
        }

        public static int Add_new_app(APP app)
        {
            if (app.App_imma == "")
                throw new Exception("BL_APP_CHECK_RULE_1"); //Imma can't be empty
            return DAL.AccesApp.Add_new_app(app);
        }

        public static List<APP> Read_all_app()
        {
            return DAL.AccesApp.Read_all();
        }


        public static APP search_app_by_desc(string app_desc)
        {
            return DAL.AccesApp.Read_app_by_desc(app_desc);
        }

        public static int Delete_app(int app_id)
        {
            int retval = 0;
            DateTime now = DateTime.Now;

            if(DAL.AccesRÉS.CheckIFRunningResByApp(app_id,now) > 0)
                throw new Exception("BL_APP_CHECK_RULE_2"); // : Impossible to delete A/C classe while reservation(s) are active


            retval = DAL.AccesApp.DeleteAPP(app_id);

            return retval;
        }

        public static int Update_app(APP update)
        {
            int retval = 0;
            DateTime now = DateTime.Now;

            //check if class is modified in update
            if (update.App_classe != (search_app_by_ID(update.App_ID)).App_classe)
            {
                if (DAL.AccesRÉS.CheckIFRunningResByApp(update.App_ID, now) > 0) //check if running reservation on this A/C
                    throw new Exception("BL_APP_CHECK_RULE_3"); // If yes : Impossible to modify A/C classe while reservation(s) are active
            }
            
            
               retval = DAL.AccesApp.Modify_app(update);
            

            return retval;
        }

       public static List<APP> Get_Authorized_planes_by_PilotID(int pilot_id)
        {
            List<APP> retval = new List<APP>();
            List<APP> all_app = BL.Services_appareils.Read_all_app();
            List<int> list_class;

            list_class = BL.Services_licenses.Get_Lic_Class_active_By_mbrID(pilot_id);

            foreach (APP aircraft in all_app)
            {
                if (list_class.Contains(Int32.Parse(aircraft.App_classe)))
                    retval.Add(aircraft);
            }

            return retval;
        }
    }
}
