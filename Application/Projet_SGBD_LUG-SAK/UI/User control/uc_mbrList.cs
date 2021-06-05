
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
    public partial class uc_mbrList : UserControl
    {
        public event delSelect SelectMbr;
        public uc_mbrList()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.tbMemberName.Text.Equals(""))
                this.bs_members_list.DataSource = BL.Services_membre.search_member_by_name(tbMemberName.Text);
            else if (!this.tbMemberID.Text.Equals(""))
                this.bs_members_list.DataSource = BL.Services_membre.search_member_by_ID(Int32.Parse(tbMemberID.Text));
            else
                this.bs_members_list.DataSource = BL.Services_membre.search_member_by_name(tbMemberName.Text);
        }


        private void ucRech_mbr(object sender, EventArgs e)
        {
            this.bs_members_list.DataSource = BL.Services_membre.search_member_by_name(tbMemberName.Text);
        }

        private void itemCliked(object sender, DataGridViewCellEventArgs e)
        {

            ///in video prof is using LIST VIEW and hier we have DATAGRIDVIEW and method to get ID is different
            /// we can decide to use this one or to change to LISTVIEW
            /// DATAGRIDVIEW doesn't have option "SELECTED INDEX CHANGED"

            if (dgvMbrList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvMbrList.CurrentRow.Selected = true;

                this.SelectMbr(Int32.Parse( dgvMbrList.Rows[e.RowIndex].Cells["Mbr_ID"].FormattedValue.ToString()));
                
            }
        }

        private void dgvMbrList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void RefreshMemberList()
        {
            this.bs_members_list.DataSource = BL.Services_membre.search_member_by_name(tbMemberName.Text);
        }
        
    }
}
