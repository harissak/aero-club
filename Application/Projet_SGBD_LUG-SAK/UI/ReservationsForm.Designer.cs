
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
            this.SuspendLayout();
            // 
            // panelReservationsScreen
            // 
            this.panelReservationsScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReservationsScreen.Location = new System.Drawing.Point(0, 0);
            this.panelReservationsScreen.Name = "panelReservationsScreen";
            this.panelReservationsScreen.Size = new System.Drawing.Size(800, 450);
            this.panelReservationsScreen.TabIndex = 0;
            this.panelReservationsScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.panelReservations_Paint);
            // 
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelReservationsScreen);
            this.Name = "ReservationsForm";
            this.Text = "ReservationsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReservationsScreen;
    }
}