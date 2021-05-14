using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RES
    {
        public  int Res_ID { get; set; }
        public DateTime Res_date { get; set; }
        public DateTime Res_hr_deb { get; set; }
        public DateTime Res_hr_fin { get; set; }
        public bool Res_est_annule { get; set; }
        public bool Res_est_prevenu { get; set; }
        public int Res_FK_Mbr_ID { get; set; }
        public int Res_FK_App_ID { get; set; }
    }
}
