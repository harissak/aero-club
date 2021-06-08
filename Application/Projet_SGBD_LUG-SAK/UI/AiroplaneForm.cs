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
    public partial class AiroplaneForm : Form
    {
        public AiroplaneForm()
        {
            InitializeComponent();
            this.uc_add_aircraft1.Visible = false;
        }

        private void uc_appList1_Load(object sender, EventArgs e)
        {

        }

        private void AiroplaneForm_Load(object sender, EventArgs e)
        {

        }

        private void bt_add_aircraft_Click(object sender, EventArgs e)
        {
            this.uc_add_aircraft1.Visible = true;
            this.uc_add_aircraft1.Enabled = true;
            this.bt_cancel_add.Visible = true;
            this.uc_modify_aircraft1.Visible = false;
        }

        private void bt_cancel_add_Click(object sender, EventArgs e)
        {
            this.uc_add_aircraft1.Visible = false;
            this.bt_cancel_add.Visible = false;
            this.uc_modify_aircraft1.Visible = true;
        }

        private void uc_appList1_SelectApp(int appID)
        {
            this.uc_modify_aircraft1.ReadSelectedAircraft(appID);
        }
    }
}
