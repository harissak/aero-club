using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitaires
{

    public enum ContexteErreur { MBR, RES, APP }
   static public class Règles
    {
        private static Dictionary<ContexteErreur, Dictionary<String, String>> dic;

        static Règles()
        {
            Règles.dic = new Dictionary<ContexteErreur, Dictionary<String, String>>();

            Règles.AjouterRègle(ContexteErreur.APP, "BL_APP_CHECK_RULE_1", "Imma can't be empty");
            Règles.AjouterRègle(ContexteErreur.APP, "BL_APP_CHECK_RULE_2", "Impossible to delete A/C classe while reservation(s) are active");
            Règles.AjouterRègle(ContexteErreur.APP, "BL_APP_CHECK_RULE_3", "Impossible to modify A/C classe while reservation(s) are active");
            Règles.AjouterRègle(ContexteErreur.MBR, "BL_MBR_CHECK_RULE_1", "Impossible to delete member while reservation(s) are active");
            Règles.AjouterRègle(ContexteErreur.RES, "BL_RES_CHECK_RULE_1", "Pilot can't do the reservation, cotisation is not valid anymore");
            Règles.AjouterRègle(ContexteErreur.RES, "BL_RES_CHECK_RULE_2", "Break time of 15 min btw reservation is not resepcted");
            Règles.AjouterRègle(ContexteErreur.RES, "BL_RES_CHECK_RULE_3", "reservation is more than 3 month in future");
            Règles.AjouterRègle(ContexteErreur.RES, "BL_RES_CHECK_RULE_4", "reservation is not under the licesence expiration + 1 month");
            Règles.AjouterRègle(ContexteErreur.RES, "BL_RES_CHECK_RULE_5", "It is not possible to make two or more reservation in same time");

        }



        private static void AjouterRègle(ContexteErreur contexte, string nom_contrainte, string message)
        {
            if (Règles.dic.ContainsKey(contexte) == false)
                Règles.dic.Add(contexte, new Dictionary<string, string>());
            Règles.dic[contexte].Add(nom_contrainte, message);
        }

        public static string DécodeMessage(ContexteErreur contexte, string message)
        {
            string retVal = message;

            if (Règles.dic.ContainsKey(contexte))
                foreach (String clé in Règles.dic[contexte].Keys)
                    if (message.Contains(clé))
                    {
                        retVal = Règles.dic[contexte][clé];
                        break;
                    }
            return retVal;
        }
    }
}
