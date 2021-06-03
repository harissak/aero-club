
namespace UI
{
    partial class ReservationsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelReservationsScreen = new System.Windows.Forms.Panel();
            this.md_del_reservation = new UI.User_control.uc_md_del_reservation();
            this.add_new_reservation = new UI.User_control.uc_add_new_reservation();
            this.cherche_reservations = new UI.User_control.uc_reservations();
            this.panelReservationsScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReservationsScreen
            // 
            this.panelReservationsScreen.Controls.Add(this.md_del_reservation);
            this.panelReservationsScreen.Controls.Add(this.add_new_reservation);
            this.panelReservationsScreen.Controls.Add(this.cherche_reservations);
            this.panelReservationsScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReservationsScreen.Location = new System.Drawing.Point(0, 0);
            this.panelReservationsScreen.Name = "panelReservationsScreen";
            this.panelReservationsScreen.Size = new System.Drawing.Size(1354, 734);
            this.panelReservationsScreen.TabIndex = 0;
            // 
            // md_del_reservation
            // 
            this.md_del_reservation.Location = new System.Drawing.Point(855, 53);
            this.md_del_reservation.Name = "md_del_reservation";
            this.md_del_reservation.Size = new System.Drawing.Size(317, 634);
            this.md_del_reservation.TabIndex = 4;
            // 
            // add_new_reservation
            // 
            this.add_new_reservation.Location = new System.Drawing.Point(858, 53);
            this.add_new_reservation.Name = "add_new_reservation";
            this.add_new_reservation.Size = new System.Drawing.Size(324, 644);
            this.add_new_reservation.TabIndex = 3;
            // 
            // cherche_reservations
            // 
            this.cherche_reservations.Location = new System.Drawing.Point(12, 0);
            this.cherche_reservations.Name = "cherche_reservations";
            this.cherche_reservations.Size = new System.Drawing.Size(707, 744);
            this.cherche_reservations.TabIndex = 2;
            // 
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 734);
            this.Controls.Add(this.panelReservationsScreen);
            this.Name = "ReservationsForm";
            this.Text = "ReservationsForm";
            this.Load += new System.EventHandler(this.ReservationsForm_Load);
            this.panelReservationsScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReservationsScreen;
        private User_control.uc_reservations cherche_reservations;
        private User_control.uc_add_new_reservation add_new_reservation;
        private User_control.uc_md_del_reservation md_del_reservation;
    }
}