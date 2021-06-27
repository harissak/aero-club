using DTO;
using System;
using System.Windows.Forms;

namespace UI.User_control
{
    public partial class uc_reservations : UserControl
    {

        public event delSelectReservation SelectReservation;

        public uc_reservations()
        {
            InitializeComponent();
        }      

        private void LoadAllReservation(object sender, EventArgs e)
        {
            RefreshAllReservation();
            this.cb_uc_rechercher_aeronef.DataSource = BL.Services_appareils.Read_all_app();
        }

        private void bt_uc_res_search_Click(object sender, EventArgs e)
        {
            if (this.tb_uc_recherch_res_id.Text != "") 
            {
                this.bs_reservation_list.DataSource = BL.Service_réservation.Read_reservation_by_ID(Convert.ToInt32(this.tb_uc_recherch_res_id.Text));

            } 
            else if (this.cb_uc_rechercher_aeronef.Text != "")
            {
                int appID = BL.Services_appareils.search_app_by_desc(this.cb_uc_rechercher_aeronef.Text).APP_ID();

                this.bs_reservation_list.DataSource = BL.Service_réservation.Read_reservations_by_app_id(appID);

            }
            else
            {
                this.bs_reservation_list.DataSource = BL.Service_réservation.Read_all_reservations();
            }
        }

        private void Reservation_clicked(object sender, DataGridViewCellEventArgs e)
        {
            int test = e.ColumnIndex;
            int test2 = e.RowIndex;
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (this.dgv_running_reserv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)//
                {
                    this.dgv_running_reserv.CurrentRow.Selected = true;

                    this.SelectReservation(Int32.Parse(this.dgv_running_reserv.Rows[e.RowIndex].Cells["Res_ID"].FormattedValue.ToString()),
                                            Int32.Parse(this.dgv_running_reserv.Rows[e.RowIndex].Cells["mbr_id"].FormattedValue.ToString()),
                                            Int32.Parse(this.dgv_running_reserv.Rows[e.RowIndex].Cells["app_id"].FormattedValue.ToString()));

                }
                else
                {

                }
            }
                
        }

        private void dgv_running_reserv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void RefreshAllReservation()
        {
            this.bs_reservation_list.DataSource = BL.Service_réservation.Read_all_reservations();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            RefreshAllReservation();
            this.tb_uc_recherch_res_id.Text = "";
        }
    }
}