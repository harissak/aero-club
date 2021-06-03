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
    public partial class uc_reservations : UserControl
    {
        public uc_reservations()
        {
            InitializeComponent();
            
        }

        private void rESBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void LoadAllReservation(object sender, EventArgs e)
        {
            this.bs_reservation_list.DataSource = BL.Service_réservation.Read_all_reservations();
        }
    }
}
