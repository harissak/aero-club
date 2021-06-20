using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitaires;

namespace UI.User_control
{
    public partial class uc_add_new_reservation : UserControl
    {

        private int app_id;
        public event delRefresh refreshList;

        public uc_add_new_reservation()
        {
            InitializeComponent();
            this.dtp_hour_end.Value = this.dtp_hour_start.Value.AddMinutes(60);
            this.dtp_hour_end.MinDate = this.dtp_hour_start.Value.AddMinutes(60); //min 1 hour
            this.dtp_hour_end.MaxDate = this.dtp_hour_start.Value.AddMinutes(360); //max 6 hour

        }

      


        private void uc_btn_add_res_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime jour = Convert.ToDateTime(this.dt_uc_res_aj_date.SelectionRange.Start.ToShortDateString());

            //Maybe we should check this in sql as constraints
            if (jour >= today.AddDays(-1))
            {

                try
                {
                    DateTime heurdeb = this.dtp_hour_start.Value;
                    DateTime heurfin = this.dtp_hour_end.Value;
                    DateTime full_hr_deb = new DateTime(jour.Year, jour.Month, jour.Day, heurdeb.Hour, heurdeb.Minute, 0);
                    DateTime full_hr_fin = new DateTime(jour.Year, jour.Month, jour.Day, heurfin.Hour, heurfin.Minute, 0);

                    if (Check_rules(today, jour, Int32.Parse(this.cb_uc_res_aj_id.Text), app_id, full_hr_deb,full_hr_fin))
                    { 
                    
                        BL.Service_réservation.Add_new_reservation(
                                         new DTO.RES
                                         {
                                             Res_FK_Mbr_ID = Convert.ToInt32(this.cb_uc_res_aj_id.Text),
                                             Res_date = jour,
                                             Res_hr_deb = full_hr_deb,
                                             Res_hr_fin = full_hr_fin,
                                             Res_est_annule = false,
                                             Res_est_prevenu = false,
                                             Res_FK_App_ID = app_id
                                         }).ToString();


                            MessageBox.Show("You have succesfully made new reservation!!");
                            refreshList();
                            ResetAllControls(this);
                    
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show((ex.Message),
                           "Warning",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("You cannot choose date older than todays date.",
                                       "Information",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
            }
        }

        private void LoadPilotOnly(object sender, EventArgs e)
        {
            
            this.cb_uc_res_aj_id.DataSource = BL.Services_membre.LoadPilotOnly();
          //  this.cb_uc_res_aj_machine.DataSource = BL.Services_appareils.Read_all_app(); //loading of the CB (ALL) - TO DELETE IF LOAD A/C per ID is working - FLO-

        }

        private void MbrIDValueChanged(object sender, EventArgs e)
        {
            this.tb_uc_res_aj_nom.Text= BL.Services_membre.search_member_by_ID(Convert.ToInt32(this.cb_uc_res_aj_id.Text)).getNomPrenom();

            //load only authorised A/C
            this.cb_uc_res_aj_machine.Text = ""; 
            this.cb_uc_res_aj_machine.DataSource = BL.Services_appareils.Get_Authorized_planes_by_PilotID(Int32.Parse(this.cb_uc_res_aj_id.Text));

        }

        private void machine_SelectedIndexChanged(object sender, EventArgs e)
        {
            app_id = Convert.ToInt32(BL.Services_appareils.search_app_by_desc(this.cb_uc_res_aj_machine.Text).APP_ID());

        }

        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is DateTimePicker && control.Name == "dtp_hour_start")
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    dateTimePicker.Value = DateTime.Now;
                }

                if (control is MonthCalendar)
                {
                    MonthCalendar monthCalendar = (MonthCalendar)control;
                    monthCalendar.TodayDate = DateTime.Now;
                }
            }
        }

        private void dtp_hour_start_ValueChanged(object sender, EventArgs e)
        {
            this.dtp_hour_end.MinDate = this.dtp_hour_start.Value.AddMinutes(60); //min 1 hour
            this.dtp_hour_end.MaxDate = this.dtp_hour_start.Value.AddMinutes(360); //max 6 hour
        }

        private bool Check_rules(DateTime today, DateTime jour, int mbr_id, int app_id, DateTime full_hr_deb, DateTime full_hr_fin)
        {
            bool retVal = false;

            try
            {
                BL.Service_réservation.Res_Check_ThreeMonthDelay(today, jour);                              //check if reservation is less than 3 months  in future
                BL.Service_réservation.Res_Check_Pilot_Lic(mbr_id, jour);
                BL.Service_réservation.Res_check_cotisation_status(mbr_id);                                   //check if cotisation is up to date
                BL.Service_réservation.Res_Check_APP_Break_Time(app_id, jour, full_hr_deb, full_hr_fin);     //Check if reservation respect 15 min break between a other reservation
                BL.Service_réservation.Pilot_has_another_reservation(mbr_id, jour, full_hr_deb, full_hr_fin); // Checke does pilot has another reservation at same time

                retVal = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Utilitaires.Règles.DécodeMessage(ContexteErreur.RES, ex.Message),
                           "Warning",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }

            return retVal;

        }
    }
}
