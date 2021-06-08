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
                throw new Exception("BL_APP_CHECK_RULE_1");
            return DAL.AccesApp.Add_new_app(app);
        }

        public static List<APP> Read_all_app()
        {
            return DAL.AccesApp.Read_all();
        }

        //public static List <APP> Read_app_imm_by_des (string desc_app)
        //{
        //    List<APP> retVal = new List<APP>();

        //   retVal.Add(DAL.AccesApp.Read_app_imm_by_desc(desc_app));

        //    return retVal;

        //}
        //public static APP Read_app_by_desc(string app_des)
        //{
        //    return DAL.AccesApp.Read_app_by_desc(app_des);
        //}

        public static APP search_app_by_desc(string app_desc)
        {

            

            return DAL.AccesApp.Read_app_by_desc(app_desc);

           

        }

        public static int Delete_app(int app_id)
        {
            int retval = 0;
            DateTime now = DateTime.Now;

            if(DAL.AccesRÉS.CheckIFRunningResByApp(app_id,now) > 0)
                throw new Exception("BL_APP_CHECK_RULE_2");


          //  retval = DAL.AccesApp.DeleteAPP(app_id);

            return retval;
        }
    }
}
