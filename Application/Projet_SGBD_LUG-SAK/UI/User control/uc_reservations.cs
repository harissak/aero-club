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
        }

        private void bt_uc_res_search_Click(object sender, EventArgs e)
        {
            this.bs_reservation_list.DataSource = BL.Service_réservation.Read_reservation_by_ID(Convert.ToInt32(this.tb_uc_recherch_res_id.Text));
        }

        private void Reservation_clicked(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_running_reserv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                this.dgv_running_reserv.CurrentRow.Selected = true;    
                
                this.SelectReservation(Int32.Parse(this.dgv_running_reserv.Rows[e.RowIndex].Cells["Res_ID"].FormattedValue.ToString()),
                                        Int32.Parse(this.dgv_running_reserv.Rows[e.RowIndex].Cells["mbr_id"].FormattedValue.ToString()),
                                        Int32.Parse(this.dgv_running_reserv.Rows[e.RowIndex].Cells["app_id"].FormattedValue.ToString()));
               
            }
        }

        private void dgv_running_reserv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void RefreshAllReservation()
        {
            this.bs_reservation_list.DataSource = BL.Service_réservation.Read_all_reservations();
        }
    }
}