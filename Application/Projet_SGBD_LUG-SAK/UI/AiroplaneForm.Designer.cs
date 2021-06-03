
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
            this.uc_appList1 = new UI.User_control.uc_appList();
            this.panelAiroplaneScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAiroplaneScreen
            // 
            this.panelAiroplaneScreen.Controls.Add(this.uc_appList1);
            this.panelAiroplaneScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAiroplaneScreen.Location = new System.Drawing.Point(0, 0);
            this.panelAiroplaneScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAiroplaneScreen.Name = "panelAiroplaneScreen";
            this.panelAiroplaneScreen.Size = new System.Drawing.Size(964, 738);
            this.panelAiroplaneScreen.TabIndex = 0;
            // 
            // uc_appList1
            // 
            this.uc_appList1.Location = new System.Drawing.Point(0, 0);
            this.uc_appList1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uc_appList1.Name = "uc_appList1";
            this.uc_appList1.Size = new System.Drawing.Size(885, 662);
            this.uc_appList1.TabIndex = 0;
            this.uc_appList1.Load += new System.EventHandler(this.uc_appList1_Load);
            // 
            // AiroplaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 738);
            this.Controls.Add(this.panelAiroplaneScreen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AiroplaneForm";
            this.Text = "AiroplaneForm";
            this.Load += new System.EventHandler(this.AiroplaneForm_Load);
            this.panelAiroplaneScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAiroplaneScreen;
        private User_control.uc_appList uc_appList1;
    }
}