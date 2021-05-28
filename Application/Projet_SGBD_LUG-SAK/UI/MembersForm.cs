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
            saveDelete1.Visible = false;
        }


        private void ucRech_Mbr(int Mbr_id)
        {
            this.ucAddNewMember.ReadMember(Mbr_id);
        }

      
    }
}
