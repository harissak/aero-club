using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

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
            if(!this.tbMemberName.Text.Equals(""))
                this.dgwShowMembers.DataSource = AccesMBR.Read_MBR_BY_START_NAME(tbMemberName.Text);
            else if (!this.tbMemberID.Text.Equals(""))
                this.dgwShowMembers.DataSource = AccesMBR.Read_MBR_BY_ID(Int32.Parse(tbMemberID.Text));
            else
                this.dgwShowMembers.DataSource = AccesMBR.Read_MBR_BY_START_NAME(tbMemberName.Text);
        }

        private void addNewMember(object sender, EventArgs e)
        {
            AddNewMemberForm addNewMemberF = new AddNewMemberForm();
            addNewMemberF.ShowDialog();
               
            
        }
    }
}
