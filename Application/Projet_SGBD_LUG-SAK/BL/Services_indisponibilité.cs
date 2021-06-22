using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BL
{
    public static class Services_indisponibilité
    {
       public static bool Check_if_APP_has_indisp(int app_id,DateTime start,DateTime end)
        {
            DateTime now = DateTime.Now;
            bool retval = false;
            List<Indisp> indisponibilités = new List<Indisp>();

            indisponibilités = DAL.AccesIndisp.Get_Current_Indisp_By_APP(app_id, now);

            foreach (Indisp indispo in indisponibilités)
            {
                if((end >= indispo.Indisp_heure_deb && end <= indispo.Indisp_heure_fin) || 
                    (start >= indispo.Indisp_heure_deb && start <= indispo.Indisp_heure_fin))
                {
                    retval = true;
                    break;
                }
            }

            return retval;
        }
    }
}
