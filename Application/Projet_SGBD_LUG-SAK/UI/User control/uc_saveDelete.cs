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
    public partial class uc_saveDelete : UserControl

    {

        private int member_id;
        public event delUpdate updateMbr;
        public event delRefresh refreshMbrList;

        public uc_saveDelete()
        {
            InitializeComponent();
        }

        private void deleteMember_Click(object sender, EventArgs e)
        {
            BL.Services_membre.Delete_member(member_id);
            MessageBox.Show("You have successfuly deleted member with MEMBER ID = " + member_id.ToString());
            bsMember.Clear();
            refreshMbrList();

        }

        public void del_member_ID(int Mbr_ID)
        {
            member_id = Mbr_ID;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void ReadMember(int Mbr_id)
        {
            this.bsMember.DataSource = BL.Services_membre.search_member_by_ID(Mbr_id);
        }

        private void modify_Click(object sender, EventArgs e)
        {

            try
            {

                BL.Services_membre.Update_member(
                                 new DTO.MBR
                                 {
                                     Mbr_ID = Convert.ToInt32(this.tb_mdf_ID.Text),
                                     Mbr_nom = this.tb_mdf_Nom.Text,
                                     Mbr_prenom = this.tb_mdf_Prénom.Text,
                                     Mbr_sexe = Convert.ToChar(this.cb_mdf_Sex.Text),
                                     Mbr_naiss = Convert.ToDateTime(this.dt_mdf_Naissance.Text),
                                     Mbr_adrs = this.tb_mdf_Adresse.Text,
                                     Mbr_gsm = this.tb_mdf_GSM.Text,
                                     Mbr_fix_tel = this.tb_mdf_TeleFixe.Text,
                                     Mbr_cot_valide = Convert.ToDateTime(this.dt_mdf_cot_val.Text),
                                     Mbr_cp = this.tb_mdf_CP.Text,
                                     Mbr_loc = this.tb_mdf_Ville.Text,
                                     Mbr_num_boite = this.tb_mdf_NbrBoite.Text,
                                     Mbr_mail = this.tb_mdf_Mail.Text,
                                     Mbr_passw = this.tb_mdf_Password.Text,
                                     Mbr_est_adm = this.cb_mdf_is_admin.Checked,    // Text == "OUI" ? true : false,
                                     Mbr_est_pil = this.cb_mdf_is_pilote.Checked    //Text == "OUI" ? true : false
                                 }).ToString();


                MessageBox.Show("You have succesfully updated new member infos!!");
                bsMember.Clear();
                refreshMbrList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void bsMember_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }    

}
