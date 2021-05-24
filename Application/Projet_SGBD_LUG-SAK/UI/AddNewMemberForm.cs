using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AddNewMemberForm : MetroFramework.Forms.MetroForm
    {
        public AddNewMemberForm()
        {
            InitializeComponent();
        }

    

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                tb_Ins_ID.Text = BL.Services_membre.Add_new_member(
                                new DTO.MBR
                                {
                                    Mbr_nom = this.tb_Ins_Nom.Text,
                                    Mbr_prenom = this.tb_Ins_Prènom.Text,
                                    Mbr_sexe = Convert.ToChar(this.cb_Ins_Sex.Text),
                                    Mbr_naiss = Convert.ToDateTime(this.dt_Ins_Naissance.Text),
                                    Mbr_adrs = this.tb_Ins_Adresse.Text,
                                    Mbr_gsm = this.tb_Ins_GSM.Text,
                                    Mbr_fix_tel = this.tb_Ins_TeleFixe.Text,
                                    Mbr_cot_valide = Convert.ToDateTime(this.dt_Ins_cot_val.Text),
                                    Mbr_cp = this.tb_Ins_CP.Text,
                                    Mbr_loc = this.tb_Ins_Ville.Text,
                                    Mbr_num_boite = this.tb_Ins_NbrBoite.Text,
                                    Mbr_mail = this.tb_Ins_Mail.Text,
                                    Mbr_passw = this.tb_Ins_Password.Text,
                                    Mbr_est_adm = this.cb_Ins_Admin.Text == "OUI" ? true : false,
                                    Mbr_est_pil = this.cb_Ins_Pilot.Text == "OUI" ? true : false
                                }).ToString();
                this.Close();

                MessageBox.Show("You have succesfully registered new member!!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

           

        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }
    }
}
