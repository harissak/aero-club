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
    public partial class uc_licenses_list : UserControl
    {
        public uc_licenses_list()
        {
            InitializeComponent();
        }

        private void uc_licenses_list_Load(object sender, EventArgs e)
        {
            this.bs_licenses.DataSource = BL.Services_licenses.Read_all_lic();
        }

        private void bt_search_name_Click(object sender, EventArgs e)
        {
            this.bs_licenses.DataSource = BL.Services_licenses.Get_Lic_ByName_Owner(this.tb_search_name.Text);
        }
    }
}
