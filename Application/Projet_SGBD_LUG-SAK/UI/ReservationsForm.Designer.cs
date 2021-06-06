
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
            this.tab_reservation = new System.Windows.Forms.TabControl();
            this.tab_Overview = new System.Windows.Forms.TabPage();
            this.tab_new_reservation = new System.Windows.Forms.TabPage();
            this.cherche_reservations = new UI.User_control.uc_reservations();
            this.uc_add_new_reservation1 = new UI.User_control.uc_add_new_reservation();
            this.panelReservationsScreen.SuspendLayout();
            this.tab_reservation.SuspendLayout();
            this.tab_Overview.SuspendLayout();
            this.tab_new_reservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReservationsScreen
            // 
            this.panelReservationsScreen.Controls.Add(this.tab_reservation);
            this.panelReservationsScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReservationsScreen.Location = new System.Drawing.Point(0, 0);
            this.panelReservationsScreen.Margin = new System.Windows.Forms.Padding(2);
            this.panelReservationsScreen.Name = "panelReservationsScreen";
            this.panelReservationsScreen.Size = new System.Drawing.Size(1016, 596);
            this.panelReservationsScreen.TabIndex = 0;
            // 
            // tab_reservation
            // 
            this.tab_reservation.Controls.Add(this.tab_Overview);
            this.tab_reservation.Controls.Add(this.tab_new_reservation);
            this.tab_reservation.Location = new System.Drawing.Point(3, 3);
            this.tab_reservation.Name = "tab_reservation";
            this.tab_reservation.SelectedIndex = 0;
            this.tab_reservation.Size = new System.Drawing.Size(1016, 590);
            this.tab_reservation.TabIndex = 5;
            // 
            // tab_Overview
            // 
            this.tab_Overview.Controls.Add(this.cherche_reservations);
            this.tab_Overview.Location = new System.Drawing.Point(4, 22);
            this.tab_Overview.Name = "tab_Overview";
            this.tab_Overview.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Overview.Size = new System.Drawing.Size(1008, 564);
            this.tab_Overview.TabIndex = 0;
            this.tab_Overview.Text = "Overview";
            this.tab_Overview.UseVisualStyleBackColor = true;
            // 
            // tab_new_reservation
            // 
            this.tab_new_reservation.Controls.Add(this.uc_add_new_reservation1);
            this.tab_new_reservation.Location = new System.Drawing.Point(4, 22);
            this.tab_new_reservation.Name = "tab_new_reservation";
            this.tab_new_reservation.Padding = new System.Windows.Forms.Padding(3);
            this.tab_new_reservation.Size = new System.Drawing.Size(1008, 555);
            this.tab_new_reservation.TabIndex = 1;
            this.tab_new_reservation.Text = "Nouvelle reservation";
            this.tab_new_reservation.UseVisualStyleBackColor = true;
            // 
            // cherche_reservations
            // 
            this.cherche_reservations.Location = new System.Drawing.Point(3, 3);
            this.cherche_reservations.Name = "cherche_reservations";
            this.cherche_reservations.Size = new System.Drawing.Size(530, 545);
            this.cherche_reservations.TabIndex = 2;
            // 
            // uc_add_new_reservation1
            // 
            this.uc_add_new_reservation1.Location = new System.Drawing.Point(5, 5);
            this.uc_add_new_reservation1.Margin = new System.Windows.Forms.Padding(2);
            this.uc_add_new_reservation1.Name = "uc_add_new_reservation1";
            this.uc_add_new_reservation1.Size = new System.Drawing.Size(333, 413);
            this.uc_add_new_reservation1.TabIndex = 5;
            // 
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 596);
            this.Controls.Add(this.panelReservationsScreen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReservationsForm";
            this.Text = "ReservationsForm";
            this.Load += new System.EventHandler(this.ReservationsForm_Load);
            this.panelReservationsScreen.ResumeLayout(false);
            this.tab_reservation.ResumeLayout(false);
            this.tab_Overview.ResumeLayout(false);
            this.tab_new_reservation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReservationsScreen;
        private System.Windows.Forms.TabControl tab_reservation;
        private System.Windows.Forms.TabPage tab_Overview;
        private System.Windows.Forms.TabPage tab_new_reservation;
        private User_control.uc_add_new_reservation uc_add_new_reservation1;
        private User_control.uc_reservations cherche_reservations;
    }
}