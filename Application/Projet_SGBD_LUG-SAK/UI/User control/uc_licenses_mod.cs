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
    public partial class uc_licenses_mod : UserControl
    {
        public uc_licenses_mod()
        {
            InitializeComponent();
        }

        public void Read_lic(int lic_ID)
        {
            this.bs_modif_lic.DataSource = BL.Services_licenses.Read_Lic_By_ID(lic_ID);
        }

        private void bt_modif_lic_save_Click(object sender, EventArgs e)
        {
            try
            {
                BL.Services_licenses.Update_lic(
                    new DTO.LIC
                    {
                        Lic_ID =  Int32.Parse(this.tb_modif_lic_ID.Text),
                        Lic_num = this.tb_modif_Lic_num.Text,
                        Lic_obt = this.dtp_mod_lic_obt.Value,
                        Lic_exp = this.dtp_modif_lix_exp.Value,
                        Lic_active = this.cb_modif_lic_active.Checked,
                        Lic_pays = this.tb_modif_lic_country.Text,
                        Lic_cl1 = this.cb_modif_lic_cl1.Checked,
                        Lic_cl2 = this.cb_modif_lic_cl2.Checked,
                        Lic_cl3 = this.cb_modif_lic_cl3.Checked,
                        Lic_cl4 = this.cb_modif_lic_cl4.Checked,
                        Lic_cl5 = this.cb_modif_lic_cl5.Checked,
                        Lic_cl6 = this.cb_modif_lic_cl6.Checked
                    });

                MessageBox.Show("Modification(s) done with sucess!",
                             "Sucess!",
                             MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show((ex.Message),
                       "Warning",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }

    }
}
