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

        public uc_saveDelete()
        {
            InitializeComponent();
        }

        private void deleteMember_Click(object sender, EventArgs e)
        {
            BL.Services_membre.Delete_member(member_id);
            MessageBox.Show("You have successfuly deleted member with MEMBER ID = " + member_id.ToString()); ;
        }

        public void del_member_ID (int Mbr_ID)
        {
            member_id = Mbr_ID;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void modify_Click(object sender, EventArgs e)
        {
            this.updateMbr(member_id);
        }
    }

}
