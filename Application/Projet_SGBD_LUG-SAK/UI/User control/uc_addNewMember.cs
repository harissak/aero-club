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
    public partial class uc_addNewMember : UserControl
    {

        public event delRefresh refreshMbrList;

        public uc_addNewMember()
        {
            InitializeComponent();
           
        }

        private void addNewMember_Click(object sender, EventArgs e)
        {
            try
            {

                tb_Ins_ID.Text = BL.Services_membre.Add_new_member(
                                new DTO.MBR
                                {
                                    Mbr_nom = this.tb_Ins_Nom.Text,
                                    Mbr_prenom = this.tb_Ins_Prénom.Text,
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
                                    Mbr_est_adm = this.cb_Ins_is_admin.Checked,
                                    Mbr_est_pil = this.cb_Ins_is_pilot.Checked
                                }).ToString();


                MessageBox.Show("You have succesfully registered new member!!");
                refreshMbrList();
                ResetAllControls(this);
                
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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

                if (control is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    dateTimePicker.Value = DateTime.Now;
                }

            }
        }


    }
}
