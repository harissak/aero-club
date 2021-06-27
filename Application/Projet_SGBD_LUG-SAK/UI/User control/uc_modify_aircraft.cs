using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DTO;
using Utilitaires;

namespace UI.User_control
{
    public partial class uc_modify_aircraft : UserControl
    {
        public event delRefreshApp RefreshApp;

        public uc_modify_aircraft()
        {
            InitializeComponent();
        }

        public void ReadSelectedAircraft(int app_id)
        {
            int cb_select;
            this.bs_mod_app.DataSource = BL.Services_appareils.Read_appareil_by_ID(app_id);

            
             cb_select = ((APP)this.bs_mod_app.Current).GetClasse();


            this.cb_mod_app_class.SelectedIndex = cb_select - 1;
            
        }

        private void bt_mod_save_Click(object sender, EventArgs e)
        {
            try
            {
                BL.Services_appareils.Update_app(
                    new DTO.APP
                    {
                        App_ID = Convert.ToInt32(this.tb_mod_app_ID.Text),
                        App_imma = this.tb_mod_app_imma.Text,
                        App_classe = (this.cb_mod_app_class.SelectedItem.ToString() ),
                        App_descr = this.tb_mod_app_descr.Text
                    }) ;

                MessageBox.Show("Modification(s) done with sucess!",
                             "Sucess!",
                             MessageBoxButtons.OK);

                RefreshApp();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Utilitaires.Règles.DécodeMessage(ContexteErreur.APP, ex.Message),
                               "Avertissement",
                               MessageBoxButtons.OK
                               , MessageBoxIcon.Error);
            }

        }

    }
}
