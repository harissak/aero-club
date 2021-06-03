using DTO;
using System;
using System.Windows.Forms;

namespace UI.User_control
{
    public partial class uc_reservations : UserControl
    {
        public uc_reservations()
        {
            InitializeComponent();

        }

      

        private void LoadAllReservation(object sender, EventArgs e)
        {
            this.bs_reservation_list.DataSource = BL.Service_réservation.Read_all_reservations();
        }

        private void bt_uc_res_search_Click(object sender, EventArgs e)
        {

        }

        //test

    }
}