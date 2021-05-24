using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MBR
    {

        public int        Mbr_ID { get; set; }
        public string     Mbr_nom { get; set; }
        public string     Mbr_prenom { get; set; }
        public char?      Mbr_sexe { get; set; }
        public DateTime   Mbr_naiss { get; set; }
        public string     Mbr_adrs { get; set; }
        public string     Mbr_num_boite { get; set; }
        public string     Mbr_cp { get; set; }
        public string     Mbr_loc { get; set; }
        public string     Mbr_mail { get; set; }
        public string     Mbr_fix_tel { get; set; }
        public string     Mbr_gsm { get; set; }
        public DateTime   Mbr_cot_valide { get; set; }
        public bool       Mbr_est_pil { get; set; }
        public bool       Mbr_est_adm { get; set; }
        public string     Mbr_passw { get; set; }
    }
}
