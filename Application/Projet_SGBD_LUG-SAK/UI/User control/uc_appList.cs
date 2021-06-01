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
    public partial class uc_appList : UserControl
    {
        public uc_appList()
        {
            InitializeComponent();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
           this.bs_apps.DataSource = BL.Services_appareils.Read_all_app();
        }

        private void bs_app(object sender, EventArgs e)
        {

        }
    }
}
