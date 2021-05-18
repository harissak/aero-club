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


namespace UI
{
    public partial class BasicDBReadTest : Form
    {
        public BasicDBReadTest()
        {
            InitializeComponent();
        }

        private void BUT_Member_Click(object sender, EventArgs e)
        {
          // this.DGV_MBR.DataSource = BL.ServMBR.Read_MBR_BY_START_NAME(TB_MBR.Text);
        }

        private void TB_MBR_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGV_MBR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
