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
    public partial class uc_md_del_reservation : UserControl
    {
        public uc_md_del_reservation()
        {
            InitializeComponent();
        }


        private void uc_btn_res_cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
