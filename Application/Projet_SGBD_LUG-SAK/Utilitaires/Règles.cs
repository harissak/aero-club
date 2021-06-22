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

            Règles.AjouterRègle(ContexteErreur.APP, "BL_APP_CHECK_RULE_1", "L'immatriculation de l'appareil doit etre remplie");
            Règles.AjouterRègle(ContexteErreur.APP, "BL_APP_CHECK_RULE_2", "Impossible de suprimmer l'appareil, une reservation est en cours");
            Règles.AjouterRègle(ContexteErreur.APP, "BL_APP_CHECK_RULE_3", "Impossible de modifier les classes de l'appareil, une reservation est en cours");
            Règles.AjouterRègle(ContexteErreur.MBR, "BL_MBR_CHECK_RULE_1", "Impossible de supprimer un membre pilote  qui à au moin une reservation active");
            Règles.AjouterRègle(ContexteErreur.RES, "BL_RES_CHECK_RULE_1", "Impossible de proceder à la reservation, cotisation périmée");
            Règles.AjouterRègle(ContexteErreur.RES, "BL_RES_CHECK_RULE_2", "Temps de repos de 15 minutes avant le decollage et/ou apres l'aterissage n'est pas respecté");
            Règles.AjouterRègle(ContexteErreur.RES, "BL_RES_CHECK_RULE_3", "La reservation est dans plus de trois mois");
            Règles.AjouterRègle(ContexteErreur.RES, "BL_RES_CHECK_RULE_4", "Impossible de proceder à la reservation, licence périmée");
            Règles.AjouterRègle(ContexteErreur.RES, "BL_RES_CHECK_RULE_5", "Impossible de proceder à la reservation en même temp qu'une autre");
            Règles.AjouterRègle(ContexteErreur.RES, "BL_RES_CHECK_RULE_6", "Impossible de proceder à la reservation, appareil indisponible à la periode souhaitée");

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
