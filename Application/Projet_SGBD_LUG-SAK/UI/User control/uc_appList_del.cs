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
using Utilitaires;


namespace UI.User_control
{
    public partial class uc_appList_del : UserControl
    {
        public event delSelectApp SelectApp;
        
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
                    MessageBox.Show(Utilitaires.Règles.DécodeMessage(ContexteErreur.APP, ex.Message),
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

       
        private void dgv_app_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1) //if header is clicked, do nothing
            {
                if (this.dgv_app_list.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    this.dgv_app_list.CurrentRow.Selected = true;

                    this.SelectApp(Int32.Parse(this.dgv_app_list.Rows[e.RowIndex].Cells["appIDDataGridViewTextBoxColumn"].FormattedValue.ToString()));
                }
            }
        }   

        public void Read_all_app()
        {
            this.bs_apps.DataSource = BL.Services_appareils.Read_all_app();
        }
    }
}
