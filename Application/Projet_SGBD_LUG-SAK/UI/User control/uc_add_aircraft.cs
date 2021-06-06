using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace UI.User_control
{
    public partial class uc_add_aircraft : UserControl
    {
        
        public uc_add_aircraft()
        {
            InitializeComponent();
            PopulateCBClass();
        }

        private void PopulateCBClass()
        {
            this.cb_add_app_class.Items.Add("1");
            this.cb_add_app_class.Items.Add("2");
            this.cb_add_app_class.Items.Add("3");
            this.cb_add_app_class.Items.Add("4");
            this.cb_add_app_class.Items.Add("5");
            this.cb_add_app_class.Items.Add("6");

            this.cb_add_app_class.SelectedIndex = 0;
        }

        private void cb_add_app_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cb_add_app_class.SelectedIndex)
            {
                case 0: this.lb_add_app_classInfo.Text = "(Paramoteurs)";
                    break;
                case 1: this.lb_add_app_classInfo.Text = "(Pendulaires)";
                    break;
                case 2: this.lb_add_app_classInfo.Text = "(3 axes)";
                    break;
                case 3: this.lb_add_app_classInfo.Text = "(Autogires)";
                    break;
                default: this.lb_add_app_classInfo.Text = "(Not in use)";
                    break;
            }
        }

        private void bt_add_app_Click(object sender, EventArgs e)
        {
            try
            {
                BL.Services_appareils.Add_new_app(
                    new APP
                    {
                        App_imma = this.tb_add_app_imma.Text,
                        App_classe = this.cb_add_app_class.SelectedItem.ToString(),
                        App_descr = this.tb_add_app_descr.Text
                    });
                ResetAddControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show((ex.Message),
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ResetAddControl()
        {
            this.tb_add_app_imma.Text = "";
            this.cb_add_app_class.SelectedIndex = 0;
            this.tb_add_app_descr.Text = "";
        }
    }
}
