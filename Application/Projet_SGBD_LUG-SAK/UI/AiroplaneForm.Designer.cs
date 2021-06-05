
namespace UI
{
    partial class AiroplaneForm
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
            this.panelAiroplaneScreen = new System.Windows.Forms.Panel();
            this.bt_add_aircraft = new System.Windows.Forms.Button();
            this.bt_cancel_add = new System.Windows.Forms.Button();
            this.uc_add_aircraft1 = new UI.User_control.uc_add_aircraft();
            this.uc_appList1 = new UI.User_control.uc_appList_del();
            this.uc_modify_aircraft1 = new UI.User_control.uc_modify_aircraft();
            this.panelAiroplaneScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAiroplaneScreen
            // 
            this.panelAiroplaneScreen.Controls.Add(this.uc_modify_aircraft1);
            this.panelAiroplaneScreen.Controls.Add(this.bt_cancel_add);
            this.panelAiroplaneScreen.Controls.Add(this.bt_add_aircraft);
            this.panelAiroplaneScreen.Controls.Add(this.uc_add_aircraft1);
            this.panelAiroplaneScreen.Controls.Add(this.uc_appList1);
            this.panelAiroplaneScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAiroplaneScreen.Location = new System.Drawing.Point(0, 0);
            this.panelAiroplaneScreen.Margin = new System.Windows.Forms.Padding(2);
            this.panelAiroplaneScreen.Name = "panelAiroplaneScreen";
            this.panelAiroplaneScreen.Size = new System.Drawing.Size(967, 600);
            this.panelAiroplaneScreen.TabIndex = 0;
            // 
            // bt_add_aircraft
            // 
            this.bt_add_aircraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add_aircraft.Location = new System.Drawing.Point(178, 511);
            this.bt_add_aircraft.Name = "bt_add_aircraft";
            this.bt_add_aircraft.Size = new System.Drawing.Size(145, 39);
            this.bt_add_aircraft.TabIndex = 2;
            this.bt_add_aircraft.Text = "Add an A/C";
            this.bt_add_aircraft.UseVisualStyleBackColor = true;
            this.bt_add_aircraft.Click += new System.EventHandler(this.bt_add_aircraft_Click);
            // 
            // bt_cancel_add
            // 
            this.bt_cancel_add.Location = new System.Drawing.Point(843, 218);
            this.bt_cancel_add.Name = "bt_cancel_add";
            this.bt_cancel_add.Size = new System.Drawing.Size(108, 23);
            this.bt_cancel_add.TabIndex = 3;
            this.bt_cancel_add.Text = "Cancel And Close";
            this.bt_cancel_add.UseVisualStyleBackColor = true;
            this.bt_cancel_add.Visible = false;
            this.bt_cancel_add.Click += new System.EventHandler(this.bt_cancel_add_Click);
            // 
            // uc_add_aircraft1
            // 
            this.uc_add_aircraft1.Enabled = false;
            this.uc_add_aircraft1.Location = new System.Drawing.Point(610, 12);
            this.uc_add_aircraft1.Name = "uc_add_aircraft1";
            this.uc_add_aircraft1.Size = new System.Drawing.Size(345, 233);
            this.uc_add_aircraft1.TabIndex = 1;
            // 
            // uc_appList1
            // 
            this.uc_appList1.Location = new System.Drawing.Point(0, 4);
            this.uc_appList1.Margin = new System.Windows.Forms.Padding(4);
            this.uc_appList1.Name = "uc_appList1";
            this.uc_appList1.Size = new System.Drawing.Size(606, 600);
            this.uc_appList1.TabIndex = 0;
            this.uc_appList1.Load += new System.EventHandler(this.uc_appList1_Load);
            // 
            // uc_modify_aircraft1
            // 
            this.uc_modify_aircraft1.Location = new System.Drawing.Point(613, 12);
            this.uc_modify_aircraft1.Name = "uc_modify_aircraft1";
            this.uc_modify_aircraft1.Size = new System.Drawing.Size(345, 233);
            this.uc_modify_aircraft1.TabIndex = 4;
            // 
            // AiroplaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 600);
            this.Controls.Add(this.panelAiroplaneScreen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AiroplaneForm";
            this.Text = "AiroplaneForm";
            this.Load += new System.EventHandler(this.AiroplaneForm_Load);
            this.panelAiroplaneScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAiroplaneScreen;
        private User_control.uc_appList_del uc_appList1;
        private User_control.uc_add_aircraft uc_add_aircraft1;
        private System.Windows.Forms.Button bt_add_aircraft;
        private System.Windows.Forms.Button bt_cancel_add;
        private User_control.uc_modify_aircraft uc_modify_aircraft1;
    }
}