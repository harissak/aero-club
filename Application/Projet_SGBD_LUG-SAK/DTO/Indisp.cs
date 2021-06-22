using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Indisp
    {
        public int Indisp_ID { get; set; }
        public string Indisp_desc { get; set; }
        public DateTime Indisp_jour_deb { get; set; }
        public DateTime Indisp_heure_deb { get; set; }
        public DateTime Indisp_jour_fin { get; set; }
        public DateTime dateTime { get; set; }
        public DateTime Indisp_heure_fin { get; set; }
        public int Indisp_FK_App_ID { get; set; }
    }
}
