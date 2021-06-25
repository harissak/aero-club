using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using DTO;

namespace UI.User_control
{
    public partial class uc_md_del_reservation : UserControl
    {

        public event delRefresh refreshList;
        private RES res_courant;

        public uc_md_del_reservation()
        {
            InitializeComponent();
            this.res_courant = null;
        }

        private void Uc_btn_res_modify_Click(object sender, EventArgs e)
        {
            int machID = BL.Services_appareils.search_app_by_desc(uc_res_change_machine.Text).APP_ID();


          
                try
            {

                DateTime jour = Convert.ToDateTime(this.uc_res_change_date.SelectionRange.Start.ToShortDateString());
                DateTime heurdeb = this.dtp_ch_hour_start.Value;
                DateTime heurfin = this.dtp_ch_hour_fin.Value;


                BL.Service_réservation.Update_reservation(
                                 new DTO.RES
                                 {
                                     Res_ID = Convert.ToInt32(this.uc_ch_res_mbr_id.Text),
                                     Res_FK_Mbr_ID = Convert.ToInt32(this.uc_ch_res_mbr_id.Text),
                                     Res_FK_App_ID = machID,
                                     Res_date = jour,
                                     Res_hr_deb = new DateTime(jour.Year, jour.Month, jour.Day, heurdeb.Hour, heurdeb.Minute, 0),
                                     Res_hr_fin = new DateTime(jour.Year, jour.Month, jour.Day, heurfin.Hour, heurfin.Minute, 0),
                                     Res_est_annule = uc_res_change_annul.Checked,
                                     Res_est_prevenu = uc_res_change_prevu.Checked

                                 }).ToString();

                MessageBox.Show("You have succesfully made new reservation!!");
                res_binding_source.Clear();
                Clear_data();
                refreshList();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

    }

        private void uc_btn_res_delet_Click(object sender, EventArgs e)
        {
            BL.Service_réservation.Delete_reservation(Convert.ToInt32(this.uc_res_ch_id.Text));
            MessageBox.Show("You have successfuly deleted reservation.");
            res_binding_source.Clear();
            Clear_data();
            refreshList();
            this.Enabled = false;

        }

        private void Clear_data()
        {

            this.dtp_ch_hour_start.Text     = "";
            this.dtp_ch_hour_start.Text     = "";
            this.uc_res_change_nom.Text     = "";
            this.uc_res_change_machine.Text = "";

        }

       public void ReadData(int reservationID, int mbrID, int mashinID)
        {

            this.Enabled = true;
            String description = BL.Services_appareils.search_app_by_ID(mashinID).ToString();
            //insert data to modify reservation list 

            this.uc_res_change_nom.Text = BL.Services_membre.search_member_by_ID(mbrID).getNomPrenom();
            this.res_binding_source.DataSource = BL.Service_réservation.Read_reservation_by_ID(reservationID);
            this.uc_res_change_machine.DataSource = BL.Services_appareils.Read_all_app();          
            this.uc_res_change_machine.SelectedIndex = uc_res_change_machine.FindStringExact(description);
            this.uc_ch_res_mbr_id.DataSource = BL.Services_membre.LoadPilotOnly();
            this.uc_ch_res_mbr_id.SelectedIndex = uc_ch_res_mbr_id.FindStringExact(mbrID.ToString());
       
        }

        private void uc_md_del_reservation_Load(object sender, EventArgs e)
        {

        }
    }
}
