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
    public partial class ReservationsForm : Form
    {
        public ReservationsForm()
        {
            InitializeComponent();
            this.tab_mdf_reservation.Enabled = false;
            DeleteOldReservations();


        }
        private void SelectReservationID(int resID, int mbrID, int machineID)
        {
            this.md_del_reservation.ReadData(resID, mbrID, machineID);
            this.tab_mdf_reservation.Enabled = true;
        }

        private void RefreschReservationList()
        {
            this.cherche_reservations.RefreshAllReservation();
            this.tab_reservation.SelectTab("tab_Overview");
        }

        private void ReservationsForm_Load(object sender, EventArgs e)
        {

        }

        private void DeleteOldReservations()
        {
            DateTime today = DateTime.Now.AddDays(-2);
            BL.Service_réservation.DeleteOldReservations(today);


        }

    }
}
