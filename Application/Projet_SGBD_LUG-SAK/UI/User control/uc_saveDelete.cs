using DTO;
using FluentValidation.Results;
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
    public partial class uc_saveDelete : UserControl

    {
        private int member_id;
        public event delUpdate updateMbr;
        public event delRefresh refreshMbrList;
        private MBR Mbr_courant;

        public uc_saveDelete()
        {
            InitializeComponent();
            this.Mbr_courant = null;
        }

        private void deleteMember_Click(object sender, EventArgs e)
        {

            try
            {

            //delete License if present to keep db coherent
            if(BL.Services_membre.search_member_by_ID(member_id).Mbr_est_pil == true)
                BL.Services_licenses.Delete_Lic(member_id);

            BL.Services_membre.Delete_member(member_id);
            
            MessageBox.Show("You have successfuly deleted member with MEMBER ID = " + member_id.ToString());
            bsMember.Clear();
            refreshMbrList();


            } catch (Exception ex)
            {
                MessageBox.Show(Utilitaires.Règles.DécodeMessage(ContexteErreur.MBR, ex.Message),
                               "Avertissement",
                               MessageBoxButtons.OK
                               , MessageBoxIcon.Error);

            }

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
            this.Mbr_courant = BL.Services_membre.search_member_by_ID(Mbr_id);
            this.bsMember.DataSource = this.Mbr_courant;
          
        }

        private void modify_Click(object sender, EventArgs e)
        {
         

            if(this.ValidationEncodages()== true)
            {

            try
            {
                //check if member is upgraded to pilot, if yes create a license
                if (BL.Services_membre.Modif_Is_upgratedPilot(Convert.ToInt32(this.tb_mdf_ID.Text), this.cb_mdf_is_pilote.Checked) == true)
                {
                    BL.Services_licenses.Insert_Lic(
                    new DTO.LIC
                    {
                        Lic_num = "00000000",
                        Lic_obt = new DateTime(1900, 01, 01),
                        Lic_exp = new DateTime(2100, 01, 01),
                        Lic_active = false,
                        Lic_pays = "XXXXXXXX",
                        Lic_cl1 = false,
                        Lic_cl2 = false,
                        Lic_cl3 = false,
                        Lic_cl4 = false,
                        Lic_cl5 = false,
                        Lic_cl6 = false,
                        LIC_FK_MBR_ID = Int32.Parse(this.tb_mdf_ID.Text)
                    }
                    );
                }
                else
                {   //Check if member is downgraded to member if yes delete license
                    if (BL.Services_membre.Modif_Is_DowngradeMBR(Convert.ToInt32(this.tb_mdf_ID.Text), this.cb_mdf_is_pilote.Checked) == true)
                    {
                        BL.Services_licenses.Delete_Lic(Int32.Parse(this.tb_mdf_ID.Text));
                    }
                }

                //modification of the member
                BL.Services_membre.Update_member(this.Mbr_courant);
           
            MessageBox.Show("You have succesfully updated new member infos!!");
                bsMember.Clear();
                refreshMbrList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                }
            }


        }

      

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void uc_saveDelete_Load(object sender, EventArgs e)
        {

        }

        private bool ValidationEncodages()
        {

            ValidationResult résultat = new MBRValidateru().Validate(this.Mbr_courant);

            bool retVal = résultat.IsValid;
            string message = "";

            if (retVal == false)
            {
                foreach (ValidationFailure erreur in résultat.Errors)
                {
                    message += "- " + erreur.ErrorMessage + " \n";
                }
                MessageBox.Show("A corriger : \n" + message,
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

            }
            return retVal;
        }

       
    }    

}
