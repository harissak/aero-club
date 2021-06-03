using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public static class Utilitaire
    {
        public static IDbConnection ConnectionToLocalServer()
        {
            //add in comment the connection to your locale machine you wish to save here


            //lpt flo: new SqlConnection(@"Data source=laptop-rud1s1fu\sqlexpress; Initial catalog=Projet_SGBD_LUG-SAK; Integrated Security =True"); 
            //desktop flo: new SqlConnection(@"Data source=desktop-08pcs13\sqlexpress; Initial catalog=Projet_SGBD_LUG-SAK; Integrated Security =True"); 
            //return new SqlConnection(@"Data Source=DESKTOP-PR1OB8V\SQLEXPRESS;Initial Catalog=ULM_SGBD_LUG-SAK;Integrated Security=True");
           return new SqlConnection(@"Data Source=DESKTOP-08PCS13\SQLEXPRESS; Initial catalog=ULM_SGBD_LUG-SAK; Integrated Security =True");


        }
    }
}
