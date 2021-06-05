using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace UI.User_control
{
    public partial class uc_appList_del : UserControl
    {
        public uc_appList_del()
        {
            InitializeComponent();
        }

        private void dgv_app_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bs_apps_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bt_app_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous confirmez la suppression ? ",
                               "Confirmation",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    APP select = (APP)this.bs_apps.Current;
                    BL.Services_appareils.Delete_app(select.App_ID);

                    this.bs_apps.RemoveCurrent();
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

        private void uc_appList_Load(object sender, EventArgs e)
        {
            this.bs_apps.DataSource = BL.Services_appareils.Read_all_app();
        }

    }
}
