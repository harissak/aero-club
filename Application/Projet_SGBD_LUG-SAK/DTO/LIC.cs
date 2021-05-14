using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LIC
    {
        public int      Lic_ID { get; set; }
        public string   Lic_num { get; set; }
        public DateTime Lic_obt { get; set; }
        public DateTime Lic_exp { get; set; }
        public bool     Lic_active { get; set; }
        public string   Lic_pays { get; set; }
        public bool     Lic_cl1 { get; set; }
        public bool     Lic_cl2 { get; set; }
        public bool     Lic_cl3 { get; set; }
        public bool     Lic_cl4 { get; set; }
        public bool     Lic_cl5 { get; set; }
        public bool     Lic_cl6 { get; set; }
        public int      LIC_FK_MBR_ID { get; set; }
    }
}
