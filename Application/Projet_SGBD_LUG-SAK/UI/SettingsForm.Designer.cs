
namespace UI
{
    partial class SettingsForm
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
            this.panelSettingsScreen = new System.Windows.Forms.Panel();
            this.tab_settings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tab_settings_page2 = new System.Windows.Forms.TabPage();
            this.setting_uc_licenses_list = new UI.User_control.uc_licenses_list();
            this.panelSettingsScreen.SuspendLayout();
            this.tab_settings.SuspendLayout();
            this.tab_settings_page2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSettingsScreen
            // 
            this.panelSettingsScreen.Controls.Add(this.tab_settings);
            this.panelSettingsScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettingsScreen.Location = new System.Drawing.Point(0, 0);
            this.panelSettingsScreen.Margin = new System.Windows.Forms.Padding(2);
            this.panelSettingsScreen.Name = "panelSettingsScreen";
            this.panelSettingsScreen.Size = new System.Drawing.Size(1018, 688);
            this.panelSettingsScreen.TabIndex = 0;
            // 
            // tab_settings
            // 
            this.tab_settings.Controls.Add(this.tabPage1);
            this.tab_settings.Controls.Add(this.tab_settings_page2);
            this.tab_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_settings.Location = new System.Drawing.Point(4, 0);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.SelectedIndex = 0;
            this.tab_settings.Size = new System.Drawing.Size(1014, 676);
            this.tab_settings.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1006, 647);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tab_settings_page2
            // 
            this.tab_settings_page2.Controls.Add(this.setting_uc_licenses_list);
            this.tab_settings_page2.Location = new System.Drawing.Point(4, 25);
            this.tab_settings_page2.Name = "tab_settings_page2";
            this.tab_settings_page2.Padding = new System.Windows.Forms.Padding(3);
            this.tab_settings_page2.Size = new System.Drawing.Size(1006, 647);
            this.tab_settings_page2.TabIndex = 1;
            this.tab_settings_page2.Text = "Flight Licenses Management";
            this.tab_settings_page2.UseVisualStyleBackColor = true;
            // 
            // setting_uc_licenses_list
            // 
            this.setting_uc_licenses_list.Location = new System.Drawing.Point(0, 7);
            this.setting_uc_licenses_list.Margin = new System.Windows.Forms.Padding(4);
            this.setting_uc_licenses_list.Name = "setting_uc_licenses_list";
            this.setting_uc_licenses_list.Size = new System.Drawing.Size(982, 599);
            this.setting_uc_licenses_list.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 688);
            this.Controls.Add(this.panelSettingsScreen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.panelSettingsScreen.ResumeLayout(false);
            this.tab_settings.ResumeLayout(false);
            this.tab_settings_page2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSettingsScreen;
        private System.Windows.Forms.TabControl tab_settings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tab_settings_page2;
        private User_control.uc_licenses_list setting_uc_licenses_list;
    }
}