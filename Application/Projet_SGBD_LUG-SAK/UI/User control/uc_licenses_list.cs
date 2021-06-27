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
    public partial class uc_licenses_list : UserControl
    {
        public event delSelectLIC SelectLic;

        public uc_licenses_list()
        {
            InitializeComponent();
        }

        private void uc_licenses_list_Load(object sender, EventArgs e)
        {
            this.bs_licenses.DataSource = BL.Services_licenses.Read_all_lic();
        }

        private void bt_search_name_Click(object sender, EventArgs e)
        {
            this.bs_licenses.DataSource = BL.Services_licenses.Get_Lic_ByName_Owner(this.tb_search_name.Text);
        }

        private void dgv_licenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1) //if header is clicked, do nothing
            {
                if (this.dgv_licenses.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    this.dgv_licenses.CurrentRow.Selected = true;

                    this.SelectLic(Int32.Parse(this.dgv_licenses.Rows[e.RowIndex].Cells["licIDDataGridViewTextBoxColumn"].FormattedValue.ToString()));
                }
            }
        }

        private void btn_reloiad_dgv_Click(object sender, EventArgs e)
        {
            this.bs_licenses.DataSource = BL.Services_licenses.Read_all_lic();
        }

        private void bt_search_mat_Click(object sender, EventArgs e)
        {
            int id_owner;
            if (Int32.TryParse(this.tb_search_mat.Text, out id_owner) == true)
                this.bs_licenses.DataSource = BL.Services_licenses.Get_Lic_ByID_Owner(id_owner);
            else
            {
                MessageBox.Show("Impossible to search the entered value, is the format correct or the cell empty?",
                             "Error!",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }

        }
    }
}
