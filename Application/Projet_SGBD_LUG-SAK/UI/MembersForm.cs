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
        }

        private void btnSearchMember(object sender, EventArgs e)
        {

            if (!this.tbMemberName.Text.Equals(""))
                this.dgwShowMembers.DataSource = BL.Services_membre.search_member_by_name(tbMemberName.Text);
            else if (!this.tbMemberID.Text.Equals(""))
                this.dgwShowMembers.DataSource = BL.Services_membre.search_member_by_ID(Int32.Parse(tbMemberID.Text));
            else
                this.dgwShowMembers.DataSource = BL.Services_membre.search_member_by_name(tbMemberName.Text);
        }

        private void addNewMember(object sender, EventArgs e)

        {
            AddNewMemberForm addNewMemberF = new AddNewMemberForm();
            addNewMemberF.ShowDialog();
               
            
        }

        private void MembersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'membersDataSet.Mbr' table. You can move, or remove it, as needed.
            this.mbrTableAdapter.Fill(this.membersDataSet.Mbr);

        }
    }
}
