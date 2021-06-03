using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.User_control
{
    public partial class uc_add_new_reservation : UserControl
    {

        private int app_id;

        public uc_add_new_reservation()
        {
            InitializeComponent();
        }


        private void uc_btn_add_res_Click(object sender, EventArgs e)
        {
            try
            {
                String heurD = this.cb_uc_res_aj_heur_deb.Text;
                DateTime heurDebut = DateTime.ParseExact("12:00", "HH:mm", System.Globalization.CultureInfo.CurrentCulture);
                String heurF = this.cb_uc_res_aj_heur_fin.Text;
                DateTime heurFin = DateTime.ParseExact("14:00", "HH:mm", System.Globalization.CultureInfo.CurrentCulture);


                //MessageBox.Show(heurDebut.ToString());


                BL.Service_réservation.Add_new_reservation(
                                 new DTO.RES
                                 {
                                     Res_FK_Mbr_ID = Convert.ToInt32(this.cb_uc_res_aj_id.Text),
                                     Res_hr_deb = heurDebut,
                                     Res_date = Convert.ToDateTime(this.dt_uc_res_aj_date.SelectionRange.Start.ToShortDateString()),
                                     Res_hr_fin = heurFin,
                                     Res_est_annule = false,
                                     Res_est_prevenu = this.cb_uc_add_res_prevu.Text == "OUI" ? true : false,
                                     Res_FK_App_ID = app_id



                                 }).ToString();


                MessageBox.Show("You have succesfully made new reservation!!");


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void LoadMemberName(object sender, EventArgs e)
        {
            
            this.cb_uc_res_aj_id.DataSource = BL.Services_membre.read_all_members_id();
            this.cb_uc_res_aj_machine.DataSource = BL.Services_appareils.Read_all_app();
           
        }

        private void MbrIDValueChanged(object sender, EventArgs e)
        {
          List<DTO.MBR> member= BL.Services_membre.search_member_by_ID(Convert.ToInt32(this.cb_uc_res_aj_id.Text));
          this.tb_uc_res_aj_nom.Text = member[0].getNomPrenom();
        }

        private void machine_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DTO.APP> appareil = BL.Services_appareils.search_app_by_desc(this.cb_uc_res_aj_machine.Text);
            app_id = appareil[0].APP_ID();  

        }
    }
}
