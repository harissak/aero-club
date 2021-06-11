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
