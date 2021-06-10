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

                 this.tb_Ins_ID.Text = BL.Services_membre.Add_new_member(
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
                
                //IF Pilote --> Creation of a blank license in order to keep DB in coherant status
                if(this.cb_Ins_is_pilot.Checked)
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
                        LIC_FK_MBR_ID = Int32.Parse(this.tb_Ins_ID.Text)
                    }
                    );
                    MessageBox.Show("You have succesfully registered a new pilot!!" + "\n\n" + "Don't forget to update the License");
                }
                else
                {
                    MessageBox.Show("You have succesfully registered new member!!");
                }                   

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

        private void uc_addNewMember_Load(object sender, EventArgs e)
        {

        }
    }
}
