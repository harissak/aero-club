using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class LicenceForm : Form
    {
        public event delSearchLICbyName SearchLICbyName;

        public LicenceForm()
        {
            InitializeComponent();
        }

        private void setting_uc_licenses_list_SelectLic(int lic_ID)
        {
            this.uc_licenses_mod1.Read_lic(lic_ID);
        }

    }
}
