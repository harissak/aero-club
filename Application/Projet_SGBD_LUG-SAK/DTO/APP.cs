using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class APP
    {
        public int    App_ID { get; set; }
        public string App_imma { get; set; }
        public string App_classe { get; set; }
        public string App_descr { get; set; }

        public override string ToString()
        {
            return this.App_descr;
        }

        public int APP_ID ()
        {
            return App_ID;
        }

        public int GetClasse()
        {
            return Int32.Parse( this.App_classe);
        }
    }
}
