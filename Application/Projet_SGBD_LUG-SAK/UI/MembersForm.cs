using System;
using System.Windows.Forms;
using BL;


namespace UI
{
    public partial class MembersForm : Form
    {
        private Form currentForm;
        public MembersForm()
        {
            InitializeComponent();
            saveDeleteMember.Visible = false;
        }


        private void recherce_Mbr(int Mbr_id)
        {
            this.saveDeleteMember.ReadMember(Mbr_id);
            saveDeleteMember.Visible = true;
            this.saveDeleteMember.del_member_ID(Mbr_id);

        }
  
        
        private void refreshMembersList()
        {
            this.mbrList.RefreshMemberList();
        }

    }
}
