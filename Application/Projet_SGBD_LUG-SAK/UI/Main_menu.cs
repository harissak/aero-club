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
    public partial class Main_menu : Form
    {
        private Form currentForm;
        public Main_menu()
        {
            InitializeComponent();
        }



        private void btnReservation_Click(object sender, EventArgs e)
        {
            this.OpenNewWindow(new ReservationsForm());
            this.lblTitle.Text = "RESERVATIONS";
            this.btnReservation.BackColor = Color.FromArgb(153, 163, 164);
            this.panelTitleBar.BackColor = Color.FromArgb(153, 163, 164);
            btnColors(this.btnMembers, this.btnSettings, this.btnManual, this.btnAiroPlane, this.btnMembers);

        }

        private void btnMembers_Click(object sender, EventArgs e)
        {

            this.OpenNewWindow(new MembersForm());
            this.lblTitle.Text = "MEMBERS";
            this.btnMembers.BackColor = Color.FromArgb(220, 118, 51);
            this.panelTitleBar.BackColor = Color.FromArgb(220, 118, 51);
            btnColors(this.btnReservation, this.btnSettings, this.btnManual, this.btnAiroPlane, this.btnReservation);

        }

        private void btnAiroPlane_Click(object sender, EventArgs e)
        {
            this.OpenNewWindow(new AiroplaneForm());
            this.lblTitle.Text = "AIRCRAFTS";
            this.btnAiroPlane.BackColor = Color.FromArgb(88, 214, 141);
            this.panelTitleBar.BackColor = Color.FromArgb(88, 214, 141);
            btnColors(this.btnReservation, this.btnSettings, this.btnManual, this.btnMembers, this.btnReservation);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.OpenNewWindow(new LicenceForm());
            this.lblTitle.Text = "LICENCES";
            this.btnSettings.BackColor = Color.FromArgb(93, 173, 226);
            this.panelTitleBar.BackColor = Color.FromArgb(93, 173, 226);
            btnColors(this.btnReservation, this.btnMembers, this.btnManual, this.btnAiroPlane, this.btnReservation);

        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            this.OpenNewWindow(new ManualForm());
            this.lblTitle.Text = "MANUAL";
            this.btnManual.BackColor = Color.FromArgb(165, 105, 189);
            this.panelTitleBar.BackColor = Color.FromArgb(165, 105, 189);
            btnColors(this.btnReservation, this.btnSettings, this.btnMembers, this.btnAiroPlane, this.btnReservation);

        }

        private void panelHome_click(object sender, EventArgs e)
        {
            if (this.currentForm != null)
                this.currentForm.Close();
            this.lblTitle.Text = "ULM EFPL";
            this.panelTitleBar.BackColor = Color.FromArgb(127, 179, 213);
            btnColors(this.btnReservation, this.btnSettings, this.btnManual, this.btnAiroPlane, this.btnMembers);

        }

        private void btnColors(Button btn1, Button btn2, Button btn3, Button btn4, Button btn5)
        {
            btn1.BackColor = Color.FromArgb(43, 69, 216);
            btn2.BackColor = Color.FromArgb(43, 69, 216);
            btn3.BackColor = Color.FromArgb(43, 69, 216);
            btn4.BackColor = Color.FromArgb(43, 69, 216);
            btn5.BackColor = Color.FromArgb(43, 69, 216);

        }

        private void OpenNewWindow(Form newWindow)
        {
            if (this.currentForm != null)
                this.currentForm.Close();

            this.currentForm = newWindow;
            newWindow.TopLevel = false;
            newWindow.FormBorderStyle = FormBorderStyle.None;
            newWindow.Dock = DockStyle.Fill;
            this.panelHomeScreen.Controls.Add(newWindow);
            newWindow.BringToFront();
            newWindow.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_menu_Load(object sender, EventArgs e)
        {

        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
