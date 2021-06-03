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
            this.md_del_reservation.Visible = false;
        }

        private void ReservationsForm_Load(object sender, EventArgs e)
        {

        }


    }
}
