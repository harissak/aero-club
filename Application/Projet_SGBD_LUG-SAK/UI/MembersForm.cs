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
            this.addNewMember.ReadMember(Mbr_id);
            saveDeleteMember.Visible = true;
            this.saveDeleteMember.del_member_ID(Mbr_id);
            
        }


        private void updateMember(int Mbr_ID)
        {
            this.addNewMember.updateMember(Mbr_ID);
            
        }

        private void mbrList_Load(object sender, EventArgs e)
        {

        }
    }
}
